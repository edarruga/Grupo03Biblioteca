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
                if (other is ClaveUsuario) return this.Equals(other as ClaveUsuario);
            }
            return false;
        }

        public bool Equals(ClaveUsuario other)
        {
            return this.dni.Equals(other.dni);
        }

        public override int GetHashCode()
        {
            int hashCode = -1874643772;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(dni);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
            return hashCode;
        }
    }
}
