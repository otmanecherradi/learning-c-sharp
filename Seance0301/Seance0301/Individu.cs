using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0301
{
    class Individu
    {
        private int code;
        public int Code
        {
            get { return code; }
            set { code = value; }
        }

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

        public Individu()
        {
            Code = new Random().Next(9999);
            Nom = "Inconnu";
            Prenom = "Inconnu";
        }

        public Individu(int c, string n, string p)
        {
            Code = c;
            Nom = n;
            Prenom = p;
        }

        public virtual void Afficher()
        {
            Console.WriteLine($"Individu {{\n\tCode = {Code};\n\tNom {Nom};\n\tPrenom = {Prenom};\n}}\n");
        }
    }
}
