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
        /// <summary>
        /// Transforma el Libro al tipo LibroDato
        /// </summary>
        /// <param name="l"></param>
        /// <returns>Devuelve el LibroDato asociado al Libro l</returns>
        public static LibroDato LibroALibroDato(Libro l)
        {
            if (l == null) return null;
            return new LibroDato(l.Isbn, l.Autor, l.Titulo, l.Editorial);
        }

        /// <summary>
        /// Transforma el LibroDato al tipo Libro
        /// </summary>
        /// <param name="ld"></param>
        /// <returns>Devuelve el Libro asociado al LibroDato ld</returns>
        public static Libro LibroDatoALibro(LibroDato ld)
        {
            if (ld == null) return null;
            return new Libro(ld.Isbn, ld.Titulo, ld.Autor, ld.Editorial);
        }

        /// <summary>
        /// Transforma el Usuario al tipo UsuarioDato
        /// </summary>
        /// <param name="u"></param>
        /// <returns>Devuelve el UsuarioDato asociado al Usuario u</returns>
        public static UsuarioDato UsuarioAUsuarioDato(Usuario u)
        {
            if (u == null) return null;
            return new UsuarioDato(u.Dni, u.Nombre, u.Apellidos);
        }

        /// <summary>
        /// Transforma el UsuarioDato al tipo Usuario
        /// </summary>
        /// <param name="ud"></param>
        /// <returns>Devuelve el Usuario asociado al UsuarioDato ud</returns>
        public static Usuario UsuarioDatoAUsuario(UsuarioDato ud)
        {
            if (ud == null) return null;
            return new Usuario(ud.Dni, ud.Nombre, ud.Apellidos);
        }

        /// <summary>
        /// Transforma el Ejemplar al tipo EjemplarDato
        /// </summary>
        /// <param name="e"></param>
        /// <returns>Devuelve el EjemplarDato asociado al tipo Ejemplar</returns>
        public static EjemplarDato EjemplarAEjemplarDato(Ejemplar e)
        {
            if (e == null) return null;
            return new EjemplarDato(e.Codigo, e.Prestado, e.Libro.Isbn);
        }

        /// <summary>
        /// Transforma el EjemplarDato a tipo Ejemplar
        /// </summary>
        /// <param name="ed"></param>
        /// <returns>Devuelve el Ejemplar asociado el EjemplarDato ed</returns>
        public static Ejemplar EjemplarDatoAEjemplar(EjemplarDato ed)
        {
            if (ed == null) return null;
            return new Ejemplar(ed.Codigo, ed.Prestado, Transformador.LibroDatoALibro( BBDD.Read<ClaveLibro,LibroDato>(new ClaveLibro(ed.IsbnLibro))));
        }

        /// <summary>
        /// Transforma el Prestamo a tipo PrestamoDato
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Devuelve el PrestamoDato asociado al Prestamo p</returns>
        public static PrestamoDato PrestamoAPrestamoDato(Prestamo p)
        {
            if (p == null) return null;
            return new PrestamoDato(p.Usuario.Dni, p.EjemPrestados, p.Fecha, p.Estado);
        }

        /// <summary>
        /// Transforma el PrestamoDato al tipo Prestamo
        /// </summary>
        /// <param name="pd"></param>
        /// <returns>Devuelve el Prestamo asociado al tipo PrestamoDato pd</returns>
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

        /// <summary>
        /// Transforma el Prestamo a PrestamoEjemplarDato, recibiendo como parametros el prestamo y ejemplar asociado
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns>Devuelve el PrestamoEjemplarDato asociado al Prestamo y Ejemplar p y e respectivamente.</returns>
        public static PrestamoEjemplarDato PrestamoAPrestamoEjemplarDato(Prestamo p, Ejemplar e)
        {
            if (p == null || e == null) return null;
            return new PrestamoEjemplarDato(p.Fecha, p.Usuario.Dni, e.Codigo);
        }

        /// <summary>
        /// Transforma el Personal al tipo PersonalDato
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Devuelve el PresonalDato asociado al Personal p</returns>
        public static PersonalDato PersonalAPersonalDato(Personal p)
        {
            if (p == null) return null;
            return new PersonalDato(p.Nombre, p.Contraseña, p.GetType().Name);
        }

        /// <summary>
        /// Transforma el PersonalDato a tipo Personal
        /// </summary>
        /// <param name="pd"></param>
        /// <returns>Devuelve el Personal asociado al PersonalDato pd</returns>
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
