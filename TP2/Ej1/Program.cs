using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {

   


        static void Main(string[] args)
        {
           
            Console.WriteLine("1 - Circulo: ");
            Console.WriteLine("2 - Triangulo: ");
            Console.WriteLine("3 - Salir");
            int opc = Convert.ToInt16(Console.ReadLine());
   
            switch (opc)
            {
                case 1:
                    OpcionCirculo();
                    break;
                case 2:
                    OpcionTriangulo();
                    break;
                case 3:
                    break;
            }

            Console.ReadKey();
            }


        public static void OpcionTriangulo()
        {
            Console.Clear();
            Console.WriteLine("pX: ");
            Double pX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pY: ");
            double pY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pZ: ");
            double pZ = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1 - Área: ");
            Console.WriteLine("2 - Perímetro: ");
            int opc = Convert.ToInt16(Console.ReadLine());
            Fachada facade = new Fachada();
            double area = facade.CalcularAreaTriangulo(pX, pY, pZ);
            double perimetro = facade.CalcularPerímetroTriangulo(pX, pY, pZ);
            switch (opc)
            {
                case 1:
                    Console.WriteLine("El área es:" + area);
                    break;
                case 2:
                    Console.WriteLine("El perímetro es:" + perimetro);
                    break;
            }
        }



        public static void OpcionCirculo()
        {
            Console.Clear();
            Console.WriteLine("pX: ");
            double pX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pY: ");
            double pY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1 - Área: ");
            Console.WriteLine("2 - Perímetro: ");
            int opc = Convert.ToInt16(Console.ReadLine());
            Fachada facade = new Fachada();
            double area = facade.CalcularAreaCiruculo(pX, pY, radio);
            double perimetro = facade.CalcularPerímetroCiruculo(pX, pY, radio);
            switch (opc)
                {
                case 1:
                    Console.WriteLine("El área es:" + area);
                    break;
                case 2:
                    Console.WriteLine("El perímetro es:" + perimetro);
                   break;
                }
        }
    }
}
        
        
    
