using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0310
{

    public class SexeException : Exception
    {
        public SexeException() : base("Sexe doit etre 'M' ou bien 'F'") { }
    }
}
