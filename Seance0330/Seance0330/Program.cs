using System;
using System.Collections.Generic;

namespace Seance0330
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seance march 30th

            // solution for the 2012 exam
            // may be fount in correspondents classes: Cleint, Compte, CompteCarnet, CompateCourant

            // Interfaces in C#

            Point p = new Point(10, 5);
            Console.WriteLine(p.distanceOrigine());
            Console.WriteLine("x => {0}", p.x);
            Console.WriteLine("y => {0}", p.y);

            p.initialiser();
            Console.WriteLine("x => {0}", p.x);
            Console.WriteLine("y => {0}", p.y);

            Chien chien = new Chien();
            Chat chat = new Chat();

            chien.cri();
            chat.cri();


            List<Employer> eps = new List<Employer>();

            eps.Add(new Employer() { Nom = "Kamal", Salaire = 10000 });
            eps.Add(new Employer() { Nom = "Chaima", Salaire = 13000 });
            eps.Add(new Employer() { Nom = "Ali", Salaire = 5000 });
            eps.Add(new Employer() { Nom = "Said", Salaire = 10000 });
            eps.Add(new Employer() { Nom = "Yahya", Salaire = 5000 });

            foreach (Employer e in eps)
            {
                Console.WriteLine("{0} => {1}", e.Nom, e.Salaire);
            }

            eps.Sort();

            foreach (Employer e in eps)
            {
                Console.WriteLine("{0} => {1}", e.Nom, e.Salaire);
            }


        }
    }
}
