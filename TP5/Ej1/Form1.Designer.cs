namespace Ej1
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
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(135, 109);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(75, 23);
            this.boton1.TabIndex = 0;
            this.boton1.Text = "Boton 1";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.BotonPresionado);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(262, 109);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(75, 23);
            this.boton2.TabIndex = 1;
            this.boton2.Text = "Boton 2";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.BotonPresionado);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(401, 109);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(75, 23);
            this.boton3.TabIndex = 2;
            this.boton3.Text = "Boton 3";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.BotonPresionado);
            // 
            // boton4
            // 
            this.boton4.Location = new System.Drawing.Point(522, 109);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(75, 23);
            this.boton4.TabIndex = 3;
            this.boton4.Text = "Boton 4";
            this.boton4.UseVisualStyleBackColor = true;
            this.boton4.Click += new System.EventHandler(this.BotonPresionado);
            // 
            // boton5
            // 
            this.boton5.Location = new System.Drawing.Point(660, 109);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(75, 23);
            this.boton5.TabIndex = 4;
            this.boton5.Text = "Boton 5";
            this.boton5.UseVisualStyleBackColor = true;
            this.boton5.Click += new System.EventHandler(this.BotonPresionado);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(923, 290);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton5;
    }
}

