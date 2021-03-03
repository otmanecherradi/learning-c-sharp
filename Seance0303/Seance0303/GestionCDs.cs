using System;
using System.Collections;
using System.Text;

namespace Seance0303
{
    class GestionCDs
    {
        private ArrayList cds;

        private bool isPresent(int n)
        {
            foreach (CD cD in cds)
                if (cD.Numero.Equals(n))
                    return true;
            return false;
        }

        public void AjouterCD(CD cd)
        {
            if (!isPresent(cd.Numero))
                cds.Add(cd);
            else
                Console.WriteLine("CD already in list");
        }

        public void AjouterCD(int n, string t, Genres g, DateTime d, string a)
        {
            if (!isPresent(n))
            {
                CD newCD = new CD(n, t, g, d, a);
                cds.Add(newCD);
            }
            else
                Console.WriteLine("CD already in list");
        }

        public void RechercherCD(int n)
        {
            foreach (CD cD in cds)
            {
                if (cD.Numero.Equals(n))
                    Console.WriteLine(cD.ToString());
            }
        }

        public void RechercherCD(string t)
        {
            foreach (CD cD in cds)
            {
                if (cD.Titre.Equals(t))
                    Console.WriteLine(cD.ToString());
            }
        }

        public void ModifierCD(int n, string t, Genres g, DateTime d, string a)
        {
            foreach (CD cD in cds)
            {
                if (cD.Numero.Equals(n))
                {
                    Console.WriteLine(cD.ToString());
                    cD.Titre = t;
                    cD.Genre = g;
                    cD.DateEdition = d;
                    cD.Author = a;
                }
                    
            }
        }

        public void AffichierCDs()
        {
            foreach (CD cD in cds)
            {
                Console.WriteLine(cD.ToString());
            }
        }

    }
}
