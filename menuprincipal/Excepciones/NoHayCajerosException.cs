using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuPrincipal.Excepciones
{
    class NoHayCajerosException : Exception
    {
        public string mensaje;
        public NoHayCajerosException(string m)
        {
            mensaje = m;
        }
    }
}
