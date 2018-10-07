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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstExistingDC
            // 
            this.lstExistingDC.FormattingEnabled = true;
            this.lstExistingDC.Location = new System.Drawing.Point(14, 206);
            this.lstExistingDC.Name = "lstExistingDC";
            this.lstExistingDC.Size = new System.Drawing.Size(169, 199);
            this.lstExistingDC.TabIndex = 1;
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
            this.cmdCreateNewDC.Text = "Create Data Center";
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
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmdCreateNewDC);
            this.splitContainer1.Panel1.Controls.Add(this.lstExistingDC);
            this.splitContainer1.Panel1.Controls.Add(this.lblExistingDC);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabLayout);
            this.splitContainer1.Size = new System.Drawing.Size(889, 512);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 6;
            // 
            // tabLayout
            // 
            this.tabLayout.Controls.Add(this.tabPage1);
            this.tabLayout.Location = new System.Drawing.Point(3, 0);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.SelectedIndex = 0;
            this.tabLayout.Size = new System.Drawing.Size(673, 509);
            this.tabLayout.TabIndex = 0;
            this.tabLayout.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmMenuHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 514);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "frmMenuHome";
            this.Text = "MenuHome";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstExistingDC;
        private System.Windows.Forms.Label lblExistingDC;
        private System.Windows.Forms.Button cmdCreateNewDC;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabLayout;
        private System.Windows.Forms.TabPage tabPage1;
    }
}