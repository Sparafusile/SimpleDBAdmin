namespace SimpleDBAdmin
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.leftPaneTable = new System.Windows.Forms.TableLayoutPanel();
            this.domainList = new System.Windows.Forms.TreeView();
            this.domainListImages = new System.Windows.Forms.ImageList(this.components);
            this.CreateButton = new System.Windows.Forms.Button();
            this.leftPaneTopButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.lblItemNamesSizeBytes = new System.Windows.Forms.Label();
            this.lblAttributeValuesSizeBytes = new System.Windows.Forms.Label();
            this.lblAttributeValueCount = new System.Windows.Forms.Label();
            this.lblAttributeNameSizeBytes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAttributeNameCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPercentSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RefreshMetaData = new System.Windows.Forms.Button();
            this.DeleteDomain = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.queryText = new System.Windows.Forms.TextBox();
            this.runQuery = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.InsertButton = new System.Windows.Forms.Button();
            this.insertGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDomainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDomainListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAWSPublicKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAWSPrivateKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacheDomainSchemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentTable = new System.Windows.Forms.TableLayoutPanel();
            this.exportDomainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.leftPaneTable.SuspendLayout();
            this.leftPaneTopButtonTable.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.parentTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.leftPaneTable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Tabs);
            this.splitContainer1.Size = new System.Drawing.Size(612, 481);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 0;
            // 
            // leftPaneTable
            // 
            this.leftPaneTable.ColumnCount = 1;
            this.leftPaneTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPaneTable.Controls.Add(this.domainList, 0, 1);
            this.leftPaneTable.Controls.Add(this.CreateButton, 0, 2);
            this.leftPaneTable.Controls.Add(this.leftPaneTopButtonTable, 0, 0);
            this.leftPaneTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPaneTable.Location = new System.Drawing.Point(0, 0);
            this.leftPaneTable.Name = "leftPaneTable";
            this.leftPaneTable.RowCount = 3;
            this.leftPaneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.leftPaneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPaneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.leftPaneTable.Size = new System.Drawing.Size(206, 481);
            this.leftPaneTable.TabIndex = 0;
            // 
            // domainList
            // 
            this.domainList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.domainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainList.HideSelection = false;
            this.domainList.ImageIndex = 0;
            this.domainList.ImageList = this.domainListImages;
            this.domainList.Location = new System.Drawing.Point(3, 43);
            this.domainList.Name = "domainList";
            this.domainList.SelectedImageIndex = 0;
            this.domainList.Size = new System.Drawing.Size(200, 395);
            this.domainList.TabIndex = 20;
            this.domainList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.domainList_SelectedIndexChanged);
            // 
            // domainListImages
            // 
            this.domainListImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("domainListImages.ImageStream")));
            this.domainListImages.TransparentColor = System.Drawing.Color.Transparent;
            this.domainListImages.Images.SetKeyName(0, "database.png");
            this.domainListImages.Images.SetKeyName(1, "attributeHierarchy.png");
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(3, 444);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(200, 34);
            this.CreateButton.TabIndex = 21;
            this.CreateButton.Text = "Create Domain";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // leftPaneTopButtonTable
            // 
            this.leftPaneTopButtonTable.ColumnCount = 4;
            this.leftPaneTopButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leftPaneTopButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leftPaneTopButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leftPaneTopButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leftPaneTopButtonTable.Controls.Add(this.connectButton, 0, 0);
            this.leftPaneTopButtonTable.Controls.Add(this.disconnectButton, 1, 0);
            this.leftPaneTopButtonTable.Controls.Add(this.filterButton, 2, 0);
            this.leftPaneTopButtonTable.Controls.Add(this.refreshButton, 3, 0);
            this.leftPaneTopButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPaneTopButtonTable.Location = new System.Drawing.Point(0, 0);
            this.leftPaneTopButtonTable.Margin = new System.Windows.Forms.Padding(0);
            this.leftPaneTopButtonTable.Name = "leftPaneTopButtonTable";
            this.leftPaneTopButtonTable.RowCount = 1;
            this.leftPaneTopButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPaneTopButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.leftPaneTopButtonTable.Size = new System.Drawing.Size(206, 40);
            this.leftPaneTopButtonTable.TabIndex = 22;
            // 
            // connectButton
            // 
            this.connectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectButton.Image = ((System.Drawing.Image)(resources.GetObject("connectButton.Image")));
            this.connectButton.Location = new System.Drawing.Point(3, 3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(45, 34);
            this.connectButton.TabIndex = 0;
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disconnectButton.Image = ((System.Drawing.Image)(resources.GetObject("disconnectButton.Image")));
            this.disconnectButton.Location = new System.Drawing.Point(54, 3);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(45, 34);
            this.disconnectButton.TabIndex = 1;
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // filterButton
            // 
            this.filterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterButton.Image = ((System.Drawing.Image)(resources.GetObject("filterButton.Image")));
            this.filterButton.Location = new System.Drawing.Point(105, 3);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(45, 34);
            this.filterButton.TabIndex = 2;
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(156, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(47, 34);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshDomainListToolStripMenuItem_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Controls.Add(this.tabPage4);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(402, 481);
            this.Tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(394, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Meta Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblItemCount, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblItemNamesSizeBytes, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblAttributeValuesSizeBytes, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblAttributeValueCount, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAttributeNameSizeBytes, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblAttributeNameCount, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalSize, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblPercentSize, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.RefreshMetaData, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.DeleteDomain, 0, 11);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 13;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 449);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblItemCount
            // 
            this.lblItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCount.Location = new System.Drawing.Point(223, 183);
            this.lblItemCount.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(100, 18);
            this.lblItemCount.TabIndex = 13;
            this.lblItemCount.Text = "0";
            this.lblItemCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblItemNamesSizeBytes
            // 
            this.lblItemNamesSizeBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemNamesSizeBytes.AutoSize = true;
            this.lblItemNamesSizeBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNamesSizeBytes.Location = new System.Drawing.Point(223, 148);
            this.lblItemNamesSizeBytes.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblItemNamesSizeBytes.Name = "lblItemNamesSizeBytes";
            this.lblItemNamesSizeBytes.Size = new System.Drawing.Size(100, 18);
            this.lblItemNamesSizeBytes.TabIndex = 11;
            this.lblItemNamesSizeBytes.Text = "0";
            this.lblItemNamesSizeBytes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAttributeValuesSizeBytes
            // 
            this.lblAttributeValuesSizeBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttributeValuesSizeBytes.AutoSize = true;
            this.lblAttributeValuesSizeBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttributeValuesSizeBytes.Location = new System.Drawing.Point(223, 113);
            this.lblAttributeValuesSizeBytes.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblAttributeValuesSizeBytes.Name = "lblAttributeValuesSizeBytes";
            this.lblAttributeValuesSizeBytes.Size = new System.Drawing.Size(100, 18);
            this.lblAttributeValuesSizeBytes.TabIndex = 10;
            this.lblAttributeValuesSizeBytes.Text = "0";
            this.lblAttributeValuesSizeBytes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAttributeValueCount
            // 
            this.lblAttributeValueCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttributeValueCount.AutoSize = true;
            this.lblAttributeValueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttributeValueCount.Location = new System.Drawing.Point(223, 78);
            this.lblAttributeValueCount.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblAttributeValueCount.Name = "lblAttributeValueCount";
            this.lblAttributeValueCount.Size = new System.Drawing.Size(100, 18);
            this.lblAttributeValueCount.TabIndex = 9;
            this.lblAttributeValueCount.Text = "0";
            this.lblAttributeValueCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAttributeNameSizeBytes
            // 
            this.lblAttributeNameSizeBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttributeNameSizeBytes.AutoSize = true;
            this.lblAttributeNameSizeBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttributeNameSizeBytes.Location = new System.Drawing.Point(223, 43);
            this.lblAttributeNameSizeBytes.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblAttributeNameSizeBytes.Name = "lblAttributeNameSizeBytes";
            this.lblAttributeNameSizeBytes.Size = new System.Drawing.Size(100, 18);
            this.lblAttributeNameSizeBytes.TabIndex = 8;
            this.lblAttributeNameSizeBytes.Text = "0";
            this.lblAttributeNameSizeBytes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attribute Name Count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Attribute Value Count";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attribute Values Size Bytes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Item Names Size Bytes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Item Count";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAttributeNameCount
            // 
            this.lblAttributeNameCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttributeNameCount.AutoSize = true;
            this.lblAttributeNameCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttributeNameCount.Location = new System.Drawing.Point(223, 8);
            this.lblAttributeNameCount.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblAttributeNameCount.Name = "lblAttributeNameCount";
            this.lblAttributeNameCount.Size = new System.Drawing.Size(100, 18);
            this.lblAttributeNameCount.TabIndex = 7;
            this.lblAttributeNameCount.Text = "0";
            this.lblAttributeNameCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Size";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSize.Location = new System.Drawing.Point(223, 218);
            this.lblTotalSize.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(100, 18);
            this.lblTotalSize.TabIndex = 15;
            this.lblTotalSize.Text = "0";
            this.lblTotalSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Percent Maximum";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPercentSize
            // 
            this.lblPercentSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentSize.AutoSize = true;
            this.lblPercentSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentSize.Location = new System.Drawing.Point(223, 253);
            this.lblPercentSize.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblPercentSize.Name = "lblPercentSize";
            this.lblPercentSize.Size = new System.Drawing.Size(100, 18);
            this.lblPercentSize.TabIndex = 17;
            this.lblPercentSize.Text = "0";
            this.lblPercentSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Attribute Names Size Bytes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RefreshMetaData
            // 
            this.RefreshMetaData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.RefreshMetaData, 2);
            this.RefreshMetaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshMetaData.Location = new System.Drawing.Point(3, 303);
            this.RefreshMetaData.Name = "RefreshMetaData";
            this.RefreshMetaData.Size = new System.Drawing.Size(388, 34);
            this.RefreshMetaData.TabIndex = 18;
            this.RefreshMetaData.Text = "Refresh Meta Data";
            this.RefreshMetaData.UseVisualStyleBackColor = true;
            this.RefreshMetaData.Click += new System.EventHandler(this.RefreshMetaData_Click);
            // 
            // DeleteDomain
            // 
            this.DeleteDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.DeleteDomain, 2);
            this.DeleteDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteDomain.Location = new System.Drawing.Point(3, 363);
            this.DeleteDomain.Name = "DeleteDomain";
            this.DeleteDomain.Size = new System.Drawing.Size(388, 34);
            this.DeleteDomain.TabIndex = 19;
            this.DeleteDomain.Text = "Delete this Domain";
            this.DeleteDomain.UseVisualStyleBackColor = true;
            this.DeleteDomain.Click += new System.EventHandler(this.DeleteDomain_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(394, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Query";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.queryText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.runQuery, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 446);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // queryText
            // 
            this.queryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryText.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryText.Location = new System.Drawing.Point(3, 3);
            this.queryText.Multiline = true;
            this.queryText.Name = "queryText";
            this.queryText.Size = new System.Drawing.Size(382, 405);
            this.queryText.TabIndex = 0;
            this.queryText.WordWrap = false;
            // 
            // runQuery
            // 
            this.runQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.runQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runQuery.Location = new System.Drawing.Point(3, 414);
            this.runQuery.Name = "runQuery";
            this.runQuery.Size = new System.Drawing.Size(382, 29);
            this.runQuery.TabIndex = 1;
            this.runQuery.Text = "Run Query";
            this.runQuery.UseVisualStyleBackColor = true;
            this.runQuery.Click += new System.EventHandler(this.runQuery_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.resultGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(394, 452);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Results";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // resultGrid
            // 
            this.resultGrid.AllowUserToAddRows = false;
            this.resultGrid.AllowUserToResizeRows = false;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultGrid.Location = new System.Drawing.Point(3, 3);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.resultGrid.ShowCellErrors = false;
            this.resultGrid.ShowCellToolTips = false;
            this.resultGrid.ShowEditingIcon = false;
            this.resultGrid.ShowRowErrors = false;
            this.resultGrid.Size = new System.Drawing.Size(388, 446);
            this.resultGrid.TabIndex = 0;
            this.resultGrid.VirtualMode = true;
            this.resultGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultGrid_CellValueChanged);
            this.resultGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.resultGrid_UserDeletingRow);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(394, 452);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Insert";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.InsertButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.insertGrid, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 446);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // InsertButton
            // 
            this.InsertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.Location = new System.Drawing.Point(3, 409);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(382, 34);
            this.InsertButton.TabIndex = 0;
            this.InsertButton.Text = "Insert Item Into Selected Domain";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // insertGrid
            // 
            this.insertGrid.AllowUserToOrderColumns = true;
            this.insertGrid.AllowUserToResizeRows = false;
            this.insertGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insertGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertGrid.Location = new System.Drawing.Point(3, 3);
            this.insertGrid.MultiSelect = false;
            this.insertGrid.Name = "insertGrid";
            this.insertGrid.Size = new System.Drawing.Size(382, 400);
            this.insertGrid.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDomainToolStripMenuItem,
            this.exportDomainToolStripMenuItem,
            this.refreshDomainListToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveAWSPublicKeysToolStripMenuItem,
            this.saveAWSPrivateKeysToolStripMenuItem,
            this.cacheDomainSchemasToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // createDomainToolStripMenuItem
            // 
            this.createDomainToolStripMenuItem.Name = "createDomainToolStripMenuItem";
            this.createDomainToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.createDomainToolStripMenuItem.Text = "Create Domain";
            this.createDomainToolStripMenuItem.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // refreshDomainListToolStripMenuItem
            // 
            this.refreshDomainListToolStripMenuItem.Name = "refreshDomainListToolStripMenuItem";
            this.refreshDomainListToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.refreshDomainListToolStripMenuItem.Text = "Refresh Domain List";
            this.refreshDomainListToolStripMenuItem.Click += new System.EventHandler(this.refreshDomainListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // saveAWSPublicKeysToolStripMenuItem
            // 
            this.saveAWSPublicKeysToolStripMenuItem.Checked = true;
            this.saveAWSPublicKeysToolStripMenuItem.CheckOnClick = true;
            this.saveAWSPublicKeysToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveAWSPublicKeysToolStripMenuItem.Name = "saveAWSPublicKeysToolStripMenuItem";
            this.saveAWSPublicKeysToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveAWSPublicKeysToolStripMenuItem.Text = "Save AWS Public Keys";
            // 
            // saveAWSPrivateKeysToolStripMenuItem
            // 
            this.saveAWSPrivateKeysToolStripMenuItem.Checked = true;
            this.saveAWSPrivateKeysToolStripMenuItem.CheckOnClick = true;
            this.saveAWSPrivateKeysToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveAWSPrivateKeysToolStripMenuItem.Name = "saveAWSPrivateKeysToolStripMenuItem";
            this.saveAWSPrivateKeysToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveAWSPrivateKeysToolStripMenuItem.Text = "Save AWS Private Keys";
            // 
            // cacheDomainSchemasToolStripMenuItem
            // 
            this.cacheDomainSchemasToolStripMenuItem.Checked = true;
            this.cacheDomainSchemasToolStripMenuItem.CheckOnClick = true;
            this.cacheDomainSchemasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cacheDomainSchemasToolStripMenuItem.Name = "cacheDomainSchemasToolStripMenuItem";
            this.cacheDomainSchemasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cacheDomainSchemasToolStripMenuItem.Text = "Cache Domain Schemas";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // parentTable
            // 
            this.parentTable.ColumnCount = 1;
            this.parentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.parentTable.Controls.Add(this.splitContainer1, 0, 0);
            this.parentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentTable.Location = new System.Drawing.Point(0, 24);
            this.parentTable.Name = "parentTable";
            this.parentTable.RowCount = 1;
            this.parentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.parentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.parentTable.Size = new System.Drawing.Size(618, 487);
            this.parentTable.TabIndex = 2;
            // 
            // exportDomainToolStripMenuItem
            // 
            this.exportDomainToolStripMenuItem.Name = "exportDomainToolStripMenuItem";
            this.exportDomainToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exportDomainToolStripMenuItem.Text = "Export Domain";
            this.exportDomainToolStripMenuItem.Click += new System.EventHandler(this.exportDomainToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 511);
            this.Controls.Add(this.parentTable);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "SimpleDB Administrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.leftPaneTable.ResumeLayout(false);
            this.leftPaneTopButtonTable.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.insertGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.parentTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Label lblItemNamesSizeBytes;
        private System.Windows.Forms.Label lblAttributeValuesSizeBytes;
        private System.Windows.Forms.Label lblAttributeValueCount;
        private System.Windows.Forms.Label lblAttributeNameSizeBytes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAttributeNameCount;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox queryText;
        private System.Windows.Forms.Button runQuery;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.DataGridView insertGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel parentTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPercentSize;
        private System.Windows.Forms.Button RefreshMetaData;
        private System.Windows.Forms.TableLayoutPanel leftPaneTable;
        private System.Windows.Forms.TreeView domainList;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button DeleteDomain;
        private System.Windows.Forms.ToolStripMenuItem createDomainToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAWSPublicKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAWSPrivateKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacheDomainSchemasToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel leftPaneTopButtonTable;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolStripMenuItem refreshDomainListToolStripMenuItem;
        private System.Windows.Forms.ImageList domainListImages;
        private System.Windows.Forms.ToolStripMenuItem exportDomainToolStripMenuItem;

    }
}

