using System;
using System.Collections;

namespace Seance0303
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seance march 3rd

            //test of Article, Habit and Electromenager class

            Habit h = new Habit(1, 12.3, 1234, 113, 14, "black");

            Console.WriteLine(h.ToString());
            h.Sapprovisionner(24);
            Console.WriteLine(h.ToString());

            Electromenager e = new Electromenager(1, 12.3, 1234, 113, 14, 24);

            Console.WriteLine("Date de fin de garantie est: {0:G}", e.DateFinGarantie());

            Console.WriteLine(e.ToString());
            e.Achat(243);
            Console.WriteLine(e.ToString());

            Console.WriteLine("\n---------------------------------------------------------------\n");

            // Collection

            // ArrayList,

            // we can specify the capacity of the array, or just skip it, though this capacity is not strict, we can add to the array as many objects as we want
            ArrayList arrayList = new ArrayList(2);

            arrayList.Add(3);
            arrayList.Add("rrrr");

            // produces error
            //arrayList.Insert(3, 2);

            // loop over it
            foreach (var z in arrayList)
            {
                Console.WriteLine(z);
            }
            

        }
    }
}

