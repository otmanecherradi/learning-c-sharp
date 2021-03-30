using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0330
{
    class Point : IPoint
    {
        public int x { get; set; }
        public int y { get; set; }

        
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public double distanceOrigine()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public void initialiser()
        {
            x = 0;
            y = 0;
        }
    }
}
