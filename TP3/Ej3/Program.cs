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
            if (Isabel.EvaluarSolicitudPorCliente(15000.0, 25, 1))
            {
                Console.Write("Se le puede otorgar credito!!!");
                Console.ReadKey();
            }
            else
            {
                Console.Write("No se le puede otorgar credito a esta persona!!!");
                Console.ReadKey();
            }

            
        }
    }
}
