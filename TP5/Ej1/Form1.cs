using System;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este metodo imprime un mensaje cuando cualquiera de los botones es presionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonPresionado(object sender, EventArgs e)
        {
            var botonPresionado = sender as Button;
            MessageBox.Show("Se ha presionado el " + botonPresionado.Text);
        }

    }
}
