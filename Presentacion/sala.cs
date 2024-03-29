﻿using ModeloDeDominio;
using ModeloDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Presentacion
{
    public partial class sala : gestionDeBiblioteca
    {
        private System.Windows.Forms.ToolStripMenuItem altaPrestamosTsmi;
        private System.Windows.Forms.ToolStripMenuItem bajaPrestamosTsmi;
        private System.Windows.Forms.ToolStripMenuItem busquedaPrestamosTsmi;
        private System.Windows.Forms.ToolStripMenuItem listadoDePrestamosActivosTsmi;
        private System.Windows.Forms.ToolStripMenuItem recorridoUnoAUnoPrestamosTsmi;
        private System.Windows.Forms.ToolStripMenuItem verEjemplaresNoDevueltosTsmi;
        private System.Windows.Forms.ToolStripMenuItem devolverEjemplarTsmi;
        private System.Windows.Forms.ToolStripMenuItem prestamosFinalizadosTsmi;
        private System.Windows.Forms.ToolStripMenuItem prestamosEnProcesoTsmi;
        public sala(string nombre)
            :base(nombre)
        {
            InitializeComponent();
            this.Text = "Personal de sala: "+nombre;

            this.altaPrestamosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaPrestamosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaPrestamosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePrestamosActivosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoUnoAUnoPrestamosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.verEjemplaresNoDevueltosTsmi= new System.Windows.Forms.ToolStripMenuItem();
            this.devolverEjemplarTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosEnProcesoTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosFinalizadosTsmi= new System.Windows.Forms.ToolStripMenuItem();

            base.tsmiLibros.Visible=false;
            base.tsmiEjemplares.Visible = false;

            this.listadoDePrestamosActivosTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.prestamosFinalizadosTsmi,
                this.prestamosEnProcesoTsmi
            });

            base.prestamosTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPrestamosTsmi,
            this.bajaPrestamosTsmi,
            this.busquedaPrestamosTsmi,
            this.listadoDePrestamosActivosTsmi,
            this.recorridoUnoAUnoPrestamosTsmi,
            this.verEjemplaresNoDevueltosTsmi,
            this.devolverEjemplarTsmi});

            // 
            // altaPrestamosTsmi
            // 
            this.altaPrestamosTsmi.Name = "altaPrestamosTsmi";
            this.altaPrestamosTsmi.Size = new System.Drawing.Size(468, 54);
            this.altaPrestamosTsmi.Text = "Alta";
            this.altaPrestamosTsmi.Click += new System.EventHandler(this.altaPrestamosTsmi_Click);
            // 
            // bajaPrestamosTsmi
            // 
            this.bajaPrestamosTsmi.Name = "bajaPrestamosTsmi";
            this.bajaPrestamosTsmi.Size = new System.Drawing.Size(468, 54);
            this.bajaPrestamosTsmi.Text = "Baja";
            this.bajaPrestamosTsmi.Click += new System.EventHandler(this.bajaPrestamosTsmi_Click);
            // 
            // busquedaPrestamosTsmi
            // 
            this.busquedaPrestamosTsmi.Name = "busquedaPrestamosTsmi";
            this.busquedaPrestamosTsmi.Size = new System.Drawing.Size(468, 54);
            this.busquedaPrestamosTsmi.Text = "Búsqueda";
            this.busquedaPrestamosTsmi.Click += new System.EventHandler(this.busquedaPrestamosTsmi_Click);
            // 
            // listadoDePrestamosActivosTsmi
            // 
            this.listadoDePrestamosActivosTsmi.Name = "listadoDePrestamosActivosTsmi";
            this.listadoDePrestamosActivosTsmi.Size = new System.Drawing.Size(468, 54);
            this.listadoDePrestamosActivosTsmi.Text = "Listado de préstamos";
            // 
            // recorridoUnoAUnoPrestamosTsmi
            // 
            this.recorridoUnoAUnoPrestamosTsmi.Name = "recorridoUnoAUnoPrestamosTsmi";
            this.recorridoUnoAUnoPrestamosTsmi.Size = new System.Drawing.Size(468, 54);
            this.recorridoUnoAUnoPrestamosTsmi.Text = "Recorrido uno a uno";
            this.recorridoUnoAUnoPrestamosTsmi.Click += new System.EventHandler(this.recorridoUnoAUnoPrestamosTsmi_Click);
            // 
            // verEjemplaresNoDevueltosTsmi
            // 
            this.verEjemplaresNoDevueltosTsmi.Name = "verEjemplaresNoDevueltosTsmi";
            this.verEjemplaresNoDevueltosTsmi.Size = new System.Drawing.Size(468, 54);
            this.verEjemplaresNoDevueltosTsmi.Text = "Ejemplares no devueltos";
            this.verEjemplaresNoDevueltosTsmi.Click += new System.EventHandler(this.verEjemplaresNoDevueltosTsmi_Click);
            // 
            // devolverEjemplarTsmi
            // 
            this.devolverEjemplarTsmi.Name = "devolverEjemplarTsmi";
            this.devolverEjemplarTsmi.Size = new System.Drawing.Size(468, 54);
            this.devolverEjemplarTsmi.Text = "Devolver ejemplar";
            this.devolverEjemplarTsmi.Click += new System.EventHandler(this.devolverEjemplarTsmi_Click);
            // 
            // prestamosFinalizadosTsmi
            // 
            this.prestamosFinalizadosTsmi.Name = "prestamosFinalizadosTsmi";
            this.prestamosFinalizadosTsmi.Size = new System.Drawing.Size(468, 54);
            this.prestamosFinalizadosTsmi.Text = "Préstamos finalizados";
            this.prestamosFinalizadosTsmi.Click += new System.EventHandler(this.prestamosFinalizadosTsmi_Click);
            // 
            // prestamosEnProcesoTsmi
            //
            this.prestamosEnProcesoTsmi.Name = "prestamosEnProcesoTsmi";
            this.prestamosEnProcesoTsmi.Size = new System.Drawing.Size(468, 54);
            this.prestamosEnProcesoTsmi.Text = "Préstamos en proceso";
            this.prestamosEnProcesoTsmi.Click += new System.EventHandler(this.prestamosEnProcesoTsmi_Click);

        }

        /// <summary>
        /// Muestra el formulario para dar de alta un prestamo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaPrestamosTsmi_Click(object sender, EventArgs e)
        {
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir DNI";
            introducir.ClaveL.Text = "DNI:";
            DialogResult resultado = introducir.ShowDialog();
            if (DialogResult.OK == resultado)
            {
                if (introducir.Clave != "")
                {
                    if (MNBiblioteca.existeUsuario(introducir.Clave))
                    {
                        alta altaPrestamo = new alta();
                        DateTime fecha = DateTime.Now;
                        altaPrestamo.Text = "Alta de un prestamo";
                        claveUC fechaUC = new claveUC(76, 15, "Fecha:", fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                        claveUC dniUC = new claveUC(76, 45, "DNI:", introducir.Clave);
                        claveUC nombreUC = new claveUC(76, 75, "Nombre:", MNBiblioteca.getNombreUsuario(introducir.Clave));
                        claveUC apellidosUC = new claveUC(76, 105, "Apellidos:", MNBiblioteca.getApellidosUsuario(introducir.Clave));
                        fechaUC.Name = "fechaUC";
                        dniUC.Name = "dniUC";
                        nombreUC.Name = "nombreUC";
                        apellidosUC.Name = "apellidosUC";
                        altaPrestamo.Controls.Add(fechaUC);
                        altaPrestamo.Controls.Add(dniUC);
                        altaPrestamo.Controls.Add(nombreUC);
                        altaPrestamo.Controls.Add(apellidosUC);

                        //List<string> ejemplaresDePrestamo = new List<string>();

                        datoDesplegable listaEjemplares = new datoDesplegable(76, 185);
                        listaEjemplares.DatoDesplegableL.Text = "Ejemplares:";
                        listaEjemplares.Name = "ejemplaresUC";
                        listaEjemplares.DatoDesplegableCb.SelectedIndex = -1;

                        Button aniadirB = new Button();
                        aniadirB.Name = "aniadirB";
                        aniadirB.Text = "Añadir";
                        aniadirB.Size = new System.Drawing.Size(70, 25);
                        aniadirB.Location = new System.Drawing.Point(87, 140);
                        aniadirB.Margin = new System.Windows.Forms.Padding(6);
                        aniadirB.TabIndex = 1;

                        aniadirB.Click += delegate (object se, EventArgs eve)
                        {
                            Introducir introducirLibro=new Introducir();
                            introducirLibro.Text = "Introduce el ISBN de un libro";
                            introducirLibro.ClaveL.Text = "ISBN:";
                            DialogResult result = introducirLibro.ShowDialog();
                            if(DialogResult.OK == result)
                            {
                                if (introducirLibro.Clave != "")
                                {
                                    if (MNBiblioteca.existeLibro(introducirLibro.Clave))
                                    {
                                        List<string> codigos = MNBiblioteca.listaEjemplares(introducirLibro.Clave);
                                        List<string> codigosNOPrestados=new List<string>();
                                        foreach (string codigo in codigos)
                                        {
                                            if (MNBiblioteca.ejemplarDisponible(codigo))
                                            {
                                                codigosNOPrestados.Add(codigo);
                                            }
                                        }
                                        if (codigosNOPrestados.Count <= 0)
                                        {
                                            MessageBox.Show("No existe ningún ejemplar disponible de ese libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        else
                                        {
                                            datosDesplegables ejemplares =new datosDesplegables();
                                            ejemplares.Text = "Listado de ejemplares disponibles";
                                            ejemplares.ClaveL.Text = "Código:";
                                            ejemplares.ClaveDesplegableCb.DataSource = codigosNOPrestados;
                                            ejemplares.ClaveDesplegableCb.SelectedIndex = 0;
                                            DialogResult ejemplarSelect = ejemplares.ShowDialog();
                                            if(ejemplarSelect == DialogResult.OK)
                                            {

                                                //Es posible que tenga cambiar el estado del ejemplar seleccionado a prestado
                                                string cod=(string)ejemplares.ClaveDesplegableCb.SelectedItem;
                                                if (MNBiblioteca.darEjemplarPrestado(cod))
                                                {
                                                    ((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.Items.Add((string)ejemplares.ClaveDesplegableCb.SelectedValue);
                                                    ((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.SelectedIndex = 0;
                                                    ((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.Refresh();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("No se pudo realizar correctamente la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                                

                                            }
                                        }
                                    }
                                    else
                                    {
                                        
                                        MessageBox.Show("No existe ningún libro con ese ISBN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El parametro ISBN es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                }
                            }
                            else
                            {
                                introducirLibro.Close();
                            }
                            introducirLibro.Dispose();
                        };

                        Button eliminarB = new Button();
                        eliminarB.Name = "eliminarB";
                        eliminarB.Text = "Eliminar";
                        eliminarB.Size = new System.Drawing.Size(70, 25);
                        eliminarB.Location = new System.Drawing.Point(185, 140);
                        eliminarB.Margin = new System.Windows.Forms.Padding(6);
                        eliminarB.TabIndex = 0;
                        eliminarB.Click += delegate (object se, EventArgs eve)
                        {
                            if (((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.Items.Count > 0)
                            {
                                string cod2 = (string)((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.SelectedItem;
                                if (MNBiblioteca.devolverEjemplarPrestado(cod2)){
                                    ((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.Items.Remove(((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.SelectedItem);
                                    if (((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.Items.Count > 0)
                                    {
                                        ((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.SelectedIndex = 0;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo eliminar el ejemplar del prestamo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("No hay ejemplares que eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        };
                        
                        altaPrestamo.Controls.Add(aniadirB);
                        altaPrestamo.Controls.Add(eliminarB);
                        altaPrestamo.Controls.Add(listaEjemplares);

                        DialogResult prestamo = altaPrestamo.ShowDialog();
                        if (prestamo == DialogResult.OK)
                        {
                            if (((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.Items.Count<=0)
                            {
                                MessageBox.Show("No se ha introducido ningún ejemplar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.altaPrestamosTsmi_Click(sender, e);
                            }
                            else
                            {
                                //Este es el caso donde se ha introducido al menos un ejemplar
                                //Falta por hacer
                                string dni = ((claveUC)altaPrestamo.Controls["dniUC"]).ClaveTbUC.Text;
                                List<string> codigos = new List<string>();
                                int num = ((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.Items.Count;
                                for(int i = 0; i < num; i++)
                                {
                                    codigos.Add((string)((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.Items[i]);
                                }
                                string[] validformats = new[] { "MM/dd/yyyy", "yyyy/MM/dd", "MM/dd/yyyy HH:mm:ss",
                                        "MM/dd/yyyy hh:mm tt","yyyy-MM-dd HH:mm:ss", "yyyy-MM-dd HH:mm:ss, fff" };

                                CultureInfo provider = CultureInfo.InvariantCulture;
                                DateTime fechaFinal;
                                
                                if (DateTime.TryParseExact(((claveUC)altaPrestamo.Controls["fechaUC"]).ClaveTbUC.Text, validformats, provider,
                                    DateTimeStyles.None, out fechaFinal))
                                {
                                    if (!MNSala.altaPrestamo(dni,codigos,1,fechaFinal))
                                    {
                                        //Entra en este error
                                        MessageBox.Show("No se pudo realizar correctamente la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("La operación se realizó con exito", "Prestamo realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo realizar correctamente la operación", "Error por fecha inesperada", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "No existe ningún usuario con ese DNI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.altaPrestamosTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro DNI es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.altaPrestamosTsmi_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
        }

        /// <summary>
        /// Muestra el formulario para dar de baja un prestamo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bajaPrestamosTsmi_Click(object sender, EventArgs e)
        {
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir DNI";
            introducir.ClaveL.Text = "DNI:";
            DialogResult resultado = introducir.ShowDialog();
            if (DialogResult.OK == resultado)
            {
                if (introducir.Clave != "")
                {
                    if (MNBiblioteca.existeUsuario(introducir.Clave))
                    {
                        List<Prestamo> prestamos = MNSala.getPrestamos(introducir.Clave);
                        List<string> fechasPrestamo = prestamos.Select(p => p.Fecha.ToString("yyyy-MM-dd HH:mm:ss")).ToList();
                        if (prestamos.Count > 0)
                        {
                            datosDesplegables datosPrestamos = new datosDesplegables();
                            datosPrestamos.Size = new System.Drawing.Size(400, 550);
                            datosPrestamos.AceptarAlB.Location = new System.Drawing.Point(145, 450);
                            datosPrestamos.ClaveDesplegableCb.SelectedIndex = -1;
                            datosPrestamos.Text = "Dar de baja prestamo";
                            datosPrestamos.ClaveL.Text = "Fecha:";
                            datosPrestamos.ClaveDesplegableCb.DataSource = null;
                            foreach (string fecha in fechasPrestamo)
                            {
                                datosPrestamos.ClaveDesplegableCb.Items.Add(fecha);
                            }

                            claveUC dniUC = new claveUC(85, 95, "DNI:", introducir.Clave);
                            claveUC nombreUC = new claveUC(85, 125, "Nombre:", MNBiblioteca.getNombreUsuario(introducir.Clave));
                            claveUC apellidosUC = new claveUC(85, 155, "Apellidos:", MNBiblioteca.getApellidosUsuario(introducir.Clave));
                            claveUC estadoUC = new claveUC(85, 185, "Prestamo:");
                            datoDesplegable ejemplaresUC = new datoDesplegable(85, 225);
                            ejemplaresUC.DatoDesplegableL.Text = "Ejemplar:";
                            claveUC estadoEjemplarUC = new claveUC(85, 255, "Ejemplar:");
                            claveUC isbnUC = new claveUC(85, 285, "ISBN:");
                            claveUC tituloUC = new claveUC(85, 315, "Titulo:");
                            claveUC autorUC = new claveUC(85, 345, "Autor:");
                            claveUC editorialUC = new claveUC(85, 375, "Editorial:");

                            dniUC.Name = "dniUC";
                            nombreUC.Name = "nombreUC";
                            apellidosUC.Name = "apellidosUC";
                            estadoUC.Name = "estadoUC";
                            ejemplaresUC.Name = "ejemplaresUC";
                            estadoEjemplarUC.Name = "estadoEjemplarUC";
                            isbnUC.Name = "isbnUC";
                            tituloUC.Name = "tituloUC";
                            autorUC.Name = "autorUC";
                            editorialUC.Name = "editorialUC";


                            datosPrestamos.Controls.Add(dniUC);
                            datosPrestamos.Controls.Add(nombreUC);
                            datosPrestamos.Controls.Add(apellidosUC);
                            datosPrestamos.Controls.Add(estadoUC);
                            datosPrestamos.Controls.Add(ejemplaresUC);
                            datosPrestamos.Controls.Add(estadoEjemplarUC);
                            datosPrestamos.Controls.Add(isbnUC);
                            datosPrestamos.Controls.Add(tituloUC);
                            datosPrestamos.Controls.Add(autorUC);
                            datosPrestamos.Controls.Add(editorialUC);

                            datosPrestamos.ClaveDesplegableCb.DataSource = fechasPrestamo;
                            datosPrestamos.ClaveDesplegableCb.SelectedIndex = -1;
                            datosPrestamos.ClaveDesplegableCb.SelectedIndexChanged += (s, ev) => cambiarDatosBusquedaPorFecha(sender, e, datosPrestamos);
                            ((datoDesplegable)datosPrestamos.Controls["ejemplaresUC"]).DatoDesplegableCb.SelectedIndexChanged += (s, ev) => cambiarDatosBusquedaPorEjemplar(sender, e, datosPrestamos);

                            DialogResult baja= datosPrestamos.ShowDialog();
                            if (baja == DialogResult.OK)
                            {
                                string[] validformats = new[] { "MM/dd/yyyy", "yyyy/MM/dd", "MM/dd/yyyy HH:mm:ss",
                                        "MM/dd/yyyy hh:mm tt","yyyy-MM-dd HH:mm:ss", "yyyy-MM-dd HH:mm:ss, fff" };

                                CultureInfo provider = CultureInfo.InvariantCulture;
                                DateTime fechaFinal;

                                DateTime.TryParseExact((string)datosPrestamos.ClaveDesplegableCb.SelectedValue, validformats, provider, DateTimeStyles.None, out fechaFinal);

                                if (((claveUC)datosPrestamos.Controls["estadoUC"]).ClaveTbUC.Text != "")
                                {
                                    if(((claveUC)datosPrestamos.Controls["estadoUC"]).ClaveTbUC.Text == "EnProceso")
                                    {
                                        MessageBox.Show("No se puede dar de baja el prestamo, por se encuentra en proceso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        if(MNSala.bajaPrestamo(fechaFinal, ((claveUC)datosPrestamos.Controls["dniUC"]).ClaveTbUC.Text))
                                        {
                                            MessageBox.Show("Operación realizada con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Se ha producido un fallo inespeado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        
                                        
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No has introducido ningún prestamo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario especificado no tiene registrado ningún prestamo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "No existe ningún usuario con ese DNI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.bajaPrestamosTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro DNI es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.bajaPrestamosTsmi_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
        }

        /// <summary>
        /// Muestra el formulario para realizar la busqueda de un prestamo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void busquedaPrestamosTsmi_Click(object sender, EventArgs e)
        {
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir DNI";
            introducir.ClaveL.Text = "DNI:";
            DialogResult resultado = introducir.ShowDialog();
            if (DialogResult.OK == resultado)
            {
                if (introducir.Clave != "")
                {
                    if (MNBiblioteca.existeUsuario(introducir.Clave))
                    {
                        List<Prestamo> prestamos = MNSala.getPrestamos(introducir.Clave);
                        List<string> fechasPrestamo=prestamos.Select(p => p.Fecha.ToString("yyyy-MM-dd HH:mm:ss")).ToList();
                        if (prestamos.Count > 0)
                        {
                            datosDesplegables datosPrestamos = new datosDesplegables();
                            datosPrestamos.Size = new System.Drawing.Size(400, 550);
                            datosPrestamos.AceptarAlB.Location = new System.Drawing.Point(145, 450);
                            datosPrestamos.ClaveDesplegableCb.SelectedIndex = -1;
                            datosPrestamos.Text = "Datos del prestamo";
                            datosPrestamos.ClaveL.Text = "Fecha:";
                            datosPrestamos.ClaveDesplegableCb.DataSource = null;
                            foreach (string fecha in fechasPrestamo)
                            {
                                datosPrestamos.ClaveDesplegableCb.Items.Add(fecha);
                            }

                            claveUC dniUC = new claveUC(85, 95, "DNI:", introducir.Clave);
                            claveUC nombreUC = new claveUC(85, 125, "Nombre:", MNBiblioteca.getNombreUsuario(introducir.Clave));
                            claveUC apellidosUC = new claveUC(85, 155, "Apellidos:", MNBiblioteca.getApellidosUsuario(introducir.Clave));
                            claveUC estadoUC = new claveUC(85, 185, "Prestamo:");
                            datoDesplegable ejemplaresUC = new datoDesplegable(85, 225);
                            ejemplaresUC.DatoDesplegableL.Text = "Ejemplar:";
                            claveUC estadoEjemplarUC = new claveUC(85, 255, "Ejemplar:");
                            claveUC isbnUC = new claveUC(85, 285, "ISBN:");
                            claveUC tituloUC = new claveUC(85, 315, "Titulo:");
                            claveUC autorUC = new claveUC(85, 345, "Autor:");
                            claveUC editorialUC = new claveUC(85, 375, "Editorial:");

                            dniUC.Name = "dniUC";
                            nombreUC.Name = "nombreUC";
                            apellidosUC.Name = "apellidosUC";
                            estadoUC.Name = "estadoUC";
                            ejemplaresUC.Name = "ejemplaresUC";
                            estadoEjemplarUC.Name = "estadoEjemplarUC";
                            isbnUC.Name = "isbnUC";
                            tituloUC.Name = "tituloUC";
                            autorUC.Name = "autorUC";
                            editorialUC.Name = "editorialUC";


                            datosPrestamos.Controls.Add(dniUC);
                            datosPrestamos.Controls.Add(nombreUC);
                            datosPrestamos.Controls.Add(apellidosUC);
                            datosPrestamos.Controls.Add(estadoUC);
                            datosPrestamos.Controls.Add(ejemplaresUC);
                            datosPrestamos.Controls.Add(estadoEjemplarUC);
                            datosPrestamos.Controls.Add(isbnUC);
                            datosPrestamos.Controls.Add(tituloUC);
                            datosPrestamos.Controls.Add(autorUC);
                            datosPrestamos.Controls.Add(editorialUC);

                            datosPrestamos.ClaveDesplegableCb.DataSource = fechasPrestamo;
                            datosPrestamos.ClaveDesplegableCb.SelectedIndex = -1;
                            datosPrestamos.ClaveDesplegableCb.SelectedIndexChanged += (s, ev) => cambiarDatosBusquedaPorFecha(sender, e, datosPrestamos);
                            ((datoDesplegable)datosPrestamos.Controls["ejemplaresUC"]).DatoDesplegableCb.SelectedIndexChanged += (s, ev) => cambiarDatosBusquedaPorEjemplar(sender, e, datosPrestamos);

                            datosPrestamos.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("El usuario especificado no tiene registrado ningún prestamo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "No existe ningún usuario con ese DNI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.busquedaPrestamosTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro DNI es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.busquedaPrestamosTsmi_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
        }

        /// <summary>
        /// Actualiza los datos del prestamo representados en el formulario datosPrestamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="datosPrestamos">datosPrestamos!=null</param>
        private void cambiarDatosBusquedaPorFecha(object sender, EventArgs e, datosDesplegables datosPrestamos)
        {
            claveUC estadoUC = (claveUC)datosPrestamos.Controls["estadoUC"];
            datoDesplegable ejemplaresUC = (datoDesplegable)datosPrestamos.Controls["ejemplaresUC"];
            claveUC estadoEjemplarUC = (claveUC)datosPrestamos.Controls["estadoEjemplarUC"];
            claveUC isbnUC = (claveUC)datosPrestamos.Controls["isbnUC"];
            claveUC tituloUC = (claveUC)datosPrestamos.Controls["tituloUC"];
            claveUC autorUC = (claveUC)datosPrestamos.Controls["autorUC"];
            claveUC editorialUC = (claveUC)datosPrestamos.Controls["editorialUC"];


            string fecha = (string)datosPrestamos.ClaveDesplegableCb.SelectedValue;
            string dni =((claveUC)datosPrestamos.Controls["dniUC"]).ClaveTbUC.Text;

            string[] validformats = new[] { "MM/dd/yyyy", "yyyy/MM/dd", "MM/dd/yyyy HH:mm:ss",
                                        "MM/dd/yyyy hh:mm tt","yyyy-MM-dd HH:mm:ss", "yyyy-MM-dd HH:mm:ss, fff" };

            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime fechaFinal;

            DateTime.TryParseExact(fecha, validformats, provider, DateTimeStyles.None, out fechaFinal);
            if (dni != null && fecha !=null)
            {
                Prestamo pre = MNSala.getPrestamo(fechaFinal, dni);
                if (pre.Estado == Estado.EnProceso)
                {
                    MNBiblioteca.calcularEstadoPrestamo(pre);
                }
                Prestamo prestamo = MNSala.getPrestamo(fechaFinal, dni);
                estadoUC.ClaveTbUC.Text=prestamo.Estado.ToString();

                List<Ejemplar> ejemplares = prestamo.EjemPrestados;
                List<string> codigos=ejemplares.Select(ej => ej.Codigo).ToList();
                ejemplaresUC.DatoDesplegableCb.Items.Clear();
                foreach (string codigo in codigos)
                {
                    ejemplaresUC.DatoDesplegableCb.Items.Add(codigo);
                }
                ejemplaresUC.DatoDesplegableCb.SelectedIndex = -1;
                ejemplaresUC.DatoDesplegableCb.Refresh();
               

                estadoEjemplarUC.ClaveTbUC.Text = "";
                isbnUC.ClaveTbUC.Text = "";
                tituloUC.ClaveTbUC.Text = "";
                autorUC.ClaveTbUC.Text = "";
                editorialUC.ClaveTbUC.Text = "";
            }
        }

        /// <summary>
        /// Actualiza los datos de ejemplar del prestamo representados en el formulario datosPrestamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="datosPrestamos">datosPrestamos !=null</param>
        private void cambiarDatosBusquedaPorEjemplar(object sender, EventArgs e, datosDesplegables datosPrestamos)
        {
            claveUC estadoEjemplarUC = (claveUC)datosPrestamos.Controls["estadoEjemplarUC"];
            claveUC isbnUC = (claveUC)datosPrestamos.Controls["isbnUC"];
            claveUC tituloUC = (claveUC)datosPrestamos.Controls["tituloUC"];
            claveUC autorUC = (claveUC)datosPrestamos.Controls["autorUC"];
            claveUC editorialUC = (claveUC)datosPrestamos.Controls["editorialUC"];
            
            string codigo = (string)((datoDesplegable)datosPrestamos.Controls["ejemplaresUC"]).DatoDesplegableCb.SelectedItem;

            if (codigo != null)
            {
                Ejemplar ejemplar=MNBiblioteca.getEjemplar(codigo);
                Libro libro = ejemplar.Libro;
                if (ejemplar.Prestado)
                {
                    estadoEjemplarUC.ClaveTbUC.Text = "Prestado";
                }
                else
                {
                    estadoEjemplarUC.ClaveTbUC.Text = "Devuelto";
                }
                isbnUC.ClaveTbUC.Text = libro.Isbn;
                tituloUC.ClaveTbUC.Text = libro.Titulo;
                autorUC.ClaveTbUC.Text = libro.Autor;
                editorialUC.ClaveTbUC.Text = libro.Editorial;
            }
        }
        
        /// <summary>
        /// Muestra el formulario con los datos de los prestamos ya finalizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prestamosFinalizadosTsmi_Click(object sender, EventArgs e)
        {
            List<Prestamo> prestamos = MNSala.getPrestamosFinalizados();
            List<Prestamo> prestamosActualizados = new List<Prestamo>();
            foreach (Prestamo prestamo in prestamos)
            {
                if (prestamo.Estado == Estado.EnProceso)
                {
                    Prestamo pre = MNSala.getPrestamo(prestamo.Fecha, prestamo.Usuario.Dni);
                    MNBiblioteca.calcularEstadoPrestamo(pre);
                }              
                Prestamo prestamoActualizado = MNSala.getPrestamo(prestamo.Fecha, prestamo.Usuario.Dni);
                prestamosActualizados.Add(prestamoActualizado);
            }
            prestamosDg form = new prestamosDg(prestamosActualizados, "Listado de préstamos finalizados");
            form.ShowDialog();
        }

        /// <summary>
        /// Muestra el formulario con los datos de los prestamos en proceso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prestamosEnProcesoTsmi_Click(object sender, EventArgs e)
        {
            List<Prestamo> prestamos = MNSala.getPrestamosEnProceso();
            List<Prestamo> prestamosActualizados=new List<Prestamo>();
            foreach (Prestamo prestamo in prestamos)
            {
                if (prestamo.Estado == Estado.EnProceso)
                {
                    Prestamo pre = MNSala.getPrestamo(prestamo.Fecha, prestamo.Usuario.Dni);
                    MNBiblioteca.calcularEstadoPrestamo(pre);
                }
                Prestamo prestamoActualizado = MNSala.getPrestamo(prestamo.Fecha, prestamo.Usuario.Dni);
                prestamosActualizados.Add(prestamoActualizado);
            }
            prestamosDg form = new prestamosDg(prestamosActualizados,"Listado de préstamos en proceso");
            form.ShowDialog();
        }

        /// <summary>
        /// Muestra el formulario con los datos de todos los prestamos pudiendo recorrerlos de uno en uno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recorridoUnoAUnoPrestamosTsmi_Click(object sender, EventArgs e)
        {
            rocorridoUnoaUno recorrido = new rocorridoUnoaUno();
            recorrido.Text = "Recorrido de prestamos uno a uno";
            recorrido.Size = new System.Drawing.Size(400, 500);
            List<Prestamo> listaPrestamos = MNSala.getPrestamos();

            List<Prestamo> prestamosActualizados = new List<Prestamo>();
            foreach (Prestamo prestamo in listaPrestamos)
            {
                if (prestamo.Estado == Estado.EnProceso)
                {
                    Prestamo pre = MNSala.getPrestamo(prestamo.Fecha, prestamo.Usuario.Dni);
                    MNBiblioteca.calcularEstadoPrestamo(pre);
                }
                Prestamo prestamoActualizado = MNSala.getPrestamo(prestamo.Fecha, prestamo.Usuario.Dni);
                prestamosActualizados.Add(prestamoActualizado);
            }

            claveUC fechaUC = new claveUC(85, 65, "Fecha:");
            claveUC dniUC = new claveUC(85, 95, "DNI:");
            claveUC nombreUC = new claveUC(85, 125, "Nombre:");
            claveUC apellidosUC = new claveUC(85, 155, "Apellidos:");
            claveUC estadoUC = new claveUC(85, 185, "Prestamo:");
            datoDesplegable ejemplaresUC = new datoDesplegable(85, 225);
            ejemplaresUC.DatoDesplegableL.Text = "Ejemplar:";
            claveUC estadoEjemplarUC = new claveUC(85, 255, "Ejemplar:");
            claveUC isbnUC = new claveUC(85, 285, "ISBN:");
            claveUC tituloUC = new claveUC(85, 315, "Titulo:");
            claveUC autorUC = new claveUC(85, 345, "Autor:");
            claveUC editorialUC = new claveUC(85, 375, "Editorial:");

            fechaUC.Name = "fechaUC";
            dniUC.Name = "dniUC";
            nombreUC.Name = "nombreUC";
            apellidosUC.Name = "apellidosUC";
            estadoUC.Name = "estadoUC";
            ejemplaresUC.Name = "ejemplaresUC";
            estadoEjemplarUC.Name = "estadoEjemplarUC";
            isbnUC.Name = "isbnUC";
            tituloUC.Name = "tituloUC";
            autorUC.Name = "autorUC";
            editorialUC.Name = "editorialUC";

            recorrido.Controls.Add(fechaUC);
            recorrido.Controls.Add(dniUC);
            recorrido.Controls.Add(nombreUC);
            recorrido.Controls.Add(apellidosUC);
            recorrido.Controls.Add(estadoUC);
            recorrido.Controls.Add(ejemplaresUC);
            recorrido.Controls.Add(estadoEjemplarUC);
            recorrido.Controls.Add(isbnUC);
            recorrido.Controls.Add(tituloUC);
            recorrido.Controls.Add(autorUC);
            recorrido.Controls.Add(editorialUC);

            foreach (Prestamo p in prestamosActualizados)
            {
                recorrido.BindingNavigator.BindingSource.Add(p);
            }
            recorrido.BindingNavigatorPositionItem.TextChanged += (s, ev) => cambiarDatosPrestamoUnoaUno(sender, e, recorrido);
            ((datoDesplegable)recorrido.Controls["ejemplaresUC"]).DatoDesplegableCb.SelectedIndexChanged += (s, ev) => cambiarDatosPrestamoPorEjemplarUnoAUno(sender, e, recorrido);

            this.cambiarDatosPrestamoUnoaUno(sender, e, recorrido);

            recorrido.ShowDialog();
        }

        /// <summary>
        /// Actualiza los datos de ejemplar del prestamo representados en el formulario recorrido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="recorrido">recorrido!=null</param>
        private void cambiarDatosPrestamoPorEjemplarUnoAUno(object sender, EventArgs e, rocorridoUnoaUno recorrido)
        {
            claveUC estadoEjemplarUC = (claveUC)recorrido.Controls["estadoEjemplarUC"];
            claveUC isbnUC = (claveUC)recorrido.Controls["isbnUC"];
            claveUC tituloUC = (claveUC)recorrido.Controls["tituloUC"];
            claveUC autorUC = (claveUC)recorrido.Controls["autorUC"];
            claveUC editorialUC = (claveUC)recorrido.Controls["editorialUC"];

            string codigo = (string)((datoDesplegable)recorrido.Controls["ejemplaresUC"]).DatoDesplegableCb.SelectedItem;

            if (codigo != null)
            {
                Ejemplar ejemplar = MNBiblioteca.getEjemplar(codigo);
                Libro libro = ejemplar.Libro;
                if (ejemplar.Prestado)
                {
                    estadoEjemplarUC.ClaveTbUC.Text = "Prestado";
                }
                else
                {
                    estadoEjemplarUC.ClaveTbUC.Text = "Devuelto";
                }
                isbnUC.ClaveTbUC.Text = libro.Isbn;
                tituloUC.ClaveTbUC.Text = libro.Titulo;
                autorUC.ClaveTbUC.Text = libro.Autor;
                editorialUC.ClaveTbUC.Text = libro.Editorial;
            }
        }

        /// <summary>
        /// Actualiza los datos del prestamo representados en el formulario recorrido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="recorrido">recorrido !=null</param>
        private void cambiarDatosPrestamoUnoaUno(object sender, EventArgs e, rocorridoUnoaUno recorrido)
        {
            claveUC fechaUC = (claveUC)recorrido.Controls["fechaUC"];
            claveUC dniUC = (claveUC)recorrido.Controls["dniUC"];
            claveUC nombreUC = (claveUC)recorrido.Controls["nombreUC"];
            claveUC apellidosUC = (claveUC)recorrido.Controls["apellidosUC"];
            claveUC estadoUC = (claveUC)recorrido.Controls["estadoUC"];
            datoDesplegable ejemplaresUC = (datoDesplegable)recorrido.Controls["ejemplaresUC"];
            claveUC estadoEjemplarUC = (claveUC)recorrido.Controls["estadoEjemplarUC"];
            claveUC isbnUC = (claveUC)recorrido.Controls["isbnUC"];
            claveUC tituloUC = (claveUC)recorrido.Controls["tituloUC"];
            claveUC autorUC = (claveUC)recorrido.Controls["autorUC"];
            claveUC editorialUC = (claveUC)recorrido.Controls["editorialUC"];

            Prestamo p = (Prestamo)recorrido.BindingNavigator.BindingSource.Current;
            List<string> codigos = new List<string>();
            string fecha = "";
            string dni = "";
            string nombre = "";
            string apellidos = "";
            string estadoPrestamo = "";
            string estadoEjemplar = "";
            string isbn = "";
            string titulo = "";
            string autor = "";
            string editorial = "";
            if (p != null)
            {
                MNBiblioteca.calcularEstadoPrestamo(p);
                codigos = p.EjemPrestados.Select(pr => pr.Codigo).ToList();
                fecha=p.Fecha.ToString("yyyy-MM-dd HH:mm:ss");
                dni = p.Usuario.Dni;
                nombre = p.Usuario.Nombre;
                apellidos = p.Usuario.Apellidos;
                estadoPrestamo = p.Estado.ToString();
            }
            fechaUC.ClaveTbUC.Text = fecha;
            dniUC.ClaveTbUC.Text = dni;
            nombreUC.ClaveTbUC.Text = nombre;
            apellidosUC.ClaveTbUC.Text = apellidos;
            estadoUC.ClaveTbUC.Text = estadoPrestamo;
            ejemplaresUC.DatoDesplegableCb.SelectedIndex = -1;
            ejemplaresUC.DatoDesplegableCb.Items.Clear();
            foreach (string cod in codigos)
            {
                ejemplaresUC.DatoDesplegableCb.Items.Add(cod);
            }
            estadoEjemplarUC.ClaveTbUC.Text = estadoEjemplar;
            isbnUC.ClaveTbUC.Text = isbn;
            tituloUC.ClaveTbUC.Text = titulo;
            autorUC.ClaveTbUC.Text = autor;
            editorialUC.ClaveTbUC.Text = editorial;


        }

        /// <summary>
        /// Muestra el formulario con los datos de los ejemplares no devueltos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verEjemplaresNoDevueltosTsmi_Click(object sender, EventArgs e)
        {
            List<Ejemplar> ejemplares = MNBiblioteca.getEjemplaresNoDevueltos();
            List<string> codigos = new List<string>();
            foreach(Ejemplar ejemplar in ejemplares)
            {
                codigos.Add(ejemplar.Codigo);
            }
            datosDesplegables datosEjemplar = new datosDesplegables();

            datosEjemplar.ClaveDesplegableCb.SelectedIndex = -1;
            datosEjemplar.Text = "Ejemplares no duevueltos";
            datosEjemplar.ClaveL.Text = "Código:";
            datosEjemplar.ClaveDesplegableCb.DataSource = null;
            foreach (string codigo in codigos)
            {
                datosEjemplar.ClaveDesplegableCb.Items.Add(codigo);
            }

            claveUC isbnUC = new claveUC(85, 95, "ISBN:");
            claveUC tituloUC = new claveUC(85, 125, "Titulo:");
            claveUC autorUC = new claveUC(85, 155, "Autor:");
            claveUC editorialUC = new claveUC(85, 185, "Editorial:");

            isbnUC.Name = "isbnUC";
            tituloUC.Name = "tituloUC";
            autorUC.Name = "autorUC";
            editorialUC.Name = "editorialUC";

            datosEjemplar.Controls.Add(isbnUC);
            datosEjemplar.Controls.Add(tituloUC);
            datosEjemplar.Controls.Add(autorUC);
            datosEjemplar.Controls.Add(editorialUC);

            datosEjemplar.ClaveDesplegableCb.DataSource = codigos;
            datosEjemplar.ClaveDesplegableCb.SelectedIndex = -1;
            datosEjemplar.ClaveDesplegableCb.SelectedIndexChanged += (s, ev) => cambiarEjemplaresNoDevueltos(sender, e, datosEjemplar);
            datosEjemplar.ShowDialog();
        }

        /// <summary>
        /// Actualiza los datos de ejemplar del prestamo no devuelto representados en el formulario datosPrestamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="datosEjemplar">datosEjemplar!=null</param>
        private void cambiarEjemplaresNoDevueltos(object sender, EventArgs e, datosDesplegables datosEjemplar)
        {
            claveUC isbnUC = (claveUC)datosEjemplar.Controls["isbnUC"];
            claveUC tituloUC = (claveUC)datosEjemplar.Controls["tituloUC"];
            claveUC autorUC = (claveUC)datosEjemplar.Controls["autorUC"];
            claveUC editorialUC = (claveUC)datosEjemplar.Controls["editorialUC"];

            string codigo = datosEjemplar.ClaveDesplegableCb.SelectedItem as string;

            if (codigo != null)
            {
                Ejemplar ejemplar = MNBiblioteca.getEjemplar(codigo);
                Libro libro = ejemplar.Libro;
                isbnUC.ClaveTbUC.Text = libro.Isbn;
                tituloUC.ClaveTbUC.Text = libro.Titulo;
                autorUC.ClaveTbUC.Text = libro.Autor;
                editorialUC.ClaveTbUC.Text = libro.Editorial;
            }
        }

        /// <summary>
        /// Muestra el formulario para devolver un ejemplar prestado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void devolverEjemplarTsmi_Click(object sender, EventArgs e)
        {
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir Código de ejemplar";
            introducir.ClaveL.Text = "Código:";
            DialogResult resultado = introducir.ShowDialog();
            if (DialogResult.OK == resultado)
            {
                if (introducir.Clave != "")
                {
                    if (MNBiblioteca.existeEjemplar(introducir.Clave))
                    {
                        if (MNBiblioteca.estaPrestado(introducir.Clave))
                        {
                            MNBiblioteca.actualizarEstadoDeEjemplarEnPrestamo(false, introducir.Clave);
                            MNBiblioteca.devolverEjemplarPrestado(introducir.Clave); 
                            MessageBox.Show("La operación se realizó con exito", "Ejemplar devuelto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El ejemplar introducido no está prestado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (error == DialogResult.OK)
                            {
                                this.devolverEjemplarTsmi_Click(sender, e);
                            }
                        }
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "No existe ningún ejemplar con ese Código", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.devolverEjemplarTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro Código es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.devolverEjemplarTsmi_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
        }

    }
}
