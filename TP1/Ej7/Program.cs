using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            float result = 0;
            for (int i = 0; i < 100000; i++)
            {
               result += ((float)(Math.Pow(-1,i)))/(2*i+1);
                
            }
            Console.WriteLine("El resultado es " + result);
            Console.ReadLine();
        }
    }
}

