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
            int x = 0;
            int y = 0;
            try
            {
                Matematica matematica = new Matematica();
                matematica.Dividir(x,y);

            }
            catch (DivideByZeroException ex)
            {

                System.Console.Write("No es posible la division en 0", ex);
            }
        }
    }
}
