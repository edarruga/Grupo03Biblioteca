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
    public partial class ListadoLibros : Form
    {
        private List<Libro> lista;

        public ListadoLibros()
        {
            InitializeComponent();
        }

        public ListadoLibros(List<Libro> lista)
        {
            this.lista = lista;
            InitializeComponent();
            this.aniadirDatos();
        }
        /// <summary>
        /// Ordena los valores de los libros por su ISBN, y actualiza todas las listas
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
        /// Ordena los valores de los libros por su titulo, y actualiza todas las listas
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
        /// Ordena los valores de los libros por su autor, y actualiza todas las listas
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
        /// Ordena los valores de los libros por su editorial, y actualiza todas las listas
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
        /// Elimina los datos de los libros de todas las listas
        /// </summary>
        private void eliminarDatos()
        {
            this.lbAutor.Items.Clear();
            this.lbEditorial.Items.Clear();
            this.lbISBN.Items.Clear();
            this.lbTitulo.Items.Clear();
        }

        /// <summary>
        /// Añade los datos de los elibros especificos a sus respectivas listas
        /// </summary>
        private void aniadirDatos()
        {
            foreach (Libro l in this.lista)
            {
                this.lbISBN.Items.Add(l.Isbn);
                this.lbAutor.Items.Add(l.Autor);
                this.lbTitulo.Items.Add(l.Titulo);
                this.lbEditorial.Items.Add(l.Editorial);
            }
        }

        /// <summary>
        /// Ordena los valores de los libros por su ISBN
        /// </summary>
        private void ordenarPorISBN()
        {
            List<Libro> ordenada = this.lista.OrderBy(l => l.Isbn).ToList();
            this.lista = ordenada;
        }

        /// <summary>
        /// Ordena los valores de los libros por su titulo
        /// </summary>
        private void ordenarPorTitulo()
        {
            List<Libro> ordenada = this.lista.OrderBy(l => l.Titulo).ToList();
            this.lista = ordenada;
        }

        /// <summary>
        /// Ordena los valores de los libros por su autor
        /// </summary>
        private void ordenarPorAutor()
        {
            List<Libro> ordenada = this.lista.OrderBy(l => l.Autor).ToList();
            this.lista = ordenada;
        }

        /// <summary>
        /// Ordena los valores de los libros por su editorial
        /// </summary>

        private void ordenarPorEditorial()
        {
            List<Libro> ordenada = this.lista.OrderBy(l => l.Editorial).ToList();
            this.lista = ordenada;
        }

        /// <summary>
        /// Cierra el formulario de listado de libros
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
