using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuPrincipal.Excepciones
{
    class CajaAbiertaException : Exception
    {
        public int opc;
        public CajaAbiertaException(int opc)
        {
            this.opc = opc;
        }
    }
}
