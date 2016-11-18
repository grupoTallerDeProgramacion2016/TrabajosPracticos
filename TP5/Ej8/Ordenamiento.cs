using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ej8
{
    public partial class Ordenamiento : Form
    {
        private RepositorioIList rep;

        public Ordenamiento(RepositorioIList prep)
        {
            InitializeComponent();
            rep = prep;
            comboBoxBusqueda.SelectedIndex = 0;
            comboBoxOrdenamiento.SelectedIndex = 0;
        }

        private void txtBtnCodigo_Click(object sender, EventArgs e)
        {



        }

        /// <summary>
        /// este metodo actualiza el datagrid con la busqueda ingresada por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                List<Usuario> usu = rep.ObtenerTodos();
                table.DataSource = usu;
            }
            else
            {
                switch (comboBoxBusqueda.SelectedIndex)
                {
                    //buscar por codigo
                    case 0:
                        Usuario usu = rep.ObtenerPorCodigo(txtCodigo.Text);
                        table.DataSource = new List<Usuario>() { usu };
                        break;
                    //buscar por nombre completo
                    case 1:
                        var usus = rep.BuscarPorAproximacion(txtCodigo.Text);
                        table.DataSource = usus;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Este metodo carga el datagrid con todos los usuarios con el ordenamiento elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambioOrdenamiento(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            List<Usuario> usus;
            switch (comboBoxOrdenamiento.SelectedIndex)
            {
                //ordenar por codigo ascendente
                case 0:
                    usus = rep.ObtenerOrdenadoPor(new RepositorioIList.OrdenCodigoAscendente());
                    table.DataSource = usus;
                    break;
                //ordenar por codigo descendente
                case 1:
                    usus = rep.ObtenerOrdenadoPor(new RepositorioIList.OrdenCodigoDescendente());
                    table.DataSource = usus;
                    break;
                //ordenar por correo electronico
                case 3:
                    usus = rep.ObtenerOrdenadoPor(new RepositorioIList.OrdenCorreoElectronico());
                    table.DataSource = usus;
                    break;
                default:
                    break;
            }
        }
    }
}
