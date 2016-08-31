using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el Limite Inferior: ");
            int limInferior = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Limite Superior: ");
            int limSuperior = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            float promedio = 0;
            int aux = limInferior;
            do
            {
                sum += aux++;
            } while (aux <= limSuperior);
            promedio = ((float)sum / (limSuperior - limInferior + 1));
            Console.WriteLine("El promedio es : " + promedio);
            Console.ReadLine();
        }
    }
}
