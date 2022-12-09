using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class BBDD
    {
        private static Table<ClaveLibro,  LibroDato> tablaLibro = new Table<ClaveLibro, LibroDato>();
        private static Table<ClaveUsuario, UsuarioDato> tablaUsuario = new Table<ClaveUsuario, UsuarioDato>();
        private static Table<ClaveEjemplar, EjemplarDato> tablaEjemplar = new Table<ClaveEjemplar, EjemplarDato>();
        private static Table<ClavePrestamo, PrestamoDato> tablaPrestamo = new Table<ClavePrestamo, PrestamoDato>();


        public static Table<ClaveLibro, LibroDato> TablaLibro
        {
            get { return tablaLibro; }
        }

        public static Table<ClaveUsuario, UsuarioDato> TablaUsuario
        {
            get { return tablaUsuario; }
        }

        public static Table<ClaveEjemplar, EjemplarDato> TablaEjemplar
        {
            get { return tablaEjemplar; }
        }

        public static Table<ClavePrestamo, PrestamoDato> TablaPrestamo
        {
            get { return tablaPrestamo; }
        }

        private BBDD(){}


        public static bool Create(Object o)
        {
            if (o != null)
            {
                if (o is Libro)
                {
                    if (!tablaLibro.Contains(new ClaveLibro((o as Libro).Isbn)))
                    {
                        tablaLibro.Add(Transformador.LibroALibroDato(o as Libro));
                        return true;
                    }
                }
                if (o is Usuario)
                {
                    if (!tablaUsuario.Contains(new ClaveUsuario((o as Usuario).Dni)))
                    {
                        tablaUsuario.Add(Transformador.UsuarioAUsuarioDato(o as Usuario));
                        return true;
                    }
                }
                if (o is Prestamo)
                {
                    if (!tablaPrestamo.Contains(new ClavePrestamo((o as Prestamo).Fecha, (o as Prestamo).Usuario.Dni)))
                    {
                        tablaPrestamo.Add(Transformador.PrestamoAPrestamoDato(o as Prestamo));
                        return true;
                    }
                }
                if (o is Ejemplar)
                {
                    if (!tablaEjemplar.Contains(new ClaveEjemplar((o as Ejemplar).Codigo)))
                    {
                        tablaEjemplar.Add(Transformador.EjemplarAEjemplarDato(o as Ejemplar));
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>El libro con ISBN "isbn", o en caso de no existir en la tabla devuelve nulo</returns>
        //public static Libro ReadLibro(string isbn)
        //{
        //    if(tablaLibro.Contains(isbn) && isbn!=null) return Transformador.LibroDatoALibro(tablaLibro[isbn]);
        //    return null;
        //}

        public static object Read(Clave c)
        {
            if (c!=null)
            {
                if (c is ClaveLibro && tablaLibro.Contains(c as ClaveLibro))
                {
                    return tablaLibro[c as ClaveLibro];
                }
                if (c is ClaveUsuario && tablaUsuario.Contains(c as ClaveUsuario))
                {
                    return tablaUsuario[c as ClaveUsuario];
                }
                if (c is ClaveEjemplar && tablaEjemplar.Contains(c as ClaveEjemplar))
                {
                    return tablaEjemplar[c as ClaveEjemplar];
                }
                if (c is ClavePrestamo && tablaPrestamo.Contains(c as ClavePrestamo))
                {
                    return tablaPrestamo[c as ClavePrestamo];
                }
            }
            return null;
        }

        //public static void UpdateLibro(Libro l)
        //{
        //    if (l != null && tablaLibro.Remove(l.Isbn)) tablaLibro.Add(Transformador.LibroALibroDato(l));
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="o">Tiene que ser parte del sistema de persistencia</param>
        /// <returns>verdadero si ha modificado el objeto introducido o falso si no lo introduce</returns>
        public static bool Update(object o)
        {
            if (o!=null)
            {
                if (o is Libro && tablaLibro.Remove(new ClaveLibro((o as Libro).Isbn)))
                {
                    tablaLibro.Add(Transformador.LibroALibroDato(o as Libro));
                    return true;
                }
                if (o is Usuario && tablaUsuario.Remove(new ClaveUsuario((o as Usuario).Dni)))
                {
                    tablaUsuario.Add(Transformador.UsuarioAUsuarioDato(o as Usuario));
                    return true;
                }
                if (o is Ejemplar && tablaEjemplar.Remove(new ClaveEjemplar((o as Ejemplar).Codigo)))
                {
                    tablaEjemplar.Add(Transformador.EjemplarAEjemplarDato(o as Ejemplar));
                    return true;
                }
                if (o is Prestamo && tablaPrestamo.Remove(new ClavePrestamo((o as Prestamo).Fecha, (o as Prestamo).Usuario.Dni)))
                {
                    tablaPrestamo.Add(Transformador.PrestamoAPrestamoDato(o as Prestamo));
                    return true;
                }
            }
            return false;
        }

        //public static bool RemoveLibro(string isbn)
        //{
        //    return tablaLibro.Remove(isbn);
        //}

        public static bool Remove(Clave c)
        {
            if (c != null)
            {
                if (c is ClaveLibro)
                {
                    return tablaLibro.Remove(c as ClaveLibro);
                }
                if (c is ClaveUsuario)
                {
                    return tablaUsuario.Remove(c as ClaveUsuario);
                }
                if (c is ClaveEjemplar)
                {
                    return tablaEjemplar.Remove(c as ClaveEjemplar);
                }
                if (c is ClavePrestamo)
                {
                    return tablaPrestamo.Remove(c as ClavePrestamo);
                }
            }
            return false;
        }

        //public static bool Add(Usuario u)
        //{
        //    if (!tablaUsuario.Contains(u.Isbn) && u != null)
        //    {
        //        tablaLibro.Add(new LibroDato());
        //    }
        //    return false;
        //}
    }
}
