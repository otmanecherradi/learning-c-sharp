using System;

namespace Seance0211
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loops / Boucle
            
            // for loop

            // syntax
            for (int i = 0; i < 5; i += 1)
            {
                Console.WriteLine(i);
            }


            // incrementation
            for (int i = 0; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }

            // break
            for (int i = 0; i < 10; i += 1)
            {
                if (i == 4)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            // continue
            for (int i = 0; i < 10; i += 1)
            {
                if (i==4)
                {
                    continue;
                }

                Console.WriteLine(i);
            }


            /*
            // boucle infinie/ A NE PAS FAIRE
            for (; ;)
            {
                Console.WriteLine("boucle infinie");
            }
            */

            // while loop
            int i = 0;
            // condition d'arret est indisponsable
            while (i<5)
            {
                Console.WriteLine(i);
                i += 1;
            }

            // Do While
            i = 0;
            do
            {
                Console.WriteLine(i);
                i += 1;
            } while (i<5);

            // to be continued 
            

            // TP
            
            // -------------------------------------------------------------------

            // exercice 3.1
            Console.WriteLine("\n# exercice 3.1 #\n");
            for (int i = 0; i < 10; i += 1)
            {
                Console.WriteLine(i+1);
            }

            Console.WriteLine("-------------------------------------------------------------------");
            
            // exercice 3.2
            Console.WriteLine("\n# exercice 3.2 #\n");
            int s = 0;
            for (int i = 0; i < 10; i += 1)
            {
                s += i + 1;
            }
            Console.WriteLine("la somme des 10 premiers naturel nbr est: {0}", s);

            Console.WriteLine("-------------------------------------------------------------------");

            // exercice 3.3
            Console.WriteLine("\n# exercice 3.3 #\n");
            Console.Write("enter un nbr? > ");
            int l = int.Parse(Console.ReadLine());
            s = 1;
            Console.Write("1");
            for (int i = 2; i <= l; i += 1)
            {
                Console.Write(" + {0}", i);
                s += i;
            }
            Console.WriteLine(" = {0}", s);

            Console.WriteLine("-------------------------------------------------------------------");

            // exercice 3.4
            Console.WriteLine("\n# exercice 3.4 #\n");
            Console.Write("enter un nbr? > ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i += 1)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }

            Console.WriteLine("-------------------------------------------------------------------");

            // exercice 3.5
            Console.WriteLine("\n# exercice 3.5 #\n");
            for (int i = 0; i <= 4; i += 1)
            {
                int a = 0;
                while (a < i)
                {
                    Console.Write("* ");
                    a += 1;
                }
                Console.Write("\n");
            }

            Console.WriteLine("-------------------------------------------------------------------");

            // exercice sup
            Console.WriteLine("\n# exercice sup #\n");
            for (int i = 1; i < 9; i += 1)
            {
                if(i < 5)
                {
                    for (int j = 0; j < 4; j += 1)
                        Console.Write(' ');
                    for (int j = 0; j < i; j += 1)
                        Console.Write('*');
                    Console.Write("\n");
                }
                else
                {
                    for (int j = 1; j < i - 4; j += 1)
                        Console.Write(' ');
                    for (int j = i; j < 9; j += 1)
                        Console.Write('*');
                    Console.Write("\n");
                }


                
            }

        }
    }
}
