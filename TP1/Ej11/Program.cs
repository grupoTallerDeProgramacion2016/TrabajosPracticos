using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el radio del circulo: ");
            String entrada = Console.ReadLine();
            float radio = float.Parse(entrada);
            Console.WriteLine("el area del circulo es: " + Math.PI * Math.Pow(radio, 2));
            Console.WriteLine("el perimetro del circulo es: " + 2 * Math.PI * radio);
            Console.Read();
        }

    }
}