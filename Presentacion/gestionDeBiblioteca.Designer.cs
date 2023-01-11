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
            this.recorridoUnoAUnoTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.altaLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoUnoAUnoLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEjemplares = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.introducirEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoUnoAUnoEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.altaPrestamosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaPrestamosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePrestamosActivosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoUnoAUnoPrestamosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioTsmi,
            this.tsmiLibros,
            this.tsmiEjemplares,
            this.prestamosTsmi,
            this.configuracionTsmi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
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
            this.usuarioTsmi.Size = new System.Drawing.Size(64, 20);
            this.usuarioTsmi.Text = "Usuarios";
            // 
            // altaTsmi
            // 
            this.altaTsmi.Name = "altaTsmi";
            this.altaTsmi.Size = new System.Drawing.Size(182, 22);
            this.altaTsmi.Text = "Alta";
            this.altaTsmi.Click += new System.EventHandler(this.altaTsmi_Click);
            // 
            // bajaTsmi
            // 
            this.bajaTsmi.Name = "bajaTsmi";
            this.bajaTsmi.Size = new System.Drawing.Size(182, 22);
            this.bajaTsmi.Text = "Baja";
            this.bajaTsmi.Click += new System.EventHandler(this.bajaTsmi_Click);
            // 
            // búsquedaTsmi
            // 
            this.búsquedaTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introducirToolStripMenuItem,
            this.seleccionerToolStripMenuItem});
            this.búsquedaTsmi.Name = "búsquedaTsmi";
            this.búsquedaTsmi.Size = new System.Drawing.Size(182, 22);
            this.búsquedaTsmi.Text = "Búsqueda";
            // 
            // introducirToolStripMenuItem
            // 
            this.introducirToolStripMenuItem.Name = "introducirToolStripMenuItem";
            this.introducirToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.introducirToolStripMenuItem.Text = "Introducir";
            this.introducirToolStripMenuItem.Click += new System.EventHandler(this.introducirToolStripMenuItem_Click);
            // 
            // seleccionerToolStripMenuItem
            // 
            this.seleccionerToolStripMenuItem.Name = "seleccionerToolStripMenuItem";
            this.seleccionerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.seleccionerToolStripMenuItem.Text = "Seleccionar";
            this.seleccionerToolStripMenuItem.Click += new System.EventHandler(this.seleccionerToolStripMenuItem_Click);
            // 
            // listadoDeUsuariosToolStripMenuItem
            // 
            this.listadoDeUsuariosToolStripMenuItem.Name = "listadoDeUsuariosToolStripMenuItem";
            this.listadoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listadoDeUsuariosToolStripMenuItem.Text = "Listado de usuarios";
            this.listadoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeUsuariosToolStripMenuItem_Click);
            // 
            // recorridoUnoAUnoTsmi
            // 
            this.recorridoUnoAUnoTsmi.Name = "recorridoUnoAUnoTsmi";
            this.recorridoUnoAUnoTsmi.Size = new System.Drawing.Size(182, 22);
            this.recorridoUnoAUnoTsmi.Text = "Recorrido uno a uno";
            this.recorridoUnoAUnoTsmi.Click += new System.EventHandler(this.recorridoUnoAUnoTsmi_Click);
            // 
            // tsmiLibros
            // 
            this.tsmiLibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaLibrosTsmi,
            this.bajaLibrosTsmi,
            this.busquedaLibrosTsmi,
            this.listadoDeLibrosTsmi,
            this.recorridoUnoAUnoLibrosTsmi});
            this.tsmiLibros.MergeIndex = 1;
            this.tsmiLibros.Name = "tsmiLibros";
            this.tsmiLibros.Size = new System.Drawing.Size(51, 20);
            this.tsmiLibros.Text = "Libros";
            // 
            // altaLibrosTsmi
            // 
            this.altaLibrosTsmi.Name = "altaLibrosTsmi";
            this.altaLibrosTsmi.Size = new System.Drawing.Size(182, 22);
            this.altaLibrosTsmi.Text = "Alta";
            this.altaLibrosTsmi.Click += new System.EventHandler(this.altaLibrosTsmi_Click);
            // 
            // bajaLibrosTsmi
            // 
            this.bajaLibrosTsmi.Name = "bajaLibrosTsmi";
            this.bajaLibrosTsmi.Size = new System.Drawing.Size(182, 22);
            this.bajaLibrosTsmi.Text = "Baja";
            this.bajaLibrosTsmi.Click += new System.EventHandler(this.bajaLibrosTsmi_Click);
            // 
            // busquedaLibrosTsmi
            // 
            this.busquedaLibrosTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarLibrosTsmi,
            this.seleccionarLibrosTsmi});
            this.busquedaLibrosTsmi.Name = "busquedaLibrosTsmi";
            this.busquedaLibrosTsmi.Size = new System.Drawing.Size(182, 22);
            this.busquedaLibrosTsmi.Text = "Búsqueda";
            // 
            // insertarLibrosTsmi
            // 
            this.insertarLibrosTsmi.Name = "insertarLibrosTsmi";
            this.insertarLibrosTsmi.Size = new System.Drawing.Size(180, 22);
            this.insertarLibrosTsmi.Text = "Introducir";
            this.insertarLibrosTsmi.Click += new System.EventHandler(this.insertarLibrosTsmi_Click);
            // 
            // seleccionarLibrosTsmi
            // 
            this.seleccionarLibrosTsmi.Name = "seleccionarLibrosTsmi";
            this.seleccionarLibrosTsmi.Size = new System.Drawing.Size(180, 22);
            this.seleccionarLibrosTsmi.Text = "Seleccionar";
            this.seleccionarLibrosTsmi.Click += new System.EventHandler(this.seleccionarLibrosTsmi_Click);
            // 
            // listadoDeLibrosTsmi
            // 
            this.listadoDeLibrosTsmi.Name = "listadoDeLibrosTsmi";
            this.listadoDeLibrosTsmi.Size = new System.Drawing.Size(182, 22);
            this.listadoDeLibrosTsmi.Text = "Listado de libros";
            this.listadoDeLibrosTsmi.Click += new System.EventHandler(this.listadoDeLibrosTsmi_Click);
            // 
            // recorridoUnoAUnoLibrosTsmi
            // 
            this.recorridoUnoAUnoLibrosTsmi.Name = "recorridoUnoAUnoLibrosTsmi";
            this.recorridoUnoAUnoLibrosTsmi.Size = new System.Drawing.Size(182, 22);
            this.recorridoUnoAUnoLibrosTsmi.Text = "Recorrido uno a uno";
            this.recorridoUnoAUnoLibrosTsmi.Click += new System.EventHandler(this.recorridoUnoAUnoLibrosTsmi_Click);
            // 
            // tsmiEjemplares
            // 
            this.tsmiEjemplares.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEjemplaresTsmi,
            this.bajaEjemplaresTsmi,
            this.busquedaEjemplaresTsmi,
            this.listadoDeEjemplaresTsmi,
            this.recorridoUnoAUnoEjemplaresTsmi});
            this.tsmiEjemplares.MergeIndex = 2;
            this.tsmiEjemplares.Name = "tsmiEjemplares";
            this.tsmiEjemplares.Size = new System.Drawing.Size(76, 20);
            this.tsmiEjemplares.Text = "Ejemplares";
            // 
            // altaEjemplaresTsmi
            // 
            this.altaEjemplaresTsmi.Name = "altaEjemplaresTsmi";
            this.altaEjemplaresTsmi.Size = new System.Drawing.Size(188, 22);
            this.altaEjemplaresTsmi.Text = "Alta";
            this.altaEjemplaresTsmi.Click += new System.EventHandler(this.altaEjemplaresTsmi_Click);
            // 
            // bajaEjemplaresTsmi
            // 
            this.bajaEjemplaresTsmi.Name = "bajaEjemplaresTsmi";
            this.bajaEjemplaresTsmi.Size = new System.Drawing.Size(188, 22);
            this.bajaEjemplaresTsmi.Text = "Baja";
            this.bajaEjemplaresTsmi.Click += new System.EventHandler(this.bajaEjemplaresTsmi_Click);
            // 
            // busquedaEjemplaresTsmi
            // 
            this.busquedaEjemplaresTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introducirEjemplaresTsmi,
            this.seleccionarEjemplaresTsmi});
            this.busquedaEjemplaresTsmi.Name = "busquedaEjemplaresTsmi";
            this.busquedaEjemplaresTsmi.Size = new System.Drawing.Size(188, 22);
            this.busquedaEjemplaresTsmi.Text = "Búsqueda";
            // 
            // introducirEjemplaresTsmi
            // 
            this.introducirEjemplaresTsmi.Name = "introducirEjemplaresTsmi";
            this.introducirEjemplaresTsmi.Size = new System.Drawing.Size(180, 22);
            this.introducirEjemplaresTsmi.Text = "Introducir";
            this.introducirEjemplaresTsmi.Click += new System.EventHandler(this.introducirEjemplaresTsmi_Click);
            // 
            // seleccionarEjemplaresTsmi
            // 
            this.seleccionarEjemplaresTsmi.Name = "seleccionarEjemplaresTsmi";
            this.seleccionarEjemplaresTsmi.Size = new System.Drawing.Size(180, 22);
            this.seleccionarEjemplaresTsmi.Text = "Seleccionar";
            this.seleccionarEjemplaresTsmi.Click += new System.EventHandler(this.seleccionarEjemplaresTsmi_Click);
            // 
            // listadoDeEjemplaresTsmi
            // 
            this.listadoDeEjemplaresTsmi.Name = "listadoDeEjemplaresTsmi";
            this.listadoDeEjemplaresTsmi.Size = new System.Drawing.Size(188, 22);
            this.listadoDeEjemplaresTsmi.Text = "Listado de ejemplares";
            this.listadoDeEjemplaresTsmi.Click += new System.EventHandler(this.listadoDeEjemplaresTsmi_Click);
            // 
            // recorridoUnoAUnoEjemplaresTsmi
            // 
            this.recorridoUnoAUnoEjemplaresTsmi.Name = "recorridoUnoAUnoEjemplaresTsmi";
            this.recorridoUnoAUnoEjemplaresTsmi.Size = new System.Drawing.Size(188, 22);
            this.recorridoUnoAUnoEjemplaresTsmi.Text = "Recorrido uno a uno";
            this.recorridoUnoAUnoEjemplaresTsmi.Click += new System.EventHandler(this.recorridoUnoAUnoEjemplaresTsmi_Click);
            // 
            // prestamosTsmi
            // 
            this.prestamosTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPrestamosTsmi,
            this.bajaPrestamosTsmi,
            this.listadoDePrestamosActivosTsmi,
            this.recorridoUnoAUnoPrestamosTsmi});
            this.prestamosTsmi.Name = "prestamosTsmi";
            this.prestamosTsmi.Size = new System.Drawing.Size(74, 20);
            this.prestamosTsmi.Text = "Préstamos";
            // 
            // altaPrestamosTsmi
            // 
            this.altaPrestamosTsmi.Name = "altaPrestamosTsmi";
            this.altaPrestamosTsmi.Size = new System.Drawing.Size(186, 22);
            this.altaPrestamosTsmi.Text = "Alta";
            this.altaPrestamosTsmi.Click += new System.EventHandler(this.altaPrestamosTsmi_Click);
            // 
            // bajaPrestamosTsmi
            // 
            this.bajaPrestamosTsmi.Name = "bajaPrestamosTsmi";
            this.bajaPrestamosTsmi.Size = new System.Drawing.Size(186, 22);
            this.bajaPrestamosTsmi.Text = "Baja";
            this.bajaPrestamosTsmi.Click += new System.EventHandler(this.bajaPrestamosTsmi_Click);
            // 
            // listadoDePrestamosActivosTsmi
            // 
            this.listadoDePrestamosActivosTsmi.Name = "listadoDePrestamosActivosTsmi";
            this.listadoDePrestamosActivosTsmi.Size = new System.Drawing.Size(186, 22);
            this.listadoDePrestamosActivosTsmi.Text = "Listado de préstamos";
            this.listadoDePrestamosActivosTsmi.Click += new System.EventHandler(this.listadoDePrestamosActivosTsmi_Click);
            // 
            // recorridoUnoAUnoPrestamosTsmi
            // 
            this.recorridoUnoAUnoPrestamosTsmi.Name = "recorridoUnoAUnoPrestamosTsmi";
            this.recorridoUnoAUnoPrestamosTsmi.Size = new System.Drawing.Size(186, 22);
            this.recorridoUnoAUnoPrestamosTsmi.Text = "Recorrido uno a uno";
            this.recorridoUnoAUnoPrestamosTsmi.Click += new System.EventHandler(this.recorridoUnoAUnoPrestamosTsmi_Click);
            // 
            // configuracionTsmi
            // 
            this.configuracionTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.configuracionTsmi.Name = "configuracionTsmi";
            this.configuracionTsmi.Size = new System.Drawing.Size(95, 20);
            this.configuracionTsmi.Text = "Configuración";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // gestionDeBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 307);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "gestionDeBiblioteca";
            this.Text = "gestión de biblioteca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem altaTsmi;
        private System.Windows.Forms.ToolStripMenuItem bajaTsmi;
        private System.Windows.Forms.ToolStripMenuItem búsquedaTsmi;
        private System.Windows.Forms.ToolStripMenuItem introducirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridoUnoAUnoTsmi;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioTsmi;
        private System.Windows.Forms.ToolStripMenuItem configuracionTsmi;
        private System.Windows.Forms.ToolStripMenuItem prestamosTsmi;
        protected internal System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLibros;
        private System.Windows.Forms.ToolStripMenuItem altaLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem bajaLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem busquedaLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem listadoDeLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem recorridoUnoAUnoLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem insertarLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem seleccionarLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem tsmiEjemplares;
        private System.Windows.Forms.ToolStripMenuItem altaEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem bajaEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem busquedaEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem introducirEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem seleccionarEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem recorridoUnoAUnoEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem altaPrestamosTsmi;
        private System.Windows.Forms.ToolStripMenuItem bajaPrestamosTsmi;
        private System.Windows.Forms.ToolStripMenuItem listadoDePrestamosActivosTsmi;
        private System.Windows.Forms.ToolStripMenuItem recorridoUnoAUnoPrestamosTsmi;
    }
}