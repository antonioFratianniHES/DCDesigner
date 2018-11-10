namespace DC_Designer
{
    partial class FrmMenuHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstExistingLayout = new System.Windows.Forms.ListBox();
            this.lblExistingLayout = new System.Windows.Forms.Label();
            this.cmdCreateNewDC = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmdLogOut = new System.Windows.Forms.Button();
            this.lblUserNameLogged = new System.Windows.Forms.Label();
            this.cmdAddGestionUser = new System.Windows.Forms.Button();
            this.lblFiltreClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.tblDcDesigner = new System.Windows.Forms.TabControl();
            this.tabLayout = new System.Windows.Forms.TabPage();
            this.cmdAddRow = new System.Windows.Forms.Button();
            this.txtNomDC = new System.Windows.Forms.TextBox();
            this.lblNomDC = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.dcLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tabUserManager = new System.Windows.Forms.TabPage();
            this.cmdCloseUserManager = new System.Windows.Forms.Button();
            this.cmdNewClient = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cmbEntreprise = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.cmdRemoveUser = new System.Windows.Forms.Button();
            this.cmdAddUser = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.tabClientManager = new System.Windows.Forms.TabPage();
            this.cmdRemoveClient = new System.Windows.Forms.Button();
            this.txtAddressClient = new System.Windows.Forms.TextBox();
            this.txtTelClient = new System.Windows.Forms.TextBox();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.lblAdresseClient = new System.Windows.Forms.Label();
            this.lblTelClient = new System.Windows.Forms.Label();
            this.cmdCloseClientManager = new System.Windows.Forms.Button();
            this.cmdAddClient = new System.Windows.Forms.Button();
            this.lblNameClient = new System.Windows.Forms.Label();
            this.lstClient = new System.Windows.Forms.ListBox();
            this.cmdExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tblDcDesigner.SuspendLayout();
            this.tabLayout.SuspendLayout();
            this.tabUserManager.SuspendLayout();
            this.tabClientManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstExistingLayout
            // 
            this.lstExistingLayout.FormattingEnabled = true;
            this.lstExistingLayout.ItemHeight = 16;
            this.lstExistingLayout.Location = new System.Drawing.Point(23, 315);
            this.lstExistingLayout.Margin = new System.Windows.Forms.Padding(4);
            this.lstExistingLayout.Name = "lstExistingLayout";
            this.lstExistingLayout.Size = new System.Drawing.Size(224, 244);
            this.lstExistingLayout.TabIndex = 1;
            this.lstExistingLayout.DoubleClick += new System.EventHandler(this.LstExistingDC_DoubleClick);
            // 
            // lblExistingLayout
            // 
            this.lblExistingLayout.AutoSize = true;
            this.lblExistingLayout.Location = new System.Drawing.Point(19, 295);
            this.lblExistingLayout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExistingLayout.Name = "lblExistingLayout";
            this.lblExistingLayout.Size = new System.Drawing.Size(103, 17);
            this.lblExistingLayout.TabIndex = 2;
            this.lblExistingLayout.Text = "Existing Layout";
            // 
            // cmdCreateNewDC
            // 
            this.cmdCreateNewDC.Location = new System.Drawing.Point(23, 174);
            this.cmdCreateNewDC.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreateNewDC.Name = "cmdCreateNewDC";
            this.cmdCreateNewDC.Size = new System.Drawing.Size(225, 69);
            this.cmdCreateNewDC.TabIndex = 0;
            this.cmdCreateNewDC.Text = "New Data Center";
            this.cmdCreateNewDC.UseVisualStyleBackColor = true;
            this.cmdCreateNewDC.Click += new System.EventHandler(this.CmdCreateNewDC_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.cmdExit);
            this.splitContainer1.Panel1.Controls.Add(this.cmdLogOut);
            this.splitContainer1.Panel1.Controls.Add(this.lblUserNameLogged);
            this.splitContainer1.Panel1.Controls.Add(this.cmdAddGestionUser);
            this.splitContainer1.Panel1.Controls.Add(this.lblFiltreClient);
            this.splitContainer1.Panel1.Controls.Add(this.cmbClient);
            this.splitContainer1.Panel1.Controls.Add(this.cmdCreateNewDC);
            this.splitContainer1.Panel1.Controls.Add(this.lstExistingLayout);
            this.splitContainer1.Panel1.Controls.Add(this.lblExistingLayout);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tblDcDesigner);
            this.splitContainer1.Size = new System.Drawing.Size(1185, 630);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 6;
            // 
            // cmdLogOut
            // 
            this.cmdLogOut.Location = new System.Drawing.Point(102, 9);
            this.cmdLogOut.Name = "cmdLogOut";
            this.cmdLogOut.Size = new System.Drawing.Size(75, 26);
            this.cmdLogOut.TabIndex = 7;
            this.cmdLogOut.Text = "LogOut";
            this.cmdLogOut.UseVisualStyleBackColor = true;
            this.cmdLogOut.Click += new System.EventHandler(this.CmdLogOut_Click);
            // 
            // lblUserNameLogged
            // 
            this.lblUserNameLogged.AutoSize = true;
            this.lblUserNameLogged.Location = new System.Drawing.Point(23, 12);
            this.lblUserNameLogged.Name = "lblUserNameLogged";
            this.lblUserNameLogged.Size = new System.Drawing.Size(73, 17);
            this.lblUserNameLogged.TabIndex = 6;
            this.lblUserNameLogged.Text = "userName";
            // 
            // cmdAddGestionUser
            // 
            this.cmdAddGestionUser.Location = new System.Drawing.Point(23, 86);
            this.cmdAddGestionUser.Name = "cmdAddGestionUser";
            this.cmdAddGestionUser.Size = new System.Drawing.Size(224, 67);
            this.cmdAddGestionUser.TabIndex = 5;
            this.cmdAddGestionUser.Text = "User Manager";
            this.cmdAddGestionUser.UseVisualStyleBackColor = true;
            this.cmdAddGestionUser.Visible = false;
            this.cmdAddGestionUser.Click += new System.EventHandler(this.CmdAddGestionUser_Click);
            // 
            // lblFiltreClient
            // 
            this.lblFiltreClient.AutoSize = true;
            this.lblFiltreClient.Location = new System.Drawing.Point(19, 270);
            this.lblFiltreClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltreClient.Name = "lblFiltreClient";
            this.lblFiltreClient.Size = new System.Drawing.Size(93, 17);
            this.lblFiltreClient.TabIndex = 4;
            this.lblFiltreClient.Text = "filter by Client";
            this.lblFiltreClient.Visible = false;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(118, 267);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(130, 24);
            this.cmbClient.TabIndex = 3;
            this.cmbClient.Visible = false;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.CmbClient_SelectedIndexChanged);
            // 
            // tblDcDesigner
            // 
            this.tblDcDesigner.AllowDrop = true;
            this.tblDcDesigner.Controls.Add(this.tabLayout);
            this.tblDcDesigner.Controls.Add(this.tabUserManager);
            this.tblDcDesigner.Controls.Add(this.tabClientManager);
            this.tblDcDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDcDesigner.Location = new System.Drawing.Point(0, 0);
            this.tblDcDesigner.Margin = new System.Windows.Forms.Padding(4);
            this.tblDcDesigner.Name = "tblDcDesigner";
            this.tblDcDesigner.SelectedIndex = 0;
            this.tblDcDesigner.Size = new System.Drawing.Size(910, 630);
            this.tblDcDesigner.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tblDcDesigner.TabIndex = 0;
            this.tblDcDesigner.Visible = false;
            // 
            // tabLayout
            // 
            this.tabLayout.AutoScroll = true;
            this.tabLayout.Controls.Add(this.cmdAddRow);
            this.tabLayout.Controls.Add(this.txtNomDC);
            this.tabLayout.Controls.Add(this.lblNomDC);
            this.tabLayout.Controls.Add(this.cmdClose);
            this.tabLayout.Controls.Add(this.cmdSave);
            this.tabLayout.Controls.Add(this.dcLayout);
            this.tabLayout.Location = new System.Drawing.Point(4, 25);
            this.tabLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLayout.Size = new System.Drawing.Size(902, 601);
            this.tabLayout.TabIndex = 0;
            this.tabLayout.Text = "Layout";
            this.tabLayout.UseVisualStyleBackColor = true;
            // 
            // cmdAddRow
            // 
            this.cmdAddRow.Location = new System.Drawing.Point(24, 49);
            this.cmdAddRow.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAddRow.Name = "cmdAddRow";
            this.cmdAddRow.Size = new System.Drawing.Size(100, 28);
            this.cmdAddRow.TabIndex = 14;
            this.cmdAddRow.Text = "Add Row";
            this.cmdAddRow.UseVisualStyleBackColor = true;
            this.cmdAddRow.Click += new System.EventHandler(this.CmdAddRow_Click);
            // 
            // txtNomDC
            // 
            this.txtNomDC.AllowDrop = true;
            this.txtNomDC.Location = new System.Drawing.Point(87, 17);
            this.txtNomDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomDC.Name = "txtNomDC";
            this.txtNomDC.Size = new System.Drawing.Size(132, 22);
            this.txtNomDC.TabIndex = 12;
            // 
            // lblNomDC
            // 
            this.lblNomDC.AutoSize = true;
            this.lblNomDC.Location = new System.Drawing.Point(20, 21);
            this.lblNomDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomDC.Name = "lblNomDC";
            this.lblNomDC.Size = new System.Drawing.Size(56, 17);
            this.lblNomDC.TabIndex = 11;
            this.lblNomDC.Text = "NomDC";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(357, 15);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(100, 28);
            this.cmdClose.TabIndex = 10;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(237, 15);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 28);
            this.cmdSave.TabIndex = 9;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // dcLayout
            // 
            this.dcLayout.AllowDrop = true;
            this.dcLayout.AutoSize = true;
            this.dcLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dcLayout.ColumnCount = 2;
            this.dcLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dcLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dcLayout.Location = new System.Drawing.Point(24, 75);
            this.dcLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dcLayout.Name = "dcLayout";
            this.dcLayout.RowCount = 1;
            this.dcLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dcLayout.Size = new System.Drawing.Size(0, 0);
            this.dcLayout.TabIndex = 0;
            // 
            // tabUserManager
            // 
            this.tabUserManager.Controls.Add(this.cmdCloseUserManager);
            this.tabUserManager.Controls.Add(this.cmdNewClient);
            this.tabUserManager.Controls.Add(this.txtPassword);
            this.tabUserManager.Controls.Add(this.lblPassword);
            this.tabUserManager.Controls.Add(this.cmbEntreprise);
            this.tabUserManager.Controls.Add(this.lblClient);
            this.tabUserManager.Controls.Add(this.txtUserName);
            this.tabUserManager.Controls.Add(this.lblNom);
            this.tabUserManager.Controls.Add(this.cmdRemoveUser);
            this.tabUserManager.Controls.Add(this.cmdAddUser);
            this.tabUserManager.Controls.Add(this.lstUsers);
            this.tabUserManager.Location = new System.Drawing.Point(4, 25);
            this.tabUserManager.Name = "tabUserManager";
            this.tabUserManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserManager.Size = new System.Drawing.Size(902, 601);
            this.tabUserManager.TabIndex = 1;
            this.tabUserManager.Text = "User Manager";
            this.tabUserManager.UseVisualStyleBackColor = true;
            // 
            // cmdCloseUserManager
            // 
            this.cmdCloseUserManager.Location = new System.Drawing.Point(807, 6);
            this.cmdCloseUserManager.Name = "cmdCloseUserManager";
            this.cmdCloseUserManager.Size = new System.Drawing.Size(60, 26);
            this.cmdCloseUserManager.TabIndex = 21;
            this.cmdCloseUserManager.Text = "Close";
            this.cmdCloseUserManager.UseVisualStyleBackColor = true;
            this.cmdCloseUserManager.Click += new System.EventHandler(this.CmdCloseUserManager_Click);
            // 
            // cmdNewClient
            // 
            this.cmdNewClient.Location = new System.Drawing.Point(630, 117);
            this.cmdNewClient.Name = "cmdNewClient";
            this.cmdNewClient.Size = new System.Drawing.Size(100, 26);
            this.cmdNewClient.TabIndex = 16;
            this.cmdNewClient.Text = "New Client";
            this.cmdNewClient.UseVisualStyleBackColor = true;
            this.cmdNewClient.Click += new System.EventHandler(this.CmdNewClient_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(524, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(445, 84);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 17);
            this.lblPassword.TabIndex = 14;
            // 
            // cmbEntreprise
            // 
            this.cmbEntreprise.FormattingEnabled = true;
            this.cmbEntreprise.Location = new System.Drawing.Point(524, 119);
            this.cmbEntreprise.Name = "cmbEntreprise";
            this.cmbEntreprise.Size = new System.Drawing.Size(100, 24);
            this.cmbEntreprise.TabIndex = 13;
            this.cmbEntreprise.TextChanged += new System.EventHandler(this.CmbEntreprise_TextChanged);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(445, 119);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(0, 17);
            this.lblClient.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(524, 47);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 11;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(445, 50);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(0, 17);
            this.lblNom.TabIndex = 10;
            // 
            // cmdRemoveUser
            // 
            this.cmdRemoveUser.Location = new System.Drawing.Point(259, 47);
            this.cmdRemoveUser.Name = "cmdRemoveUser";
            this.cmdRemoveUser.Size = new System.Drawing.Size(123, 39);
            this.cmdRemoveUser.TabIndex = 6;
            this.cmdRemoveUser.Text = "Remove User";
            this.cmdRemoveUser.UseVisualStyleBackColor = true;
            this.cmdRemoveUser.Click += new System.EventHandler(this.CmdRemoveUser_Click);
            // 
            // cmdAddUser
            // 
            this.cmdAddUser.Location = new System.Drawing.Point(630, 47);
            this.cmdAddUser.Name = "cmdAddUser";
            this.cmdAddUser.Size = new System.Drawing.Size(100, 39);
            this.cmdAddUser.TabIndex = 5;
            this.cmdAddUser.Text = "Add User";
            this.cmdAddUser.UseVisualStyleBackColor = true;
            this.cmdAddUser.Click += new System.EventHandler(this.CmdAddUser_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 16;
            this.lstUsers.Location = new System.Drawing.Point(28, 47);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(4);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(224, 212);
            this.lstUsers.TabIndex = 2;
            // 
            // tabClientManager
            // 
            this.tabClientManager.Controls.Add(this.cmdRemoveClient);
            this.tabClientManager.Controls.Add(this.txtAddressClient);
            this.tabClientManager.Controls.Add(this.txtTelClient);
            this.tabClientManager.Controls.Add(this.txtNameClient);
            this.tabClientManager.Controls.Add(this.lblAdresseClient);
            this.tabClientManager.Controls.Add(this.lblTelClient);
            this.tabClientManager.Controls.Add(this.cmdCloseClientManager);
            this.tabClientManager.Controls.Add(this.cmdAddClient);
            this.tabClientManager.Controls.Add(this.lblNameClient);
            this.tabClientManager.Controls.Add(this.lstClient);
            this.tabClientManager.Location = new System.Drawing.Point(4, 25);
            this.tabClientManager.Name = "tabClientManager";
            this.tabClientManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientManager.Size = new System.Drawing.Size(902, 601);
            this.tabClientManager.TabIndex = 2;
            this.tabClientManager.Text = "Client Manager";
            this.tabClientManager.UseVisualStyleBackColor = true;
            // 
            // cmdRemoveClient
            // 
            this.cmdRemoveClient.Location = new System.Drawing.Point(27, 252);
            this.cmdRemoveClient.Name = "cmdRemoveClient";
            this.cmdRemoveClient.Size = new System.Drawing.Size(75, 29);
            this.cmdRemoveClient.TabIndex = 29;
            this.cmdRemoveClient.Text = "Remove";
            this.cmdRemoveClient.UseVisualStyleBackColor = true;
            this.cmdRemoveClient.Click += new System.EventHandler(this.CmdRemoveClient_Click);
            // 
            // txtAddressClient
            // 
            this.txtAddressClient.Location = new System.Drawing.Point(451, 90);
            this.txtAddressClient.Name = "txtAddressClient";
            this.txtAddressClient.Size = new System.Drawing.Size(100, 22);
            this.txtAddressClient.TabIndex = 28;
            // 
            // txtTelClient
            // 
            this.txtTelClient.Location = new System.Drawing.Point(451, 61);
            this.txtTelClient.Name = "txtTelClient";
            this.txtTelClient.Size = new System.Drawing.Size(100, 22);
            this.txtTelClient.TabIndex = 27;
            // 
            // txtNameClient
            // 
            this.txtNameClient.Location = new System.Drawing.Point(451, 33);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(100, 22);
            this.txtNameClient.TabIndex = 26;
            // 
            // lblAdresseClient
            // 
            this.lblAdresseClient.AutoSize = true;
            this.lblAdresseClient.Location = new System.Drawing.Point(384, 93);
            this.lblAdresseClient.Name = "lblAdresseClient";
            this.lblAdresseClient.Size = new System.Drawing.Size(59, 17);
            this.lblAdresseClient.TabIndex = 25;
            this.lblAdresseClient.Text = "adresse";
            // 
            // lblTelClient
            // 
            this.lblTelClient.AutoSize = true;
            this.lblTelClient.Location = new System.Drawing.Point(384, 64);
            this.lblTelClient.Name = "lblTelClient";
            this.lblTelClient.Size = new System.Drawing.Size(23, 17);
            this.lblTelClient.TabIndex = 24;
            this.lblTelClient.Text = "tel";
            // 
            // cmdCloseClientManager
            // 
            this.cmdCloseClientManager.Location = new System.Drawing.Point(810, 6);
            this.cmdCloseClientManager.Name = "cmdCloseClientManager";
            this.cmdCloseClientManager.Size = new System.Drawing.Size(60, 26);
            this.cmdCloseClientManager.TabIndex = 23;
            this.cmdCloseClientManager.Text = "Close";
            this.cmdCloseClientManager.UseVisualStyleBackColor = true;
            this.cmdCloseClientManager.Click += new System.EventHandler(this.CmdCloseClientManager_Click);
            // 
            // cmdAddClient
            // 
            this.cmdAddClient.Location = new System.Drawing.Point(591, 36);
            this.cmdAddClient.Name = "cmdAddClient";
            this.cmdAddClient.Size = new System.Drawing.Size(90, 23);
            this.cmdAddClient.TabIndex = 22;
            this.cmdAddClient.Text = "Add Client";
            this.cmdAddClient.UseVisualStyleBackColor = true;
            this.cmdAddClient.Click += new System.EventHandler(this.CmdAddClient_Click);
            // 
            // lblNameClient
            // 
            this.lblNameClient.AutoSize = true;
            this.lblNameClient.Location = new System.Drawing.Point(384, 36);
            this.lblNameClient.Name = "lblNameClient";
            this.lblNameClient.Size = new System.Drawing.Size(45, 17);
            this.lblNameClient.TabIndex = 21;
            this.lblNameClient.Text = "Name";
            // 
            // lstClient
            // 
            this.lstClient.FormattingEnabled = true;
            this.lstClient.ItemHeight = 16;
            this.lstClient.Location = new System.Drawing.Point(27, 30);
            this.lstClient.Margin = new System.Windows.Forms.Padding(4);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(224, 196);
            this.lstClient.TabIndex = 20;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(184, 9);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 26);
            this.cmdExit.TabIndex = 8;
            this.cmdExit.Text = "EXIT";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // FrmMenuHome
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1183, 633);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1194, 660);
            this.Name = "FrmMenuHome";
            this.Text = "MenuHome";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tblDcDesigner.ResumeLayout(false);
            this.tabLayout.ResumeLayout(false);
            this.tabLayout.PerformLayout();
            this.tabUserManager.ResumeLayout(false);
            this.tabUserManager.PerformLayout();
            this.tabClientManager.ResumeLayout(false);
            this.tabClientManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstExistingLayout;
        private System.Windows.Forms.Label lblExistingLayout;
        private System.Windows.Forms.Button cmdCreateNewDC;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tblDcDesigner;
        private System.Windows.Forms.TabPage tabLayout;
        private System.Windows.Forms.TableLayoutPanel dcLayout;
        private System.Windows.Forms.TextBox txtNomDC;
        private System.Windows.Forms.Label lblNomDC;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdAddRow;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblFiltreClient;
        private System.Windows.Forms.Button cmdAddGestionUser;
        private System.Windows.Forms.TabPage tabClientManager;
        private System.Windows.Forms.Label lblNameClient;
        private System.Windows.Forms.ListBox lstClient;
        private System.Windows.Forms.Button cmdCloseClientManager;
        private System.Windows.Forms.Button cmdAddClient;
        private System.Windows.Forms.TabPage tabUserManager;
        private System.Windows.Forms.Button cmdCloseUserManager;
        private System.Windows.Forms.Button cmdNewClient;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cmbEntreprise;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button cmdRemoveUser;
        private System.Windows.Forms.Button cmdAddUser;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button cmdRemoveClient;
        private System.Windows.Forms.TextBox txtAddressClient;
        private System.Windows.Forms.TextBox txtTelClient;
        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.Label lblAdresseClient;
        private System.Windows.Forms.Label lblTelClient;
        private System.Windows.Forms.Button cmdLogOut;
        private System.Windows.Forms.Label lblUserNameLogged;
        private System.Windows.Forms.Button cmdExit;
    }
}