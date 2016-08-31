using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            float promedio = 0;
            int sum = 0;
            for (int i = 1; i <= 100; i+=2)
            {
                sum += i;
            }
            promedio = (float)sum / 49;
            Console.Write("Suma de los primeros 100 impares: " + sum + "El promedio es:" + promedio);
            Console.ReadLine();


        }
        
    }
}
