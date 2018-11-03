using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Designer
{
    internal class GestionAjoutEquip
    {
        private static Equipement e;

        public static void setEquipement(String nom,String Descr)
        {
            e = new Equipement(nom,Descr);
        }

        public static Equipement getEquipement()
        {
            return e;
        }
       
    }
}
