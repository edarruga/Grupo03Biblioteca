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
        private String isbnLibro;
        public EjemplarDato(string id, bool prestado, String isbnLibro) : base(id)
        {
            this.prestado = prestado;
            this.isbnLibro = isbnLibro;
        }
    }
}
