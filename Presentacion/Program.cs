using ModeloDeNegocio;
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
            MNBiblioteca.poblarBaseDeDatos();
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
