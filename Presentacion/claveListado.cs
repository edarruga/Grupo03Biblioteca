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
    public partial class claveListado : UserControl
    {
        public claveListado(int x,int y,string nombre,List<Usuario> lista)
        {
            InitializeComponent();
            this.Left = x;
            this.Top = y;
            this.clavebL.Text=nombre;
            foreach(Usuario u in lista)
            {
                this.clavelbL.Items.Add(u.Dni);
            }
            
        }
    }
}
