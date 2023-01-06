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
    }
}
