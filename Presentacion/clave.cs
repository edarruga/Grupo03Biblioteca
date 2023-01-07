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
    public partial class claveUC : UserControl
    {
        public claveUC(int x, int y, string l, string clave)
        {
            InitializeComponent();
            this.Left = x;
            this.Top = y;
            this.claveLUC.Text = l;
            this.claveTbUC.Text = clave;
        }
        public claveUC(int x, int y, string l)
        {
            InitializeComponent();
            this.Left = x;
            this.Top = y;
            this.claveLUC.Text = l;
        }
        public TextBox ClaveTbUC { get { return this.claveTbUC; } }
    }
}
