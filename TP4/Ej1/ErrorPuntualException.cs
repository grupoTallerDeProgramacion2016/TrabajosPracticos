using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class ErrorPuntualException : ApplicationException
    {
        /// <summary>
        /// Error puntual que implementa el constructor  con un mensaje como parametro
        /// </summary>
        /// <param name="mensaje"></param>
        public ErrorPuntualException(string mensaje): base (mensaje)
        {
            
        }

    }
}
