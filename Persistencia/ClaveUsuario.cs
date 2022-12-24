using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ClaveUsuario : Clave, IEquatable<ClaveUsuario>
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
                if (other is ClaveUsuario) return this.dni.Equals((other as ClaveUsuario).dni);
            }
            return false;
        }

        public bool Equals(ClaveUsuario other)
        {
            if (other != null)
            {
                return this.dni.Equals((other as ClaveUsuario).dni);
            }
            return false;
        }
    }
}
