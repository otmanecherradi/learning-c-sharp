using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0310
{
    class Voiture
    {
        private string owner;
        public string Proprietaire
        {
            get { return owner; }
            set { owner = value; }
        }

        private string brand;
        public string Marque
        {
            get { return brand; }
            set { brand = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int nbrHorses;
        public int NbrChevaux
        {
            get { return nbrHorses; }
            set { nbrHorses = value; }
        }


        public Voiture() { }
        public Voiture(string n, string b, string t, int p)
        {
            owner = n;
            brand = b;
            type = t;
            nbrHorses = p;
        }


        public override string ToString()
        {
            return $"{GetType().Name} {{\n\tProprietaire = {Proprietaire};\n\tMarque = {Marque};\n\tType = {Type};\n\tNbrChevaux = {NbrChevaux};\n}}\n";
        }
    }
}
