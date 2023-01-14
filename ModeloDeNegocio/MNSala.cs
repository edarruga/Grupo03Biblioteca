using ModeloDeDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeNegocio
{
    public static class MNSala
    {
        /// <summary>
        /// Da de alta el prestamo 
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Verdadero si el prestamo se introduce correctamente en la base de datos, falso en caso contrario.</returns>
        public static bool altaPrestamo(string dni,List<string> codigos, int estado, DateTime fecha)
        {
            Usuario usuario = new Usuario(dni, MNBiblioteca.getNombreUsuario(dni), MNBiblioteca.getApellidosUsuario(dni));
            List<Ejemplar> ejemplares = MNBiblioteca.listaEjemplares(codigos);
            Estado estadoPrestamo = Estado.EnProceso;
            return GestorBD.AltaPrestamo(new Prestamo(usuario, ejemplares, estadoPrestamo, fecha));
        }

        /// <summary>
        /// Obtiene el prestamo
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="dni"></param>
        /// <returns>Devuelve el prestamo asociado a esa fecha y a ese dni</returns>
        public static Prestamo getPrestamo(DateTime fecha, string dni)
        {
            return GestorBD.GetPrestamo(fecha, dni);
        }

        /// <summary>
        /// Obtiene los prestamos de un usuario
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve la lista de prestamos asociados al usuario con el dni introducido</returns>
        public static List<Prestamo> getPrestamos(string dni)
        {
            return GestorBD.GetPrestamos(dni);
        }
        /// <summary>
        /// Obtiene todos los prestamos
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve la lista de todos los prestamos</returns>
        public static List<Prestamo> getPrestamos()
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            List<Usuario> usuarios =MNBiblioteca.listaUsuarios();
            List<Prestamo> prestamosUsuario=new List<Prestamo>();
            foreach (Usuario usuario in usuarios)
            {
                prestamosUsuario = MNSala.getPrestamos(usuario.Dni);
                foreach(Prestamo prestamo in prestamosUsuario)
                {
                    prestamos.Add(prestamo);
                }
            }
            return prestamos;
        }

        /// <summary>
        /// Obtiene los prestamos en proceso.
        /// </summary>
        /// <returns>Devuelve la lista de prestamos que siguen en proceso.</returns>
        public static List<Prestamo> getPrestamosEnProceso()
        {
            return GestorBD.GetPrestamosEnProceso();
        }
        /// <summary>
        /// Obtiene los prestamos finalizados
        /// </summary>
        /// <returns>Devuelve la lista de prestamos que han sido procesados.</returns>
        public static List<Prestamo> getPrestamosFinalizados()
        {
            return GestorBD.GetPrestamosFinalizados();
        }

        /// <summary>
        /// Obtiene los libros del prestamo
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="dni"></param>
        /// <returns>Devuelve la lista de libros asociados al prestamo con esa fecha y dni</returns>
        public static List<Libro> verLibrosNoDevueltos(DateTime fecha,string dni)
        {
            return GestorBD.VerLibrosNoDevueltos(fecha, dni);
        }
        /// <summary>
        /// Da de baja el prestamo asociado a esa fecha y dni
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="dni"></param>
        /// <returns>Verdadero si el prestamo asociado es eliminado correctamente de la base de datos, falso en caso contrario</returns>
        public static bool bajaPrestamo(DateTime fecha,string dni)
        {
            
            return GestorBD.BajaPrestamo(fecha,dni);
        }
        /// <summary>
        /// Determina si el prestamo esta fuera de plazo.
        /// </summary>
        /// <param name="prestamo"></param>
        /// <returns>Verdadero si el prestamo introducido esta fuera de plazo, es decir, tiene algún libro no devuelto, falso en caso contrario</returns>
        public static bool prestamoFueraPlazo(Prestamo prestamo)
        {
            return GestorBD.PrestamoFueraPlazo(prestamo);
        }
    }
}
