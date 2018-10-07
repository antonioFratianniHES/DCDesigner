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
    public partial class frmMenuHome : Form
    {
        public frmMenuHome()
        {
            InitializeComponent();
            //splitContainer1.Panel2.Hide();
            frmConnexion f = new frmConnexion();
            f.ShowDialog(this);
        }

        private void cmdCreateNewDC_Click(object sender, EventArgs e)
        {
            frmLayout f = new frmLayout();
            f.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(f);
            f.Show();
            splitContainer1.Panel2.Show(); 
        }

  
    }
}
