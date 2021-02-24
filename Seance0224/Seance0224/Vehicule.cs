using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0224
{
    class Vehicule
    {
        public string Marque;
        public int Puissance;
        public int VitesseMax;
        public int VitesseCour;

        public Vehicule() { }

        public Vehicule(string m, int p, int vm, int vc) {
            Marque = m;
            Puissance = p;
            VitesseMax = vm;
            VitesseCour = vc;
        }

        public Vehicule(Vehicule v)
        {
            Marque = v.Marque;
            Puissance = v.Puissance;
            VitesseMax = v.VitesseMax;
            VitesseCour = v.VitesseCour;
        }

        public void Accelerer(int v)
        {
            VitesseCour += v;
            if (VitesseCour > VitesseMax)
                VitesseCour = VitesseMax;
        }

        public override string ToString()
        {
            return $"Vehicule {{ Marque = {Marque}; Puissance = {Puissance}; VitesseMax = {VitesseMax}; VitesseCour = {VitesseCour}}}";
        }

    }
}
