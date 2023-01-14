using ModeloDeDominio;
using ModeloDeNegocio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class prestamosDg : Form
    {
        private List<Prestamo> prestamos;
        public prestamosDg()
        {
            InitializeComponent();
        }
        public prestamosDg(List<Prestamo> p,string texto)
        {
            InitializeComponent();
            this.prestamos= p;
            this.Text= texto;
        }

        /// <summary>
        /// Carga los datos de los prestamos del objeto prestamosDg en un DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prestamosDg_Load(object sender, EventArgs e)
        {
            if (this.prestamos.Count > 0)
            {
                this.dataGridView1.BackgroundColor = SystemColors.Control;
                DataGridViewColumn numeroPrestamo = new DataGridViewTextBoxColumn();
                numeroPrestamo.HeaderText = "Número de préstamo";
                DataGridViewColumn dni = new DataGridViewTextBoxColumn();
                dni.HeaderText = "DNI usuario";
                DataGridViewColumn nombre = new DataGridViewTextBoxColumn();
                nombre.HeaderText = "Nombre usuario";
                DataGridViewColumn apellidos = new DataGridViewTextBoxColumn();
                apellidos.HeaderText = "Apellidos usuario";
                DataGridViewColumn fecha = new DataGridViewTextBoxColumn();
                fecha.HeaderText = "Fecha préstamo";
                DataGridViewColumn ejemplares = new DataGridViewTextBoxColumn();
                ejemplares.HeaderText = "Ejemplares préstamo";
                DataGridViewColumn caducado = new DataGridViewTextBoxColumn();
                caducado.HeaderText = "Préstamo caducado";
                this.dataGridView1.Columns.Add(numeroPrestamo);
                this.dataGridView1.Columns.Add(dni);
                this.dataGridView1.Columns.Add(nombre);
                this.dataGridView1.Columns.Add(apellidos);
                this.dataGridView1.Columns.Add(fecha);
                this.dataGridView1.Columns.Add(ejemplares);
                this.dataGridView1.Columns.Add(caducado);
                int i = 0;
                foreach (Prestamo prestamo in prestamos)
                {
                    this.dataGridView1.Rows.Add();
                    this.dataGridView1[0, i].Value = i+1;
                    this.dataGridView1[1, i].Value = prestamo.Usuario.Dni;
                    this.dataGridView1[2, i].Value = prestamo.Usuario.Nombre;
                    this.dataGridView1[3, i].Value = prestamo.Usuario.Apellidos;
                    this.dataGridView1[4, i].Value = prestamo.Fecha;
                    foreach (Ejemplar ej in prestamo.EjemPrestados)
                    {
                        this.dataGridView1[5, i].Value += ej.Codigo + " ";
                    }
                    if (MNSala.prestamoFueraPlazo(prestamo))
                    {
                        this.dataGridView1[6, i].Value = "Caducado";
                    }
                    else
                    {
                        this.dataGridView1[6, i].Value = " ";
                    }
                    
                    i++;
                }
            }
            else
            {
                MessageBox.Show("No existen préstamos en proceso actualmente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
