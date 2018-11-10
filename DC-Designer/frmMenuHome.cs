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
            lblUserNameLogged.Text = userName;
            ViewByUser();
        }

        private void ViewByUser()
        {
            
            tblDcDesigner.TabPages.Remove(tabLayout);
            tblDcDesigner.TabPages.Remove(tabUserManager);
            tblDcDesigner.TabPages.Remove(tabClientManager);
            tblDcDesigner.Show();
            if (userName == "admin")
            {
                cmdAddGestionUser.Show();
                cmbClient.Show();
                lblFiltreClient.Show();
                
                cmdCreateNewDC.Hide();
                cmdSave.Hide();
            }
            AfficherListDC();
        }

        private void AfficherListDC()
        {
            if (userName == "admin") {
                foreach (var dC in dCs)
                {
                   lstExistingLayout.Items.Add( dC.GetNom());
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
            tblDcDesigner.TabPages.Remove(tabLayout);
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
            if (lstExistingLayout.SelectedValue != null)
            {
   
                if (tblDcDesigner.Visible == true) {
                    AlertSave();
                }
                int dCToOpen = lstExistingLayout.SelectedIndex;
                DC dC = dCs[dCToOpen];
                dcLayout.RowCount = dC.GetRows().Count;
                int i = 0;
                int j = 0;
                foreach (var row in dC.GetRows())
                {
                    dcLayout.ColumnCount = row.GetRacks().Count + 1;
                    foreach (var rack in row.GetRacks())
                    {
                        dcLayout.Controls.Add(rack.GetRackDesign(), i, j);
                        j++;
                    }
                    if (userName != "admin")
                    {
                        dcLayout.Controls.Add(CreateAddRackButton(),i,j+1);
                    }
                    i++;
                }
            }

            //TODO
            //afficher rack sauver pour admin sans modification possible
        }

        private void CmdCreateNewDC_Click(object sender, EventArgs e)
        {
            if (tblDcDesigner.Contains(tabLayout))
            {
                AlertSave();
            }
            else
            {
                tblDcDesigner.TabPages.Add(tabLayout);
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
            lstUsers.Items.Add(txtUserName.Text);
            txtUserName.Text = "";
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
            if (txtNameClient.Text!="" && txtNameClient.Text.Length>1)
            {
                lstClient.Items.Add(txtNameClient.Text);
                cmbClient.Items.Add(txtNameClient.Text);
                cmbEntreprise.Items.Add(txtNameClient.Text);
                txtNameClient.Text = "";
                txtAddressClient.Text = "";
                txtTelClient.Text = "";

                //TODO
                //Ajout à la base
            }


        }

        private void CmdAddGestionUser_Click(object sender, EventArgs e)
        {
            tblDcDesigner.TabPages.Add(tabUserManager);
        }

        private void CmdCloseUserManager_Click(object sender, EventArgs e)
        {
            tblDcDesigner.TabPages.Remove(tabUserManager);
        }

        private void CmdCloseClientManager_Click(object sender, EventArgs e)
        {
            tblDcDesigner.TabPages.Remove(tabClientManager);
        }

        private void CmdNewClient_Click(object sender, EventArgs e)
        {
            tblDcDesigner.TabPages.Add(tabClientManager);
            tblDcDesigner.SelectedTab = tabClientManager;
        }

        private void CmdLogOut_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Do you want to log out?", "logging out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    Application.Restart();
                    break;

                case DialogResult.No:

                    break;

            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Do you want to save before quiting?", "quiting", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop))
            {
                case DialogResult.Yes:
                    if (userName!="admin")
                    {
                        SaveLayout();
                    }
                    else { SaveUserClient(); }
                    break;

                case DialogResult.No:
                    Close();
                    break;

            }
        }

        private void SaveUserClient()
        {
            //TODO
            //save client et user dans la base
        }
    }
}
