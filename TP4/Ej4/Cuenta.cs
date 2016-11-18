using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    public class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;

        public Cuenta(double pAcuerdo)
        {
            iAcuerdo = pAcuerdo;
            iSaldo = 0;
        }

        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            iSaldo = pSaldoInicial;
            iAcuerdo = pAcuerdo;
        }

        public double Saldo
        {
            get { return this.iSaldo; }
        }

        public double Acuerdo
        {
            get { return this.iAcuerdo; }
        }

        /// <summary>
        /// Permite acreditar saldo a la cuenta, este debe ser mayor a cero
        /// </summary>
        /// <param name="pSaldo"></param>
        public void AcreditarSaldo(double pSaldo)
        {
            if (pSaldo <= 0)
            {
                throw new AcreditacionSaldoException("El saldo que desea depositar es nulo o negativo");
            }
            iSaldo = iSaldo + pSaldo;
        }

        /// <summary>
        /// Permite debitar saldo de la cuenta, este debe ser mayor a cero,
        /// debe ser menor o igual al saldo disponible y debe cumplir con el acuerdo
        /// </summary>
        /// <param name="pSaldo"></param>
        public void DebitarSaldo(double pSaldo)
        {
            if (Saldo <= 0) {
                throw new SaldoNegativoNuloException("El sado que desea retirar es nulo o negativo");
            }
            if (iSaldo <= pSaldo)
            {
                throw new SaldoInsuficienteException("No posee saldo suficiente para realizar la extraccion");
            }
            if (pSaldo >= iAcuerdo)
            {
                throw new AcuerdoSuperadoException("El saldo que desea retirar supera el acuerdo de la cuenta");
            }
            iSaldo -= pSaldo;

        }


    }
}
