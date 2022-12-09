using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class ClaveUsuario : Clave
    {
        private string dni;

        public ClaveUsuario(string dni)
        {
            this.dni = dni;
        }

        public string Dni { get { return dni; } }

        public bool Equals(Clave other)
        {
            if (other != null)
            {
                if (other is ClaveUsuario) return this.Dni.Equals((other as ClaveUsuario).Dni); 
            }
            return false;
        }
    }
}
