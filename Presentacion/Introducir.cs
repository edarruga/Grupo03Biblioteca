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

        private void aceptarB_Click(object sender, EventArgs e)
        {
            this.clave = this.claveTb.Text;
        }

        private void cancelarB_Click(object sender, EventArgs e)
        {
            this.Close();
            // PREGUNTAR SI ES NECESARIO DISPOSE AQUI
        }
    }
}
