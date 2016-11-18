using System;

namespace Ej7
{/// <summary>
/// Clase que contiene todos los datos de los eventos que ocurren en un calendario determinado
/// </summary>
    public class Evento
    {
        private string iTitulo;
        private DateTime iFecha;
        private int iDuracion;
        private Frecuencia iFrecuenciaRepeticion;
        private int iDiaSemanaRepeticion;
        private int iDiaMesRepeticion;
        private int iMesRepeticion;
        private int id;
        /// <summary>
        /// Utilizamos un atributo estatico para asignar los id que
        /// identifican a los eventos
        /// </summary>
        static int iClave = 0;

        /// <summary>
        /// Clase enumerada que para representar las posibles frecuencias
        /// </summary>
        public enum Frecuencia
        {
            UnicaVez,
            Semanal,
            Mensual,
            Anual
        }

        public DateTime Fecha { get { return this.iFecha; } set { this.Fecha = value; } }

        public string Titulo { get { return this.iTitulo; } set { this.iTitulo = value; } }

        public int Duracion { get { return this.iDuracion; } set { this.iDuracion = value; } }

        public Frecuencia FrecuenciaRepeticion
        {
            get { return this.iFrecuenciaRepeticion; }
            set { this.iFrecuenciaRepeticion = value; }
        }

        public int IdEvento { get { return this.id; } }

        /// <summary>
        /// Constructor del evento
        /// </summary>
        /// <param name="ptitulo"></param>
        /// <param name="pFecha"></param>
        /// <param name="pHoraComienzo"></param>
        /// <param name="pDuracion"></param>
        /// <param name="pFrecuenciaRepeticion"></param>
        public Evento(string ptitulo, DateTime pFecha, int pDuracion, Frecuencia pFrecuenciaRepeticion)
        {
            iTitulo = ptitulo;
            iFecha = pFecha;
            iDuracion = pDuracion;
            iFrecuenciaRepeticion = pFrecuenciaRepeticion;
            switch (iFrecuenciaRepeticion)
            {
                case Frecuencia.Semanal:
                    this.iDiaSemanaRepeticion = (int)iFecha.DayOfWeek;
                    break;
                case Frecuencia.Mensual:
                    this.iDiaMesRepeticion = (int)iFecha.Day;
                    break;
                case Frecuencia.Anual:
                    this.iMesRepeticion = iFecha.Month;
                    this.iDiaMesRepeticion = iFecha.Day;
                    break;
                default:
                    break;
            }
            id = Evento.iClave++;

        }

        /// <summary>
        /// Metodo para saber si un evento ocurre un determinado dia de la semana (lunes, martes...)
        /// </summary>
        /// <param name="pDia"></param>
        /// <returns></returns>
        public Boolean OcurreEnElDiaSemana(int pDia)
        {
            if (this.FrecuenciaRepeticion == Frecuencia.Semanal)
            {
                return pDia == this.iDiaSemanaRepeticion;
            }
            return false;
        }

        /// <summary>
        /// Metodo para saber si un evento ocurre un dia del mes determinado (22, 23...)
        /// </summary>
        /// <param name="pDia"></param>
        /// <returns></returns>
        public Boolean OcurreEnElDiaMes(int pDia)
        {
            if (this.FrecuenciaRepeticion == Frecuencia.Mensual)
            {
                return pDia == this.iDiaMesRepeticion;
            }
            return false;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                return ((Evento)obj).id == this.id;
            }


        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return (id);
        }

    }
}
