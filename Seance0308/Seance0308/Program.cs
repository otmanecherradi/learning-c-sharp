using System;
using System.Collections.Generic;

namespace Seance0308
{
    enum MenuChoice
    {
        Quit,
        AddBus,
        AddVoyage,
        ListAllVoyage,
        ListAllVoyageBetweenTwoDates,
        NbrVoyageCurrentYear,
    }

    class Program
    {

        static List<Chauffeur> chauffeurs = new List<Chauffeur>();
        static List<Bus> buses = new List<Bus>();
        static List<Voyage> voyages = new List<Voyage>();

        static void Main(string[] args)
        {
            // Seance march 8th

            // Lists:
            // Lists are like ArrayList, with the difference being typed,
            // means you can only add to the list element that are of the same type.

            // Example
            // Declare a List
            List<int> intList = new List<int>();

            // All methods in ArrayList can be found here in List
            for (int i = 0; i < 10; i += 1)
            {
                // print the capacity, the count and the element (visual infos each time we add)
                Console.WriteLine("adding element {0}, current count {1}, current capacity {2}", i, intList.Count, intList.Capacity);
                // adding an integer each time
                intList.Add(i);
            }
            // printing the list into the console
            foreach (int i in intList)
            {
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine("\n-------------------------------------------------------\n");

            // test of class Abonne, Repertoire
            Console.WriteLine("# TP-8 #\n");

            Abonne a1 = new Abonne("name2", "+212666666666");
            Abonne a2 = new Abonne("name1", "+212666666661");

            Repertoire r = new Repertoire(3);

            if (r.AddAbonne(a1))
                Console.WriteLine("Abonne ajouter avec succes");
            else
                Console.WriteLine("Repertoire est a capacite");

            if (r.AddAbonne(a2))
                Console.WriteLine("Abonne ajouter avec succes");
            else
                Console.WriteLine("Repertoire est a capacite");

            r.Affichier();

            if (r.GetNumero(a1.Nom) != "")
                Console.WriteLine("{0} => {1}", a1.Nom, r.GetNumero(a1.Nom));
            else
                Console.WriteLine("Abonne ne se trouve pas");

            Console.WriteLine("il existe {0} Abonnes dans la repertoire", r.GetNombreAbonnes());

            foreach (Abonne abonne in r.GetAbonnesTries())
                Console.WriteLine("{0} => {1}", abonne.Nom, abonne.PhoneNumber);


            Console.WriteLine("\n-------------------------------------------------------\n");

            // test of class Chauffeur, Bus et Voyages
            Console.WriteLine("# Exam 2012 #\n");

            showMenu();
            MenuChoice menuChoice = GetChoice();
            while (menuChoice != MenuChoice.Quit)
            {

                switch (menuChoice)
                {
                    case MenuChoice.AddBus:
                        AddBus();
                        break;
                    case MenuChoice.AddVoyage:
                        AddVoyage();
                        break;
                    case MenuChoice.ListAllVoyage:
                        ListAllVoyages();
                        break;
                    case MenuChoice.ListAllVoyageBetweenTwoDates:
                        foreach (var v in ListAllVoyageBetweenTwoDates())
                            Console.WriteLine(v.ToString());
                        break;
                    case MenuChoice.NbrVoyageCurrentYear:
                        Console.WriteLine("Nbr de voyages dans l'annees en cours est {0}.", NbrVoyageCurrentYear());
                        break;
                }

                showMenu();
                menuChoice = GetChoice();
            }

            Console.WriteLine("Good Bye!");
        }

        static List<Voyage> ListAllVoyageBetweenTwoDates()
        {
            Console.WriteLine("Liste des voyages passe dans deux dates :");
            Console.Write("Date 1 ::> ");
            DateTime dt1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Date 2 ::> ");
            DateTime dt2 = DateTime.Parse(Console.ReadLine());
            return voyages.FindAll((v) => v.VDate > dt1 && v.VDate < dt2);
        }
        static int NbrVoyageCurrentYear()
        {
            Console.WriteLine("Nombre des voyages de l'annees en cours :");
            int n = 0;
            foreach (Voyage v in voyages)
                if (v.VDate.Year.Equals(DateTime.Today.Year))
                    n += 1;
            return n;
        }
        static void ListAllVoyages()
        {
            foreach (var v in voyages)
                Console.WriteLine(v.ToString());
        }
        static void AddBus()
        {
            Console.WriteLine("Ajouter un bus:");
            Console.Write("Immatriculation ::> ");
            string im = Console.ReadLine();
            Console.Write("Marque ::> ");
            string mk = Console.ReadLine();
            Console.Write("Type ::> ");
            string ty = Console.ReadLine();
            buses.Add(new Bus(im, mk, ty));
        }
        static void AddVoyage()
        {
            Console.WriteLine("Ajouter un bus:");
            Console.Write("CIN Chauffeur ::> ");
            string cin = Console.ReadLine();
            var c = RechercheChauffeur(cin);
            if (c == null)
            {
                Console.WriteLine("Chauffeur Introuvable");
                return;
            }
            Console.Write("Immatriculation Bus ::> ");
            string imm = Console.ReadLine();
            var b = RechercheBus(imm);
            if (b == null)
            {
                Console.WriteLine("Bus Introuvable");
                return;
            }
            Console.Write("Ville Depart ::> ");
            string vd = Console.ReadLine();
            Console.Write("Ville Arrive ::> ");
            string va = Console.ReadLine();
            Console.Write("Nbr Voyageurs ::> ");
            int vs = int.Parse(Console.ReadLine());
            Console.Write("Prix Billet ::> ");
            double pb = double.Parse(Console.ReadLine());
            voyages.Add(new Voyage(c, b, vd, va, vs, pb));
        }
        static dynamic RechercheChauffeur(string cin)
        {
            foreach (Chauffeur chauffeur in chauffeurs)
            {
                if (chauffeur.CIN.Equals(cin))
                {
                    return chauffeur;
                }
            }

            return null;
        }
        static dynamic RechercheBus(string imm)
        {
            foreach (Bus bus in buses)
            {
                if (bus.Immatriculation.Equals(imm))
                {
                    return bus;
                }
            }

            return null;
        }
        static int RechercheVoyage(int nbr)
        {
            int idx = -1;

            for (int i = 0; i < voyages.Count; i += 1)
            {
                if (voyages[i].NbrVoyage.Equals(nbr))
                    idx = i;
            }

            return idx;
        }

        static void showMenu()
        {
            Console.WriteLine("**** Gestion Voyages Organises ****");
            Console.WriteLine("- {0} => Ajouter un bus.", (int)MenuChoice.AddBus);
            Console.WriteLine("- {0} => Ajouter un voyage.", (int)MenuChoice.AddVoyage);
            Console.WriteLine("- {0} => Lister tous les voyages.", (int)MenuChoice.ListAllVoyage);
            Console.WriteLine("- {0} => Lister les voyages passe dans deux dates.", (int)MenuChoice.ListAllVoyageBetweenTwoDates);
            Console.WriteLine("- {0} => Nombre des voyages de l'annees en cours.", (int)MenuChoice.NbrVoyageCurrentYear);
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
