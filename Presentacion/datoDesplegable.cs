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
    public partial class datoDesplegable : UserControl
    {
        public datoDesplegable(int x,int y)
        {
            InitializeComponent();
            this.Left = x;
            this.Top = y;
        }
        public Label DatoDesplegableL
        {
            get { return this.datoDesplegableL; }
        }
        public ComboBox DatoDesplegableCb
        {
            get { return this.datoDesplegableCb; }
        }
    }
}
