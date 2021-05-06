using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance0506
{
    class Filiere
    {
        public string Code { get; set; }

        public string Libelle { get; set; }

        public List<Stagiaire> Stagiaires { get; set; }

        public Filiere()
        {
            Stagiaires = new List<Stagiaire>();
        }

        public Filiere(string code, string libelle) : this()
        {
            Code = code;
            Libelle = libelle;
        }
    }
}
