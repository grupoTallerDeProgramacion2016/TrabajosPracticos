using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    class Program
    {
        static void Main(string[] args)
        {
            Double maximo = 0;
            Double minimo = Double.MaxValue;
            Double sum = 0;
            Double promedio = 0;
            Random ram = new Random();
            Double[] arreglo = new Double[30];
            for (int i = 0; i < 30; i++)
            {
                arreglo[i] = ram.NextDouble();
               

                sum += arreglo[i];
                if (arreglo[i] > maximo)
                {
                    maximo = arreglo[i];
                }else if (arreglo[i]< minimo)
                {
                    minimo = arreglo[i];
                }
               
            }
            promedio = sum / 30; 
            Console.WriteLine(maximo + "  Es el maximo");
            Console.WriteLine(minimo + "  Es el minimo");
            Console.WriteLine(sum + "  Es la suma total de los numeros");
            Console.WriteLine(promedio + " Es el promedio de los numeros");
            Console.ReadLine();
        }
    }
}
