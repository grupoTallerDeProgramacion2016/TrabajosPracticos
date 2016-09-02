using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Cuentas
    {
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;
        private Cliente iCliente;

        public Cuentas()
        {
               
        }

        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
            set { this.iCuentaCorriente = value; }
        }

        public Cuenta CuentaCajaAhorro
        {
            get { return this.iCajaAhorro; }
            set { this.iCajaAhorro = value; }
        }
        
    }
}
