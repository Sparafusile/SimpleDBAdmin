using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace SimpleDBAdmin
{
    public partial class Main : Form
    {
        #region Constants
        private const string AesKey = "Uk4T0f9mpc7XuAsHgrO223zgrwvR8taAyzFZWoXLyGg=";

        private const string AesIV = "mLGwr8pbunnyrt6vz0NcTg==";

        private readonly Regex DomainNameFromQuery = new Regex( @"(?<from>FROM)(?<spaces>\s+)((?<domain>[\w-\.]+)|`(?<domain>[\w-\.]+)`)", RegexOptions.IgnoreCase | RegexOptions.Singleline );
        #endregion

        #region Properties
        private List<AwsCredentials> AwsCredentials { get; set; }

        private AwsCredentials Credentials { get; set; }

        private Dictionary<string, DomainMetaData> DomainMetaData { get; set; }

        private DomainFilterDialog FilterDialog { get; set; }

        private TreeNode HiddenNodes { get; set; }

        private SimpleDBContext db { get; set; }
        #endregion

        public Main()
        {
            InitializeComponent();
            this.LoadSettings();
            this.FilterDialog = new DomainFilterDialog
            {
                StartPosition = FormStartPosition.CenterParent
            };
        }

        private void Connect()
        {
            new ConnectDialog( this, this.AwsCredentials ) { StartPosition = FormStartPosition.CenterParent }.ShowDialog();
        }

        private void Disconnect()
        {
            this.db = null;
            this.Credentials = null;
            this.domainList.Nodes.Clear();
            this.DomainMetaData = new Dictionary<string, DomainMetaData>();
        }

        public void Authorize( AwsCredentials c )
        {
            if( this.AwsCredentials == null )
            {
                this.AwsCredentials = new List<AwsCredentials>();
            }

            var existing = this.AwsCredentials.FirstOrDefault( m => m.Key.Equals( c.Key ) && m.ServiceUrl.Equals( c.ServiceUrl, StringComparison.OrdinalIgnoreCase ) );
            if( existing != null )
            {
                existing.Name = c.Name;
                existing.Secret = c.Secret;
            }
            else
            {
                this.AwsCredentials.Add( c );
            }

            try
            {
                this.db = new SimpleDBContext( c.Key, c.Secret, c.ServiceUrl );
                this.DomainMetaData = new Dictionary<string, DomainMetaData>();
                this.Credentials = c;
                this.LoadDomains();
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.Message, @"Could not connect to AWS SimpleDB", MessageBoxButtons.OK );
            }
        }

        private void SaveSettings()
        {
            var settings = new Settings
            {
                X = this.Location.X,
                Y = this.Location.Y,
                Width = this.Size.Width,
                Height = this.Size.Height,

                SavePublicKeys = this.saveAWSPublicKeysToolStripMenuItem.Checked,
                SavePrivateKeys = this.saveAWSPrivateKeysToolStripMenuItem.Checked,
                SaveDomainSchemas = this.cacheDomainSchemasToolStripMenuItem.Checked
            };

            // If the user has elected to save their AWS credentials
            if( this.saveAWSPublicKeysToolStripMenuItem.Checked && this.AwsCredentials != null )
            {
                // If the user has elected to save their AWS secret keys
                if( this.saveAWSPrivateKeysToolStripMenuItem.Checked )
                {
                    // Convert the actual key to a AES encrypted version to save in the file
                    foreach( var c in this.AwsCredentials )
                    {
                        c.EncryptedSecret = Convert.ToBase64String( encrypt( c.Secret, Convert.FromBase64String( AesKey ), Convert.FromBase64String( AesIV ) ) );
                    }
                }

                // Include the credentials in the xml file
                settings.AwsCredentials = this.AwsCredentials;
            }

            // Write the settings to file
            using( var w = new StreamWriter( "Settings.xml" ) )
            {
                var x = new XmlSerializer( typeof( Settings ) );
                x.Serialize( w, settings );
            }

            if( !this.saveAWSPublicKeysToolStripMenuItem.Checked || this.Credentials == null ) return;

            // Make sure no filter is applied
            this.FilterDomains( null );

            // Create the schema object
            var schema = new DomainSchema();
            foreach( TreeNode domain in this.domainList.Nodes )
            {
                schema.Add
                (
                    domain.Text, ( from TreeNode c in domain.Nodes select c.Text ).ToArray()
                );
            }

            // The name of the file is a SHA2 has of the public key and the service url
            var hash = HashSha2( this.Credentials.Key + this.Credentials.ServiceUrl );

            // Write the file
            using( var w = new StreamWriter( hash + ".xml" ) )
            {
                var x = new XmlSerializer( typeof( DomainSchema ) );
                x.Serialize( w, schema );
            }
        }

        private void LoadSettings()
        {
            if( !File.Exists( "Settings.xml" ) ) return;
            using( var r = new StreamReader( "Settings.xml" ) )
            {
                var x = new XmlSerializer( typeof( Settings ) );
                var settings = x.Deserialize( r ) as Settings;
                if( settings == null ) return;

                this.SetBounds( settings.X, settings.Y, settings.Width, settings.Height );
                this.Location = new System.Drawing.Point( settings.X, settings.Y );
                this.Size = new System.Drawing.Size( settings.Width, settings.Height );
                this.saveAWSPublicKeysToolStripMenuItem.Checked = settings.SavePublicKeys;
                this.saveAWSPrivateKeysToolStripMenuItem.Checked = settings.SavePrivateKeys;
                this.AwsCredentials = settings.AwsCredentials;
            }

            if( this.AwsCredentials == null ) return;

            foreach( var c in this.AwsCredentials.Where( m => !string.IsNullOrEmpty( m.EncryptedSecret ) ) )
            {
                c.Secret = decrypt( Convert.FromBase64String( c.EncryptedSecret ), Convert.FromBase64String( AesKey ), Convert.FromBase64String( AesIV ) );
            }
        }

        private void LoadDomains()
        {
            if( this.db == null ) return;

            this.domainList.Nodes.Clear();
            foreach( var d in this.db.Domains )
            {
                this.domainList.Nodes.Add( d );
            }

            this.LoadDomainSchema( this.Credentials );
        }

        private TreeNode GetSelectedDomainNode()
        {
            var node = this.domainList.SelectedNode;
            while( node != null && node.Level > 0 ) node = node.Parent;
            return node;
        }

        private string GetSelectedDomainName()
        {
            var node = GetSelectedDomainNode();
            return node == null ? null : node.Text;
        }

        private void FilterDomains( string filter )
        {
            if( this.HiddenNodes != null )
            {
                // Add the currently hidden nodes back to the list
                foreach( TreeNode node in this.HiddenNodes.Nodes )
                {
                    this.domainList.Nodes.Add( node );
                }
            }

            this.HiddenNodes = new TreeNode();
            this.domainList.Sort();

            // If there is no filter, we are done
            if( string.IsNullOrEmpty( filter ) ) return;

            foreach( var node in this.domainList.Nodes.Cast<TreeNode>().Where( node => node != null && node.Text.IndexOf( filter, StringComparison.OrdinalIgnoreCase ) < 0 ) )
            {
                this.domainList.Nodes.Remove( node );
                this.HiddenNodes.Nodes.Add( node );
            }
        }

        private void LoadDomainSchema( AwsCredentials c )
        {
            var hash = HashSha2( c.Key + c.ServiceUrl );

            if( !File.Exists( hash + ".xml" ) ) return;
            using( var r = new StreamReader( hash + ".xml" ) )
            {
                var x = new XmlSerializer( typeof( DomainSchema ) );
                var schema = x.Deserialize( r ) as DomainSchema;
                if( schema == null ) return;

                foreach( TreeNode domain in this.domainList.Nodes )
                {
                    if( !schema.ContainsKey( domain.Text ) ) continue;
                    var columns = schema[domain.Text];
                    foreach( var column in columns )
                    {
                        domain.Nodes.Add( column, column, 1 );
                    }
                }
            }
        }

        private void LoadDomainMetaData( string Domain )
        {
            if( this.db == null ) return;

            if( !this.DomainMetaData.ContainsKey( Domain ) )
            {
                try
                {
                    var meta = this.db.GetDomainDetails( Domain );
                    this.DomainMetaData.Add( Domain, meta );
                }
                catch( Exception ex )
                {
                    MessageBox.Show( ex.Message, @"Could not retrieve domain meta data", MessageBoxButtons.OK );
                }
            }

            var data = this.DomainMetaData[Domain];

            this.lblAttributeNameCount.Text = data.AttributeNameCount.ToString( "N0" );
            this.lblAttributeNameSizeBytes.Text = data.AttributeNamesSizeBytes.ToString( "N0" );
            this.lblAttributeValueCount.Text = data.AttributeValueCount.ToString( "N0" );
            this.lblAttributeValuesSizeBytes.Text = data.AttributeValuesSizeBytes.ToString( "N0" );
            this.lblItemCount.Text = data.ItemCount.ToString( "N0" );
            this.lblItemNamesSizeBytes.Text = data.ItemNamesSizeBytes.ToString( "N0" );

            var total = data.ItemNamesSizeBytes + data.AttributeNamesSizeBytes + data.AttributeValuesSizeBytes;
            if( total < 2L * 1024 )
            {
                this.lblTotalSize.Text = total.ToString( "N0" ) + @" bytes";
            }
            else if( total < 2L * 1024 * 1024 )
            {
                this.lblTotalSize.Text = ( total / 1024.0 ).ToString( "N2" ) + @" kB";
            }
            else if( total < 2L * 1024 * 1024 * 1024 )
            {
                this.lblTotalSize.Text = ( total / 1024.0 / 1024.0 ).ToString( "N2" ) + @" MB";
            }
            else
            {
                this.lblTotalSize.Text = ( total / 1024.0 / 1024.0 / 1024.0 ).ToString( "N2" ) + @" GB";
            }

            var percent = total / 1024.0 / 1024.0 / 1024.0 * 10;
            this.lblPercentSize.Text = percent.ToString( "P5" );
        }

        private void LoadQueryResults( List<SimpleDBItem> Items, string Domain )
        {
            var data = new DataTable( "Query Results" );
            var columns = ( from i in Items from p in i select p.Key ).Distinct().ToList();

            // Find the domain node with the given name
            var node = this.domainList.Nodes.Cast<TreeNode>()
                .Where( m => m.Text.Equals( Domain, StringComparison.OrdinalIgnoreCase ) )
                .FirstOrDefault( m => m.Level == 0 );

            if( node != null )
            {
                var insertNeedsUpdated = false;

                // Add new attribute nodes to the domain node if they are missing
                foreach( var c in columns.Where( c => !node.Nodes.ContainsKey( c ) ) )
                {
                    node.Nodes.Add( c, c, 1 );
                    insertNeedsUpdated = true;
                }
                
                // If the domain list needed updated, the insert grid does too
                if( insertNeedsUpdated )
                {
                    this.UpdateInsertGridView();
                }
            }

            // Add the columns to the result grid
            data.Columns.Add( "Name" );
            data.Columns.AddRange( ( from c in columns select new DataColumn( c ) ).ToArray() );

            // Add the rows to the result grid
            foreach( var i in Items )
            {
                var row = data.NewRow();
                row["Name"] = i.Name;
                foreach( var a in i )
                {
                    row[a.Key] = a.Value;
                }
                data.Rows.Add( row );
            }

            // Show the data
            this.resultGrid.DataSource = data;

            // Hide the Name column
            if( this.resultGrid.Columns["Name"] != null )
                this.resultGrid.Columns["Name"].Visible = false;

            // Make the Results table visible
            this.Tabs.SelectedTab = this.tabPage3;
        }

        private void UpdateInsertGridView()
        {
            var data = new DataTable( "Insert Item" );

            data.Columns.Add( "Name" );
            data.Columns.Add( "Value" );

            var node = this.GetSelectedDomainNode();

            if( node != null )
            {
                foreach( TreeNode n in node.Nodes )
                {
                    var row = data.NewRow();
                    row["Name"] = n.Text;
                    data.Rows.Add( row );
                }
            }

            this.insertGrid.DataSource = data;
            this.insertGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void UpdateRowByName( string name, List<KeyValuePair<string, string>> Attributes )
        {
            try
            {
                this.db.Update( this.GetSelectedDomainName(), name, Attributes );
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.Message, @"Failed to update domain row", MessageBoxButtons.OK );
            }
        }

        private void DeleteRowByName( string name )
        {
            try
            {
                var domain = GetSelectedDomainName();
                if( domain != null ) this.db.Delete( domain, name );
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.Message, @"Failed to delete domain row", MessageBoxButtons.OK );
            }
        }

        #region Event Handlers
        private void runQuery_Click( object sender, EventArgs e )
        {
            if( this.db == null ) return;
            var match = DomainNameFromQuery.Match( this.queryText.Text );

            try
            {
                LoadQueryResults( this.db.Select( this.queryText.Text ), match.Groups["domain"].Value );
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.Message, @"Could not execute query", MessageBoxButtons.OK );
            }
        }

        private void domainList_SelectedIndexChanged( object sender, TreeViewEventArgs e )
        {
            var domain = this.GetSelectedDomainName();
            if( domain == null ) return;

            // Set the default query or update the existing one
            if( string.IsNullOrEmpty( this.queryText.Text ) )
            {
                this.queryText.Text = @"SELECT * FROM `" + domain + @"`";
            }
            else
            {
                this.queryText.Text = DomainNameFromQuery.Replace( this.queryText.Text, "${from}${spaces}`" + domain + "`" );
            }

            // Set the insert column list
            this.UpdateInsertGridView();

            this.LoadDomainMetaData( domain );
        }

        private void InsertButton_Click( object sender, EventArgs e )
        {
            if( this.db == null ) return;
            var domain = this.GetSelectedDomainName();
            if( domain == null ) return;

            var kvp = new List<KeyValuePair<string, String>>( this.insertGrid.Rows.Count );

            foreach( DataGridViewRow row in this.insertGrid.Rows )
            {
                object name = row.Cells[0].Value, value = row.Cells[1].Value;
                if( name == null || value == null ) continue;
                kvp.Add( new KeyValuePair<string,string>( name.ToString(), value.ToString() ) );
            }

            try
            {
                this.db.Insert( domain, kvp );
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.Message, @"Failed to insert domain row", MessageBoxButtons.OK );
            }
        }

        private void connectToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Connect();
        }

        private void disconnectToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Disconnect();
        }

        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void RefreshMetaData_Click( object sender, EventArgs e )
        {
            var domain = this.GetSelectedDomainName();
            if( domain == null ) return;

            if( this.DomainMetaData.ContainsKey( domain ) )
            {
                this.DomainMetaData.Remove( domain );
            }

            this.LoadDomainMetaData( domain );
        }

        private void CreateButton_Click( object sender, EventArgs e )
        {
            if( this.db == null ) return;
            var dialog = new DomainNameDialog { StartPosition = FormStartPosition.CenterParent };
            if( dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK || string.IsNullOrEmpty( dialog.DomainName ) ) return;

            try
            {
                this.db.CreateDomain( dialog.DomainName );
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.Message, @"Could not create domain", MessageBoxButtons.OK );
            }

            this.LoadDomains();
        }

        private void DeleteDomain_Click( object sender, EventArgs e )
        {
            if( this.db == null ) return;

            var node = GetSelectedDomainNode();
            if( node == null ) return;

            var r = MessageBox.Show( @"Are you sure you wish to delete this row from the domain `" + node.Text + @"`?", @"Confirm Delete", MessageBoxButtons.YesNo );
            if( r != DialogResult.Yes ) return;

            try
            {
                this.db.DeleteDomain( node.Text );
                this.domainList.Nodes.Remove( node );
                this.DomainMetaData.Remove( node.Text );
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.Message, @"Could not delete domain", MessageBoxButtons.OK );
            }
        }

        private void Main_FormClosing( object sender, FormClosingEventArgs e )
        {
            this.SaveSettings();
        }

        private void refreshDomainListToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.LoadDomains();
        }

        private void filterButton_Click( object sender, EventArgs e )
        {
            if( this.FilterDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK ) return;
            this.FilterDomains( this.FilterDialog.DomainFilter );
        }

        private void aboutToolStripMenuItem_Click( object sender, EventArgs e )
        {
            new AboutDialog
            {
                StartPosition = FormStartPosition.CenterParent
            }
            .ShowDialog();
        }

        private void resultGrid_UserDeletingRow( object sender, DataGridViewRowCancelEventArgs e )
        {
            var domain = GetSelectedDomainName();
            var r = MessageBox.Show( @"Are you sure you wish to delete this row from the domain `" + domain + @"`?", @"Confirm Delete", MessageBoxButtons.YesNo );
            if( r == DialogResult.Yes )
            {
                this.DeleteRowByName( e.Row.Cells["Name"].Value.ToString() );
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void resultGrid_CellValueChanged( object sender, DataGridViewCellEventArgs e )
        {
            this.UpdateRowByName
            (
                this.resultGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString(),
                new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string,string>
                    (
                        this.resultGrid.Columns[e.ColumnIndex].HeaderText,
                        this.resultGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()
                    )
                }
            );
        }
        #endregion

        #region Hashing and Encryption
        private static string HashSha2( string str )
        {
            using( var sha2Hash = new SHA512Managed() )
            {
                return Convert.ToBase64String( sha2Hash.ComputeHash( System.Text.Encoding.UTF8.GetBytes( str ) ) );
            }
        }

        public static byte[] encrypt( string plainText, byte[] key, byte[] iv )
        {
            return encrypt( System.Text.Encoding.UTF8.GetBytes( plainText ), key, iv );
        }

        public static byte[] encrypt( byte[] plainText, byte[] key, byte[] iv )
        {
            // http://msdn.microsoft.com/en-us/library/system.security.cryptography.rijndaelmanaged.aspx

            // Check arguments.
            if( plainText == null || plainText.Length <= 0 ) throw new ArgumentNullException( "plainText" );
            if( key == null || key.Length <= 0 ) throw new ArgumentNullException( "key" );
            if( iv == null || iv.Length <= 0 ) throw new ArgumentNullException( "iv" );

            // Create an RijndaelManaged object
            // with the specified key and IV.
            using( var aesAlg = new AesManaged() )
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                try
                {
                    using( var stream = new MemoryStream() )
                    using( var encryptor = aesAlg.CreateEncryptor( aesAlg.Key, aesAlg.IV ) )
                    using( var encrypt = new CryptoStream( stream, encryptor, CryptoStreamMode.Write ) )
                    {
                        encrypt.Write( plainText, 0, plainText.Length );
                        encrypt.FlushFinalBlock();
                        return stream.ToArray();
                    }
                }
                catch
                {
                }
            }

            // Return the encrypted bytes from the memory stream.
            return null;
        }

        public static string decrypt( byte[] cipherText, byte[] key, byte[] iv )
        {
            // http://msdn.microsoft.com/en-us/library/system.security.cryptography.rijndaelmanaged.aspx
            // http://stackoverflow.com/questions/4501289/c-sharp-byte-encryption

            // Check arguments.
            if( cipherText == null || cipherText.Length <= 0 ) throw new ArgumentNullException( "cipherText" );
            if( key == null || key.Length <= 0 ) throw new ArgumentNullException( "key" );
            if( iv == null || iv.Length <= 0 ) throw new ArgumentNullException( "iv" );

            byte[] plaintext = null;

            using( var aesAlg = new AesManaged() )
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                try
                {
                    using( var stream = new MemoryStream() )
                    using( var decryptor = aesAlg.CreateDecryptor( aesAlg.Key, aesAlg.IV ) )
                    using( var encrypt = new CryptoStream( stream, decryptor, CryptoStreamMode.Write ) )
                    {
                        encrypt.Write( cipherText, 0, cipherText.Length );
                        encrypt.FlushFinalBlock();
                        plaintext = stream.ToArray();
                    }
                }
                catch
                {
                }
            }

            return System.Text.Encoding.UTF8.GetString( plaintext );
        }

        public static byte[] GetRandomAesKey()
        {
            using( var r = new System.Security.Cryptography.RijndaelManaged() )
            {
                r.GenerateKey();
                return r.Key;
            }
        }

        public static byte[] GetRandomAesIV()
        {
            using( var r = new System.Security.Cryptography.RijndaelManaged() )
            {
                r.GenerateIV();
                return r.IV;
            }
        }
        #endregion
    }
}
