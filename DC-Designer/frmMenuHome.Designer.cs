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
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.tabLayout = new System.Windows.Forms.TabControl();
            this.newTab = new System.Windows.Forms.TabPage();
            this.cmdAddRow = new System.Windows.Forms.Button();
            this.txtNomDC = new System.Windows.Forms.TextBox();
            this.lblNomDC = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.dcLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblFiltreClient = new System.Windows.Forms.Label();
            this.cmdAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabLayout.SuspendLayout();
            this.newTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstExistingDC
            // 
            this.lstExistingDC.FormattingEnabled = true;
            this.lstExistingDC.ItemHeight = 16;
            this.lstExistingDC.Location = new System.Drawing.Point(19, 254);
            this.lstExistingDC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cmdCreateNewDC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.cmdAddUser);
            this.splitContainer1.Panel1.Controls.Add(this.lblFiltreClient);
            this.splitContainer1.Panel1.Controls.Add(this.cmbClient);
            this.splitContainer1.Panel1.Controls.Add(this.cmdCreateNewDC);
            this.splitContainer1.Panel1.Controls.Add(this.lstExistingDC);
            this.splitContainer1.Panel1.Controls.Add(this.lblExistingDC);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabLayout);
            this.splitContainer1.Size = new System.Drawing.Size(1185, 630);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 6;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(114, 206);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(130, 24);
            this.cmbClient.TabIndex = 3;
            this.cmbClient.Visible = false;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.CmbClient_SelectedIndexChanged);
            // 
            // tabLayout
            // 
            this.tabLayout.AllowDrop = true;
            this.tabLayout.Controls.Add(this.newTab);
            this.tabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayout.Location = new System.Drawing.Point(0, 0);
            this.tabLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.SelectedIndex = 0;
            this.tabLayout.Size = new System.Drawing.Size(910, 630);
            this.tabLayout.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabLayout.TabIndex = 0;
            this.tabLayout.Visible = false;
            // 
            // newTab
            // 
            this.newTab.AutoScroll = true;
            this.newTab.Controls.Add(this.cmdAddRow);
            this.newTab.Controls.Add(this.txtNomDC);
            this.newTab.Controls.Add(this.lblNomDC);
            this.newTab.Controls.Add(this.cmdClose);
            this.newTab.Controls.Add(this.cmdSave);
            this.newTab.Controls.Add(this.dcLayout);
            this.newTab.Location = new System.Drawing.Point(4, 25);
            this.newTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newTab.Name = "newTab";
            this.newTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newTab.Size = new System.Drawing.Size(902, 601);
            this.newTab.TabIndex = 0;
            this.newTab.Text = "new Layout";
            this.newTab.UseVisualStyleBackColor = true;
            // 
            // cmdAddRow
            // 
            this.cmdAddRow.Location = new System.Drawing.Point(24, 49);
            this.cmdAddRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtNomDC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // lblFiltreClient
            // 
            this.lblFiltreClient.AutoSize = true;
            this.lblFiltreClient.Location = new System.Drawing.Point(15, 209);
            this.lblFiltreClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltreClient.Name = "lblFiltreClient";
            this.lblFiltreClient.Size = new System.Drawing.Size(99, 17);
            this.lblFiltreClient.TabIndex = 4;
            this.lblFiltreClient.Text = "filtre par Client";
            this.lblFiltreClient.Visible = false;
            // 
            // cmdAddUser
            // 
            this.cmdAddUser.Location = new System.Drawing.Point(19, 61);
            this.cmdAddUser.Name = "cmdAddUser";
            this.cmdAddUser.Size = new System.Drawing.Size(176, 39);
            this.cmdAddUser.TabIndex = 5;
            this.cmdAddUser.Text = "AddUser";
            this.cmdAddUser.UseVisualStyleBackColor = true;
            this.cmdAddUser.Visible = false;
            this.cmdAddUser.Click += new System.EventHandler(this.CmdAddUser_Click);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1194, 660);
            this.Name = "FrmMenuHome";
            this.Text = "MenuHome";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabLayout.ResumeLayout(false);
            this.newTab.ResumeLayout(false);
            this.newTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstExistingDC;
        private System.Windows.Forms.Label lblExistingDC;
        private System.Windows.Forms.Button cmdCreateNewDC;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabLayout;
        private System.Windows.Forms.TabPage newTab;
        private System.Windows.Forms.TableLayoutPanel dcLayout;
        private System.Windows.Forms.TextBox txtNomDC;
        private System.Windows.Forms.Label lblNomDC;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdAddRow;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblFiltreClient;
        private System.Windows.Forms.Button cmdAddUser;
    }
}