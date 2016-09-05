using System;

namespace Ej3
{
    class Program
    {

        static void Main(string[] args)
        {
            int opc;

            do
            {
                Console.WriteLine("Menu principal");
                Console.WriteLine();
                Console.WriteLine("1 - Nueva partida");
                Console.WriteLine("2 - Mejores partidas");
                Console.WriteLine("3 - Modificar intentos maximos");
                Console.WriteLine("4 - Salir");
                Console.WriteLine();
                Console.WriteLine("opcion: ");
                opc = Convert.ToInt16(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Jugar();
                        break;
                    case 2:

                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            } while (opc != 4);


        }

        private static void Jugar()
        {
            Console.Clear();
            Console.WriteLine("AHORCADO!");
            Console.WriteLine();

            Console.Write("Ingresa tu nombre : ");
            string nombre = Console.ReadLine();

            JuegoAhorcado juego = new JuegoAhorcado();
            Partida partida = juego.IniciarPartida(nombre);
            bool entradaCorrecta = false;
            string entrada;
            char letra = ' ';

            do
            {
                Console.Clear();
                do
                {
                    ImprimirPantalla(partida.PalabraActual, partida.Errores, partida.Duracion, partida.Intentos);
                    entrada = Console.ReadLine();
                    if (entrada.Length == 1 && Char.IsLetter(entrada, 0))
                    {
                        letra = Convert.ToChar(entrada);
                        entradaCorrecta = true;
                    }
                    else
                    {
                        entradaCorrecta = false;
                        Console.Clear();
                        Console.WriteLine("Solo puede ingresar una letra!!!!!");
                        Console.ReadLine();
                    }
                } while (!entradaCorrecta);

                partida = juego.InsertarLetra(letra);

            } while (partida.Estado == EstadoPartida.EnCurso);

            if (partida.Estado == EstadoPartida.Ganada)
            {
                Console.WriteLine("Enorabuena ha ganao el juego!");
            }
            else
            {
                Console.WriteLine("Sos un muerto, perdiste");
            }

            juego.GuardarPartida();
            Console.ReadLine();
        }

        /// <summary>
        /// Imprime la pantalla del juego
        /// </summary>
        /// <param name="pPalabraActual"> Palabra a adivinar en la que se ven las letras acertadas </param>
        /// <param name="pErrores"> String que contiene las letras incorrectas </param>
        /// <param name="pDuracion"> Duracion actual de la partida </param>
        /// <param name="pIntentos"> Cantidad de intentos disponibles </param>
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
