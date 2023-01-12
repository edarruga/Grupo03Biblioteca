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
                                    codigos.Add((string)((datoDesplegable)altaPrestamo.Controls["ejemplaresUC"]).DatoDesplegableCb.Items[0]);
                                }
                                string[] validformats = new[] { "MM/dd/yyyy", "yyyy/MM/dd", "MM/dd/yyyy HH:mm:ss",
                                        "MM/dd/yyyy hh:mm tt","yyyy-MM-dd HH:mm", "yyyy-MM-dd HH:mm:ss, fff" };

                                CultureInfo provider = CultureInfo.InvariantCulture;
                                DateTime fechaFinal;
                                
                                if (DateTime.TryParseExact(((claveUC)altaPrestamo.Controls["fechaUC"]).ClaveTbUC.Text, validformats, provider,
                                    DateTimeStyles.None, out fechaFinal))
                                {
                                    if (!MNSala.altaPrestamo(dni,codigos,1,fechaFinal))
                                    {
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
