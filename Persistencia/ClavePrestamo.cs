using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ClavePrestamo : Clave, IEquatable<ClavePrestamo>
    {
        private DateTime fecha;
        private string dni;
        public ClavePrestamo(DateTime fecha, string dni)
        {
            this.fecha = fecha;
            this.dni = dni;
        }

        public DateTime Fecha { get { return fecha; } }

        public string Dni { get { return dni; } }

        public bool Equals(Clave other)
        {
            if (other != null && other is ClavePrestamo)
            {
                return (other as ClavePrestamo).fecha.Equals(this.fecha) && (other as ClavePrestamo).dni.Equals(this.dni);
            }
            return false;
        }

        public bool Equals(ClavePrestamo other)
        {
            return this.Equals(other as Clave);
        }

        public override int GetHashCode()
        {
            int hashCode = 1466386584;
            hashCode = hashCode * -1521134295 + fecha.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(dni);
            hashCode = hashCode * -1521134295 + Fecha.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
            return hashCode;
        }
    }
}
