using Ej2.Domain;
using Ej2.Logic;
using System;
using System.Windows.Forms;

namespace Ej2.UI
{
    public partial class VistaCliente : Form
    {
        private Client iCliente;
        private Fachada fachada;

        public VistaCliente(Client pCliente = null)
        {
            InitializeComponent();
            this.iCliente = pCliente;
            this.button_Guardar.Enabled = false;
            this.textBox_Id.Enabled = false;
            MostrarCliente();
        }

        private void MostrarCliente()
        {
            if (this.iCliente != null)
            {
                this.textBox_Id.Text = this.iCliente.Id.ToString();
                this.textBox_Nombre.Text = this.iCliente.FirstName;
                this.textBox_Apellido.Text = this.iCliente.LastName;
                this.textBox_NDocumento.Text = this.iCliente.Document.Number;
                this.comboBox_TDocumento.SelectedIndex = this.iCliente.Document.Type.GetHashCode();
            }
            else
            {
                this.iCliente = new Domain.Client();
            }
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            this.iCliente.FirstName = this.textBox_Nombre.Text;
            this.iCliente.LastName = this.textBox_Apellido.Text;
            this.iCliente.Document.Number = this.textBox_NDocumento.Text;
            this.iCliente.Document.Type = (DocumentType)this.comboBox_TDocumento.SelectedIndex;

            if (this.iCliente == null)
            {
                fachada.CrearCliente(this.iCliente);
            }
            else
            {
                fachada.ModificarCliente(this.iCliente);
            }

            this.Close();
        }
    }
}
