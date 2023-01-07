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
    public partial class rocorridoUnoaUno : Form
    {
        public rocorridoUnoaUno()
        {
            InitializeComponent();
        }
        public BindingNavigator BindingNavigator
        {
            get { return this.bindingNavigator; }
        }
        public ToolStripTextBox BindingNavigatorPositionItem
        {
            get { return this.bindingNavigatorPositionItem; }
        }
    }
}
