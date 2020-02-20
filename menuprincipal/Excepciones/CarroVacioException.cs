using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuPrincipal.Excepciones
{
    class CarroVacioException : Exception
    {
        public string mensaje;
        public CarroVacioException(string m)
        {
            mensaje = m;
        }
    }
}
