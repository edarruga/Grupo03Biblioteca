using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class EjemplarDato : Entity<ClaveEjemplar>, IEquatable<EjemplarDato>
    {
        private bool prestado;
        private String isbnLibro;
        public EjemplarDato(string id, bool prestado, String isbnLibro) : base(new ClaveEjemplar(id))
        {
            this.prestado = prestado;
            this.isbnLibro = isbnLibro;
        }
        public string Codigo
        {
            get { return this.Id.Codigo; }
        }
        public bool Prestado
        {
            get { return prestado; }
        }
        public String IsbnLibro
        {
            get { return isbnLibro; }
        }

        public bool Equals(EjemplarDato other)
        {
            return this.Id.Equals(other.Id);
        }
    }
}
