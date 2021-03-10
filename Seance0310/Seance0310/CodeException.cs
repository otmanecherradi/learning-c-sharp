using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0310
{
    public class CodeException : Exception
    {
        public CodeException() : base("Code ne doit etre negatif") { }
    }
}
