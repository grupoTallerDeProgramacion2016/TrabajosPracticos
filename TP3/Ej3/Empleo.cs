using System;

namespace Ej3
{
    public class Empleo
    {
        private double iSueldo;
        private DateTime iFechaIngreso;

        public Empleo(double pSueldo, DateTime pFechaIngreso)
        {
            iSueldo = pSueldo;
            iFechaIngreso = pFechaIngreso;
        }

        public double Sueldo { get { return this.iSueldo; } }

        public DateTime FechaIngreso { get { return this.iFechaIngreso;} }
    }
}
