using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0325
{
    class Occasion : Voiture
    {

        public readonly int NombreKilometre;
        public readonly int Age; // years

        public Occasion() : base() { }


        public Occasion(string im, double pxb, int nbrK, int age) : base(im, pxb)
        {
            NombreKilometre = nbrK;
            Age = age;
        }


        public override double getPrix()
        {
            double price = 0;
            
            if (NombreKilometre > 20000)
                price = PrixBase + ((NombreKilometre + 20000) * 0.05);
            else
                price = PrixBase - ((NombreKilometre + 20000) * 0.05);

            return price;
        }

        public override string ToString()
        {
            return string.Join(' ', base.ToString(), Numero, Age, NombreKilometre, getPrix());
        }
    }
}
