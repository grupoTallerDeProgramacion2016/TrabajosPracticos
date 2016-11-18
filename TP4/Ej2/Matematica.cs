using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    public class Matematica
    {

        /// <summary>
        /// Metodo que realiza la division entre 2 numeros
        /// </summary>
        /// <param name="pDividendo"></param>
        /// <param name="pDivisor"></param>
        /// <returns></returns>
        public static double Dividir(double pDividendo,double pDivisor )
        {
            //Se verifica la precondicion solicitada
            if (pDividendo != 0)
            { 
                return pDivisor / pDividendo;
            }
            else
            {
                throw new DividirPorCeroException();
            }
        }
    }
}
