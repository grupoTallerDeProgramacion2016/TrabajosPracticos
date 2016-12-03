using Ej2.DAL.EntityFramework;
using Ej2.DTO;
using Ej2.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ej2.UI
{
    public partial class PantallaCajero : Form
    {
        protected UnitOfWork iUnitOfWork;
        protected Fachada iFachada;
        private AccountDTO iCuenta;

        public PantallaCajero()
        {
            InitializeComponent();
            this.iUnitOfWork = new UnitOfWork(new AccountManagerDbContext());
            this.iFachada = new Fachada(this.iUnitOfWork);
            groupBox_Ingreso.Visible = true;
            groupBox_Cajero.Visible = false;
            groupBox_Operacion.Visible = false;

        }

        /// <summary>
        /// Realiza la busqueda de la cuenta a la cual se quiere ingresar
        /// y la carga en el cajero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Ingreso_Click(object sender, EventArgs e)
        {
            int id = -1;
            try
            {
                id = Convert.ToInt16(textBox_IngresoId.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El id ingresado no tiene un formato valido");
                return;
            }
            try
            {
                var cuenta = iFachada.Cuenta.ObtenerCuenta(id);
                iCuenta = cuenta;
                groupBox_Ingreso.Visible = false;
                groupBox_Cajero.Visible = true;
                groupBox_Operacion.Visible = false;
                MostrarBalance(iFachada.Cuenta.ObtenerBalance(iCuenta));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! ocurrio un error en la busqueda\n" +
                                 "error: " + ex.Message);
            }

        }

        /// <summary>
        /// Procedimiento que guarda los cambios por las dudas y cierra la unidad de trabajo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PantallaCajero_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.iUnitOfWork.Complete();
            this.iUnitOfWork.Dispose();
        }

        /// <summary>
        /// Muestra el balance de la cuenta en la pantalla con diferentes colores
        /// dependiendo de su valor
        /// </summary>
        /// <param name="pBalance"></param>
        private void MostrarBalance(double pBalance)
        {
            label_Balance.Text = pBalance.ToString();
            if (pBalance > 0)
            {
                label_Balance.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                label_Balance.BackColor = System.Drawing.Color.Red;
            }

        }

        /// <summary>
        /// Activa los componentes para hacer el deposito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Deposito_Click(object sender, EventArgs e)
        {
            groupBox_Operacion.Visible = true;
            groupBox_Cajero.Visible = false;
            label_titulo.Text = "Deposito";

        }

        /// <summary>
        /// Activa los componentes del menu del cajero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            groupBox_Cajero.Visible = true;
            groupBox_Operacion.Visible = false;
            MostrarBalance(iFachada.Cuenta.ObtenerBalance(iCuenta));
        }

        /// <summary>
        /// Ejecuta la operacion que se desea realizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Realizar_Click(object sender, EventArgs e)
        {
            double monto;
            try
            {
                monto = Convert.ToDouble(textBox_Monto.Text);
                if (label_titulo.Text == "Retiro" || label_titulo.Text == "Transferencia")
                {
                    monto = monto * -1;
                }
                iFachada.Cuenta.RegistrarMovimiento(iCuenta, label_titulo.Text, monto);
                groupBox_Cajero.Visible = true;
                groupBox_Operacion.Visible = false;
                MostrarBalance(iFachada.Cuenta.ObtenerBalance(iCuenta));
            }
            catch (Exception)
            {
                MessageBox.Show("El monto ingresado no tiene un formato valido");
                return;
            }
        }

        /// <summary>
        /// Activa los componentes para hacer el Retiro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Retiro_Click(object sender, EventArgs e)
        {
            groupBox_Cajero.Visible = false;
            groupBox_Operacion.Visible = true;
            label_titulo.Text = "Retiro";
        }

        /// <summary>
        /// Activa los componentes para hacer la transferencia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Transferencia_Click(object sender, EventArgs e)
        {
            groupBox_Cajero.Visible = false;
            groupBox_Operacion.Visible = true;
            label_titulo.Text = "Transferencia";
        }

        /// <summary>
        /// Abre una ventana con los ultimos movimientos de la cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Ultimos_Click(object sender, EventArgs e)
        {
            try
            {
                List<AccountMovementDTO> lista = iFachada.Cuenta.ObtenerUltimosMovimientos(iCuenta).ToList();
                var pantallaMovimientos = new PantallaMovimientos(iFachada, iCuenta);
                pantallaMovimientos.ShowDialog(this);
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede obtener la lista de movimientos");
            }
        }
    }
}
