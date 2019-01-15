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
    class Row
    {
        private int rowNum;
        private List<Rack> lstRacks = new List<Rack>();
        public Row(int rowNum,int dcid, List<Rack> lstRacks) {
            this.rowNum = rowNum;
            this.lstRacks = lstRacks;
        }

        public int GetRowNum() { return rowNum; }
        public List<Rack> GetRacks() { return lstRacks; }
        public void AddRack(Rack rack){ lstRacks.Add(rack);}

        internal void Update()
        {
            foreach (Rack rack in lstRacks)
            {
                rack.Update();
            }
        }

        internal void Save(int nomRow,int dcid)
        {
            int rowId;
            OracleConnection con = new OracleConnection
            {
                ConnectionString = "DATA SOURCE=HEGLOCAL;PASSWORD=DCDesigner_data;PERSIST SECURITY INFO=True;USER ID=DCDESIGNER_DATA"
            };
            con.Open();

            OracleCommand cmdAddDc = new OracleCommand("insert into vwrange(dcid) VALUES(" + dcid + ")", con);
            OracleCommand cmdgetDcId = new OracleCommand("select rangeid from vw_range where nomRange ='" + nomRow + "' and dcid="+dcid, con);
            OracleDataReader dr2 = cmdgetDcId.ExecuteReader();
            rowId = dr2.GetInt32(0);
            con.Close();
            int i = 0;
            foreach (Rack rack in lstRacks)
            {
                rack.Save(i++,rowId);
            }
        }
    }
}
