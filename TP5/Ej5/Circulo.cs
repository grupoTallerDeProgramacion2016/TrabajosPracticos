using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class Circulo
    {
        private double iRadio;
        private Punto iCentro;

        public Circulo(Punto pCentro, double pRadio)
        {
            iRadio = pRadio;
            iCentro = pCentro;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            iCentro = new Punto(pX, pY);
            iRadio = pRadio;
        }

        public Punto Centro
        {
            get { return this.iCentro; }

        }

        public double Radio
        {
            get { return this.iRadio; }

        }

        public double Area
        {
            get { return Math.PI * Math.Pow(this.iRadio, 2); }

        }

        public double Perimetro
        {
            get { return 2.0 * Math.PI * this.iRadio; }

        }
    }
}
