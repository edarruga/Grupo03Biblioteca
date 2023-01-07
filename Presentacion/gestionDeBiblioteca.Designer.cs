namespace Presentacion
{
    partial class gestionDeBiblioteca
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.altaTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.introducirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoUnoAUnoTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioTsmi,
            this.librosTsmi,
            this.ejemplaresTsmi,
            this.prestamosTsmi,
            this.configuracionTsmi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1714, 56);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioTsmi
            // 
            this.usuarioTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaTsmi,
            this.bajaTsmi,
            this.búsquedaTsmi,
            this.listadoDeUsuariosToolStripMenuItem,
            this.recorridoUnoAUnoTsmi});
            this.usuarioTsmi.Name = "usuarioTsmi";
            this.usuarioTsmi.Size = new System.Drawing.Size(156, 48);
            this.usuarioTsmi.Text = "Usuarios";
            // 
            // altaTsmi
            // 
            this.altaTsmi.Name = "altaTsmi";
            this.altaTsmi.Size = new System.Drawing.Size(455, 54);
            this.altaTsmi.Text = "Alta";
            this.altaTsmi.Click += new System.EventHandler(this.altaTsmi_Click);
            // 
            // bajaTsmi
            // 
            this.bajaTsmi.Name = "bajaTsmi";
            this.bajaTsmi.Size = new System.Drawing.Size(455, 54);
            this.bajaTsmi.Text = "Baja";
            this.bajaTsmi.Click += new System.EventHandler(this.bajaTsmi_Click);
            // 
            // búsquedaTsmi
            // 
            this.búsquedaTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introducirToolStripMenuItem,
            this.seleccionerToolStripMenuItem});
            this.búsquedaTsmi.Name = "búsquedaTsmi";
            this.búsquedaTsmi.Size = new System.Drawing.Size(455, 54);
            this.búsquedaTsmi.Text = "Búsqueda";
            // 
            // introducirToolStripMenuItem
            // 
            this.introducirToolStripMenuItem.Name = "introducirToolStripMenuItem";
            this.introducirToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.introducirToolStripMenuItem.Text = "Introducir";
            this.introducirToolStripMenuItem.Click += new System.EventHandler(this.introducirToolStripMenuItem_Click);
            // 
            // seleccionerToolStripMenuItem
            // 
            this.seleccionerToolStripMenuItem.Name = "seleccionerToolStripMenuItem";
            this.seleccionerToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.seleccionerToolStripMenuItem.Text = "Seleccionar";
            this.seleccionerToolStripMenuItem.Click += new System.EventHandler(this.seleccionerToolStripMenuItem_Click);
            // 
            // listadoDeUsuariosToolStripMenuItem
            // 
            this.listadoDeUsuariosToolStripMenuItem.Name = "listadoDeUsuariosToolStripMenuItem";
            this.listadoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(455, 54);
            this.listadoDeUsuariosToolStripMenuItem.Text = "Listado de usuarios";
            this.listadoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeUsuariosToolStripMenuItem_Click);
            // 
            // librosTsmi
            // 
            this.librosTsmi.Name = "librosTsmi";
            this.librosTsmi.Size = new System.Drawing.Size(122, 48);
            this.librosTsmi.Text = "Libros";
            // 
            // ejemplaresTsmi
            // 
            this.ejemplaresTsmi.Name = "ejemplaresTsmi";
            this.ejemplaresTsmi.Size = new System.Drawing.Size(185, 48);
            this.ejemplaresTsmi.Text = "Ejemplares";
            // 
            // prestamosTsmi
            // 
            this.prestamosTsmi.Name = "prestamosTsmi";
            this.prestamosTsmi.Size = new System.Drawing.Size(180, 48);
            this.prestamosTsmi.Text = "Préstamos";
            // 
            // configuracionTsmi
            // 
            this.configuracionTsmi.Name = "configuracionTsmi";
            this.configuracionTsmi.Size = new System.Drawing.Size(228, 48);
            this.configuracionTsmi.Text = "Configuración";
            // 
            // recorridoUnoAUnoTsmi
            // 
            this.recorridoUnoAUnoTsmi.Name = "recorridoUnoAUnoTsmi";
            this.recorridoUnoAUnoTsmi.Size = new System.Drawing.Size(455, 54);
            this.recorridoUnoAUnoTsmi.Text = "Recorrido uno a uno";
            this.recorridoUnoAUnoTsmi.Click += new System.EventHandler(this.recorridoUnoAUnoTsmi_Click);
            // 
            // gestionDeBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 926);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "gestionDeBiblioteca";
            this.Text = "gestión de biblioteca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioTsmi;
        private System.Windows.Forms.ToolStripMenuItem librosTsmi;
        private System.Windows.Forms.ToolStripMenuItem ejemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem prestamosTsmi;
        private System.Windows.Forms.ToolStripMenuItem configuracionTsmi;
        private System.Windows.Forms.ToolStripMenuItem altaTsmi;
        private System.Windows.Forms.ToolStripMenuItem bajaTsmi;
        private System.Windows.Forms.ToolStripMenuItem búsquedaTsmi;
        private System.Windows.Forms.ToolStripMenuItem introducirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridoUnoAUnoTsmi;
    }
}