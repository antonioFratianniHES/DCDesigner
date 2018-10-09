namespace DC_Designer
{
    partial class frmAjoutRack
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
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.lblNomRack = new System.Windows.Forms.Label();
            this.lblNbU = new System.Windows.Forms.Label();
            this.txtNomRack = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(152, 132);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(79, 26);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Location = new System.Drawing.Point(34, 133);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(77, 25);
            this.cmdAnnuler.TabIndex = 3;
            this.cmdAnnuler.Text = "Cancel";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // lblNomRack
            // 
            this.lblNomRack.AutoSize = true;
            this.lblNomRack.Location = new System.Drawing.Point(31, 40);
            this.lblNomRack.Name = "lblNomRack";
            this.lblNomRack.Size = new System.Drawing.Size(29, 13);
            this.lblNomRack.TabIndex = 2;
            this.lblNomRack.Text = "Nom";
            // 
            // lblNbU
            // 
            this.lblNbU.AutoSize = true;
            this.lblNbU.Location = new System.Drawing.Point(31, 81);
            this.lblNbU.Name = "lblNbU";
            this.lblNbU.Size = new System.Drawing.Size(70, 13);
            this.lblNbU.TabIndex = 3;
            this.lblNbU.Text = "Nombre de U";
            // 
            // txtNomRack
            // 
            this.txtNomRack.Location = new System.Drawing.Point(128, 37);
            this.txtNomRack.Name = "txtNomRack";
            this.txtNomRack.Size = new System.Drawing.Size(103, 20);
            this.txtNomRack.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 74);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // frmAjoutRack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 177);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtNomRack);
            this.Controls.Add(this.lblNbU);
            this.Controls.Add(this.lblNomRack);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjoutRack";
            this.Text = "Ajout Rack";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.Label lblNomRack;
        private System.Windows.Forms.Label lblNbU;
        private System.Windows.Forms.TextBox txtNomRack;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}