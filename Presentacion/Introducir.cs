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
    public partial class Introducir : Form
    {
        private string clave=null;
        public Label ClaveL {
            get { return this.claveL; }
        }
        public string Clave
        {
            get { return this.clave; }
        }
        
        public Introducir()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Modifica el parametro clave del objeto con el valor que se encuentre en el textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aceptarB_Click(object sender, EventArgs e)
        {
            this.clave = this.claveTb.Text;
        }
        /// <summary>
        /// Cierra el formulario Introducir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cancelarB_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
