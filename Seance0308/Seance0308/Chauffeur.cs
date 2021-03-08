using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0308
{
    class Chauffeur
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private string cin;
        public string CIN
        {
            get { return cin; }
            set { cin = value; }
        }


        public Chauffeur() { }

        public Chauffeur(string n, string p, string c)
        {
            Nom = n;
            Prenom = p;
            CIN = c;
        }

        public override string ToString()
        {
            //return $"{GetType().Name} {{\n\tNom = {Nom};\n\tPrenom = {Prenom};\n\tCIN = {CIN};\n}}\n";
            return $"{Nom}\t{Prenom}\t{CIN}";
        }
    }
}
