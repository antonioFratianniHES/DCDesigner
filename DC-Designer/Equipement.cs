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
            throw new NotImplementedException();
        }
    }
}
