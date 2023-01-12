using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Persistencia
{
    public static class GestorBD
    {
        public static bool AltaPersonal(Personal p)
        {
            return BBDD.Create<ClavePersonal, PersonalDato>(Transformador.PersonalAPersonalDato(p));
        }
        public static bool AltaUsuario(Usuario u)
        {
            return BBDD.Create<ClaveUsuario, UsuarioDato>(Transformador.UsuarioAUsuarioDato(u));
        }
        public static bool BajaUsuario(string dni)
        {
            return BBDD.Delete<ClaveUsuario, UsuarioDato>(new ClaveUsuario(dni));
        }
        public static Usuario GetUsuario(String dni)
        {
            return Transformador.UsuarioDatoAUsuario(BBDD.Read<ClaveUsuario, UsuarioDato>(new ClaveUsuario(dni)));
        }

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

        public static bool TienePrestamoFueraPlazo(string dni)
        {
            var prestamosFueraPlazos = BBDD.TablaPrestamo.Where((p) => p.DniUsuario == dni && p.Estado == Estado.EnProceso && (DateTime.Now - p.Fecha).TotalDays > 15);
            return prestamosFueraPlazos.ToList().Count > 0;
        }

        public static List<Usuario> ListaUsuarios()
        {
            var listaUsuarios = BBDD.TablaUsuario.Select((ud) => Transformador.UsuarioDatoAUsuario(ud));
            return listaUsuarios.ToList();
        }

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

        public static bool AltaEjemplar(Ejemplar e)
        {
            return BBDD.Create<ClaveEjemplar, EjemplarDato>(Transformador.EjemplarAEjemplarDato(e));
        }

        public static bool BajaEjemplar(string codigo)
        {
            return BBDD.Delete<ClaveEjemplar, EjemplarDato>(new ClaveEjemplar(codigo));
        }

        public static bool AltaLibro(Libro l)
        {
            return BBDD.Create<ClaveLibro, LibroDato>(Transformador.LibroALibroDato(l));
        }

        public static bool BajaLibro(string isbn)
        {
            return BBDD.Delete<ClaveLibro, LibroDato>(new ClaveLibro(isbn));
        }

        public static Ejemplar GetEjemplar(string codigo)
        {
            return Transformador.EjemplarDatoAEjemplar(BBDD.Read<ClaveEjemplar, EjemplarDato>(new ClaveEjemplar(codigo)));
        }

        public static bool EjemplarDisponible(string codigo)
        {
            if (BBDD.TablaEjemplar.Contains(new ClaveEjemplar(codigo)))
            {
                return !BBDD.Read<ClaveEjemplar, EjemplarDato>(new ClaveEjemplar(codigo)).Prestado;
            }
            return false;
        }

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

        public static List<Libro> ListaLibros()
        {
            return BBDD.TablaLibro.Select(l => Transformador.LibroDatoALibro(l)).ToList();
        }

        public static List<Ejemplar> ListaEjemplares(string isbnLibro)
        {
            return BBDD.TablaEjemplar.Where(ed => ed.IsbnLibro == isbnLibro).Select(ed => Transformador.EjemplarDatoAEjemplar(ed)).ToList();
        }

        //PERSONAL DE SALA

        public static bool AltaPrestamo(Prestamo p)
        {
            return BBDD.Create<ClavePrestamo, PrestamoDato>(Transformador.PrestamoAPrestamoDato(p));
        }

        public static bool BajaPrestamo(DateTime fecha, string dni)
        {
            return BBDD.Delete<ClavePrestamo, PrestamoDato>(new ClavePrestamo(fecha,dni));
        }

        public static Usuario GetUsuarioByPrestamo(DateTime fecha, string dni)
        {
            PrestamoDato p = BBDD.Read<ClavePrestamo, PrestamoDato>(new ClavePrestamo(fecha, dni));
            return Transformador.UsuarioDatoAUsuario(BBDD.Read<ClaveUsuario, UsuarioDato>(new ClaveUsuario(p.DniUsuario)));
        }

        public static Estado GetEstadoPrestamo(DateTime fecha, string dni)
        {
            return BBDD.Read<ClavePrestamo, PrestamoDato>(new ClavePrestamo(fecha, dni)).Estado;
        }

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

        public static Prestamo GetPrestamo(DateTime fecha, string dni)
        {
            return Transformador.PrestamoDatoAPrestamo(BBDD.Read<ClavePrestamo, PrestamoDato>(new ClavePrestamo(fecha, dni)));
        }

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

        public static List<Prestamo> GetPrestamosEnProceso()
        {
            var listaEnProceso = BBDD.TablaPrestamo.Where(pd => pd.Estado == Estado.EnProceso);
            return listaEnProceso.Select(pd=> Transformador.PrestamoDatoAPrestamo(pd)).ToList();
        }

        public static List<Ejemplar> EjemplaresPrestados()
        {
            var listaEjemplaresNoDevueltos = BBDD.TablaEjemplar.Where(ed => ed.Prestado);
            return listaEjemplaresNoDevueltos.Select(ed => Transformador.EjemplarDatoAEjemplar(ed)).ToList();
        }
        public static Libro GetLibro(string isbn)
        {
            return Transformador.LibroDatoALibro(BBDD.Read<ClaveLibro, LibroDato>(new ClaveLibro(isbn)));
        }
    }
}
