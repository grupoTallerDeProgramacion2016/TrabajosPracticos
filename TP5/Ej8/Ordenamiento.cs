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
    public partial class Ordenamiento : Form
    {
        RepositorioIList rep;
        public Ordenamiento(RepositorioIList prep)
        {
            InitializeComponent();
            rep = prep;
        }

        private void txtBtnCodigo_Click(object sender, EventArgs e)
        {
            
            Usuario usu = rep.ObtenerPorCodigo(txtCodigo.Text);
            table.DataSource = usu;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Usuario> usu = rep.ObtenerTodos();

            table.DataSource = usu;
        }
    }
}
