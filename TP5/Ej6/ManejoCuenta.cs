using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej6
{
    public partial class ManejoCuenta : Form
    {
        private static Cuentas cuentas = new Cuentas();
        byte seleccionCuenta = 0;
        Cajero caj = new Cajero();
        
        public ManejoCuenta()
        {
            InitializeComponent();
            seleccionCuenta = MenuPrincipal.opcion;
            caj.Cuentas = cuentas;
            caj.SeleccionarCuenta(seleccionCuenta);
            txtSaldo.Text = Convert.ToString(caj.ObtenerSaldo());
            txtSaldo.Enabled = false;
         }
         public bool Validar()
        {
            if (txtDinero.Text == "")
            {
                MessageBox.Show("Error: Campo Dinero vacio :)");
                return false; 
            }
            return true;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                caj.AcreditarSaldo(Convert.ToDouble(txtDinero.Text));
                txtDinero.Text = "";
                txtSaldo.Text = Convert.ToString(caj.ObtenerSaldo());

            }
        }

        private void ManejoCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                caj.DebitarSaldo(Convert.ToDouble(txtDinero.Text));
                txtDinero.Text = "";
                txtSaldo.Text = Convert.ToString(caj.ObtenerSaldo());
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {

            if (Validar())
            {
                caj.Transferir(Convert.ToDouble(txtDinero.Text));
                txtDinero.Text = "";
                txtSaldo.Text = Convert.ToString(caj.ObtenerSaldo());
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
