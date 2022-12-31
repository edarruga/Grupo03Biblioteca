using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersonalDato : Entity<ClavePersonal>, IEquatable<PersonalDato> 
    {
        private string contraseña;
        private string tipo;

        public PersonalDato(string name, string pass, string tipo) : base(new ClavePersonal(name))
        {
            this.contraseña=pass;
            this.tipo=tipo;
        }

        public bool Equals(PersonalDato other)
        {
            if (other!=null)
            {
                return this.Id.Equals(other.Id);
            }
            return false;
        }

        public string Nombre { get { return this.Id.Nombre; } }

        public string Contraseña { get { return this.contraseña; } }
        public string Tipo { get { return this.tipo; } }
    }
}
