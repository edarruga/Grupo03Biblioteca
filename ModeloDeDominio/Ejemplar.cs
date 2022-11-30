using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeDominio
{
    public class Ejemplar
    {
        private string codigo;
        private bool prestado;
        private Libro libro;

        public Ejemplar(string codigo, Libro libro)
        {
            this.codigo = codigo;
            this.libro = libro;
            prestado = false;
        }

        public string Codigo
        {
            get { return codigo; }
        }

        public bool Prestado
        {
            get { return prestado; }
            set { prestado = value; }
        }

        public Libro Libro { get { return libro; }}
    }
}
