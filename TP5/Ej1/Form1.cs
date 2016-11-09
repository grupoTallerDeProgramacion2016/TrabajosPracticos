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

        private void Boton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el Boton 1");
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el Boton 2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el Boton 3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el Boton 4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el Boton 5");
        }
    }
}
