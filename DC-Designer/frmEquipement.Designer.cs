namespace DC_Designer
{
    partial class frmEquipement
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
            this.lblNomEquipement = new System.Windows.Forms.Label();
            this.lblModele = new System.Windows.Forms.Label();
            this.txtNomEquipement = new System.Windows.Forms.TextBox();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.cmdAnnulerEquip = new System.Windows.Forms.Button();
            this.cmdAddEquip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomEquipement
            // 
            this.lblNomEquipement.AutoSize = true;
            this.lblNomEquipement.Location = new System.Drawing.Point(43, 36);
            this.lblNomEquipement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomEquipement.Name = "lblNomEquipement";
            this.lblNomEquipement.Size = new System.Drawing.Size(37, 17);
            this.lblNomEquipement.TabIndex = 0;
            this.lblNomEquipement.Text = "Nom";
            // 
            // lblModele
            // 
            this.lblModele.AutoSize = true;
            this.lblModele.Location = new System.Drawing.Point(43, 84);
            this.lblModele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(54, 17);
            this.lblModele.TabIndex = 1;
            this.lblModele.Text = "Modele";
            // 
            // txtNomEquipement
            // 
            this.txtNomEquipement.Location = new System.Drawing.Point(128, 32);
            this.txtNomEquipement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomEquipement.Name = "txtNomEquipement";
            this.txtNomEquipement.Size = new System.Drawing.Size(169, 22);
            this.txtNomEquipement.TabIndex = 2;
            // 
            // txtModele
            // 
            this.txtModele.Location = new System.Drawing.Point(128, 80);
            this.txtModele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModele.Name = "txtModele";
            this.txtModele.Size = new System.Drawing.Size(169, 22);
            this.txtModele.TabIndex = 3;
            this.txtModele.Text = "(facultatif)";
            // 
            // cmdAnnulerEquip
            // 
            this.cmdAnnulerEquip.Location = new System.Drawing.Point(197, 148);
            this.cmdAnnulerEquip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAnnulerEquip.Name = "cmdAnnulerEquip";
            this.cmdAnnulerEquip.Size = new System.Drawing.Size(100, 28);
            this.cmdAnnulerEquip.TabIndex = 4;
            this.cmdAnnulerEquip.Text = "Annuler";
            this.cmdAnnulerEquip.UseVisualStyleBackColor = true;
            this.cmdAnnulerEquip.Click += new System.EventHandler(this.cmdAnnulerEquip_Click);
            // 
            // cmdAddEquip
            // 
            this.cmdAddEquip.Location = new System.Drawing.Point(46, 148);
            this.cmdAddEquip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAddEquip.Name = "cmdAddEquip";
            this.cmdAddEquip.Size = new System.Drawing.Size(100, 28);
            this.cmdAddEquip.TabIndex = 5;
            this.cmdAddEquip.Text = "Ajouter";
            this.cmdAddEquip.UseVisualStyleBackColor = true;
            this.cmdAddEquip.Click += new System.EventHandler(this.cmdAddEquip_Click);
            // 
            // frmEquipement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 201);
            this.Controls.Add(this.cmdAddEquip);
            this.Controls.Add(this.cmdAnnulerEquip);
            this.Controls.Add(this.txtModele);
            this.Controls.Add(this.txtNomEquipement);
            this.Controls.Add(this.lblModele);
            this.Controls.Add(this.lblNomEquipement);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEquipement";
            this.Text = "Equipement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomEquipement;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.TextBox txtNomEquipement;
        private System.Windows.Forms.TextBox txtModele;
        private System.Windows.Forms.Button cmdAnnulerEquip;
        private System.Windows.Forms.Button cmdAddEquip;
    }
}