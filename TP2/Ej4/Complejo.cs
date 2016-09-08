using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    public class Complejo
    {
        private double iReal;
        private double iImaginario;

        public Complejo(double pReal, double pImaginario)
        {
            iReal = pReal;
            iImaginario = pImaginario;
        }

        public double Real
        {
            get
            {
                return this.iReal;
            }
        }

        public double Imaginario
        {
            get
            {
                return this.iImaginario;
            }
        }

        public double ArgumentoEnRadianes
        {
            get
            {
                return  Math.Atan2(this.iImaginario,this.iReal);
            }
        }

        public double ArgumentoEnGrados
        {
            get
            {
                return ((this.ArgumentoEnRadianes)*180)/Math.PI;
            }
        }

        public Complejo Conjugado
        {
            get
            {
                return new Complejo(this.iReal, this.iImaginario * -1);
            }
        }

        public double Magnitud
        {
            get
            {
                return Math.Sqrt(Math.Pow(iImaginario, 2) + Math.Pow(iReal, 2));
            }
        }

        public bool EsReal()
        {
            return iImaginario == 0;
        }

        public bool EsImaginario()
        {
            return iImaginario != 0;
        }

        public bool EsIgual(Complejo pOtroComplejo)
        {
            return iImaginario == pOtroComplejo.Imaginario && iReal == pOtroComplejo.Real;
        }

        public bool EsIgual(double pReal, double pImaginario)
        {
            return iImaginario == pImaginario && iReal == pReal;
        }

        public Complejo Sumar(Complejo pOtroComplejo)
        {
            return new Complejo(this.iReal + pOtroComplejo.iReal, this.iImaginario + pOtroComplejo.iImaginario);
        }

        public Complejo Restar(Complejo pOtroComplejo)
        {
            return new Complejo(this.iReal - pOtroComplejo.iReal, this.iImaginario - pOtroComplejo.iImaginario);
        }

        public Complejo Multiplicar(Complejo pOtroComplejo)
        {
            return new Complejo((this.iReal * pOtroComplejo.iReal) - (this.iImaginario * pOtroComplejo.iImaginario), +
            ((this.iReal * pOtroComplejo.iImaginario) + (this.iImaginario * pOtroComplejo.iReal)));
        }

        public Complejo Dividir(Complejo pOtroComplejo)
        {
            return new Complejo(((this.iReal * pOtroComplejo.iReal) + (this.iImaginario * pOtroComplejo.iImaginario))/ ((Math.Pow(pOtroComplejo.iReal,2))+ (Math.Pow(pOtroComplejo.iImaginario, 2)))
                , +
            ((this.iReal * pOtroComplejo.iImaginario) - (this.iImaginario * pOtroComplejo.iReal))/ ((Math.Pow(pOtroComplejo.iReal, 2)) + (Math.Pow(pOtroComplejo.iImaginario, 2))));
        }

     }
}
