using Ej2.DTO;
using Ej2.Logic;
using System;
using System.Windows.Forms;

namespace Ej2.UI
{
    public partial class VistaCuenta : Form
    {

        private Fachada iFachada;
        private AccountDTO iCuenta;

        public VistaCuenta(Fachada pFachada, AccountDTO pCuenta = null)
        {
            InitializeComponent();
            this.iFachada = pFachada;
            this.textBox_Id.Enabled = false;
            this.iCuenta = pCuenta;
            MostrarCuenta();
        }

        /// <summary>
        /// Carga los datos de la cuenta en la ventana
        /// </summary>
        private void MostrarCuenta()
        {
            if (this.iCuenta == null)
            {
                this.iCuenta = new AccountDTO();
            }
            else
            {
                dataGridView_UltimosMovimientos.DataSource = iFachada.Cuenta.ObtenerUltimosMovimientos(this.iCuenta);
                textBox_Id.Text = iCuenta.Id.ToString();
                textBox_Cliente.Text = iCuenta.ClientId.ToString();
            }
            textBox_Name.Text = iCuenta.Name;
            textBox_Descubierto.Text = iCuenta.OverdraftLimit.ToString();
        }

        /// <summary>
        /// Guarda la cuenta, o la crea si no tenia id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Guardar_Click(object sender, EventArgs e)
        {
            this.iCuenta.Name = textBox_Name.Text;
            this.iCuenta.OverdraftLimit = Convert.ToDouble(textBox_Descubierto.Text);
            try
            {
                this.iCuenta.ClientId = Convert.ToInt32(textBox_Cliente.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Escribi bien el id de usuario!!!!");
            }


            if (String.IsNullOrWhiteSpace(textBox_Id.Text))
            {
                try
                {
                    iFachada.Cuenta.CrearCuenta(this.iCuenta);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ups! ocurrio un error!" +
                                    ex.Message);
                }
            }
            else
            {
                try
                {
                    iFachada.Cuenta.ModificarCuenta(this.iCuenta);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ups! ocurrio un error!" +
                                    ex.Message);
                }

            }
        }

        /// <summary>
        /// Sale de la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
