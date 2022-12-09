using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class ClaveEjemplar : Clave
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
    }
}
