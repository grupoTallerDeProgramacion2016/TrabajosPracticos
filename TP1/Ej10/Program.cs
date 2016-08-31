using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10
{
    class Program
    {
        static void Main(string[] args)
        {
        
        for (int i = 1900; i < 2015; i++ )
            {
                if (esBisiesto(i))
                {
                    Console.WriteLine(i + "  Es bisiesto");
                }
                
            }
            Console.ReadLine();
        }
        static Boolean esBisiesto(int anio)
        {
            if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
