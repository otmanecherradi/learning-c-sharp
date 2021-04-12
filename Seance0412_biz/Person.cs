using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance0412_biz
{
    class Person
    {
        public string CIN { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string FamilySituation { get; set; }
        public string City { get; set; }

        public Person(string cin, string lastName, string firstName, int age, string familySituation, string city)
        {
            CIN = cin;
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            FamilySituation = familySituation;
            City = city;
        }

        public string[] ToList()
        {
            return new string[] { CIN, LastName, FirstName, Age.ToString(), FamilySituation, City };
        }
    }
}
