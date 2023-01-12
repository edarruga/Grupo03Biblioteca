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
            Libro l = new Libro("111","lll","Eduardo","edit");
            Libro l2 = new Libro("222", "kkk", "Eduardo", "edit");
            Ejemplar e = new Ejemplar("123", l);
            Ejemplar e2 = new Ejemplar("111",l);
            Ejemplar e3 = new Ejemplar("222", l);
            PersonalSala p2 = new PersonalSala("bbb", "123");
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
            GestorBD.AltaLibro(l);
            GestorBD.AltaLibro(l2);
            GestorBD.AltaEjemplar(e);
            GestorBD.AltaEjemplar(e2);
            GestorBD.AltaEjemplar(e3);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.iniciar();
        }
        public static void iniciar()
        {
            
            login login = new login();
            Application.Run(login);
            if (login.Tipo == "PersonalServicioAdquisiciones")
            {

                servicioDeAdquisiciones gestion = new servicioDeAdquisiciones(login.Personal);
                login.Close();
                DialogResult resultado=gestion.ShowDialog();
                if (resultado == DialogResult.Retry)
                {
                    Program.iniciar();
                }

            }
            else if (login.Tipo == "PersonalSala")
            {
                sala gestion = new sala(login.Personal);
                login.Close();
                DialogResult resultado = gestion.ShowDialog();
                if (resultado == DialogResult.Retry)
                {
                    Program.iniciar();
                }
            }
        }
    }
}
