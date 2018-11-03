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
            equip = GestionAjoutEquip.getEquipement();
            if (equip != null)
            {
                txtNomEquipement.Text = equip.getNom();
                txtModele.Text = equip.getDescr();
            }
            else {
                txtModele.Text = "(facultatif)";
            }
            
        }

        private void cmdAnnulerEquip_Click(object sender, EventArgs e)
        {
            GestionAjoutEquip.setEquipement(null);
            Close();
            InitializeComponent();
          
        }

        private void cmdAddEquip_Click(object sender, EventArgs e)
        {
            if (txtNomEquipement.Text != "")
            {
                GestionAjoutEquip.setEquipement(txtNomEquipement.Text, txtModele.Text);
                Close();
                InitializeComponent();
          
            }
        }
    }
}
