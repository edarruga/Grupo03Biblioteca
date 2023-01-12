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
    }
}
