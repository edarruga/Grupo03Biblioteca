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

        private void bISBN_Click(object sender, EventArgs e)
        {
            ordenarPorISBN();
            this.eliminarDatos();
            this.aniadirDatos();
        }

        private void bTitulo_Click(object sender, EventArgs e)
        {
            ordenarPorTitulo();
            this.eliminarDatos();
            this.aniadirDatos();
        }

        private void bAutor_Click(object sender, EventArgs e)
        {
            ordenarPorAutor();
            this.eliminarDatos();
            this.aniadirDatos();
        }

        private void bEditorial_Click(object sender, EventArgs e)
        {
            ordenarPorEditorial();
            this.eliminarDatos();
            this.aniadirDatos();
        }

        private void eliminarDatos()
        {
            this.lbAutor.Items.Clear();
            this.lbEditorial.Items.Clear();
            this.lbISBN.Items.Clear();
            this.lbTitulo.Items.Clear();
        }
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

        private void ordenarPorISBN()
        {
            List<Libro> ordenada = this.lista.OrderBy(l => l.Isbn).ToList();
            this.lista = ordenada;
        }

        private void ordenarPorTitulo()
        {
            List<Libro> ordenada = this.lista.OrderBy(l => l.Titulo).ToList();
            this.lista = ordenada;
        }

        private void ordenarPorAutor()
        {
            List<Libro> ordenada = this.lista.OrderBy(l => l.Autor).ToList();
            this.lista = ordenada;
        }

        private void ordenarPorEditorial()
        {
            List<Libro> ordenada = this.lista.OrderBy(l => l.Editorial).ToList();
            this.lista = ordenada;
        }

        private void cerrarb_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
