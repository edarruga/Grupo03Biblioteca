using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class ClavePrestamo
    {
        private DateTime fecha;
        private string dni;
        public ClavePrestamo(DateTime fecha, string dni)
        {
            this.fecha = fecha;
            this.dni = dni;
        }
    }
}
