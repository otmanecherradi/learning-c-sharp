using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0227
{
    class Stagiaire
    {
        private static int nbrStagiaire = 0;

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
        public string Nom
        {
            get
            {
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

        private double[] notes = new double[] { };
        public double[] Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }

        public Stagiaire()
        {
            nbrStagiaire += 1;
            matricule = StagiaireLength();
        }

        public Stagiaire(string n, string p, string f) : this()
        {
            nom = n;
            prenom = p;
            filiere = f;
        }

        public Stagiaire(string n, string p, string f, double[] ns) : this(n, p, f)
        {
            nom = n;
            prenom = p;
            filiere = f;
            notes = ns;
        }


        public Stagiaire(Stagiaire s) : this()
        {
            nom = s.Nom;
            prenom = s.Prenom;
            filiere = s.Filiere;
            notes = s.Notes;
        }

        public static int StagiaireLength()
        {
            return nbrStagiaire;
        }

        public static void RAZ()
        {
            nbrStagiaire = 0;
        }

        public static bool Equals(Stagiaire s1, Stagiaire s2)
        {
            return s1.matricule.Equals(s2.matricule);
        }

        public double Moyenne()
        {
            double s = 0;
            for (int i = 0; i < notes.Length; i += 1)
            {
                s += notes[i];
            }
            return s / notes.Length;
        }

        public double Moyenne(int[] coef)
        {
            // supposant que les coefficients et les notes on la meme taille, identique et pas nul
            double s = 0;
            double cs = 0;
            for (int i = 0; i < notes.Length; i += 1)
            {
                s += notes[i] * coef[i];
                cs += coef[i];
            }
            return s / cs;
        }

        public void Afficher()
        {
            //Console.WriteLine($"La matricule {matricule}\tLe nom {nom}\tLe prenom {prenom}\tLa filiere {filiere}\tLa moyenne {Moyenne()}");
            if (notes.Length != 0)
                Console.WriteLine($"Stagiaire {{\n\tMatricule = {matricule};\n\tNom = {nom};\n\tPrenom = {prenom};\n\tFiliere = {filiere};\n\tMoyenne = {Moyenne()}\n}}\n");
            else
                Console.WriteLine($"Stagiaire {{\n\tMatricule = {matricule};\n\tNom = {nom};\n\tPrenom = {prenom};\n\tFiliere = {filiere};\n\tMoyenne = Null\n}}\n");
        }
    }
}
