using Ej2.Domain;
using Ej2.DTO;
using Ej2.Logic;
using System;
using System.Windows.Forms;

namespace Ej2.UI
{
    public partial class VistaCliente : Form
    {
        private ClientDTO iCliente;
        private Fachada iFachada;

        public VistaCliente(Fachada pFachada, ClientDTO pCliente = null)
        {
            InitializeComponent();
            this.iFachada = pFachada;
            this.iCliente = pCliente;
            this.textBox_Id.Enabled = false;
            this.comboBox_TDocumento.SelectedIndex = 1;
            MostrarCliente();
        }

        /// <summary>
        /// Carga los datos del cliente en la pantalla
        /// </summary>
        private void MostrarCliente()
        {
            if (this.iCliente == null)
            {
                this.iCliente = new ClientDTO();
            }
            else
            {
                this.textBox_Id.Text = this.iCliente.Id.ToString();
            }
            this.textBox_Nombre.Text = this.iCliente.FirstName;
            this.textBox_Apellido.Text = this.iCliente.LastName;
            this.textBox_NDocumento.Text = this.iCliente.DocumentNumber;
            this.comboBox_TDocumento.SelectedIndex = this.iCliente.DocumentType.GetHashCode();
        }

        /// <summary>
        /// Guarda los datos del cliente, o los crea si es que no posee id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Guardar_Click(object sender, EventArgs e)
        {
            this.iCliente.FirstName = this.textBox_Nombre.Text;
            this.iCliente.LastName = this.textBox_Apellido.Text;
            this.iCliente.DocumentNumber = this.textBox_NDocumento.Text;
            this.iCliente.DocumentType = (DocumentType)this.comboBox_TDocumento.SelectedIndex;

            if (this.iCliente.Id > 0)
            {
                try
                {
                    iFachada.Cliente.ModificarCliente(this.iCliente);
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
                    iFachada.Cliente.CrearCliente(this.iCliente);
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
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
