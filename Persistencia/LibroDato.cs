using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class LibroDato : Entity<ClaveLibro>, IEquatable<LibroDato>
    {
        private string autor;
        private string editorial;
        private string titulo;
        public LibroDato(string isbn, string autor, string titulo, string editorial) : base(new ClaveLibro(isbn))
        {
            this.autor = autor;
            this.editorial = editorial;
            this.titulo = titulo;
        }

        public string Isbn
        {
            get { return this.Id.Isbn; }
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

        public bool Equals(LibroDato other)
        {
            return this.Id.Equals(other.Id);
        }
    }
}
