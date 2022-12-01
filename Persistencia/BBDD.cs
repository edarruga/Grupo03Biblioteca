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

        public static bool Add(Libro l) 
        {
            if (!tablaLibro.Contains(l.Isbn) && l!=null)
            {
                tablaLibro.Add(new LibroDato(l.Isbn, l.Autor, l.Editorial));
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
