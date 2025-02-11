using System;
using System.Collections.Generic;
using System.Text;

namespace TiposReferenciaTiposValor
{
    // Nossa classe do tipo Structs ou tipo valor
    struct Point
    {
        public double X, Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
