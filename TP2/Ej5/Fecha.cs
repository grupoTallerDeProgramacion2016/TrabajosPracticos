namespace Ej5
{
    public class Fecha
    {

        private const int anioInicial = 1970;
        private int iAnio = anioInicial;
        private int iMes = 0;
        private int iDia = 1;
        private int iDiasTotal = 0;
        private int[] meses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int[] coefNoBisiesto = { 0,3,3,6,1,4,6,2,5,0,3,5};
        private int[] coefBisiesto = { 0,3,4,0,2,5,0,3,6,1,4,6};
        private string[] semana = {"domingo", "lunes", "martes", "miercoles", "jueves", "viernes", "sabado"};

        public Fecha(int pAnio, int pMes, int pDia)
        {
            this.iDiasTotal += pDia;
            this.iDia = pDia;
            this.iDiasTotal += this.DiasMeses(pMes - 1);
            this.iMes = pMes - 1;
            this.iDiasTotal += this.DiasAnios(pAnio - anioInicial);
            this.iAnio = pAnio;                  
        }

        private Fecha(int pDias)
        {
            //variables auxiliares
            int dias = pDias;
            int mes = 0;
            int anio = anioInicial ;

            //calcula el año
            while (dias >= 365)
            {
                if (EsBisiesto(anio))
                {
                    dias--;
                }
                dias -= 365;
                anio++;
            }

            //calcula el mes
            bool sigue = true;
            for (int i = 0; i < meses.Length && sigue; i++)
            {

                if (EsBisiesto(anio))
                {
                    int a = 0;
                    if (i == 1) { a += 1; }

                    if (dias > (meses[i] + a))
                    {
                        dias -= meses[i] + a;
                        mes++;
                    }
                    else
                    {
                        sigue = false;
                    }


                }
                else
                {
                    if (dias > meses[i])
                    {
                        dias -= meses[i];
                        mes++;
                    }
                    else
                    {
                        sigue = false;
                    }
                }
            }

            //actualiza las variables de instancia con los valores calculados
            this.iDia = dias;
            this.iMes = mes;
            this.iAnio = anio;
            this.iDiasTotal = pDias;
        }

        public int Anio { get { return this.iAnio; } }

        public int Mes { get { return this.iMes + 1; } }

        public int Dia { get { return this.iDia; } }

        public int DiasTotal { get { return this.iDiasTotal; } }

        public string DiaSemana
        {
            get
            {
                int M = coefNoBisiesto[iMes];
                if (EsBisiesto(iAnio))
                {
                    M = coefBisiesto[iMes];
                }
               int diaSemana = ((iAnio - 1) % 7 + ((iAnio - 1) / 4 - 3 * ((iAnio - 1) / 100 + 1) /4) % 7 + M + iDia%7)%7;
                return semana[diaSemana];
            }
        }

        /// <summary>
        /// Agregar dias a la fecha
        /// </summary>
        /// <param name="pDia"></param>
        /// <returns></returns>
        public Fecha AgregarDias(int pDia)
        {
            return new Fecha(this.iDiasTotal + pDia);            
        }

        /// <summary>
        /// Agregar meses a la fecha
        /// </summary>
        /// <param name="pMes"></param>
        /// <returns></returns>
        public Fecha AgregarMeses(int pMes)
        {
            return new Fecha(this.iDiasTotal + this.DiasMeses(pMes));
        }

        /// <summary>
        /// Agregar anios a la fecha
        /// </summary>
        /// <param name="pAnio"></param>
        /// <returns></returns>
        public Fecha AgregarAnios(int pAnio)
        {
            return new Fecha(this.iDiasTotal + this.DiasAnios(pAnio));
        }

        /// <summary>
        /// Dias desde la fecha actual agregando pMes meses
        /// </summary>
        /// <param name="pMes"></param>
        /// <returns></returns>
        private int DiasMeses(int pMes)
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

            return diasAux;
        }

        /// <summary>
        /// cantidad de dias desde la fecha actual agregando pAnio anios
        /// </summary>
        /// <param name="pAnio"></param>
        /// <returns></returns>
        private int DiasAnios(int pAnio)
        {
            int dias = 0;

            for (int i = this.iAnio; i < this.iAnio + pAnio; i++)
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
            return dias;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAnio"></param>
        /// <returns></returns>
        public static bool EsBisiesto(int pAnio)
        {
            return (pAnio % 4 == 0 && (pAnio % 100 != 0 || pAnio % 400 == 0));
        }

        /// <summary>
        /// Compara a esta fecha con la pasada como parametro y devuelve:
        ///  * 0 si ambas fechas son iguales
        ///  * 1 si esta fecha es mayor
        ///  *-1 si esta fecha es menor
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public int Comparar(Fecha fecha)
        {
            if (fecha.DiasTotal == this.iDiasTotal)
            {
                return 0;
            }
            else
            {
                if (fecha.DiasTotal < this.iDiasTotal)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}



