
using ModeloDeNegocio;
using Persistencia;
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
                Label ErrorLa= new System.Windows.Forms.Label();
                ErrorLa.AutoSize = true;
                ErrorLa.Location = new System.Drawing.Point(45, 155);
                ErrorLa.Name = "ErrorLa";
                ErrorLa.Size = new System.Drawing.Size(429, 32);
                ErrorLa.TabIndex = 5;
                ErrorLa.Text = "Personal o contraseña incorrectos";
                ErrorLa.ForeColor = System.Drawing.Color.Red;
                this.Controls.Add(ErrorLa);
            }
            
        }
    }
}
