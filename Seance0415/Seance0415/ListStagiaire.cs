using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance0415
{
    class ListStagiaire
    {

        public List<Stagiaire> lstgs = new List<Stagiaire>();

        // the class to be public so that the prog can see it, even within the same namespace
        public Stagiaire Search(int n)
        {
            foreach (Stagiaire s in lstgs)
                if (s.Num.Equals(n))
                    return s;
            return null;
        }

        public bool Add(Stagiaire s)
        {
            Stagiaire st = Search(s.Num);
            if (st == null)
                lstgs.Add(st);
            return st == null;
        }

        public bool Update(int n, string m, string p)
        {
            Stagiaire s = Search(n);
            if (s != null)
            {
                s.Nom = m;
                s.Prenom = p;
            }
            return s != null;

        }

        public bool Delete(int n)
        {
            Stagiaire s = Search(n);
            if (s != null)
                lstgs.Remove(s);
            return s != null;
        }
    }
}
