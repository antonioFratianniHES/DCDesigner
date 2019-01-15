using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Designer
{
     class Equipement
    {

        private String nom;
        private String description;
        private int id;
        private int position;
        OracleConnection con = new OracleConnection
        {
            ConnectionString = "DATA SOURCE=HEGLOCAL;PASSWORD=DCDesigner_data;PERSIST SECURITY INFO=True;USER ID=DCDESIGNER_DATA"
        };
        public Equipement(String nom, String description)
        {
            this.nom = nom;
            this.description = description;
        }

        public Equipement(int id,String nom, String description,int position)
        {
            this.id = id;
            this.nom = nom;
            this.description = description;
            this.position = position;
        }

        public String GetNom() { return nom; }

        public void SetNom(String nom) { this.nom= nom; }

        public String GetDescr() { return description; }

        public override bool Equals(object obj)
        {
            var equipement = obj as Equipement;
            return equipement != null &&
                   nom == equipement.nom;
        }

        public override int GetHashCode()
        {
            return 1933275133 + EqualityComparer<string>.Default.GetHashCode(nom);
        }

        internal void Save(int rackId)
        {
            con.Open();
            OracleCommand cmdSaveEquip = new OracleCommand("insert into vw_equipment (equipmentname, typeequipement,rackid,rackposition) values('"+ nom +"','"+ description + "', "+rackId+", " + position + ")", con);
            cmdSaveEquip.ExecuteNonQuery();
            con.Close();
        }

        internal void Update()
        {
            con.Open();
            OracleCommand cmdUpdateEquip = new OracleCommand("UPDATE vw_equipment SET equipmentname = '" +nom + "' , typeequipement= '" + description + "', rackposition = "+position+"  WHERE numero =  " + id, con);
            cmdUpdateEquip.ExecuteNonQuery();
            con.Close();
        }
    }
}
