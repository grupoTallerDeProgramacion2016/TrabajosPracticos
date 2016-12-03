using Ej2.DTO;
using Ej2.Logic;
using System;
using System.Windows.Forms;

namespace Ej2.UI
{
    public partial class PantallaMovimientos : Form
    {
        private Fachada iFachada;
        private AccountDTO iAccount;

        public PantallaMovimientos(Fachada pFachada, AccountDTO pAccount)
        {
            InitializeComponent();
            iFachada = pFachada;
            iAccount = pAccount;
            dataGridView1.DataSource = pFachada.Cuenta.ObtenerUltimosMovimientos(pAccount);
        }

        /// <summary>
        /// Actualiza la cantidad de movimientos con la entrada del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Actualizar_Click(object sender, System.EventArgs e)
        {
            try
            {
                var cantidad = Convert.ToInt16(textBox_Cantidad.Text);
                dataGridView1.DataSource = iFachada.Cuenta.ObtenerUltimosMovimientos(iAccount, cantidad);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Formato incorrecto de cantidad");
            }
        }
    }
}
