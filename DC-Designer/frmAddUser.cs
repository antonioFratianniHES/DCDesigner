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
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void CmdAddUser_Click(object sender, EventArgs e)
        {
            //ajouter l'user à la liste
            Close();
            Dispose();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void cmbEntreprise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEntreprise.SelectedIndex == 0)
            {
                cmbEntreprise.Items.Add("Nouvelle Entreprise");
                cmbEntreprise.Text = "Nouvelle Entreprise";
                cmbEntreprise.SelectedIndex = cmbEntreprise.Items.Count - 1;
            }
        }

        private void cmbEntreprise_TextChanged(object sender, EventArgs e)
        {
            if (cmbEntreprise.Text !="Add")
            {

            }
            int index = cmbEntreprise.FindString(cmbEntreprise.Text);
            if (index < 0)
            {
                
                txtUserName.Text = String.Empty;
            }
            else
            {
                cmbEntreprise.SelectedIndex = index;
            }
        }
    }
}
