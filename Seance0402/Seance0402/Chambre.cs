using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0402
{
    class Chambre : IComparable<Chambre>
    {

        public int Numero { get; set; }
        public int Category { get; set; }
        public double Prix { get; set; }
        public int Capacity { get; set; }
        public char Etat { get; set; }


        public Chambre() { }

        public Chambre(int n, int c, double p)
        {
            Numero = n;
            Category = c;
            Prix = p;
        }


        public void Affiche_Chambre()
        {
            string state = Etat == 'L' ? "Libre" : "Occuper";
            Console.WriteLine($"{GetType().Name} {{\n\tNumero = {Numero};\n\tCategory = {Category};\n\tPrix = {Prix};\n\tCapacity = {Capacity};\n\tEtat = {state};\n}}\n");
        }

        public int CompareTo(Chambre other)
        {
            return Numero.CompareTo(other.Numero);
        }
    }
}
