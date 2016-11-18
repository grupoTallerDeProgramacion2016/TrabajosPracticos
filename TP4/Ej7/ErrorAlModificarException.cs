using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    /// <summary>
    /// Esta excepcion se produce cuando no se ejecuto correctamente una
    /// modificacion de algun objeto de la agenda
    /// </summary>
    public class ErrorAlModificarException : AgendaException
    {
        
        public ErrorAlModificarException(string pMensaje) : base(pMensaje)
        {
        }
    }
}
