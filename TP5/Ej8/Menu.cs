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
    public partial class Menu : Form
    {
        RepositorioIList rep;
             
        public Menu()
        {
            InitializeComponent();
            rep = new RepositorioIList();
        }
        static void Main(String[] arg) {
            Application.Run(new Menu());
        }

        private void aBMUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMUsuario abm = new ABMUsuario(rep);
            abm.MdiParent = this;
            abm.Show();
        }

        private void metodosDeOrdenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordenamiento ord = new Ordenamiento(rep);
            ord.MdiParent = this;
            ord.Show();
        }
    }
}
