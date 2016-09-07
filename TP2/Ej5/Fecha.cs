using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class Fecha
    {
        private static DateTime iFecha;
        DateTime fecha = iFecha;
        
        public static void agregarDia(int pDia)
        {
            iFecha.AddDays(pDia);
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
            get { return DateTime.IsLeapYear(iFecha.Year) ; }
        }

        public static int compararFecha
        {
            get { return DateTime.Compare(iFecha.Date, iFecha.Date); }
        }

        
            
        
    }
}
