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
    public partial class listado : Form
    {
        public listado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cierra el formulario de listado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
