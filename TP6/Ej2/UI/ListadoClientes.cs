using Ej2.DTO;
using Ej2.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ej2.UI
{
    public partial class ListadoClientes : Form
    {
        private Fachada iFachada;

        public ListadoClientes(Fachada pFachada)
        {
            InitializeComponent();
            this.iFachada = pFachada;
            this.dataGridView_Clientes.AutoGenerateColumns = false;
            RefrescarListado();
        }

        /// <summary>
        /// Refresca el listado de clientes que se muestra en pantalla
        /// </summary>
        private void RefrescarListado()
        {
            dataGridView_Clientes.DataSource = iFachada.Cliente.ObtenerTodos();
        }

        /// <summary>
        /// Realiza la busqueda cada vez que se cambia el campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BuscarId(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(((TextBox)sender).Text))
                {
                    RefrescarListado();
                }
                else
                {
                    var busqueda = Convert.ToInt32(((TextBox)sender).Text);
                    var lista = new List<ClientDTO>();
                    lista.Add(iFachada.Cliente.ObtenerCliente(busqueda));
                    dataGridView_Clientes.DataSource = lista;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! ocurrio un error en la busqueda\n" +
                                 "error: " + ex.Message);
            }
        }

        /// <summary>
        /// Abre una nueva vista cliente para poder realizar la modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Modificar_Click(object sender, EventArgs e)
        {
            var vistaCliente = new VistaCliente(iFachada, (ClientDTO)dataGridView_Clientes.SelectedRows[0].DataBoundItem);
            vistaCliente.ShowDialog(this);
            RefrescarListado();
        }

        /// <summary>
        /// Elimina al cliente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Esta seguro de eliminar al cliente?", "Eliminar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    iFachada.Cliente.EliminarCliente(((ClientDTO)dataGridView_Clientes.SelectedRows[0].DataBoundItem));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! no se ha podido eliminar el cliente\n" +
                                "error: " + ex.Message);
            }
            finally
            {
                RefrescarListado();
            }

        }
    }
}
