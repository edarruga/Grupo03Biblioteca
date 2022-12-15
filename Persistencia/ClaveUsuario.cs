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
                if (other is ClaveUsuario) return this.Dni.Equals((other as ClaveUsuario).Dni);
            }
            return false;
        }

        public bool Equals(ClaveUsuario other)
        {
            return this.Equals(other as Clave);
        }
    }
}
