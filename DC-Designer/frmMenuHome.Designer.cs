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
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdLogOut = new System.Windows.Forms.Button();
            this.lblUserNameLogged = new System.Windows.Forms.Label();
            this.cmdAddGestionUser = new System.Windows.Forms.Button();
            this.lblFiltreCompany = new System.Windows.Forms.Label();
            this.cmbFiltreCompany = new System.Windows.Forms.ComboBox();
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
            this.cmdNewCompany = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cmbEntreprise = new System.Windows.Forms.ComboBox();
            this.lblEntrepriseCompany = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.cmdRemoveUser = new System.Windows.Forms.Button();
            this.cmdAddUser = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.tabCompanyManager = new System.Windows.Forms.TabPage();
            this.cmdRemoveCompany = new System.Windows.Forms.Button();
            this.txtAddressCompany = new System.Windows.Forms.TextBox();
            this.txtTelCompany = new System.Windows.Forms.TextBox();
            this.txtNameCompany = new System.Windows.Forms.TextBox();
            this.lblAdresseCompany = new System.Windows.Forms.Label();
            this.lblTelCompany = new System.Windows.Forms.Label();
            this.cmdCloseCompanyManager = new System.Windows.Forms.Button();
            this.cmdAddCompany = new System.Windows.Forms.Button();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.lstCompany = new System.Windows.Forms.ListBox();
            this.lblUsersList = new System.Windows.Forms.Label();
            this.lblCompanyList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tblDcDesigner.SuspendLayout();
            this.tabLayout.SuspendLayout();
            this.tabUserManager.SuspendLayout();
            this.tabCompanyManager.SuspendLayout();
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
            this.lblExistingLayout.Text = "&Existing Layout";
            // 
            // cmdCreateNewDC
            // 
            this.cmdCreateNewDC.Location = new System.Drawing.Point(23, 174);
            this.cmdCreateNewDC.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreateNewDC.Name = "cmdCreateNewDC";
            this.cmdCreateNewDC.Size = new System.Drawing.Size(225, 55);
            this.cmdCreateNewDC.TabIndex = 0;
            this.cmdCreateNewDC.Text = "&New Data Center";
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
            this.splitContainer1.Panel1.Controls.Add(this.lblFiltreCompany);
            this.splitContainer1.Panel1.Controls.Add(this.cmbFiltreCompany);
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
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(184, 9);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 26);
            this.cmdExit.TabIndex = 8;
            this.cmdExit.Text = "E&XIT";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // cmdLogOut
            // 
            this.cmdLogOut.Location = new System.Drawing.Point(102, 9);
            this.cmdLogOut.Name = "cmdLogOut";
            this.cmdLogOut.Size = new System.Drawing.Size(75, 26);
            this.cmdLogOut.TabIndex = 7;
            this.cmdLogOut.Text = "&LogOut";
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
            this.cmdAddGestionUser.Size = new System.Drawing.Size(224, 51);
            this.cmdAddGestionUser.TabIndex = 5;
            this.cmdAddGestionUser.Text = "&User Manager";
            this.cmdAddGestionUser.UseVisualStyleBackColor = true;
            this.cmdAddGestionUser.Visible = false;
            this.cmdAddGestionUser.Click += new System.EventHandler(this.CmdAddGestionUser_Click);
            // 
            // lblFiltreCompany
            // 
            this.lblFiltreCompany.AutoSize = true;
            this.lblFiltreCompany.Location = new System.Drawing.Point(20, 247);
            this.lblFiltreCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltreCompany.Name = "lblFiltreCompany";
            this.lblFiltreCompany.Size = new System.Drawing.Size(121, 17);
            this.lblFiltreCompany.TabIndex = 4;
            this.lblFiltreCompany.Text = "&Filter by Company";
            this.lblFiltreCompany.Visible = false;
            // 
            // cmbFiltreCompany
            // 
            this.cmbFiltreCompany.FormattingEnabled = true;
            this.cmbFiltreCompany.Location = new System.Drawing.Point(22, 268);
            this.cmbFiltreCompany.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFiltreCompany.Name = "cmbFiltreCompany";
            this.cmbFiltreCompany.Size = new System.Drawing.Size(155, 24);
            this.cmbFiltreCompany.TabIndex = 3;
            this.cmbFiltreCompany.Visible = false;
            this.cmbFiltreCompany.SelectedIndexChanged += new System.EventHandler(this.CmbClient_SelectedIndexChanged);
            // 
            // tblDcDesigner
            // 
            this.tblDcDesigner.AllowDrop = true;
            this.tblDcDesigner.Controls.Add(this.tabLayout);
            this.tblDcDesigner.Controls.Add(this.tabUserManager);
            this.tblDcDesigner.Controls.Add(this.tabCompanyManager);
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
            this.cmdAddRow.Text = "Add &Row";
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
            this.lblNomDC.Text = "Nom&DC";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(357, 15);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(100, 28);
            this.cmdClose.TabIndex = 10;
            this.cmdClose.Text = "&Close";
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
            this.cmdSave.Text = "&Save";
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
            this.tabUserManager.Controls.Add(this.lblUsersList);
            this.tabUserManager.Controls.Add(this.cmdCloseUserManager);
            this.tabUserManager.Controls.Add(this.cmdNewCompany);
            this.tabUserManager.Controls.Add(this.txtPassword);
            this.tabUserManager.Controls.Add(this.lblPassword);
            this.tabUserManager.Controls.Add(this.cmbEntreprise);
            this.tabUserManager.Controls.Add(this.lblEntrepriseCompany);
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
            this.cmdCloseUserManager.Text = "&Close";
            this.cmdCloseUserManager.UseVisualStyleBackColor = true;
            this.cmdCloseUserManager.Click += new System.EventHandler(this.CmdCloseUserManager_Click);
            // 
            // cmdNewCompany
            // 
            this.cmdNewCompany.Location = new System.Drawing.Point(630, 117);
            this.cmdNewCompany.Name = "cmdNewCompany";
            this.cmdNewCompany.Size = new System.Drawing.Size(122, 26);
            this.cmdNewCompany.TabIndex = 16;
            this.cmdNewCompany.Text = "Ne&w Company";
            this.cmdNewCompany.UseVisualStyleBackColor = true;
            this.cmdNewCompany.Click += new System.EventHandler(this.CmdNewClient_Click);
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
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "&Password";
            // 
            // cmbEntreprise
            // 
            this.cmbEntreprise.FormattingEnabled = true;
            this.cmbEntreprise.Location = new System.Drawing.Point(524, 119);
            this.cmbEntreprise.Name = "cmbEntreprise";
            this.cmbEntreprise.Size = new System.Drawing.Size(100, 24);
            this.cmbEntreprise.TabIndex = 13;
            // 
            // lblEntrepriseCompany
            // 
            this.lblEntrepriseCompany.AutoSize = true;
            this.lblEntrepriseCompany.Location = new System.Drawing.Point(445, 119);
            this.lblEntrepriseCompany.Name = "lblEntrepriseCompany";
            this.lblEntrepriseCompany.Size = new System.Drawing.Size(67, 17);
            this.lblEntrepriseCompany.TabIndex = 12;
            this.lblEntrepriseCompany.Text = "&Company";
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
            this.lblNom.Size = new System.Drawing.Size(73, 17);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Userna&me";
            // 
            // cmdRemoveUser
            // 
            this.cmdRemoveUser.Location = new System.Drawing.Point(259, 47);
            this.cmdRemoveUser.Name = "cmdRemoveUser";
            this.cmdRemoveUser.Size = new System.Drawing.Size(123, 39);
            this.cmdRemoveUser.TabIndex = 6;
            this.cmdRemoveUser.Text = "&Remove User";
            this.cmdRemoveUser.UseVisualStyleBackColor = true;
            this.cmdRemoveUser.Click += new System.EventHandler(this.CmdRemoveUser_Click);
            // 
            // cmdAddUser
            // 
            this.cmdAddUser.Location = new System.Drawing.Point(630, 47);
            this.cmdAddUser.Name = "cmdAddUser";
            this.cmdAddUser.Size = new System.Drawing.Size(122, 39);
            this.cmdAddUser.TabIndex = 5;
            this.cmdAddUser.Text = "&Add User";
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
            this.lstUsers.DoubleClick += new System.EventHandler(this.LstUsers_DoubleClick);
            // 
            // tabCompanyManager
            // 
            this.tabCompanyManager.Controls.Add(this.lblCompanyList);
            this.tabCompanyManager.Controls.Add(this.cmdRemoveCompany);
            this.tabCompanyManager.Controls.Add(this.txtAddressCompany);
            this.tabCompanyManager.Controls.Add(this.txtTelCompany);
            this.tabCompanyManager.Controls.Add(this.txtNameCompany);
            this.tabCompanyManager.Controls.Add(this.lblAdresseCompany);
            this.tabCompanyManager.Controls.Add(this.lblTelCompany);
            this.tabCompanyManager.Controls.Add(this.cmdCloseCompanyManager);
            this.tabCompanyManager.Controls.Add(this.cmdAddCompany);
            this.tabCompanyManager.Controls.Add(this.lblNameCompany);
            this.tabCompanyManager.Controls.Add(this.lstCompany);
            this.tabCompanyManager.Location = new System.Drawing.Point(4, 25);
            this.tabCompanyManager.Name = "tabCompanyManager";
            this.tabCompanyManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompanyManager.Size = new System.Drawing.Size(902, 601);
            this.tabCompanyManager.TabIndex = 2;
            this.tabCompanyManager.Text = "Client Manager";
            this.tabCompanyManager.UseVisualStyleBackColor = true;
            // 
            // cmdRemoveCompany
            // 
            this.cmdRemoveCompany.Location = new System.Drawing.Point(259, 47);
            this.cmdRemoveCompany.Name = "cmdRemoveCompany";
            this.cmdRemoveCompany.Size = new System.Drawing.Size(75, 29);
            this.cmdRemoveCompany.TabIndex = 29;
            this.cmdRemoveCompany.Text = "&Remove";
            this.cmdRemoveCompany.UseVisualStyleBackColor = true;
            this.cmdRemoveCompany.Click += new System.EventHandler(this.CmdRemoveClient_Click);
            // 
            // txtAddressCompany
            // 
            this.txtAddressCompany.Location = new System.Drawing.Point(504, 104);
            this.txtAddressCompany.Name = "txtAddressCompany";
            this.txtAddressCompany.Size = new System.Drawing.Size(100, 22);
            this.txtAddressCompany.TabIndex = 28;
            // 
            // txtTelCompany
            // 
            this.txtTelCompany.Location = new System.Drawing.Point(504, 75);
            this.txtTelCompany.Name = "txtTelCompany";
            this.txtTelCompany.Size = new System.Drawing.Size(100, 22);
            this.txtTelCompany.TabIndex = 27;
            // 
            // txtNameCompany
            // 
            this.txtNameCompany.Location = new System.Drawing.Point(504, 47);
            this.txtNameCompany.Name = "txtNameCompany";
            this.txtNameCompany.Size = new System.Drawing.Size(100, 22);
            this.txtNameCompany.TabIndex = 26;
            // 
            // lblAdresseCompany
            // 
            this.lblAdresseCompany.AutoSize = true;
            this.lblAdresseCompany.Location = new System.Drawing.Point(437, 107);
            this.lblAdresseCompany.Name = "lblAdresseCompany";
            this.lblAdresseCompany.Size = new System.Drawing.Size(60, 17);
            this.lblAdresseCompany.TabIndex = 25;
            this.lblAdresseCompany.Text = "A&dresse";
            // 
            // lblTelCompany
            // 
            this.lblTelCompany.AutoSize = true;
            this.lblTelCompany.Location = new System.Drawing.Point(437, 78);
            this.lblTelCompany.Name = "lblTelCompany";
            this.lblTelCompany.Size = new System.Drawing.Size(28, 17);
            this.lblTelCompany.TabIndex = 24;
            this.lblTelCompany.Text = "&Tel";
            // 
            // cmdCloseCompanyManager
            // 
            this.cmdCloseCompanyManager.Location = new System.Drawing.Point(807, 6);
            this.cmdCloseCompanyManager.Name = "cmdCloseCompanyManager";
            this.cmdCloseCompanyManager.Size = new System.Drawing.Size(60, 26);
            this.cmdCloseCompanyManager.TabIndex = 23;
            this.cmdCloseCompanyManager.Text = "&Close";
            this.cmdCloseCompanyManager.UseVisualStyleBackColor = true;
            this.cmdCloseCompanyManager.Click += new System.EventHandler(this.CmdCloseClientManager_Click);
            // 
            // cmdAddCompany
            // 
            this.cmdAddCompany.Location = new System.Drawing.Point(617, 47);
            this.cmdAddCompany.Name = "cmdAddCompany";
            this.cmdAddCompany.Size = new System.Drawing.Size(111, 30);
            this.cmdAddCompany.TabIndex = 22;
            this.cmdAddCompany.Text = "&Add Company";
            this.cmdAddCompany.UseVisualStyleBackColor = true;
            this.cmdAddCompany.Click += new System.EventHandler(this.CmdAddClient_Click);
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.Location = new System.Drawing.Point(437, 50);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(45, 17);
            this.lblNameCompany.TabIndex = 21;
            this.lblNameCompany.Text = "Na&me";
            // 
            // lstCompany
            // 
            this.lstCompany.FormattingEnabled = true;
            this.lstCompany.ItemHeight = 16;
            this.lstCompany.Location = new System.Drawing.Point(28, 47);
            this.lstCompany.Margin = new System.Windows.Forms.Padding(4);
            this.lstCompany.Name = "lstCompany";
            this.lstCompany.Size = new System.Drawing.Size(224, 212);
            this.lstCompany.TabIndex = 20;
            this.lstCompany.DoubleClick += new System.EventHandler(this.LstCompany_DoubleClick);
            // 
            // lblUsersList
            // 
            this.lblUsersList.AutoSize = true;
            this.lblUsersList.Location = new System.Drawing.Point(28, 23);
            this.lblUsersList.Name = "lblUsersList";
            this.lblUsersList.Size = new System.Drawing.Size(71, 17);
            this.lblUsersList.TabIndex = 22;
            this.lblUsersList.Text = "Users &List";
            // 
            // lblCompanyList
            // 
            this.lblCompanyList.AutoSize = true;
            this.lblCompanyList.Location = new System.Drawing.Point(27, 20);
            this.lblCompanyList.Name = "lblCompanyList";
            this.lblCompanyList.Size = new System.Drawing.Size(100, 17);
            this.lblCompanyList.TabIndex = 30;
            this.lblCompanyList.Text = "Companys &List";
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
            this.tabCompanyManager.ResumeLayout(false);
            this.tabCompanyManager.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbFiltreCompany;
        private System.Windows.Forms.Label lblFiltreCompany;
        private System.Windows.Forms.Button cmdAddGestionUser;
        private System.Windows.Forms.TabPage tabCompanyManager;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.ListBox lstCompany;
        private System.Windows.Forms.Button cmdCloseCompanyManager;
        private System.Windows.Forms.Button cmdAddCompany;
        private System.Windows.Forms.TabPage tabUserManager;
        private System.Windows.Forms.Button cmdCloseUserManager;
        private System.Windows.Forms.Button cmdNewCompany;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cmbEntreprise;
        private System.Windows.Forms.Label lblEntrepriseCompany;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button cmdRemoveUser;
        private System.Windows.Forms.Button cmdAddUser;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button cmdRemoveCompany;
        private System.Windows.Forms.TextBox txtAddressCompany;
        private System.Windows.Forms.TextBox txtTelCompany;
        private System.Windows.Forms.TextBox txtNameCompany;
        private System.Windows.Forms.Label lblAdresseCompany;
        private System.Windows.Forms.Label lblTelCompany;
        private System.Windows.Forms.Button cmdLogOut;
        private System.Windows.Forms.Label lblUserNameLogged;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblUsersList;
        private System.Windows.Forms.Label lblCompanyList;
    }
}