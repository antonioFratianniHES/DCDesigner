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
        private String adminCmpy="adminCompany";
        OracleConnection con = new OracleConnection
        {
            ConnectionString = "DATA SOURCE=XE;PASSWORD=DCDesigner_user;PERSIST SECURITY INFO=True;USER ID=DCDESIGNER_USER"
        };
        private SortedDictionary<int, Company> cmpy = new SortedDictionary<int, Company>();
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
            if (userCompany == adminCmpy)
            {
                cmdAddGestionUser.Show();
                cmbFiltreCompany.Show();
                lblFiltreCompany.Show();
                cmdCreateNewDC.Hide();
                txtNomDC.Enabled = false;
                cmdSave.Hide();
                cmdAddRow.Hide();
                PopulateLists();
            }
            
            AfficherListDC();
        }

        private void PopulateLists()
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("select numero,name,CompanyID from vw_employee" , con);
            OracleDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                OracleCommand cmdCmpyName = new OracleCommand("select CompanyName from vw_company where companyid='" + dr.GetInt32(2) + "'", con);
                OracleDataReader drCmpy = cmd.ExecuteReader();
                if (drCmpy.Read()) {
                    users.Add(i, new User(dr.GetInt32(0), dr.GetString(1), drCmpy.GetString(1)));
                    lstUsers.Items.Add(dr.GetString(1));
                }
                i++;
            }
            OracleCommand cmdCompy = new OracleCommand("select companyid,companyname,adress from vw_company", con);
            OracleDataReader drCompy = cmdCompy.ExecuteReader();
            i = 0;
            while (drCompy.Read())
            {
                cmpy.Add(i, new Company(drCompy.GetInt16(0),drCompy.GetString(1), drCompy.GetString(2),""));
          
                String cmpanyDB = drCompy.GetString(1);
                lstCompany.Items.Add(cmpanyDB);
                cmbEditUserCompany.Items.Add(cmpanyDB);
                cmbUserCompany.Items.Add(cmpanyDB);
                if(cmpanyDB!= adminCmpy) { 
                    cmbFiltreCompany.Items.Add(cmpanyDB);
                }
                i++;
            }
            con.Close();
        }

        private void AfficherListDC()
        {
            con.Open();
            String stringCmd = "select dcid,datacentername,nbRangee from vw_datacenter";
            if (userCompany != adminCmpy)
            {
                OracleCommand cmdGetCompanyName = new OracleCommand("select companyid from vw_company where companyname = '" +userCompany+ "'", con);
                OracleDataReader drGetComp = cmdGetCompanyName.ExecuteReader();
                if (drGetComp.Read()) { 
                    stringCmd += " where coid = '"+drGetComp.GetInt16(0)+"'";
                }
            }
            OracleCommand cmd = new OracleCommand(stringCmd, con);
            OracleDataReader drDatacenter = cmd.ExecuteReader();
            int i = 0;
            while (drDatacenter.Read())
            {
                Boolean editable = userCompany != adminCmpy;
                filteredDcs.Add(i,new DC(drDatacenter.GetString(1),drDatacenter.GetInt32(0),userCompany,editable));
                lstExistingLayout.Items.Add(drDatacenter.GetString(1));
                i++;
            }
            con.Close();
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
                    
                    int cmpyNo = (from d in cmpy where d.Value.GetName() == userCompany select d).First().Key;
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
                if (tblDcDesigner.TabPages.Contains(tabLayout) && userCompany != adminCmpy) {
                    AlertSave();
                }
                int dCToOpen = lstExistingLayout.SelectedIndex;
                
                
                newDC = filteredDcs[dCToOpen];
               
                
                if (userCompany==adminCmpy && tblDcDesigner.TabPages.Contains(tabLayout))
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
              
              
            
            newDC = new DC("NewLayout", filteredDcs.Count+1, userCompany,true);
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
            if (userCompany != adminCmpy)
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
            
            int idCmpyToFilter=-1;
            lstExistingLayout.Items.Clear();
            con.Open();
            OracleCommand cmdGetId = new OracleCommand("select companyid from vw_company where companyname ='"+cmbFiltreCompany.SelectedText+"'", con);
            OracleDataReader drGetId = cmdGetId.ExecuteReader();
            if (drGetId.Read()) {
                idCmpyToFilter = drGetId.GetInt32(0);
            }
            OracleCommand cmd = new OracleCommand("select dcid,datacentername,nbRangee from vw_datacenter where coid ='"+ idCmpyToFilter + "'", con);
            OracleDataReader drDatacenter = cmd.ExecuteReader();
            int i = 0;
            filteredDcs.Clear();
            while (drDatacenter.Read())
            {
                filteredDcs.Add(i, new DC(drDatacenter.GetString(1), drDatacenter.GetInt32(0), userCompany,false));
                lstExistingLayout.Items.Add(drDatacenter.GetString(1));
                i++;
            }
            con.Close();
            //changer la liste pour afficher que les clients selectionner
        }


        private void CmdAddUser_Click(object sender, EventArgs e)
        {
            con.Open();
            int cmpyNo = cmpy[cmbUserCompany.SelectedIndex].GetId();
                
            OracleCommand cmdAddUser = new OracleCommand("insert into vw_employee(NAME,PASSWORD,companyid) VALUES('" + txtUserName.Text + "','" + txtPassword.Text + "','" + cmpyNo + "')", con);
            cmdAddUser.ExecuteNonQuery();
            OracleCommand cmdgetId = new OracleCommand("select numero from vw_employee where name='"+txtUserName.Text+"'", con);
            OracleDataReader dr = cmdgetId.ExecuteReader();
            if (dr.Read())
            { 
                users.Add(users.Count+1,new User(dr.GetInt32(0)+1,txtUserName.Text, cmbUserCompany.SelectedText));
            }
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
                        int userToRemoveId = users[lstUsers.SelectedIndex].GetId();
                        users.Remove(userToRemoveId);
                        con.Open();
                        OracleCommand cmdRMUser = new OracleCommand("delete from vw_employee where numero =" + userToRemoveId, con);
                        cmdRMUser.ExecuteNonQuery();
                        con.Close();
                        lstUsers.Items.RemoveAt(lstUsers.SelectedIndex);
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
                        int cmpyToRemoveID = cmpy[lstCompany.SelectedIndex].GetId() ;
                        con.Open();
                        OracleCommand cmdRMUser = new OracleCommand("delete from vw_company where companyid =" + cmpyToRemoveID, con);
                        cmdRMUser.ExecuteNonQuery();
                        con.Close();
                        break;

                    case DialogResult.No:

                        break;

                }

            }

        }

        private void CmdAddClient_Click(object sender, EventArgs e)
        {
            if (txtNameCompany.Text!="" && txtNameCompany.Text.Length>1 && txtAddressCompany.Text.Length>1)
            {
                lstCompany.Items.Add(txtNameCompany.Text);
                con.Open();
                OracleCommand cmdAddCmpy = new OracleCommand("insert into vw_company(companyname,adress) VALUES('" + txtNameCompany.Text + "','" + txtAddressCompany.Text +"')", con);
                cmdAddCmpy.ExecuteNonQuery();
                OracleCommand cmdGetcmpyID = new OracleCommand("select companyid from vw_company where companyname= '"+ txtNameCompany.Text + "'",con);
                OracleDataReader dr = cmdGetcmpyID.ExecuteReader();
                if (dr.Read()) { 
                cmpy.Add(cmpy.Count, new Company(dr.GetInt32(0), txtNameCompany.Text, txtAddressCompany.Text, txtTelCompany.Text));
                }
                con.Close();
                txtNameCompany.Text = "";
                txtAddressCompany.Text = "";
                txtTelCompany.Text = "";
                PopulateLists();
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
            if (userCompany!= adminCmpy) { 
                switch (MessageBox.Show("Do you want to log out and save?", "logging out", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                         SaveLayout();
                        Application.Restart();
                        break;
                    case DialogResult.No:
                        Application.Restart();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            Application.Restart();
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
            Company companyToEdit = cmpy[lstCompany.SelectedIndex]; // à corriger
            txtEditCompanyName.Text = companyToEdit.GetName();
            txtEditCompanyTel.Text = companyToEdit.GetTel();
            txtEditCompanyAddress.Text = companyToEdit.GetAddress();
        }


        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
