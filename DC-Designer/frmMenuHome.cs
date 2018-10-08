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

           /* frmLayout f = new frmLayout();
            f.TopLevel = false;
            f.Show();*/

            tabLayout.Visible = true;
            TabPage newTab = new TabPage();
            newTab.Name = "tabPage"+tabLayout.TabPages.Count;
            newTab.Text = "New Layout"+ tabLayout.TabPages.Count;

            TableLayoutPanel dcPanel = new TableLayoutPanel();
            dcPanel.AutoSize = true;
            dcPanel.ColumnCount = 1;
            dcPanel.CellBorderStyle= TableLayoutPanelCellBorderStyle.InsetDouble; 
            dcPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            
            dcPanel.Width = 100;
            dcPanel.Height = 200;
            

            Button addRack = new Button();
            addRack.Name = "cmdAddRack";
            addRack.Text = "+";
            addRack.Font= new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addRack.Size = new Size(49, 51);
            addRack.TextAlign = ContentAlignment.MiddleCenter;
            addRack.AutoSize = true;
            addRack.Anchor = AnchorStyles.None;
            addRack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addRack.Click += new EventHandler(cmdAddRack_Click);

            dcPanel.Controls.Add(addRack,0,0);
            newTab.Controls.Add(dcPanel);
            //f.AutoSize = true;
            
           // newTab.Controls.Add(f);
            tabLayout.TabPages.Add(newTab);
           
         
        }

        private void cmdAddRack_Click(object sender, EventArgs e)
        {
            frmAjoutRack f = new frmAjoutRack();
            f.ShowDialog(this);
        }
    }
}
