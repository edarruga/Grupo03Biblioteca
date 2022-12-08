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
        private static Table<string, UsuarioDato> tablaUsuario = new Table<string, UsuarioDato>();

        public static Table<ClaveLibro, LibroDato> TablaLibro
        {
            get { return tablaLibro; }
        }

        private BBDD(){}


        public static bool Create(Object o)
        {
            if (0 != null)
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
                    if (!tablaUsuario.Contains((o as Usuario).Dni))
                    {
                        tablaUsuario.Add(Transformador.UsuarioAUsuarioDato(o as Usuario));
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
