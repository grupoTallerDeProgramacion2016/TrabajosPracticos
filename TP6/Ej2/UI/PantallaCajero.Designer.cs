namespace Ej2.UI
{
    partial class PantallaCajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Ingreso = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IngresoId = new System.Windows.Forms.TextBox();
            this.button_Ingreso = new System.Windows.Forms.Button();
            this.groupBox_Cajero = new System.Windows.Forms.GroupBox();
            this.label_Balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Transferencia = new System.Windows.Forms.Button();
            this.button_Retiro = new System.Windows.Forms.Button();
            this.button_Ultimos = new System.Windows.Forms.Button();
            this.button_Deposito = new System.Windows.Forms.Button();
            this.groupBox_Operacion = new System.Windows.Forms.GroupBox();
            this.button_Realizar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.textBox_Monto = new System.Windows.Forms.TextBox();
            this.groupBox_Ingreso.SuspendLayout();
            this.groupBox_Cajero.SuspendLayout();
            this.groupBox_Operacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Ingreso
            // 
            this.groupBox_Ingreso.Controls.Add(this.label1);
            this.groupBox_Ingreso.Controls.Add(this.textBox_IngresoId);
            this.groupBox_Ingreso.Controls.Add(this.button_Ingreso);
            this.groupBox_Ingreso.Location = new System.Drawing.Point(103, 45);
            this.groupBox_Ingreso.Name = "groupBox_Ingreso";
            this.groupBox_Ingreso.Size = new System.Drawing.Size(420, 171);
            this.groupBox_Ingreso.TabIndex = 0;
            this.groupBox_Ingreso.TabStop = false;
            this.groupBox_Ingreso.Text = "Ingreso al cajero";
            this.groupBox_Ingreso.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ingresa el id de tu cuenta";
            // 
            // textBox_IngresoId
            // 
            this.textBox_IngresoId.Location = new System.Drawing.Point(144, 82);
            this.textBox_IngresoId.Name = "textBox_IngresoId";
            this.textBox_IngresoId.Size = new System.Drawing.Size(143, 20);
            this.textBox_IngresoId.TabIndex = 1;
            // 
            // button_Ingreso
            // 
            this.button_Ingreso.Location = new System.Drawing.Point(179, 120);
            this.button_Ingreso.Name = "button_Ingreso";
            this.button_Ingreso.Size = new System.Drawing.Size(75, 23);
            this.button_Ingreso.TabIndex = 0;
            this.button_Ingreso.Text = "Ingresar";
            this.button_Ingreso.UseVisualStyleBackColor = true;
            this.button_Ingreso.Click += new System.EventHandler(this.button_Ingreso_Click);
            // 
            // groupBox_Cajero
            // 
            this.groupBox_Cajero.Controls.Add(this.label_Balance);
            this.groupBox_Cajero.Controls.Add(this.label2);
            this.groupBox_Cajero.Controls.Add(this.button_Transferencia);
            this.groupBox_Cajero.Controls.Add(this.button_Retiro);
            this.groupBox_Cajero.Controls.Add(this.button_Ultimos);
            this.groupBox_Cajero.Controls.Add(this.button_Deposito);
            this.groupBox_Cajero.Location = new System.Drawing.Point(103, 45);
            this.groupBox_Cajero.Name = "groupBox_Cajero";
            this.groupBox_Cajero.Size = new System.Drawing.Size(420, 238);
            this.groupBox_Cajero.TabIndex = 1;
            this.groupBox_Cajero.TabStop = false;
            this.groupBox_Cajero.Text = "Cajero";
            // 
            // label_Balance
            // 
            this.label_Balance.AutoSize = true;
            this.label_Balance.Location = new System.Drawing.Point(220, 205);
            this.label_Balance.Name = "label_Balance";
            this.label_Balance.Size = new System.Drawing.Size(0, 13);
            this.label_Balance.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balance de la cuenta: ";
            // 
            // button_Transferencia
            // 
            this.button_Transferencia.Location = new System.Drawing.Point(100, 105);
            this.button_Transferencia.Name = "button_Transferencia";
            this.button_Transferencia.Size = new System.Drawing.Size(246, 37);
            this.button_Transferencia.TabIndex = 0;
            this.button_Transferencia.Text = "Transferencia";
            this.button_Transferencia.UseVisualStyleBackColor = true;
            this.button_Transferencia.Click += new System.EventHandler(this.button_Transferencia_Click);
            // 
            // button_Retiro
            // 
            this.button_Retiro.Location = new System.Drawing.Point(100, 62);
            this.button_Retiro.Name = "button_Retiro";
            this.button_Retiro.Size = new System.Drawing.Size(246, 37);
            this.button_Retiro.TabIndex = 0;
            this.button_Retiro.Text = "Retirar";
            this.button_Retiro.UseVisualStyleBackColor = true;
            this.button_Retiro.Click += new System.EventHandler(this.button_Retiro_Click);
            // 
            // button_Ultimos
            // 
            this.button_Ultimos.Location = new System.Drawing.Point(100, 148);
            this.button_Ultimos.Name = "button_Ultimos";
            this.button_Ultimos.Size = new System.Drawing.Size(246, 37);
            this.button_Ultimos.TabIndex = 0;
            this.button_Ultimos.Text = "Ultimos movimientos";
            this.button_Ultimos.UseVisualStyleBackColor = true;
            this.button_Ultimos.Click += new System.EventHandler(this.button_Ultimos_Click);
            // 
            // button_Deposito
            // 
            this.button_Deposito.Location = new System.Drawing.Point(100, 19);
            this.button_Deposito.Name = "button_Deposito";
            this.button_Deposito.Size = new System.Drawing.Size(246, 37);
            this.button_Deposito.TabIndex = 0;
            this.button_Deposito.Text = "Depositar";
            this.button_Deposito.UseVisualStyleBackColor = true;
            this.button_Deposito.Click += new System.EventHandler(this.button_Deposito_Click);
            // 
            // groupBox_Operacion
            // 
            this.groupBox_Operacion.Controls.Add(this.button_Realizar);
            this.groupBox_Operacion.Controls.Add(this.button_Cancelar);
            this.groupBox_Operacion.Controls.Add(this.label3);
            this.groupBox_Operacion.Controls.Add(this.label_titulo);
            this.groupBox_Operacion.Controls.Add(this.textBox_Monto);
            this.groupBox_Operacion.Location = new System.Drawing.Point(103, 91);
            this.groupBox_Operacion.Name = "groupBox_Operacion";
            this.groupBox_Operacion.Size = new System.Drawing.Size(414, 238);
            this.groupBox_Operacion.TabIndex = 2;
            this.groupBox_Operacion.TabStop = false;
            this.groupBox_Operacion.Text = "Operacion";
            // 
            // button_Realizar
            // 
            this.button_Realizar.Location = new System.Drawing.Point(271, 177);
            this.button_Realizar.Name = "button_Realizar";
            this.button_Realizar.Size = new System.Drawing.Size(103, 23);
            this.button_Realizar.TabIndex = 9;
            this.button_Realizar.Text = "Realizar operacion";
            this.button_Realizar.UseVisualStyleBackColor = true;
            this.button_Realizar.Click += new System.EventHandler(this.button_Realizar_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(53, 177);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 8;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto";
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(181, 46);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(77, 23);
            this.label_titulo.TabIndex = 6;
            this.label_titulo.Text = "label1";
            // 
            // textBox_Monto
            // 
            this.textBox_Monto.Location = new System.Drawing.Point(149, 102);
            this.textBox_Monto.Name = "textBox_Monto";
            this.textBox_Monto.Size = new System.Drawing.Size(175, 20);
            this.textBox_Monto.TabIndex = 5;
            // 
            // PantallaCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 341);
            this.Controls.Add(this.groupBox_Operacion);
            this.Controls.Add(this.groupBox_Cajero);
            this.Controls.Add(this.groupBox_Ingreso);
            this.Name = "PantallaCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaCajero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaCajero_FormClosing);
            this.groupBox_Ingreso.ResumeLayout(false);
            this.groupBox_Ingreso.PerformLayout();
            this.groupBox_Cajero.ResumeLayout(false);
            this.groupBox_Cajero.PerformLayout();
            this.groupBox_Operacion.ResumeLayout(false);
            this.groupBox_Operacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Ingreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_IngresoId;
        private System.Windows.Forms.Button button_Ingreso;
        private System.Windows.Forms.GroupBox groupBox_Cajero;
        private System.Windows.Forms.Label label_Balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Transferencia;
        private System.Windows.Forms.Button button_Retiro;
        private System.Windows.Forms.Button button_Ultimos;
        private System.Windows.Forms.Button button_Deposito;
        private System.Windows.Forms.GroupBox groupBox_Operacion;
        private System.Windows.Forms.Button button_Realizar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.TextBox textBox_Monto;
    }
}