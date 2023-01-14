
using ModeloDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class login : Form
    {
        private bool logueado = false;
        private string tipo = null;
        private string personal = "";
        public login()
        {
            InitializeComponent();
        }
        public bool Logueado { get { return logueado; }}
        public string Tipo { get { return tipo; }}
        public string Personal { get { return personal; }}


        /// <summary>
        /// Intenta loguearse en la aplicación con los introducidos en las TextBox, si son correctos se mostrará el formulario de gestión de biblioteca que les corresponda acorde a su función,
        /// en caso contrario se mostrará un mensaje de error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Continuar_Click(object sender, EventArgs e)
        {
            this.tipo = MNBiblioteca.login(this.NombreTb.Text, this.ContrasenaTb.Text);
            if (this.tipo!=null)//Comprobar si existe el personal
            {
                this.logueado = true;
                this.personal = this.NombreTb.Text;
                this.Dispose();
            }
            else
            {
                this.logueado = false;
                MessageBox.Show("El personal o la contraseña introducios son incorrectos", "Error de autentificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /*
                Label ErrorLa= new System.Windows.Forms.Label();
                ErrorLa.AutoSize = true;
                ErrorLa.Location = new System.Drawing.Point(45, 155);
                ErrorLa.Name = "ErrorLa";
                ErrorLa.Size = new System.Drawing.Size(429, 32);
                ErrorLa.TabIndex = 5;
                ErrorLa.Text = "Personal o contraseña incorrectos";
                ErrorLa.ForeColor = System.Drawing.Color.Red;
                this.Controls.Add(ErrorLa);
                */
            }
            
        }
    }
}
