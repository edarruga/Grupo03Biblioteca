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
        
        public PrestamoDato(string dni, List<Ejemplar> ejemPrestados, DateTime fecha ,Estado estado) : base(new ClavePrestamo(fecha, dni))
        {
            this.estado = estado;
            foreach (Ejemplar ejemplar in ejemPrestados)
            {
                PrestamoEjemplarDato ped = new PrestamoEjemplarDato(fecha, dni, ejemplar.Codigo);
                if (!BBDD.TablaPrestamoEjemplar.Contains(ped.Id)) BBDD.TablaPrestamoEjemplar.Add(ped);
            }
        }
        public Estado Estado
        {
            get { return this.estado; }
        }
        public string DniUsuario
        {
            get { return this.Id.DniUsuario;}
        }

        public DateTime Fecha { get { return this.Id.Fecha; } }

        public bool Equals(PrestamoDato other)
        {
            return this.Id.Equals(other.Id);
        }
    }
}
