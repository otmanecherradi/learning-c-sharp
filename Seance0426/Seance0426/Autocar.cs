using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance0426
{
    class Autocar
    {
        public List<Personne> Personnes { get; set; }

        public Autocar(int capacity)
        {
            Personnes = new List<Personne>(capacity);
        }

        public void Add(Personne p)
        {
            if (Personnes.Count + 1 > Personnes.Capacity)
                throw new Exception("Autocar Pleine");
            
            SearchDisponibility(p.NumeroPlace);

            Personnes.Add(p);
        }

        public void SearchDisponibility(int place)
        {
            foreach(Personne p in Personnes)
            {
                if (p.NumeroPlace.Equals(place))
                    throw new Exception("Place non vide");
            }
        }

        public void AddRange(Personne[] ps)
        {
            if (Personnes.Count + ps.Length > Personnes.Capacity)
                throw new Exception("Autocar Pleine");

            Personnes.AddRange(ps);
        }
    }
}
