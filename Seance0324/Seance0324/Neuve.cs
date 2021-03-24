using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0324
{
    class Neuve : Voiture
    {
        public readonly double Climatisation = -1;
        public readonly double Airbag = -1;
        public readonly double ToiOuvrant = -1;
        public readonly double Bluetooth = -1;

        public Neuve() : base() { }


        public Neuve(string im, double pxb, double c, double a, double to, double b) : base(im, pxb)
        {
            Climatisation = c;
            Airbag = a;
            ToiOuvrant = to;
            Bluetooth = b;
        }

        public override double getPrix()
        {
            double price = PrixBase;
            if (Climatisation != -1)
                price += Climatisation;
            if (Airbag != -1)
                price += Airbag;
            if (ToiOuvrant != -1)
                price += ToiOuvrant;
            if (Bluetooth != -1)
                price += Bluetooth;
            return price;
        }

        public override string ToString()
        {
            return string.Join(' ', base.ToString(), Numero, getPrix());
        }
    }
}
