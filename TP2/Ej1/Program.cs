using System;

namespace Ej1
{
    class Program
    {


        static void Main(string[] args)
        {
            int opc;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Circulo");
                Console.WriteLine("2 - Triangulo");
                Console.WriteLine("3 - Salir");
                Console.Write("Opcion: ");

                opc = Convert.ToInt16(Console.ReadLine());

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
                        Console.WriteLine("opcion invalida !");
                        break;
                }

            } while (opc != 3);




        }
        
        public static void OpcionCirculo()
        {
            Fachada fac = new Fachada();

            Console.Clear();
            Console.WriteLine("CIRCULO");
            Console.WriteLine();
            Console.Write("px: ");
            double px = Convert.ToDouble(Console.ReadLine());
            Console.Write("py: ");
            double py = Convert.ToDouble(Console.ReadLine());
            Console.Write("radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("1 - Area");
            Console.WriteLine("2 - Perimetro");
            Console.Write("Opcion: ");
            int opc = Convert.ToInt16(Console.ReadLine());

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
                    Console.WriteLine("opcion invalida !");
                    break;

            }
            Console.ReadKey();
        }

        public static void OpcionTriangulo()
        {
            Fachada fac = new Fachada();

            Console.Clear();
            Console.Write("px1: ");
            double px1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("py1: ");
            double py1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("px2: ");
            double px2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("py2: ");
            double py2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("px3: ");
            double px3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("py3: ");
            double py3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("1 - Area");
            Console.WriteLine("2 - Perimetro");
            Console.Write("Opcion: ");
            int opc = Convert.ToInt16(Console.ReadLine());

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
                    Console.WriteLine("opcion invalida !");
                    break;

            }
            Console.ReadKey();
        }
    }
}
