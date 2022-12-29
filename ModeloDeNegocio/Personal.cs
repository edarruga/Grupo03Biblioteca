using ModeloDeDominio;
using Persistencia;

namespace ModeloDeNegocio
{
    public class Personal
    {
        private string username;
        private string password;

        public Personal(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get { return username; } }
        public string Password { get { return password; } }

        public void DarAltaUsuario(Usuario u)
        {
            GestorBD.altaUsuario(u);
        }

        //public bool DarBajaUsuario(Usuario u)
        //{
        //    return false;
        //}

        public Usuario ObtenerUsuario(string dniUsuario)
        {
            return GestorBD.getUsuario(dniUsuario);
        }
    }
}
