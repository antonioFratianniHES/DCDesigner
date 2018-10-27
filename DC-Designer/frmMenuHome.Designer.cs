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
            this.tabLayout = new System.Windows.Forms.TabControl();
            this.newTab = new System.Windows.Forms.TabPage();
            this.dcLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txtNomDC = new System.Windows.Forms.TextBox();
            this.lblNomDC = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
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
            this.lstExistingDC.Location = new System.Drawing.Point(14, 206);
            this.lstExistingDC.Name = "lstExistingDC";
            this.lstExistingDC.Size = new System.Drawing.Size(169, 199);
            this.lstExistingDC.TabIndex = 1;
            this.lstExistingDC.DoubleClick += new System.EventHandler(this.LstExistingDC_DoubleClick);
            // 
            // lblExistingDC
            // 
            this.lblExistingDC.AutoSize = true;
            this.lblExistingDC.Location = new System.Drawing.Point(11, 190);
            this.lblExistingDC.Name = "lblExistingDC";
            this.lblExistingDC.Size = new System.Drawing.Size(61, 13);
            this.lblExistingDC.TabIndex = 2;
            this.lblExistingDC.Text = "Existing DC";
            // 
            // cmdCreateNewDC
            // 
            this.cmdCreateNewDC.Location = new System.Drawing.Point(14, 92);
            this.cmdCreateNewDC.Name = "cmdCreateNewDC";
            this.cmdCreateNewDC.Size = new System.Drawing.Size(169, 56);
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
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.cmdCreateNewDC);
            this.splitContainer1.Panel1.Controls.Add(this.lstExistingDC);
            this.splitContainer1.Panel1.Controls.Add(this.lblExistingDC);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabLayout);
            this.splitContainer1.Size = new System.Drawing.Size(889, 512);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 6;
            // 
            // tabLayout
            // 
            this.tabLayout.AllowDrop = true;
            this.tabLayout.Controls.Add(this.newTab);
            this.tabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayout.Location = new System.Drawing.Point(0, 0);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.SelectedIndex = 0;
            this.tabLayout.Size = new System.Drawing.Size(681, 512);
            this.tabLayout.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabLayout.TabIndex = 0;
            this.tabLayout.Visible = false;
            // 
            // newTab
            // 
            this.newTab.Controls.Add(this.txtNomDC);
            this.newTab.Controls.Add(this.lblNomDC);
            this.newTab.Controls.Add(this.cmdCancel);
            this.newTab.Controls.Add(this.cmdSave);
            this.newTab.Controls.Add(this.dcLayout);
            this.newTab.Location = new System.Drawing.Point(4, 22);
            this.newTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newTab.Name = "newTab";
            this.newTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newTab.Size = new System.Drawing.Size(673, 486);
            this.newTab.TabIndex = 0;
            this.newTab.Text = "new Layout";
            this.newTab.UseVisualStyleBackColor = true;
            // 
            // dcLayout
            // 
            this.dcLayout.ColumnCount = 2;
            this.dcLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dcLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dcLayout.Location = new System.Drawing.Point(18, 61);
            this.dcLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dcLayout.Name = "dcLayout";
            this.dcLayout.RowCount = 1;
            this.dcLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dcLayout.Size = new System.Drawing.Size(384, 379);
            this.dcLayout.TabIndex = 0;
            // 
            // txtNomDC
            // 
            this.txtNomDC.AllowDrop = true;
            this.txtNomDC.Location = new System.Drawing.Point(65, 14);
            this.txtNomDC.Name = "txtNomDC";
            this.txtNomDC.Size = new System.Drawing.Size(100, 20);
            this.txtNomDC.TabIndex = 12;
            // 
            // lblNomDC
            // 
            this.lblNomDC.AutoSize = true;
            this.lblNomDC.Location = new System.Drawing.Point(15, 17);
            this.lblNomDC.Name = "lblNomDC";
            this.lblNomDC.Size = new System.Drawing.Size(44, 13);
            this.lblNomDC.TabIndex = 11;
            this.lblNomDC.Text = "NomDC";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(268, 12);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(178, 12);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 9;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // FrmMenuHome
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(887, 514);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(900, 547);
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
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
    }
}