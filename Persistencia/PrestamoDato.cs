using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class PrestamoDato : Entity<ClavePrestamo>
    {
        private Estado estado;
        private DateTime fecha;
        private string dni;
        private List<ClaveEjemplar> ejemPrestados;
        public PrestamoDato(string dni, List<Ejemplar> ejemPrestados, DateTime fecha ,Estado estado) : base(new ClavePrestamo(fecha, dni))
        {
            this.dni = dni;
            this.fecha = fecha;
            this.estado = estado;
            this.ejemPrestados = new List<ClaveEjemplar>();
            foreach(Ejemplar ejemplar in ejemPrestados)
            {
                this.ejemPrestados.Add(new ClaveEjemplar(ejemplar.Codigo));
            }
        }
        public Estado Estado
        {
            get { return this.estado; }
        }
        public string Dni
        {
            get { return this.dni;}
        }

        public DateTime Fecha { get { return this.fecha; } }

        public List<ClaveEjemplar> EjemPrestados { get { return this.ejemPrestados; } }
    }
}
