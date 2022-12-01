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
        private Estado Estado;
        public PrestamoDato(ClavePrestamo id,Estado estado) : base(id)
        {
            Estado = estado;
        }
    }
}
