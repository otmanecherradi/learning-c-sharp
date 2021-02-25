using System;

namespace Seance0225
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seance feb 25th, in class


            //Console.WriteLine("\n-------------------------------------------------------\n");

            // test of class Produit
            Console.WriteLine("# Exercice 4 #\n");

            Produit p1 = new Produit(111, "imprimante", 700, DateTime.Parse("12/12/2016"));
            Produit p2 = new Produit();

            Console.Write("Enter the code of the product > ");
            p2.Code = int.Parse(Console.ReadLine());
            Console.Write("Enter the description of the product > ");
            p2.Description = Console.ReadLine();
            Console.Write("Enter the prixHT of the product > ");
            p2.PrixHT = double.Parse(Console.ReadLine());

            p1.Afficher();
            p2.Afficher();

            Console.WriteLine("the comparaison of the products:");
            switch (p1.ComparerPrix(p2))
            {
                case 0:
                    Console.WriteLine("egaux");
                    break;
                case -1:
                    Console.WriteLine("{0} sup", p2.Description);
                    break;
                case 1:
                    Console.WriteLine("{0} sup", p1.Description);
                    break;
            }




        }
    }
}
