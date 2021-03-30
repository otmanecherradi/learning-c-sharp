using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0330
{
    class TestTwoInterfaces : IInterfaceOne, IInterfaceTwo
    {
        void IInterfaceOne.paint()
        {
            Console.WriteLine("Console.WriteLine");
        }

        void IInterfaceTwo.paint()
        {
            Console.WriteLine("Console.WriteLine");
        }
    }
}
