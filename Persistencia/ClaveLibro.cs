using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ClaveLibro : Clave, IEquatable<ClaveLibro>
    {
        private string isbn;

        public ClaveLibro(string isbn)
        {
            this.isbn = isbn;
        }

        public string Isbn { get { return this.isbn;} }

        public bool Equals(Clave other)
        {
            if (other is ClaveLibro) return this.Equals(other as ClaveLibro);
            return false;
        }

        public bool Equals(ClaveLibro other)
        {
            if (other!=null)
            {
                return this.isbn.Equals(other.isbn);
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = -1790538230;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(isbn);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Isbn);
            return hashCode;
        }
    }
}
