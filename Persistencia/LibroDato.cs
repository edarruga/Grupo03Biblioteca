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
        private string isbn;
        private string autor;
        private string editorial;
        private string titulo;
        public LibroDato(string isbn, string autor, string titulo, string editorial) : base(isbn)
        {
            this.isbn = isbn;
            this.autor = autor;
            this.editorial = editorial;
            this.titulo = titulo;
        }

        public string Isbn
        {
            get { return isbn; }
        }

        public string Autor
        {
            get { return autor; }
        }

        public string Editorial
        {
            get { return editorial; }
        }

        public string Titulo
        {
            get { return titulo; }
        }
    }
}
