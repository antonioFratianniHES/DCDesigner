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
            this.components = new System.ComponentModel.Container();
            this.lstExistingLayout = new System.Windows.Forms.ListBox();
            this.dataSetDataFinal = new DC_Designer.DataSetDataFinal();
            this.lblExistingLayout = new System.Windows.Forms.Label();
            this.cmdCreateNewDC = new System.Windows.Forms.Button();
            this.spltHomeMenu = new System.Windows.Forms.SplitContainer();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdLogOut = new System.Windows.Forms.Button();
            this.lblUserNameLogged = new System.Windows.Forms.Label();
            this.cmdAddGestionUser = new System.Windows.Forms.Button();
            this.lblFiltreCompany = new System.Windows.Forms.Label();
            this.cmbFiltreCompany = new System.Windows.Forms.ComboBox();
            this.tblDcDesigner = new System.Windows.Forms.TabControl();
            this.tabLayout = new System.Windows.Forms.TabPage();
            this.pnlLayout = new System.Windows.Forms.Panel();
            this.cmdAddRow = new System.Windows.Forms.Button();
            this.txtNomDC = new System.Windows.Forms.TextBox();
            this.lblNomDC = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.dcLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tabUserManager = new System.Windows.Forms.TabPage();
            this.cmdEditUser = new System.Windows.Forms.Button();
            this.lblUsersList = new System.Windows.Forms.Label();
            this.cmdCloseUserManager = new System.Windows.Forms.Button();
            this.cmdNewCompany = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cmbUserCompany = new System.Windows.Forms.ComboBox();
            this.lblEntrepriseCompany = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.cmdRemoveUser = new System.Windows.Forms.Button();
            this.cmdAddUser = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.tabCompanyManager = new System.Windows.Forms.TabPage();
            this.cmdEditCompany = new System.Windows.Forms.Button();
            this.lblCompanyList = new System.Windows.Forms.Label();
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
            this.tabEditUser = new System.Windows.Forms.TabPage();
            this.cmdCloseUser = new System.Windows.Forms.Button();
            this.cmdNewCompanyEdit = new System.Windows.Forms.Button();
            this.txtEditUserPassword = new System.Windows.Forms.TextBox();
            this.lblEditUserPassword = new System.Windows.Forms.Label();
            this.cmbEditUserCompany = new System.Windows.Forms.ComboBox();
            this.lblEditUserCompany = new System.Windows.Forms.Label();
            this.txtEditUserUsername = new System.Windows.Forms.TextBox();
            this.lblEditUserUsername = new System.Windows.Forms.Label();
            this.cmdModfiyUser = new System.Windows.Forms.Button();
            this.tabEditCompany = new System.Windows.Forms.TabPage();
            this.cmdCloseCompany = new System.Windows.Forms.Button();
            this.txtEditCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtEditCompanyTel = new System.Windows.Forms.TextBox();
            this.txtEditCompanyName = new System.Windows.Forms.TextBox();
            this.lblEditCompanyAddress = new System.Windows.Forms.Label();
            this.lblEditCompanyTel = new System.Windows.Forms.Label();
            this.cmdModifyCompany = new System.Windows.Forms.Button();
            this.lblEditCompanyName = new System.Windows.Forms.Label();
            this.cOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPANYTableAdapter = new DC_Designer.DataSetDataFinalTableAdapters.COMPANYTableAdapter();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new DC_Designer.DataSetDataFinalTableAdapters.EMPLOYEETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDataFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltHomeMenu)).BeginInit();
            this.spltHomeMenu.Panel1.SuspendLayout();
            this.spltHomeMenu.Panel2.SuspendLayout();
            this.spltHomeMenu.SuspendLayout();
            this.tblDcDesigner.SuspendLayout();
            this.tabLayout.SuspendLayout();
            this.tabUserManager.SuspendLayout();
            this.tabCompanyManager.SuspendLayout();
            this.tabEditUser.SuspendLayout();
            this.tabEditCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstExistingLayout
            // 
            this.lstExistingLayout.DisplayMember = "DCNAME";
            this.lstExistingLayout.FormattingEnabled = true;
            this.lstExistingLayout.ItemHeight = 16;
            this.lstExistingLayout.Location = new System.Drawing.Point(12, 316);
            this.lstExistingLayout.Margin = new System.Windows.Forms.Padding(4);
            this.lstExistingLayout.Name = "lstExistingLayout";
            this.lstExistingLayout.Size = new System.Drawing.Size(224, 244);
            this.lstExistingLayout.TabIndex = 2;
            this.lstExistingLayout.DoubleClick += new System.EventHandler(this.LstExistingDC_DoubleClick);
            // 
            // dataSetDataFinal
            // 
            this.dataSetDataFinal.DataSetName = "DataSetDataFinal";
            this.dataSetDataFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblExistingLayout
            // 
            this.lblExistingLayout.AutoSize = true;
            this.lblExistingLayout.Location = new System.Drawing.Point(19, 295);
            this.lblExistingLayout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExistingLayout.Name = "lblExistingLayout";
            this.lblExistingLayout.Size = new System.Drawing.Size(103, 17);
            this.lblExistingLayout.TabIndex = 1;
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
            // spltHomeMenu
            // 
            this.spltHomeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltHomeMenu.IsSplitterFixed = true;
            this.spltHomeMenu.Location = new System.Drawing.Point(1, 1);
            this.spltHomeMenu.Margin = new System.Windows.Forms.Padding(4);
            this.spltHomeMenu.Name = "spltHomeMenu";
            // 
            // spltHomeMenu.Panel1
            // 
            this.spltHomeMenu.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spltHomeMenu.Panel1.Controls.Add(this.cmdExit);
            this.spltHomeMenu.Panel1.Controls.Add(this.cmdLogOut);
            this.spltHomeMenu.Panel1.Controls.Add(this.lblUserNameLogged);
            this.spltHomeMenu.Panel1.Controls.Add(this.cmdAddGestionUser);
            this.spltHomeMenu.Panel1.Controls.Add(this.lblFiltreCompany);
            this.spltHomeMenu.Panel1.Controls.Add(this.cmbFiltreCompany);
            this.spltHomeMenu.Panel1.Controls.Add(this.cmdCreateNewDC);
            this.spltHomeMenu.Panel1.Controls.Add(this.lstExistingLayout);
            this.spltHomeMenu.Panel1.Controls.Add(this.lblExistingLayout);
            // 
            // spltHomeMenu.Panel2
            // 
            this.spltHomeMenu.Panel2.Controls.Add(this.tblDcDesigner);
            this.spltHomeMenu.Size = new System.Drawing.Size(1185, 630);
            this.spltHomeMenu.SplitterDistance = 269;
            this.spltHomeMenu.SplitterWidth = 5;
            this.spltHomeMenu.TabIndex = 6;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(184, 9);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 26);
            this.cmdExit.TabIndex = 8;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // cmdLogOut
            // 
            this.cmdLogOut.Location = new System.Drawing.Point(101, 9);
            this.cmdLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdLogOut.Name = "cmdLogOut";
            this.cmdLogOut.Size = new System.Drawing.Size(75, 26);
            this.cmdLogOut.TabIndex = 7;
            this.cmdLogOut.Text = "&Log Out";
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
            this.cmdAddGestionUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdAddGestionUser.Name = "cmdAddGestionUser";
            this.cmdAddGestionUser.Size = new System.Drawing.Size(224, 50);
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
            this.lblFiltreCompany.TabIndex = 3;
            this.lblFiltreCompany.Text = "&Filter by Company";
            this.lblFiltreCompany.Visible = false;
            // 
            // cmbFiltreCompany
            // 
            this.cmbFiltreCompany.DataSource = this.cOMPANYBindingSource;
            this.cmbFiltreCompany.DisplayMember = "CONAME";
            this.cmbFiltreCompany.FormattingEnabled = true;
            this.cmbFiltreCompany.Location = new System.Drawing.Point(21, 268);
            this.cmbFiltreCompany.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFiltreCompany.Name = "cmbFiltreCompany";
            this.cmbFiltreCompany.Size = new System.Drawing.Size(155, 24);
            this.cmbFiltreCompany.TabIndex = 4;
            this.cmbFiltreCompany.Visible = false;
            this.cmbFiltreCompany.SelectedIndexChanged += new System.EventHandler(this.CmbClient_SelectedIndexChanged);
            // 
            // tblDcDesigner
            // 
            this.tblDcDesigner.AllowDrop = true;
            this.tblDcDesigner.Controls.Add(this.tabLayout);
            this.tblDcDesigner.Controls.Add(this.tabUserManager);
            this.tblDcDesigner.Controls.Add(this.tabCompanyManager);
            this.tblDcDesigner.Controls.Add(this.tabEditUser);
            this.tblDcDesigner.Controls.Add(this.tabEditCompany);
            this.tblDcDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDcDesigner.Location = new System.Drawing.Point(0, 0);
            this.tblDcDesigner.Margin = new System.Windows.Forms.Padding(4);
            this.tblDcDesigner.Name = "tblDcDesigner";
            this.tblDcDesigner.SelectedIndex = 0;
            this.tblDcDesigner.Size = new System.Drawing.Size(911, 630);
            this.tblDcDesigner.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tblDcDesigner.TabIndex = 0;
            this.tblDcDesigner.Visible = false;
            // 
            // tabLayout
            // 
            this.tabLayout.AutoScroll = true;
            this.tabLayout.Controls.Add(this.pnlLayout);
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
            this.tabLayout.Size = new System.Drawing.Size(903, 601);
            this.tabLayout.TabIndex = 0;
            this.tabLayout.Text = "Layout";
            this.tabLayout.UseVisualStyleBackColor = true;
            // 
            // pnlLayout
            // 
            this.pnlLayout.AllowDrop = true;
            this.pnlLayout.AutoSize = true;
            this.pnlLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLayout.Location = new System.Drawing.Point(8, 86);
            this.pnlLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Size = new System.Drawing.Size(0, 0);
            this.pnlLayout.TabIndex = 6;
            // 
            // cmdAddRow
            // 
            this.cmdAddRow.Location = new System.Drawing.Point(24, 49);
            this.cmdAddRow.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAddRow.Name = "cmdAddRow";
            this.cmdAddRow.Size = new System.Drawing.Size(100, 28);
            this.cmdAddRow.TabIndex = 5;
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
            this.txtNomDC.TabIndex = 2;
            // 
            // lblNomDC
            // 
            this.lblNomDC.AutoSize = true;
            this.lblNomDC.Location = new System.Drawing.Point(20, 21);
            this.lblNomDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomDC.Name = "lblNomDC";
            this.lblNomDC.Size = new System.Drawing.Size(56, 17);
            this.lblNomDC.TabIndex = 1;
            this.lblNomDC.Text = "Nom&DC";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(807, 6);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(60, 26);
            this.cmdClose.TabIndex = 4;
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
            this.cmdSave.TabIndex = 3;
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
            this.tabUserManager.Controls.Add(this.cmdEditUser);
            this.tabUserManager.Controls.Add(this.lblUsersList);
            this.tabUserManager.Controls.Add(this.cmdCloseUserManager);
            this.tabUserManager.Controls.Add(this.cmdNewCompany);
            this.tabUserManager.Controls.Add(this.txtPassword);
            this.tabUserManager.Controls.Add(this.lblPassword);
            this.tabUserManager.Controls.Add(this.cmbUserCompany);
            this.tabUserManager.Controls.Add(this.lblEntrepriseCompany);
            this.tabUserManager.Controls.Add(this.txtUserName);
            this.tabUserManager.Controls.Add(this.lblNom);
            this.tabUserManager.Controls.Add(this.cmdRemoveUser);
            this.tabUserManager.Controls.Add(this.cmdAddUser);
            this.tabUserManager.Controls.Add(this.lstUsers);
            this.tabUserManager.Location = new System.Drawing.Point(4, 25);
            this.tabUserManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUserManager.Name = "tabUserManager";
            this.tabUserManager.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUserManager.Size = new System.Drawing.Size(903, 601);
            this.tabUserManager.TabIndex = 1;
            this.tabUserManager.Text = "User Manager";
            this.tabUserManager.UseVisualStyleBackColor = true;
            // 
            // cmdEditUser
            // 
            this.cmdEditUser.Location = new System.Drawing.Point(259, 92);
            this.cmdEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEditUser.Name = "cmdEditUser";
            this.cmdEditUser.Size = new System.Drawing.Size(123, 39);
            this.cmdEditUser.TabIndex = 23;
            this.cmdEditUser.Text = "E&dit";
            this.cmdEditUser.UseVisualStyleBackColor = true;
            this.cmdEditUser.Click += new System.EventHandler(this.CmdEditUser_Click);
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
            // cmdCloseUserManager
            // 
            this.cmdCloseUserManager.Location = new System.Drawing.Point(807, 6);
            this.cmdCloseUserManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdCloseUserManager.Name = "cmdCloseUserManager";
            this.cmdCloseUserManager.Size = new System.Drawing.Size(60, 26);
            this.cmdCloseUserManager.TabIndex = 21;
            this.cmdCloseUserManager.Text = "&Close";
            this.cmdCloseUserManager.UseVisualStyleBackColor = true;
            this.cmdCloseUserManager.Click += new System.EventHandler(this.CmdCloseUserManager_Click);
            // 
            // cmdNewCompany
            // 
            this.cmdNewCompany.Location = new System.Drawing.Point(629, 117);
            this.cmdNewCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdNewCompany.Name = "cmdNewCompany";
            this.cmdNewCompany.Size = new System.Drawing.Size(123, 26);
            this.cmdNewCompany.TabIndex = 16;
            this.cmdNewCompany.Text = "Ne&w Company";
            this.cmdNewCompany.UseVisualStyleBackColor = true;
            this.cmdNewCompany.Click += new System.EventHandler(this.CmdNewClient_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(524, 84);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // cmbUserCompany
            // 
            this.cmbUserCompany.DataSource = this.cOMPANYBindingSource;
            this.cmbUserCompany.DisplayMember = "CONAME";
            this.cmbUserCompany.FormattingEnabled = true;
            this.cmbUserCompany.Location = new System.Drawing.Point(524, 119);
            this.cmbUserCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUserCompany.Name = "cmbUserCompany";
            this.cmbUserCompany.Size = new System.Drawing.Size(100, 24);
            this.cmbUserCompany.TabIndex = 13;
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
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.cmdRemoveUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRemoveUser.Name = "cmdRemoveUser";
            this.cmdRemoveUser.Size = new System.Drawing.Size(123, 39);
            this.cmdRemoveUser.TabIndex = 6;
            this.cmdRemoveUser.Text = "&Remove User";
            this.cmdRemoveUser.UseVisualStyleBackColor = true;
            this.cmdRemoveUser.Click += new System.EventHandler(this.CmdRemoveUser_Click);
            // 
            // cmdAddUser
            // 
            this.cmdAddUser.Location = new System.Drawing.Point(629, 47);
            this.cmdAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdAddUser.Name = "cmdAddUser";
            this.cmdAddUser.Size = new System.Drawing.Size(123, 39);
            this.cmdAddUser.TabIndex = 5;
            this.cmdAddUser.Text = "&Add User";
            this.cmdAddUser.UseVisualStyleBackColor = true;
            this.cmdAddUser.Click += new System.EventHandler(this.CmdAddUser_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.DataSource = this.eMPLOYEEBindingSource;
            this.lstUsers.DisplayMember = "EMPNAME";
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 16;
            this.lstUsers.Location = new System.Drawing.Point(28, 47);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(4);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(224, 212);
            this.lstUsers.TabIndex = 2;
            this.lstUsers.DoubleClick += new System.EventHandler(this.CmdEditUser_Click);
            // 
            // tabCompanyManager
            // 
            this.tabCompanyManager.Controls.Add(this.cmdEditCompany);
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
            this.tabCompanyManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCompanyManager.Name = "tabCompanyManager";
            this.tabCompanyManager.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCompanyManager.Size = new System.Drawing.Size(903, 601);
            this.tabCompanyManager.TabIndex = 2;
            this.tabCompanyManager.Text = "Company Manager";
            this.tabCompanyManager.UseVisualStyleBackColor = true;
            // 
            // cmdEditCompany
            // 
            this.cmdEditCompany.Location = new System.Drawing.Point(259, 82);
            this.cmdEditCompany.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEditCompany.Name = "cmdEditCompany";
            this.cmdEditCompany.Size = new System.Drawing.Size(75, 27);
            this.cmdEditCompany.TabIndex = 31;
            this.cmdEditCompany.Text = "E&dit";
            this.cmdEditCompany.UseVisualStyleBackColor = true;
            this.cmdEditCompany.Click += new System.EventHandler(this.CmdEditCompany_Click);
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
            // cmdRemoveCompany
            // 
            this.cmdRemoveCompany.Location = new System.Drawing.Point(259, 47);
            this.cmdRemoveCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRemoveCompany.Name = "cmdRemoveCompany";
            this.cmdRemoveCompany.Size = new System.Drawing.Size(75, 30);
            this.cmdRemoveCompany.TabIndex = 29;
            this.cmdRemoveCompany.Text = "&Remove";
            this.cmdRemoveCompany.UseVisualStyleBackColor = true;
            this.cmdRemoveCompany.Click += new System.EventHandler(this.CmdRemoveClient_Click);
            // 
            // txtAddressCompany
            // 
            this.txtAddressCompany.Location = new System.Drawing.Point(504, 103);
            this.txtAddressCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressCompany.Name = "txtAddressCompany";
            this.txtAddressCompany.Size = new System.Drawing.Size(100, 22);
            this.txtAddressCompany.TabIndex = 28;
            // 
            // txtTelCompany
            // 
            this.txtTelCompany.Location = new System.Drawing.Point(504, 75);
            this.txtTelCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelCompany.Name = "txtTelCompany";
            this.txtTelCompany.Size = new System.Drawing.Size(100, 22);
            this.txtTelCompany.TabIndex = 27;
            // 
            // txtNameCompany
            // 
            this.txtNameCompany.Location = new System.Drawing.Point(504, 47);
            this.txtNameCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.cmdCloseCompanyManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.cmdAddCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lstCompany.DataSource = this.cOMPANYBindingSource;
            this.lstCompany.DisplayMember = "CONAME";
            this.lstCompany.FormattingEnabled = true;
            this.lstCompany.ItemHeight = 16;
            this.lstCompany.Location = new System.Drawing.Point(28, 47);
            this.lstCompany.Margin = new System.Windows.Forms.Padding(4);
            this.lstCompany.Name = "lstCompany";
            this.lstCompany.Size = new System.Drawing.Size(224, 212);
            this.lstCompany.TabIndex = 20;
            this.lstCompany.DoubleClick += new System.EventHandler(this.CmdEditCompany_Click);
            // 
            // tabEditUser
            // 
            this.tabEditUser.Controls.Add(this.cmdCloseUser);
            this.tabEditUser.Controls.Add(this.cmdNewCompanyEdit);
            this.tabEditUser.Controls.Add(this.txtEditUserPassword);
            this.tabEditUser.Controls.Add(this.lblEditUserPassword);
            this.tabEditUser.Controls.Add(this.cmbEditUserCompany);
            this.tabEditUser.Controls.Add(this.lblEditUserCompany);
            this.tabEditUser.Controls.Add(this.txtEditUserUsername);
            this.tabEditUser.Controls.Add(this.lblEditUserUsername);
            this.tabEditUser.Controls.Add(this.cmdModfiyUser);
            this.tabEditUser.Location = new System.Drawing.Point(4, 25);
            this.tabEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.tabEditUser.Name = "tabEditUser";
            this.tabEditUser.Padding = new System.Windows.Forms.Padding(4);
            this.tabEditUser.Size = new System.Drawing.Size(903, 601);
            this.tabEditUser.TabIndex = 3;
            this.tabEditUser.Text = "User";
            this.tabEditUser.UseVisualStyleBackColor = true;
            // 
            // cmdCloseUser
            // 
            this.cmdCloseUser.Location = new System.Drawing.Point(807, 6);
            this.cmdCloseUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdCloseUser.Name = "cmdCloseUser";
            this.cmdCloseUser.Size = new System.Drawing.Size(60, 26);
            this.cmdCloseUser.TabIndex = 25;
            this.cmdCloseUser.Text = "&Close";
            this.cmdCloseUser.UseVisualStyleBackColor = true;
            this.cmdCloseUser.Click += new System.EventHandler(this.CmdCloseUser_Click);
            // 
            // cmdNewCompanyEdit
            // 
            this.cmdNewCompanyEdit.Location = new System.Drawing.Point(204, 84);
            this.cmdNewCompanyEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdNewCompanyEdit.Name = "cmdNewCompanyEdit";
            this.cmdNewCompanyEdit.Size = new System.Drawing.Size(123, 26);
            this.cmdNewCompanyEdit.TabIndex = 24;
            this.cmdNewCompanyEdit.Text = "Ne&w Company";
            this.cmdNewCompanyEdit.UseVisualStyleBackColor = true;
            this.cmdNewCompanyEdit.Click += new System.EventHandler(this.CmdNewClient_Click);
            // 
            // txtEditUserPassword
            // 
            this.txtEditUserPassword.Location = new System.Drawing.Point(99, 50);
            this.txtEditUserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditUserPassword.Name = "txtEditUserPassword";
            this.txtEditUserPassword.PasswordChar = '*';
            this.txtEditUserPassword.Size = new System.Drawing.Size(100, 22);
            this.txtEditUserPassword.TabIndex = 23;
            // 
            // lblEditUserPassword
            // 
            this.lblEditUserPassword.AutoSize = true;
            this.lblEditUserPassword.Location = new System.Drawing.Point(20, 50);
            this.lblEditUserPassword.Name = "lblEditUserPassword";
            this.lblEditUserPassword.Size = new System.Drawing.Size(69, 17);
            this.lblEditUserPassword.TabIndex = 22;
            this.lblEditUserPassword.Text = "&Password";
            // 
            // cmbEditUserCompany
            // 
            this.cmbEditUserCompany.DataSource = this.cOMPANYBindingSource;
            this.cmbEditUserCompany.DisplayMember = "CONAME";
            this.cmbEditUserCompany.FormattingEnabled = true;
            this.cmbEditUserCompany.Location = new System.Drawing.Point(99, 86);
            this.cmbEditUserCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEditUserCompany.Name = "cmbEditUserCompany";
            this.cmbEditUserCompany.Size = new System.Drawing.Size(100, 24);
            this.cmbEditUserCompany.TabIndex = 21;
            // 
            // lblEditUserCompany
            // 
            this.lblEditUserCompany.AutoSize = true;
            this.lblEditUserCompany.Location = new System.Drawing.Point(20, 86);
            this.lblEditUserCompany.Name = "lblEditUserCompany";
            this.lblEditUserCompany.Size = new System.Drawing.Size(67, 17);
            this.lblEditUserCompany.TabIndex = 20;
            this.lblEditUserCompany.Text = "&Company";
            // 
            // txtEditUserUsername
            // 
            this.txtEditUserUsername.Location = new System.Drawing.Point(99, 14);
            this.txtEditUserUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditUserUsername.Name = "txtEditUserUsername";
            this.txtEditUserUsername.Size = new System.Drawing.Size(100, 22);
            this.txtEditUserUsername.TabIndex = 19;
            // 
            // lblEditUserUsername
            // 
            this.lblEditUserUsername.AutoSize = true;
            this.lblEditUserUsername.Location = new System.Drawing.Point(20, 17);
            this.lblEditUserUsername.Name = "lblEditUserUsername";
            this.lblEditUserUsername.Size = new System.Drawing.Size(73, 17);
            this.lblEditUserUsername.TabIndex = 18;
            this.lblEditUserUsername.Text = "Userna&me";
            // 
            // cmdModfiyUser
            // 
            this.cmdModfiyUser.Location = new System.Drawing.Point(204, 12);
            this.cmdModfiyUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdModfiyUser.Name = "cmdModfiyUser";
            this.cmdModfiyUser.Size = new System.Drawing.Size(123, 26);
            this.cmdModfiyUser.TabIndex = 17;
            this.cmdModfiyUser.Text = "&Modify";
            this.cmdModfiyUser.UseVisualStyleBackColor = true;
            // 
            // tabEditCompany
            // 
            this.tabEditCompany.Controls.Add(this.cmdCloseCompany);
            this.tabEditCompany.Controls.Add(this.txtEditCompanyAddress);
            this.tabEditCompany.Controls.Add(this.txtEditCompanyTel);
            this.tabEditCompany.Controls.Add(this.txtEditCompanyName);
            this.tabEditCompany.Controls.Add(this.lblEditCompanyAddress);
            this.tabEditCompany.Controls.Add(this.lblEditCompanyTel);
            this.tabEditCompany.Controls.Add(this.cmdModifyCompany);
            this.tabEditCompany.Controls.Add(this.lblEditCompanyName);
            this.tabEditCompany.Location = new System.Drawing.Point(4, 25);
            this.tabEditCompany.Margin = new System.Windows.Forms.Padding(4);
            this.tabEditCompany.Name = "tabEditCompany";
            this.tabEditCompany.Padding = new System.Windows.Forms.Padding(4);
            this.tabEditCompany.Size = new System.Drawing.Size(903, 601);
            this.tabEditCompany.TabIndex = 4;
            this.tabEditCompany.Text = "Company";
            this.tabEditCompany.UseVisualStyleBackColor = true;
            // 
            // cmdCloseCompany
            // 
            this.cmdCloseCompany.Location = new System.Drawing.Point(807, 6);
            this.cmdCloseCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdCloseCompany.Name = "cmdCloseCompany";
            this.cmdCloseCompany.Size = new System.Drawing.Size(60, 26);
            this.cmdCloseCompany.TabIndex = 36;
            this.cmdCloseCompany.Text = "&Close";
            this.cmdCloseCompany.UseVisualStyleBackColor = true;
            this.cmdCloseCompany.Click += new System.EventHandler(this.CmdCloseCompany_Click);
            // 
            // txtEditCompanyAddress
            // 
            this.txtEditCompanyAddress.Location = new System.Drawing.Point(92, 69);
            this.txtEditCompanyAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditCompanyAddress.Name = "txtEditCompanyAddress";
            this.txtEditCompanyAddress.Size = new System.Drawing.Size(100, 22);
            this.txtEditCompanyAddress.TabIndex = 35;
            // 
            // txtEditCompanyTel
            // 
            this.txtEditCompanyTel.Location = new System.Drawing.Point(92, 41);
            this.txtEditCompanyTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditCompanyTel.Name = "txtEditCompanyTel";
            this.txtEditCompanyTel.Size = new System.Drawing.Size(100, 22);
            this.txtEditCompanyTel.TabIndex = 34;
            // 
            // txtEditCompanyName
            // 
            this.txtEditCompanyName.Location = new System.Drawing.Point(92, 12);
            this.txtEditCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditCompanyName.Name = "txtEditCompanyName";
            this.txtEditCompanyName.Size = new System.Drawing.Size(100, 22);
            this.txtEditCompanyName.TabIndex = 33;
            // 
            // lblEditCompanyAddress
            // 
            this.lblEditCompanyAddress.AutoSize = true;
            this.lblEditCompanyAddress.Location = new System.Drawing.Point(25, 73);
            this.lblEditCompanyAddress.Name = "lblEditCompanyAddress";
            this.lblEditCompanyAddress.Size = new System.Drawing.Size(60, 17);
            this.lblEditCompanyAddress.TabIndex = 32;
            this.lblEditCompanyAddress.Text = "A&dresse";
            // 
            // lblEditCompanyTel
            // 
            this.lblEditCompanyTel.AutoSize = true;
            this.lblEditCompanyTel.Location = new System.Drawing.Point(25, 43);
            this.lblEditCompanyTel.Name = "lblEditCompanyTel";
            this.lblEditCompanyTel.Size = new System.Drawing.Size(28, 17);
            this.lblEditCompanyTel.TabIndex = 31;
            this.lblEditCompanyTel.Text = "&Tel";
            // 
            // cmdModifyCompany
            // 
            this.cmdModifyCompany.Location = new System.Drawing.Point(205, 12);
            this.cmdModifyCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdModifyCompany.Name = "cmdModifyCompany";
            this.cmdModifyCompany.Size = new System.Drawing.Size(111, 25);
            this.cmdModifyCompany.TabIndex = 30;
            this.cmdModifyCompany.Text = "&Modify";
            this.cmdModifyCompany.UseVisualStyleBackColor = true;
            // 
            // lblEditCompanyName
            // 
            this.lblEditCompanyName.AutoSize = true;
            this.lblEditCompanyName.Location = new System.Drawing.Point(25, 16);
            this.lblEditCompanyName.Name = "lblEditCompanyName";
            this.lblEditCompanyName.Size = new System.Drawing.Size(45, 17);
            this.lblEditCompanyName.TabIndex = 29;
            this.lblEditCompanyName.Text = "Na&me";
            // 
            // cOMPANYBindingSource
            // 
            this.cOMPANYBindingSource.DataMember = "COMPANY";
            this.cOMPANYBindingSource.DataSource = this.dataSetDataFinal;
            // 
            // cOMPANYTableAdapter
            // 
            this.cOMPANYTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.dataSetDataFinal;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // FrmMenuHome
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1183, 633);
            this.Controls.Add(this.spltHomeMenu);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1194, 659);
            this.Name = "FrmMenuHome";
            this.Text = "MenuHome";
            this.Load += new System.EventHandler(this.FrmMenuHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDataFinal)).EndInit();
            this.spltHomeMenu.Panel1.ResumeLayout(false);
            this.spltHomeMenu.Panel1.PerformLayout();
            this.spltHomeMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltHomeMenu)).EndInit();
            this.spltHomeMenu.ResumeLayout(false);
            this.tblDcDesigner.ResumeLayout(false);
            this.tabLayout.ResumeLayout(false);
            this.tabLayout.PerformLayout();
            this.tabUserManager.ResumeLayout(false);
            this.tabUserManager.PerformLayout();
            this.tabCompanyManager.ResumeLayout(false);
            this.tabCompanyManager.PerformLayout();
            this.tabEditUser.ResumeLayout(false);
            this.tabEditUser.PerformLayout();
            this.tabEditCompany.ResumeLayout(false);
            this.tabEditCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstExistingLayout;
        private System.Windows.Forms.Label lblExistingLayout;
        private System.Windows.Forms.Button cmdCreateNewDC;
        private System.Windows.Forms.SplitContainer spltHomeMenu;
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
        private System.Windows.Forms.ComboBox cmbUserCompany;
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
        private System.Windows.Forms.TabPage tabEditUser;
        private System.Windows.Forms.Button cmdCloseUser;
        private System.Windows.Forms.Button cmdNewCompanyEdit;
        private System.Windows.Forms.TextBox txtEditUserPassword;
        private System.Windows.Forms.Label lblEditUserPassword;
        private System.Windows.Forms.ComboBox cmbEditUserCompany;
        private System.Windows.Forms.Label lblEditUserCompany;
        private System.Windows.Forms.TextBox txtEditUserUsername;
        private System.Windows.Forms.Label lblEditUserUsername;
        private System.Windows.Forms.Button cmdModfiyUser;
        private System.Windows.Forms.TabPage tabEditCompany;
        private System.Windows.Forms.Button cmdCloseCompany;
        private System.Windows.Forms.TextBox txtEditCompanyAddress;
        private System.Windows.Forms.TextBox txtEditCompanyTel;
        private System.Windows.Forms.TextBox txtEditCompanyName;
        private System.Windows.Forms.Label lblEditCompanyAddress;
        private System.Windows.Forms.Label lblEditCompanyTel;
        private System.Windows.Forms.Button cmdModifyCompany;
        private System.Windows.Forms.Label lblEditCompanyName;
        private System.Windows.Forms.Button cmdEditUser;
        private System.Windows.Forms.Button cmdEditCompany;
        private System.Windows.Forms.Panel pnlLayout;
        private DataSetDataFinal dataSetDataFinal;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource;
        private DataSetDataFinalTableAdapters.COMPANYTableAdapter cOMPANYTableAdapter;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private DataSetDataFinalTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
    }
}