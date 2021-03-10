using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0310
{
    class Formateur
    {
        public static int NbrFormateurs = 0;

        private int code;
        public int Code
        {
            get { return code; }
            set
            {
                if (value < 0)
                    throw new CodeException();
                else
                    code = value;
            }
        }

        private string nom;
        public string Nom
        {
            get { return nom; }
            set
            {
                if (value.Length < 3)
                    throw new NomException();
                else
                    nom = value;
            }
        }

        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public char sexe;
        public char Sexe
        {
            get { return sexe; }
            set
            {
                if (value != 'M' || value != 'F')
                    throw new SexeException();
                else
                    sexe = value;
            }
        }

        public int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string specialite;
        public string Specialite
        {
            get { return specialite; }
            set { specialite = value; }
        }


        public Formateur()
        {
            NbrFormateurs += 1;
            Code = NbrFormateurs;
        }

        public Formateur(string n, string p, char s, int a, string sp) : this()
        {
            Nom = n;
            Prenom = p;
            Sexe = s;
            Age = a;
            Specialite = sp;
        }


        public void Affiche()
        {
            Console.WriteLine($"{GetType().Name} {{\n\tCode = {Code};\n\tNom = {nom};\n\tPrenom = {prenom};\n\tSexe = {Sexe};\n\tAge = {Age}\n\tSpecialite = {Specialite}\n}}\n");
        }
    }
}
