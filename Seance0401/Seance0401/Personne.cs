using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0401
{
    class Personne : IAffichable
    {
        private string nom, prenon;

        public Personne(string nom, string prenon)
        {
            this.nom = nom;
            this.prenon = prenon;
        }

        public void afficher()
        {
            Console.WriteLine(nom + " " + prenon);
        }

        public void afficher(string message)
        {
            Console.WriteLine(nom + " " + prenon + " " + message);
        }
    }
}
