using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeDominio
{
    public class Prestamo
    {
        private DateTime fecha;
        private Usuario usuario;
        private Estado estado;

        public Prestamo(Usuario us)
        {
            this.fecha = DateTime.Now;
            this.usuario = us;
            this.estado = Estado.EnProceso;
        }

        public DateTime Fecha
        {
            get { return fecha; }
        }

        public Usuario Usuario { get { return usuario; } }

        public Estado Estado 
        { 
            get { return estado; }
            set { this.estado = value; } 
        }
    }
}
