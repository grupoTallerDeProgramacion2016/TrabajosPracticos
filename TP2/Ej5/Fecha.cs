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
            iDiasTotal = 0;
            iAnio = 0;
            iMes = 0;
            iDia = 1;
        }

        public int Anio { get { return this.iAnio + anioInicial; } }

        public int Mes { get { return this.iMes + 1; } }

        public int Dia { get { return this.iDia; } }

        public void AgregarDias(int pDia)
        {
            iDiasTotal += pDia;
            this.CalcularVariables(iDiasTotal);
        }

        public int AgregarMeses(int pMes)
        {
            //calcula el mes de la fecha final
            int ultimoMes = (iMes + pMes) % 12;

            //calcula los dias para llegar al primero del mes siguiente
            int diasAux = meses[iMes] - iDia;

            //hace la sumatoria de los dias que poseen los meses intermedios
            for (int i = iMes + 1; i != ultimoMes; i++)
            {
                if (i == 12)
                {
                    i = 0;
                }
                diasAux += meses[i];
            }

            //suma los dias que corresponderan al ultimo mes verificando que no sean mayores
            //a los dias que posee el mes
            if (iDia <= meses[ultimoMes])
            {
                diasAux += iDia;
            }
            else
            {
                diasAux += meses[ultimoMes];
            }

            //agrega los dias calculados a la fecha
            this.AgregarDias(diasAux);
            return diasAux;
        }

        public int AgregarAnios(int pAnio)
        {
            int dias = 0;

            for (int i = anioInicial; i < anioInicial + pAnio; i++)
            {
                if (EsBisiesto(i))
                {
                    dias += 366;
                }
                else
                {
                    dias += 365;
                }
            }

            this.AgregarDias(dias);
            return dias;
        }

        private void CalcularVariables(int pDias)
        {
            //variables auxiliares
            int dia = 0;
            int mes = 0;
            int anio = anioInicial;

            //calcula el año
            while (pDias >= 365)
            {
                pDias -= 365;
                anio++;
                if (EsBisiesto(anio))
                {
                    pDias--;
                }
            }

            //calcula el mes
            bool sigue = true;
            for (int i = 0; i < meses.Length && sigue; i++)
            {

                if (EsBisiesto(anio))
                {
                    int a = 0;
                    if (i == 1) { a += 1; }

                    if (pDias > (meses[i] + a))
                    {
                        pDias -= meses[i];
                        mes++;
                    }
                    else
                    {
                        sigue = false;
                    }


                }
                else
                {
                    if (pDias > meses[i])
                    {
                        pDias -= meses[i];
                        mes++;
                    }
                    else
                    {
                        sigue = false;
                    }
                }
            }

            //actualiza las variables de instancia con los valores calculados
            this.iDia = pDias;
            this.iMes = mes;
            this.iAnio = anio - anioInicial;
        }

        public static bool EsBisiesto(int pAnio)
        {
            return (pAnio % 4 == 0 && (pAnio % 100 != 0 || pAnio % 400 == 0));
        }



    }
}



