using System;

namespace Seance0210
{
    class Program
    {
        enum Level { Low, Medium, High }
        enum Days { Dimanche, Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi };
        enum Options { Addition, Soustraction, Multiplication, Division, Quit };

        static void Main(string[] args)
        {
            // enums to be declared out of the main scope
            Level l = Level.High;
            Console.WriteLine(l);

            // using enums with switch
            switch (l)
            {
                case Level.Low:
                    Console.WriteLine("low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("medium level");
                    break;
                case Level.High:
                    Console.WriteLine("high level");
                    break;
                default:
                    Console.WriteLine("level out of range");
                    break;
            }
            
            // ---------------------------------------------------------

            // exercice vote

            const int AGE_MARGIN = 18;

            Console.Write("entrez votre age? ");
            int userAge = int.Parse(Console.ReadLine());
            if (userAge < AGE_MARGIN)
                Console.WriteLine("t as pas le droit de voter");
            else
                Console.WriteLine("yeeeee VOTE!");


            // ------------------------------------------------------

            // exercice nbr plus grand

            Console.WriteLine("entrez 2 nbr?");
            int nbr1 = int.Parse(Console.ReadLine());
            int nbr2 = int.Parse(Console.ReadLine());

            if (nbr1>nbr2)
                Console.WriteLine("le plus grand est {0}", nbr1);
            else
                Console.WriteLine("le plus grand est {0}", nbr2);

            // ------------------------------------------------------

            // exercice etat temperature

            Console.Write("entrez la temperature? ");
            double tmp = double.Parse(Console.ReadLine());

            if(tmp < 0)
                Console.WriteLine("temps glacial");
            else if (tmp < 10)
                Console.WriteLine("tres froid");
            else if (tmp < 20)
                Console.WriteLine("temperature froide");
            else if (tmp<30)
                Console.WriteLine("temps normal");
            else if (tmp<40)
                Console.WriteLine("c est chaud");
            else
                Console.WriteLine("tres chaud, la mort");

            // ------------------------------------------------------

            // exercice equation 2eme deg

            Console.WriteLine("entrez les valeurs de:");
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("z: ");
            double z = double.Parse(Console.ReadLine());

            if (x == 0)
            {
                Console.WriteLine("equation 1er degre");

                if(y==0)
                    Console.WriteLine("pas de solution");
                else
                    Console.WriteLine("{0} est une seul solution pour l equation", -z/y);
            }
            else
            {
                double d = Math.Pow(y, 2) - 4 * x * z;
                
                if (d==0)
                    Console.WriteLine("{0} est une seul solution pour l equation", -z / (2*x));
                else if (d>0)
                {
                    Console.WriteLine("l equation accepte 2 solution dans R");
                    Console.WriteLine("1er racine est {0}", (-y - Math.Sqrt(d)) / (2 * x));
                    Console.WriteLine("2eme racine est {0}", (-y + Math.Sqrt(d)) / (2 * x));
                }
                else
                    Console.WriteLine("l'equation n'as pas de racines reels, mais 2 racines complexe");
            }

            // --------------------------------------------
            
            // exercice jour de semaine

            Console.Write("entrez le nbr de jour? ");
            Days j = (Days)int.Parse(Console.ReadLine());
            switch (j)
            {
                case Days.Dimanche:
                    Console.Write("Dimanche");
                    break;
                case Days.Lundi:
                    Console.Write("Lundi");
                    break;
                case Days.Mardi:
                    Console.Write("Mardi");
                    break;
                case Days.Mercredi:
                    Console.Write("Mercredi");
                    break;
                case Days.Jeudi:
                    Console.Write("Jeudi");
                    break;
                case Days.Vendredi:
                    Console.Write("Vendredi");
                    break;
                case Days.Samedi:
                    Console.Write("Samedi");
                    break;
                default:
                    Console.Write("pas de jour pour toi");
                    break;
            }

            // ------------------------------------------------------

            // exercice calculatrice

            Console.WriteLine("Programe Calculatrice? ...");
            Console.WriteLine("Choisissez une des options suivantes");
            Console.WriteLine("     - {0}: {1}", 0, Options.Addition);
            Console.WriteLine("     - {0}: {1}", 1, Options.Soustraction);
            Console.WriteLine("     - {0}: {1}", 2, Options.Division);
            Console.WriteLine("     - {0}: {1}", 3, Options.Multiplication);
            Console.Write("votre choix? : ");
            Options opt = (Options)int.Parse(Console.ReadLine());

            if (opt != Options.Quit)
            {
                Console.WriteLine("Entrer 2 nbr");
                Console.Write("x: ");
                double a = double.Parse(Console.ReadLine());
            
                Console.Write("y: ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Resultat");

                switch (opt)
                {
                    case Options.Addition:
                        Console.WriteLine("Addition, {0} + {1} = {2}", a, b, a + b);
                        break;
                    case Options.Soustraction:
                        Console.WriteLine("Soustraction, {0} - {1} = {2}", a, b, a - b);
                        break;
                    case Options.Division:
                        if(b == 0)
                            Console.WriteLine("division sur 0 est incorrect");
                        else
                            Console.WriteLine("Division, {0} / {1} = {2}", a, b, a / b);
                        break;
                    case Options.Multiplication:
                        Console.WriteLine("Multiplication, {0} x {1} = {2}", a, b, a * b);
                        break;
                    default:
                        Console.WriteLine("pas d'operation pour toi!");
                        break;
                }
            }
            else
                Console.WriteLine("bye");

        }

    }
}
