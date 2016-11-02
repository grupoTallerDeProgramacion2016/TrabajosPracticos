using System;

namespace Ej7
{/// <summary>
/// Clase que contiene todos los datos de los eventos que ocurren en un calendario determinado
/// </summary>
    public class Evento
    {
        private string iTitulo;
        private DateTime iFecha;
        private string iHoraComienzo;
        private string iDuracion;
        private string iFrecuenciaRepeticion;
        private int id;
        static int iClave = 0;

        /// <summary>
        /// Constructor del evento
        /// </summary>
        /// <param name="ptitulo"></param>
        /// <param name="pFecha"></param>
        /// <param name="pHoraComienzo"></param>
        /// <param name="pDuracion"></param>
        /// <param name="pFrecuenciaRepeticion"></param>
        public Evento(string ptitulo, DateTime pFecha, string pHoraComienzo, string pDuracion, string pFrecuenciaRepeticion)
        {
            iTitulo = ptitulo;
            pFecha = DateTime.Now;
            pHoraComienzo = (DateTime.Now.ToString().Split(' ')[1]);
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
