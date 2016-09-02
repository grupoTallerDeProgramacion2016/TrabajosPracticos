using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Complejo
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
                return Math.Atan2(this.iImaginario,this.iReal);
            }
        }

        public double ArgumentoEnGrados
        {
            get
            {
                return 1.0;
            }
        }

        public Complejo Conjugado
        {
            get
            {
                return this;
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

        
    }
}
