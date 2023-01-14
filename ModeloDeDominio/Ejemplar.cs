using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeDominio
{
    public class Ejemplar:IEquatable<Ejemplar>
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

        public Ejemplar(string codigo, Boolean prestado, Libro libro)
        {
            this.codigo = codigo;
            this.libro = libro;
            this.prestado = prestado;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ejemplar"></param>
        /// <returns>Verdadero si el la instancia del ejemplar y "ejemplar" tienen el mismo código, falso en caso contrario</returns>
        public bool Equals(Ejemplar ejemplar)
        {
            if (this.codigo == ejemplar.codigo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
