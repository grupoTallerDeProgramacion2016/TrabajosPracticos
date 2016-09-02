using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Cajero
    {
        Cuenta cuenta1 = null;
        Cuenta cuenta2 = null;
        Cuentas cuentas = null;
        byte cuentaSelec = 0;

        public Cuentas Cuentas
        {
            set { this.cuentas = value;}
        }


        public void AcreditarSaldo (double saldo)
        {
            cuenta1.AcreditarSaldo(saldo);
        }

        public bool DebitarSaldo (double debito)
        {
            return cuenta1.DebitarSaldo(debito);
        }

        public double ObtenerSaldo()
        {
            return cuenta1.Saldo;
        }

        public bool Transferir(double monto)
        {

            if (cuenta1.DebitarSaldo(monto))
            {
                cuenta2.AcreditarSaldo(monto);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SeleccionarCuenta (byte seleccion)
        {
            cuentaSelec = seleccion;
            if (cuentaSelec == 1)
            {
                cuenta1 = cuentas.CuentaCorriente;
                cuenta2 = cuentas.CuentaCajaAhorro;
            }else if (cuentaSelec == 2)
            {
                cuenta1 = cuentas.CuentaCajaAhorro;
                cuenta2 = cuentas.CuentaCorriente;
            }
        }
    }
}
