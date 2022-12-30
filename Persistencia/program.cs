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
            Usuario u = new Usuario("a", "a", "a");
            List<Ejemplar> lEjemp = new List<Ejemplar>();
            Libro libro = new Libro("111", "111", "111", "111");
            Ejemplar e = new Ejemplar("22222", libro);
            Ejemplar e2 = new Ejemplar("33333", libro);
            lEjemp.Add(e);
            lEjemp.Add(e2);
            Prestamo p = new Prestamo(u, lEjemp);

            BBDD.Create<ClaveUsuario, UsuarioDato>(Transformador.UsuarioAUsuarioDato(u));
            BBDD.Create<ClaveLibro, LibroDato>(Transformador.LibroALibroDato(libro));
            BBDD.Create<ClaveEjemplar, EjemplarDato>(Transformador.EjemplarAEjemplarDato(e));
            BBDD.Create<ClaveEjemplar, EjemplarDato>(Transformador.EjemplarAEjemplarDato(e2));
            BBDD.Create<ClavePrestamo, PrestamoDato>(Transformador.PrestamoAPrestamoDato(p));

            //Libro l = new Libro("222", "a", "ola", "pingop");
            //Libro l2 = new Libro("222", "", "", "");
            //LibroDato ld2 = Transformador.LibroALibroDato(l2); 

            //Table<ClaveLibro, LibroDato> libroDatos = new Table<ClaveLibro, LibroDato>();
            //libroDatos.Add(Transformador.LibroALibroDato(l));
            //Console.WriteLine(libroDatos.Contains(ld2.Id));
            //LibroDato ld = BBDD.Read<ClaveLibro, LibroDato>(ld2.Id);

            //Ejemplar e = new Ejemplar("22222", new Libro("111", "111", "111", "111"));
            //EjemplarDato ed = Transformador.EjemplarAEjemplarDato(e);

            //Table<ClaveEjemplar, EjemplarDato> ejemplarDatos = new Table<ClaveEjemplar, EjemplarDato>();
            //ejemplarDatos.Add(ed);
            //Console.WriteLine(ejemplarDatos.Contains(ed.Id));

            //BBDD.Create<ClaveEjemplar, EjemplarDato>(ed);
            //EjemplarDato ed2 = BBDD.Read<ClaveEjemplar, EjemplarDato>(Transformador.EjemplarAEjemplarDato(e).Id);

            Console.ReadLine();
        }
    }
}
