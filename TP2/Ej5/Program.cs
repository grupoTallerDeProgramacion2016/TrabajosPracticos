using System;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            var fecha = new Fecha(2016, 9, 16);
            Console.WriteLine("año : " + fecha.Anio);
            Console.WriteLine("mes : " + fecha.Mes);
            Console.WriteLine("dia : " + fecha.Dia);
            Console.WriteLine(fecha.DiaSemana);
            Console.ReadKey();
            fecha = fecha.AgregarMeses(4);
            Console.WriteLine("año : " + fecha.Anio);
            Console.WriteLine("mes : " + fecha.Mes);
            Console.WriteLine("dia : " + fecha.Dia);
            Console.ReadKey();
            fecha = fecha.AgregarAnios(7);
            Console.WriteLine("año : " + fecha.Anio);
            Console.WriteLine("mes : " + fecha.Mes);
            Console.WriteLine("dia : " + fecha.Dia);
            Console.ReadKey();
        }
    }
}
