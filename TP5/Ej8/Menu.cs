using System;
using System.Windows.Forms;

namespace Ej8
{
    public partial class Menu : Form
    {
        private RepositorioIList rep;

        public Menu()
        {
            InitializeComponent();
            rep = new RepositorioIList();
        }

        static void Main(String[] arg)
        {
            Application.Run(new Menu());
        }

        /// <summary>
        /// Este metodo abre una ventana para cargar un nuevo usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aBMUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMUsuario abm = new ABMUsuario(rep);
            abm.MdiParent = this;
            abm.Show();
        }

        /// <summary>
        /// Este metodo abre una ventana para buscar usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metodosDeOrdenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordenamiento ord = new Ordenamiento(rep);
            ord.MdiParent = this;
            ord.Show();
        }
    }
}
