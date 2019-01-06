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
        private TableLayoutPanel dcDesign;

        public DC(String nomDc, String company, List<Row> rows)
        {
            this.nomDc = nomDc;
            this.company = company;
            this.rows = rows;
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
            rows.Add(new Row(dcDesign.RowCount-1, new List<Rack>()));
            Button cmdAddRack = CreateAddRackButton();
            dcDesign.Controls.Add(cmdAddRack, 0, 0);
        }

        public TableLayoutPanel GetDcDesign() { return dcDesign; }

        public TableLayoutPanel GetDcDesingWithoutEdit()
        {
            TableLayoutPanel design = new TableLayoutPanel();
            int j = 0;
            foreach (Row row in rows)
            {
                List<Rack> racks = row.GetRacks();
                for (int i = 0; i <racks.Count ; i++)
                {
                    design.Controls.Add(racks[i].GetRackDesign(), i, j);
                }
                j++;
            }
            return design;
        }



        public String GetNom() { return nomDc; }
        public List<Row> GetRows() { return rows; }

        public String GetCompany() { return company; }

        public void SetNom(String nomDc) { this.nomDc = nomDc; }

        public void Addrows()
        {
            rows.Add(new Row(dcDesign.RowCount-1,new List<Rack>()));
            dcDesign.RowCount++;
            dcDesign.Controls.Add(CreateAddRackButton(), 0, dcDesign.RowCount-1);
        }

        public void SetCompany(String company) { this.company = company; }

        public int Save()
        {
            int dcid;
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "DATA SOURCE=XE;PASSWORD=DCDesigner_data;PERSIST SECURITY INFO=True;USER ID=DCDESIGNER_DATA";
            con.Open();
            OracleCommand cmdgetId = new OracleCommand("select companyid from vw_company where companyname='" + company+ "'", con);
            OracleDataReader dr = cmdgetId.ExecuteReader();

            OracleCommand cmdAddDc = new OracleCommand("insert into vw_datacenter(datacentername,coid,nbrangee) VALUES('" + nomDc + "','" +dr.GetInt32(0)  + "','" + rows.Count + "')", con);
            OracleCommand cmdgetDcId = new OracleCommand("select dcid from vw_datacenter where datacentername='" +nomDc + "'", con);
            OracleDataReader dr2 = cmdgetDcId.ExecuteReader();
            dcid = dr2.GetInt32(0);
            con.Close();
            int i = 0;
            foreach (Row row in rows)
            {
                row.Save(i++, dcid);
            }
                return dcid;
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
