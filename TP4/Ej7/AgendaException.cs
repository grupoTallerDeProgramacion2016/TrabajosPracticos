using System;

namespace Ej7
{
    /// <summary>
    /// Excepcion que abarca a todas las excepciones lanzadas desde la aplicacion de la agenda
    /// </summary>
    public class AgendaException : Exception
    {

        public AgendaException(string pMensaje) : base(pMensaje)
        { }
    }
}
