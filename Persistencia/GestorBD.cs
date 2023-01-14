using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Persistencia
{
    public static class GestorBD
    {

        /// <summary>
        /// Transforma el Personal p a PersonalDato y lo introduce en la base de datos.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Verdadero si se crea el Personal p correctamente, falso en caso contrario</returns>
        public static bool AltaPersonal(Personal p)
        {
            return BBDD.Create<ClavePersonal, PersonalDato>(Transformador.PersonalAPersonalDato(p));
        }

        /// <summary>
        /// Transforma el Usuario u a UsuarioDato y lo introduce en la base de datos.
        /// </summary>
        /// <param name="u"></param>
        /// <returns>Verdadero si se crea el Usuario u correctamente, falso en caso contrario</returns>
        public static bool AltaUsuario(Usuario u)
        {
            return BBDD.Create<ClaveUsuario, UsuarioDato>(Transformador.UsuarioAUsuarioDato(u));
        }

        /// <summary>
        /// Da da baja el usuario asociado al dni
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Verdadero si se da de baja al usuario con DNI "dni", falso en caso de que no exista un usuario con dni o en caso de fallo</returns>
        public static bool BajaUsuario(string dni)
        {
            return BBDD.Delete<ClaveUsuario, UsuarioDato>(new ClaveUsuario(dni));
        }

        /// <summary>
        /// Obtiene el usuario asociado al dni
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve el Usuario asociado al DNI dni, falso en caso de no existir en la BBDD.</returns>
        public static Usuario GetUsuario(String dni)
        {
            return Transformador.UsuarioDatoAUsuario(BBDD.Read<ClaveUsuario, UsuarioDato>(new ClaveUsuario(dni)));
        }

        /// <summary>
        /// Obtiene los ejemplares activos del usuario
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve la lista de los ejemplares activos del usuario asociado al dni.</returns>
        public static List<Ejemplar> EjemplaresUsuarioActivos(string dni)
        {
            var prestamosActivosUsuario = BBDD.TablaPrestamo.Where((p) => p.DniUsuario == dni && p.Estado == Estado.EnProceso);
            var clavePrestamos = prestamosActivosUsuario.Select((p) => p.Id);
            List<Ejemplar> lista = new List<Ejemplar>();
            foreach (ClavePrestamo cp in clavePrestamos)
            {
                foreach (PrestamoEjemplarDato ped in BBDD.TablaPrestamoEjemplar)
                {
                    if (cp.Equals(ped.Id.Prestamo))
                    {
                        Ejemplar e = Transformador.EjemplarDatoAEjemplar(BBDD.Read<ClaveEjemplar, EjemplarDato>(ped.Id.Ejemplar));
                        if (e != null) lista.Add(e);
                    }
                }
            }
            return lista;
        }

        /// <summary>
        /// Determina si el usuario introducido tiene ejemplares fuera de plazo.
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Verdadero en caso de que el usuario asociado al DNI dni tenga algún prestamo fuera de plazo, falso en caso contrario</returns>
        public static bool TienePrestamoFueraPlazo(string dni)
        {
            var prestamosFueraPlazos = BBDD.TablaPrestamo.Where((p) => p.DniUsuario == dni && p.Estado == Estado.EnProceso && (DateTime.Now - p.Fecha).TotalDays > 15);
            return prestamosFueraPlazos.ToList().Count > 0;
        }

        /// <summary>
        /// Determina si el prestamo esta fuera de plazo.
        /// </summary>
        /// <param name="prestamo"></param>
        /// <returns>Verdadero si el prestamo introducido esta fuera de plazo, es decir, tiene algún libro no devuelto, falso en caso contrario</returns>
        public static bool PrestamoFueraPlazo(Prestamo prestamo)
        {
            var prestamosFueraPlazos = BBDD.TablaPrestamo.Where((p) => p.DniUsuario == prestamo.Usuario.Dni && p.Estado == Estado.EnProceso && (DateTime.Now - p.Fecha).TotalDays > 15);
            return prestamosFueraPlazos.ToList().Count > 0;
        }

        /// <summary>
        /// Obtiene la lista de usuarios.
        /// </summary>
        /// <returns>Devuelve la lista de usuarios actuales de la BBDD</returns>
        public static List<Usuario> ListaUsuarios()
        {
            var listaUsuarios = BBDD.TablaUsuario.Select((ud) => Transformador.UsuarioDatoAUsuario(ud));
            return listaUsuarios.ToList();
        }

        /// <summary>
        /// Obtiene el numero de libros prestados de un usuario.
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve el numero de libros que ha tomado prestados el usuario asociado al DNI dni.</returns>
        public static int NumLibrosPrestados(string dni)
        {
            var librosPrestados =
                from pd in BBDD.TablaPrestamo.Where(prestamo => prestamo.DniUsuario == dni)
                join ped in BBDD.TablaPrestamoEjemplar on pd.Id equals ped.Id.Prestamo
                join ed in BBDD.TablaEjemplar on ped.Id.Ejemplar equals ed.Id
                join ld in BBDD.TablaLibro on ed.IsbnLibro equals ld.Isbn
                select ld;
            var librosPrestadosDistintos = librosPrestados.Distinct();
            return librosPrestadosDistintos.Count();
        }

        /// <summary>
        /// Dados un nombre y una contraseña, inicia sesión en la aplicacion.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="contraseña"></param>
        /// <returns>devuelve el tipo asociado al personal que ha iniciado sesión.</returns>
        public static string Login(string nombre, string contraseña)
        {
            if (BBDD.TablaPersonal.Contains(new ClavePersonal(nombre)))
            {
                PersonalDato pd = BBDD.TablaPersonal[new ClavePersonal(nombre)];
                if (pd.Contraseña == contraseña)
                {
                    return pd.Tipo;
                }
            }
            return null;
        }

        //PERSONAL SERVICIO DE ADQUISICIONES

        /// <summary>
        /// Da de alta un ejemplar
        /// </summary>
        /// <param name="e"></param>
        /// <returns>Verdadero si el ejemplar e es introducido correctamente en la base de datos, falso en caso contrario.</returns>
        public static bool AltaEjemplar(Ejemplar e)
        {
            return BBDD.Create<ClaveEjemplar, EjemplarDato>(Transformador.EjemplarAEjemplarDato(e));
        }

        /// <summary>
        /// Da de baja el ejemplar con el codigo "codigo"
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Verdadero si el ejemplar asociado al codigo es eliminado correctamente de la base de datos, falso en caso contrario.</returns>
        public static bool BajaEjemplar(string codigo)
        {
            return BBDD.Delete<ClaveEjemplar, EjemplarDato>(new ClaveEjemplar(codigo));
        }

        /// <summary>
        /// Da de baja el libro introducido
        /// </summary>
        /// <param name="l"></param>
        /// <returns>Verdadero si el libro se introduce correctamente en la base de datos, falso en caso contrario</returns>
        public static bool AltaLibro(Libro l)
        {
            return BBDD.Create<ClaveLibro, LibroDato>(Transformador.LibroALibroDato(l));
        }

        /// <summary>
        /// Da de baja al libro asociado al isbn introducido
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>Verdadero si el libro se elimina correctamente de la base de datos, falso en caso contrario.</returns>
        public static bool BajaLibro(string isbn)
        {
            return BBDD.Delete<ClaveLibro, LibroDato>(new ClaveLibro(isbn));
        }

        /// <summary>
        /// Obtiene el ejemplar el codigo introducido
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Devuelve el ejemplar asociado al codigo "codigo"</returns>
        public static Ejemplar GetEjemplar(string codigo)
        {
            return Transformador.EjemplarDatoAEjemplar(BBDD.Read<ClaveEjemplar, EjemplarDato>(new ClaveEjemplar(codigo)));
        }

        /// <summary>
        /// Determina la disponibilidad del ejemplar introducido
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Verdadero si el ejemplar con codigo "codigo" esta disponible actualmente, falso en caso contrario</returns>
        public static bool EjemplarDisponible(string codigo)
        {
            if (BBDD.TablaEjemplar.Contains(new ClaveEjemplar(codigo)))
            {
                return !BBDD.Read<ClaveEjemplar, EjemplarDato>(new ClaveEjemplar(codigo)).Prestado;
            }
            return false;
        }

        /// <summary>
        /// Obtiene la fecha en la que el ejemplar estará disponible
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Devuelve la fecha en la que el ejemplar con codigo "codigo" volvera a estar disponible.</returns>
        public static DateTime FechaDisponibleEjemplar(string codigo)
        {
            var lista = BBDD.TablaPrestamoEjemplar.Where(ped => ped.Id.Ejemplar.Codigo == codigo);
            DateTime fechaMayor = new DateTime(0, 0, 0);
            foreach (PrestamoEjemplarDato ped in lista)
            {
                if (fechaMayor < ped.Fecha)
                {
                    fechaMayor = ped.Fecha;
                }
            }
            return fechaMayor.AddDays(15);
        }

        /// <summary>
        /// Obtiene el libro mas prestado
        /// </summary>
        /// <returns>Obtiene el libro que más ocurrencias tiene en la tabla tablaPrestamoEjemplar</returns>
        public static Libro LibroMasPrestado()
        {
            var listaLibros =
                from ped in BBDD.TablaPrestamoEjemplar
                join pd in BBDD.TablaPrestamo on ped.Id.Prestamo equals pd.Id
                group ped by pd into agrupacion
                orderby agrupacion.Count() descending
                select agrupacion.Key;
            PrestamoDato prestDato = listaLibros.First();
            PrestamoEjemplarDato prestEjempDato = BBDD.TablaPrestamoEjemplar.Where(ped => ped.Id.Prestamo.Equals(prestDato.Id)).First();
            EjemplarDato ed = BBDD.TablaEjemplar.Where(ejemplar => ejemplar.Codigo == prestEjempDato.Codigo).First();
            LibroDato ld = BBDD.TablaLibro.Where(libro => ed.IsbnLibro == libro.Isbn).First();
            return Transformador.LibroDatoALibro(ld);
        }

        /// <summary>
        /// Obtiene la lista de los libros
        /// </summary>
        /// <returns>Devuelve la lista de libros actuales en la BBDD</returns>
        public static List<Libro> ListaLibros()
        {
            return BBDD.TablaLibro.Select(l => Transformador.LibroDatoALibro(l)).ToList();
        }

        /// <summary>
        /// Obtiene la lista de ejemplares asociados a un libro
        /// </summary>
        /// <param name="isbnLibro"></param>
        /// <returns>Devuelve la lista de ejemplares asociada al libro con isbn "isbn"</returns>
        public static List<Ejemplar> ListaEjemplares(string isbnLibro)
        {
            return BBDD.TablaEjemplar.Where(ed => ed.IsbnLibro == isbnLibro).Select(ed => Transformador.EjemplarDatoAEjemplar(ed)).ToList();
        }

        /// <summary>
        /// Obtiene la lista de ejemplares
        /// </summary>
        /// <returns>Devuelve la lista de todos los ejemplares actuales en la base de datos.</returns>
        public static List<Ejemplar> ListaEjemplares()
        {
            return BBDD.TablaEjemplar.Select(ed => Transformador.EjemplarDatoAEjemplar(ed)).ToList();
        }

        //PERSONAL DE SALA

        /// <summary>
        /// Da de alta el prestamo 
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Verdadero si el prestamo se introduce correctamente en la base de datos, falso en caso contrario.</returns>
        public static bool AltaPrestamo(Prestamo p)
        {
            return BBDD.Create<ClavePrestamo, PrestamoDato>(Transformador.PrestamoAPrestamoDato(p));
        }

        /// <summary>
        /// Da de baja el prestamo asociado a esa fecha y dni
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="dni"></param>
        /// <returns>Verdadero si el prestamo asociado es eliminado correctamente de la base de datos, falso en caso contrario</returns>
        public static bool BajaPrestamo(DateTime fecha, string dni)
        {
            return BBDD.Delete<ClavePrestamo, PrestamoDato>(new ClavePrestamo(fecha,dni));
        }

        /// <summary>
        /// Obtiene el estado del prestamo
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="dni"></param>
        /// <returns>Devuelve el estado del prestamo asociado a esa fecha y a ese dni</returns>
        public static Estado GetEstadoPrestamo(DateTime fecha, string dni)
        {
            return BBDD.Read<ClavePrestamo, PrestamoDato>(new ClavePrestamo(fecha, dni)).Estado;
        }

        /// <summary>
        /// Obtiene los libros del prestamo
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="dni"></param>
        /// <returns>Devuelve la lista de libros asociados al prestamo con esa fecha y dni</returns>
        public static List<Libro> VerLibrosNoDevueltos(DateTime fecha, string dni)
        {
            ClavePrestamo cpe = new ClavePrestamo(fecha, dni);
            var listaEjemplaresPrestamo = BBDD.TablaPrestamoEjemplar.Where(ped => ped.Id.Prestamo.Equals(cpe));
            List<Libro> listaLibros = new List<Libro>();
            foreach (PrestamoEjemplarDato ped in listaEjemplaresPrestamo)
            {
                EjemplarDato ed = BBDD.Read<ClaveEjemplar, EjemplarDato>(ped.Id.Ejemplar);
                if (ed.Prestado)
                {
                    Ejemplar e = Transformador.EjemplarDatoAEjemplar(ed);
                    if (listaLibros.Contains(e.Libro))
                    {
                        listaLibros.Add(e.Libro);
                    }
                }
            }
            return listaLibros;
        }

        /// <summary>
        /// Obtiene el prestamo
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="dni"></param>
        /// <returns>Devuelve el prestamo asociado a esa fecha y a ese dni</returns>
        public static Prestamo GetPrestamo(DateTime fecha, string dni)
        {
            return Transformador.PrestamoDatoAPrestamo(BBDD.Read<ClavePrestamo, PrestamoDato>(new ClavePrestamo(fecha, dni)));
        }

        /// <summary>
        /// Actualiza el prestamo por el introducido
        /// </summary>
        /// <param name="p"></param>
        public static void SetPrestamo(Prestamo p)
        {
            BBDD.Update<ClavePrestamo, PrestamoDato>(Transformador.PrestamoAPrestamoDato(p));
        }

        /// <summary>
        /// Devuelve el ejemplar.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Verdadero si el ejemplar asociado al codigo se devuelve correctamente, falso en caso contrario</returns>
        public static bool DevolverEjemplarPrestado(string codigo)
        {
            if (BBDD.TablaEjemplar.Contains(new ClaveEjemplar(codigo)))
            {
                EjemplarDato ed = BBDD.Read<ClaveEjemplar, EjemplarDato>(new ClaveEjemplar(codigo));
                ed.Prestado = false;
                return BBDD.Update<ClaveEjemplar, EjemplarDato>(ed);
            }
            return false;
        }

        /// <summary>
        /// Presta el ejemplar 
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Verdadero si el ejemplar asociado al codigo introducido se presta correctamente, falso en caso contrario</returns>
        public static bool DarEjemplarPrestado(string codigo)
        {
            if (BBDD.TablaEjemplar.Contains(new ClaveEjemplar(codigo)))
            {
                EjemplarDato ed = BBDD.Read<ClaveEjemplar, EjemplarDato>(new ClaveEjemplar(codigo));
                ed.Prestado = true;
                return BBDD.Update<ClaveEjemplar, EjemplarDato>(ed);
            }
            return false;
        }

        /// <summary>
        /// Obtiene los prestamos en proceso.
        /// </summary>
        /// <returns>Devuelve la lista de prestamos que siguen en proceso.</returns>
        public static List<Prestamo> GetPrestamosEnProceso()
        {
            var listaEnProceso = BBDD.TablaPrestamo.Where(pd => pd.Estado == Estado.EnProceso);
            return listaEnProceso.Select(pd=> Transformador.PrestamoDatoAPrestamo(pd)).ToList();
        }

        /// <summary>
        /// Obtiene los prestamos finalizados
        /// </summary>
        /// <returns>Devuelve la lista de prestamos que han sido procesados.</returns>
        public static List<Prestamo> GetPrestamosFinalizados()
        {
            var listaEnProceso = BBDD.TablaPrestamo.Where(pd => pd.Estado == Estado.Finalizado);
            return listaEnProceso.Select(pd => Transformador.PrestamoDatoAPrestamo(pd)).ToList();
        }

        /// <summary>
        /// Obtiene los prestamos de un usuario
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve la lista de prestamos asociados al usuario con el dni introducido</returns>
        public static List<Prestamo> GetPrestamos(string dni)
        {
            var listaEnProceso = BBDD.TablaPrestamo.Where(pd => pd.DniUsuario == dni);
            return listaEnProceso.Select(pd => Transformador.PrestamoDatoAPrestamo(pd)).ToList();
        }

        /// <summary>
        /// Obtiene los ejemplares prestados
        /// </summary>
        /// <returns>Devuelve la lista de ejemplares que estan prestados actualmente.</returns>
        public static List<Ejemplar> EjemplaresPrestados()
        {
            var listaEjemplaresNoDevueltos = BBDD.TablaEjemplar.Where(ed => ed.Prestado);
            return listaEjemplaresNoDevueltos.Select(ed => Transformador.EjemplarDatoAEjemplar(ed)).ToList();
        }

        /// <summary>
        /// obtiene el libro
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>Devuelve el libro asociado al isbn introducido</returns>
        public static Libro GetLibro(string isbn)
        {
            return Transformador.LibroDatoALibro(BBDD.Read<ClaveLibro, LibroDato>(new ClaveLibro(isbn)));
        }

        /// <summary>
        /// Llena la base de datos de todos los datos iniciales.
        /// </summary>
        public static void poblarBaseDeDatos()
        {
            PersonalServicioAdquisiciones p = new PersonalServicioAdquisiciones("aaa", "123");
            PersonalServicioAdquisiciones p2 = new PersonalServicioAdquisiciones("daarmas", "daarmas");

            PersonalSala p3 = new PersonalSala("bbb", "123");
            PersonalSala p4 = new PersonalSala("edarruga", "edarruga");

            Libro l = new Libro("111", "Berserk", "Kentaro Miura", "Panini");
            Libro l2 = new Libro("222", "El quijote", "Miguel de Cervantes", "Vicent Vives");
            Libro l3 = new Libro("333", "La sirenita", "Hans Christian Andersen", "Ignac");
            Libro l4 = new Libro("444", "Cronicas de la torre", "Laura Gallego", "SM");

            Ejemplar e = new Ejemplar("123", true,l);
            Ejemplar e2 = new Ejemplar("456", l);
            Ejemplar e3 = new Ejemplar("789", l);

            Ejemplar e4 = new Ejemplar("111", l2);
            Ejemplar e5 = new Ejemplar("222", l2);
            Ejemplar e6 = new Ejemplar("333", l2);

            Ejemplar e7 = new Ejemplar("321", l3);
            Ejemplar e8 = new Ejemplar("654", l3);
            Ejemplar e9 = new Ejemplar("987", l3);

            Ejemplar e10 = new Ejemplar("122", true,l4);
            Ejemplar e11 = new Ejemplar("211", l4);
            Ejemplar e12 = new Ejemplar("322", l4);

            Usuario u = new Usuario("1234", "Eduardo", "Arruga");
            Usuario u2 = new Usuario("12345678A", "Alejandro", "Martinez");
            Usuario u3 = new Usuario("11111111Z", "Pablo", "Gomez");
            Usuario u4 = new Usuario("22222222X", "David", "Armas");

            GestorBD.AltaUsuario(u);
            GestorBD.AltaUsuario(u2);
            GestorBD.AltaUsuario(u3);
            GestorBD.AltaUsuario(u4);
            GestorBD.AltaPersonal(p);
            GestorBD.AltaPersonal(p2);
            GestorBD.AltaPersonal(p3);
            GestorBD.AltaPersonal(p4);
            GestorBD.AltaLibro(l);
            GestorBD.AltaLibro(l2);
            GestorBD.AltaLibro(l3);
            GestorBD.AltaLibro(l4);
            GestorBD.AltaEjemplar(e);
            GestorBD.AltaEjemplar(e2);
            GestorBD.AltaEjemplar(e3);
            GestorBD.AltaEjemplar(e4);
            GestorBD.AltaEjemplar(e5);
            GestorBD.AltaEjemplar(e6);
            GestorBD.AltaEjemplar(e7);
            GestorBD.AltaEjemplar(e8);
            GestorBD.AltaEjemplar(e9);
            GestorBD.AltaEjemplar(e10);
            GestorBD.AltaEjemplar(e11);
            GestorBD.AltaEjemplar(e12);

            List<Ejemplar> lista = new List<Ejemplar>();
            lista.Add(e10);
            lista.Add(e);

            DateTime fecha = DateTime.Now;
            string f=fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string[] validformats = new[] { "MM/dd/yyyy", "yyyy/MM/dd", "MM/dd/yyyy HH:mm:ss",
                                        "MM/dd/yyyy hh:mm tt","yyyy-MM-dd HH:mm:ss", "yyyy-MM-dd HH:mm:ss, fff" };

            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime fechaFinal;

            DateTime.TryParseExact(f, validformats, provider, DateTimeStyles.None, out fechaFinal);

            Prestamo pr = new Prestamo(u2, lista, Estado.EnProceso, fechaFinal);
            GestorBD.AltaPrestamo(pr);
        }
    }
    
}
