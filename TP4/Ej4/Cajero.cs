using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Cajero
    {
        Cuenta cuenta1 = null;
        Cuenta cuenta2 = null;
        Cuentas cuentas = null;
        byte cuentaSelec = 0;

        public Cuentas Cuentas
        {
            set { this.cuentas = value; }
        }

        /// <summary>
        /// Deposita el monto ingresado en la cuenta
        /// </summary>
        /// <param name="saldo"> Dinero a depositar </param>
        public void AcreditarSaldo(double saldo)
        {
            cuenta1.AcreditarSaldo(saldo);
        }

        /// <summary>
        /// Extrae el dinero solicitado de la cuenta, si no es posible devuelve false
        /// </summary>
        /// <param name="debito"> Dinero a extraer </param>
        /// <returns> Booleano que representa el exito de la extraccion </returns>
        public void DebitarSaldo(double debito)
        {
            cuenta1.DebitarSaldo(debito);
        }

        /// <summary>
        /// Consulta el saldo disponible en la cuenta
        /// </summary>
        /// <returns> Saldo disponible </returns>
        public double ObtenerSaldo()
        {
            return cuenta1.Saldo;
        }

        /// <summary>
        /// Transfiere un monto desde la cuenta seleccionada hacia la otra cuenta del usuario
        /// </summary>
        /// <param name="monto"> Monto a transferir </param>
        /// <returns> Booleano que representa el exito de la transaccion </returns>
        public void Transferir(double monto)
        {

            cuenta1.DebitarSaldo(monto);
            cuenta2.AcreditarSaldo(monto);
        }

        /// <summary>
        /// selecciona una de las cuentas disponibles para realizar las operaciones del cajero:
        ///  *1: selecciona la cuenta corriente
        ///  *2: selecciona la caja de ahorro
        /// </summary>
        /// <param name="seleccion"> Seleccion ingresada </param>
        public void SeleccionarCuenta(byte seleccion)
        {
            cuentaSelec = seleccion;
            if (cuentaSelec == 1)
            {
                cuenta1 = cuentas.CuentaCorriente;
                cuenta2 = cuentas.CuentaCajaAhorro;
            }
            else if (cuentaSelec == 2)
            {
                cuenta1 = cuentas.CuentaCajaAhorro;
                cuenta2 = cuentas.CuentaCorriente;
            }
        }
    }
}
