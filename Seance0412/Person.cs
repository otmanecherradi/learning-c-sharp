using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance0412
{
    class Person
    {
        public string CIN { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string SituationFamiliale { get; set; }
        public string City { get; set; }

        public Person(string cIN, string nom, string pernom, int age, string situationFamiliale, string ville)
        {
            CIN = cIN;
            LastName = nom;
            FirstName = pernom;
            Age = age;
            SituationFamiliale = situationFamiliale;
            City = ville;
        }
    }
}
