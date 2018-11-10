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
            this.lstExistingDC = new System.Windows.Forms.ListBox();
            this.lblExistingDC = new System.Windows.Forms.Label();
            this.cmdCreateNewDC = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblFiltreClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.tblDcDesigner = new System.Windows.Forms.TabControl();
            this.tblLayout = new System.Windows.Forms.TabPage();
            this.cmdAddRow = new System.Windows.Forms.Button();
            this.txtNomDC = new System.Windows.Forms.TextBox();
            this.lblNomDC = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.dcLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tblUserManager = new System.Windows.Forms.TabPage();
            this.cmdRemoveClient = new System.Windows.Forms.Button();
            this.lstClient = new System.Windows.Forms.ListBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAddClient = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cmbEntreprise = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.cmdRemoveUser = new System.Windows.Forms.Button();
            this.cmdAddUser = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tblDcDesigner.SuspendLayout();
            this.tblLayout.SuspendLayout();
            this.tblUserManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstExistingDC
            // 
            this.lstExistingDC.FormattingEnabled = true;
            this.lstExistingDC.ItemHeight = 16;
            this.lstExistingDC.Location = new System.Drawing.Point(19, 254);
            this.lstExistingDC.Margin = new System.Windows.Forms.Padding(4);
            this.lstExistingDC.Name = "lstExistingDC";
            this.lstExistingDC.Size = new System.Drawing.Size(224, 244);
            this.lstExistingDC.TabIndex = 1;
            this.lstExistingDC.DoubleClick += new System.EventHandler(this.LstExistingDC_DoubleClick);
            // 
            // lblExistingDC
            // 
            this.lblExistingDC.AutoSize = true;
            this.lblExistingDC.Location = new System.Drawing.Point(15, 234);
            this.lblExistingDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExistingDC.Name = "lblExistingDC";
            this.lblExistingDC.Size = new System.Drawing.Size(79, 17);
            this.lblExistingDC.TabIndex = 2;
            this.lblExistingDC.Text = "Existing DC";
            // 
            // cmdCreateNewDC
            // 
            this.cmdCreateNewDC.Location = new System.Drawing.Point(19, 113);
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
            this.splitContainer1.Panel1.Controls.Add(this.lblFiltreClient);
            this.splitContainer1.Panel1.Controls.Add(this.cmbClient);
            this.splitContainer1.Panel1.Controls.Add(this.cmdCreateNewDC);
            this.splitContainer1.Panel1.Controls.Add(this.lstExistingDC);
            this.splitContainer1.Panel1.Controls.Add(this.lblExistingDC);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tblDcDesigner);
            this.splitContainer1.Size = new System.Drawing.Size(1185, 630);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 6;
            // 
            // lblFiltreClient
            // 
            this.lblFiltreClient.AutoSize = true;
            this.lblFiltreClient.Location = new System.Drawing.Point(15, 209);
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
            this.cmbClient.Location = new System.Drawing.Point(114, 206);
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
            this.tblDcDesigner.Controls.Add(this.tblLayout);
            this.tblDcDesigner.Controls.Add(this.tblUserManager);
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
            // tblLayout
            // 
            this.tblLayout.AutoScroll = true;
            this.tblLayout.Controls.Add(this.cmdAddRow);
            this.tblLayout.Controls.Add(this.txtNomDC);
            this.tblLayout.Controls.Add(this.lblNomDC);
            this.tblLayout.Controls.Add(this.cmdClose);
            this.tblLayout.Controls.Add(this.cmdSave);
            this.tblLayout.Controls.Add(this.dcLayout);
            this.tblLayout.Location = new System.Drawing.Point(4, 25);
            this.tblLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblLayout.Size = new System.Drawing.Size(902, 601);
            this.tblLayout.TabIndex = 0;
            this.tblLayout.Text = "Layout";
            this.tblLayout.UseVisualStyleBackColor = true;
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
            // tblUserManager
            // 
            this.tblUserManager.Controls.Add(this.cmdRemoveClient);
            this.tblUserManager.Controls.Add(this.lstClient);
            this.tblUserManager.Controls.Add(this.txtClient);
            this.tblUserManager.Controls.Add(this.label1);
            this.tblUserManager.Controls.Add(this.cmdAddClient);
            this.tblUserManager.Controls.Add(this.txtPassword);
            this.tblUserManager.Controls.Add(this.lblPassword);
            this.tblUserManager.Controls.Add(this.cmbEntreprise);
            this.tblUserManager.Controls.Add(this.lblClient);
            this.tblUserManager.Controls.Add(this.txtUserName);
            this.tblUserManager.Controls.Add(this.lblNom);
            this.tblUserManager.Controls.Add(this.cmdRemoveUser);
            this.tblUserManager.Controls.Add(this.cmdAddUser);
            this.tblUserManager.Controls.Add(this.lstUsers);
            this.tblUserManager.Location = new System.Drawing.Point(4, 25);
            this.tblUserManager.Name = "tblUserManager";
            this.tblUserManager.Padding = new System.Windows.Forms.Padding(3);
            this.tblUserManager.Size = new System.Drawing.Size(902, 601);
            this.tblUserManager.TabIndex = 1;
            this.tblUserManager.Text = "Gestion User";
            this.tblUserManager.UseVisualStyleBackColor = true;
            // 
            // cmdRemoveClient
            // 
            this.cmdRemoveClient.Location = new System.Drawing.Point(259, 277);
            this.cmdRemoveClient.Name = "cmdRemoveClient";
            this.cmdRemoveClient.Size = new System.Drawing.Size(123, 39);
            this.cmdRemoveClient.TabIndex = 20;
            this.cmdRemoveClient.Text = "Remove Client";
            this.cmdRemoveClient.UseVisualStyleBackColor = true;
            this.cmdRemoveClient.Click += new System.EventHandler(this.CmdRemoveClient_Click);
            // 
            // lstClient
            // 
            this.lstClient.FormattingEnabled = true;
            this.lstClient.ItemHeight = 16;
            this.lstClient.Location = new System.Drawing.Point(28, 277);
            this.lstClient.Margin = new System.Windows.Forms.Padding(4);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(224, 196);
            this.lstClient.TabIndex = 19;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(523, 277);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 22);
            this.txtClient.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 17;
            // 
            // cmdAddClient
            // 
            this.cmdAddClient.Location = new System.Drawing.Point(630, 277);
            this.cmdAddClient.Name = "cmdAddClient";
            this.cmdAddClient.Size = new System.Drawing.Size(100, 24);
            this.cmdAddClient.TabIndex = 16;
            this.cmdAddClient.Text = "Add Client";
            this.cmdAddClient.UseVisualStyleBackColor = true;
            this.cmdAddClient.Click += new System.EventHandler(this.CmdAddClient_Click);
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
            this.lblPassword.Text = "Password";
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
            this.lblClient.Size = new System.Drawing.Size(43, 17);
            this.lblClient.TabIndex = 12;
            this.lblClient.Text = "Client";
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
            this.lblNom.Text = "Username";
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
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.tblUserManager.ResumeLayout(false);
            this.tblUserManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstExistingDC;
        private System.Windows.Forms.Label lblExistingDC;
        private System.Windows.Forms.Button cmdCreateNewDC;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tblDcDesigner;
        private System.Windows.Forms.TabPage tblLayout;
        private System.Windows.Forms.TableLayoutPanel dcLayout;
        private System.Windows.Forms.TextBox txtNomDC;
        private System.Windows.Forms.Label lblNomDC;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdAddRow;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblFiltreClient;
        private System.Windows.Forms.Button cmdAddUser;
        private System.Windows.Forms.TabPage tblUserManager;
        private System.Windows.Forms.Button cmdRemoveUser;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cmbEntreprise;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAddClient;
        private System.Windows.Forms.Button cmdRemoveClient;
        private System.Windows.Forms.ListBox lstClient;
    }
}