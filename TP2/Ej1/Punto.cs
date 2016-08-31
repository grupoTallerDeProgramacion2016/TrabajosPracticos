using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    public class Punto //Se declara la clase punto
    {

        private double iX;  //se declaran los atributos de la clase
        private double iY;

       // public object get { get; private set; }

        public Punto (double pX, double pY) //Construcción del punto
        {
            iX = pX;   //se asigna cada atributo a su parámetro del constructor correspondiente
            iY = pY;
        }

        public double X  //Propiedad punto y
        {
            get {return this.iX;}
            set {this.iX = value;}            
        }

        public double Y   //propiedad punto y
        {
            get { return this.iY;}
            set { this.iY = value;}
        }

        public double CalcularDistanciaDesde (Punto pPunto) //se crea el método CalcularDistanciaDesde
        {
                     return Math.Sqrt(Math.Pow((pPunto.X - this.iX), 2 ) + Math.Pow((pPunto.Y-this.iY), 2));
        }
        
    }
}
