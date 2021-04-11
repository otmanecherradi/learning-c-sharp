using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Stagiaire
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string Option { get; set; }
        public string Age { get; set; }

        public Stagiaire()
        {
        }

        public Stagiaire(string lastName, string firstName, string gender, string option, string age)
        {
            LastName = lastName;
            FirstName = firstName;
            Gender = gender;
            Option = option;
            Age = age;
        }

        public string[] ToList()
        {
            return new string[] { LastName, FirstName, Gender, Option, Age };
        }
    }
}
