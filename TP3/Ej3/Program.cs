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
            Console.WriteLine("Ahorcado!!!");
            Console.Write("Nombre del jugador: ");
            string nombre = Console.ReadLine();
            Partida partida = JuegoAhorcado.IniciarPartida(nombre);
            Console.Write("la palabra es: "+ partida.Palabra);
            Console.Write("letra: ");
            char letra = Convert.ToChar(Console.ReadLine());

            while (partida.VerificarLetra(letra))
            {
                Console.WriteLine("palabra: " + partida.PalabraActual);
                Console.WriteLine("errores: " + partida.Errores);
                Console.Write("letra: ");
                letra = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
