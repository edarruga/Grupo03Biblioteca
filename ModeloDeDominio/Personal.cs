using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeDominio
{
    public class Personal
    {
        private string nombre;
        private string contraseña;

        public Personal(string name, string pass)
        {
            this.nombre  = name;
            this.contraseña = pass;
        }

        public string Nombre { get { return nombre; } }
        public string Contraseña { get { return contraseña ; } }
    }
}
