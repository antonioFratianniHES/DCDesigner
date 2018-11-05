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
    }
}
