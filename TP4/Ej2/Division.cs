using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
/// <summary>
///Fachada 
/// </summary>
    public class Division
    {
                
        public double obtenerDivision(double x, double y)
        {
            try
            {
                return Matematica.Dividir(x, y);
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Se produjo una excepción, en la división!");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return 0;
                       
        }
              

       
    }
}

