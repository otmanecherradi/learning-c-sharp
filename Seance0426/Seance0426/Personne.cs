using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance0426
{
    class Personne
    {

        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int NumeroPlace { get; set; }
        public double MontantAPayer { get; set; }
        public double RestAPayer { get; set; }

        public Personne() { }

        public Personne(string cin, string nom, string prenom, int numeroPlace, double montantAPayer, double restAPayer)
        {
            CIN = cin;
            Nom = nom;
            Prenom = prenom;
            NumeroPlace = numeroPlace;
            MontantAPayer = montantAPayer;
            RestAPayer = restAPayer;
        }
    }
}
