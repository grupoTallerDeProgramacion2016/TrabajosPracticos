using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Punto
    {
        private double iX;
        private double iY;
        public Punto(double pX, double pY)
        {
            iX = pX;
            iY = pY;
        }

        public double X
        {
            get { return this.iX;}
           
        }
        public double Y
        {
            get { return this.iY; }
           
        }
        public double calcularDistanciaDesde(Punto pPunto)
        {
             return Math.Sqrt (Math.Pow((pPunto.X - this.iX), 2) + Math.Pow((pPunto.Y - this.iY),2));
        }

    }
}
