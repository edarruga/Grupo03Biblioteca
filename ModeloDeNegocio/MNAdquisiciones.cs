using ModeloDeDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeNegocio
{
    public class MNAdquisiciones
    {
        public static List<Ejemplar> listaEjemplares(string isbn)
        {
            return GestorBD.ListaEjemplares(isbn);
        }

        public static bool altaLibro(string isbn, string titulo, string autor, string editorial)
        {
            return GestorBD.AltaLibro(new Libro(isbn, titulo, autor, editorial));
        }

        public static bool bajaLibro(string isbn)
        {
            return GestorBD.BajaLibro(isbn);
        }

        public static string getTituloLibro(string isbn)
        {
            return GestorBD.GetLibro(isbn).Titulo;
        }

        public static string getAutorLibro(string isbn)
        {
            return GestorBD.GetLibro(isbn).Autor;
        }
        public static string getEditorialLibro(string isbn)
        {
            return GestorBD.GetLibro(isbn).Editorial;
        }

        public static List<string> listaISBNLibros()
        {
            return GestorBD.ListaLibros().Select(l => l.Isbn).ToList();
        }

        public static List<Libro> listaLibros()
        {
            return GestorBD.ListaLibros();
        }
    }
}
