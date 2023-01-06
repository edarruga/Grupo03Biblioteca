using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
            var prestamosActivosUsuario = BBDD.TablaPrestamo.Where((p)=>p.DniUsuario==dni && p.Estado==Estado.EnProceso);
            var clavePrestamos = prestamosActivosUsuario.Select((p) => p.Id);
            List<Ejemplar> lista = new List<Ejemplar>();
            foreach (ClavePrestamo cp in clavePrestamos)
            {
                foreach (PrestamoEjemplarDato ped in BBDD.TablaPrestamoEjemplar)
                {
                    if (cp.Equals(ped.Id.Prestamo))
                    {
                        Ejemplar e = Transformador.EjemplarDatoAEjemplar(BBDD.Read<ClaveEjemplar, EjemplarDato>(ped.Id.Ejemplar));
                        if (e!=null) lista.Add(e);
                    }
                }
            }
            return lista;
        }

        public static bool TienePrestamoFueraPlazo(string dni)
        {
            var prestamosFueraPlazos = BBDD.TablaPrestamo.Where((p)=>p.DniUsuario==dni && p.Estado==Estado.EnProceso && (DateTime.Now-p.Fecha).TotalDays>15);
            return prestamosFueraPlazos.ToList().Count>0;
        }

        public static List<Usuario> ListaUsuarios()
        {
            var listaUsuarios = BBDD.TablaUsuario.Select((ud)=>Transformador.UsuarioDatoAUsuario(ud));
            return listaUsuarios.ToList();
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
    }
}
