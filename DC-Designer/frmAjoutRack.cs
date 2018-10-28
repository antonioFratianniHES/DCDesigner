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
    public partial class FrmAjoutRack : Form
    {
        public FrmAjoutRack()
        {
            InitializeComponent();
          
        }

        private void CmdAnnuler_Click(object sender, EventArgs e)
        {
            GestionRack.SetRack("", 0);
            Close();
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            if(txtNomRack.TextLength!=0 && numNbU.Value > 0){
                GestionRack.SetRack(txtNomRack.Text, (int)numNbU.Value);
            }
            this.Close();
            this.Dispose();
        }
    }
}
