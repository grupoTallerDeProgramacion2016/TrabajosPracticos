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
            Console.WriteLine("Ahorcado version lucio!!!");
            Console.Write("Nombre del jugador : ");
            string nombre = Console.ReadLine();
            JuegoAhorcado juego = new JuegoAhorcado();
            Partida partida = juego.IniciarPartida(nombre);
            //Console.WriteLine("la palabra es: " + juego.PartidaActual.Palabra);

            ImprimirPantalla(partida.PalabraActual, partida.Errores, partida.Duracion, partida.Intentos);
            char letra = Convert.ToChar(Console.ReadLine());
            partida = juego.InsertarLetra(letra);

            while (partida.Estado == EstadoPartida.EnCurso)
            {
                Console.Clear();
                ImprimirPantalla(partida.PalabraActual, partida.Errores, partida.Duracion, partida.Intentos);
                letra = Convert.ToChar(Console.ReadLine());
                partida = juego.InsertarLetra(letra);
            }
            if (partida.Estado == EstadoPartida.Ganada)
            { Console.WriteLine("Enorabuena ha ganao el juego!"); }
            else
            { Console.WriteLine("Sos un muerto, perdiste puto"); }

            Console.ReadLine();
        }

        public static void ImprimirPantalla(string pPalabraActual, string pErrores, string pDuracion, int pIntentos)
        {
            Console.WriteLine("JUEGO AHORCADO");            
            Console.WriteLine();
            Console.WriteLine("  ------------------¬");

            int error = 10 - pIntentos;

            switch (error)
            {
                case 1:
                    Console.WriteLine("     0              |"); break;
                case 2:
                    Console.WriteLine("     0              |");
                    Console.WriteLine("    /               |"); break;
                case 3:
                    Console.WriteLine("     0              |");
                    Console.WriteLine("    /|              |");
                    error -= 1;
                    break;
                case 4:
                    Console.WriteLine("     0              |");
                    Console.WriteLine("    /|\\             |");
                    error -= 2;
                    break;
                case 5: 
                    Console.WriteLine("     0              |");
                    Console.WriteLine("    /|\\             |");
                    Console.WriteLine("    /               |");
                    error -= 3;
                    break;
                case 6:
                    Console.WriteLine("     0              |");
                    Console.WriteLine("    /|\\             |");
                    Console.WriteLine("    / \\             |");
                    error -= 4;
                    break;
                default:
                    Console.WriteLine("     0              |");
                    Console.WriteLine("    /|\\             |");
                    Console.WriteLine("    / \\             |");
                    error -= 4;
                    break;
            }

            for (int i = error; i < 10; i++)
            { Console.WriteLine("                    |"); }
            Console.WriteLine("  ------------------|");
            Console.WriteLine();
            Console.WriteLine(pPalabraActual);
            Console.WriteLine();
            Console.WriteLine("Letras erradas: " + pErrores);
            Console.WriteLine();
            Console.WriteLine("Intentos: " + pIntentos);
            Console.WriteLine();
            Console.WriteLine("Tiempo: " + pDuracion);
            Console.WriteLine();
            Console.Write("Siguiente letra: ");
        }
    }
}
