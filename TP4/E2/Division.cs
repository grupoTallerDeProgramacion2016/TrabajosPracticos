using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2
{
/// <summary>
///Fachada 
/// </summary>
     class Division
    {

        private Matematica matematica;

        public double obtenerDivision(int x, int y)
        {
            
            if (y != 0) 
            {
               return matematica.Dividir(x,y);
            }
            else
            {
                throw new DividirPorCeroException("Error, no se puede division entre 0");
            }
                       
        }

        

       
    }
}

