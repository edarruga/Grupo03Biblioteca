﻿using System;
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
        private List<Ejemplar> ejemPrestados;

        public Prestamo(Usuario us, List<Ejemplar> ejemPrestados)
        {
            this.fecha = DateTime.Now;
            this.usuario = us;
            this.estado = Estado.EnProceso;
            this.ejemPrestados = ejemPrestados;
        }

        public Prestamo(Usuario us, List<Ejemplar> ejemPrestados, Estado estado, DateTime fecha)
        {
            this.usuario = us;
            this.ejemPrestados = ejemPrestados;
            this.estado = estado;
            this.fecha = fecha;
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

        public List<Ejemplar> EjemPrestados
        {
            get { return ejemPrestados; }
        }
        public bool Contains(Ejemplar ejemplar)
        {
            foreach(Ejemplar ejemplar2 in ejemPrestados)
            {
                if (ejemplar2.Equals(ejemplar))
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
