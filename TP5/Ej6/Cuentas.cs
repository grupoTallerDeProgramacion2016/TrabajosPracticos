using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
   public class Cuentas
    {
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;
        private Cliente iCliente;

        public Cuentas()
        {
            iCuentaCorriente = new Cuenta(0, 1000);
            iCajaAhorro = new Cuenta(0, 1000);
        }

        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
        }

        public Cuenta CuentaCajaAhorro
        {
            get { return this.iCajaAhorro; }
        }

    }
}
