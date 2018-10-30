using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Designer
{
    internal class GestionRack
    {
        static string nomRack;
        static int tailleRack;

        internal static void SetRack(string nom,int taille) {
            nomRack = nom;
            tailleRack = taille;
        }

        internal static Rack GetRack() {
            if (nomRack == "" || tailleRack == 0) {
                return null;
            }
            return new Rack(nomRack, tailleRack);
        }
    }
}
