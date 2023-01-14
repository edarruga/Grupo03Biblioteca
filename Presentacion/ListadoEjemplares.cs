using ModeloDeDominio;
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
    public partial class ListadoEjemplares : Form
    {
        private List<Ejemplar> lista;

        public ListadoEjemplares()
        {
            InitializeComponent();
        }

        public ListadoEjemplares(List<Ejemplar> lista)
        {
            this.lista = lista;
            InitializeComponent();
            this.aniadirDatos();
        }
        /// <summary>
        /// Ordena los valores de los ejemplares por su código, y actualiza todas las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCodigo_Click(object sender, EventArgs e)
        {
            ordenarPorCodigo();
            this.eliminarDatos();
            this.aniadirDatos();
        }
        /// <summary>
        /// Ordena los valores de los ejemplares por su ISBN, y actualiza todas las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bISBN_Click(object sender, EventArgs e)
        {
            ordenarPorISBN();
            this.eliminarDatos();
            this.aniadirDatos();
        }
        /// <summary>
        /// Ordena los valores de los ejemplares por su titulo, y actualiza todas las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bTitulo_Click(object sender, EventArgs e)
        {
            ordenarPorTitulo();
            this.eliminarDatos();
            this.aniadirDatos();
        }
        /// <summary>
        /// Ordena los valores de los ejemplares por su autor, y actualiza todas las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAutor_Click(object sender, EventArgs e)
        {
            ordenarPorAutor();
            this.eliminarDatos();
            this.aniadirDatos();
        }
        /// <summary>
        /// Ordena los valores de los ejemplares por su editorial, y actualiza todas las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bEditorial_Click(object sender, EventArgs e)
        {
            ordenarPorEditorial();
            this.eliminarDatos();
            this.aniadirDatos();
        }
        /// <summary>
        /// Elimina los datos de los ejemplares de todas las listas
        /// </summary>
        private void eliminarDatos()
        {
            this.lbCodigo.Items.Clear();
            this.lbPrestado.Items.Clear();
            this.lbAutor.Items.Clear();
            this.lbEditorial.Items.Clear();
            this.lbISBN.Items.Clear();
            this.lbTitulo.Items.Clear();
        }
        /// <summary>
        /// Añade los datos de los ejemplares especificos a sus respectivas listas
        /// </summary>
        private void aniadirDatos()
        {
            foreach (Ejemplar e in this.lista)
            {
                this.lbCodigo.Items.Add(e.Codigo);
                if (e.Prestado) this.lbPrestado.Items.Add("Si");
                else this.lbPrestado.Items.Add("No");
                this.lbISBN.Items.Add(e.Libro.Isbn);
                this.lbAutor.Items.Add(e.Libro.Autor);
                this.lbTitulo.Items.Add(e.Libro.Titulo);
                this.lbEditorial.Items.Add(e.Libro.Editorial);
            }
        }
        /// <summary>
        /// Ordena los valores de los ejemplares por su código
        /// </summary>
        private void ordenarPorCodigo()
        {
            List<Ejemplar> ordenada = this.lista.OrderBy(e => e.Codigo).ToList();
            this.lista = ordenada;
        }
        /// <summary>
        /// Ordena los valores de los ejemplares por su ISBN
        /// </summary>
        private void ordenarPorISBN()
        {
            List<Ejemplar> ordenada = this.lista.OrderBy(e => e.Libro.Isbn).ToList();
            this.lista = ordenada;
        }
        /// <summary>
        /// Ordena los valores de los ejemplares por su titulo
        /// </summary>
        private void ordenarPorTitulo()
        {
            List<Ejemplar> ordenada = this.lista.OrderBy(e => e.Libro.Titulo).ToList();
            this.lista = ordenada;
        }
        /// <summary>
        /// Ordena los valores de los ejemplares por su autor
        /// </summary>
        private void ordenarPorAutor()
        {
            List<Ejemplar> ordenada = this.lista.OrderBy(e => e.Libro.Autor).ToList();
            this.lista = ordenada;
        }
        /// <summary>
        /// Ordena los valores de los ejemplares por su editorial
        /// </summary>
        private void ordenarPorEditorial()
        {
            List<Ejemplar> ordenada = this.lista.OrderBy(e => e.Libro.Editorial).ToList();
            this.lista = ordenada;
        }
        /// <summary>
        /// Cierra el formulario de listado de ejemplares
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarb_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
