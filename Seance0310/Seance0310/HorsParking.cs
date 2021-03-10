using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0310
{
    public class HorsParking : Exception
    {
        public HorsParking() { }
        public HorsParking(string message) : base(message) { }
    }
}
