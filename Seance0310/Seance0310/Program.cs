using System;

namespace Seance0310
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seance march 10th

            // Exception

            // to handle exception errors, we use a try catch method so that we can catch errors

            // simple example

            try // <-- we try the current block
            {
                // current block
                int y = 0;
                Console.WriteLine("div 1 over 0 => {0}", 1 / y);
            }
            catch (DivideByZeroException e) // <-- catching the system defined exception named DivideByZeroException
            {
                // execute this only if the operation block throws an exception
                Console.WriteLine(e.Message);
            }
            //catch () { } // <-- we can follow it up with multiple catch blocks to handle each exception occured when executing the program
            finally // <-- this block will execute in either situations, mainly used for cleanup
            {
                Console.WriteLine("Finally here.");
            }


            Console.WriteLine("\n--------------------------------------------------------------------------\n");

            Console.WriteLine("\n# TP Exception #\n");

            Parking p = new Parking(12);
            p.Garer(new Voiture("Nom", "Mercedes", "Sedan", 123), 2);

            Console.WriteLine(p.ToString());
        }
    }
}
