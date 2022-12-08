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
            return new LibroDato(l.Isbn, l.Autor, l.Titulo, l.Editorial);
        }

        public static Libro LibroDatoALibro(LibroDato ld)
        {
            return new Libro(ld.Isbn, ld.Titulo, ld.Autor, ld.Editorial);
        }

        public static UsuarioDato UsuarioAUsuarioDato(Usuario u)
        {
            return new UsuarioDato(u.Dni, u.Nombre, u.Apellidos);
        }

        public static Usuario UsuarioDatoAUsuario(UsuarioDato ud)
        {
            return new Usuario(ud.Dni, ud.Nombre, ud.Apellidos);
        }

        public static EjemplarDato EjemplarAEjemplarDato(Ejemplar e)
        {
            return new EjemplarDato(e.Codigo, e.Prestado, e.Libro.Isbn);
        }

        public static Ejemplar EjemplarDatoAEjemplar(EjemplarDato ed)
        {
            return new Ejemplar(ed.Id, ed.Prestado, BBDD.ReadLibro(ed.Id) as Libro);
        }
    }
}
