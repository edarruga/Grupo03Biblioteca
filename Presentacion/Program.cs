using ModeloDeDominio;//Esto es incorrecto solo se añade para hacer pruebas
using Persistencia;//Esto es incorrecto solo se añade para hacer pruebas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonalServicioAdquisiciones p = new PersonalServicioAdquisiciones("aaa", "123");
            Usuario u = new Usuario("1234", "Eduardo", "Arruga");
            GestorBD.AltaUsuario(u);
            GestorBD.AltaPersonal(p);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login login = new login();
            Application.Run(login);
            if (login.Tipo == "PersonalServicioAdquisiciones")
            {

                gestionDeBiblioteca gestion = new gestionDeBiblioteca(login.Personal);
                login.Close();
                gestion.ShowDialog();

            }
            else if (login.Tipo == "PersonalSala")
            {

            }

        }
    }
}
