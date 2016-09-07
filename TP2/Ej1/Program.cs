using System;

namespace Ej1
{
    class Program
    {


        static void Main(string[] args)
        {
            int opc = 0;

            do
            {
                //menu principal
                Console.Clear();
                Console.WriteLine("1 - Circulo");
                Console.WriteLine("2 - Triangulo");
                Console.WriteLine("3 - Salir");
                Console.Write("Opcion: ");

                try
                {
                    opc = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception e)
                {
                    //si el valor ingresado es incorrecto se muestra un mensaje al usuario y se continua el ciclo hasta que sea correctos
                    MensajeError("ingrese un numero del 1 al 3", e.ToString());
                    continue;
                }


                switch (opc)
                {
                    case 1:
                        OpcionCirculo();
                        break;
                    case 2:
                        OpcionTriangulo();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Valor ingresado incorrectamente");
                        Console.WriteLine(" * Solo se permiten ingresar numeros del 1 al 3 como opcion");
                        break;
                }

            } while (opc != 3);


        }

        private static void OpcionCirculo()
        {
            Fachada fac = new Fachada();
            double px;
            double py;
            double radio;

            Console.Clear();
            Console.WriteLine("CIRCULO");
            Console.WriteLine();

            do
            {
                //carga de datos por el usuario con control de errores para el ingreso
                try
                {
                    Console.Clear();
                    Console.Write("px: ");
                    px = Convert.ToDouble(Console.ReadLine());
                    Console.Write("py: ");
                    py = Convert.ToDouble(Console.ReadLine());
                    Console.Write("radio: ");
                    radio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    break;
                }
                catch (Exception e)
                {
                    //si algun valor ingresado es incorrecto se muestra un mensaje al usuario y se continua el ciclo hasta que sean correctos
                    MensajeError("Solo se permiten numeros de punto flotante o enteros", e.ToString());
                    continue;
                }

            } while (true);


            //menu secundario            
            byte opc = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1 - Area");
                    Console.WriteLine("2 - Perimetro");
                    Console.Write("Opcion: ");
                    opc = Convert.ToByte(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    //si el valor ingresado es incorrecto se muestra un mensaje al usuario y se continua el ciclo hasta que sea correctos
                    MensajeError("Solo se permiten las opciones 1 o 2", e.ToString());
                    continue;
                }

            } while (true);

            switch (opc)
            {
                case 1:
                    double area = fac.CalcularAreaCirculo(px, py, radio);
                    Console.WriteLine("El area del circulo es: " + area);
                    break;
                case 2:
                    double perimetro = fac.CalcularPerimetroCirculo(px, py, radio);
                    Console.WriteLine("El perimetro del circulo es: " + perimetro);
                    break;
                default:
                    Console.WriteLine("Valor ingresado incorrectamente");
                    Console.WriteLine(" * Solo se permiten ingresar numeros del 1 al 2 como opcion");
                    break;

            }
            Console.ReadKey();
        }

        private static void OpcionTriangulo()
        {
            Fachada fac = new Fachada();
            double px1;
            double py1;
            double px2;
            double py2;
            double px3;
            double py3;

            Console.Clear();
            Console.WriteLine("TRIANGULO");
            Console.WriteLine();

            do
            {
                //carga de datos por el usuario con control de errores
                try
                {
                    Console.Clear();
                    Console.Write("px1: ");
                    px1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("py1: ");
                    py1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("px2: ");
                    px2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("py2: ");
                    py2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("px3: ");
                    px3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("py3: ");
                    py3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    break;

                }
                catch (Exception e)
                {
                    //si algun valor ingresado es incorrecto se muestra un mensaje al usuario y se continua el ciclo hasta que sean correctos
                    MensajeError("Solo se permiten numeros de punto flotante o enteros", e.ToString());
                    continue;

                }

            } while (true);

            //menu secundario            
            byte opc = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1 - Area");
                    Console.WriteLine("2 - Perimetro");
                    Console.Write("Opcion: ");
                    opc = Convert.ToByte(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    //si el valor ingresado es incorrecto se muestra un mensaje al usuario y se continua el ciclo hasta que sea correctos
                    MensajeError("Solo se permiten las opciones 1 o 2", e.ToString());
                    continue;
                }

            } while (true);

            switch (opc)
            {
                case 1:
                    double area = fac.CalcularAreaTriangulo(px1, py1, px2, py2, px3, py3);
                    Console.WriteLine("El area del triangulo es: " + area);
                    break;
                case 2:
                    double perimetro = fac.CalcularPerimetroTriangulo(px1, py1, px2, py2, px3, py3);
                    Console.WriteLine("El perimetro del triangulo es: " + perimetro);
                    break;
                default:
                    Console.WriteLine("Valor ingresado incorrectamente");
                    Console.WriteLine(" * Solo se permiten ingresar numeros del 1 al 2 como opcion");
                    break;

            }
            Console.ReadKey();
        }

        /// <summary>
        /// Imprime un mensaje de error al usuario con una sugerencia y el codigo del error
        /// </summary>
        /// <param name="sugerencia"></param>
        /// <param name="err"></param>
        private static void MensajeError(string sugerencia, string error)
        {
            Console.Clear();
            Console.WriteLine("Opcion ingresada incorrectamente");
            Console.WriteLine(" * " + sugerencia);
            Console.WriteLine();
            Console.WriteLine("Mensaje de error: " + error);
            Console.ReadLine();
        }
    }
}
