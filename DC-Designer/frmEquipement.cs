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
        public frmEquipement()
        {
            InitializeComponent();
        }

        private void cmdAnnulerEquip_Click(object sender, EventArgs e)
        {
            Close();
            InitializeComponent();
        }

        private void cmdAddEquip_Click(object sender, EventArgs e)
        {
            GestionAjoutEquip.setEquipement(txtNomEquipement.Text, txtModele.Text);
            Close();
            InitializeComponent();
        }
    }
}
