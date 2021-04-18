using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance0415_biz
{
    public enum BloodType { O, A, B, AB }

    public enum RH { Plus, Minus }

    [Serializable]
    public class Donner
    {
        public string CIN { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public BloodType BloodGrp { get; set; }
        public RH Rhesus { get; set; }

        public Donner() { }

        public Donner(string cin, string lastName, string firstName, BloodType bloodGrp, RH rhesus)
        {
            CIN = cin;
            LastName = lastName;
            FirstName = firstName;
            BloodGrp = bloodGrp;
            Rhesus = rhesus;
        }

    }
}
