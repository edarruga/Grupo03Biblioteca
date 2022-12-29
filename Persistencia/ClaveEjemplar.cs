using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ClaveEjemplar : Clave, IEquatable<ClaveEjemplar>
    {
        private string codigo;

        public ClaveEjemplar(string codigo)
        {
            this.codigo = codigo;
        }

        public string Codigo { get { return codigo; } }

        public bool Equals(Clave other)
        {
            if (other !=null)
            {
                if (other is ClaveEjemplar) return this.codigo.Equals(other as ClaveEjemplar);
            }
            return false;
        }

        public bool Equals(ClaveEjemplar other)
        {
            return this.Equals(other as Clave);
        }

        public override int GetHashCode()
        {
            int hashCode = -484661012;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(codigo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Codigo);
            return hashCode;
        }
    }
}
