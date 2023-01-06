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
        private void aniadirDatos()
        {
            foreach(Usuario u in this.lista)
            {
                this.dniLb.Items.Add(u.Dni);
                this.nombreLb.Items.Add(u.Nombre);
                this.apellidosLb.Items.Add(u.Apellidos);
            }
        }
        private void eliminarDatos()
        {
            this.dniLb.Items.Clear();
            this.nombreLb.Items.Clear();
            this.apellidosLb.Items.Clear();
        }
        private void ordenarPorDNI()
        {
            List<Usuario> ordenada=this.lista.OrderBy(usuario => usuario.Dni).ToList();
            this.lista=ordenada;
        }
        private void ordenarPorNombre()
        {
            List<Usuario> ordenada = this.lista.OrderBy(usuario => usuario.Nombre).ToList();
            this.lista = ordenada;
        }
        private void ordenarPorApellidos()
        {
            List<Usuario> ordenada = this.lista.OrderBy(usuario => usuario.Apellidos).ToList();
            this.lista = ordenada;
        }

        private void cerrarb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dnib_Click(object sender, EventArgs e)
        {
            this.ordenarPorDNI();
            this.eliminarDatos();
            this.aniadirDatos();
        }

        private void nombreb_Click(object sender, EventArgs e)
        {
            this.ordenarPorNombre();
            this.eliminarDatos();
            this.aniadirDatos();
        }

        private void apellidosb_Click(object sender, EventArgs e)
        {
            this.ordenarPorApellidos();
            this.eliminarDatos();
            this.aniadirDatos();
        }
    }
}
