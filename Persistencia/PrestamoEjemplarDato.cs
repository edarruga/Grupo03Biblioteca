using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PrestamoEjemplarDato : Entity<ClavePrestamoEjemplar>, IEquatable<PrestamoEjemplarDato>
    {
        public PrestamoEjemplarDato(DateTime fecha, string dniUsuario, string codigo) : base(new ClavePrestamoEjemplar(new ClavePrestamo(fecha, dniUsuario), new ClaveEjemplar(codigo)))
        {
        }

        public DateTime Fecha
        {
            get { return this.Id.Prestamo.Fecha; }
        }

        public string DniUsuario
        {
            get { return this.Id.Prestamo.DniUsuario; }
        }

        public string Codigo
        {
            get { return this.Id.Ejemplar.Codigo; }
        }

        public bool Equals(PrestamoEjemplarDato other)
        {
            return this.Id.Equals(other.Id);
        }
    }
}
