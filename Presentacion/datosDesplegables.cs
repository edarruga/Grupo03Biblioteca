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
    public partial class datosDesplegables : Form
    {
        public datosDesplegables()
        {
            InitializeComponent();
            
        }
        public Label ClaveL
        {
            get { return this.claveL; }
        }
        public ComboBox ClaveDesplegableCb
        {
            get { return this.claveDesplegableCb; }
        }

        private void aceptarAlB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
