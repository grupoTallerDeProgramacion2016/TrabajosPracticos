using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Circulo
    {
        private double iRadio; //Se declara el atributo iRadio de la clase circulo
        private Punto iCentro;


        public  Circulo (Punto pCentro, double pRadio)
        {
            iRadio = pRadio;
            iCentro = pCentro;
        } 


        public Circulo (double pX, double pY, double pRadio) // se crea el primer constructor de la clase circulo
        {
            iRadio = pRadio;
            iCentro = new Punto(pX, pY);     
        }

        public Punto Centro //Se crea la propiedad centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }

        public double Radio //se crea la propiedad radio
        {
            get { return this.iRadio; }
            set { this.Radio = value; }
        }


        public double Area //se crea la propiedad Area
        {
            get { return Math.PI*Math.Pow(iRadio, 2); }
           
        }

        public double Perímetro //se crea la propiedad Perímetro
        {
            get { return 2*Math.PI * Math.Pow(iRadio, 2); }
            
        }
    }
}
