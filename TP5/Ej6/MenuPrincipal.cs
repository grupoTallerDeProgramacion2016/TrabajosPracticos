using System;
using System.Windows.Forms;

namespace Ej6
{
    public partial class MenuPrincipal : Form
    {
        /// <summary>
        /// Campo estatico que almacena la opcion del usuario para la cuenta
        /// </summary>
        public static byte opcion = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Abre la ventana de manejo de cuenta con la opcion para cuenta corriente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCuentaCorriente_Click(object sender, EventArgs e)
        {
            opcion = 1;
            ManejoCuenta man = new ManejoCuenta();
            man.ShowDialog(this);


        }

        /// <summary>
        /// Abre la ventana de manejo de cuenta con la opcion para cuenta corriente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCajaAhorro_Click(object sender, EventArgs e)
        {
            opcion = 2;
            ManejoCuenta man = new ManejoCuenta();
            man.ShowDialog(this);

        }

    }
}
