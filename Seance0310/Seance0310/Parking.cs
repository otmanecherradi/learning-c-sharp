using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0310
{
    class Parking
    {
        private uint nbrPlaces;

        public Voiture[] cars { get; }

        public Parking(uint nbrPlaces)
        {
            this.nbrPlaces = nbrPlaces;
            cars = new Voiture[nbrPlaces];
        }


        public void Garer(Voiture c, uint nbrPlace)
        {
            if (nbrPlace > cars.Length)
                throw new HorsParking();

            if (cars[nbrPlace] != null)
                throw new Exception("Place Non Libre");

            cars[nbrPlace] = c;
        }

        public Voiture Sortir(uint nbrPlace)
        {
            if (nbrPlace > cars.Length)
                throw new HorsParking();

            if (cars[nbrPlace] == null)
                throw new Exception("Place Libre");

            Voiture c = cars[nbrPlace];
            cars[nbrPlace] = null;
            return c;
        }

        public override string ToString()
        {
            string res = $"{GetType().Name} {{\n\tNbrPlaces = {nbrPlaces};\n\tVoitures = {{\n";
            for (int i = 0; i < cars.Length; i += 1)
            {
                res += $"\t\tPlace {{\n\t\t\tNumero {i};\n";
                Voiture c = cars[i];
                if (c == null)
                    res += $"\t\t\tVoiture = null (Place Vide);\n";
                else
                    res += $"\t\t\tVoiture = {string.Join("\t\t\t\t", c.ToString().Split("\t"))}\t\t\t}};\n";

                res += "\t\t};\n";
            }
            res += "}\n";

            return res;
        }
    }
}
