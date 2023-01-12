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
    }
}
