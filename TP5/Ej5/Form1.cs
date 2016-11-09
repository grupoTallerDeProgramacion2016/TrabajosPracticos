using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej5
{
    public partial class Form1 : Form
    {


        private Fachada fachada= new Fachada();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hacerAritmetica_Click(object sender, EventArgs e)
        {
            if (radioCirculo.Checked)
            {
                var pX = Convert.ToDouble(pXCirculo.Text);
                var pY = Convert.ToDouble(pYCirculo.Text);
                var pR = Convert.ToDouble(pRadio.Text);
                textPerimetro.Text = Convert.ToString(fachada.CalcularPerimetroCirculo(pX,pY,pR));
                textArea.Text = Convert.ToString(fachada.CalcularAreaCirculo(pX, pY, pR));
            }
            else
            {
                if (radioTriangulo.Checked)
                {
                    var pX1 = Convert.ToDouble(pXTriangulo1.Text);
                    var pX2 = Convert.ToDouble(pXTriangulo2.Text);
                    var pY1 = Convert.ToDouble(pYTriangulo1.Text);
                    var pY2 = Convert.ToDouble(pYTriangulo2.Text);
                    var pZ1 = Convert.ToDouble(pZTriangulo1.Text);
                    var pZ2 = Convert.ToDouble(pZTriangulo2.Text);
                    textPerimetro.Text = Convert.ToString(fachada.CalcularPerimetroTriangulo(pX1, pX2,pY1, pY2,pZ1, pZ2));
                    textArea.Text = Convert.ToString(fachada.CalcularAreaTriangulo(pX1, pX2, pY1, pY2, pZ1, pZ2));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
