using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    public class SaldoInsuficienteException : CuentaException
    {

        /// <summary>
        /// Esta excepcion debe ser lanzada si no se posee saldo sufieciente para realizar un debito
        /// </summary>
        /// <param name="pMensaje"></param>
        public SaldoInsuficienteException(string pMensaje) : base(pMensaje)
        {
        }
    }
}
