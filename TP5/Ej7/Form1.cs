using System.Windows.Forms;

namespace Ej7
{
    public partial class Form1 : Form
    {
        private FachadaEncriptador encriptador;

        public Form1()
        {
            InitializeComponent();
            encriptador = new FachadaEncriptador();
            comboBoxMetodo.Items.AddRange(encriptador.ObtenerEncriptadoresDisponibles().ToArray());
        }
    }
}
