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
        private static bool editable=true;

        public static void SetOldName(String name)
        {
            oldName = name;
        }

        public static String GetOldName() { return oldName; }

        public static void SetEquipement(String nom,String Descr)
        {
            e = new Equipement(nom,Descr);
        }

        public static void SetEquipement(Equipement equip)
        {
            e = equip;
        }

        public static Equipement GetEquipement()
        {
            return e;
        }

        internal static bool GetEditable()
        {
            return editable;
        }

        public static void SetEditable(bool edit) { editable = edit; }
    }
}
