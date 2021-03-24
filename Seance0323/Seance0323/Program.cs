using System;
using System.Collections.Generic;
using System.IO;

namespace Seance0323
{
    enum MenuChoice
    {
        Quit,
        AddAbonne,
        ListAllAbonnes,
        SearchAbonneByName,
        SearchAbonneByPhoneNumber,
        ModifyPhoneNumberOfAbonne,
        DeleteAbonne,
        SortAbonnes,
        SaveAbonnesToFile,
        ListAllAbonnesFromFile,
        SerializeAbonne,
        DeserializeAbonne,
    }

    class Program
    {

        static List<Personne> personnes = new List<Personne>();

        static Repertoire r;

        static void Main(string[] args)
        {
            // Seance march 23rd

            //File handling

            string fileName = "test1.txt";
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            Console.WriteLine($"file {fs.Name} was created successfully");

            StreamWriter sw = new StreamWriter(fs); // Write to the file
            sw.WriteLine("Hellooooooooooooooooooo");

            StreamReader sr = new StreamReader(fs); // Reads from the file
            while (sr.Peek() != -1)
            {
                Console.WriteLine(sr.ReadLine());
            }

            fs.Close(); // always close the stream when you are done with it

            // Exercice d'application

            Console.WriteLine("\n---------------------------------------------------------------\n");

            //test of Personne classe

            Personne p1 = new Personne("Kamal", "Mohammed");
            Personne p2 = new Personne("Lahlou", "Samir");
            Personne p3 = new Personne("Holmes", "Sherlcok");

            AjouterPersonne(p1);
            AjouterPersonne(p2);
            AjouterPersonne(p3);

            AjouterFichier();

            string path = Path.Combine(Environment.CurrentDirectory, "some.txt"); // get a path of a file

            var p = @"c:\\d.txt"; // var modifier to assign default type to variable

            Console.WriteLine("\n---------------------------------------------------------------\n");

            // test of class Abonne, Repertoire
            Console.WriteLine("# TP-8 (suite) #\n");

            Console.WriteLine("Donnez le nombre d'abonnes par repertoire :");
            Console.Write("Nombre ::> ");

            int cap = int.Parse(Console.ReadLine());
            r = new Repertoire(cap);

            showMenu();
            MenuChoice menuChoice = GetChoice();
            while (menuChoice != MenuChoice.Quit)
            {

                switch (menuChoice)
                {
                    case MenuChoice.AddAbonne:
                        AddAbonne();
                        break;
                    case MenuChoice.ListAllAbonnes:
                        ListAllAbonnes();
                        break;
                    case MenuChoice.SearchAbonneByName:
                        SearchAbonneByName();
                        break;
                    case MenuChoice.SearchAbonneByPhoneNumber:
                        SearchAbonneByPhoneNumber();
                        break;
                    case MenuChoice.ModifyPhoneNumberOfAbonne:
                        ModifyPhoneNumberOfAbonne();
                        break;
                    case MenuChoice.DeleteAbonne:
                        DeleteAbonne();
                        break;
                    case MenuChoice.SortAbonnes:
                        SortAbonnes();
                        break;
                    case MenuChoice.SaveAbonnesToFile:
                        SaveAbonnesToFile();
                        break;
                    case MenuChoice.ListAllAbonnesFromFile:
                        ListAllAbonnesFromFile();
                        break;
                    case MenuChoice.SerializeAbonne:
                        SerializeAbonne();
                        break;
                    case MenuChoice.DeserializeAbonne:
                        DeserializeAbonne();
                        break;
                }

                showMenu();
                menuChoice = GetChoice();
            }

            Console.WriteLine("Good Bye!");
        }

        private static void DeserializeAbonne()
        {
            // to be implemented
            Console.WriteLine("NotImplementedYet");
        }

        private static void SerializeAbonne()
        {
            // to be implemented
            Console.WriteLine("NotImplementedYet");
        }

        private static void ListAllAbonnesFromFile()
        {
            Console.WriteLine("Lister les abonnes depuis un fichier :");
            using StreamReader sr = new StreamReader("repertoire.txt");
            while(sr.Peek() != -1)
            {
                var l = sr.ReadLine().Split(';');
                Console.WriteLine("{0} => {1}", l[0], l[1]);
            }
        }

        private static void SaveAbonnesToFile()
        {
            Console.WriteLine("Enregistrer les abonnes dans un fichier :");
            using StreamWriter sw = new StreamWriter("repertoire.txt", true);
            foreach (Abonne a in r.Abonnes)
                sw.WriteLine(string.Join(';', a.Nom, a.PhoneNumber));
            Console.WriteLine("Les abonnes sont enregistrer dans un fichier avec succes");
        }

        private static void SortAbonnes()
        {
            Console.WriteLine("Lister les abonnes :");
            foreach (Abonne abonne in r.GetAbonnesTries())
                Console.WriteLine("{0} => {1}", abonne.Nom, abonne.PhoneNumber);
        }

        private static void DeleteAbonne()
        {
            Console.WriteLine("Suprimmer abonne :");
            Console.Write("Nom ::> ");
            string n = Console.ReadLine();
            Abonne a = r.SearchByName(n);
            if (a == null)
                Console.WriteLine("Abonne ne se trouve pas");
            else
            {
                r.Delete(a);
                Console.WriteLine("Abonne supprimer avec succes");
            }
        }

        private static void ModifyPhoneNumberOfAbonne()
        {
            Console.WriteLine("Rechercher abonne :");
            Console.Write("Nom ::> ");
            string n = Console.ReadLine();
            Abonne a = r.SearchByName(n);
            if (a == null)
                Console.WriteLine("Abonne ne se trouve pas");
            else
            {
                Console.Write("Nouveau nombre de telephone ::> ");
                string nbr = Console.ReadLine();
                a.PhoneNumber = nbr;
                Console.WriteLine("Abonne modifier avec succes");
            }
        }

        private static void SearchAbonneByPhoneNumber()
        {
            Console.WriteLine("Rechercher abonne :");
            Console.Write("Nombre de telephone ::> ");
            string n = Console.ReadLine();
            Abonne a = r.SearchByPhoneNumber(n);
            if (a == null)
                Console.WriteLine("Abonne ne se trouve pas");
            else
                Console.WriteLine("{0} => {1}", n, a);
        }

        private static void SearchAbonneByName()
        {
            Console.WriteLine("Rechercher abonne :");
            Console.Write("Nom ::> ");
            string n = Console.ReadLine();
            Abonne a = r.SearchByName(n);
            if (a == null)
                Console.WriteLine("Abonne ne se trouve pas");
            else
                Console.WriteLine("{0} => {1}", n, a);
        }

        private static void ListAllAbonnes()
        {
            Console.WriteLine("Lister les abonnes :");
            r.Affichier();
        }

        private static void AddAbonne()
        {
            Console.WriteLine("Ajouter un nouveau abonne :");
            Console.Write("Nom ::> ");
            string n = Console.ReadLine();
            Console.Write("Numero de telephone ::> ");
            string t = Console.ReadLine();
            if (r.AddAbonne(new Abonne(n, t)))
                Console.WriteLine("Abonne ajouter avec succes");
            else
                Console.WriteLine("Repertoire est pleine");
        }

        static void showMenu()
        {
            Console.WriteLine("**** Gestion Repertoire des Abonnes ****");
            Console.WriteLine("- {0} => Ajouter un abonne.", (int)MenuChoice.AddAbonne);
            Console.WriteLine("- {0} => Lister tout les abonnes.", (int)MenuChoice.ListAllAbonnes);
            Console.WriteLine("- {0} => Rechercher par nom.", (int)MenuChoice.SearchAbonneByName);
            Console.WriteLine("- {0} => Rechercher par numero de telephone.", (int)MenuChoice.SearchAbonneByPhoneNumber);
            Console.WriteLine("- {0} => Modifier numero de telephone.", (int)MenuChoice.ModifyPhoneNumberOfAbonne);
            Console.WriteLine("- {0} => Suprimmer un abonne.", (int)MenuChoice.DeleteAbonne);
            Console.WriteLine("- {0} => Trier les abonnes.", (int)MenuChoice.SortAbonnes);
            Console.WriteLine("- {0} => Enregister les abonnes dans un fichier.", (int)MenuChoice.SaveAbonnesToFile);
            Console.WriteLine("- {0} => Lister les abonnes depuis un fichier.", (int)MenuChoice.ListAllAbonnesFromFile);
            Console.WriteLine("- {0} => Serailiser un abonne.", (int)MenuChoice.SerializeAbonne);
            Console.WriteLine("- {0} => Deserialiser un abonne.", (int)MenuChoice.DeserializeAbonne);
            Console.WriteLine("- {0} => Quitter.", (int)MenuChoice.Quit);
        }

        static MenuChoice GetChoice()
        {
            Console.Write("Faites votre choix ::> ");
            int choice = int.Parse(Console.ReadLine());
            return (MenuChoice)choice;
        }

        static void AjouterPersonne(Personne p)
        {
            personnes.Add(p);
        }

        static void AjouterFichier()
        {
            StreamWriter sw = new StreamWriter("personnes.txt");

            foreach (Personne p in personnes)
            {
                sw.WriteLine(string.Join(',', p.Nom, p.Prenom));
            }

            sw.Close();
        }

    }
}
