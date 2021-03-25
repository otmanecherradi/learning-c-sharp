using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0325
{
    abstract class Voiture
    {
        public string Numero { get; set; }
        public double PrixBase;


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
