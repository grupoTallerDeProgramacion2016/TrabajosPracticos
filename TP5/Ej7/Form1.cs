using System.Windows.Forms;

namespace Ej7
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// fachada para acceder a las funciones de los encriptadores
        /// </summary>
        private FachadaEncriptador encriptador;

        /// <summary>
        /// array de string que contiene los nombres de los encriptadores disponibles
        /// </summary>
        private string[] encriptadores;

        public Form1()
        {
            InitializeComponent();
            encriptador = new FachadaEncriptador();
            encriptadores = encriptador.ObtenerEncriptadoresDisponibles().ToArray();
            comboBoxMetodo.Items.AddRange(encriptadores);
        }

        /// <summary>
        /// Encripta el texto ingresado con el encriptador seleccionado del combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEncriptar_Click(object sender, System.EventArgs e)
        {
            //Bloques para evitar errores inesperados al encriptar
            try
            {
                textBoxSalida.Text = encriptador.Encriptar(encriptadores[comboBoxMetodo.SelectedIndex], textBoxEntrada.Text);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Se ha producido un error en el encriptador\n" +
                    "por favor verifica que hayas ingresado correctamente la cadena");
            }

        }

        /// <summary>
        /// Desencripta el texto ingresado con el encriptador seleccionado del combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDesencriptar_Click(object sender, System.EventArgs e)
        {
            try
            {
                textBoxSalida.Text = encriptador.Desencriptar(encriptadores[comboBoxMetodo.SelectedIndex], textBoxEntrada.Text);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Se ha producido un error en el encriptador\n" +
                    "por favor verifica que hayas ingresado correctamente la cadena");
            }
        }
    }
}
