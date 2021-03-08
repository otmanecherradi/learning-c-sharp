using System;
using System.Collections.Generic;

namespace Seance0308
{
    class Repertoire
    {
        private readonly List<Abonne> abonnesList;

        public Repertoire(int m)
        {
            abonnesList = new List<Abonne>(m);
        }

        public bool AddAbonne(Abonne a)
        {
            if (abonnesList.Count < abonnesList.Capacity)
            {
                abonnesList.Add(a);
                return true;
            }
            else
                return false;
        }

        public string GetNumero(string name)
        {
            foreach (Abonne abonne in abonnesList)
            {
                if (abonne.Nom.Equals(name))
                {
                    return abonne.PhoneNumber;
                }
            }

            return "";
        }

        public int GetNombreAbonnes()
        {
            return abonnesList.Count;
        }

        public List<Abonne> GetAbonnesTries()
        {
            List<Abonne> nl = abonnesList;
            nl.Sort((Abonne a1, Abonne a2) => a1.Nom.CompareTo(a2.Nom));
            return nl;
        }

        public void Affichier()
        {
            foreach (Abonne abonne in abonnesList)
            {
                Console.WriteLine(abonne.ToString());
            }
        }
    }
}
