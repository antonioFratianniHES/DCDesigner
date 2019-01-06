using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Designer
{
    internal class Login
    {
        static String user;
        static String company; 
        internal static void SetUser(string u) {
            //recupérer user dans la base
            user = u;
            
        }
        internal static String GetUser() { return user; }

        internal static String GetCompany() { return company; }

        internal static bool UserOk(String user,String pwd)
        {
            OracleConnection con = new OracleConnection(); 
            con.ConnectionString = "DATA SOURCE=XE;PASSWORD=DCDesigner_data;PERSIST SECURITY INFO=True;USER ID=DCDESIGNER_DATA";
            con.Open();
            OracleCommand cmd = new OracleCommand("select name,password,CompanyID from vw_employee where name='" + user + "'and password='" + pwd + "'",con);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
              {
                int compID = dr.GetInt32(2);
                OracleCommand cmd2 = new OracleCommand("select companyName from vw_company where companyID='" + compID +"'",con);
                OracleDataReader dr2 = cmd2.ExecuteReader();
                //company = dr2.GetString(0);
                return true;
              }
            con.Close();
            return false;
        }
            
    }
}
