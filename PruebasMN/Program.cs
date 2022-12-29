using ModeloDeDominio;
using ModeloDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasMN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario("18082353Y","David", "Armas");
            Personal p = new Personal("daarmas", "1305");
            p.DarAltaUsuario(u);
            Usuario u2 = p.ObtenerUsuario("18082353Y");
            Console.WriteLine();
        }
    }
}
