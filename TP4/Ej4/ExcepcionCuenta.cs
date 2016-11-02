using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class ExcepcionCuenta : Exception
    {
        public ExcepcionCuenta(string pMensaje) : base(pMensaje)
        {

        }
    }
}
