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
        private String userCompany="test1";
        private List<User> users = new List<User>();
        private List<DC> dCs = new List<DC>();
        private List<Company> companies = new List<Company>();
        private List<DC> filteredDcs = new List<DC>();
        private DC newDC;

        public FrmMenuHome()
        {
            InitializeComponent();
            TestValue();
            frmConnexion f = new frmConnexion();
            f.ShowDialog(this);
            userName = Login.GetUser();
            lblUserNameLogged.Text = userName;
            ViewByUser();
        }

        private void ViewByUser()
        {
            tblDcDesigner.TabPages.Clear();
            tblDcDesigner.Show();
            if (userName == "admin")
            {
                cmdAddGestionUser.Show();
                cmbFiltreCompany.Show();
                lblFiltreCompany.Show();
                cmdCreateNewDC.Hide();
                txtNomDC.Enabled = false;
                cmdSave.Hide();
                PopulateLists();
            }
            AfficherListDC();
        }

        private void PopulateLists()
        {
            for (int i = 0; i < users.Count; i++)
            {
                lstUsers.Items.Add(users[i].GetUserName());
            }
            for (int i = 0; i < companies.Count; i++)
            {
                lstCompany.Items.Add(companies[i].getName());
                cmbUserCompany.Items.Add(companies[i].getName());
                cmbEditUserCompany.Items.Add(companies[i].getName());
            }
        }

        private void AfficherListDC()
        {
            lstExistingLayout.Items.Clear();
            if (userName == "admin") {
                foreach (var dC in dCs)
                {
                    lstExistingLayout.Items.Add(dC.GetNom());
                    cmbFiltreCompany.Items.Add(dC.GetCompany());
                }
                //TODO
                //afficherToutLesDC
                //ajout de tous les clients dans le filtre drop
            }
            else
            {
                foreach (var dC in dCs) { 

                    if (dC.GetCompany().Equals(userCompany))
                    {
                        filteredDcs.Add(dC);
                        lstExistingLayout.Items.Add(dC.GetNom());
                    }
                    
                }
                //TODO
                //afficherParClient
            }
        }




        public void InitTab() {
            //remet la tab à zero
            txtNomDC.Text = "";
            pnlLayout.Controls.Clear();
            tblDcDesigner.TabPages.Remove(tabLayout);
        }

        public void SaveLayout() {
            if (tblDcDesigner.TabPages.Contains(tabLayout))
            {
                if (!dCs.Contains(newDC))
                {
                    newDC.SetNom(txtNomDC.Text);
                    dCs.Add(newDC);
                    filteredDcs.Add(newDC);
                    lstExistingLayout.Items.Add(newDC.GetNom());
                }
                newDC.SetNom(txtNomDC.Text);

            }
            AfficherListDC();
            //TODO
            //sauve les données des rack
        }

      
        private void LstExistingDC_DoubleClick(object sender, EventArgs e)
        {
            if (lstExistingLayout.SelectedItem!=null)
            {
                if (tblDcDesigner.TabPages.Contains(tabLayout) && userName != "admin") {
                    AlertSave();
                }
                int dCToOpen = lstExistingLayout.SelectedIndex;
                
                if ((userName=="admin" && cmbFiltreCompany.SelectedText != "") || userName!="admin")
                {
                    newDC = filteredDcs[dCToOpen];
                }
                else
                {
                    newDC = dCs[dCToOpen];
                }
                
                if (userName=="admin" && tblDcDesigner.TabPages.Contains(tabLayout))
                {
                    tblDcDesigner.TabPages.Remove(tabLayout);
                    pnlLayout.Controls.Add(newDC.GetDcDesign());
                   //pnlLayout.Controls.Add(newDC.GetDcDesingWithoutEdit());
                }
                else
                {
                    pnlLayout.Controls.Add(newDC.GetDcDesign());
                    
                }
                if(!tblDcDesigner.TabPages.Contains(tabLayout)){ 
                    tblDcDesigner.TabPages.Add(tabLayout);
                    tblDcDesigner.SelectedTab = tabLayout;
                   
                    txtNomDC.Text = newDC.GetNom();
                    
                }
                lstExistingLayout.ClearSelected();
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
            if (!tblDcDesigner.TabPages.Contains(tabLayout))
            {
                tblDcDesigner.TabPages.Add(tabLayout);
            }
              
              
            
            newDC = new DC("NewLayout", userCompany, new List<Row>());
            pnlLayout.Controls.Add(newDC.GetDcDesign());
            
        }

        private void CmdAddRow_Click(object sender, EventArgs e)
        {
            newDC.Addrows();
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
            if (tblDcDesigner.TabPages.Contains(tabLayout))
            {
                pnlLayout.Controls.Clear();
                tblDcDesigner.TabPages.Remove(tabLayout);
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
            lstExistingLayout.Items.Clear();
            foreach (var dc in dCs)
            {
                if (dc.GetCompany().Equals(cmbFiltreCompany.Text))
                {
                    filteredDcs.Add(dc);
                    lstExistingLayout.Items.Add(dc.GetNom());
                }
                    
                
            }         
            
            
            //changer la liste pour afficher que les clients selectionner
        }


        private void CmdAddUser_Click(object sender, EventArgs e)
        {
            lstUsers.Items.Add(txtUserName.Text);
            txtUserName.Text = "";
            txtPassword.Text = "";
            cmbUserCompany.Text = "";
            users.Add(new User(txtUserName.Text, cmbUserCompany.SelectedText));
            //TODO
            //ajout de l'user à la base
        }


        private void CmdRemoveUser_Click(object sender, EventArgs e)
        {
            if (lstUsers.Items.Count!=0)
            {
                switch (MessageBox.Show("Do you want to remove the selected user?", "deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        users.RemoveAt(lstUsers.SelectedIndex);
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
            if (lstCompany.Items.Count!=0)
            {
                switch (MessageBox.Show("Do you want to remove the selected Client?", "deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        companies.RemoveAt(lstCompany.SelectedIndex);
                        lstCompany.Items.Remove(lstCompany.SelectedItem);
                        
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
            if (txtNameCompany.Text!="" && txtNameCompany.Text.Length>1)
            {
                lstCompany.Items.Add(txtNameCompany.Text);
                cmbFiltreCompany.Items.Add(txtNameCompany.Text);
                cmbUserCompany.Items.Add(txtNameCompany.Text);
                cmbEditUserCompany.Items.Add(txtNameCompany.Text);
                txtNameCompany.Text = "";
                txtAddressCompany.Text = "";
                txtTelCompany.Text = "";
                companies.Add(new Company(txtNameCompany.Text, txtAddressCompany.Text, txtTelCompany.Text));
                //TODO
                //Ajout à la base
            }


        }

        private void CmdAddGestionUser_Click(object sender, EventArgs e)
        {
            if (!tblDcDesigner.TabPages.Contains(tabUserManager))
            {
                tblDcDesigner.TabPages.Add(tabUserManager);
            }
            tblDcDesigner.SelectedTab = tabUserManager;
        }

        private void CmdCloseUserManager_Click(object sender, EventArgs e)
        {
            tblDcDesigner.TabPages.Remove(tabUserManager);
        }

        private void CmdCloseClientManager_Click(object sender, EventArgs e)
        {
            tblDcDesigner.TabPages.Remove(tabCompanyManager);
        }

        private void CmdNewClient_Click(object sender, EventArgs e)
        {
            if (!tblDcDesigner.TabPages.Contains(tabCompanyManager))
            {
                tblDcDesigner.TabPages.Add(tabCompanyManager);
            }
            tblDcDesigner.SelectedTab = tabCompanyManager;
        }

        private void CmdLogOut_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Do you want to log out and save?", "logging out", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    if (userName != "admin"  )
                    {
                        SaveLayout();
                    }
                    else { SaveUserClient(); }
                    Application.Restart();
                    break;
                case DialogResult.No:
                    Application.Restart();
                    break;
                case DialogResult.Cancel:

                    break;

            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Do you want to save before quiting?", "quiting", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop))
            {
                case DialogResult.Yes:
                    if (userName!="admin")
                    {
                        SaveLayout();
                    }
                    else { SaveUserClient(); }
                    Close();
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

 

        private void CmdCloseUser_Click(object sender, EventArgs e)
        {
            tblDcDesigner.TabPages.Remove(tabEditUser);
        }

        private void CmdCloseCompany_Click(object sender, EventArgs e)
        {
            tblDcDesigner.TabPages.Remove(tabEditCompany);
        }

        private void CmdEditUser_Click(object sender, EventArgs e)
        {
            if (lstUsers.Items.Count!=0)
            {
                if (!tblDcDesigner.TabPages.Contains(tabEditUser))
                {
                    tblDcDesigner.TabPages.Add(tabEditUser);
                }
                User editable = users[lstUsers.SelectedIndex];
                txtEditUserUsername.Text = editable.GetUserName();
                cmbEditUserCompany.Text = editable.GetCompany();
                tblDcDesigner.SelectedTab = tabEditUser;
            }
            
        }

        private void CmdEditCompany_Click(object sender, EventArgs e)
        {
            if (!tblDcDesigner.TabPages.Contains(tabEditCompany))
            {
                tblDcDesigner.TabPages.Add(tabEditCompany);
            }
            tblDcDesigner.SelectedTab = tabEditCompany;
            Company companyToEdit = companies[lstCompany.SelectedIndex];
            txtEditCompanyName.Text = companyToEdit.getName();
            txtEditCompanyTel.Text = companyToEdit.getTel();
            txtEditCompanyAddress.Text = companyToEdit.getAddress();
        }

        private void TestValue()
        {
            companies.Add(new Company("test1","address1","001"));
            companies.Add(new Company("test2", "address2","002"));
            users.Add(new User("test1","test1"));
            users.Add(new User("test2", "test2"));
            List<Row> row1 = new List<Row>();
            List<Rack> racks1 = new List<Rack>();
            Rack rack1 = new Rack("r1",4);
            Rack rack2 = new Rack("r2", 3);
            racks1.Add(rack1);
            racks1.Add(rack2);
            Row r1 = new Row(0, racks1);
            row1.Add(r1);
            dCs.Add(new DC("dc1","test1",row1));
            row1 = new List<Row>();
            racks1 = new List<Rack>();
            rack1 = new Rack("r1", 2);
            rack2 = new Rack("r2", 2);
            racks1.Add(rack1);
            racks1.Add(rack2);
            r1 = new Row(0, racks1);
            row1.Add(r1);
            dCs.Add(new DC("dc2", "test2", row1));
            //private List<DC> dCs = new List<DC>();
        }

    }
}
