namespace Presentacion
{
    partial class ListadoLibros
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
            this.lbAutor = new System.Windows.Forms.ListBox();
            this.lbTitulo = new System.Windows.Forms.ListBox();
            this.lbISBN = new System.Windows.Forms.ListBox();
            this.bAutor = new System.Windows.Forms.Button();
            this.bTitulo = new System.Windows.Forms.Button();
            this.bISBN = new System.Windows.Forms.Button();
            this.lbEditorial = new System.Windows.Forms.ListBox();
            this.bEditorial = new System.Windows.Forms.Button();
            this.cerrarb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAutor
            // 
            this.lbAutor.FormattingEnabled = true;
            this.lbAutor.ItemHeight = 31;
            this.lbAutor.Location = new System.Drawing.Point(723, 165);
            this.lbAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(220, 500);
            this.lbAutor.TabIndex = 11;
            // 
            // lbTitulo
            // 
            this.lbTitulo.FormattingEnabled = true;
            this.lbTitulo.ItemHeight = 31;
            this.lbTitulo.Location = new System.Drawing.Point(443, 165);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(209, 500);
            this.lbTitulo.TabIndex = 10;
            // 
            // lbISBN
            // 
            this.lbISBN.FormattingEnabled = true;
            this.lbISBN.ItemHeight = 31;
            this.lbISBN.Location = new System.Drawing.Point(155, 165);
            this.lbISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbISBN.Name = "lbISBN";
            this.lbISBN.Size = new System.Drawing.Size(220, 500);
            this.lbISBN.TabIndex = 9;
            // 
            // bAutor
            // 
            this.bAutor.Location = new System.Drawing.Point(723, 76);
            this.bAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAutor.Name = "bAutor";
            this.bAutor.Size = new System.Drawing.Size(219, 50);
            this.bAutor.TabIndex = 8;
            this.bAutor.Text = "Autor";
            this.bAutor.UseVisualStyleBackColor = true;
            this.bAutor.Click += new System.EventHandler(this.bAutor_Click);
            // 
            // bTitulo
            // 
            this.bTitulo.Location = new System.Drawing.Point(443, 76);
            this.bTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bTitulo.Name = "bTitulo";
            this.bTitulo.Size = new System.Drawing.Size(208, 50);
            this.bTitulo.TabIndex = 7;
            this.bTitulo.Text = "Título";
            this.bTitulo.UseVisualStyleBackColor = true;
            this.bTitulo.Click += new System.EventHandler(this.bTitulo_Click);
            // 
            // bISBN
            // 
            this.bISBN.Location = new System.Drawing.Point(155, 76);
            this.bISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bISBN.Name = "bISBN";
            this.bISBN.Size = new System.Drawing.Size(219, 50);
            this.bISBN.TabIndex = 6;
            this.bISBN.Text = "ISBN";
            this.bISBN.UseVisualStyleBackColor = true;
            this.bISBN.Click += new System.EventHandler(this.bISBN_Click);
            // 
            // lbEditorial
            // 
            this.lbEditorial.FormattingEnabled = true;
            this.lbEditorial.ItemHeight = 31;
            this.lbEditorial.Location = new System.Drawing.Point(1016, 165);
            this.lbEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEditorial.Name = "lbEditorial";
            this.lbEditorial.Size = new System.Drawing.Size(220, 500);
            this.lbEditorial.TabIndex = 13;
            // 
            // bEditorial
            // 
            this.bEditorial.Location = new System.Drawing.Point(1016, 76);
            this.bEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEditorial.Name = "bEditorial";
            this.bEditorial.Size = new System.Drawing.Size(219, 50);
            this.bEditorial.TabIndex = 12;
            this.bEditorial.Text = "Editorial";
            this.bEditorial.UseVisualStyleBackColor = true;
            this.bEditorial.Click += new System.EventHandler(this.bEditorial_Click);
            // 
            // cerrarb
            // 
            this.cerrarb.Location = new System.Drawing.Point(589, 708);
            this.cerrarb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cerrarb.Name = "cerrarb";
            this.cerrarb.Size = new System.Drawing.Size(208, 50);
            this.cerrarb.TabIndex = 14;
            this.cerrarb.Text = "Cerrar";
            this.cerrarb.UseVisualStyleBackColor = true;
            this.cerrarb.Click += new System.EventHandler(this.cerrarb_Click);
            // 
            // ListadoLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 782);
            this.Controls.Add(this.cerrarb);
            this.Controls.Add(this.lbEditorial);
            this.Controls.Add(this.bEditorial);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbISBN);
            this.Controls.Add(this.bAutor);
            this.Controls.Add(this.bTitulo);
            this.Controls.Add(this.bISBN);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ListadoLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de los libros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAutor;
        private System.Windows.Forms.ListBox lbTitulo;
        private System.Windows.Forms.ListBox lbISBN;
        private System.Windows.Forms.Button bAutor;
        private System.Windows.Forms.Button bTitulo;
        private System.Windows.Forms.Button bISBN;
        private System.Windows.Forms.ListBox lbEditorial;
        private System.Windows.Forms.Button bEditorial;
        private System.Windows.Forms.Button cerrarb;
    }
}