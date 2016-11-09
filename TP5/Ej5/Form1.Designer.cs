namespace Ej5
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
            this.radioCirculo = new System.Windows.Forms.RadioButton();
            this.radioTriangulo = new System.Windows.Forms.RadioButton();
            this.pXTriangulo1 = new System.Windows.Forms.TextBox();
            this.hacerAritmetica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPerimetro = new System.Windows.Forms.TextBox();
            this.textArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pYCirculo = new System.Windows.Forms.TextBox();
            this.pXCirculo = new System.Windows.Forms.TextBox();
            this.groupBoxCirculo = new System.Windows.Forms.GroupBox();
            this.pRadio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxTriangulo = new System.Windows.Forms.GroupBox();
            this.pZTriangulo2 = new System.Windows.Forms.TextBox();
            this.pZTriangulo1 = new System.Windows.Forms.TextBox();
            this.pYTriangulo2 = new System.Windows.Forms.TextBox();
            this.pYTriangulo1 = new System.Windows.Forms.TextBox();
            this.pXTriangulo2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxFigura = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxCirculo.SuspendLayout();
            this.groupBoxTriangulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioCirculo
            // 
            this.radioCirculo.AutoSize = true;
            this.radioCirculo.Location = new System.Drawing.Point(27, 73);
            this.radioCirculo.Name = "radioCirculo";
            this.radioCirculo.Size = new System.Drawing.Size(57, 17);
            this.radioCirculo.TabIndex = 0;
            this.radioCirculo.TabStop = true;
            this.radioCirculo.Text = "Circulo";
            this.radioCirculo.UseVisualStyleBackColor = true;
            this.radioCirculo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioTriangulo
            // 
            this.radioTriangulo.AutoSize = true;
            this.radioTriangulo.Location = new System.Drawing.Point(27, 146);
            this.radioTriangulo.Name = "radioTriangulo";
            this.radioTriangulo.Size = new System.Drawing.Size(69, 17);
            this.radioTriangulo.TabIndex = 1;
            this.radioTriangulo.TabStop = true;
            this.radioTriangulo.Text = "Triángulo";
            this.radioTriangulo.UseVisualStyleBackColor = true;
            this.radioTriangulo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pXTriangulo1
            // 
            this.pXTriangulo1.Location = new System.Drawing.Point(123, 43);
            this.pXTriangulo1.Name = "pXTriangulo1";
            this.pXTriangulo1.Size = new System.Drawing.Size(26, 20);
            this.pXTriangulo1.TabIndex = 6;
            // 
            // hacerAritmetica
            // 
            this.hacerAritmetica.Location = new System.Drawing.Point(334, 224);
            this.hacerAritmetica.Name = "hacerAritmetica";
            this.hacerAritmetica.Size = new System.Drawing.Size(75, 23);
            this.hacerAritmetica.TabIndex = 10;
            this.hacerAritmetica.Text = "Calcular";
            this.hacerAritmetica.UseVisualStyleBackColor = true;
            this.hacerAritmetica.Click += new System.EventHandler(this.hacerAritmetica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Perímetro";
            // 
            // textPerimetro
            // 
            this.textPerimetro.Location = new System.Drawing.Point(116, 34);
            this.textPerimetro.Name = "textPerimetro";
            this.textPerimetro.Size = new System.Drawing.Size(100, 20);
            this.textPerimetro.TabIndex = 12;
            this.textPerimetro.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(116, 69);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(100, 20);
            this.textArea.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Área";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(334, 284);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 15;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textPerimetro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textArea);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 111);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // pYCirculo
            // 
            this.pYCirculo.Location = new System.Drawing.Point(74, 52);
            this.pYCirculo.Name = "pYCirculo";
            this.pYCirculo.Size = new System.Drawing.Size(35, 20);
            this.pYCirculo.TabIndex = 5;
            // 
            // pXCirculo
            // 
            this.pXCirculo.Location = new System.Drawing.Point(9, 52);
            this.pXCirculo.Name = "pXCirculo";
            this.pXCirculo.Size = new System.Drawing.Size(35, 20);
            this.pXCirculo.TabIndex = 2;
            this.pXCirculo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxCirculo
            // 
            this.groupBoxCirculo.Controls.Add(this.pRadio);
            this.groupBoxCirculo.Controls.Add(this.label4);
            this.groupBoxCirculo.Controls.Add(this.label3);
            this.groupBoxCirculo.Controls.Add(this.pYCirculo);
            this.groupBoxCirculo.Controls.Add(this.pXCirculo);
            this.groupBoxCirculo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxCirculo.Location = new System.Drawing.Point(119, 37);
            this.groupBoxCirculo.Name = "groupBoxCirculo";
            this.groupBoxCirculo.Size = new System.Drawing.Size(135, 149);
            this.groupBoxCirculo.TabIndex = 17;
            this.groupBoxCirculo.TabStop = false;
            this.groupBoxCirculo.Text = "Circulo";
            // 
            // pRadio
            // 
            this.pRadio.Location = new System.Drawing.Point(12, 118);
            this.pRadio.Name = "pRadio";
            this.pRadio.Size = new System.Drawing.Size(97, 20);
            this.pRadio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Radio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Centro";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBoxTriangulo
            // 
            this.groupBoxTriangulo.Controls.Add(this.pZTriangulo2);
            this.groupBoxTriangulo.Controls.Add(this.pZTriangulo1);
            this.groupBoxTriangulo.Controls.Add(this.pYTriangulo2);
            this.groupBoxTriangulo.Controls.Add(this.pYTriangulo1);
            this.groupBoxTriangulo.Controls.Add(this.pXTriangulo2);
            this.groupBoxTriangulo.Controls.Add(this.label7);
            this.groupBoxTriangulo.Controls.Add(this.label6);
            this.groupBoxTriangulo.Controls.Add(this.label5);
            this.groupBoxTriangulo.Controls.Add(this.pXTriangulo1);
            this.groupBoxTriangulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxTriangulo.Location = new System.Drawing.Point(260, 37);
            this.groupBoxTriangulo.Name = "groupBoxTriangulo";
            this.groupBoxTriangulo.Size = new System.Drawing.Size(237, 162);
            this.groupBoxTriangulo.TabIndex = 18;
            this.groupBoxTriangulo.TabStop = false;
            this.groupBoxTriangulo.Text = "Triángulo";
            // 
            // pZTriangulo2
            // 
            this.pZTriangulo2.Location = new System.Drawing.Point(184, 122);
            this.pZTriangulo2.Name = "pZTriangulo2";
            this.pZTriangulo2.Size = new System.Drawing.Size(26, 20);
            this.pZTriangulo2.TabIndex = 17;
            // 
            // pZTriangulo1
            // 
            this.pZTriangulo1.Location = new System.Drawing.Point(123, 122);
            this.pZTriangulo1.Name = "pZTriangulo1";
            this.pZTriangulo1.Size = new System.Drawing.Size(26, 20);
            this.pZTriangulo1.TabIndex = 16;
            // 
            // pYTriangulo2
            // 
            this.pYTriangulo2.Location = new System.Drawing.Point(184, 80);
            this.pYTriangulo2.Name = "pYTriangulo2";
            this.pYTriangulo2.Size = new System.Drawing.Size(26, 20);
            this.pYTriangulo2.TabIndex = 15;
            // 
            // pYTriangulo1
            // 
            this.pYTriangulo1.Location = new System.Drawing.Point(123, 80);
            this.pYTriangulo1.Name = "pYTriangulo1";
            this.pYTriangulo1.Size = new System.Drawing.Size(26, 20);
            this.pYTriangulo1.TabIndex = 14;
            // 
            // pXTriangulo2
            // 
            this.pXTriangulo2.Location = new System.Drawing.Point(184, 43);
            this.pXTriangulo2.Name = "pXTriangulo2";
            this.pXTriangulo2.Size = new System.Drawing.Size(26, 20);
            this.pXTriangulo2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(32, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Punto 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(32, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Punto 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(32, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Punto 1";
            // 
            // groupBoxFigura
            // 
            this.groupBoxFigura.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxFigura.Location = new System.Drawing.Point(12, 37);
            this.groupBoxFigura.Name = "groupBoxFigura";
            this.groupBoxFigura.Size = new System.Drawing.Size(101, 149);
            this.groupBoxFigura.TabIndex = 19;
            this.groupBoxFigura.TabStop = false;
            this.groupBoxFigura.Text = "Figura";
            // 
            // Form1
            // 
            this.AcceptButton = this.hacerAritmetica;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 355);
            this.Controls.Add(this.groupBoxTriangulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.hacerAritmetica);
            this.Controls.Add(this.radioTriangulo);
            this.Controls.Add(this.radioCirculo);
            this.Controls.Add(this.groupBoxCirculo);
            this.Controls.Add(this.groupBoxFigura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxCirculo.ResumeLayout(false);
            this.groupBoxCirculo.PerformLayout();
            this.groupBoxTriangulo.ResumeLayout(false);
            this.groupBoxTriangulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioCirculo;
        private System.Windows.Forms.RadioButton radioTriangulo;
        private System.Windows.Forms.TextBox pXTriangulo1;
        private System.Windows.Forms.Button hacerAritmetica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPerimetro;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pYCirculo;
        private System.Windows.Forms.TextBox pXCirculo;
        private System.Windows.Forms.GroupBox groupBoxCirculo;
        private System.Windows.Forms.GroupBox groupBoxTriangulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pRadio;
        private System.Windows.Forms.TextBox pZTriangulo2;
        private System.Windows.Forms.TextBox pZTriangulo1;
        private System.Windows.Forms.TextBox pYTriangulo2;
        private System.Windows.Forms.TextBox pYTriangulo1;
        private System.Windows.Forms.TextBox pXTriangulo2;
        private System.Windows.Forms.GroupBox groupBoxFigura;
    }
}

