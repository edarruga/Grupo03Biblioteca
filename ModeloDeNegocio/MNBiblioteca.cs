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
        /// <summary>
        /// Dados un nombre y una contraseña, inicia sesión en la aplicacion.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="contraseña"></param>
        /// <returns>devuelve el tipo asociado al personal que ha iniciado sesión.</returns>
        public static string login(string nombre,string contrasena)
        {
            return GestorBD.Login(nombre,contrasena);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve true si el Usuario asociado al DNI dni existe, falso en caso de no existir en la BBDD.</returns>
        public static bool existeUsuario(string dni)
        {
            return GestorBD.GetUsuario(dni)!=null;
        }

        /// <summary>
        /// Obtiene el nombre del usuario asociado al dni
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve el nombre del Usuario asociado al DNI dni, null en caso de no existir en la BBDD.</returns>
        public static string getNombreUsuario(string dni)
        {
            return GestorBD.GetUsuario(dni).Nombre;
        }

        /// <summary>
        /// Obtiene el apellido del usuario asociado al dni
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve el apellido del Usuario asociado al DNI dni, null en caso de no existir en la BBDD.</returns>
        public static string getApellidosUsuario(string dni)
        {
            return GestorBD.GetUsuario(dni).Apellidos;
        }
        /// <summary>
        /// Transforma el Usuario u a UsuarioDato y lo introduce en la base de datos.
        /// </summary>
        /// <param name="u"></param>
        /// <returns>Verdadero si se crea el Usuario u correctamente, falso en caso contrario</returns>
        public static bool altaUsuario(string dni,string nombre,string apellidos)
        {
            return GestorBD.AltaUsuario(new Usuario(dni,nombre,apellidos));
        }
        /// <summary>
        /// Da da baja el usuario asociado al dni
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Verdadero si se da de baja al usuario con DNI "dni", falso en caso de que no exista un usuario con dni o en caso de fallo</returns>
        public static bool bajaUsuario(string dni)
        {
            return GestorBD.BajaUsuario(dni);
        }

        /// <summary>
        /// Obtiene la lista de usuarios.
        /// </summary>
        /// <returns>Devuelve la lista de usuarios actuales de la BBDD</returns>
        public static List<Usuario> listaUsuarios()
        {
            return GestorBD.ListaUsuarios();
        }
        /// <summary>
        /// Obtiene la lista de dnis de usuarios.
        /// </summary>
        /// <returns>Devuelve la lista de dnis de usuarios actuales de la BBDD</returns>
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

        /// <summary>
        /// Obtiene el numero de libros prestados de un usuario.
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve el numero de libros que ha tomado prestados el usuario asociado al DNI dni.</returns>
        public static int numLibrosPrestados(string dni)
        {
            
            return GestorBD.NumLibrosPrestados(dni);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve true si el Libro asociado al ISBN isbn existe, falso en caso de no existir en la BBDD.</returns>
        public static bool existeLibro(string isbn)
        {
            return GestorBD.GetLibro(isbn) != null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>Devuelve una lista con todos los códigos de ejemplares asociados al libro con ISBN isbn</returns>
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
        /// <summary>
        /// Determina la disponibilidad del ejemplar introducido
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Verdadero si el ejemplar con codigo "codigo" esta disponible actualmente, falso en caso contrario</returns>
        public static bool ejemplarDisponible(string codigo)
        {
            return GestorBD.EjemplarDisponible(codigo);
        }

        /// <summary>
        /// Obtiene el ejemplar el codigo introducido
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Devuelve el ejemplar asociado al codigo "codigo"</returns>
        public static Ejemplar getEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>Devuelve una lista con los ejemplares asociados a los codigos de la lista codigos</returns>
        public static List<Ejemplar> listaEjemplares(List<string> codigos)
        {
            List<Ejemplar> ejemplares=new List<Ejemplar>();
            foreach(string codigo in codigos)
            {
                ejemplares.Add(getEjemplar(codigo));
            }
            return ejemplares;
        }

        /// <summary>
        /// Presta el ejemplar 
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Verdadero si el ejemplar asociado al codigo introducido se presta correctamente, falso en caso contrario</returns>
        public static bool darEjemplarPrestado(string codigo)
        {
            return GestorBD.DarEjemplarPrestado(codigo);
        }

        /// <summary>
        /// Devuelve el ejemplar.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Verdadero si el ejemplar asociado al codigo se devuelve correctamente, falso en caso contrario</returns>
        public static bool devolverEjemplarPrestado(string codigo)
        {
            return GestorBD.DevolverEjemplarPrestado(codigo);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve true si el Ejemplar asociado al Código codigo existe, falso en caso de no existir en la BBDD.</returns>
        public static bool existeEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo) != null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve true si el Ejempalar asociado al Código codigo está prestado, falso en caso contrario.</returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Devuelve el prestamo que contenga en estado prestado el ejemplar que corresponda con el Código codigo</returns>
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
        /// <summary>
        /// Actualiza el estado de un ejemplar en un prestamo concreto
        /// </summary>
        /// <param name="prestado"></param>
        /// <param name="codigo">Tiene que existir un prestamo que contenga un prestamo que corresponda con el String codigo </param>
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

        /// <summary>
        /// Calcula y actualiza el estado de un prestamo según el estado de sus ejemplares
        /// </summary>
        /// <param name="prestamo"></param>
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

        /// <summary>
        /// Obtiene los ejemplares prestados
        /// </summary>
        /// <returns>Devuelve la lista de ejemplares que estan prestados actualmente.</returns>
        public static List<Ejemplar> getEjemplaresNoDevueltos()
        {
            return GestorBD.EjemplaresPrestados();
        }

        /// <summary>
        /// Llena la base de datos de todos los datos iniciales.
        /// </summary>
        public static void poblarBaseDeDatos()
        {
            GestorBD.poblarBaseDeDatos();
        }
    }
}
