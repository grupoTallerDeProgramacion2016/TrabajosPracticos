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
    public partial class MenuPrincipal : Form
    {
        public static byte opcion = 0;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCuentaCorriente_Click(object sender, EventArgs e)
        {
            opcion = 1;
            ManejoCuenta man = new ManejoCuenta();
            man.Show();
           
           
        }

        private void btnCajaAhorro_Click(object sender, EventArgs e)
        {
            opcion = 2;
            ManejoCuenta man = new ManejoCuenta();
            man.Show();
          
        }


    }
}
