
using System;

namespace Ej1
{
    class Triangulo
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            iPunto1 = pPunto1;
            iPunto2 = pPunto2;
            iPunto3 = pPunto3;
        }
        public Punto Punto1
        {
            get { return this.iPunto1; }
        }
        public Punto Punto2
        {
            get { return this.iPunto2; }
        }
        public Punto Punto3
        {
            get { return this.iPunto3; }
        }
        public double Area
        {
            get
            {
                double semiPe = (Lado1 + Lado2 + Lado3) / 2;
                return Math.Sqrt(semiPe * (semiPe - Lado1) * (semiPe - Lado2) * (semiPe - Lado3));
            }
        }
        public double Perimetro
        {
            get
            {
                return Lado1 + Lado2 + Lado3;
            }
        }
        private double Lado1
        {
            get { return this.iPunto1.calcularDistanciaDesde(this.iPunto2); }
        }
        private double Lado2
        {
            get { return this.iPunto1.calcularDistanciaDesde(this.iPunto3); }
        }
        private double Lado3
        {
            get { return this.iPunto2.calcularDistanciaDesde(this.iPunto3); }
        }
    }
}
