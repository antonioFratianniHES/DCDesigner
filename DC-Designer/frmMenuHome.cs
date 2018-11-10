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
        private List<DC> dCs = new List<DC>();
        public FrmMenuHome()
        {
            InitializeComponent();
            frmConnexion f = new frmConnexion();
            f.ShowDialog(this);
            userName = Login.GetUser();
            ViewByUser();
        }

        private void ViewByUser()
        {
            tblDcDesigner.Show();
            tblDcDesigner.TabPages.Remove(tblLayout);
            if (userName == "admin")
            {
                cmbClient.Show();
                lblFiltreClient.Show();
                tblUserManager.Show();
                cmdCreateNewDC.Hide();
                cmdSave.Hide();
            }
            else
            {
                tblDcDesigner.TabPages.Remove(tblUserManager);
            }
            AfficherListDC();
        }

        private void AfficherListDC()
        {
            if (userName == "admin") {
                foreach (var dC in dCs)
                {
                   lstExistingDC.Items.Add( dC.GetNom());
                    cmbClient.Items.Add(dC.GetNom());
                }
                //TODO
                //afficherToutLesDC
                //ajout de tous les clients dans le filtre drop
            }
            else
            {
                //TODO
                //afficherParClient
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
            tblDcDesigner.TabPages.Remove(tblLayout);
        }

        public void SaveLayout() {
            //TODO
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
            if (lstExistingDC.SelectedValue!=null && tblDcDesigner.Visible == true) {
                AlertSave();
            }
            int dCToOpen = lstExistingDC.SelectedIndex;
            DC dC = dCs[dCToOpen];
            dcLayout.RowCount = dC.GetRows().Count;
            int i = 0;
            int j = 0;
            foreach (var row in dC.GetRows())
            {
                dcLayout.ColumnCount = row.GetRacks().Count;
                foreach (var rack in row.GetRacks())
                {
                    dcLayout.Controls.Add(rack.GetRackDesign(),i,j);
                    j++;
                }
                i++;
            }
           
            //TODO
            //afficher rack sauver pour admin sans modification possible
        }

        private void CmdCreateNewDC_Click(object sender, EventArgs e)
        {
            if (tblDcDesigner.Contains(tblLayout))
            {
                AlertSave();
            }
            else
            {
                tblDcDesigner.TabPages.Add(tblLayout);
            }
            

            Button cmdAddRack = CreateAddRackButton();
            dcLayout.Controls.Add(cmdAddRack, 0, 0);
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
            if (userName != "admin")
            {
                AlertSave();
            }            
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
                    break;
            }
        }

        private void CmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO
            //changer la liste pour afficher que les clients selectionner
        }


        private void CmdAddUser_Click(object sender, EventArgs e)
        {
            lstUsers.Items.Add(txtUserName);
            //TODO
            //ajout de l'user à la base
        }


        private void CmbEntreprise_TextChanged(object sender, EventArgs e)
        {
            int index = cmbEntreprise.FindString(cmbEntreprise.Text);
            if (index != 0)
            {
                cmbEntreprise.SelectedIndex = index;
            }
        }

        private void CmdRemoveUser_Click(object sender, EventArgs e)
        {
            if (lstUsers.Items.Count!=0)
            {
                switch (MessageBox.Show("Do you want to remove the selected user?", "deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        lstUsers.Items.Remove(lstUsers.SelectedItem);
                        //TODO
                        //remove de la base
                        break;

                    case DialogResult.No:

                        break;

                }
            }

        }

        private void CmdRemoveClient_Click(object sender, EventArgs e)
        {
            if (lstClient.Items.Count!=0)
            {
                switch (MessageBox.Show("Do you want to remove the selected Client?", "deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        lstClient.Items.Remove(lstClient.SelectedItem);
                        //TODO
                        //remove de la base
                        break;

                    case DialogResult.No:

                        break;

                }

            }

        }

        private void CmdAddClient_Click(object sender, EventArgs e)
        {
            if (txtClient.Text!="" && txtClient.Text.Length>1 &&!lstClient.Items.Contains(txtClient.Text))
            {
                lstClient.Items.Add(txtClient.Text);
                cmbClient.Items.Add(txtClient.Text);
                txtClient.Text = "";
                cmbEntreprise.Items.Add(txtClient.Text);
            }
                        
            //TODO
            //Ajout à la base
        }
    }
}
