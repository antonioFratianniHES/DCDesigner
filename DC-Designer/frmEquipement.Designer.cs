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
            this.components = new System.ComponentModel.Container();
            this.lblModele = new System.Windows.Forms.Label();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.cmdAnnulerEquip = new System.Windows.Forms.Button();
            this.cmdModifierEquip = new System.Windows.Forms.Button();
            this.dataSetDataFinal = new DC_Designer.DataSetDataFinal();
            this.vW_CONNECTEDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_CONNECTEDTOTableAdapter = new DC_Designer.DataSetDataFinalTableAdapters.VW_CONNECTEDTOTableAdapter();
            this.tableAdapterManager = new DC_Designer.DataSetDataFinalTableAdapters.TableAdapterManager();
            this.vW_CONNECTEDTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.lblNomEquipement = new System.Windows.Forms.Label();
            this.txtNomEquipement = new System.Windows.Forms.TextBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDataFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_CONNECTEDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_CONNECTEDTODataGridView)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            // txtModele
            // 
            this.txtModele.Location = new System.Drawing.Point(128, 80);
            this.txtModele.Margin = new System.Windows.Forms.Padding(4);
            this.txtModele.Name = "txtModele";
            this.txtModele.Size = new System.Drawing.Size(169, 22);
            this.txtModele.TabIndex = 3;
            this.txtModele.Text = "(facultatif)";
            // 
            // cmdAnnulerEquip
            // 
            this.cmdAnnulerEquip.Location = new System.Drawing.Point(451, 361);
            this.cmdAnnulerEquip.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAnnulerEquip.Name = "cmdAnnulerEquip";
            this.cmdAnnulerEquip.Size = new System.Drawing.Size(100, 28);
            this.cmdAnnulerEquip.TabIndex = 4;
            this.cmdAnnulerEquip.Text = "Annuler";
            this.cmdAnnulerEquip.UseVisualStyleBackColor = true;
            this.cmdAnnulerEquip.Click += new System.EventHandler(this.CmdAnnulerEquip_Click);
            // 
            // cmdModifierEquip
            // 
            this.cmdModifierEquip.Location = new System.Drawing.Point(46, 361);
            this.cmdModifierEquip.Margin = new System.Windows.Forms.Padding(4);
            this.cmdModifierEquip.Name = "cmdModifierEquip";
            this.cmdModifierEquip.Size = new System.Drawing.Size(100, 28);
            this.cmdModifierEquip.TabIndex = 5;
            this.cmdModifierEquip.Text = "Modifier";
            this.cmdModifierEquip.UseVisualStyleBackColor = true;
            this.cmdModifierEquip.Click += new System.EventHandler(this.CmdAddEquip_Click);
            // 
            // dataSetDataFinal
            // 
            this.dataSetDataFinal.DataSetName = "DataSetDataFinal";
            this.dataSetDataFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vW_CONNECTEDTOBindingSource
            // 
            this.vW_CONNECTEDTOBindingSource.DataMember = "VW_CONNECTEDTO";
            this.vW_CONNECTEDTOBindingSource.DataSource = this.dataSetDataFinal;
            // 
            // vW_CONNECTEDTOTableAdapter
            // 
            this.vW_CONNECTEDTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COMPANYTableAdapter = null;
            this.tableAdapterManager.CONNECTEDTOTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DATACENTERTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.EQUIPMENTTableAdapter = null;
            this.tableAdapterManager.RACKTableAdapter = null;
            this.tableAdapterManager.RANGETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DC_Designer.DataSetDataFinalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vW_CONNECTEDTODataGridView
            // 
            this.vW_CONNECTEDTODataGridView.AutoGenerateColumns = false;
            this.vW_CONNECTEDTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vW_CONNECTEDTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vW_CONNECTEDTODataGridView.DataSource = this.vW_CONNECTEDTOBindingSource;
            this.vW_CONNECTEDTODataGridView.Location = new System.Drawing.Point(46, 122);
            this.vW_CONNECTEDTODataGridView.Name = "vW_CONNECTEDTODataGridView";
            this.vW_CONNECTEDTODataGridView.RowTemplate.Height = 24;
            this.vW_CONNECTEDTODataGridView.Size = new System.Drawing.Size(505, 220);
            this.vW_CONNECTEDTODataGridView.TabIndex = 7;
            this.vW_CONNECTEDTODataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vW_CONNECTEDTODataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PORTSOURCE";
            this.dataGridViewTextBoxColumn3.HeaderText = "PORTSOURCE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RACKDESTINATION";
            this.dataGridViewTextBoxColumn4.HeaderText = "RACKDESTINATION";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EQUIPEMENTDESTINATION";
            this.dataGridViewTextBoxColumn5.HeaderText = "EQUIPEMENTDESTINATION";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PORTDESTINATION";
            this.dataGridViewTextBoxColumn6.HeaderText = "PORTDESTINATION";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(645, 27);
            this.fillByToolStrip.TabIndex = 8;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
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
            // txtNomEquipement
            // 
            this.txtNomEquipement.Location = new System.Drawing.Point(128, 32);
            this.txtNomEquipement.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomEquipement.Name = "txtNomEquipement";
            this.txtNomEquipement.Size = new System.Drawing.Size(169, 22);
            this.txtNomEquipement.TabIndex = 2;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Visible = false;
            // 
            // frmEquipement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 409);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.vW_CONNECTEDTODataGridView);
            this.Controls.Add(this.cmdModifierEquip);
            this.Controls.Add(this.cmdAnnulerEquip);
            this.Controls.Add(this.txtModele);
            this.Controls.Add(this.txtNomEquipement);
            this.Controls.Add(this.lblModele);
            this.Controls.Add(this.lblNomEquipement);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEquipement";
            this.Text = "Equipement";
            this.Load += new System.EventHandler(this.frmEquipement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDataFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_CONNECTEDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_CONNECTEDTODataGridView)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.TextBox txtModele;
        private System.Windows.Forms.Button cmdAnnulerEquip;
        private System.Windows.Forms.Button cmdModifierEquip;
        private DataSetDataFinal dataSetDataFinal;
        private System.Windows.Forms.BindingSource vW_CONNECTEDTOBindingSource;
        private DataSetDataFinalTableAdapters.VW_CONNECTEDTOTableAdapter vW_CONNECTEDTOTableAdapter;
        private DataSetDataFinalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vW_CONNECTEDTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Label lblNomEquipement;
        private System.Windows.Forms.TextBox txtNomEquipement;
    }
}