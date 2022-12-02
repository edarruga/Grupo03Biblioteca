using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal static class Transformador
    {
        public static LibroDato LibroALibroDato(Libro l)
        {
            return new LibroDato(l.Isbn, l.Autor, l.Editorial, l.Titulo);
        }

        public static Libro LibroDatoToLibro(LibroDato ld)
        {
            return new Libro(ld.Isbn, ld.Titulo, ld.Autor, ld.Editorial);
        }


    }
}
