namespace DC_Designer
{
    partial class frmMenuHome
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.lstExistingDC.DoubleClick += new System.EventHandler(this.lstExistingDC_DoubleClick);
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
            this.cmdCreateNewDC.Click += new System.EventHandler(this.cmdCreateNewDC_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.cmdCreateNewDC);
            this.splitContainer1.Panel1.Controls.Add(this.lstExistingDC);
            this.splitContainer1.Panel1.Controls.Add(this.lblExistingDC);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabLayout);
            this.splitContainer1.Size = new System.Drawing.Size(1185, 630);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 6;
            // 
            // tabLayout
            // 
            this.tabLayout.AllowDrop = true;
            this.tabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayout.Location = new System.Drawing.Point(0, 0);
            this.tabLayout.Margin = new System.Windows.Forms.Padding(4);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.SelectedIndex = 0;
            this.tabLayout.Size = new System.Drawing.Size(907, 630);
            this.tabLayout.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabLayout.TabIndex = 0;
            // 
            // frmMenuHome
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1183, 633);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1194, 664);
            this.Name = "frmMenuHome";
            this.Text = "MenuHome";
            this.Resize += new System.EventHandler(this.frmMenuHome_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstExistingDC;
        private System.Windows.Forms.Label lblExistingDC;
        private System.Windows.Forms.Button cmdCreateNewDC;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabLayout;
    }
}