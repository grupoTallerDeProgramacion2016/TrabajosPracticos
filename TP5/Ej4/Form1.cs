using System;
using System.Windows.Forms;

namespace Ej4
{
    public partial class Form1 : Form
    {
        int cuenta = 0;
        string[] array = new string[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            array[cuenta++] = boton.Text;
            textBox1.Lines = array;

        }
    }
}
