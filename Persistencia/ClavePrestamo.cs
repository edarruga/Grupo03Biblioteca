using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class ClavePrestamo : Clave
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
    }
}
