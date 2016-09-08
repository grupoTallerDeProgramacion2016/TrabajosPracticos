using System;

namespace Ej5
{
    class Fecha
    {

        private const int anioInicial = 1970;
        private int iAnio;
        private int iMes;
        private int iDia;
        private int iDiasTotal;
        private int[] meses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public Fecha()
        {
            iDias = 0;
        }

        public void AgregarDias(int pDia)
        {
            iDias += pDia;
        }
        
        public void AgregarMeses(int pMes)
        {
            
            if(meses[iMes] <= meses[iMes])
            {
                
            }
        }

        private void CalcularVariables(int pDias)
        {
            int dia = 0;
            int mes = 1;
            int anio = anioInicial;

            while (pDias >= 365)
            {
                pDias -= 365;
                anio++;
                if (AnioBisiesto(anio))
                {
                    pDias--;
                }
            }
            bool sigue = true;
            for (int i = 0; i < meses.Length && sigue; i++)
            {
                if (pDias > meses[i])
                {
                    pDias -= meses[i];    
                    mes++;
                }
                else
                {
                    sigue = false;
                    dias = pDias;
                }
            }

        }

        public bool AnioBisiesto(int pAnio)
        {
            return (pAnio % 4 == 0 && (pAnio % 100 != 0 || pAnio % 400 == 0));
        }

        public static int compararFecha
        {
            get { return DateTime.Compare(iFecha.Date, iFecha.Date); }
        }

    }
}



