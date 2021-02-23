using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0223
{
    class HelloWorld
    {
        public string Name { get; set; }

        public string salutation = "Hello World";

        public void SayHello()
        {
            Console.WriteLine(salutation);
        }

        public string GetHelloTo()
        {
            return $"Hello {Name}";
        }
    }
}
