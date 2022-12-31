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
            if (l == null) return null;
            return new LibroDato(l.Isbn, l.Autor, l.Titulo, l.Editorial);
        }

        public static Libro LibroDatoALibro(LibroDato ld)
        {
            if (ld == null) return null;
            return new Libro(ld.Isbn, ld.Titulo, ld.Autor, ld.Editorial);
        }

        public static UsuarioDato UsuarioAUsuarioDato(Usuario u)
        {
            if (u == null) return null;
            return new UsuarioDato(u.Dni, u.Nombre, u.Apellidos);
        }

        public static Usuario UsuarioDatoAUsuario(UsuarioDato ud)
        {
            if (ud == null) return null;
            return new Usuario(ud.Dni, ud.Nombre, ud.Apellidos);
        }

        public static EjemplarDato EjemplarAEjemplarDato(Ejemplar e)
        {
            if (e == null) return null;
            return new EjemplarDato(e.Codigo, e.Prestado, e.Libro.Isbn);
        }

        public static Ejemplar EjemplarDatoAEjemplar(EjemplarDato ed)
        {
            if (ed == null) return null;
            return new Ejemplar(ed.Codigo, ed.Prestado, Transformador.LibroDatoALibro( BBDD.Read<ClaveLibro,LibroDato>(new ClaveLibro(ed.IsbnLibro))));
        }

        public static PrestamoDato PrestamoAPrestamoDato(Prestamo p)
        {
            if (p == null) return null;
            return new PrestamoDato(p.Usuario.Dni, p.EjemPrestados, p.Fecha, p.Estado);
        }

        public static Prestamo PrestamoDatoAPrestamo(PrestamoDato pd) 
        {
            if (pd == null) return null;
            List<Ejemplar> ejemplares = new List<Ejemplar>();
            //foreach (EjemplarDato ed in BBDD.TablaEjemplar)
            //{
            //    if (ed.Id.Equals(pd.Id))
            //    {
            //        ejemplares.Add(Transformador.EjemplarDatoAEjemplar(BBDD.Read<ClaveEjemplar,EjemplarDato>(ed.Id)));
            //    }
            //}
            foreach (PrestamoEjemplarDato ped in BBDD.TablaPrestamoEjemplar)
            {
                if (ped.Id.Prestamo.Equals(pd.Id))
                {
                    ejemplares.Add(Transformador.EjemplarDatoAEjemplar(BBDD.Read<ClaveEjemplar, EjemplarDato>(ped.Id.Ejemplar)));
                }
            }
            return new Prestamo(Transformador.UsuarioDatoAUsuario(BBDD.Read<ClaveUsuario,UsuarioDato>(new ClaveUsuario(pd.DniUsuario))), ejemplares, pd.Estado, pd.Fecha);
        }

        public static PrestamoEjemplarDato PrestamoAPrestamoEjemplarDato(Prestamo p, Ejemplar e)
        {
            if (p == null || e == null) return null;
            return new PrestamoEjemplarDato(p.Fecha, p.Usuario.Dni, e.Codigo);
        }

        public static PersonalDato PersonalAPersonalDato(Personal p)
        {
            if (p == null) return null;
            return new PersonalDato(p.Nombre, p.Contraseña, p.GetType().Name);
        }

        public static Personal PersonalDatoAPersonal(PersonalDato pd)
        {
            if (pd == null) return null;
            if (pd.Tipo.Equals("PersonalSala"))
            {
                return new PersonalSala(pd.Nombre, pd.Contraseña);
            }
            else if (pd.Tipo.Equals("PersonalServicioAdquisiciones"))
            {
                return new PersonalServicioAdquisiciones(pd.Nombre, pd.Contraseña);
            }
            else
            {
                return new Personal(pd.Nombre, pd.Contraseña);
            }
        }
    }
}
