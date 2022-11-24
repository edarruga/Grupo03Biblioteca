using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeDominio
{
    public class Usuario
    {
        private String dni;
        private String nombre;
        private String apellidos;

        public Usuario(String dni, String nombre, String apellidos)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
        }

        public String Dni
        {
            get { return dni; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
    }
}
