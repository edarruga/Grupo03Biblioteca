using ModeloDeDominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public static class Transformador
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
            return new Ejemplar(ed.Codigo, ed.Prestado, BBDD.Read(ed.Id) as Libro);
        }

        public static PrestamoDato PrestamoAPrestamoDato(Prestamo p)
        {

            return new PrestamoDato(p.Usuario.Dni, p.EjemPrestados, p.Fecha, p.Estado);
        }

        public static Prestamo PrestamoDatoAPrestamo(PrestamoDato pd) 
        {
            List<Ejemplar> ejemplares = new List<Ejemplar>();
            foreach (PrestamoEjemplarDato ped in BBDD.TablaPrestamoEjemplar)
            {
                if (ped.Id.Prestamo.Equals(pd.Id))
                {
                    ejemplares.Add(BBDD.Read(ped.Id.Ejemplar) as Ejemplar);
                }
            }
            return new Prestamo(BBDD.Read(new ClaveUsuario(pd.DniUsuario)) as Usuario, ejemplares, pd.Estado, pd.Fecha);
        }

        public static PrestamoEjemplarDato PrestamoAPrestamoEjemplarDato(Prestamo p, Ejemplar e)
        {
            return new PrestamoEjemplarDato(p.Fecha, p.Usuario.Dni, e.Codigo);
        }
    }
}
