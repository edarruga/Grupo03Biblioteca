using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class EjemplarDato : Entity<string>
    {
        private bool prestado;
        private LibroDato ld;
        public EjemplarDato(string id, bool prestado, LibroDato ld) : base(id)
        {
            this.prestado = prestado;
            this.ld = ld;
        }
    }
}
