using System;

namespace Seance0223
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seance Feb 23rd

            // classes and objects

            HelloWorld helloWorld = new HelloWorld();

            helloWorld.SayHello();

            helloWorld.Name = "World, from C#";

            string salutation = helloWorld.GetHelloTo();

            Console.WriteLine(salutation);

        }
    }
}
