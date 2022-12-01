using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class LibroDato : Entity<String>
    {
        private string autor;
        private string editorial;
        public LibroDato(String isbn,String autor,String editorial) : base(isbn)
        {
            this.autor = autor;
            this.editorial = editorial;
        }
    }
}
