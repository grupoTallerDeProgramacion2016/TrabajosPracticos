using System;
using System.Windows.Forms;

namespace Ej4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este metodo obtiene el texto del boton que fue presionado y lo agrega
        /// al textbox insertando un salto de linea al final
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            textBox1.Text += boton.Text + System.Environment.NewLine;

        }
    }
}
