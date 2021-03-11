using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0311
{
    class Chambre
    {
        //private int r;
        //public int R { get => r; set => r = value; }
        // use it as a shortcut for getter and setter

        private int numero;
        public int Numero { get => numero; set => numero = value; }

        private int category;
        public int Category { get => category; set => category = value; }

        private double prix;
        public double Prix { get => prix; set => prix = value; }

        private int capacity;
        public int Capacity { get => capacity; set => capacity = value; }

        private char etat;
        public char Etat { get => etat; set => etat = value; }


        public Chambre() { }

        public Chambre(int n, int c, double p)
        {
            numero = n;
            category = c;
            prix = p;
        }


        public void Affiche_Chambre()
        {
            string state = Etat == 'L' ? "Libre" : "Occuper";
            Console.WriteLine($"{GetType().Name} {{\n\tNumero = {Numero};\n\tCategory = {Category};\n\tPrix = {Prix};\n\tCapacity = {Capacity};\n\tEtat = {state};\n}}\n");
        }
    }
}
