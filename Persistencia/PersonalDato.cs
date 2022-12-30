using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class PersonalDato : Entity<ClavePersonal>, IEquatable<PersonalDato> 
    {
        private string pass;
        private string tipo;

        public PersonalDato(string name, string pass, string tipo) : base(new ClavePersonal(name))
        {
            this.pass=pass;
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

        public string Pass { get { return this.pass; } }
        public string Tipo { get { return this.tipo; } }
    }
}
