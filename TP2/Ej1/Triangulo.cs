﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            get {double semiPerímetro = (Lado1 + Lado2 + Lado3) / 2;
                return Math.Sqrt((semiPerímetro - Lado1) * (semiPerímetro - Lado2) * (semiPerímetro - Lado3)); }
        }

        public double Perímetro
        {
            get { return (Lado1 + Lado2 + Lado3); }
        }

        private double Lado1
        {
            get { return iPunto1.CalcularDistanciaDesde(iPunto1); }
        }

        private double Lado2
        {
            get { return iPunto1.CalcularDistanciaDesde(iPunto3); }
        }

        private double Lado3
        {
            get { return iPunto2.CalcularDistanciaDesde(iPunto3); }
        }
    }
}

