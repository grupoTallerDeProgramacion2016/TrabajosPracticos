using System;
using System.Windows.Forms;

namespace Ej3
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] traduccion = { "one", "two", "tree", "four", "five", "six", "seven", "eight", "nine", "ten" };

            res.Text = traduccion[(int)comboBox1.SelectedIndex];
        }
    }
}
