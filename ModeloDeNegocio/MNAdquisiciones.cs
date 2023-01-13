using ModeloDeDominio;
using Persistencia;
using System.Collections.Generic;
using System.Linq;

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

        public static bool existeEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo) != null;
        }

        public static bool altaEjemplar(string codigo, string isbnLibro)
        {
            Libro l = GestorBD.GetLibro(isbnLibro);
            if (l!=null) return GestorBD.AltaEjemplar(new Ejemplar(codigo, l)); ;
            return false;
        }

        public static bool bajaEjemplar(string codigo)
        {
            return GestorBD.BajaEjemplar(codigo);
        }

        public static bool getEstadoEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo).Prestado;
        }

        public static string getIsbnEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo).Libro.Isbn;
        }

        public static Libro getLibroEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo).Libro;
        }

        public static List<string> listaCodigosEjemplares()
        {
            return GestorBD.ListaEjemplares().Select(l => l.Codigo).ToList();
        }

        public static List<Ejemplar> listaEjemplares()
        {
            return GestorBD.ListaEjemplares();
        }
    }
}
