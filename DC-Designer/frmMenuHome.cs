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
        private String userName;
        public FrmMenuHome()
        {
            InitializeComponent();
            frmConnexion f = new frmConnexion();
            f.ShowDialog(this);
            userName = Login.GetUser();
            if (userName=="admin")
            {
                cmbClient.Show();
            }
        }


        private Button CreateAddRackButton()
        {
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
            return cmdAddRack;
        }



        public void InitTab() {
            //remet la tab à zero
            dcLayout.Controls.Clear();
            dcLayout.ColumnCount = 1;
            dcLayout.RowCount = 1;
            txtNomDC.Text = "";
            newTab.Name="New Layout";
            tabLayout.Visible = false;
        }

        public void SaveLayout() {
            //sauve les données des rack
        }

        private void CmdAddRack_Click(object sender, EventArgs e)
        {
            FrmAjoutRack f = new FrmAjoutRack();
            f.ShowDialog(this);
            Rack r = GestionRack.GetRack();
            if (r != null)
            {
                Button cmdAddRack = (Button)sender;
                TableLayoutPanelCellPosition cellNewRack = dcLayout.GetCellPosition(cmdAddRack);

                dcLayout.ColumnCount++;
                dcLayout.Controls.Remove(cmdAddRack);
                dcLayout.Controls.Add(r.GetRackDesign(), cellNewRack.Column, cellNewRack.Row);
                dcLayout.Controls.Add(cmdAddRack, cellNewRack.Column + 1, cellNewRack.Row);
            }
        }

        private void LstExistingDC_DoubleClick(object sender, EventArgs e)
        {
            if (lstExistingDC.SelectedValue!=null && tabLayout.Visible == true) {
                AlertSave();
            }
            else { 
            int DcToOpen = lstExistingDC.SelectedIndex;
                //afficher les données du layout selectionné
            }
        }

        private void CmdCreateNewDC_Click(object sender, EventArgs e)
        {
            if (tabLayout.Visible == true)
            {
                AlertSave();
            }
            else tabLayout.Visible = true;

            Button cmdAddRack = CreateAddRackButton();
            dcLayout.Controls.Add(cmdAddRack, 0, 0);
            dcLayout.AllowDrop = true;
            tabLayout.AllowDrop = true;

        }

        private void CmdAddRow_Click(object sender, EventArgs e)
        {
            dcLayout.Controls.Add(CreateAddRackButton(), 0, dcLayout.RowCount);
            dcLayout.RowCount += 1;
        }

       

        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveLayout();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            AlertSave();
        }

        private void AlertSave() {
            switch (MessageBox.Show("Do you want to save the Current DC?","Closing",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    SaveLayout();
                    InitTab();
                    break;

                case DialogResult.No:
                    InitTab();
                    break;

                case DialogResult.Cancel:
                    // "Cancel" processing
                    break;
            }
        }
    }
}
