namespace DC_Designer
{
    partial class FrmAjoutRack
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
            this.numNbU = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numNbU)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(203, 162);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(105, 32);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Location = new System.Drawing.Point(45, 164);
            this.cmdAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(103, 31);
            this.cmdAnnuler.TabIndex = 3;
            this.cmdAnnuler.Text = "Cancel";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.CmdAnnuler_Click);
            // 
            // lblNomRack
            // 
            this.lblNomRack.AutoSize = true;
            this.lblNomRack.Location = new System.Drawing.Point(41, 49);
            this.lblNomRack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomRack.Name = "lblNomRack";
            this.lblNomRack.Size = new System.Drawing.Size(37, 17);
            this.lblNomRack.TabIndex = 2;
            this.lblNomRack.Text = "Nom";
            // 
            // lblNbU
            // 
            this.lblNbU.AutoSize = true;
            this.lblNbU.Location = new System.Drawing.Point(42, 93);
            this.lblNbU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbU.Name = "lblNbU";
            this.lblNbU.Size = new System.Drawing.Size(92, 17);
            this.lblNbU.TabIndex = 3;
            this.lblNbU.Text = "Nombre de U";
            // 
            // txtNomRack
            // 
            this.txtNomRack.Location = new System.Drawing.Point(171, 46);
            this.txtNomRack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomRack.Name = "txtNomRack";
            this.txtNomRack.Size = new System.Drawing.Size(136, 22);
            this.txtNomRack.TabIndex = 0;
            // 
            // numNbU
            // 
            this.numNbU.Location = new System.Drawing.Point(171, 91);
            this.numNbU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numNbU.Name = "numNbU";
            this.numNbU.Size = new System.Drawing.Size(51, 22);
            this.numNbU.TabIndex = 1;
            // 
            // frmAjoutRack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 218);
            this.Controls.Add(this.numNbU);
            this.Controls.Add(this.txtNomRack);
            this.Controls.Add(this.lblNbU);
            this.Controls.Add(this.lblNomRack);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjoutRack";
            this.Text = "Ajout Rack";
            ((System.ComponentModel.ISupportInitialize)(this.numNbU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.Label lblNomRack;
        private System.Windows.Forms.Label lblNbU;
        private System.Windows.Forms.TextBox txtNomRack;
        private System.Windows.Forms.NumericUpDown numNbU;
    }
}