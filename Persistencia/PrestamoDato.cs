using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class PrestamoDato : Entity<ClavePrestamo>
    {
        public PrestamoDato(ClavePrestamo id) : base(id)
        {
        }
    }
}
