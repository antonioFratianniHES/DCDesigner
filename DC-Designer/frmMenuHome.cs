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

          
            tabLayout.Visible = true;
            TabPage newTab = new TabPage();
            tabLayout.TabPages.Add(newTab);
            newTab.Name = "tabPage"+tabLayout.TabPages.Count;
            newTab.Text = "New Layout"+ tabLayout.TabPages.Count;
            newTab.AutoSizeMode = AutoSizeMode.GrowAndShrink;


            TableLayoutPanel dcLayout = new TableLayoutPanel();
            dcLayout.ColumnCount = 2;
            dcLayout.AutoSize = true;

            Rack r = new Rack();
            TableLayoutPanel rackPanel = r.emptyRack(10);

            rackPanel.AutoSize = true;
            rackPanel.ColumnCount = 1;
            rackPanel.CellBorderStyle= TableLayoutPanelCellBorderStyle.InsetDouble; 
            rackPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            
            rackPanel.Width = 100;
            rackPanel.Height = 200;
            

            Button cmdAddRack = new Button();
            cmdAddRack.Name = "cmdAddRack";
            cmdAddRack.Text = "+";
            cmdAddRack.Font= new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdAddRack.ForeColor = SystemColors.HotTrack;
            cmdAddRack.Size = new Size(49, 51);
            cmdAddRack.TextAlign = ContentAlignment.MiddleCenter;
            cmdAddRack.AutoSize = true;
            cmdAddRack.Anchor = AnchorStyles.None;
            cmdAddRack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cmdAddRack.Click += new EventHandler(cmdAddRack_Click);

            dcLayout.Controls.Add(cmdAddRack,1,0);
            dcLayout.Controls.Add(rackPanel);
            newTab.Controls.Add(dcLayout);
           
            newTab.AllowDrop = true;
                   
         
        }


        private void cmdAddRack_Click(object sender, EventArgs e)
        {
            frmAjoutRack f = new frmAjoutRack();
            f.ShowDialog(this);
        }

        private void lstExistingDC_DoubleClick(object sender, EventArgs e)
        {
            int DcToOpen = lstExistingDC.SelectedIndex;

        }

        private void frmMenuHome_Resize(object sender, EventArgs e)
        {
            //foreach();
        }

    }
}
