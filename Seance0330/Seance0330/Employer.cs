using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0330
{
    class Employer : IComparable<Employer>, ICloneable
    {
        public int Salaire { get; set; }
        public string Nom { get; set; }

        public int CompareTo(Employer e)
        {
            if (Salaire == e.Salaire)
                return Nom.CompareTo(e.Nom);
            else
                return Salaire.CompareTo(e.Salaire);
        }

        public object Clone()
        {
            return new Employer() { Nom = Nom };
        }
    }
}
