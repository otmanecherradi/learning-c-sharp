using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0323
{
    class Personne
    {
        private string nom;
        public string Nom { get => nom; set => nom = value; }
        private string prenom;
        public string Prenom { get => prenom; set => prenom = value; }

        public Personne() { }

        public Personne(string n, string p)
        {
            nom = n;
            prenom = p;
        }

        public override string ToString()
        {
            return $"Personne {{\n\tNon = {Nom};\n\tPrenom = {Prenom};\n}}\n";
        }
    }
}
