using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0310
{

    [Serializable]
    public class NomException : Exception
    {
        public NomException() : base("Nom doit contenir plus de 3 caracteres") { }
    }
}
