using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0309
{
    class Bus
    {
        private string immatriculation;
        public string Immatriculation
        {
            get { return immatriculation; }
            set { immatriculation = value; }
        }

        private string marque;
        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public Bus() { }

        public Bus(string i, string m, string t)
        {
            Immatriculation = i;
            Marque = m;
            Type = t;
        }

        public override string ToString()
        {
            //return $"{GetType().Name} {{\n\tImmatriculation = {Immatriculation};\n\tMarque = {Marque};\n\tType = {Type};\n}}\n";
            return $"{Immatriculation}\t{Marque}\t{Type}";
        }
    }
}
