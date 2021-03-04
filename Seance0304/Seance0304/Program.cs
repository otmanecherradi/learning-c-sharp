using System;

namespace Seance0304
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seance march 4rt

            // testing for CD and GestionCDs classes

            CD cd1 = new CD(1, "title 1", Genres.Rock, DateTime.Now, "author 1");
            CD cd2 = new CD(2, "title 2", Genres.Pop, DateTime.Now, "author 2");

            GestionCDs gs = new GestionCDs();

            CD[] cds = { cd1, cd2 };

            foreach (CD cd in cds)
                if (gs.AjouterCD(cd))
                    Console.WriteLine($"CD {cd.Titre} est ajoute avec succe");
                else
                    Console.WriteLine($"CD {cd.Titre} existe deja");

            gs.AffichierCDs();

            Console.WriteLine("\n---------------------------------------------------------------\n");

        }
    }
}
