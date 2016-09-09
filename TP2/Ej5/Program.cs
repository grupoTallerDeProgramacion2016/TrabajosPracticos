using System;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            var fecha = new Fecha();
            int dias = fecha.AgregarAnios(3);
            Console.WriteLine("dias: " + dias);
            Console.WriteLine("año : " + fecha.Anio);
            Console.WriteLine("mes : " + fecha.Mes);
            Console.WriteLine("dia : " + fecha.Dia);
            Console.ReadKey();
            dias = fecha.AgregarMeses(6);
            Console.WriteLine("dias: " + dias);
            Console.WriteLine("año : " + fecha.Anio);
            Console.WriteLine("mes : " + fecha.Mes);
            Console.WriteLine("dia : " + fecha.Dia);
            Console.ReadKey();
            fecha.AgregarDias(7);
            Console.WriteLine("año : " + fecha.Anio);
            Console.WriteLine("mes : " + fecha.Mes);
            Console.WriteLine("dia : " + fecha.Dia);
            Console.ReadKey();
        }
    }
}
