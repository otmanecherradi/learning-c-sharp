using System;

namespace Seance0325
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seance march 25th

            // abstract classes

            Occasion o = new Occasion("A124555", 150000, 20500, 5);
            Neuve n = new Neuve("N12345", 300000, 500, 1000, -1, -1);

            Console.WriteLine(o.ToString());
            Console.WriteLine(n.ToString());

            Console.WriteLine($"Prix de la voiture Occasion: {o.getPrix()}");
            Console.WriteLine($"Prix de la voiture neuve: {n.getPrix()}");


            // 


        }
    }
}
