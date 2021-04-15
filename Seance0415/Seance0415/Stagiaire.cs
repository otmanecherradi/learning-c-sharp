using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance0415
{
    // !!!!!!! public just because it is used by the Form1 internal code !!!!!!!
    public class Stagiaire
    {
        public int Num { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Stagiaire() { }
        public Stagiaire(int num, string nom, string prenom)
        {
            Num = num;
            Nom = nom;
            Prenom = prenom;
        }
    }
}
