﻿using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            var veterinaria = new Veterinaria();
            Animal[] animales = { new Perro(), new Gato()};
            veterinaria.AceptarAnimales(animales);
            Console.ReadLine();
        }
    }
}
