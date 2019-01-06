using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC_Designer
{
    public partial class frmEquipement : Form
    {
        private Equipement equip;
        public frmEquipement()
        {
            InitializeComponent();
            equip = GestionAjoutEquip.GetEquipement();
            if (equip != null)
            {
                txtNomEquipement.Text = equip.GetNom();
                toolStripTextBox1.Text = equip.GetNom();
                txtModele.Text = equip.GetDescr();
            }
            else {
                txtModele.Text = "(facultatif)";
            }
            
        }

        private void CmdAnnulerEquip_Click(object sender, EventArgs e)
        {
            GestionAjoutEquip.SetEquipement(null);
            Close();
            InitializeComponent();
          
        }

        private void CmdAddEquip_Click(object sender, EventArgs e)
        {
            if (txtNomEquipement.Text != "")
            {
                GestionAjoutEquip.SetEquipement(txtNomEquipement.Text, txtModele.Text);
                Close();
                InitializeComponent();
          
            }
        }

        private void frmEquipement_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetDataFinal.VW_CONNECTEDTO'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_CONNECTEDTOTableAdapter.Fill(this.dataSetDataFinal.VW_CONNECTEDTO);

        }

        private void vW_CONNECTEDTODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vW_CONNECTEDTOTableAdapter.FillBy(this.dataSetDataFinal.VW_CONNECTEDTO, toolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
