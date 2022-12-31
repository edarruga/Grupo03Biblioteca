using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ClavePersonal : Clave, IEquatable<ClavePersonal>
    {
        private string nombre;

        public ClavePersonal(string name)
        {
            this.nombre = name;
        }

        public string Nombre { get { return nombre; } }
        public bool Equals(Clave other)
        {
            if (other != null)
            {
                if (other is ClavePersonal) return this.Equals(other as ClavePersonal);
            }
            return false;
        }

        public bool Equals(ClavePersonal other)
        {
            if (other!=null)
            {
                return this.nombre.Equals(other.nombre);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(nombre);
        }
    }
}
