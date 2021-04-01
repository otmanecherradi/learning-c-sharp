using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0401
{

    class BasicTruck : BasicCar
    {
        private string loadType = "vide";

        public string LoadType { get => loadType; set => loadType = value; }
    }
}
