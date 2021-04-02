using System;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

using System.Collections.Generic;


namespace Seance0402
{

    enum MenuChoice
    {
        Quit,
        AddChamber,
        ListChamberOfCategory,
        ReserveChamber,
        ListChambers,
        ListChambersSortedByCapacity,
    }


    class Program
    {
        static TChambre g;

        static void Main(string[] args)
        {
            // Seance April 2nd;

            // Serialization

            // Serialization is meant to allow us to store an object in database or memory or even XML file

            // used with the [Serializable] annotation and for those that we do not want to serialize, we annotate them with [NonSerialized]

            // example, Refer to Video Class

            Video v = new Video(1, "titre1", "description1", DateTime.Now);

            Console.WriteLine(v);

            Video.Serialize("v", v);

            Console.WriteLine(Video.Deserialize("v"));


            Etudiant e1 = new Etudiant(1, "Kamal", "Yahya");

            Console.WriteLine(e1);

            Stream fs = File.Create("etud.dat");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, e1);
            fs.Close();

            fs = File.OpenRead("etud.dat");
            bf = new BinaryFormatter();
            e1 = (Etudiant)bf.Deserialize(fs);
            fs.Close();

            Console.WriteLine(e1);

            Console.WriteLine("\n-------------------------------------------------------\n");

            // test of class Chambre, TChambre
            Console.WriteLine("# Exam - Gestion Hotel #\n");
            g = new TChambre();

            MenuChoice menuChoice;
            do
            {
                ShowMenu();
                menuChoice = GetChoice();

                switch (menuChoice)
                {
                    case MenuChoice.AddChamber:
                        Saisie_Chambre();
                        break;
                    case MenuChoice.ListChamberOfCategory:
                        Console.Write("Inserter la Categorie des chambres ::> ");
                        int ctg = int.Parse(Console.ReadLine());
                        ListChamberOfCategory(ctg);
                        break;
                    case MenuChoice.ReserveChamber:
                        Console.Write("Inserter le Numero du chambre ::> ");
                        int num = int.Parse(Console.ReadLine());
                        ReserveChamber(num);
                        break;
                    case MenuChoice.ListChambers:
                        foreach (Chambre c in g.ListChambre)
                            c.Affiche_Chambre();
                        break;
                    case MenuChoice.ListChambersSortedByCapacity:
                        foreach (Chambre c in ListChambersSortedByCapacity())
                            c.Affiche_Chambre();
                        break;
                }
            } while (menuChoice != MenuChoice.Quit);

            Console.WriteLine("Good Bye!");

        }


        static void Saisie_Chambre()
        {
            Console.WriteLine("------ Saisir Un Chambre ------");

            Console.Write("Inserter le Numero du chambre ::> ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Inserter le Category du chambre ::> ");
            int ctg = int.Parse(Console.ReadLine());

            double prx;
            do
            {
                Console.Write("Inserter le Prix du chambre ::> ");
                prx = double.Parse(Console.ReadLine());
                if (prx < 0)
                    Console.WriteLine("Prix doit etre sup à 0");
            } while (prx < 0);

            int cpt;
            do
            {
                Console.Write("Inserter la Capacite du chambre ::> ");
                cpt = int.Parse(Console.ReadLine());
                if (cpt < 1 || cpt > 4)
                    Console.WriteLine("Capacite doit etre sup ou egal a 1 et inf ou egal a 4");
            } while (cpt < 1 || cpt > 4);

            Chambre c = new Chambre(num, ctg, prx)
            {
                Capacity = cpt,
                Etat = 'L'
            };

            g.Create(c);

            Console.WriteLine("Chambre ajoute avec succe");
        }

        static void ListChamberOfCategory(int ctg) => g.ListChamberOfCategory(ctg);

        static void ReserveChamber(int num)
        {
            if (g.ReserveChamber(num))
                Console.WriteLine("Chambre reserver avec succe");
            else
                Console.WriteLine("Chambre non reserver");
        }

        static List<Chambre> ListChambersSortedByCapacity() => g.ListChambersSortedByCapacity();

        static void ShowMenu()
        {
            Console.WriteLine("****** Gestion d'un Hotel ******");
            Console.WriteLine("- {0} => Ajouter un Chambre.", (int)MenuChoice.AddChamber);
            Console.WriteLine("- {0} => Lister les Chambres d'une category.", (int)MenuChoice.ListChamberOfCategory);
            Console.WriteLine("- {0} => Reserver un Chambre.", (int)MenuChoice.ReserveChamber);
            Console.WriteLine("- {0} => Lister tout les Chambres.", (int)MenuChoice.ListChambers);
            Console.WriteLine("- {0} => Lister tout les Chambres (Tri croissant des capacites).", (int)MenuChoice.ListChambersSortedByCapacity);
            Console.WriteLine("- {0} => Quitter.", (int)MenuChoice.Quit);
        }

        static MenuChoice GetChoice()
        {
            Console.Write("Faites votre choix ::> ");
            int choice = int.Parse(Console.ReadLine());
            return (MenuChoice)choice;
        }
    }
}
