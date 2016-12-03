using Ej2.DTO;
using Ej2.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ej2.UI
{
    public partial class ListadoCuentas : Form
    {
        private Fachada iFachada;

        public ListadoCuentas(Fachada pFachada)
        {
            InitializeComponent();
            this.iFachada = pFachada;
            this.dataGridView_Cuentas.AutoGenerateColumns = false;
            RefrescarListado();
        }

        /// <summary>
        /// Refresca al listado de cuentas que se muestra en pantalla
        /// </summary>
        private void RefrescarListado()
        {
            dataGridView_Cuentas.DataSource = iFachada.Cuenta.ObtenerTodas();
        }

        /// <summary>
        /// Realiza la busqueda por id cada vez que cambia el campo
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
                    var lista = new List<AccountDTO>();
                    lista.Add(iFachada.Cuenta.ObtenerCuenta(busqueda));
                    dataGridView_Cuentas.DataSource = lista;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! ocurrio un error en la busqueda\n" +
                                 "error: " + ex.Message);
            }
        }

        /// <summary>
        /// Abre una nueva vista cuenta para poder modificar la cuenta seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Modificar_Click(object sender, EventArgs e)
        {
            var vistaCuenta = new VistaCuenta(iFachada, (AccountDTO)dataGridView_Cuentas.SelectedRows[0].DataBoundItem);
            vistaCuenta.ShowDialog(this);
            RefrescarListado();
        }

        /// <summary>
        /// Elimina la cuenta seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Esta seguro de eliminar esta cuenta?", "Eliminar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    iFachada.Cuenta.EliminarCuenta((AccountDTO)dataGridView_Cuentas.SelectedRows[0].DataBoundItem);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! no se ha podido eliminar la cuenta\n" +
                                "error: " + ex.Message);
            }
            finally
            {
                RefrescarListado();
            }
        }

        /// <summary>
        /// Carga en la lista las cuentas que se encuentran sobregiradas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Sobregiradas_Click(object sender, EventArgs e)
        {
            dataGridView_Cuentas.DataSource = iFachada.Cuenta.ObtenerCuentasSobregiradas();
        }
    }
}
