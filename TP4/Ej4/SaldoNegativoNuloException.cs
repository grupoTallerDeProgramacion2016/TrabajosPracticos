namespace Ej4
{
    class SaldoNegativoNuloException : CuentaException
    {

        /// <summary>
        /// Esta excepcion debe ser lanzada si el saldo ingresado es negativo
        /// </summary>
        /// <param name="pMensaje"></param>
        public SaldoNegativoNuloException(string pMensaje) : base(pMensaje)
        {
        }
    }
}
