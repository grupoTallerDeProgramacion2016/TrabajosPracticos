
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] cadenas = new String[5]; //almacena las cadenas ingresadas invertidas
            String invertida;                 //almacena las cadenas invertidas

            if (args.Length != 5)
            {
                Console.WriteLine("No se ingresaron los 5 paramtros necesarios");
            }

            /*
             * Llama al Metodo Invertir con todas las cadenas ingresadas
             * como argumento y las carga en el arreglo
             */
            for (int i = 0; i < args.Length; i++)
            {
                invertida = Invertir(args[i]);
                cadenas[i] = invertida;
            }
            Array.Sort(cadenas); //ordena las cadenas

            foreach (String cadena in cadenas)
            {
                Console.WriteLine(cadena);
            }

            Console.ReadLine();

        }

        /// <summary>
        /// Esta funcion invierte una cadena
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>cadena invertida</returns>
        static String Invertir(String cadena)
        {
            String invertida = "";

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                invertida += cadena[i];
            }

            return invertida;
        }
    }
}