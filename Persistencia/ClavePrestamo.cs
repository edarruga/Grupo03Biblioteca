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
        private string dniUsuario;
        public ClavePrestamo(DateTime fecha, string dni)
        {
            this.fecha = fecha;
            this.dniUsuario = dni;
        }

        public DateTime Fecha { get { return fecha; } }

        public string DniUsuario { get { return dniUsuario; } }

        public bool Equals(Clave other)
        {
            if (other != null && other is ClavePrestamo)
            {
                return (other as ClavePrestamo).fecha.Equals(this.fecha) && (other as ClavePrestamo).dniUsuario.Equals(this.dniUsuario);
            }
            return false;
        }

        public bool Equals(ClavePrestamo other)
        {
            return this.dniUsuario.Equals(other.dniUsuario) && this.fecha.Equals(other.fecha);
        }

        public override int GetHashCode()
        {
            int hashCode = 1466386584;
            hashCode = hashCode * -1521134295 + fecha.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(dniUsuario);
            hashCode = hashCode * -1521134295 + Fecha.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DniUsuario);
            return hashCode;
        }
    }
}
