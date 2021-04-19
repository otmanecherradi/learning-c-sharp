using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Seance0419
{
    class Country
    {
        public Image Flag { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Language { get; set; }

        public Country() { }

        public Country(Image flag, string name, string capital, string language)
        {
            Flag = flag;
            Name = name;
            Capital = capital;
            Language = language;
        }
    }
}
