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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El estado del " + radioButton1.Text + " es " + radioButton1.Checked + " El estado del " + radioButton2.Text + " es " + radioButton2.Checked + " El estado del " + radioButton3.Text + " es " + radioButton3.Checked + " El estado del " + checkBox1.Text + " es " + checkBox1.Checked + " El estado del " + radioButton2.Text + " es " + radioButton2.Checked);
        }
    }
}
