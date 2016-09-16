using Ej1;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            var veterinaria = new Veterinaria();
            Animal[] animales = { new Perro(), new Gato(), new Pato(), new Vaca(), new Chancho()};
            veterinaria.AceptarAnimales(animales);
            System.Console.ReadLine();
        }
    }
}
