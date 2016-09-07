using System;

namespace Ej3
{
    class Program
    {
        private static JuegoAhorcado juego = new JuegoAhorcado();

        static void Main(string[] args)
        {
            int opc;

            do
            {
                Console.Clear();
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
                        MejoresPartidas();
                        break;
                    case 3:
                        CambiarIntentos();
                        break;
                    case 4:
                        Console.WriteLine("Adios!");
                        break;
                    default:
                        break;
                }
            } while (opc != 4);


        }

        private static void CambiarIntentos()
        {

            Console.Clear();
            Console.WriteLine("CAMBIAR DIFICULTAD");
            Console.WriteLine();
            Console.WriteLine("Cantidad de intentos actual: " + juego.Intentos);
            Console.WriteLine();
            Console.WriteLine("Nueva cantidad de intentos: ");
            int intentos = Convert.ToInt16(Console.ReadLine());
            juego.Intentos = intentos;
            Console.WriteLine();
            Console.WriteLine("Intentos guardados con exito");
        }

        private static void MejoresPartidas()
        {
            Console.Clear();

            var lista = juego.MejoresCinco;
            byte cont = 1;

            Console.WriteLine("POSICION   " + " NOMBRE             " + "DURACION");
            foreach (Partida partida in lista)
            {
                Console.WriteLine(cont + " -               \t" + partida.NombreJugador + "\t\t" + partida.DuracionStr);
                cont++;
            }
            Console.ReadKey();
        }

        private static void Jugar()
        {
            Console.Clear();
            Console.WriteLine("AHORCADO!");
            Console.WriteLine();

            Console.Write("Ingresa tu nombre : ");
            string nombre = Console.ReadLine();

            Partida partida = juego.IniciarPartida(nombre);
            bool entradaCorrecta = false;
            string entrada;
            char letra = ' ';

            do
            {
                do
                {
                    Console.Clear();
                    ImprimirPantalla(partida);
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

            ImprimirPantallaFinal(partida);
            juego.GuardarPartida();
        }

        private static void ImprimirPantalla(Partida pDatosPartida)
        {
            Console.WriteLine("JUEGO AHORCADO");
            Console.WriteLine();
            Console.WriteLine(pDatosPartida.PalabraActual);
            Console.WriteLine();
            Console.WriteLine("Letras erradas: " + pDatosPartida.Errores);
            Console.WriteLine();
            Console.WriteLine("Intentos: " + pDatosPartida.Intentos);
            Console.WriteLine();
            Console.Write("Siguiente letra: ");
        }

        private static void ImprimirPantallaFinal(Partida pDatosPartida)
        {
            Console.Clear();
            Console.WriteLine("FIN DEL JUEGO!");
            Console.WriteLine();
            if (pDatosPartida.Estado == EstadoPartida.Ganada)
            {
                Console.WriteLine(pDatosPartida.NombreJugador + " has ganado la partida");
            }
            else
            {
                Console.WriteLine(pDatosPartida.NombreJugador + " has perdido la partida");
            }
            Console.WriteLine();
            Console.WriteLine("La palabra era: " + pDatosPartida.Palabra);
            Console.WriteLine();
            Console.WriteLine("Letras erradas: " + pDatosPartida.Errores);
            Console.WriteLine();
            Console.WriteLine("Intentos: " + pDatosPartida.Intentos);
            Console.WriteLine();
            Console.WriteLine("Tu tiempo: " + pDatosPartida.DuracionStr);
            Console.ReadKey();
        }
    }
}
