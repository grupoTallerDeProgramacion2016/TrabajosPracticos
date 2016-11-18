namespace Ej7
{
    partial class Form1
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
            this.buttonEncriptar = new System.Windows.Forms.Button();
            this.buttonDesencriptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.textBoxSalida = new System.Windows.Forms.TextBox();
            this.comboBoxMetodo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonEncriptar
            // 
            this.buttonEncriptar.Location = new System.Drawing.Point(36, 243);
            this.buttonEncriptar.Name = "buttonEncriptar";
            this.buttonEncriptar.Size = new System.Drawing.Size(75, 23);
            this.buttonEncriptar.TabIndex = 0;
            this.buttonEncriptar.Text = "Encriptar";
            this.buttonEncriptar.UseVisualStyleBackColor = true;
            this.buttonEncriptar.Click += new System.EventHandler(this.buttonEncriptar_Click);
            // 
            // buttonDesencriptar
            // 
            this.buttonDesencriptar.Location = new System.Drawing.Point(335, 243);
            this.buttonDesencriptar.Name = "buttonDesencriptar";
            this.buttonDesencriptar.Size = new System.Drawing.Size(75, 23);
            this.buttonDesencriptar.TabIndex = 1;
            this.buttonDesencriptar.Text = "Desencriptar";
            this.buttonDesencriptar.UseVisualStyleBackColor = true;
            this.buttonDesencriptar.Click += new System.EventHandler(this.buttonDesencriptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto de entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Metodo de encriptacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Texto encriptado";
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Location = new System.Drawing.Point(164, 25);
            this.textBoxEntrada.Multiline = true;
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEntrada.Size = new System.Drawing.Size(246, 66);
            this.textBoxEntrada.TabIndex = 5;
            // 
            // textBoxSalida
            // 
            this.textBoxSalida.Location = new System.Drawing.Point(164, 155);
            this.textBoxSalida.Multiline = true;
            this.textBoxSalida.Name = "textBoxSalida";
            this.textBoxSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSalida.Size = new System.Drawing.Size(246, 66);
            this.textBoxSalida.TabIndex = 6;
            // 
            // comboBoxMetodo
            // 
            this.comboBoxMetodo.FormattingEnabled = true;
            this.comboBoxMetodo.Location = new System.Drawing.Point(164, 110);
            this.comboBoxMetodo.Name = "comboBoxMetodo";
            this.comboBoxMetodo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMetodo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 288);
            this.Controls.Add(this.comboBoxMetodo);
            this.Controls.Add(this.textBoxSalida);
            this.Controls.Add(this.textBoxEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDesencriptar);
            this.Controls.Add(this.buttonEncriptar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncriptar;
        private System.Windows.Forms.Button buttonDesencriptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEntrada;
        private System.Windows.Forms.TextBox textBoxSalida;
        private System.Windows.Forms.ComboBox comboBoxMetodo;
    }
}

