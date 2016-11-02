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

        public void AcreditarSaldo(double pSaldo)
        {
            if (pSaldo <= 0)
            {
                throw new ExcepcionSaldoNuloONegativo("El saldo que desea depositar es nulo o negativo");
            }
            iSaldo = iSaldo + pSaldo;
        }

        public void DebitarSaldo(double pSaldo)
        {
            if (iSaldo <= pSaldo)
            {
            }
            if (pSaldo >= iAcuerdo)||)
            {
                throw new ExcepcionCuenta("No se puede realizar esta transaccion :(");

            }
            iSaldo -= pSaldo;

        }


    }
}
