using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    public class Veterinaria
    {
        public void AceptarAnimales(Animal[] animales)
        {
            foreach (var animal in animales)
            {
                animal.HacerRuido();
            }
        }
    }
}
