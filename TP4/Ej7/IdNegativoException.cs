namespace Ej7
{
    /// <summary>
    /// Esta excepcion se produce si se desea buscar un objeto de la agenda
    /// con un id negativo
    /// </summary>
    public class IdNegativoException : AgendaException
    {

        public IdNegativoException(string pMensaje) : base(pMensaje)
        {
        }
    }
}
