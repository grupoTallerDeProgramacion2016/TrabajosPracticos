using System;
using System.Windows.Forms;

namespace Ej6
{
    public partial class ManejoCuenta : Form
    {
        /// <summary>
        /// El campo cuentas static permite que las ventanas que se abren para
        /// el manejo de cuentas compartan la misma informacion
        /// </summary>
        private static Cuentas cuentas = new Cuentas();
        byte seleccionCuenta = 0;
        Cajero caj = new Cajero();

        public ManejoCuenta()
        {
            InitializeComponent();
            //Se obtiene la seleccion que realizo el usuario en el menu principal para 
            //seleccionar la cuenta correspondiente
            seleccionCuenta = MenuPrincipal.opcion;
            caj.Cuentas = cuentas;
            caj.SeleccionarCuenta(seleccionCuenta);
            txtSaldo.Text = Convert.ToString(caj.ObtenerSaldo());
            txtSaldo.Enabled = false;
        }

        /// <summary>
        /// Valida que el campo de texto para ingresar el dinero no este vacio
        /// </summary>
        /// <returns></returns>
        public bool Validar()
        {
            if (txtDinero.Text == "")
            {
                MessageBox.Show("Error: Campo Dinero vacio :)");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Cierra la ventana para regresar al menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Realiza la accion del deposito 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    caj.AcreditarSaldo(Convert.ToDouble(txtDinero.Text));
                }
                catch (CuentaException ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.GetType());
                }
                catch (Exception)
                {
                    MessageBox.Show("Ups! El monto ingresado debe ser un \n numero real.Ej: 12.23");
                }

                txtDinero.Text = "";
                txtSaldo.Text = Convert.ToString(caj.ObtenerSaldo());

            }
        }

        /// <summary>
        /// Realiza una extraccion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    caj.DebitarSaldo(Convert.ToDouble(txtDinero.Text));
                }
                catch (CuentaException ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.GetType());
                }
                catch (Exception)
                {
                    MessageBox.Show("Ups! El monto ingresado debe ser un \n numero real.Ej: 12.23");
                }
                txtDinero.Text = "";
                txtSaldo.Text = Convert.ToString(caj.ObtenerSaldo());
            }
        }

        /// <summary>
        /// Realiza una transferencia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransferir_Click(object sender, EventArgs e)
        {

            if (Validar())
            {
                try
                {
                    caj.Transferir(Convert.ToDouble(txtDinero.Text));
                }
                catch (CuentaException ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.GetType());
                }
                catch (Exception)
                {
                    MessageBox.Show("Ups! El monto ingresado debe ser un \n numero real.Ej: 12.23");
                }
                txtDinero.Text = "";
                txtSaldo.Text = Convert.ToString(caj.ObtenerSaldo());
            }
        }

    }
}
