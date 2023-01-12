using ModeloDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class sala : gestionDeBiblioteca
    {
        private System.Windows.Forms.ToolStripMenuItem altaPrestamosTsmi;
        private System.Windows.Forms.ToolStripMenuItem bajaPrestamosTsmi;
        private System.Windows.Forms.ToolStripMenuItem listadoDePrestamosActivosTsmi;
        private System.Windows.Forms.ToolStripMenuItem recorridoUnoAUnoPrestamosTsmi;
        public sala(string nombre)
            :base(nombre)
        {
            InitializeComponent();
            this.Text = "Personal de sala: "+nombre;

            this.altaPrestamosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaPrestamosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePrestamosActivosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoUnoAUnoPrestamosTsmi = new System.Windows.Forms.ToolStripMenuItem();

            base.tsmiLibros.Visible=false;
            base.tsmiEjemplares.Visible = false;

            base.prestamosTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPrestamosTsmi,
            this.bajaPrestamosTsmi,
            this.listadoDePrestamosActivosTsmi,
            this.recorridoUnoAUnoPrestamosTsmi});

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
            // listadoDePrestamosActivosTsmi
            // 
            this.listadoDePrestamosActivosTsmi.Name = "listadoDePrestamosActivosTsmi";
            this.listadoDePrestamosActivosTsmi.Size = new System.Drawing.Size(468, 54);
            this.listadoDePrestamosActivosTsmi.Text = "Listado de préstamos";
            this.listadoDePrestamosActivosTsmi.Click += new System.EventHandler(this.listadoDePrestamosActivosTsmi_Click);
            // 
            // recorridoUnoAUnoPrestamosTsmi
            // 
            this.recorridoUnoAUnoPrestamosTsmi.Name = "recorridoUnoAUnoPrestamosTsmi";
            this.recorridoUnoAUnoPrestamosTsmi.Size = new System.Drawing.Size(468, 54);
            this.recorridoUnoAUnoPrestamosTsmi.Text = "Recorrido uno a uno";
            this.recorridoUnoAUnoPrestamosTsmi.Click += new System.EventHandler(this.recorridoUnoAUnoPrestamosTsmi_Click);

        }

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
                        claveUC fechaUC = new claveUC(76, 15, "Fecha:", fecha.ToString("yyyy-MM-dd HH:mm"));
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
                                        List<string> codigos = MNBiblioteca.listaEemplares(introducirLibro.Clave);
                                        List<string> codigosNOPrestados=new List<string>();
                                        foreach (string codigo in codigos)
                                        {
                                            if (MNBiblioteca.ejemplarPrestado)
                                            {
                                                codigosNOPrestados.Add(codigo);
                                            }
                                        }
                                        if (codigosNOPrestados.Count <= 0)
                                        {
                                            MessageBox.Show("Error", "No existe ningún ejemplar disponible de ese libro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        else
                                        {

                                        }
                                    }
                                    else
                                    {
                                        
                                        MessageBox.Show("Error", "No existe ningún libro con ese ISBN", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error", "El parametro ISBN es obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                        eliminarB.TabIndex = 1;

                        datoDesplegable listaEjemplares = new datoDesplegable(76, 185);
                        listaEjemplares.DatoDesplegableL.Text = "Ejemplares:";
                        listaEjemplares.Name = "ejemplaresUC";


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
                                if (!ModeloDeNegocio.MNBiblioteca.altaUsuario(introducir.Clave, ((datoUC)altaPrestamo.Controls["nombreUC"]).Dato, ((datoUC)altaPrestamo.Controls["apellidosUC"]).Dato))
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
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "No existe un prestamo con ese DNI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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

        private void bajaPrestamosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void listadoDePrestamosActivosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void recorridoUnoAUnoPrestamosTsmi_Click(object sender, EventArgs e)
        {

        }
    }
}
