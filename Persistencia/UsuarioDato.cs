﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class UsuarioDato : Entity<ClaveUsuario>, IEquatable<UsuarioDato>
    {
        private string nombre;
        private string apellidos;
        public UsuarioDato(string id,string nombre,string apellidos) : base(new ClaveUsuario(id))
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        public string Dni
        {
            get { return this.Id.Dni; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public string Apellidos
        {
            get { return apellidos; }
        }

        public bool Equals(UsuarioDato other)
        {
            return base.Equals(other);
        }
    }
}
