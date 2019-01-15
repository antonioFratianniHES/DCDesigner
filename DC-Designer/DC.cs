using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC_Designer
{
    class DC
    {
        String nomDc;
        List<Row> rows;
        String company;
        int dcid;
        int nbrangee=0;
        private TableLayoutPanel dcDesign;
        List<Rack> racks = new List<Rack>();
        List<Equipement> equipements = new List<Equipement>();
        OracleConnection con = new OracleConnection
        {
            ConnectionString = "DATA SOURCE=HEGLOCAL;PASSWORD=DCDesigner_data;PERSIST SECURITY INFO=True;USER ID=DCDESIGNER_DATA"
        };

        public DC(String nomDc, int dcid,String company,Boolean editable)
        {
            this.nomDc = nomDc;
            this.company = company;
            this.dcid = dcid;
            rows = new List<Row>();
            dcDesign = new TableLayoutPanel()
            {
                AllowDrop = true,
                AutoSize = true,
                AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink,
                ColumnCount = 2,
                Location = new System.Drawing.Point(18, 61),
                Margin = new System.Windows.Forms.Padding(2),
                Name = "dcLayout",
                RowCount = 1,
                Size = new System.Drawing.Size(0, 0),
                

            };
            if (editable) { 
                Button cmdAddRack = CreateAddRackButton();
                dcDesign.Controls.Add(cmdAddRack, 0, 0);
            }
        }

        

        public TableLayoutPanel GetDcDesign() {
            ChargerDonnee();
            return dcDesign; }


        private void ChargerDonnee()
        {
            
            con.Open();
            OracleCommand cmdgetNbRangee = new OracleCommand("select nbrangee from vw_datacenter where dcid=" + dcid, con);
            OracleDataReader drnbRangee = cmdgetNbRangee.ExecuteReader();
            if (drnbRangee.Read())
            {
                nbrangee = drnbRangee.GetInt32(0);
            }
            OracleCommand cmdGetRows = new OracleCommand("select rangeid,rangeenom,dcid from vw_range where dcid = "+dcid,con);
            OracleDataReader drGetRows = cmdGetRows.ExecuteReader();
            while (drGetRows.Read()) {
                List<Rack> racksRange = new List<Rack>();
                OracleCommand cmdgetRacks = new OracleCommand("select rackid,rackname,racksize,rangeeid,rangeeposition from vw_rack where rangeeid=" + drGetRows.GetInt32(0), con);
                OracleDataReader drGetRacks = cmdgetRacks.ExecuteReader();
                while (drGetRacks.Read()) {

                    OracleCommand cmdgetEquip = new OracleCommand("select numero,equipmentname,rackposition from vw_equipment where rackid=" + drGetRacks.GetInt32(0), con);
                    OracleDataReader drGetEquip = cmdgetEquip.ExecuteReader();
                    while (drGetEquip.Read())
                    {
                        equipements.Add(new Equipement(drGetEquip.GetInt32(0), drGetEquip.GetString(1), "", drGetEquip.GetInt32(2)));
                    }
                    Rack rackToAdd = new Rack(drGetRacks.GetInt32(0), drGetRacks.GetString(1), equipements);
                    racksRange.Add(rackToAdd);
                    dcDesign.Controls.Add(rackToAdd.GetRackDesign(),drGetRacks.GetInt32(4)-1, Convert.ToInt32(drGetRows.GetString(1))-1);
                }
                rows.Add(new Row(drGetRows.GetInt32(0),drGetRows.GetInt32(2), racksRange));
            }


            con.Close();

        }
        public void ShowLayout()
        {
            ChargerDonnee();
            for (int i = 0; i < nbrangee; i++)
            {
                Addrows();
            }

        }
        public String GetNom() { return nomDc; }
        public List<Row> GetRows() { return rows; }

        public String GetCompany() { return company; }

        public void SetNom(String nomDc) { this.nomDc = nomDc; }

        public void Addrows()
        {
            nbrangee++;
            dcDesign.RowCount++;
            dcDesign.Controls.Add(CreateAddRackButton(), 0, dcDesign.RowCount-1);
        }

        public void SetCompany(String company) { this.company = company; }

        public int Save()
        {
                       
            con.Open();
            OracleCommand cmdgetId = new OracleCommand("select companyid from vw_company where companyname='" + company+ "'", con);
            OracleDataReader dr = cmdgetId.ExecuteReader();
            if (dr.Read()) { 
                OracleCommand cmdAddDc = new OracleCommand("insert into vw_datacenter(datacentername,coid,nbrangee) VALUES('" + nomDc + "','" +dr.GetInt32(0)  + "','" + rows.Count + "')", con);
                cmdAddDc.ExecuteNonQuery();
                OracleCommand cmdgetDcId = new OracleCommand("select dcid from vw_datacenter where datacentername='" +nomDc + "'", con);
                OracleDataReader dr2 = cmdgetDcId.ExecuteReader();
                if (dr2.Read()) { 
                    dcid = dr2.GetInt32(0);
                }
            }
            con.Close();
            int i = 0;
            foreach (Row row in rows)
            {
                row.Save(i++, dcid);
            }
                return dcid;
        }

        public void Update() {
            foreach (Row row in rows)
            {
                row.Update();
            }
            con.Open();
            OracleCommand cmdUpdateDC = new OracleCommand("UPDATE vw_datacenter SET datacenterNAME = '" + nomDc + "' , nbrangee= " + nbrangee + "  WHERE dcid =  " + dcid, con);
            cmdUpdateDC.ExecuteNonQuery();
            con.Close();
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

        private void CmdAddRack_Click(object sender, EventArgs e)
        {
            FrmAjoutRack f = new FrmAjoutRack();
            f.ShowDialog(dcDesign.Parent);
            Rack r = GestionRack.GetRack();
            if (r != null)
            {
                Button cmdAddRack = (Button)sender;
                TableLayoutPanelCellPosition cellNewRack = dcDesign.GetCellPosition(cmdAddRack);
                dcDesign.ColumnCount++;
                dcDesign.Controls.Remove(cmdAddRack);
                dcDesign.Controls.Add(r.GetRackDesign(), cellNewRack.Column, cellNewRack.Row);
                dcDesign.Controls.Add(cmdAddRack, cellNewRack.Column + 1, cellNewRack.Row);
                rows[cellNewRack.Row].AddRack(r);
            }
        }

        public override bool Equals(object obj)
        {
            DC dC = obj as DC;
            return dC != null &&
                   nomDc == dC.nomDc &&
                   EqualityComparer<List<Row>>.Default.Equals(rows, dC.rows);
        }

        public override int GetHashCode()
        {
            var hashCode = 1380730520;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomDc);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Row>>.Default.GetHashCode(rows);
            return hashCode;
        }
    }
}
