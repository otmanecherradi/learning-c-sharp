using System;

namespace Seance0224
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seance Feb 24th

            Console.WriteLine("# Exercice 2 #\n");

            Vehicule[] vcs = new Vehicule[2];

            vcs[0] = new Vehicule("Audi", 700, 310, 0);
            vcs[1] = new Vehicule("Bugatti", 1001, 450, 0);

            // assign an objet to another one
            Vehicule vv;
            vv = vcs[0];
            Console.WriteLine(vv.ToString());

            foreach (Vehicule v in vcs)
            {
                Console.WriteLine(v.ToString());
            }

            vcs[0].Accelerer(10);
            vcs[1].Accelerer(300);


            foreach (Vehicule v in vcs)
            {
                Console.WriteLine(v.ToString());
            }

            Console.WriteLine("\n-------------------------------------------------------\n");

            // test of class Stagiaire
            Console.WriteLine("# Exercice 3 #\n");

            // methode C# only
            Stagiaire stg1 = new Stagiaire("Kamal", "Yahya", "TDI")
            {
                Matricule = 1
            };
            Stagiaire stg2 = new Stagiaire("Jamal", "Youssef", "TDI");
            stg2.Matricule = 2;
            Stagiaire stg3 = new Stagiaire(3, "Ilham", "Faiss", "TRI", 12, 13, 15);

            stg1.Affiche();
            stg2.Affiche();
            stg3.Affiche();

            if (stg1.Equals(stg3))
            {
                Console.WriteLine("Les Matricule de Stagiaire 1 et 2 sont egaux");
            }
            else
            {
                Console.WriteLine("Les Matricule de Stagiaire 1 et 2 sont pas egaux");
            }

            Console.WriteLine("La moyenne du 3eme Stagiaire est: {0}", stg3.Moyenne());

            Console.WriteLine("\n-------------------------------------------------------\n");

            // test of class Produit
            Console.WriteLine("# Exercice 4 #\n");

        }
    }
}
