namespace Ej6
{
    partial class ManejoCuenta
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
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(50, 12);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(204, 49);
            this.btnDepositar.TabIndex = 1;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(50, 67);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(204, 49);
            this.btnRetirar.TabIndex = 3;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(50, 122);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(204, 49);
            this.btnTransferir.TabIndex = 4;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(323, 203);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dinero($)";
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(399, 82);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(132, 20);
            this.txtDinero.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(399, 122);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(132, 20);
            this.txtSaldo.TabIndex = 10;
            // 
            // ManejoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 260);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnDepositar);
            this.Name = "ManejoCuenta";
            this.Text = "ManejoCuenta";
            this.Load += new System.EventHandler(this.ManejoCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
    }
}