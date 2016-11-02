using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class AcuerdoSuperadoException : CuentaException
    {
        /// <summary>
        /// Esta excepcion debe ser lanzada si el saldo debitado supera el acuerdo de la cuenta
        /// </summary>
        /// <param name="pMensaje"></param>
        public AcuerdoSuperadoException(string pMensaje) : base(pMensaje)
        {
        }
    }
}
