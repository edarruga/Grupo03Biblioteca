using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class ClaveLibro : Clave
    {
        private string isbn;

        public ClaveLibro(string isbn)
        {
            this.isbn = isbn;
        }

        public string Isbn { get; }

        public bool Equals(Clave other)
        {
            if (other!=null && other is ClaveLibro)
            {
                return this.isbn.Equals((other as ClaveLibro).isbn);
            }
            return false;
        }
    }
}
