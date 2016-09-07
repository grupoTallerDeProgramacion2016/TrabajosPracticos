using System;

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
            get { return this.iX; }

        }

        public double Y
        {
            get { return this.iY; }

        }

        /// <summary>
        /// Calcula la distancia desde un punto dado a este punto
        /// </summary>
        /// <param name="pPunto"> Punto dado para calcular la distacia </param>
        /// <returns> Distacia desde pPunto </returns>
        public double calcularDistanciaDesde(Punto pPunto)
        {
            return Math.Sqrt(Math.Pow((pPunto.X - this.iX), 2) + Math.Pow((pPunto.Y - this.iY), 2));
        }

    }
}
