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
    public partial class datoUC : UserControl
    {
        public datoUC(int x, int y, string l)
        {
            InitializeComponent();
            this.Left = x;
            this.Top = y;
            this.datoLUC.Text = l;
        }
        public string Dato
        {
            get { return this.datoTbUC.Text; }
        }
        public TextBox DatoTbUC { get { return this.datoTbUC; } }

    }
}
