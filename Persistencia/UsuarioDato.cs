using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class UsuarioDato : Entity<string>
    {
        private string dni;
        private string nombre;
        private string apellidos;
        public UsuarioDato(string id,string nombre,string apellidos) : base(id)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = id;
        }
        public string Dni
        {
            get { return dni; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public string Apellidos
        {
            get { return apellidos; }
        }
    }
}
