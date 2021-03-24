using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0324
{
    abstract class Voiture
    {
        public string Numero { get; set; }
        public double PrixBase { get; set; }


        public Voiture() { }

        public Voiture(string im, double pxb)
        {
            Numero = im;
            PrixBase = pxb;
        }


        public abstract double getPrix();

        public override string ToString()
        {
            return Numero;
        }
    }
}
