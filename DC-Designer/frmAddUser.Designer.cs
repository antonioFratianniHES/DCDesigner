namespace DC_Designer
{
    partial class FrmAddUser
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
            this.cmdAddUser = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblEntreprise = new System.Windows.Forms.Label();
            this.cmbEntreprise = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAddUser
            // 
            this.cmdAddUser.Location = new System.Drawing.Point(53, 169);
            this.cmdAddUser.Name = "cmdAddUser";
            this.cmdAddUser.Size = new System.Drawing.Size(75, 23);
            this.cmdAddUser.TabIndex = 0;
            this.cmdAddUser.Text = "Add";
            this.cmdAddUser.UseVisualStyleBackColor = true;
            this.cmdAddUser.Click += new System.EventHandler(this.CmdAddUser_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(154, 169);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(50, 35);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(129, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 3;
            // 
            // lblEntreprise
            // 
            this.lblEntreprise.AutoSize = true;
            this.lblEntreprise.Location = new System.Drawing.Point(50, 104);
            this.lblEntreprise.Name = "lblEntreprise";
            this.lblEntreprise.Size = new System.Drawing.Size(73, 17);
            this.lblEntreprise.TabIndex = 4;
            this.lblEntreprise.Text = "Entreprise";
            // 
            // cmbEntreprise
            // 
            this.cmbEntreprise.FormattingEnabled = true;
            this.cmbEntreprise.Items.AddRange(new object[] {
            "Add"});
            this.cmbEntreprise.Location = new System.Drawing.Point(129, 104);
            this.cmbEntreprise.Name = "cmbEntreprise";
            this.cmbEntreprise.Size = new System.Drawing.Size(100, 24);
            this.cmbEntreprise.TabIndex = 5;
            this.cmbEntreprise.SelectedIndexChanged += new System.EventHandler(this.cmbEntreprise_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(129, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(50, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 227);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cmbEntreprise);
            this.Controls.Add(this.lblEntreprise);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAddUser);
            this.Name = "FrmAddUser";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAddUser;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblEntreprise;
        private System.Windows.Forms.ComboBox cmbEntreprise;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}