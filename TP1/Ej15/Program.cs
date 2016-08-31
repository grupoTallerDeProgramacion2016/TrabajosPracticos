using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random ram = new Random();
            int[] arreglo = new int[50];
            for (int i = 0; i <arreglo.Length; i++)
            {
                arreglo[i] = ram.Next(1,5000);
            
            }
            Array.Sort(arreglo);
         
           for (int j =0; j <arreglo.Length; j++)
            {
                Console.WriteLine(arreglo[j]);
            }
            Console.WriteLine("A PARTIR DE ACA DEVUELVE LOS VALORES COMPRENDIDOS ENTRE DOS CONSTANTES");
            Console.Write("INGRESE VALOR 1  ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("INGRESE VALOR 2  ");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            for (int q = 0; q < arreglo.Length; q++)
              {
                  if (arreglo[q] > valor1 && arreglo[q] < valor2)
                  {
                    Console.WriteLine(arreglo[q]);
                  }

              }

            Console.ReadLine();


        }
        
    }
}
