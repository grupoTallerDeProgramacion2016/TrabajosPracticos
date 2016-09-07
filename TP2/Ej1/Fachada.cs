namespace Ej1
{
    class Fachada
    {

        public double CalcularAreaCirculo(double pX, double pY, double pRadio)
        {
            return new Circulo(new Punto(pX, pY), pRadio).Area;
        }

        public double CalcularPerimetroCirculo(double pX, double pY, double pRadio)
        {
            return new Circulo(new Punto(pX, pY), pRadio).Perimetro;
        }

        public double CalcularAreaTriangulo(double pX1, double pY1, double pX2, double pY2, double pX3, double pY3)
        {
            return new Triangulo(new Punto(pX1, pY1), new Punto(pX2, pY2), new Punto(pX3, pY3)).Area;
        }

        public double CalcularPerimetroTriangulo(double pX1, double pY1, double pX2, double pY2, double pX3, double pY3)
        {
            return new Triangulo(new Punto(pX1, pY1), new Punto(pX2, pY2), new Punto(pX3, pY3)).Perimetro;
        }

    }
}
