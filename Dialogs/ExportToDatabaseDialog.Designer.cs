namespace SimpleDBAdmin
{
    partial class ExportToDatabaseDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportToDatabaseDialog));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel = new System.Windows.Forms.Button();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.databaseType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionString = new System.Windows.Forms.TextBox();
            this.panel1Next = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2Previous = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tables = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createTable = new System.Windows.Forms.TextBox();
            this.panel2Next = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3Previous = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3Next = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.targetFile = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.query = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4Previous = new System.Windows.Forms.Button();
            this.panel4Next = new System.Windows.Forms.Button();
            this.columnMapTable = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5Previous = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.columnMapTable.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connect to Destination";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Cancel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblConnectionString, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.databaseType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.connectionString, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1Next, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(3, 358);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(170, 35);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnectionString.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblConnectionString, 2);
            this.lblConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionString.Location = new System.Drawing.Point(10, 110);
            this.lblConnectionString.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(471, 36);
            this.lblConnectionString.TabIndex = 2;
            this.lblConnectionString.Text = "Please enter the connection string that will be used to transfer the data into th" +
    "e database.";
            // 
            // databaseType
            // 
            this.databaseType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.databaseType, 2);
            this.databaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseType.FormattingEnabled = true;
            this.databaseType.Items.AddRange(new object[] {
            "Microsoft SQL Server",
            "PostgreSQL",
            "SQLite"});
            this.databaseType.Location = new System.Drawing.Point(3, 64);
            this.databaseType.Name = "databaseType";
            this.databaseType.Size = new System.Drawing.Size(485, 26);
            this.databaseType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select a database type from the list below. If the database type you want " +
    "to use is not listed, it is not supported at this time.";
            // 
            // connectionString
            // 
            this.connectionString.AcceptsReturn = true;
            this.tableLayoutPanel1.SetColumnSpan(this.connectionString, 2);
            this.connectionString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionString.Location = new System.Drawing.Point(3, 153);
            this.connectionString.Multiline = true;
            this.connectionString.Name = "connectionString";
            this.connectionString.Size = new System.Drawing.Size(485, 195);
            this.connectionString.TabIndex = 3;
            // 
            // panel1Next
            // 
            this.panel1Next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1Next.Location = new System.Drawing.Point(318, 358);
            this.panel1Next.Name = "panel1Next";
            this.panel1Next.Size = new System.Drawing.Size(170, 35);
            this.panel1Next.TabIndex = 4;
            this.panel1Next.Text = "Next";
            this.panel1Next.UseVisualStyleBackColor = true;
            this.panel1Next.Click += new System.EventHandler(this.panel1Next_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Choose a Table";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2Previous, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tables, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.createTable, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel2Next, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(491, 401);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2Previous
            // 
            this.panel2Previous.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2Previous.Location = new System.Drawing.Point(3, 358);
            this.panel2Previous.Name = "panel2Previous";
            this.panel2Previous.Size = new System.Drawing.Size(170, 35);
            this.panel2Previous.TabIndex = 5;
            this.panel2Previous.Text = "Previous";
            this.panel2Previous.UseVisualStyleBackColor = true;
            this.panel2Previous.Click += new System.EventHandler(this.panel2Previous_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "If you would like to import into a new table, enter the table create command belo" +
    "w. Or leave it blank for an automatically created table.";
            // 
            // tables
            // 
            this.tables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.tables, 2);
            this.tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tables.FormattingEnabled = true;
            this.tables.Location = new System.Drawing.Point(3, 62);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(485, 26);
            this.tables.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "If you would like to import into an exsiting table, select it from the list below" +
    ".";
            // 
            // createTable
            // 
            this.createTable.AcceptsReturn = true;
            this.tableLayoutPanel2.SetColumnSpan(this.createTable, 2);
            this.createTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createTable.Location = new System.Drawing.Point(3, 153);
            this.createTable.Multiline = true;
            this.createTable.Name = "createTable";
            this.createTable.Size = new System.Drawing.Size(485, 195);
            this.createTable.TabIndex = 3;
            // 
            // panel2Next
            // 
            this.panel2Next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2Next.Location = new System.Drawing.Point(318, 358);
            this.panel2Next.Name = "panel2Next";
            this.panel2Next.Size = new System.Drawing.Size(170, 35);
            this.panel2Next.TabIndex = 4;
            this.panel2Next.Text = "Next";
            this.panel2Next.UseVisualStyleBackColor = true;
            this.panel2Next.Click += new System.EventHandler(this.panel2Next_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(497, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Download";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel3Previous, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3Next, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.query, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(497, 407);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Optionally, you can specify a specific query to use to download a subset of the D" +
    "omain data.";
            // 
            // panel3Previous
            // 
            this.panel3Previous.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3Previous.Location = new System.Drawing.Point(3, 364);
            this.panel3Previous.Name = "panel3Previous";
            this.panel3Previous.Size = new System.Drawing.Size(170, 35);
            this.panel3Previous.TabIndex = 5;
            this.panel3Previous.Text = "Previous";
            this.panel3Previous.UseVisualStyleBackColor = true;
            this.panel3Previous.Click += new System.EventHandler(this.panel3Previous_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label5, 2);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 72);
            this.label5.TabIndex = 1;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // panel3Next
            // 
            this.panel3Next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3Next.Location = new System.Drawing.Point(324, 364);
            this.panel3Next.Name = "panel3Next";
            this.panel3Next.Size = new System.Drawing.Size(170, 35);
            this.panel3Next.TabIndex = 4;
            this.panel3Next.Text = "Next";
            this.panel3Next.UseVisualStyleBackColor = true;
            this.panel3Next.Click += new System.EventHandler(this.panel3Next_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel4.Controls.Add(this.targetFile, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.browseButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(491, 44);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // targetFile
            // 
            this.targetFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.targetFile.Location = new System.Drawing.Point(3, 10);
            this.targetFile.Name = "targetFile";
            this.targetFile.Size = new System.Drawing.Size(402, 24);
            this.targetFile.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(411, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(77, 35);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Choose";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // query
            // 
            this.query.AcceptsReturn = true;
            this.tableLayoutPanel3.SetColumnSpan(this.query, 2);
            this.query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.query.Location = new System.Drawing.Point(3, 203);
            this.query.Multiline = true;
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(491, 94);
            this.query.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(497, 407);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Column Map";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel4Previous, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel4Next, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.columnMapTable, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(497, 407);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // panel4Previous
            // 
            this.panel4Previous.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel4Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4Previous.Location = new System.Drawing.Point(3, 364);
            this.panel4Previous.Name = "panel4Previous";
            this.panel4Previous.Size = new System.Drawing.Size(170, 35);
            this.panel4Previous.TabIndex = 5;
            this.panel4Previous.Text = "Previous";
            this.panel4Previous.UseVisualStyleBackColor = true;
            this.panel4Previous.Click += new System.EventHandler(this.panel4Previous_Click);
            // 
            // panel4Next
            // 
            this.panel4Next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4Next.Location = new System.Drawing.Point(324, 364);
            this.panel4Next.Name = "panel4Next";
            this.panel4Next.Size = new System.Drawing.Size(170, 35);
            this.panel4Next.TabIndex = 4;
            this.panel4Next.Text = "Next";
            this.panel4Next.UseVisualStyleBackColor = true;
            this.panel4Next.Click += new System.EventHandler(this.panel4Next_Click);
            // 
            // columnMapTable
            // 
            this.columnMapTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.columnMapTable.AutoScroll = true;
            this.columnMapTable.ColumnCount = 2;
            this.tableLayoutPanel5.SetColumnSpan(this.columnMapTable, 2);
            this.columnMapTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.columnMapTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.columnMapTable.Controls.Add(this.label7, 1, 0);
            this.columnMapTable.Controls.Add(this.label6, 0, 0);
            this.columnMapTable.Location = new System.Drawing.Point(3, 3);
            this.columnMapTable.Name = "columnMapTable";
            this.columnMapTable.RowCount = 1;
            this.columnMapTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.columnMapTable.Size = new System.Drawing.Size(491, 351);
            this.columnMapTable.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Destination Column";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Domain Attribute";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel6);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(497, 407);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Export";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.panel5Previous, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.Export, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.lblSource, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.lblDestination, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.lblColumns, 1, 4);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 7;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(497, 407);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // panel5Previous
            // 
            this.panel5Previous.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel5Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5Previous.Location = new System.Drawing.Point(3, 364);
            this.panel5Previous.Name = "panel5Previous";
            this.panel5Previous.Size = new System.Drawing.Size(170, 35);
            this.panel5Previous.TabIndex = 5;
            this.panel5Previous.Text = "Previous";
            this.panel5Previous.UseVisualStyleBackColor = true;
            this.panel5Previous.Click += new System.EventHandler(this.panel5Previous_Click);
            // 
            // Export
            // 
            this.Export.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export.Location = new System.Drawing.Point(324, 364);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(170, 35);
            this.Export.TabIndex = 4;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.label8, 2);
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(477, 36);
            this.label8.TabIndex = 6;
            this.label8.Text = "Please verify the information below. If you are satisfied, click on the Export bu" +
    "tton to procede.";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Source Domain";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Destination Table";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "Mapped Columns";
            // 
            // lblSource
            // 
            this.lblSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(251, 116);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(243, 18);
            this.lblSource.TabIndex = 10;
            this.lblSource.Text = "Not Set";
            // 
            // lblDestination
            // 
            this.lblDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(251, 166);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(243, 18);
            this.lblDestination.TabIndex = 11;
            this.lblDestination.Text = "Not Set";
            // 
            // lblColumns
            // 
            this.lblColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(251, 216);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(243, 18);
            this.lblColumns.TabIndex = 12;
            this.lblColumns.Text = "Not Set";
            // 
            // ExportToDatabaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 438);
            this.Controls.Add(this.tabControl1);
            this.Name = "ExportToDatabaseDialog";
            this.Text = "Exporting a Domain to a Database";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.columnMapTable.ResumeLayout(false);
            this.columnMapTable.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.ComboBox databaseType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox connectionString;
        private System.Windows.Forms.Button panel1Next;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button panel2Previous;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox createTable;
        private System.Windows.Forms.Button panel2Next;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button panel3Previous;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button panel3Next;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox targetFile;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox query;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button panel4Previous;
        private System.Windows.Forms.Button panel4Next;
        private System.Windows.Forms.TableLayoutPanel columnMapTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button panel5Previous;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblColumns;
    }
}