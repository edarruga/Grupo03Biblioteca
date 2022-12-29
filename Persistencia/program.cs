using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class program
    {

        private static IEqualityComparer<ClaveUsuario> comparer= EqualityComparer<ClaveUsuario>.Default;

        static void Main(string[] args)
        {
            //Usuario u = new Usuario("a","a","a");
            //List<Ejemplar> lEjemp = new List<Ejemplar>();
            //lEjemp.Add(new Ejemplar("22222", new Libro("111", "111", "111", "111")));
            //lEjemp.Add(new Ejemplar("33333", new Libro("111", "111", "111", "111")));
            //Prestamo p = new Prestamo(u, lEjemp);

            //BBDD.Create<ClaveUsuario, UsuarioDato>(Transformador.UsuarioAUsuarioDato(u));
            //BBDD.Create<ClavePrestamo, PrestamoDato>(Transformador.PrestamoAPrestamoDato(p));

            Ejemplar e = new Ejemplar("22222", new Libro("111", "111", "111", "111"));
            BBDD.Create<ClaveEjemplar, EjemplarDato>(Transformador.EjemplarAEjemplarDato(e));
            EjemplarDato ed = BBDD.Read<ClaveEjemplar, EjemplarDato>(Transformador.EjemplarAEjemplarDato(e).Id);

            Console.ReadLine();
        }
    }
}
