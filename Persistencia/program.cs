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
            //Usuario u = new Usuario("a", "a", "a");
            //List<Ejemplar> lEjemp = new List<Ejemplar>();
            //Libro libro = new Libro("111", "111", "111", "111");
            //Libro libro2 = new Libro("2", "2", "2", "2");
            //Libro libroU = new Libro("111", "update", "update", "update");
            //Ejemplar e = new Ejemplar("22222", libro);
            //Ejemplar e2 = new Ejemplar("33333", libro2);
            //lEjemp.Add(e);
            //lEjemp.Add(e2);
            //Prestamo p = new Prestamo(u, lEjemp);

            //BBDD.Create<ClaveUsuario, UsuarioDato>(Transformador.UsuarioAUsuarioDato(u));
            //BBDD.Create<ClaveLibro, LibroDato>(Transformador.LibroALibroDato(libro));
            //BBDD.Create<ClaveLibro, LibroDato>(Transformador.LibroALibroDato(libro2));

            //BBDD.Create<ClaveEjemplar, EjemplarDato>(Transformador.EjemplarAEjemplarDato(e));
            //BBDD.Create<ClaveEjemplar, EjemplarDato>(Transformador.EjemplarAEjemplarDato(e2));
            //BBDD.Create<ClavePrestamo, PrestamoDato>(Transformador.PrestamoAPrestamoDato(p));

            //BBDD.Update<ClaveLibro, LibroDato>(Transformador.LibroALibroDato(libroU));

            //BBDD.Delete<ClaveLibro, LibroDato>(Transformador.LibroALibroDato(libro2).Id);

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

            //Console.ReadLine();

            PersonalSala ps = new PersonalSala("ola", "soyramon");
            Personal p = new Personal("uwu", "soypingo");
            PersonalServicioAdquisiciones psa = new PersonalServicioAdquisiciones("adios", "mevoi");
            Console.WriteLine(ps.GetType().Name);
            Console.WriteLine(p.GetType().Name);
            Console.WriteLine(psa.GetType().Name);
            BBDD.Create<ClavePersonal, PersonalDato>(Transformador.PersonalAPersonalDato(ps));
            BBDD.Create<ClavePersonal, PersonalDato>(Transformador.PersonalAPersonalDato(p));
            BBDD.Create<ClavePersonal, PersonalDato>(Transformador.PersonalAPersonalDato(psa));
            PersonalDato pd = BBDD.Read<ClavePersonal, PersonalDato>(Transformador.PersonalAPersonalDato(ps).Id);
            Personal pPrueba = Transformador.PersonalDatoAPersonal(pd);
            Console.WriteLine(pPrueba is PersonalSala);
            Console.ReadLine();
        }
    }
}
