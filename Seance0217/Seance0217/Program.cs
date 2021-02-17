using System;

namespace Seance0217
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays

            // syntax

            int[] table = new int[5];
            table[0] = 3;
            table[1] = 4;
            table[2] = 5;
            table[3] = 7;
            table[4] = 9;

            // iterate over table with for loop
            // plain old for loop
            Console.Write("for loop");
            for (int i = 0; i < table.Length; i += 1)
            {
                Console.WriteLine("i => {0}, v => {1}", i, table[i]);
            }

            Console.WriteLine("\n-------------------------------------------------------------------\n");

            // iterate over table with foreach
            // caveat is that you don't have the index
            // to be used when the index is not a big deal
            Console.Write("foreach loop");
            foreach (int v in table)
            {
                Console.WriteLine("v => {0}", v);
            }


            Console.WriteLine("\n-------------------------------------------------------------------\n");

            Console.Write("donnez la taille du tableau > ");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            for (int i = 0; i < tab.Length; i += 1)
            {
                Console.Write("valeur de l'indice {0} > ", i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            foreach (int v in tab)
            {
                Console.WriteLine("v => {0}", v);
            }

            Console.WriteLine("\n-------------------------------------------------------------------\n");

            // multi dimensional array
            int[,] t = new int[3, 4];
            t[0, 0] = 0;
            t[2, 3] = 23;

            Console.WriteLine("nbr de case > {0}", t.Length);
            // determinates the rank of the matrics, could say the number of dimensions
            Console.WriteLine("rank > {0}", t.Rank);

            // put values in multi-dim array
            for (int i = 0; i < t.GetLength(0); i += 1)
            {
                for (int j = 0; j < t.GetLength(1); j += 1)
                {
                    t[i, j] = i * tab.GetLength(1) + j;
                }
            }

            foreach (int v in t)
            {
                Console.WriteLine("v => {0}", v);
            }

            Console.WriteLine("\n-------------------------------------------------------------------\n");

            // exercice d'application
            Console.WriteLine("# exercice d'application #");
            Console.WriteLine("enter 10 elements dans le tableau");
            int[] exapp = new int[10];
            for (int i = 0; i < exapp.Length; i += 1)
            {
                Console.Write("element {0} > ", i);
                exapp[i] = int.Parse(Console.ReadLine());
            }
            foreach (int v in exapp)
            {
                Console.WriteLine("v => {0}", v);
            }
            for (int i = exapp.Length; i < 0; i -= 1)
            {
                Console.Write("element {0} > {1}", i, exapp[i]);
            }

            Console.WriteLine("\n-------------------------------------------------------------------\n");

            // array clone
            var arr1 = exapp.Clone();
            Console.WriteLine(arr1);

            Console.WriteLine("\n-------------------------------------------------------------------\n");

            // sort array
            Array.Sort(exapp);
            Console.WriteLine(arr1);

            Console.WriteLine("\n-------------------------------------------------------------------\n");

            // Strings

            string str1 = "hello";
            string str2 = "world";

            Console.WriteLine(string.Concat(str1, ' ', str2));
            Console.WriteLine(str1 + ' ' + str2);
            
            Console.WriteLine("\n-------------------------------------------------------------------\n");

            // empty strings
            string emptyString = string.Empty;
            Console.WriteLine(str1 + emptyString + str2);

            Console.WriteLine("\n-------------------------------------------------------------------\n");

            Console.WriteLine(str1.Equals(str2));

            Console.WriteLine("\n-------------------------------------------------------------------\n");

            Console.WriteLine(string.IsNullOrEmpty(str1));
            Console.WriteLine(string.IsNullOrWhiteSpace(string.Empty));

        }
    }
}
