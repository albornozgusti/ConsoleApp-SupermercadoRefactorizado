using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuPrincipal.Excepciones
{
    class ProductoInexistenteException : Exception
    {
        //UNA CLASE EXCEPCION DEBERIA CONTENER ESTOS 3 CONSTRUCTORES
        //DEBERIAN HEREDAR DE ApplicationException
        public ProductoInexistenteException() :base()
        {
            //cuerpo vacio
            //en el :base puedo incluir un mensaje predeterminado en caso de no usar un mensaje
            //creado por el programador que use esta excepcion
        }

        public ProductoInexistenteException(string mensaje) : base(mensaje)
        {

        }

        public ProductoInexistenteException(string mensaje, Exception exterior) : base(mensaje, exterior)
        {

        }
    }
}
