using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2
{
    class DividirPorCeroException : Exception
    {
        public DividirPorCeroException(string pMensaje)
        {
            int var;
            try
            {
               var = 0;
            }
            catch (DivideByZeroException ex)
            {

                System.Console.Write("No es posible la division por 0");
            }
        }
    }
}
