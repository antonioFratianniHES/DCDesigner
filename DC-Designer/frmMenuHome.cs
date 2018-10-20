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

        private void CmdCreateNewDC_Click(object sender, EventArgs e)
        {
            if (tabLayout.Visible == true) {
                FrmSaveLayout save = new FrmSaveLayout();
                save.ShowDialog(this);
            }
            else  tabLayout.Visible = true;

            Rack r = new Rack("New Rack", 10);
            TableLayoutPanel rackPanel = r.GetRackDesign();
            dcLayout.Controls.Add(rackPanel);
            Button t = r.GetCmdRackName();
            t.Click += new EventHandler(RackClickEvent);


            Button cmdAddRack = new Button
            {
                Name = "cmdAddRack",
                Text = "+",
                Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = SystemColors.HotTrack,
                Size = new Size(49, 51),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                Anchor = AnchorStyles.None,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };
            cmdAddRack.Click += new EventHandler(CmdAddRack_Click);

            dcLayout.Controls.Add(cmdAddRack, 1, 0);


            tabLayout.AllowDrop = true;
                  
         
        }

        public void AddRack(String nom, int nbU) {
            Rack r = new Rack(nom,nbU);
            
        }

        private void CmdAddRack_Click(object sender, EventArgs e)
        {
            FrmAjoutRack f = new FrmAjoutRack();
            f.ShowDialog(this);
            
        }

        public void InitTab() {
            //remet la tab à zero
        }

        public void SaveLayout() {
            //sauve les données des rack
        }

        private void LstExistingDC_DoubleClick(object sender, EventArgs e)
        {
            if (lstExistingDC.SelectedValue!=null && tabLayout.Visible == true) {
                FrmSaveLayout save = new FrmSaveLayout();
                save.ShowDialog(this);
            }
            else { 
            int DcToOpen = lstExistingDC.SelectedIndex;
                //afficher les données du layout selectionné
            }
        }

        private void RackClickEvent(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            if (c.Name == "cmdRackName")
            {
                String oldText = c.Text;
                Control oldParent = c.Parent;
                oldParent.Controls.Remove(c);
                TextBox newName = new TextBox();
                newName.LostFocus += new EventHandler(newName_LostFocus);
                oldParent.Controls.Add(newName);
            }
           
        }

        private void newName_LostFocus(object sender, EventArgs e)
        {
            
            TextBox t = (TextBox)sender;

            String oldText = t.Text;
          //  Button cmdRackName = Rack.createRackName(nom: oldText);
        }
    }
}
