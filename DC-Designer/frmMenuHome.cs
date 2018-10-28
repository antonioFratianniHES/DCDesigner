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
    public partial class FrmMenuHome : Form
    {
        private Button cmdRackName;
        public FrmMenuHome()
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


        private void CmdAddRack_Click(object sender, EventArgs e)
        {
            FrmAjoutRack f = new FrmAjoutRack();
            f.ShowDialog(this);
            Rack r = GestionRack.GetRack();
            if (r!=null){ 
                Button cmdAddRack = (Button)sender;
                TableLayoutPanelCellPosition cellNewRack = dcLayout.GetCellPosition(cmdAddRack);
            
                r.GetCmdRackName().Click+= new EventHandler(RackClickEvent);
                dcLayout.ColumnCount++;
                dcLayout.Controls.Remove(cmdAddRack);
                dcLayout.Controls.Add(r.GetRackDesign(),cellNewRack.Column,cellNewRack.Row);
                dcLayout.Controls.Add(cmdAddRack, cellNewRack.Column+1, cellNewRack.Row);
            }
        }

        public void InitTab() {
            //remet la tab à zero
            for (int i = 0; i < dcLayout.Controls.Count; i++)
            {
                dcLayout.Controls.RemoveAt(i);
            }
            txtNomDC.Text = "";
            newTab.Name="New Layout";
            tabLayout.Visible = false;
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
            Console.WriteLine(c.Name);
            if (c.Name == "cmdRackName")
            {
                String oldText = c.Text;
                Control p = c.Parent;
                cmdRackName = c;
                p.Controls.Remove(c);
                TextBox txtNewName = new TextBox
                {
                    Name = c.Name
                };
                txtNewName.LostFocus += new EventHandler(NewName_LostFocus);
                txtNewName.KeyPress += new KeyPressEventHandler(TxtNomDC_KeyPress);
                p.Controls.Add(txtNewName);
                txtNewName.Focus();
            }
           
        }

        private void NewName_LostFocus(object sender, EventArgs e)
        {
            CreateNameButton(sender);
        }

        private void CreateNameButton(object sender)
        {
            TextBox t = (TextBox)sender;
            cmdRackName.Text = t.Text;
            Control p = t.Parent;
            p.Controls.Remove(t);
            p.Controls.Add(cmdRackName);
            cmdRackName.Click += new EventHandler(RackClickEvent);
            
        }

        private void CmdAddRow_Click(object sender, EventArgs e)
        {
            //add row
        }

        private void TxtNomDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                CreateNameButton(sender);
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveLayout();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            InitTab();
        }
    }
}
