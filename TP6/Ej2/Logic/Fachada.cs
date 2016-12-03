using Ej2.DAL.EntityFramework;

namespace Ej2.Logic
{
    /// <summary>
    /// Clase Fachada que expone la funcionalidad del sistema
    /// </summary>
    public class Fachada
    {
        /// <summary>
        /// Clases que aislan la funcionalidad de cada entidad
        /// </summary>
        private OperacionesCliente iCliente;
        private OperacionesCuenta iCuenta;

        /// <summary>
        /// Crea una fachada con una clase Uof
        /// </summary>
        /// <param name="pUnitOfWork"></param>
        public Fachada(UnitOfWork pUnitOfWork)
        {
            this.iCliente = new OperacionesCliente(pUnitOfWork);
            this.iCuenta = new OperacionesCuenta(pUnitOfWork);
        }

        public OperacionesCliente Cliente { get { return this.iCliente; } }
        public OperacionesCuenta Cuenta { get { return this.iCuenta; } }
    }
}
