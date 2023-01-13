using ModeloDeDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeNegocio
{
    public class MNSala
    {
        public static bool altaPrestamo(string dni,List<string> codigos, int estado, DateTime fecha)
        {
            Usuario usuario = new Usuario(dni, MNBiblioteca.getNombreUsuario(dni), MNBiblioteca.getApellidosUsuario(dni));
            List<Ejemplar> ejemplares = MNBiblioteca.listaEjemplares(codigos);
            Estado estadoPrestamo = Estado.EnProceso;
            return GestorBD.AltaPrestamo(new Prestamo(usuario, ejemplares, estadoPrestamo, fecha));
        }
        public static int numLibrosPrestamos(string dni)
        {
            return GestorBD.NumLibrosPrestados(dni);
        }
        public static Prestamo getPrestamo(DateTime fecha, string dni)
        {
            return GestorBD.GetPrestamo(fecha, dni);
        }
        public static List<Prestamo> getPrestamos(string dni)
        {
            return GestorBD.GetPrestamos(dni);
        }
        public static List<Libro> verLibrosNoDevueltos(DateTime fecha,string dni)
        {
            return GestorBD.VerLibrosNoDevueltos(fecha, dni);
        }
        public static bool bajaPrestamo(DateTime fecha,string dni)
        {
            return GestorBD.BajaPrestamo(fecha,dni);
        }
    }
}
