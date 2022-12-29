using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PrestamoEjemplarDato : Entity<ClavePrestamoEjemplar>, IEquatable<PrestamoEjemplarDato>
    {
        private DateTime fecha;
        private string dniUsuario;
        private string codigo;

        public PrestamoEjemplarDato(DateTime fecha, string dniUsuario, string codigo) : base(new ClavePrestamoEjemplar(new ClavePrestamo(fecha, dniUsuario), new ClaveEjemplar(codigo)))
        {
            this.fecha = fecha;
            this.dniUsuario = dniUsuario;
            this.codigo = codigo;
        }

        public DateTime Fecha
        {
            get { return fecha; }
        }

        public string DniUsuario
        {
            get { return dniUsuario; }
        }

        public string Codigo
        {
            get { return codigo; }
        }

        public bool Equals(PrestamoEjemplarDato other)
        {
            return this.Id.Equals(other.Id);
        }
    }
}
