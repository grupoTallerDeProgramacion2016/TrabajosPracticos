using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
   public class AcreditacionSaldoException : CuentaException
    {

        /// <summary>
        /// Esta excepcion debe ser lanzada ante un error en la acreditacion del saldo
        /// </summary>
        /// <param name="pMensaje"></param>
        public AcreditacionSaldoException(string pMensaje) : base(pMensaje)
        {
        }
    }
}
