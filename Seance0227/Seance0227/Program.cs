using System;

namespace Seance0227
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seance feb 27th

            // test of class Stagiaire
            Console.WriteLine("# Exercice 3 #\n");

            // methode C# only
            Stagiaire stg1 = new Stagiaire("Kamal", "Yahya", "TDI");
            Stagiaire stg2 = new Stagiaire("Jamal", "Youssef", "TDI");
            Stagiaire stg3 = new Stagiaire("Ilham", "Faiss", "TRI", new double[] { 12.0, 13.0, 15.0 });

            stg1.Afficher();
            stg2.Afficher();
            stg3.Afficher();

            //if (stg1.Equals(stg3))
            //{
            //    Console.WriteLine("Les Matricule de Stagiaire 1 et 2 sont egaux");
            //}
            //else
            //{
            //    Console.WriteLine("Les Matricule de Stagiaire 1 et 2 sont pas egaux");
            //}

            Console.WriteLine("La moyenne du 3eme Stagiaire est: {0}", stg3.Moyenne());
            Console.WriteLine("La moyenne du 3eme Stagiaire avec coef est: {0}", stg3.Moyenne(new int[] { 2, 3, 1 }));

            Console.WriteLine("\n-------------------------------------------------------\n");

        }
    }
}
