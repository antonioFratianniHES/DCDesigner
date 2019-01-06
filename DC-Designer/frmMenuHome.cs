using Oracle.ManagedDataAccess.Client;
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
        private String userCompany;
        private SortedDictionary<int, String> cmpy = new SortedDictionary<int, String>();
        private SortedDictionary<int,User> users = new SortedDictionary<int,User>();
        private SortedDictionary<int,DC> filteredDcs = new SortedDictionary<int,DC>();
        private DC newDC;

        public FrmMenuHome()
        {
            InitializeComponent();
            frmConnexion f = new frmConnexion();
            f.ShowDialog(this);
            userName = Login.GetUser();
            userCompany = Login.GetCompany();
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
            }
            PopulateLists();
            AfficherListDC();
        }

        private void PopulateLists()
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "DATA SOURCE=XE;PASSWORD=DCDesigner_data;PERSIST SECURITY INFO=True;USER ID=DCDESIGNER_DATA";
            con.Open();
            OracleCommand cmd = new OracleCommand("select numero,name,CompanyID from vw_employee" , con);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                OracleCommand cmdCmpyName = new OracleCommand("select companyName from vw_company where companyid='"+dr.GetInt32(1)+"'", con);
                OracleDataReader drCmpy = cmd.ExecuteReader();
                users.Add(dr.GetInt32(0),new User(dr.GetString(1),drCmpy.GetString(0)));
            }
            con.Close();
        }

        private void AfficherListDC()
        {
            /*  lstExistingLayout.Items.Clear();
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
                }*/
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
                if (!filteredDcs.ContainsValue(newDC))
                {
                    newDC.SetNom(txtNomDC.Text);
                    
                    int cmpyNo = (from d in cmpy where d.Value == userCompany select d).First().Key;
                    newDC.SetCompany(userCompany);
                    int dcId = newDC.Save();
                    filteredDcs.Add(dcId, newDC);
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
          /*  lstExistingLayout.Items.Clear();
            foreach (var dc in dCs)
            {
                if (dc.GetCompany().Equals(cmbFiltreCompany.Text))
                {
                    filteredDcs.Add(dc);
                    lstExistingLayout.Items.Add(dc.GetNom());
                }
                    
                
            }     */    
            
            
            //changer la liste pour afficher que les clients selectionner
        }


        private void CmdAddUser_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "DATA SOURCE=XE;PASSWORD=DCDesigner_data;PERSIST SECURITY INFO=True;USER ID=DCDESIGNER_DATA";
            con.Open();
            int cmpyNo= (from d in cmpy where d.Value == cmbUserCompany.SelectedText select d).First().Key;
            OracleCommand cmdAddUser = new OracleCommand("insert into vw_employee(NAME,PASSWORD,companyid) VALUES('" + txtUserName.Text + "','" + txtPassword.Text + "','" + cmpyNo + "')", con);
            OracleCommand cmdgetId = new OracleCommand("select numero from vw_employee where name='"+txtUserName.Text+"'", con);
            OracleDataReader dr = cmdgetId.ExecuteReader();
            users.Add(dr.GetInt32(0),new User(txtUserName.Text, cmbUserCompany.SelectedText));
            con.Close();
            txtUserName.Text = "";
            txtPassword.Text = "";
            cmbUserCompany.Text = "";
        }


        private void CmdRemoveUser_Click(object sender, EventArgs e)
        {
            if (lstUsers.Items.Count!=0)
            {
                switch (MessageBox.Show("Do you want to remove the selected user?", "deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        int userToRemoveId= (from d in users where d.Value.GetUserName() == lstUsers.SelectedValue.ToString() select d).First().Key;
                        users.Remove(userToRemoveId);
                        OracleConnection con = new OracleConnection();
                        con.ConnectionString = "DATA SOURCE=XE;PASSWORD=DCDesigner_data;PERSIST SECURITY INFO=True;USER ID=DCDESIGNER_DATA";
                        con.Open();
                        OracleCommand cmdAddUser = new OracleCommand("delete from vw_employee where numero =" + userToRemoveId, con);
                        con.Close();
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

       

        private void FrmMenuHome_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetDataFinal.EMPLOYEE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.eMPLOYEETableAdapter.Fill(this.dataSetDataFinal.EMPLOYEE);
            // TODO: cette ligne de code charge les données dans la table 'dataSetDataFinal.COMPANY'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cOMPANYTableAdapter.Fill(this.dataSetDataFinal.COMPANY);


        }
    }
}
