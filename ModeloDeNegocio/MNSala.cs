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
        public static Prestamo getPrestamo(DateTime fecha, string dni)
        {
            return GestorBD.GetPrestamo(fecha, dni);
        }
        public static List<Prestamo> getPrestamos(string dni)
        {
            return GestorBD.GetPrestamos(dni);
        }
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
        public static List<Prestamo> getPrestamosEnProceso()
        {
            return GestorBD.GetPrestamosEnProceso();
        }
        public static List<Prestamo> getPrestamosFinalizados()
        {
            return GestorBD.GetPrestamosFinalizados();
        }
        public static List<Libro> verLibrosNoDevueltos(DateTime fecha,string dni)
        {
            return GestorBD.VerLibrosNoDevueltos(fecha, dni);
        }
        public static bool bajaPrestamo(DateTime fecha,string dni)
        {
            
            return GestorBD.BajaPrestamo(fecha,dni);
        }
        public static bool prestamoFueraPlazo(Prestamo prestamo)
        {
            return GestorBD.PrestamoFueraPlazo(prestamo);
        }
    }
}
