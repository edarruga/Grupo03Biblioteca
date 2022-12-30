using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class ClavePersonal : Clave, IEquatable<ClavePersonal>
    {
        private string name;

        public ClavePersonal(string name)
        {
            this.name = name;
        }

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
                return this.name.Equals(other.name);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(name);
        }
    }
}
