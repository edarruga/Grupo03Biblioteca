using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public static class GestorBD
    {
        public static bool altaUsuario(Usuario u)
        {
            return BBDD.Create<ClaveUsuario, UsuarioDato>(Transformador.UsuarioAUsuarioDato(u));
        }
        public static bool bajaUsuario(string dni)
        {

            
            return false;
        }
        public static Usuario getUsuario(String dni)
        {
            return Transformador.UsuarioDatoAUsuario(BBDD.Read<ClaveUsuario, UsuarioDato>(new ClaveUsuario(dni)));
        }
    }
}
