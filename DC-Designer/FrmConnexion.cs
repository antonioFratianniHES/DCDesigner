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
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }


        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            if (Login.UserOk(txtUsername.Text))
            {
                Login.SetUser(u: txtUsername.Text);
                Close();
            }
            else { MessageBox.Show("user ou mot de passe incorrect","Error",MessageBoxButtons.OK); }
            
        }

    }
}
