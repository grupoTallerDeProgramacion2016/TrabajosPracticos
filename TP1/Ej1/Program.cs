﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            //utilizamos una secuencia de IFs y ElSEs para indicar que numero ingreso el usuario..
            if (numero == 1)
            {
                Console.WriteLine("UNO");
            }else if (numero == 2)
            {
                Console.WriteLine("DOS");
            }else if (numero == 3)
            {
                Console.WriteLine("TRES");
            }else if (numero == 4)
            {
                Console.WriteLine("CUATRO");
            }
            else if (numero == 5)
            {
                Console.WriteLine("CINCO");
            }
            else if (numero == 6)
            {
                Console.WriteLine("SEIS");
            }
            else if (numero == 7)
            {
                Console.WriteLine("SIETE");
            }
            else if (numero == 8)
            {
                Console.WriteLine("OCHO");
            }
            else if (numero == 9)
            {
                Console.WriteLine("NUEVE");
            }
           else if (numero > 9) 
            {
                Console.WriteLine("OTRO");
            }
            Console.ReadLine();
        }
    }
}
