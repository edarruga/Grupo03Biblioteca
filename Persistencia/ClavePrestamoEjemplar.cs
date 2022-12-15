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
            if (other != null && other is ClavePrestamoEjemplar)
            {
                return this.Prestamo.Equals((other as ClavePrestamoEjemplar).Prestamo) && this.Ejemplar.Equals((other as ClavePrestamoEjemplar).Ejemplar);
            }
            return false;
        }

        public bool Equals(ClavePrestamoEjemplar other)
        {
            return this.Equals(other as Clave);
        }
    }
}
