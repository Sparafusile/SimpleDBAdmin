using System;
using Npgsql;
using System.Linq;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

/*
 * Microsoft SQL Server
 * Microsoft Access
 * PostgreSQL
 * MySQL
 * SQLite
 * MongoDB
 * SimpleDB
 * DynamoDB
 * Redis
*/

namespace SimpleDBAdmin
{
    public partial class ExportToDatabaseDialog : Form
    {
        private readonly System.Drawing.Font ControllFont = new System.Drawing.Font( "Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );

        private string Domain { get; set; }

        private SimpleDBContext db { get; set; }

        private Dictionary<string, int> Attributes { get; set; }

        private List<ColumnMapping> ColumnMap { get; set; }

        #region Connections
        private string ConnectionType { get; set; }

        private SqlConnection SqlServerConnection { get; set; }

        private OleDbConnection AccessConnection { get; set; }

        private NpgsqlConnection PostgreSQLConnection { get; set; }

        private MySqlConnection MySqlConnection { get; set; }

        private SQLiteConnection SQLiteConnection { get; set; }
        #endregion

        public ExportToDatabaseDialog( SimpleDBContext Context, string Domain )
        {
            InitializeComponent();
            this.db = Context;
            this.Domain = Domain;
            this.lblSource.Text = this.Domain;
            this.query.Text = @"SELECT * FROM `" + this.Domain + @"`";
        }

        public new void Dispose()
        {
            base.Dispose();

            if( this.SqlServerConnection != null ) this.SqlServerConnection.Dispose();
            if( this.AccessConnection != null ) this.AccessConnection.Dispose();
            if( this.PostgreSQLConnection != null ) this.PostgreSQLConnection.Dispose();
            if( this.MySqlConnection != null ) this.MySqlConnection.Dispose();
            if( this.SQLiteConnection != null ) this.SQLiteConnection.Dispose();
        }

        private bool Connect()
        {
            try
            {
                this.tables.Items.Clear();
                switch( databaseType.SelectedItem.ToString() )
                {
                    case "Microsoft SQL Server":
                        this.SqlServerConnection = new SqlConnection( this.connectionString.Text );
                        this.SqlServerConnection.Open();
                        using( var cmd = this.SqlServerConnection.CreateCommand() )
                        {
                            cmd.CommandText = "SELECT TABLE_SCHEMA + '.' + TABLE_NAME FROM INFORMATION_SCHEMA.TABLES " +
                                              "WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY TABLE_SCHEMA, TABLE_NAME;";

                            using( var reader = cmd.ExecuteReader() )
                                while( reader.Read() )
                                    this.tables.Items.Add( reader.GetString( 0 ) );
                        }
                        break;

                    case "Microsoft Access":
                        this.AccessConnection = new OleDbConnection( this.connectionString.Text );
                        this.AccessConnection.Open();
                        break;

                    case "PostgreSQL":
                        this.PostgreSQLConnection = new NpgsqlConnection( this.connectionString.Text );
                        this.PostgreSQLConnection.Open();
                        using( var cmd = this.PostgreSQLConnection.CreateCommand() )
                        {
                            cmd.CommandText = "SELECT table_schema || '.' || table_name FROM information_schema.tables " +
                                              "WHERE table_schema NOT IN ( 'pg_catalog', 'information_schema' )";

                            using( var reader = cmd.ExecuteReader() )
                                while( reader.Read() )
                                    this.tables.Items.Add( reader.GetString( 0 ) );
                        }
                        break;

                    case "MySQL":
                        this.MySqlConnection = new MySqlConnection( this.connectionString.Text );
                        this.MySqlConnection.Open();
                        break;

                    case "SQLite":
                        this.SQLiteConnection = new SQLiteConnection( this.connectionString.Text );
                        this.SQLiteConnection.Open();

                        using( var cmd = this.SQLiteConnection.CreateCommand() )
                        {
                            cmd.CommandText = "SELECT name FROM sqlite_master WHERE type = \"table\"";

                            using( var reader = cmd.ExecuteReader() )
                                while( reader.Read() )
                                    this.tables.Items.Add( reader.GetString( 0 ) );
                        }
                        break;

                    case "MongoDB":
                        break;

                    case "SimpleDB":
                        break;

                    case "DynamoDB":
                        break;
                }

                this.ConnectionType = databaseType.SelectedItem.ToString();

                return true;
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.Message, @"Could not establish a connection", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
        }

        private List<string> GetDestinationColumns()
        {
            var list = new List<string>();
            if( this.tables.SelectedItem == null ) return list;

            var parts = this.tables.SelectedItem.ToString().Split( '.' );
            string schema = parts[0], table = parts.Length >= 2 ? parts[1] : null;

            switch( this.ConnectionType )
            {
                case "Microsoft SQL Server":
                    using( var cmd = this.SqlServerConnection.CreateCommand() )
                    {
                        cmd.CommandText = "SELECT Name FROM sys.columns WHERE object_id = OBJECT_ID('" + schema + "." + table + "') ORDER BY Name;";

                        using( var reader = cmd.ExecuteReader() )
                            while( reader.Read() )
                                list.Add( reader.GetString( 0 ) );
                    }
                    break;

                case "PostgreSQL":
                    using( var cmd = this.PostgreSQLConnection.CreateCommand() )
                    {
                        cmd.CommandText = "select column_name from information_schema.columns where table_schema='" + schema + "' and table_name='" + table + "';";

                        using( var reader = cmd.ExecuteReader() )
                            while( reader.Read() )
                                list.Add( reader.GetString( 0 ) );
                    }
                    break;

                case "SQLite":
                    using( var cmd = this.SQLiteConnection.CreateCommand() )
                    {
                        cmd.CommandText = "SELECT * FROM \"ApiLogs_20140131182419\" LIMIT 0;";

                        using( var reader = cmd.ExecuteReader() )
                        {
                            for( var i = 0 ; i < reader.FieldCount ; i++ )
                                list.Add( reader.GetName( i ) );
                        }
                    }
                    break;
            }

            return list;
        }

        private void DisplayColumnMap()
        {
            var destinationColumns = GetDestinationColumns().ToArray();
            var sourceAttributes =
            (
                from kvp in this.Attributes
                from i in Enumerable.Range( 0, kvp.Value )
                select new ColumnMapping
                {
                    IsDuplicate = kvp.Value > 1,
                    Source = kvp.Key, SourceIndex = i,
                }
            );

            // Remove all but the header row from the column map table
            while( this.columnMapTable.RowCount > 1 )
            {
                this.columnMapTable.RowStyles.RemoveAt( 1 );
                this.columnMapTable.RowCount--;
            }

            // Add a row for each domain attribute
            foreach( var c in sourceAttributes )
            {
                // Add a label for the source attribute
                var label = new Label
                {
                    Tag = c,
                    Font = ControllFont,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                    Text = c.Source + ( c.IsDuplicate ? " (" + ( c.SourceIndex + 1 ) + ")" : string.Empty ),
                };
                this.columnMapTable.Controls.Add( label, 0, this.columnMapTable.RowCount );

                // Add a combo box for the destination column
                var combo = new ComboBox
                {
                    Sorted = true,
                    Font = ControllFont,
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                };
                combo.Items.AddRange( Array.ConvertAll( destinationColumns, m => (object)m ) );
                combo.SelectedIndex = combo.Items.IndexOf( label.Text );
                this.columnMapTable.Controls.Add( combo, 1, this.columnMapTable.RowCount );

                this.columnMapTable.RowCount++;
            }

            // Set the size of all the rows
            foreach( RowStyle s in this.columnMapTable.RowStyles )
            {
                s.SizeType = SizeType.Absolute;
                s.Height = 35; 
            }
        }

        private void CreateColumnMap()
        {
            this.ColumnMap = new List<ColumnMapping>();
            for( var i = 1 ; i < this.columnMapTable.RowCount ; i++ )
            {
                // Make sure the objects in the table are the correct type
                var label = this.columnMapTable.GetControlFromPosition( 0, i ) as Label;
                var combo = this.columnMapTable.GetControlFromPosition( 1, i ) as ComboBox;
                if( label == null || combo == null || combo.SelectedItem == null ) continue;

                // The 'Tag' property of the label is a ColumnMapping object set earlier
                var m = label.Tag as ColumnMapping;
                if( m == null ) continue;

                // Add the mapping to the list
                m.Destination = combo.SelectedItem.ToString();
                this.ColumnMap.Add( m );
            }
        }

        private List<ColumnMapping> GetCreateTableSCript( out string TableName, out string CreateScript )
        {
            TableName = this.Domain;

            var mapping =
            (
                from kvp in this.Attributes
                from i in Enumerable.Range( 1, kvp.Value )
                select new ColumnMapping
                {
                    Source = kvp.Key,
                    SourceIndex = i - 1,
                    IsDuplicate = kvp.Value != 1,
                    Destination = kvp.Key + ( kvp.Value == 1 ? string.Empty : "_" + i )
                }
            )
            .ToList();

            switch( this.ConnectionType )
            {
                case "Microsoft Access":
                case "Microsoft SQL Server":
                    CreateScript = "CREATE TABLE [" + TableName + "]\n(\n" +
                        string.Join( ",\n", from c in mapping select "    [" + c.Destination + "] NVARCHAR (1024) NULL" ) + "\n);";
                    break;

                case "PostgreSQL":
                    CreateScript = "CREATE TABLE \"" + TableName + "\"\n(\n" +
                        string.Join( ",\n", from c in mapping select "    \"" + c.Destination + "\" VARCHAR (1024) NULL" ) + "\n);";
                    break;

                case "SQLite":
                    CreateScript = "CREATE TABLE \"" + TableName.Replace( ".", "_" ).Replace( "-", "_" ) + "\"\n(\n" +
                        string.Join( ",\n", from c in mapping select "    \"" + c.Destination.Replace( ".", "_" ).Replace( "-", "_" ) + "\" VARCHAR (1024) NULL" ) + "\n);";
                    break;

                case "MySQL":
                    CreateScript = "CREATE TABLE `" + TableName + "`\n(\n" +
                        string.Join( ",\n", from c in mapping select "    `" + c.Destination + "` VARCHAR (1024) NULL" ) + "\n);";
                    break;

                default:
                    CreateScript = null;
                    break;
            }

            return mapping;
        }

        public int ImportToDestination()
        {
            var total = 0;
            string schema = null, table, create = null;

            if( this.tables.SelectedItem == null )
            {
                if( !string.IsNullOrEmpty( this.createTable.Text ) )
                {
                    create = this.createTable.Text;
                    table = "UnknownTableName";
                }
                else
                {
                    this.ColumnMap = GetCreateTableSCript( out table, out create );
                }
            }
            else
            {
                var parts = this.tables.SelectedItem.ToString().Split( '.' );
                table = parts.Length >= 2 ? parts[1] : parts[0];
                schema = parts.Length >= 2 ? parts[0] : null;
            }

            try
            {
                switch( this.ConnectionType )
                {
                    case "Microsoft SQL Server":
                        #region Microsoft SQL Server
                        using( var cmd = this.SqlServerConnection.CreateCommand() )
                        {
                            // Create the destination table
                            if( !string.IsNullOrEmpty( create ) )
                            {
                                cmd.CommandText = create;
                                cmd.ExecuteNonQuery();
                            }

                            // The default schema is dbo
                            if( string.IsNullOrEmpty( schema ) ) schema = "dbo";

                            // SQL Server allows you to insert up to 1,000 rows at a time.
                            // This is the first part of the insert statement with the
                            // destination schema, table, and column list.
                            var sql = "INSERT INTO [" + schema + "].[" + table + "] ( " + string.Join( ", ", from kvp in this.ColumnMap select "[" + kvp.Destination + "]" ) + " ) VALUES\n";

                            // Re-open the temp table and read the items saved in it
                            using( var dataFile = System.IO.File.OpenRead( this.targetFile.Text ) )
                            {
                                var items = dataFile.ReadSimpleDBItems();

                                // Read items from the file up to 1,000 at a time and build an insert statement to execute
                                for( var subList = items.Take( 1000 ).ToList() ; subList.Count > 0 ; subList = items.Take( 1000 ).ToList() )
                                {
                                    // Build the part of the insert statement that has
                                    // that values for each row to be inserted.
                                    var values = string.Join
                                    (
                                        ",\n",
                                        from item in subList
                                        select "(" + string.Join
                                        (
                                            ", ",
                                            from map in this.ColumnMap
                                            select "N'" + ( item[map.Source, map.SourceIndex] ?? string.Empty ).Replace( "'", "''" ) + "'"
                                        ) + ")"
                                    );

                                    // Execute the insert statement
                                    cmd.CommandText = sql + values + ";";
                                    total += cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        break;
                        #endregion

                    case "PostgreSQL":
                        #region PostgreSQL
                        using( var cmd = this.PostgreSQLConnection.CreateCommand() )
                        {
                            // Create the destination table
                            if( !string.IsNullOrEmpty( create ) )
                            {
                                cmd.CommandText = create;
                                cmd.ExecuteNonQuery();
                            }

                            // The default schema is dbo
                            if( string.IsNullOrEmpty( schema ) ) schema = "public";

                            // SQL Server allows you to insert up to 1,000 rows at a time.
                            // This is the first part of the insert statement with the
                            // destination schema, table, and column list.
                            var sql = "INSERT INTO \"" + schema + "\".\"" + table + "\" ( " + string.Join( ", ", from kvp in this.ColumnMap select "\"" + kvp.Destination + "\"" ) + " ) VALUES\n";

                            // Re-open the temp table and read the items saved in it
                            using( var dataFile = System.IO.File.OpenRead( this.targetFile.Text ) )
                            {
                                var items = dataFile.ReadSimpleDBItems();

                                // Read items from the file up to 1,000 at a time and build an insert statement to execute
                                for( var subList = items.Take( 1000 ).ToList() ; subList.Count > 0 ; subList = items.Take( 1000 ).ToList() )
                                {
                                    // Build the part of the insert statement that has
                                    // that values for each row to be inserted.
                                    var values = string.Join
                                    (
                                        ",\n",
                                        from item in subList
                                        select "(" + string.Join
                                        (
                                            ", ",
                                            from map in this.ColumnMap
                                            select "'" + ( item[map.Source, map.SourceIndex] ?? string.Empty ).Replace( "'", "''" ) + "'"
                                        ) + ")"
                                    );

                                    // Execute the insert statement
                                    cmd.CommandText = sql + values + ";";
                                    total += cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        break;
                        #endregion

                    case "SQLite":
                        #region SQLite
                        using( var cmd = this.SQLiteConnection.CreateCommand() )
                        {
                            // Create the destination table
                            if( !string.IsNullOrEmpty( create ) )
                            {
                                cmd.CommandText = create;
                                cmd.ExecuteNonQuery();
                            }

                            // SQL Server allows you to insert up to 1,000 rows at a time.
                            // This is the first part of the insert statement with the
                            // destination schema, table, and column list.
                            var sql = "INSERT INTO \"" + table.Replace( ".", "_" ).Replace( "-", "_" ) + "\" ( " + string.Join( ", ", from kvp in this.ColumnMap select "\"" + kvp.Destination.Replace( ".", "_" ).Replace( "-", "_" ) + "\"" ) + " ) VALUES\n";

                            // Re-open the temp table and read the items saved in it
                            using( var dataFile = System.IO.File.OpenRead( this.targetFile.Text ) )
                            {
                                var items = dataFile.ReadSimpleDBItems();

                                // Read items from the file up to 1,000 at a time and build an insert statement to execute
                                for( var subList = items.Take( 1000 ).ToList() ; subList.Count > 0 ; subList = items.Take( 1000 ).ToList() )
                                {
                                    // Build the part of the insert statement that has
                                    // that values for each row to be inserted.
                                    var values = string.Join
                                    (
                                        ",\n",
                                        from item in subList
                                        select "(" + string.Join
                                        (
                                            ", ",
                                            from map in this.ColumnMap
                                            select "'" + ( item[map.Source, map.SourceIndex] ?? string.Empty ).Replace( "'", "''" ) + "'"
                                        ) + ")"
                                    );

                                    // Execute the insert statement
                                    cmd.CommandText = sql + values + ";";
                                    total += cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        break;
                        #endregion
                }

            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.Message, @"Could not insert into destination", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            return total;
        }

        #region Event Handlers
        private void Cancel_Click( object sender, EventArgs e )
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void panel1Next_Click( object sender, EventArgs e )
        {
            if( this.Connect() ) this.tabControl1.SelectedIndex = 1;
        }

        private void panel2Previous_Click( object sender, EventArgs e )
        {
            this.tabControl1.SelectedIndex = 0;
        }

        private void panel2Next_Click( object sender, EventArgs e )
        {
            this.lblDestination.Text =
                this.tables.SelectedItem != null
                    ? this.tables.SelectedItem.ToString()
                    : @"(New Table)";

            this.tabControl1.SelectedIndex = 2;
        }

        private void panel3Previous_Click( object sender, EventArgs e )
        {
            this.tabControl1.SelectedIndex = 1;
        }

        private void panel3Next_Click( object sender, EventArgs e )
        {
            try
            {
                this.Attributes =
                    this.db.Select( this.query.Text )
                    .WriteToFile( this.targetFile.Text );

                this.DisplayColumnMap();

                this.tabControl1.SelectedIndex = 3;
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.Message, @"Could not write domain data to file", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void panel4Previous_Click( object sender, EventArgs e )
        {
            this.tabControl1.SelectedIndex = 2;
        }

        private void panel4Next_Click( object sender, EventArgs e )
        {
            this.CreateColumnMap();
            this.lblColumns.Text = this.ColumnMap.Count + @" of " + ( this.columnMapTable.RowCount - 1 );
            this.tabControl1.SelectedIndex = 4;
        }

        private void panel5Previous_Click( object sender, EventArgs e )
        {
            this.tabControl1.SelectedIndex = 3;
        }

        private void Export_Click( object sender, EventArgs e )
        {
            var total = this.ImportToDestination();
            MessageBox.Show( total + @" records were successfully exported.", @"Successful Export", MessageBoxButtons.OK, MessageBoxIcon.Information );
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void browseButton_Click( object sender, EventArgs e )
        {
            var d = new SaveFileDialog
            {
                DefaultExt = ".data",
                CheckPathExists = true,
                Filter = @"Data Files (*.data)|*.data|All Files (*.*)|*.*"
            };

            if( d.ShowDialog() != System.Windows.Forms.DialogResult.OK ) return;
            this.targetFile.Text = d.FileName;
        }
        #endregion

        private class ColumnMapping
        {
            /// <summary>
            /// The source attribute in the domain
            /// </summary>
            public string Source { get; set; }

            /// <summary>
            /// The destination column in the target table
            /// </summary>
            public string Destination { get; set; }

            /// <summary>
            /// If there are multiple source attributes with
            /// the same name, this is the zero-based index
            /// for this specific one.
            /// </summary>
            public int SourceIndex { get; set; }

            /// <summary>
            /// Indicates if this source attribute is one of
            /// multiple with the same name.
            /// </summary>
            public bool IsDuplicate { get; set; }
        }
    }
}
