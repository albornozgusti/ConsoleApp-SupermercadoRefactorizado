using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuPrincipal.Excepciones
{
    class DatoInvalidoException :Exception
    {
        public string mensaje;
        public DatoInvalidoException(string m)
        {
            mensaje = m;
        }
    }
}
