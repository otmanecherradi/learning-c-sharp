using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance0412
{
    class GestionPerson
    {
        public List<Person> Ps { get; set; }

        public GestionPerson()
        {
            Ps = new List<Person>();
        }

        public void Add(Person p)
        {
            Ps.Add(p);
        }

        public int Search(string cin)
        {
            int idx = -1;
            foreach (Person p in Ps)
                if (p.CIN.Equals(cin))
                    idx = Ps.IndexOf(p);
            return idx;
        }

        public void Update(string cin, int age)
        {
            int idx = Search(cin);
            if (idx != -1)
                Ps[idx].Age = age;
            else
                throw new Exception("Introuvable");
        }

        public void Delete(string cin)
        {
            int idx = Search(cin);
            if (idx != -1)
                Ps.RemoveAt(idx);
            else
                throw new Exception("Introuvable");
        }
    }
}
