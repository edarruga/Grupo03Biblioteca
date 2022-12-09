﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class EjemplarDato : Entity<ClaveEjemplar>
    {
        private string codigo;
        private bool prestado;
        private String isbnLibro;
        public EjemplarDato(string id, bool prestado, String isbnLibro) : base(new ClaveEjemplar(id))
        {
            this.codigo = id;
            this.prestado = prestado;
            this.isbnLibro = isbnLibro;
        }
        public string Codigo
        {
            get { return codigo; }
        }
        public bool Prestado
        {
            get { return prestado; }
        }
        public String IsbnLibro
        {
            get { return isbnLibro; }
        }
    }
}
