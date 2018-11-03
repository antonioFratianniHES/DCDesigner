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
        private static String oldName;

        public static void setOldName(String name)
        {
            oldName = name;
        }

        public static String getOldName() { return oldName; }

        public static void setEquipement(String nom,String Descr)
        {
            e = new Equipement(nom,Descr);
        }

        public static void setEquipement(Equipement equip)
        {
            e = equip;
        }

        public static Equipement getEquipement()
        {
            return e;
        }
       
    }
}
