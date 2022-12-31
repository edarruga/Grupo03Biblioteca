using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeDominio
{
    public class Personal
    {
        private string name;
        private string pass;

        public Personal(string name, string pass)
        {
            this.name = name;
            this.pass = pass;
        }

        public string Name { get { return name; } }
        public string Pass { get { return pass; } }
    }
}
