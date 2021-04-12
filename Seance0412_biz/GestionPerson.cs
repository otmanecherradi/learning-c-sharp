using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance0412_biz
{
    class GestionPerson
    {
        public List<Person> PS;

        public GestionPerson()
        {
            PS = new List<Person>();
        }

        public void Add(Person p)
        {
            PS.Add(p);
        }

        public Person Search(string cin)
        {
            foreach (Person p in PS)
                if (p.CIN.Equals(cin))
                    return p;
            throw new Exception("Not Found");
        }

        public void Update(string cin, int age)
        {
            Person p = Search(cin);
            p.Age = age;
        }
        
        public void Delete(string cin)
        {
            Person p = Search(cin);
            PS.Remove(p);
        }
    }
}
