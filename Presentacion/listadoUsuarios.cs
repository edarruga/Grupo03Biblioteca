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
    public partial class listadoUsuarios : Form
    {
        private List<Usuario> lista;
        public listadoUsuarios(List<Usuario> l)
        {
            InitializeComponent();
            this.lista = l;
            this.aniadirDatos();
        }

        /// <summary>
        /// Añade los datos de los usuarios a sus respectivas listas
        /// </summary>
        private void aniadirDatos()
        {
            foreach(Usuario u in this.lista)
            {
                this.dniLb.Items.Add(u.Dni);
                this.nombreLb.Items.Add(u.Nombre);
                this.apellidosLb.Items.Add(u.Apellidos);
            }
        }

        /// <summary>
        /// Elimina todos los datos de los usuarios de cada una de las listas
        /// </summary>
        private void eliminarDatos()
        {
            this.dniLb.Items.Clear();
            this.nombreLb.Items.Clear();
            this.apellidosLb.Items.Clear();
        }

        /// <summary>
        /// Ordena los valores de los usuarios por su DNI
        /// </summary>
        private void ordenarPorDNI()
        {
            List<Usuario> ordenada=this.lista.OrderBy(usuario => usuario.Dni).ToList();
            this.lista=ordenada;
        }

        /// <summary>
        /// Ordena los valores de los usuarios por su nombre
        /// </summary>
        private void ordenarPorNombre()
        {
            List<Usuario> ordenada = this.lista.OrderBy(usuario => usuario.Nombre).ToList();
            this.lista = ordenada;
        }

        /// <summary>
        /// Ordena los valores de los usuarios por sus apellidos
        /// </summary>
        private void ordenarPorApellidos()
        {
            List<Usuario> ordenada = this.lista.OrderBy(usuario => usuario.Apellidos).ToList();
            this.lista = ordenada;
        }

        /// <summary>
        /// Cierra el formulario de listado de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Ordena los valores de los usuarios por su DNI, y actualiza todas las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dnib_Click(object sender, EventArgs e)
        {
            this.ordenarPorDNI();
            this.eliminarDatos();
            this.aniadirDatos();
        }

        /// <summary>
        /// Ordena los valores de los usuarios por su nombre, y actualiza todas las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nombreb_Click(object sender, EventArgs e)
        {
            this.ordenarPorNombre();
            this.eliminarDatos();
            this.aniadirDatos();
        }

        /// <summary>
        /// Ordena los valores de los usuarios por sus apellidos, y actualiza todas las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void apellidosb_Click(object sender, EventArgs e)
        {
            this.ordenarPorApellidos();
            this.eliminarDatos();
            this.aniadirDatos();
        }
    }
}
