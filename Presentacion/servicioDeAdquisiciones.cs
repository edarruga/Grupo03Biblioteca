using ModeloDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class servicioDeAdquisiciones : gestionDeBiblioteca
    {
        private System.Windows.Forms.ToolStripMenuItem altaLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem bajaLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem busquedaLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem listadoDeLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem recorridoUnoAUnoLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem insertarLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem seleccionarLibrosTsmi;
        private System.Windows.Forms.ToolStripMenuItem altaEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem bajaEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem busquedaEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem introducirEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem seleccionarEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEjemplaresTsmi;
        private System.Windows.Forms.ToolStripMenuItem recorridoUnoAUnoEjemplaresTsmi;
        public servicioDeAdquisiciones(String nombre):base(nombre)
        {
            
            InitializeComponent();
            this.Text = "Personal de servicio de adquisiciones: " + nombre;

            this.altaLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoUnoAUnoLibrosTsmi = new System.Windows.Forms.ToolStripMenuItem();

            this.altaEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.introducirEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoUnoAUnoEjemplaresTsmi = new System.Windows.Forms.ToolStripMenuItem();

            base.prestamosTsmi.Visible=false;

            base.tsmiLibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaLibrosTsmi,
            this.bajaLibrosTsmi,
            this.busquedaLibrosTsmi,
            this.listadoDeLibrosTsmi,
            this.recorridoUnoAUnoLibrosTsmi});

            // 
            // altaLibrosTsmi
            // 
            this.altaLibrosTsmi.Name = "altaLibrosTsmi";
            this.altaLibrosTsmi.Size = new System.Drawing.Size(455, 54);
            this.altaLibrosTsmi.Text = "Alta";
            this.altaLibrosTsmi.Click += new System.EventHandler(this.altaLibrosTsmi_Click);
            // 
            // bajaLibrosTsmi
            // 
            this.bajaLibrosTsmi.Name = "bajaLibrosTsmi";
            this.bajaLibrosTsmi.Size = new System.Drawing.Size(455, 54);
            this.bajaLibrosTsmi.Text = "Baja";
            this.bajaLibrosTsmi.Click += new System.EventHandler(this.bajaLibrosTsmi_Click);
            // 
            // busquedaLibrosTsmi
            // 
            this.busquedaLibrosTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarLibrosTsmi,
            this.seleccionarLibrosTsmi});
            this.busquedaLibrosTsmi.Name = "busquedaLibrosTsmi";
            this.busquedaLibrosTsmi.Size = new System.Drawing.Size(455, 54);
            this.busquedaLibrosTsmi.Text = "Búsqueda";
            // 
            // insertarLibrosTsmi
            // 
            this.insertarLibrosTsmi.Name = "insertarLibrosTsmi";
            this.insertarLibrosTsmi.Size = new System.Drawing.Size(334, 54);
            this.insertarLibrosTsmi.Text = "Introducir";
            this.insertarLibrosTsmi.Click += new System.EventHandler(this.insertarLibrosTsmi_Click);
            // 
            // seleccionarLibrosTsmi
            // 
            this.seleccionarLibrosTsmi.Name = "seleccionarLibrosTsmi";
            this.seleccionarLibrosTsmi.Size = new System.Drawing.Size(334, 54);
            this.seleccionarLibrosTsmi.Text = "Seleccionar";
            this.seleccionarLibrosTsmi.Click += new System.EventHandler(this.seleccionarLibrosTsmi_Click);
            // 
            // listadoDeLibrosTsmi
            // 
            this.listadoDeLibrosTsmi.Name = "listadoDeLibrosTsmi";
            this.listadoDeLibrosTsmi.Size = new System.Drawing.Size(455, 54);
            this.listadoDeLibrosTsmi.Text = "Listado de libros";
            this.listadoDeLibrosTsmi.Click += new System.EventHandler(this.listadoDeLibrosTsmi_Click);
            // 
            // recorridoUnoAUnoLibrosTsmi
            // 
            this.recorridoUnoAUnoLibrosTsmi.Name = "recorridoUnoAUnoLibrosTsmi";
            this.recorridoUnoAUnoLibrosTsmi.Size = new System.Drawing.Size(455, 54);
            this.recorridoUnoAUnoLibrosTsmi.Text = "Recorrido uno a uno";
            this.recorridoUnoAUnoLibrosTsmi.Click += new System.EventHandler(this.recorridoUnoAUnoLibrosTsmi_Click);


            base.tsmiEjemplares.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEjemplaresTsmi,
            this.bajaEjemplaresTsmi,
            this.busquedaEjemplaresTsmi,
            this.listadoDeEjemplaresTsmi,
            this.recorridoUnoAUnoEjemplaresTsmi});

            // 
            // altaEjemplaresTsmi
            // 
            this.altaEjemplaresTsmi.Name = "altaEjemplaresTsmi";
            this.altaEjemplaresTsmi.Size = new System.Drawing.Size(473, 54);
            this.altaEjemplaresTsmi.Text = "Alta";
            this.altaEjemplaresTsmi.Click += new System.EventHandler(this.altaEjemplaresTsmi_Click);
            // 
            // bajaEjemplaresTsmi
            // 
            this.bajaEjemplaresTsmi.Name = "bajaEjemplaresTsmi";
            this.bajaEjemplaresTsmi.Size = new System.Drawing.Size(473, 54);
            this.bajaEjemplaresTsmi.Text = "Baja";
            this.bajaEjemplaresTsmi.Click += new System.EventHandler(this.bajaEjemplaresTsmi_Click);
            // 
            // busquedaEjemplaresTsmi
            // 
            this.busquedaEjemplaresTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introducirEjemplaresTsmi,
            this.seleccionarEjemplaresTsmi});
            this.busquedaEjemplaresTsmi.Name = "busquedaEjemplaresTsmi";
            this.busquedaEjemplaresTsmi.Size = new System.Drawing.Size(473, 54);
            this.busquedaEjemplaresTsmi.Text = "Búsqueda";
            // 
            // introducirEjemplaresTsmi
            // 
            this.introducirEjemplaresTsmi.Name = "introducirEjemplaresTsmi";
            this.introducirEjemplaresTsmi.Size = new System.Drawing.Size(334, 54);
            this.introducirEjemplaresTsmi.Text = "Introducir";
            this.introducirEjemplaresTsmi.Click += new System.EventHandler(this.introducirEjemplaresTsmi_Click);
            // 
            // seleccionarEjemplaresTsmi
            // 
            this.seleccionarEjemplaresTsmi.Name = "seleccionarEjemplaresTsmi";
            this.seleccionarEjemplaresTsmi.Size = new System.Drawing.Size(334, 54);
            this.seleccionarEjemplaresTsmi.Text = "Seleccionar";
            this.seleccionarEjemplaresTsmi.Click += new System.EventHandler(this.seleccionarEjemplaresTsmi_Click);
            // 
            // listadoDeEjemplaresTsmi
            // 
            this.listadoDeEjemplaresTsmi.Name = "listadoDeEjemplaresTsmi";
            this.listadoDeEjemplaresTsmi.Size = new System.Drawing.Size(473, 54);
            this.listadoDeEjemplaresTsmi.Text = "Listado de ejemplares";
            this.listadoDeEjemplaresTsmi.Click += new System.EventHandler(this.listadoDeEjemplaresTsmi_Click);
            // 
            // recorridoUnoAUnoEjemplaresTsmi
            // 
            this.recorridoUnoAUnoEjemplaresTsmi.Name = "recorridoUnoAUnoEjemplaresTsmi";
            this.recorridoUnoAUnoEjemplaresTsmi.Size = new System.Drawing.Size(473, 54);
            this.recorridoUnoAUnoEjemplaresTsmi.Text = "Recorrido uno a uno";
            this.recorridoUnoAUnoEjemplaresTsmi.Click += new System.EventHandler(this.recorridoUnoAUnoEjemplaresTsmi_Click);
        }

        private void altaLibrosTsmi_Click(object sender, EventArgs e)
        {
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir ISBN";
            introducir.ClaveL.Text = "ISBN:";
            DialogResult resultado = introducir.ShowDialog();
            if (DialogResult.OK == resultado)
            {
                if (introducir.Clave != "")
                {
                    if (!MNBiblioteca.existeLibro(introducir.Clave))
                    {
                        alta altaLibro = new alta();
                        altaLibro.Text = "Alta de un libro";
                        claveUC ucISBN = new claveUC(85, 50, "ISBN:", introducir.Clave);
                        datoUC ucTitulo = new datoUC(85, 100, "Título:");
                        datoUC ucAutor = new datoUC(85, 150, "Autor:");
                        datoUC ucEditorial = new datoUC(85, 200, "Editorial:");
                        ucTitulo.Name = "ucTitulo";
                        ucAutor.Name = "ucAutor";
                        ucEditorial.Name = "ucEditorial";
                        altaLibro.Controls.Add(ucISBN);
                        altaLibro.Controls.Add(ucTitulo);
                        altaLibro.Controls.Add(ucAutor);
                        altaLibro.Controls.Add(ucEditorial);
                        DialogResult libro = altaLibro.ShowDialog();
                        if (libro == DialogResult.OK)
                        {
                            if (((datoUC)altaLibro.Controls["ucTitulo"]).Dato == "")
                            {
                                MessageBox.Show("Debes introducir un titulo para el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.altaLibrosTsmi_Click(sender, e);
                            }
                            else if (((datoUC)altaLibro.Controls["ucAutor"]).Dato == "")
                            {
                                MessageBox.Show("Debes introducir algún autor para el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.altaLibrosTsmi_Click(sender, e);
                            }
                            else if (((datoUC)altaLibro.Controls["ucEditorial"]).Dato == "")
                            {
                                MessageBox.Show("Debes introducir alguna editorial para el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.altaLibrosTsmi_Click(sender, e);
                            }
                            else
                            {
                                if (!ManagementNameAttribute.altaLibro(introducir.Clave, ((datoUC)altaLibro.Controls["nombreUC"]).Dato, ((datoUC)altaLibro.Controls["apellidosUC"]).Dato))
                                {
                                    MessageBox.Show("No se pudo realizar correctamente la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }

                        }
                        else
                        {
                            introducir.Close();
                        }
                        introducir.Dispose();
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un usuario con ese DNI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.altaTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro DNI es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.altaTsmi_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
        }

        private void bajaLibrosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void insertarLibrosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void seleccionarLibrosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeLibrosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void recorridoUnoAUnoLibrosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void altaEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }

        private void bajaEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }

        private void introducirEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }

        private void seleccionarEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }

        private void recorridoUnoAUnoEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }
    }
}
