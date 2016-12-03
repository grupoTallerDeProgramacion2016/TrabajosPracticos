namespace Ej2.UI
{
    partial class ListadoCuentas
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
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Modificar = new System.Windows.Forms.Button();
            this.textBox_Busqueda = new System.Windows.Forms.TextBox();
            this.dataGridView_Cuentas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Sobregiradas = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(482, 16);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_Eliminar.TabIndex = 6;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // button_Modificar
            // 
            this.button_Modificar.Location = new System.Drawing.Point(377, 16);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(75, 23);
            this.button_Modificar.TabIndex = 7;
            this.button_Modificar.Text = "Modificar";
            this.button_Modificar.UseVisualStyleBackColor = true;
            this.button_Modificar.Click += new System.EventHandler(this.button_Modificar_Click);
            // 
            // textBox_Busqueda
            // 
            this.textBox_Busqueda.Location = new System.Drawing.Point(48, 19);
            this.textBox_Busqueda.Name = "textBox_Busqueda";
            this.textBox_Busqueda.Size = new System.Drawing.Size(141, 20);
            this.textBox_Busqueda.TabIndex = 5;
            this.textBox_Busqueda.TextChanged += new System.EventHandler(this.BuscarId);
            // 
            // dataGridView_Cuentas
            // 
            this.dataGridView_Cuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ClientId,
            this.FirstName,
            this.LastName});
            this.dataGridView_Cuentas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_Cuentas.Location = new System.Drawing.Point(9, 60);
            this.dataGridView_Cuentas.MultiSelect = false;
            this.dataGridView_Cuentas.Name = "dataGridView_Cuentas";
            this.dataGridView_Cuentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_Cuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cuentas.Size = new System.Drawing.Size(546, 195);
            this.dataGridView_Cuentas.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "ClientId";
            this.ClientId.HeaderText = "Id Cliente";
            this.ClientId.Name = "ClientId";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "Name";
            this.FirstName.HeaderText = "Nombre";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "OverdraftLimit";
            this.LastName.HeaderText = "Descubierto";
            this.LastName.Name = "LastName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id";
            // 
            // button_Sobregiradas
            // 
            this.button_Sobregiradas.Location = new System.Drawing.Point(195, 261);
            this.button_Sobregiradas.Name = "button_Sobregiradas";
            this.button_Sobregiradas.Size = new System.Drawing.Size(189, 23);
            this.button_Sobregiradas.TabIndex = 9;
            this.button_Sobregiradas.Text = "Obtener cuentas sobregiradas";
            this.button_Sobregiradas.UseVisualStyleBackColor = true;
            this.button_Sobregiradas.Click += new System.EventHandler(this.button_Sobregiradas_Click);
            // 
            // ListadoCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 294);
            this.Controls.Add(this.button_Sobregiradas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.textBox_Busqueda);
            this.Controls.Add(this.dataGridView_Cuentas);
            this.Name = "ListadoCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.TextBox textBox_Busqueda;
        private System.Windows.Forms.DataGridView dataGridView_Cuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Sobregiradas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
    }
}