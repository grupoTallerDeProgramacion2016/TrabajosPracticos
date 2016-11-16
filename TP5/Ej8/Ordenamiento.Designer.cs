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
            this.txtBtnCodigo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToOrderColumns = true;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 111);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(543, 220);
            this.table.TabIndex = 0;
            // 
            // txtBtnCodigo
            // 
            this.txtBtnCodigo.Location = new System.Drawing.Point(13, 44);
            this.txtBtnCodigo.Name = "txtBtnCodigo";
            this.txtBtnCodigo.Size = new System.Drawing.Size(127, 23);
            this.txtBtnCodigo.TabIndex = 1;
            this.txtBtnCodigo.Text = "ObtenerPorCodigo";
            this.txtBtnCodigo.UseVisualStyleBackColor = true;
            this.txtBtnCodigo.Click += new System.EventHandler(this.txtBtnCodigo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "MostrarTodos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(168, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // Ordenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 343);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBtnCodigo);
            this.Controls.Add(this.table);
            this.Name = "Ordenamiento";
            this.Text = "Ordenamiento";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button txtBtnCodigo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}