using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ClavePrestamoEjemplar : Clave, IEquatable<ClavePrestamoEjemplar>
    {
        private ClavePrestamo prestamo;
        private ClaveEjemplar ejemplar;

        public ClavePrestamo Prestamo
        {
            get { return prestamo; }
        }

        public ClaveEjemplar Ejemplar
        {
            get { return ejemplar; }
        }

        public ClavePrestamoEjemplar(ClavePrestamo prestamo, ClaveEjemplar ejemplar)
        {
            this.prestamo = prestamo;
            this.ejemplar = ejemplar;
        }

        public bool Equals(Clave other)
        {
            if (other is ClavePrestamoEjemplar)
            {
                return Equals((ClavePrestamoEjemplar)other);
            }
            return false;
        }

        public bool Equals(ClavePrestamoEjemplar other)
        {
            if (other!=null)
            {
                return this.ejemplar.Equals(other.ejemplar) && this.prestamo.Equals(other.prestamo);
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = -2131777850;
            hashCode = hashCode * -1521134295 + EqualityComparer<ClavePrestamo>.Default.GetHashCode(prestamo);
            hashCode = hashCode * -1521134295 + EqualityComparer<ClaveEjemplar>.Default.GetHashCode(ejemplar);
            hashCode = hashCode * -1521134295 + EqualityComparer<ClavePrestamo>.Default.GetHashCode(Prestamo);
            hashCode = hashCode * -1521134295 + EqualityComparer<ClaveEjemplar>.Default.GetHashCode(Ejemplar);
            return hashCode;
        }
    }
}
