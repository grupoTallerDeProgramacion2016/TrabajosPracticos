namespace Ej2
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
            iSaldo = iSaldo + pSaldo;
        }

        public bool DebitarSaldo(double pSaldo)
        {
            if (iSaldo >= pSaldo & pSaldo <= iAcuerdo)
            {
                iSaldo -= pSaldo;
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
