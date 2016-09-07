using System;

namespace Ej5
{
    class Fecha
    {
        private int iDias;
        private enum meses { Enero = 31, Febrero = 28, Marzo = 31, Abril = 30,  Mayo = 31, Junio = 30,
                             Julio = 31}

        public Fecha()
        {
            iDias = 0;
        }

        public void AgregarDia(int pDia)
        {
            iDias += pDia;
        }

        public static void agregarMes(int pMes)
        {
            iFecha.AddMonths(pMes);
        }

        public static void agregarAño(int pAño)
        {
            iFecha.AddYears(pAño);
        }

        public int devolverDia
        {
            get { return iFecha.Day; }
        }

        public int devolverMes
        {
            get { return iFecha.Month; }
        }

        public int devolverAño
        {
            get { return iFecha.Year; }
        }

        public string devolverDiaDeLaSemana
        {
            get { return Convert.ToString(iFecha.DayOfWeek); }
        }

        public bool añoBisiesto
        {
            get { return DateTime.IsLeapYear(iFecha.Year); }
        }

        public static int compararFecha
        {
            get { return DateTime.Compare(iFecha.Date, iFecha.Date); }
        }




    }
}
