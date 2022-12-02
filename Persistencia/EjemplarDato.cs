using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class EjemplarDato : Entity<string>
    {
        private string id;
        private bool prestado;
        private String isbnLibro;
        public EjemplarDato(string id, bool prestado, String isbnLibro) : base(id)
        {
            this.id = id;
            this.prestado = prestado;
            this.isbnLibro = isbnLibro;
        }
        public string Id
        {
            get { return id; }
        }
        public bool Prestado
        {
            get { return prestado; }
        }
        public String IsbnLibro
        {
            get { return isbnLibro; }
        }
    }
}
