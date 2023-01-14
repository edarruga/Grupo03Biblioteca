using ModeloDeDominio;
using Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace ModeloDeNegocio
{
    public class MNAdquisiciones
    {
        /// <summary>
        /// Obtiene los ejemplares asociados al libro introducido
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>Devuelve la lista de ejemplares asociados al libro con el isbn introducido</returns>
        public static List<Ejemplar> listaEjemplares(string isbn)
        {
            return GestorBD.ListaEjemplares(isbn);
        }

        /// <summary>
        /// Da alta del libro con los datos introducidos
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="editorial"></param>
        /// <returns>Verdadero en caso de introducir correctamente el libro con los datos introducidos a la base de datos, falso en caso contrario</returns>
        public static bool altaLibro(string isbn, string titulo, string autor, string editorial)
        {
            return GestorBD.AltaLibro(new Libro(isbn, titulo, autor, editorial));
        }

        /// <summary>
        /// Da de baja al libro introducido
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>Verdadero si el libro con el isbn introducido es eliminado correctamente de la base de datos, falso en caso contrario</returns>
        public static bool bajaLibro(string isbn)
        {
            return GestorBD.BajaLibro(isbn);
        }

        /// <summary>
        /// Obtiene el titulo del libro
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>Devuelve el titulo del libro con el isbn introducido</returns>
        public static string getTituloLibro(string isbn)
        {
            return GestorBD.GetLibro(isbn).Titulo;
        }

        /// <summary>
        /// Obtiene el autor del libro
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>Devuelve el autor del libro con el isbn introducido</returns>
        public static string getAutorLibro(string isbn)
        {
            return GestorBD.GetLibro(isbn).Autor;
        }

        /// <summary>
        /// Obtiene la editorial del libro
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>Devuelve la editorial del libro con el isbn introducido</returns>
        public static string getEditorialLibro(string isbn)
        {
            return GestorBD.GetLibro(isbn).Editorial;
        }

        /// <summary>
        /// Obtiene los ISBNs de los libros
        /// </summary>
        /// <returns>Devuelve una lista de ISBNs de libros contenidos en la base de datos.</returns>
        public static List<string> listaISBNLibros()
        {
            return GestorBD.ListaLibros().Select(l => l.Isbn).ToList();
        }

        /// <summary>
        /// Obtiene los libros
        /// </summary>
        /// <returns>Devuelve la lista de los libros actuales en la base de datos.</returns>
        public static List<Libro> listaLibros()
        {
            return GestorBD.ListaLibros();
        }

        /// <summary>
        /// Determina si existe el ejemplar
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Verdadero si el ejemplar asociado al codigo existe, falso en caso contrario</returns>
        public static bool existeEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo) != null;
        }

        /// <summary>
        /// Da el alta de un ejemplar
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="isbnLibro"></param>
        /// <returns>Verdadero si el ejemplar con los datos introducidos es creado correctamente en la base de datos, falso en caso contrario</returns>
        public static bool altaEjemplar(string codigo, string isbnLibro)
        {
            Libro l = GestorBD.GetLibro(isbnLibro);
            if (l!=null) return GestorBD.AltaEjemplar(new Ejemplar(codigo, l)); ;
            return false;
        }

        /// <summary>
        /// Da de baja el ejemplar
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Verdadero en caso de eliminar el ejemplar asociado al codigo introducido correctamente, falso en caso contrario</returns>
        public static bool bajaEjemplar(string codigo)
        {
            return GestorBD.BajaEjemplar(codigo);
        }

        /// <summary>
        /// Determina si un ejemplar se encuentra prestado
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Verdadero si el ejemplar asociado al codigo introducido esta prestado, falso en caso contrario.</returns>
        public static bool getEstadoEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo).Prestado;
        }

        /// <summary>
        /// Obtiene el isbn del ejemplar
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Devuelve el isbn del ejemplar con el codigo introducido.</returns>
        public static string getIsbnEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo).Libro.Isbn;
        }

        /// <summary>
        /// Obtiene el libro del ejemplar
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Devuelve el libro asociado al ejemplar con el codigo introducido</returns>
        public static Libro getLibroEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo).Libro;
        }

        /// <summary>
        /// Obtiene los codigos de los ejemplares
        /// </summary>
        /// <returns>Devuelve la lista de los codigos de los ejemplares actuales de la base de datos.</returns>
        public static List<string> listaCodigosEjemplares()
        {
            return GestorBD.ListaEjemplares().Select(l => l.Codigo).ToList();
        }

        /// <summary>
        /// Obtiene los ejemplares
        /// </summary>
        /// <returns>Devuelve la lista de los ejemplares actuales de la base de datos.</returns>
        public static List<Ejemplar> listaEjemplares()
        {
            return GestorBD.ListaEjemplares();
        }
    }
}
