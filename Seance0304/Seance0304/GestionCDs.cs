using System;
using System.Collections;
using System.Text;

namespace Seance0304
{
    class GestionCDs
    {
        private ArrayList cds;
        public ArrayList CDs
        {
            get { return cds; }
            set { cds = value; }
        }

        public GestionCDs()
        {
            cds = new ArrayList();
        }

        private bool isPresent(int n)
        {
            foreach (CD cD in cds)
                if (cD.Numero.Equals(n))
                    return true;
            return false;
        }

        public bool AjouterCD(CD cd)
        {
            if (isPresent(cd.Numero))
                return false;

            cds.Add(cd);
            return true;
        }

        public bool AjouterCD(int n, string t, Genres g, DateTime d, string a)
        {
            if (isPresent(n))
                return false;

            CD newCD = new CD(n, t, g, d, a);
            cds.Add(newCD);
            return true;
        }

        public bool RechercherCD(int n) => isPresent(n);

        public int RechercherCD(string t)
        {
            int r = -1;
            foreach (CD cD in cds)
            {
                if (cD.Titre.Equals(t))
                    r = 1;
            }
            return r;
        }

        public bool ModifierCD(int n, string t, Genres g, DateTime d, string a)
        {
            if (!isPresent(n))
                return false;


            foreach (CD cD in cds)
            {
                if (cD.Numero.Equals(n))
                {
                    cD.Titre = t;
                    cD.Genre = g;
                    cD.DateEdition = d;
                    cD.Author = a;                    
                }

            }

            return true;
        }

        public void AffichierCDs()
        {
            foreach (CD cD in cds)
                Console.WriteLine(cD.ToString());
        }

    }
}
