using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    public abstract class Animal
    {
        public void Correr() { Console.WriteLine("corriendo"); }

        public void Saltar() { Console.WriteLine("Saltando"); }

        public virtual void HacerRuido() { }
    }
}
