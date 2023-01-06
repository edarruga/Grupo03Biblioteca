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
    public partial class claveDesplegable : UserControl
    {
        private List<string> claves;
        public claveDesplegable(int x, int y, string l,List<string> c)
        {
            InitializeComponent();
            this.Left = x;
            this.Top = y;
            this.claveDesplegableL.Text = l;
            List<string> ordenada = c.OrderBy(clave => clave).ToList();
            this.claves = ordenada;
        }
    }
}
