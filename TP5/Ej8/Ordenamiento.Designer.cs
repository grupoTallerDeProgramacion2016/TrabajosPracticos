namespace Ej8
{
    partial class Ordenamiento
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
            this.table = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.comboBoxOrdenamiento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToOrderColumns = true;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(31, 125);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(524, 220);
            this.table.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 43);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(210, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Busqueda";
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Items.AddRange(new object[] {
            "Codigo",
            "Nombre completo"});
            this.comboBoxBusqueda.Location = new System.Drawing.Point(337, 43);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBusqueda.TabIndex = 6;
            // 
            // comboBoxOrdenamiento
            // 
            this.comboBoxOrdenamiento.FormattingEnabled = true;
            this.comboBoxOrdenamiento.Items.AddRange(new object[] {
            "Codigo ascendente",
            "Codigo descendente",
            "Correo electronico"});
            this.comboBoxOrdenamiento.Location = new System.Drawing.Point(105, 85);
            this.comboBoxOrdenamiento.Name = "comboBoxOrdenamiento";
            this.comboBoxOrdenamiento.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrdenamiento.TabIndex = 7;
            this.comboBoxOrdenamiento.SelectedIndexChanged += new System.EventHandler(this.cambioOrdenamiento);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ordenar por";
            // 
            // Ordenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOrdenamiento);
            this.Controls.Add(this.comboBoxBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.table);
            this.Name = "Ordenamiento";
            this.Text = "Ordenamiento";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.ComboBox comboBoxOrdenamiento;
        private System.Windows.Forms.Label label2;
    }
}