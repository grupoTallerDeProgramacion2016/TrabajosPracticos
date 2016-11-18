namespace Ej6
{
    partial class MenuPrincipal
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
            this.btnCuentaCorriente = new System.Windows.Forms.Button();
            this.btnCajaAhorro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCuentaCorriente
            // 
            this.btnCuentaCorriente.Location = new System.Drawing.Point(38, 63);
            this.btnCuentaCorriente.Name = "btnCuentaCorriente";
            this.btnCuentaCorriente.Size = new System.Drawing.Size(204, 49);
            this.btnCuentaCorriente.TabIndex = 0;
            this.btnCuentaCorriente.Text = "Cuenta Corriente";
            this.btnCuentaCorriente.UseVisualStyleBackColor = true;
            this.btnCuentaCorriente.Click += new System.EventHandler(this.btnCuentaCorriente_Click);
            // 
            // btnCajaAhorro
            // 
            this.btnCajaAhorro.Location = new System.Drawing.Point(296, 63);
            this.btnCajaAhorro.Name = "btnCajaAhorro";
            this.btnCajaAhorro.Size = new System.Drawing.Size(204, 49);
            this.btnCajaAhorro.TabIndex = 1;
            this.btnCajaAhorro.Text = "Caja Ahorro";
            this.btnCajaAhorro.UseVisualStyleBackColor = true;
            this.btnCajaAhorro.Click += new System.EventHandler(this.btnCajaAhorro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(322, 149);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 184);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCajaAhorro);
            this.Controls.Add(this.btnCuentaCorriente);
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCuentaCorriente;
        private System.Windows.Forms.Button btnCajaAhorro;
        private System.Windows.Forms.Button btnSalir;
    }
}

