using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el Limite Inferior: ");
            int limInferior = Convert.ToInt32(Console.ReadLine()); //se le pide al usuario que ingrese el limite inferior
            Console.Write("Ingrese el Limite Superior: ");
            int limSuperior = Convert.ToInt32(Console.ReadLine()); //se le pide al usuario que ingrese el limite superior
            int sum = 0; //se inicializa la sumatoria con un tipo de variable 
            float promedio = 0; 
            for (int i = limInferior; i <= limSuperior; i++)
            {
                sum += i;
            }
            promedio = ((float)sum / (limSuperior - limInferior +1));
            Console.WriteLine("El promedio es : " + promedio);
            Console.ReadLine();

        }
    }
}
