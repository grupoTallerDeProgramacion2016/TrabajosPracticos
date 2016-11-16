using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej8
{
    public partial class ABMUsuario : Form
    {
        RepositorioIList rep;
        public ABMUsuario(RepositorioIList prep)
        {
            InitializeComponent();
            btnactualizar.Enabled = false;
            btnEliminar.Enabled = false;
            rep = prep;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            Usuario us = new Usuario();
            us.Codigo = txtCodigo.Text;
            us.NombreCompleto = txtNombreCompleto.Text;
            us.CorreoElectronico = txtCorreoElectronico.Text;
            rep.Agregar(us);
            MessageBox.Show("Se guardo correctamente el nuevo usuario");
            txtCodigo.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreoElectronico.Text = "";
         }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
           
            Usuario us = new Usuario();
            us.Codigo = txtCodigo.Text;
            us.NombreCompleto = txtNombreCompleto.Text;
            us.CorreoElectronico = txtCorreoElectronico.Text;
            rep.Actualizar(us);
            MessageBox.Show("Se actualizo correctamente el nuevo usuario");
            txtCodigo.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreoElectronico.Text = "";
            btnactualizar.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

            

            Usuario us = rep.ObtenerPorCodigo(txtCodigo.Text);
            if (us != null) { 

                txtNombreCompleto.Text = us.NombreCompleto;
                txtCorreoElectronico.Text = us.CorreoElectronico;
                btnactualizar.Enabled = true;
            }   
                
            else
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                           
            rep.Eliminar(txtCodigo.Text);
            MessageBox.Show("Se elimino correctamente el nuevo usuario");
            txtCodigo.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreoElectronico.Text = "";
            }else
            {
                MessageBox.Show("Por favor ingrese el codigo de usuario a eliminar");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
