using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0224
{
    class Stagiaire
    {
        private int matricule;
        public int Matricule
        {
            get
            {
                return matricule;
            }
            set
            {
                matricule = value;
            }
        }

        private string nom;
        public string Nom { 
            get {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        private string prenom;
        public string Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }

        private string filiere;
        public string Filiere
        {
            get
            {
                return filiere;
            }
            set
            {
                filiere = value;
            }
        }

        private double note1;
        public double Note1
        {
            get
            {
                return note1;
            }
            set
            {
                if (value < 0)
                    note1 = 0;
                else
                    note1 = value;
            }
        }

        private double note2;
        public double Note2
        {
            get
            {
                return note2;
            }
            set
            {
                if (value < 0)
                    note2 = 0;
                else
                    note2 = value;
            }
        }

        private double note3;
        public double Note3
        {
            get
            {
                return note3;
            }
            set
            {
                if (value < 0)
                    note3 = 0;
                else
                    note3 = value;
            }
        }

        public Stagiaire() { }

        public Stagiaire(int mtrl, string n, string p, string f, double n1, double n2, double n3) {
            matricule = mtrl;
            nom = n;
            prenom = p;
            filiere = f;
            note1 = n1;
            note2 = n2;
            note3 = n3;
        }

        public Stagiaire(string n, string p, string f)
        {
            nom = n;
            prenom = p;
            filiere = f;
        }

        public Stagiaire(Stagiaire s)
        {
            matricule = s.Matricule;
            nom = s.Nom;
            prenom = s.Prenom;
            filiere = s.Filiere;
            note1 = s.Note1;
            note2 = s.Note2;
            note3 = s.Note3;
        }

        //public bool Equals(Stagaire s)
        //{
        //    return this.matricule.Equals(s.matricule);
        //}

        public static bool Equals(Stagiaire s1, Stagiaire s2)
        {
            return s1.matricule.Equals(s2.matricule);
        }

        public double Moyenne() {
            double s = note1 + note2 + note3;
            return s / 3;
        }

        public void Affiche()
        {
            //Console.WriteLine($"La matricule {matricule}\tLe nom {nom}\tLe prenom {prenom}\tLa filiere {filiere}\tLa moyenne {Moyenne()}");
            Console.WriteLine($"Stagiaire {{\n\tMatricule = {matricule};\n\tNom {nom};\n\tPrenom = {prenom};\n\tFiliere = {filiere};\n\tMoyenne = {Moyenne()}\n}}\n");
        }
    }
}
