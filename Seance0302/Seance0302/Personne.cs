using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0302
{
    class Personne
    {
        private string nom;
        private string prenom;
        private int age;
        private string profession;

        public Personne()
        {
            profession = "";
            age = -1;
        }

        public Personne(string n, string p) : this()
        {
            nom = n;
            prenom = p;
        }

        public Personne(string n, string p, int a) : this()
        {
            nom = n;
            prenom = p;
            age = a;
        }

        public Personne(string n, string p, int a, string f)
        {
            nom = n;
            prenom = p;
            age = a;
            profession = f;
        }


        public void SetNom(string n) { nom = n; }
        public string GetNom() { return nom; }

        public void SetPrenom(string p) { prenom = p; }
        public string GetPrenom() { return prenom; }

        public void SetAge(int a) { age = a; }
        public int GetAge() { return age; }

        public void SetProfession(string f) { profession = f; }
        public string GetProfession() { return profession; }

        public virtual string SePresenter()
        {
            if (age != -1)
                //return $"Personne {{\n\tNon = {GetNom()};\n\tPrenom = {GetPrenom()};\n\tAge = {GetAge()};\n}}\n";
                return $"Je m'appelle {GetPrenom()} {GetNom()}, J'ai{GetAge()}";
            else
                //return $"Personne {{\n\tNon = {GetNom()};\n\tPrenom = {GetPrenom()};\n\tAge = {GetAge()};\n}}\n";
                return $"Je m'appelle {GetPrenom()} {GetNom()}";
        }
    }
}
