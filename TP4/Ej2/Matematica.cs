using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    public class Matematica
    {
        public static double Dividir(double pDividendo,double pDivisor )
        {
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
