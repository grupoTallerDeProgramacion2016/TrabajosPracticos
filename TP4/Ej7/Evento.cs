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
        private int id;
        static int iClave = 0;

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
            iFecha = DateTime.Now;
            iDuracion = pDuracion;
            iFrecuenciaRepeticion = pFrecuenciaRepeticion;
            id = Evento.iClave++;

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
