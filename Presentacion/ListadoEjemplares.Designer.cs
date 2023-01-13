namespace Presentacion
{
    partial class ListadoEjemplares
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
            this.lbEditorial = new System.Windows.Forms.ListBox();
            this.bEditorial = new System.Windows.Forms.Button();
            this.lbAutor = new System.Windows.Forms.ListBox();
            this.lbTitulo = new System.Windows.Forms.ListBox();
            this.lbISBN = new System.Windows.Forms.ListBox();
            this.bAutor = new System.Windows.Forms.Button();
            this.bTitulo = new System.Windows.Forms.Button();
            this.bISBN = new System.Windows.Forms.Button();
            this.cerrarb = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.ListBox();
            this.bCodigo = new System.Windows.Forms.Button();
            this.lbPrestado = new System.Windows.Forms.ListBox();
            this.lPrestado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEditorial
            // 
            this.lbEditorial.FormattingEnabled = true;
            this.lbEditorial.Location = new System.Drawing.Point(577, 86);
            this.lbEditorial.Margin = new System.Windows.Forms.Padding(1);
            this.lbEditorial.Name = "lbEditorial";
            this.lbEditorial.Size = new System.Drawing.Size(85, 212);
            this.lbEditorial.TabIndex = 21;
            // 
            // bEditorial
            // 
            this.bEditorial.Location = new System.Drawing.Point(577, 49);
            this.bEditorial.Margin = new System.Windows.Forms.Padding(1);
            this.bEditorial.Name = "bEditorial";
            this.bEditorial.Size = new System.Drawing.Size(82, 21);
            this.bEditorial.TabIndex = 20;
            this.bEditorial.Text = "Editorial";
            this.bEditorial.UseVisualStyleBackColor = true;
            this.bEditorial.Click += new System.EventHandler(this.bEditorial_Click);
            // 
            // lbAutor
            // 
            this.lbAutor.FormattingEnabled = true;
            this.lbAutor.Location = new System.Drawing.Point(467, 86);
            this.lbAutor.Margin = new System.Windows.Forms.Padding(1);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(85, 212);
            this.lbAutor.TabIndex = 19;
            // 
            // lbTitulo
            // 
            this.lbTitulo.FormattingEnabled = true;
            this.lbTitulo.Location = new System.Drawing.Point(362, 86);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(1);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(81, 212);
            this.lbTitulo.TabIndex = 18;
            // 
            // lbISBN
            // 
            this.lbISBN.FormattingEnabled = true;
            this.lbISBN.Location = new System.Drawing.Point(256, 86);
            this.lbISBN.Margin = new System.Windows.Forms.Padding(1);
            this.lbISBN.Name = "lbISBN";
            this.lbISBN.Size = new System.Drawing.Size(85, 212);
            this.lbISBN.TabIndex = 17;
            // 
            // bAutor
            // 
            this.bAutor.Location = new System.Drawing.Point(467, 49);
            this.bAutor.Margin = new System.Windows.Forms.Padding(1);
            this.bAutor.Name = "bAutor";
            this.bAutor.Size = new System.Drawing.Size(82, 21);
            this.bAutor.TabIndex = 16;
            this.bAutor.Text = "Autor";
            this.bAutor.UseVisualStyleBackColor = true;
            this.bAutor.Click += new System.EventHandler(this.bAutor_Click);
            // 
            // bTitulo
            // 
            this.bTitulo.Location = new System.Drawing.Point(362, 49);
            this.bTitulo.Margin = new System.Windows.Forms.Padding(1);
            this.bTitulo.Name = "bTitulo";
            this.bTitulo.Size = new System.Drawing.Size(78, 21);
            this.bTitulo.TabIndex = 15;
            this.bTitulo.Text = "Título";
            this.bTitulo.UseVisualStyleBackColor = true;
            this.bTitulo.Click += new System.EventHandler(this.bTitulo_Click);
            // 
            // bISBN
            // 
            this.bISBN.Location = new System.Drawing.Point(256, 49);
            this.bISBN.Margin = new System.Windows.Forms.Padding(1);
            this.bISBN.Name = "bISBN";
            this.bISBN.Size = new System.Drawing.Size(82, 21);
            this.bISBN.TabIndex = 14;
            this.bISBN.Text = "ISBN";
            this.bISBN.UseVisualStyleBackColor = true;
            this.bISBN.Click += new System.EventHandler(this.bISBN_Click);
            // 
            // cerrarb
            // 
            this.cerrarb.Location = new System.Drawing.Point(313, 321);
            this.cerrarb.Margin = new System.Windows.Forms.Padding(1);
            this.cerrarb.Name = "cerrarb";
            this.cerrarb.Size = new System.Drawing.Size(78, 21);
            this.cerrarb.TabIndex = 22;
            this.cerrarb.Text = "Cerrar";
            this.cerrarb.UseVisualStyleBackColor = true;
            // 
            // lbCodigo
            // 
            this.lbCodigo.FormattingEnabled = true;
            this.lbCodigo.Location = new System.Drawing.Point(45, 86);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(1);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(85, 212);
            this.lbCodigo.TabIndex = 24;
            // 
            // bCodigo
            // 
            this.bCodigo.Location = new System.Drawing.Point(45, 49);
            this.bCodigo.Margin = new System.Windows.Forms.Padding(1);
            this.bCodigo.Name = "bCodigo";
            this.bCodigo.Size = new System.Drawing.Size(82, 21);
            this.bCodigo.TabIndex = 23;
            this.bCodigo.Text = "Código";
            this.bCodigo.UseVisualStyleBackColor = true;
            this.bCodigo.Click += new System.EventHandler(this.bCodigo_Click);
            // 
            // lbPrestado
            // 
            this.lbPrestado.FormattingEnabled = true;
            this.lbPrestado.Location = new System.Drawing.Point(150, 86);
            this.lbPrestado.Margin = new System.Windows.Forms.Padding(1);
            this.lbPrestado.Name = "lbPrestado";
            this.lbPrestado.Size = new System.Drawing.Size(85, 212);
            this.lbPrestado.TabIndex = 26;
            // 
            // lPrestado
            // 
            this.lPrestado.AutoSize = true;
            this.lPrestado.Location = new System.Drawing.Point(166, 53);
            this.lPrestado.Name = "lPrestado";
            this.lPrestado.Size = new System.Drawing.Size(49, 13);
            this.lPrestado.TabIndex = 27;
            this.lPrestado.Text = "Prestado";
            // 
            // ListadoEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 352);
            this.Controls.Add(this.lPrestado);
            this.Controls.Add(this.lbPrestado);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.bCodigo);
            this.Controls.Add(this.cerrarb);
            this.Controls.Add(this.lbEditorial);
            this.Controls.Add(this.bEditorial);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbISBN);
            this.Controls.Add(this.bAutor);
            this.Controls.Add(this.bTitulo);
            this.Controls.Add(this.bISBN);
            this.Name = "ListadoEjemplares";
            this.Text = "ListadoEjemplares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEditorial;
        private System.Windows.Forms.Button bEditorial;
        private System.Windows.Forms.ListBox lbAutor;
        private System.Windows.Forms.ListBox lbTitulo;
        private System.Windows.Forms.ListBox lbISBN;
        private System.Windows.Forms.Button bAutor;
        private System.Windows.Forms.Button bTitulo;
        private System.Windows.Forms.Button bISBN;
        private System.Windows.Forms.Button cerrarb;
        private System.Windows.Forms.ListBox lbCodigo;
        private System.Windows.Forms.Button bCodigo;
        private System.Windows.Forms.ListBox lbPrestado;
        private System.Windows.Forms.Label lPrestado;
    }
}