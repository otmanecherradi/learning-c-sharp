using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0301
{
    class Animateur : Individu
    {
        private string diplome;
        public string Diplome
        {
            get { return diplome; }
            set { diplome = value; }
        }

        private string specialite;
        public string Specialite
        {
            get { return specialite; }
            set { specialite = value; }
        }

        public Animateur() : base()
        {
            Diplome = "Inconnu";
            Specialite = "Inconnu";
        }

        public Animateur(int c, string n, string p, string d, string s) : base(c, n, p)
        {
            Diplome = d;
            Specialite = s;
        }

        public override void Afficher()
        {
            Console.WriteLine($"Animateur {{\n\tCode = {Code};\n\tNom {Nom};\n\tPrenom = {Prenom};\n\tDiplome = {Diplome};\n\tSpecialite = {Specialite};\n}}\n");
        }
    }
}
