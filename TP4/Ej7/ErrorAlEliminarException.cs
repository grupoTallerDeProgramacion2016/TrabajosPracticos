namespace Ej7
{
    /// <summary>
    /// Esta excepcion se produce cuando no se ejecuto correctamente una eliminacion
    /// de algun objeto de la agenda
    /// </summary>
    public class ErrorAlEliminarException : AgendaException
    {
        
        public ErrorAlEliminarException(string pMensaje) : base(pMensaje)
        {
        }
    }
}
