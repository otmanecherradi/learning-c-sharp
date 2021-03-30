using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0330
{
    interface IPoint
    {
        int x { get; set; }
        int y { get; set; }

        double distanceOrigine();
        void initialiser();
    }
}
