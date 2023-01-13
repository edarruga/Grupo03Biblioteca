using ModeloDeDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeNegocio
{
    public static class MNBiblioteca
    {
        public static string login(string nombre,string contrasena)
        {
            return GestorBD.Login(nombre,contrasena);
        }
        public static bool existeUsuario(string dni)
        {
            return GestorBD.GetUsuario(dni)!=null;
        }
        public static string getNombreUsuario(string dni)
        {
            return GestorBD.GetUsuario(dni).Nombre;
        }
        public static string getApellidosUsuario(string dni)
        {
            return GestorBD.GetUsuario(dni).Apellidos;
        }
        public static bool altaUsuario(string dni,string nombre,string apellidos)
        {
            return GestorBD.AltaUsuario(new Usuario(dni,nombre,apellidos));
        }
        public static bool bajaUsuario(string dni)
        {
            return GestorBD.BajaUsuario(dni);
        }
        public static List<Usuario> listaUsuarios()
        {
            return GestorBD.ListaUsuarios();
        }
        public static List<string> listaDNIs()
        {
            List<string> lista = new List<string>();
            List<Usuario> usuarios = MNBiblioteca.listaUsuarios();
            foreach(Usuario usuario in usuarios)
            {
                lista.Add(usuario.Dni);
            }
            return lista;
        }
        public static int numLibrosPrestados(string dni)
        {
            
            return GestorBD.NumLibrosPrestados(dni);
        }
        public static bool existeLibro(string isbn)
        {
            return GestorBD.GetLibro(isbn) != null;
        }
        public static List<string> listaEjemplares(string isbn)
        {
            List<string> codigos = new List<string>();
            List<Ejemplar> ejemplares = MNAdquisiciones.listaEjemplares(isbn);
            foreach (Ejemplar ejemplar in ejemplares)
            {
                codigos.Add(ejemplar.Codigo);
            }
            return codigos;
        }
        public static bool ejemplarDisponible(string codigo)
        {
            return GestorBD.EjemplarDisponible(codigo);
        }
        public static Ejemplar getEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo);
        }
        public static List<Ejemplar> listaEjemplares(List<string> codigos)
        {
            List<Ejemplar> ejemplares=new List<Ejemplar>();
            foreach(string codigo in codigos)
            {
                ejemplares.Add(getEjemplar(codigo));
            }
            return ejemplares;
        }
        
        public static bool darEjemplarPrestado(string codigo)
        {
            return GestorBD.DarEjemplarPrestado(codigo);
        }
        public static bool devolverEjemplarPrestado(string codigo)
        {
            return GestorBD.DevolverEjemplarPrestado(codigo);
        }
        public static bool existeEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo) != null;
        }
        public static bool estaPrestado(string codigo)
        {
            Prestamo prestamo = MNBiblioteca.ultimoPrestamoActivoDeEjemplar(codigo);
            if (prestamo != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Prestamo ultimoPrestamoActivoDeEjemplar(string codigo)
        {
            List<Prestamo> prestamos = GestorBD.GetPrestamosEnProceso();
            List<Prestamo> prContienen = (prestamos.Where(pr => pr.Contains(MNBiblioteca.getEjemplar(codigo))).ToList());
            bool encontrado = false;
            Prestamo prestamo = null;
            
            foreach (Prestamo p in prContienen)
            {
                if (!encontrado)
                {
                    for (int i = 0; i < p.EjemPrestados.Count; i++)
                    {
                        if (p.EjemPrestados[i].Codigo.Equals(codigo))
                        {
                            if (p.EjemPrestados[i].Prestado)
                            {
                                encontrado = true;
                                prestamo = p;
                            }
                        }
                    }
                }
            }
            return prestamo;
        }
        public static void actualizarEstadoDeEjemplarEnPrestamo(bool prestado,string codigo)
        {
            Prestamo prestamo=MNBiblioteca.ultimoPrestamoActivoDeEjemplar(codigo);
            
            for (int i = 0; i < prestamo.EjemPrestados.Count; i++)
            {
                if (prestamo.EjemPrestados[i].Codigo.Equals(codigo))
                {
                    prestamo.EjemPrestados[i].Prestado = prestado;
                }
            }
            MNBiblioteca.calcularEstadoPrestamo(prestamo);


        }
        public static void calcularEstadoPrestamo(Prestamo prestamo)
        {
            bool devueltos = true;
            for (int i = 0; i < prestamo.EjemPrestados.Count; i++)
            {
                if (prestamo.EjemPrestados[i].Prestado==true)
                {
                    devueltos=false;
                }
            }
            if (devueltos)
            {
                Prestamo pre=GestorBD.GetPrestamo(prestamo.Fecha,prestamo.Usuario.Dni);
                pre.Estado = Estado.Finalizado;
                GestorBD.SetPrestamo(pre);
            }
            else
            {
                Prestamo pre = GestorBD.GetPrestamo(prestamo.Fecha, prestamo.Usuario.Dni);
                pre.Estado = Estado.EnProceso;
                GestorBD.SetPrestamo(pre);
            }
        }
        public static List<Ejemplar> getEjemplaresNoDevueltos()
        {
            return GestorBD.EjemplaresPrestados();
        }
    }
}
