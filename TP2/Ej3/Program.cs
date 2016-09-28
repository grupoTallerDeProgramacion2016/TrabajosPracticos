using System;

namespace Ej3
{
    class Program
    {
        //se declara static para poder accederla desde el menu y realizar las pruebas
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
                opc = ObtenerEnteroUsuario();
                
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
                        Console.ReadKey();
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
            Console.Write("Nueva cantidad de intentos: ");
            int intentos = ObtenerEnteroUsuario();
            if (intentos > 0)
            {
                juego.Intentos = intentos;
                Console.WriteLine();
                Console.WriteLine("Intentos guardados con exito");
            }
            else
            {
                Console.Write("El caracter ingrasado no es correcto!!");
                Console.ReadKey();
            }
                   


        }


        private static void MejoresPartidas()
        {
            Console.Clear();
  //            Ahorcado ahorcado = new Ahorcado();
  //            ahorcado.MejoresCinco ;
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
              Ahorcado ahorcado = new Ahorcado();
            Console.Clear();
            Console.WriteLine("AHORCADO!");
            Console.WriteLine();

            Console.Write("Ingresa tu nombre : ");
            string nombre = Console.ReadLine();

          
            Partida partida = ahorcado.IniciarPartida(nombre);
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

                
                partida = ahorcado.InsertarLetra(letra); 

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

        private static int ObtenerEnteroUsuario()
        {
            bool incorrecto = true; 
            int opc = 0;
            do
            {
                try
                {
                    opc = Convert.ToInt16(Console.ReadLine());
                    incorrecto = false;
                }
                catch (Exception)
                {
                    //si el valor ingresado es incorrecto se muestra un mensaje al usuario y se continua el ciclo hasta que sea correctos
                    Console.WriteLine("La opcion ingresada no es correcta, vuelva a ingresar la opcion despues del ENTER");
                    Console.ReadKey();
                }
                
            } while (incorrecto);

            return opc;
        }
    }
}
