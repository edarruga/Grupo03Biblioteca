using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeDominio
{
    public class Usuario
    {
        private string dni;
        private string nombre;
        private string apellidos;

        public Usuario(string dni, string nombre, string apellidos)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
        }

        public string Dni
        {
            get { return dni; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
    }
}
