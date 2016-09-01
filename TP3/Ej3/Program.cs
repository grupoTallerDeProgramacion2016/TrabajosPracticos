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
            JuegoAhorcado juego = new JuegoAhorcado();
            juego.IniciarPartida(nombre);
            Console.WriteLine("la palabra es: " + juego.PartidaActual.Palabra);
            Console.Write("letra: ");
            char letra = Convert.ToChar(Console.ReadLine());
            Partida partida = juego.InsertarLetra(letra);

            while (partida.Estado == EstadoPartida.EnCurso)
            {
                Console.Clear();
                Console.WriteLine("palabra: " + partida.PalabraActual);
                Console.WriteLine("errores: " + partida.Errores);
                Console.WriteLine("intentos: " + partida.Intentos);
                Console.Write("letra: ");
                letra = Convert.ToChar(Console.ReadLine());
                partida = juego.InsertarLetra(letra);
            }
            if (partida.Estado == EstadoPartida.Ganada)
            { Console.WriteLine("Enorabuena ha ganao el juego!"); }
            else
            { Console.WriteLine("Sos un muerto, perdiste puto"); }

            Console.ReadLine();
        }
    }
}
