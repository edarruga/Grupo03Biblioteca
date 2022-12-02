using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class BBDD
    {
        private static Table<string, LibroDato> tablaLibro = new Table<string, LibroDato>();
        //private static Table<string, UsuarioDato> tablaUsuario = new Table<string, tablaUsuario>();

        public static Table<string, LibroDato> TablaLibro
        {
            get { return tablaLibro; }
        }

        private BBDD(){}

        public static bool CreateLibro(Libro l) 
        {
            if (l!=null && !tablaLibro.Contains(l.Isbn))
            {
                tablaLibro.Add(Transformador.LibroALibroDato(l));
                return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>El libro con isbn "isbn", o en caso de no existir en la tabla devuelve nulo</returns>
        public static Libro ReadLibro(string isbn)
        {
            if(tablaLibro.Contains(isbn) && isbn!=null) return Transformador.LibroDatoALibro(tablaLibro[isbn]);
            return null;
        }

        public static void UpdateLibro(Libro l)
        {
            if (l != null && tablaLibro.Remove(l.Isbn)) tablaLibro.Add(Transformador.LibroALibroDato(l));
        }

        public static bool RemoveLibro(string isbn)
        {
            return tablaLibro.Remove(isbn);
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
