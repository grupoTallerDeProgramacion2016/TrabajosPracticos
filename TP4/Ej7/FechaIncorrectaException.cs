namespace Ej7
{
    /// <summary>
    /// Esta excepcion es lanzada si la del evento fecha es menor a la fecha actual
    /// </summary>
    public class FechaIncorrectaException : AgendaException
    {
        public FechaIncorrectaException(string pMensaje) : base(pMensaje)
        {
        }

    }

}
