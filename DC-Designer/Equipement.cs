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

        public Equipement(String nom, String description)
        {
            this.nom = nom;
            this.description = description;
        }

        public String getNom() { return nom; }

        public void setNom(String nom) { this.nom= nom; }

        public String getDescr() { return description; }

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
    }
}
