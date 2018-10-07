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
            frmConnexion f = new frmConnexion();
            f.ShowDialog(this);
        }

        private void cmdCreateNewDC_Click(object sender, EventArgs e)
        {

            frmLayout f = new frmLayout();
            f.TopLevel = false;
            f.Show();
            tabLayout.Visible = true;
            TabPage newTab = new TabPage();
            newTab.Name = "tabPage"+tabLayout.TabPages.Count;
            newTab.Text = "New Layout"+ tabLayout.TabPages.Count;
            newTab.Controls.Add(f);
            tabLayout.TabPages.Add(newTab);
           
         
        }

  
    }
}
