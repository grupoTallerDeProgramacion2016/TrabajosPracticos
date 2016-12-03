using Ej2.DAL.EntityFramework;
using Ej2.Logic;
using System.Windows.Forms;

namespace Ej2.UI
{
    public partial class MenuAdmin : Form
    {
        protected UnitOfWork iUnitOfWork;
        protected Fachada iFachada;

        public MenuAdmin()
        {
            InitializeComponent();
            this.iUnitOfWork = new UnitOfWork(new AccountManagerDbContext());
            this.iFachada = new Fachada(this.iUnitOfWork);
        }

        /// <summary>
        /// Abre la ventana para crear un nuevo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crearToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var vistaCliente = new VistaCliente(iFachada);
            vistaCliente.ShowDialog(this);
        }

        /// <summary>
        /// Abre una ventana con el listado de todos los clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listadoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var listadoCliente = new ListadoClientes(iFachada);
            listadoCliente.ShowDialog(this);
        }

        /// <summary>
        /// Abre la ventana para crear una nueva cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crearToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var vistaCuenta = new VistaCuenta(iFachada);
            vistaCuenta.ShowDialog(this);
        }

        /// <summary>
        /// Abre una ventana con el listado de todas las cuentas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listadoToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var listadoCuentas = new ListadoCuentas(iFachada);
            listadoCuentas.ShowDialog(this);
        }

        /// <summary>
        /// Procedimiento que guarda los cambios por las dudas y cierra la unidad de trabajo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.iUnitOfWork.Complete();
            this.iUnitOfWork.Dispose();
        }

        /// <summary>
        /// Abre una ventana "cajero". Seria una funcionalidad aparte
        /// pero la agregamos aca para las pruebas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ingresarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var cajero = new PantallaCajero();
            cajero.Show(this);
        }
    }
}
