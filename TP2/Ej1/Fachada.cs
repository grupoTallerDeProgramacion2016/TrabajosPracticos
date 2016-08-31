using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Fachada
    {
        public double CalcularAreaCiruculo(double pX, double pY, double pRadio)
        {
            return new Circulo(new Punto(pX, pY), pRadio).Area;
        }

        public double CalcularPerímetroCiruculo(double pX, double pY, double pRadio)
        {
            return new Circulo(new Punto(pX, pY), pRadio).Perímetro;
        }

        public double CalcularAreaTriangulo(double pX, double pY, double pZ)
        {
            return new Triangulo (new Punto(pX,pY), new Punto (pX,pZ), new Punto (pY, pZ)).Area;
        }

        public double CalcularPerímetroTriangulo(double pX, double pY, double pZ)
        {
            return new Triangulo(new Punto(pX, pY), new Punto(pX, pZ), new Punto(pY, pZ)).Perímetro;
        }
    }
}
