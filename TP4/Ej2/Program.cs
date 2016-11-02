using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            double num1;
            double num2;
            Console.WriteLine("Welcome!!!");
            Console.WriteLine("Ahora vamos a jugar con la división");
            Console.WriteLine("Ingrese los numeros que desea dividir, primero el divisor y luego el dividendo");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            var division = new Division();
            
            Console.WriteLine("EL resultado es:" + division.obtenerDivision(num1, num2));
            Console.ReadKey();           

        }
    }
}
