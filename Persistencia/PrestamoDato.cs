using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PrestamoDato : Entity<ClavePrestamo>, IEquatable<PrestamoDato>
    {
        private Estado estado;
        private DateTime fecha;
        private string dniUsuario;
        public PrestamoDato(string dni, List<Ejemplar> ejemPrestados, DateTime fecha ,Estado estado) : base(new ClavePrestamo(fecha, dni))
        {
            this.dniUsuario = dni;
            this.fecha = fecha;
            this.estado = estado;
            //this.ejemPrestados = new List<ClaveEjemplar>();
            foreach(Ejemplar ejemplar in ejemPrestados)
            {
                //BBDD.Create();
                //this.ejemPrestados.Add(new ClaveEjemplar(ejemplar.Codigo));
                BBDD.Create<ClavePrestamoEjemplar, PrestamoEjemplarDato>(new PrestamoEjemplarDato(fecha, dni, ejemplar.Codigo));
            }
        }
        public Estado Estado
        {
            get { return this.estado; }
        }
        public string DniUsuario
        {
            get { return this.dniUsuario;}
        }

        public DateTime Fecha { get { return this.fecha; } }

        public bool Equals(PrestamoDato other)
        {
            return this.Id.Equals(other.Id);
        }
    }
}
