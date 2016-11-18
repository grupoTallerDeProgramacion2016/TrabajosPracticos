using System;
using System.Windows.Forms;

namespace Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este metodo se ejecuta al presionar el boton y muestra el estado de 
        /// todos los componentes que se muestran en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" El estado del " + radioButton1.Text + " es " + radioButton1.Checked + "\n" +
                            " El estado del " + radioButton2.Text + " es " + radioButton2.Checked + "\n" +
                            " El estado del " + radioButton3.Text + " es " + radioButton3.Checked + "\n" +
                            " El estado del " + checkBox1.Text + " es " + checkBox1.Checked + "\n" +
                            " El estado del " + checkBox2.Text + " es " + checkBox2.Checked);
        }

    }
}
