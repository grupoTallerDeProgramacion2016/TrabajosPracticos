using System.Collections.Generic;

namespace Ej7
{
    /// <summary>
    /// Clase que representa la lógica del ejercicio (facade)
    /// </summary>
    public class Agenda
    {
        List<Calendario> iCalendarios;

        public Agenda()
        {
            iCalendarios = new List<Calendario>();
        }

        public void AgregarCalendario(Calendario pCalendario)
        {
            iCalendarios.Add(pCalendario);
        }

        public void ModificarCalendario(Calendario pCalendario)
        {
            iCalendarios.Remove(pCalendario);
            iCalendarios.Add(pCalendario);
        }

        public void EliminarCalendario(Calendario pCalendario)
        {
            iCalendarios.Remove(pCalendario);
        }

        public List<Calendario> ObtenerTodos()
        {
            return this.iCalendarios;
        }

    }
}
