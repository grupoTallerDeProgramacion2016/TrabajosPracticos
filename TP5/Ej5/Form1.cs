using System;
using System.Windows.Forms;

namespace Ej5
{
    public partial class Form1 : Form
    {


        private Fachada fachada = new Fachada();

        public Form1()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Este metodo se encarga de interactuar con la fachada para realizar las 
        /// operaciones sobre el circulo o triangulo con los parametros ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hacerAritmetica_Click(object sender, EventArgs e)
        {
            if (radioCirculo.Checked)
            {
                //Utilizamos un try catch para asegurarnos de que no se cierre la aplicacion 
                //a causa de errores en el ingreso de datos por parte del usuario
                try
                {
                    //En esta parte del codigo podemos identificar claramente la ventaja de implementar
                    //el patron fachada para exponer la funcionalidad del calculo del area y el perimetro
                    //ya que con unas pocas lineas de codigo ya funciona con una interfaz grafica
                    var pX = Convert.ToDouble(pXCirculo.Text);
                    var pY = Convert.ToDouble(pYCirculo.Text);
                    var pR = Convert.ToDouble(pRadio.Text);
                    textPerimetro.Text = Convert.ToString(fachada.CalcularPerimetroCirculo(pX, pY, pR));
                    textArea.Text = Convert.ToString(fachada.CalcularAreaCirculo(pX, pY, pR));
                }
                catch (Exception)
                {
                    MessageBox.Show("Ups! Ingresaste mal algun parametro\n o te ha faltado alguno :(");
                    LimpiarParametros();
                }

            }
            else
            {
                if (radioTriangulo.Checked)
                {
                    try
                    {
                        var pX1 = Convert.ToDouble(trianguloPx1.Text);
                        var pY1 = Convert.ToDouble(trianguloPy1.Text);
                        var pX2 = Convert.ToDouble(trianguloPx2.Text);
                        var pY2 = Convert.ToDouble(trianguloPy2.Text);
                        var pX3 = Convert.ToDouble(trianguloPx3.Text);
                        var pY3 = Convert.ToDouble(trianguloPy3.Text);
                        textPerimetro.Text = Convert.ToString(fachada.CalcularPerimetroTriangulo(pX1, pY1, pX2, pY2, pX3, pY3));
                        textArea.Text = Convert.ToString(fachada.CalcularAreaTriangulo(pX1, pY1, pX2, pY2, pX3, pY3));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ups! Ingresaste mal algun parametro\n o te ha faltado alguno :(");
                        LimpiarParametros();
                    }

                }
            }
        }

        /// <summary>
        /// Hace solamente visible el group box que contiene la entrada para los parametros del circulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioCirculo_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCirculo.Visible = true;
            groupBoxTriangulo.Visible = false;
        }

        /// <summary>
        /// Hace solamente visible el group box que contiene la entrada para los parametros del triangulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCirculo.Visible = false;
            groupBoxTriangulo.Visible = true;
        }

        /// <summary>
        /// Limpia los parametros de la pantalla
        /// </summary>
        private void LimpiarParametros()
        {
            trianguloPx1.Text = "";
            trianguloPx2.Text = "";
            trianguloPx3.Text = "";
            trianguloPy1.Text = "";
            trianguloPy2.Text = "";
            trianguloPy3.Text = "";
            pRadio.Text = "";
            pXCirculo.Text = "";
            pYCirculo.Text = "";
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
