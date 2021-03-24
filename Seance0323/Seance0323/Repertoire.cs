using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0323
{
    class Repertoire
    {
        public readonly List<Abonne> Abonnes;

        public Repertoire(int m)
        {
            Abonnes = new List<Abonne>(m);
        }

        public bool AddAbonne(Abonne a)
        {
            if (Abonnes.Count < Abonnes.Capacity)
            {
                Abonnes.Add(a);
                return true;
            }
            else
                return false;
        }

        public void Delete(Abonne a)
        {
            Abonnes.Remove(a);
        }

        public dynamic SearchByName(string name)
        {
            foreach (Abonne abonne in Abonnes)
            {
                if (abonne.Nom.Equals(name))
                {
                    return abonne;
                }
            }

            return null;
        }

        public dynamic SearchByPhoneNumber(string phoneNbr)
        {
            foreach (Abonne abonne in Abonnes)
            {
                if (abonne.PhoneNumber.Equals(phoneNbr))
                {
                    return abonne;
                }
            }

            return null;
        }

        public int GetNombreAbonnes()
        {
            return Abonnes.Count;
        }

        public List<Abonne> GetAbonnesTries()
        {
            List<Abonne> nl = Abonnes;
            nl.Sort((Abonne a1, Abonne a2) => a1.Nom.CompareTo(a2.Nom));
            return nl;
        }

        public void Affichier()
        {
            foreach (Abonne abonne in Abonnes)
            {
                Console.WriteLine(abonne.ToString());
            }
        }
    }
}
