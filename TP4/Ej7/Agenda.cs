using System.Collections.Generic;

namespace Ej7
{

    public class Agenda
    {
        List<Calendario> iCalendarios;

        public Agenda()
        {
            iCalendarios = new List<Calendario>();
        }

        /// <summary>
        /// Agrega un calendario a la agenda
        /// </summary>
        /// <param name="pCalendario"></param>
        public void AgregarCalendario(Calendario pCalendario)
        {
            iCalendarios.Add(pCalendario);
        }

        /// <summary>
        /// Modifica un calendario con otro que se le pasa como parametro
        /// </summary>
        /// <param name="pCalendario"></param>
        public void ModificarCalendario(Calendario pCalendario)
        {
            if (!iCalendarios.Remove(pCalendario))
            {
                throw new ErrorAlModificarException("el calendario que desea modificar no se encuentra o se ha producido un" +
                                                        " error al intentar modificarlo");
            }
            iCalendarios.Add(pCalendario);
        }

        /// <summary>
        /// Elimina a un calendario 
        /// </summary>
        /// <param name="pCalendario"></param>
        public void EliminarCalendario(Calendario pCalendario)
        {
            if (!iCalendarios.Remove(pCalendario))
            {
                throw new ErrorAlEliminarException("el calendario que desea eliminar no se encuentra o se ha producido un" +
                                                        " error al intentar eliminarlo");
            }
        }

        /// <summary>
        /// Obtiene a todos los calendarios de la agenda
        /// </summary>
        /// <returns></returns>
        public List<Calendario> ObtenerTodos()
        {
            return this.iCalendarios;
        }

        /// <summary>
        /// Obtiene un calendario por su id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Calendario ObtenerPorId(int pId)
        {
            if (pId < 0)
            {
                throw new IdNegativoException("no se puede buscar un calendario con un id negativo");
            }
            return this.iCalendarios.Find(x => x.IdCalendario == pId);
        }
    }
}
