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
        List<Evento> iEventos = new List<Evento>();
        private int id;
        /// <summary>
        /// Utilizamos un atributo estatico para asignar los id que
        /// identifican a los calendarios
        /// </summary>
        static int iClave = 0;

        /// <summary>
        /// Constructor de calendario
        /// </summary>
        /// <param name="pTitulo"></param>
        /// <param name="pFecha"></param>
        /// <param name="pHoraCreacion"></param>
        public Calendario(string pTitulo, DateTime pFecha)
        {
            iTitulo = pTitulo;
            iFecha = pFecha;
            iHoraCreacion = (pFecha.ToString().Split(' ')[1]);
            id = Calendario.iClave++;
        }

        public string Titulo { get { return this.iTitulo; } set { this.iTitulo = value; } }

        public DateTime FechaCreacion { get { return this.iFecha; } }

        public int IdCalendario { get { return this.id; } }

        /// <summary>
        /// Agregar evento al calendario
        /// </summary>
        /// <param name="pEvento"></param>
        public void agregarEvento(Evento pEvento)
        {
            //si la fecha del evento es menor a la fecha actual
            if (DateTime.Now.CompareTo(pEvento.Fecha) > 0)
            {
                throw new FechaIncorrectaException("la fecha del evento no puede ser anterior a la fecha actual");
            }
            iEventos.Add(pEvento);
        }

        /// <summary>
        /// Eliminar evento del calendario
        /// </summary>
        /// <param name="pEvento"></param>
        /// 
        public void eliminarEvento(Evento pEvento)
        {
            if (!iEventos.Remove(pEvento))
            {
                throw new ErrorAlEliminarException("el evento que desea eliminar no se encuentra o se ha producido un" +
                                                        " error al intentar eliminarlo");
            }
        }

        /// <summary>
        /// Modificar evento del calendario
        /// </summary>
        /// <param name="pEvento"></param>
        public void modificarEvento(Evento pEvento)
        {
            if (!iEventos.Remove(pEvento))
            {
                throw new ErrorAlModificarException("el evento que desea modificar no se encuentra o se ha producido un" +
                                                        " error al intentar modificarlo");
            }
            iEventos.Add(pEvento);
        }

        /// <summary>
        /// Obtiene un evento por su id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Evento ObtenerPorId(int pId)
        {
            if (pId < 0)
            {
                throw new IdNegativoException("no se puede buscar un evento con un id negativo");
            }
            return this.iEventos.Find(x => x.IdEvento == pId);
        }

        /// <summary>
        /// Obtiene todos los eventos de un calendario
        /// </summary>
        /// <returns></returns>
        public List<Evento> ObtenerTodos()
        {
            return iEventos;
        }

        /// <summary>
        /// Obtiene todos los eventos que ocurren un determiado dia de la semana
        /// </summary>
        /// <param name="pDia"></param>
        /// <returns></returns>
        public List<Evento> ObtenerPorDiaSemana(int pDia)
        {
            List<Evento> resultado = new List<Evento>();
            foreach (Evento evt in this.iEventos)
            {
                if (evt.OcurreEnElDiaSemana(pDia))
                {
                    resultado.Add(evt);
                }
            }

            return resultado;
        }

        /// <summary>
        /// Obtiene todos los eventos que se repiten con una frecuencia pFrecuencia
        /// </summary>
        /// <param name="pFrecuencia"></param>
        /// <returns></returns>
        public List<Evento> ObtenerPorFrecuencia(Evento.Frecuencia pFrecuencia)
        {
            List<Evento> resultado = new List<Evento>();
            foreach (Evento evt in this.iEventos)
            {
                if (evt.FrecuenciaRepeticion == pFrecuencia)
                {
                    resultado.Add(evt);
                }
            }
            return resultado;
        }

        /// <summary>
        /// Obtiene todos los eventos que ocurren un dia del mes
        /// </summary>
        /// <param name="pDia"></param>
        /// <returns></returns>
        public List<Evento> ObtenerPorDiaMes(int pDia)
        {
            List<Evento> resultado = new List<Evento>();
            foreach (Evento evt in this.iEventos)
            {
                if (evt.OcurreEnElDiaMes(pDia))
                {
                    resultado.Add(evt);
                }
            }
            return resultado;
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

