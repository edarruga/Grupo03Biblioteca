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
        private ClavePrestamo clavePrestamo;
        public PrestamoDato(ClavePrestamo id,Estado estado) : base(id)
        {
            this.clavePrestamo = id;
            this.estado = estado;
        }
        public Estado Estado
        {
            get { return this.estado; }
        }
        public ClavePrestamo ClavePrestamo
        {
            get { return this.clavePrestamo;}
        }
    }
}
