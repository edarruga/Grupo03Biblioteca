using ModeloDeDominio;
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
                        claveUC ucISBN = new claveUC(85, 40, "ISBN:", introducir.Clave);
                        datoUC ucTitulo = new datoUC(85, 70, "Título:");
                        datoUC ucAutor = new datoUC(85, 100, "Autor:");
                        datoUC ucEditorial = new datoUC(85, 130, "Editorial:");
                        Button btAnadirEjemplares = new Button();
                        btAnadirEjemplares.Text = "Añadir ejemplares";
                        btAnadirEjemplares.Size = new Size(new Point(69,40));
                        btAnadirEjemplares.Location = new Point(184,170);
                        btAnadirEjemplares.Click += altaEjemplaresTsmi_Click;
                        ucTitulo.Name = "ucTitulo";
                        ucAutor.Name = "ucAutor";
                        ucEditorial.Name = "ucEditorial";
                        btAnadirEjemplares.Name = "btAnadirEjemplares";
                        altaLibro.Controls.Add(ucISBN);
                        altaLibro.Controls.Add(ucTitulo);
                        altaLibro.Controls.Add(ucAutor);
                        altaLibro.Controls.Add(ucEditorial);
                        altaLibro.Controls.Add(btAnadirEjemplares);
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
                                if (!MNAdquisiciones.altaLibro(introducir.Clave, ((datoUC)altaLibro.Controls["ucTitulo"]).Dato, ((datoUC)altaLibro.Controls["ucAutor"]).Dato, ((datoUC)altaLibro.Controls["ucEditorial"]).Dato))
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
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un libro con ese ISBN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.altaLibrosTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro ISBN es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.altaLibrosTsmi_Click(sender, e);
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
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir ISBN";
            introducir.ClaveL.Text = "ISBN:";
            DialogResult resultado = introducir.ShowDialog();
            if (DialogResult.OK == resultado)
            {
                if (introducir.Clave != "")
                {
                    if (MNBiblioteca.existeLibro(introducir.Clave))
                    {
                        alta altaLibro = new alta();
                        altaLibro.Text = "Baja de un libro";
                        claveUC ucISBN = new claveUC(85, 50, "ISBN:", introducir.Clave);
                        datoUC ucTitulo = new datoUC(85, 80, "Título:");
                        datoUC ucAutor = new datoUC(85, 110, "Autor:");
                        datoUC ucEditorial = new datoUC(85, 140, "Editorial:");
                        ucTitulo.Name = "ucTitulo";
                        ucAutor.Name = "ucAutor";
                        ucEditorial.Name = "ucEditorial";
                        ucTitulo.DatoTbUC.ReadOnly = true;
                        ucAutor.DatoTbUC.ReadOnly = true;
                        ucEditorial.DatoTbUC.ReadOnly = true;
                        ucTitulo.DatoTbUC.Text = MNAdquisiciones.getTituloLibro(introducir.Clave);
                        ucAutor.DatoTbUC.Text = MNAdquisiciones.getAutorLibro(introducir.Clave);
                        ucEditorial.DatoTbUC.Text = MNAdquisiciones.getEditorialLibro(introducir.Clave);
                        altaLibro.Controls.Add(ucISBN);
                        altaLibro.Controls.Add(ucTitulo);
                        altaLibro.Controls.Add(ucAutor);
                        altaLibro.Controls.Add(ucEditorial);
                        DialogResult usuario = altaLibro.ShowDialog();
                        if (usuario == DialogResult.OK)
                        {

                            DialogResult aviso = MessageBox.Show("¿Está seguro que desea dar de baja este libro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (aviso == DialogResult.OK)
                            {
                                if (MNAdquisiciones.bajaLibro(introducir.Clave))
                                {
                                    MessageBox.Show("Libro eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "No existe ningún libro con ese ISBN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.bajaLibrosTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro ISBN es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.bajaLibrosTsmi_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
        }

        private void insertarLibrosTsmi_Click(object sender, EventArgs e)
        {
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir ISBN";
            introducir.ClaveL.Text = "ISBN:";
            DialogResult resultado = introducir.ShowDialog();
            if (DialogResult.OK == resultado)
            {
                if (introducir.Clave != "")
                {
                    if (MNBiblioteca.existeLibro(introducir.Clave))
                    {
                        datos datosLibro = new datos();
                        datosLibro.Text = "Datos del libro";
                        claveUC ucISBN = new claveUC(85, 50, "ISBN:", introducir.Clave);
                        datoUC ucTitulo = new datoUC(85, 80, "Título:");
                        datoUC ucAutor = new datoUC(85, 110, "Autor:");
                        datoUC ucEditorial = new datoUC(85, 140, "Editorial:");
                        ucTitulo.Name = "ucTitulo";
                        ucAutor.Name = "ucAutor";
                        ucEditorial.Name = "ucEditorial";
                        ucTitulo.DatoTbUC.ReadOnly = true;
                        ucTitulo.DatoTbUC.Text = MNAdquisiciones.getTituloLibro(introducir.Clave);
                        ucAutor.DatoTbUC.ReadOnly = true;
                        ucAutor.DatoTbUC.Text = MNAdquisiciones.getAutorLibro(introducir.Clave);
                        ucEditorial.DatoTbUC.ReadOnly = true;
                        ucEditorial.DatoTbUC.Text = MNAdquisiciones.getEditorialLibro(introducir.Clave);
                        datosLibro.Controls.Add(ucISBN);
                        datosLibro.Controls.Add(ucTitulo);
                        datosLibro.Controls.Add(ucAutor);
                        datosLibro.Controls.Add(ucEditorial);
                        DialogResult libro = datosLibro.ShowDialog();

                        introducir.Dispose();
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "No existe ningún libro con ese ISBN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.insertarLibrosTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro ISBN es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.insertarLibrosTsmi_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
        }

        private void seleccionarLibrosTsmi_Click(object sender, EventArgs e)
        {
            List<string> ISBNs = MNAdquisiciones.listaISBNLibros();
            datosDesplegables datosLibros = new datosDesplegables();
            datosLibros.ClaveL.Text = "ISBN:";
            datosLibros.Text = "Datos del libro";
            datoUC ucTitulo = new datoUC(85, 80, "Título:");
            datoUC ucAutor = new datoUC(85, 110, "Autor:");
            datoUC ucEditorial = new datoUC(85, 140, "Editorial:");
            ucTitulo.Name = "ucTitulo";
            ucAutor.Name = "ucAutor";
            ucEditorial.Name = "ucEditorial";
            ucTitulo.DatoTbUC.ReadOnly = true;
            ucAutor.DatoTbUC.ReadOnly = true;
            ucEditorial.DatoTbUC.ReadOnly = true;
            datosLibros.ClaveDesplegableCb.DataSource = ISBNs;
            datosLibros.ClaveDesplegableCb.SelectedIndex = -1;
            datosLibros.ClaveDesplegableCb.SelectedIndexChanged += delegate (object s, EventArgs ev)
            {
                string ISBN = (string)datosLibros.ClaveDesplegableCb.SelectedValue;
                if (ISBN != null)
                {
                    string titulo = MNAdquisiciones.getTituloLibro(ISBN);
                    ucTitulo.DatoTbUC.Text = titulo;

                    string autor = MNAdquisiciones.getAutorLibro(ISBN);
                    ucAutor.DatoTbUC.Text = autor;

                    string editorial = MNAdquisiciones.getEditorialLibro(ISBN);
                    ucEditorial.DatoTbUC.Text = editorial;
                }
            };
            datosLibros.Controls.Add(ucTitulo);
            datosLibros.Controls.Add(ucAutor);
            datosLibros.Controls.Add(ucEditorial);
            DialogResult usuario = datosLibros.ShowDialog();
        }

        private void listadoDeLibrosTsmi_Click(object sender, EventArgs e)
        {
            ListadoLibros listado = new ListadoLibros(MNAdquisiciones.listaLibros());
            listado.ShowDialog();
        }

        private void recorridoUnoAUnoLibrosTsmi_Click(object sender, EventArgs e)
        {
            rocorridoUnoaUno recorrido = new rocorridoUnoaUno();
            List<Libro> listaLibros = MNAdquisiciones.listaLibros();
            recorrido.Text = "Datos de un libro";
            claveUC ucISBN = new claveUC(20, 50, "ISBN:");
            datoUC ucTitulo = new datoUC(20, 80, "Título:");
            datoUC ucAutor = new datoUC(20, 110, "Autor:");
            datoUC ucEditorial = new datoUC(20, 140, "Editorial:");
            ucISBN.Name = "ucISBN";
            ucTitulo.DatoTbUC.ReadOnly = true;
            ucTitulo.Name = "ucTitulo";
            ucAutor.DatoTbUC.ReadOnly = true;
            ucAutor.Name = "ucAutor";
            ucEditorial.DatoTbUC.ReadOnly = true;
            ucEditorial.Name = "ucEditorial";
            foreach (Libro l in listaLibros)
            {
                recorrido.BindingNavigator.BindingSource.Add(l);
            }
            recorrido.BindingNavigatorPositionItem.TextChanged += (s, ev) => cambiarDatosLibroUnoaUno(sender, e, recorrido);

            recorrido.Controls.Add(ucISBN);
            recorrido.Controls.Add(ucTitulo);
            recorrido.Controls.Add(ucAutor);
            recorrido.Controls.Add(ucEditorial);
            this.cambiarDatosLibroUnoaUno(sender, e, recorrido);

            recorrido.ShowDialog();
        }

        private void cambiarDatosLibroUnoaUno(object sender, EventArgs e, rocorridoUnoaUno recorrido)
        {
            claveUC ucISBN = recorrido.Controls["ucISBN"] as claveUC;
            datoUC ucTitulo = recorrido.Controls["ucTitulo"] as datoUC;
            datoUC ucAutor = recorrido.Controls["ucAutor"] as datoUC;
            datoUC ucEditorial = recorrido.Controls["ucEditorial"] as datoUC;

            Libro l = recorrido.BindingNavigator.BindingSource.Current as Libro;
            string isbn = "";
            string titulo = "";
            string autor = "";
            int editorial = 0;
            if (l != null)
            {
                isbn = l.Isbn;
                titulo = l.Autor;
                autor = l.Titulo;
                editorial = MNBiblioteca.numLibrosPrestados(l.Isbn);
            }
            ucISBN.ClaveTbUC.Text = isbn;
            ucTitulo.DatoTbUC.Text = titulo;
            ucAutor.DatoTbUC.Text = autor;
            ucEditorial.DatoTbUC.Text = editorial.ToString();
        }

        private void altaEjemplaresTsmi_Click(object sender, EventArgs e)
        {
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir código";
            introducir.ClaveL.Text = "Código:";
            DialogResult resultado = introducir.ShowDialog();
            if (DialogResult.OK == resultado)
            {
                if (introducir.Clave != "")
                {
                    if (!MNAdquisiciones.existeEjemplar(introducir.Clave))
                    {
                        alta altaEjemplar = new alta();
                        altaEjemplar.Text = "Alta de un ejemplar";
                        claveUC ucCodigo = new claveUC(85, 50, "Código:", introducir.Clave);
                        datoUC ucIsbnLibro = new datoUC(85, 120, "Isbn:");
                        ucIsbnLibro.Name = "ucIsbnLibro";
                        altaEjemplar.Controls.Add(ucCodigo);
                        altaEjemplar.Controls.Add(ucIsbnLibro);
                        DialogResult ejemplar = altaEjemplar.ShowDialog();
                        if (ejemplar == DialogResult.OK)
                        {
                            if (((datoUC)altaEjemplar.Controls["ucIsbnLibro"]).Dato == "")
                            {
                                MessageBox.Show("Debes introducir un titulo para el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.altaLibrosTsmi_Click(sender, e);
                            }
                            else
                            {
                                if (!MNAdquisiciones.altaEjemplar(introducir.Clave, ((datoUC)altaEjemplar.Controls["ucIsbnLibro"]).Dato))
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
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un ejemplar con ese código", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.altaLibrosTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro código es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.altaLibrosTsmi_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
        }

        private void bajaEjemplaresTsmi_Click(object sender, EventArgs e)
        {
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir código";
            introducir.ClaveL.Text = "Código:";
            DialogResult resultado = introducir.ShowDialog();
            if (DialogResult.OK == resultado)
            {
                if (introducir.Clave != "")
                {
                    if (MNBiblioteca.existeEjemplar(introducir.Clave))
                    {
                        alta altaLibro = new alta();
                        altaLibro.Text = "Baja de un ejemplar";
                        claveUC ucCodigo = new claveUC(85, 30, "Código:", introducir.Clave);
                        datoUC ucPrestado = new datoUC(85, 55, "Prestado:");
                        datoUC ucISBN = new datoUC(85, 80, "ISBN:");
                        datoUC ucTitulo = new datoUC(85, 105, "Título:");
                        datoUC ucAutor = new datoUC(85, 130, "Autor:");
                        datoUC ucEditorial = new datoUC(85, 155, "Editorial:");
                        ucPrestado.Name = "ucPrestado";
                        ucISBN.Name = "ucISBN";
                        ucTitulo.Name = "ucTitulo";
                        ucAutor.Name = "ucAutor";
                        ucEditorial.Name = "ucEditorial";
                        ucPrestado.DatoTbUC.ReadOnly = true;
                        ucISBN.DatoTbUC.ReadOnly = true;
                        ucTitulo.DatoTbUC.ReadOnly = true;
                        ucAutor.DatoTbUC.ReadOnly = true;
                        ucEditorial.DatoTbUC.ReadOnly = true;
                        if (MNAdquisiciones.getEstadoEjemplar(introducir.Clave)) ucPrestado.DatoTbUC.Text = "Si";
                        else ucPrestado.DatoTbUC.Text = "No";

                        ucISBN.DatoTbUC.Text = MNAdquisiciones.getIsbnEjemplar(introducir.Clave);
                        ucTitulo.DatoTbUC.Text = MNAdquisiciones.getTituloLibro(MNAdquisiciones.getIsbnEjemplar(introducir.Clave));
                        ucAutor.DatoTbUC.Text = MNAdquisiciones.getAutorLibro(MNAdquisiciones.getIsbnEjemplar(introducir.Clave));
                        ucEditorial.DatoTbUC.Text = MNAdquisiciones.getEditorialLibro(MNAdquisiciones.getIsbnEjemplar(introducir.Clave));
                        altaLibro.Controls.Add(ucCodigo);
                        altaLibro.Controls.Add(ucPrestado);
                        altaLibro.Controls.Add(ucISBN);
                        altaLibro.Controls.Add(ucTitulo);
                        altaLibro.Controls.Add(ucAutor);
                        altaLibro.Controls.Add(ucEditorial);
                        DialogResult usuario = altaLibro.ShowDialog();
                        if (usuario == DialogResult.OK)
                        {

                            DialogResult aviso = MessageBox.Show("¿Está seguro que desea dar de baja este ejemplar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (aviso == DialogResult.OK)
                            {
                                if (MNAdquisiciones.bajaLibro(introducir.Clave))
                                {
                                    MessageBox.Show("Ejemplar eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "No existe ningún ejemplar con ese código", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.bajaEjemplaresTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro código es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.bajaEjemplaresTsmi_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
        }

        private void introducirEjemplaresTsmi_Click(object sender, EventArgs e)
        {
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir código";
            introducir.ClaveL.Text = "Código:";
            DialogResult resultado = introducir.ShowDialog();
            if (DialogResult.OK == resultado)
            {
                if (introducir.Clave != "")
                {
                    if (MNBiblioteca.existeEjemplar(introducir.Clave))
                    {
                        datos datosEjemplar = new datos();
                        datosEjemplar.Text = "Datos del ejemplar";
                        claveUC ucCodigo = new claveUC(85, 30, "Código:", introducir.Clave);
                        datoUC ucPrestado = new datoUC(85, 55, "Prestado:");
                        datoUC ucISBN = new datoUC(85, 80, "ISBN:");
                        datoUC ucTitulo = new datoUC(85, 105, "Título:");
                        datoUC ucAutor = new datoUC(85, 130, "Autor:");
                        datoUC ucEditorial = new datoUC(85, 155, "Editorial:");
                        ucPrestado.Name = "ucPrestado";
                        ucISBN.Name = "ucISBN";
                        ucTitulo.Name = "ucTitulo";
                        ucAutor.Name = "ucAutor";
                        ucEditorial.Name = "ucEditorial";
                        ucPrestado.DatoTbUC.ReadOnly = true;
                        ucISBN.DatoTbUC.ReadOnly = true;
                        ucTitulo.DatoTbUC.ReadOnly = true;
                        ucAutor.DatoTbUC.ReadOnly = true;
                        ucEditorial.DatoTbUC.ReadOnly = true;
                        if (MNAdquisiciones.getEstadoEjemplar(introducir.Clave)) ucPrestado.DatoTbUC.Text = "Si";
                        else ucPrestado.DatoTbUC.Text = "No";
                        ucISBN.DatoTbUC.Text = MNAdquisiciones.getIsbnEjemplar(introducir.Clave);
                        ucTitulo.DatoTbUC.Text = MNAdquisiciones.getTituloLibro(MNAdquisiciones.getIsbnEjemplar(introducir.Clave));
                        ucAutor.DatoTbUC.Text = MNAdquisiciones.getAutorLibro(MNAdquisiciones.getIsbnEjemplar(introducir.Clave));
                        ucEditorial.DatoTbUC.Text = MNAdquisiciones.getEditorialLibro(MNAdquisiciones.getIsbnEjemplar(introducir.Clave));
                        datosEjemplar.Controls.Add(ucCodigo);
                        datosEjemplar.Controls.Add(ucPrestado);
                        datosEjemplar.Controls.Add(ucISBN);
                        datosEjemplar.Controls.Add(ucTitulo);
                        datosEjemplar.Controls.Add(ucAutor);
                        datosEjemplar.Controls.Add(ucEditorial);
                        DialogResult libro = datosEjemplar.ShowDialog();

                        introducir.Dispose();
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "No existe ningún ejemplar con ese código", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.introducirEjemplaresTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro código es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.introducirEjemplaresTsmi_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
        }

        private void seleccionarEjemplaresTsmi_Click(object sender, EventArgs e)
        {
            List<string> codigos = MNAdquisiciones.listaCodigosEjemplares();
            datosDesplegables datosEjemplares = new datosDesplegables();
            datosEjemplares.ClaveL.Text = "Código:";
            datosEjemplares.Text = "Datos del ejemplar";
            datoUC ucPrestado = new datoUC(85, 75, "Prestado:");
            datoUC ucISBN = new datoUC(85, 100, "ISBN:");
            datoUC ucTitulo = new datoUC(85, 125, "Título:");
            datoUC ucAutor = new datoUC(85, 150, "Autor:");
            datoUC ucEditorial = new datoUC(85, 175, "Editorial:");
            ucPrestado.Name = "ucPrestado";
            ucISBN.Name = "ucISBN";
            ucTitulo.Name = "ucTitulo";
            ucAutor.Name = "ucAutor";
            ucEditorial.Name = "ucEditorial";
            ucPrestado.DatoTbUC.ReadOnly = true;
            ucISBN.DatoTbUC.ReadOnly = true;
            ucTitulo.DatoTbUC.ReadOnly = true;
            ucAutor.DatoTbUC.ReadOnly = true;
            ucEditorial.DatoTbUC.ReadOnly = true;
            datosEjemplares.ClaveDesplegableCb.DataSource = codigos;
            datosEjemplares.ClaveDesplegableCb.SelectedIndex = -1;
            datosEjemplares.ClaveDesplegableCb.SelectedIndexChanged += delegate (object s, EventArgs ev)
            {
                string codigo = (string)datosEjemplares.ClaveDesplegableCb.SelectedValue;
                if (codigo != null)
                {
                    string isbn = MNAdquisiciones.getIsbnEjemplar(codigo);
                    ucISBN.DatoTbUC.Text=isbn;  

                    string titulo = MNAdquisiciones.getTituloLibro(MNAdquisiciones.getIsbnEjemplar(codigo));
                    ucTitulo.DatoTbUC.Text = titulo;

                    string autor = MNAdquisiciones.getAutorLibro(MNAdquisiciones.getIsbnEjemplar(codigo));
                    ucAutor.DatoTbUC.Text = autor;

                    string editorial = MNAdquisiciones.getEditorialLibro(MNAdquisiciones.getIsbnEjemplar(codigo));
                    ucEditorial.DatoTbUC.Text = editorial;

                    string prestado;
                    if (MNAdquisiciones.getEstadoEjemplar(codigo)) prestado = "Si";
                    else prestado = "No";
                    ucPrestado.DatoTbUC.Text = prestado;
                }
            };
            datosEjemplares.Controls.Add(ucPrestado);
            datosEjemplares.Controls.Add(ucISBN);
            datosEjemplares.Controls.Add(ucTitulo);
            datosEjemplares.Controls.Add(ucAutor);
            datosEjemplares.Controls.Add(ucEditorial);
            DialogResult usuario = datosEjemplares.ShowDialog();
        }

        private void listadoDeEjemplaresTsmi_Click(object sender, EventArgs e)
        {
            ListadoEjemplares listado = new ListadoEjemplares(MNAdquisiciones.listaEjemplares());
            listado.ShowDialog();
        }

        private void recorridoUnoAUnoEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }
    }
}
