using System;
using System.Collections.Generic;

namespace Ej7
{/// <summary>
/// Clase que representa un calendario
/// </summary>
    public class Calendario
    {
        private string iTitulo;
        private DateTime iFecha;
        private string iHoraCreacion;
        IList<Evento> listaEvento = new List<Evento>();
        private int id;
        static int iClave = 0;

        /// <summary>
        /// Constructor de calendario
        /// </summary>
        /// <param name="pTitulo"></param>
        /// <param name="pFecha"></param>
        /// <param name="pHoraCreacion"></param>
        public Calendario(string pTitulo, DateTime pFecha, string pHoraCreacion)
        {
            iTitulo = pTitulo;
            pFecha = DateTime.Now;
            pHoraCreacion = (DateTime.Now.ToString().Split(' ')[1]);
            id = iClave++;
        }

        /// <summary>
        /// Agregar evento al calendario
        /// </summary>
        /// <param name="pEvento"></param>
        public void agregarEvento(Evento pEvento)
        {
            listaEvento.Add(pEvento);
        }

        /// <summary>
        /// Propiedad que devuelve los eventos de una lista de Eventos
        /// </summary>

        public IList<Evento> Eventos
        {
            get { return this.listaEvento; }

        }

        /// <summary>
        /// Eliminar evento del calendario
        /// </summary>
        /// <param name="pEvento"></param>
        public void eliminarEvento(Evento pEvento)
        {
            listaEvento.Remove(pEvento);
        }

        /// <summary>
        /// Modificar evento del calendario
        /// </summary>
        /// <param name="pEvento"></param>
        public void modificarEvento(Evento pEvento)
        {
            listaEvento.Remove(pEvento);
            listaEvento.Add(pEvento);
        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return id == ((Calendario)obj).id;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return id;
        }

    }
}

