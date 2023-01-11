using ModeloDeDominio;
using ModeloDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class gestionDeBiblioteca : Form
    {
        public gestionDeBiblioteca(String nombre)
        {
            InitializeComponent();
            this.Text = nombre+" - Gestión de biblioteca";

        }
        public gestionDeBiblioteca()
        {
            InitializeComponent();

        }


        private void altaTsmi_Click(object sender, EventArgs e)
        {
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir DNI";
            introducir.ClaveL.Text = "DNI:";
            DialogResult resultado=introducir.ShowDialog();
            if (DialogResult.OK==resultado)
            {
                if (introducir.Clave != "")
                {
                    if (!MNBiblioteca.existeUsuario(introducir.Clave))
                    {
                        alta altaUsuario = new alta();
                        altaUsuario.Text = "Alta de un usuario";
                        claveUC dniUC = new claveUC(85, 50, "DNI:", introducir.Clave);
                        datoUC nombreUC = new datoUC(85, 100, "Nombre:");
                        datoUC apellidosUC = new datoUC(85, 150, "Apellidos:");
                        nombreUC.Name = "nombreUC";
                        apellidosUC.Name = "apellidosUC";
                        altaUsuario.Controls.Add(dniUC);
                        altaUsuario.Controls.Add(nombreUC);
                        altaUsuario.Controls.Add(apellidosUC);
                        DialogResult usuario = altaUsuario.ShowDialog();
                        if (usuario == DialogResult.OK)
                        {
                            if (((datoUC)altaUsuario.Controls["nombreUC"]).Dato == "")
                            {
                                MessageBox.Show("Debes introducir un nombre para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.altaTsmi_Click(sender, e);
                            }
                            else if (((datoUC)altaUsuario.Controls["apellidosUC"]).Dato == "")
                            {
                                MessageBox.Show("Debes introducir algún apellido para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.altaTsmi_Click(sender, e);
                            }
                            else
                            {
                                if(!ModeloDeNegocio.MNBiblioteca.altaUsuario(introducir.Clave, ((datoUC)altaUsuario.Controls["nombreUC"]).Dato, ((datoUC)altaUsuario.Controls["apellidosUC"]).Dato))
                                {
                                    MessageBox.Show("No se pudo realizar correctamente la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                
                            }

                        }
                        else
                        {
                            introducir.Close();
                        }
                        introducir.Dispose();
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un usuario con ese DNI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.altaTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro DNI es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.altaTsmi_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
            
        }

        private void bajaTsmi_Click(object sender, EventArgs e)
        {
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir DNI";
            introducir.ClaveL.Text = "DNI:";
            DialogResult resultado = introducir.ShowDialog();
            if (DialogResult.OK == resultado)
            {
                if (introducir.Clave != "")
                {
                    if (MNBiblioteca.existeUsuario(introducir.Clave))
                    {
                        alta altaUsuario = new alta();
                        altaUsuario.Text = "Baja de un usuario";
                        claveUC dniUC = new claveUC(85, 50, "DNI:", introducir.Clave);
                        datoUC nombreUC = new datoUC(85, 100, "Nombre:");
                        datoUC apellidosUC = new datoUC(85, 150, "Apellidos:");
                        nombreUC.Name = "nombreUC";
                        apellidosUC.Name = "apellidosUC";
                        nombreUC.DatoTbUC.ReadOnly = true;
                        nombreUC.DatoTbUC.Text = ModeloDeNegocio.MNBiblioteca.getNombreUsuario(introducir.Clave);
                        apellidosUC.DatoTbUC.ReadOnly = true;
                        apellidosUC.DatoTbUC.Text = ModeloDeNegocio.MNBiblioteca.getApellidosUsuario(introducir.Clave);
                        altaUsuario.Controls.Add(dniUC);
                        altaUsuario.Controls.Add(nombreUC);
                        altaUsuario.Controls.Add(apellidosUC);
                        DialogResult usuario = altaUsuario.ShowDialog();
                        if (usuario == DialogResult.OK)
                        {

                            DialogResult aviso = MessageBox.Show("¿Está seguro que desea dar de baja al usuario?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (aviso == DialogResult.OK)
                            {
                                if (ModeloDeNegocio.MNBiblioteca.bajaUsuario(introducir.Clave))
                                {
                                    MessageBox.Show("Usuario eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                }
                            }

                        }
                        else
                        {
                            introducir.Close();
                        }
                        introducir.Dispose();
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "No existe ningún usuario con ese DNI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.bajaTsmi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro DNI es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.bajaTsmi_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
        }

        private void seleccionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> dnis = MNBiblioteca.listaDNIs();
            datosDesplegables datosUsuario = new datosDesplegables();
            datosUsuario.Text = "Datos del usuario";
            datoUC nombreUC = new datoUC(85, 100, "Nombre:");
            datoUC apellidosUC = new datoUC(85, 150, "Apellidos:");
            nombreUC.DatoTbUC.ReadOnly = true;
            nombreUC.Name = "nombreUC";
            apellidosUC.DatoTbUC.ReadOnly = true;
            apellidosUC.Name = "apellidosUC";
            datosUsuario.ClaveDesplegableCb.DataSource = dnis;
            datosUsuario.ClaveDesplegableCb.SelectedIndex = -1;
            datosUsuario.ClaveDesplegableCb.SelectedIndexChanged += (s, ev) => cambiarDatosUsuario(sender, e, datosUsuario);
            datosUsuario.Controls.Add(nombreUC);
            datosUsuario.Controls.Add(apellidosUC);
            DialogResult usuario = datosUsuario.ShowDialog();

        }
        private void cambiarDatosUsuario(object sender,EventArgs e,datosDesplegables datosUsuario)
        {
            datoUC nombreUC = (datoUC)datosUsuario.Controls["nombreUC"];
            datoUC apellidosUC = (datoUC)datosUsuario.Controls["apellidosUC"];
            string dni = (string)datosUsuario.ClaveDesplegableCb.SelectedValue;
            if (dni != null)
            {
                string nombre = MNBiblioteca.getNombreUsuario(dni);
                nombreUC.DatoTbUC.Text = nombre;

                string apellidos = MNBiblioteca.getApellidosUsuario(dni);
                apellidosUC.DatoTbUC.Text= apellidos;
            }
        }

        private void introducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Introducir introducir = new Introducir();
            introducir.Text = "Introducir DNI";
            introducir.ClaveL.Text = "DNI:";
            DialogResult resultado = introducir.ShowDialog();
            if (DialogResult.OK == resultado)
            {
                if (introducir.Clave != "")
                {
                    if (MNBiblioteca.existeUsuario(introducir.Clave))
                    {
                        datos datosUsuario = new datos();
                        datosUsuario.Text = "Datos del usuario";
                        claveUC dniUC = new claveUC(85, 50, "DNI:", introducir.Clave);
                        datoUC nombreUC = new datoUC(85, 100, "Nombre:");
                        datoUC apellidosUC = new datoUC(85, 150, "Apellidos:");
                        nombreUC.Name = "nombreUC";
                        apellidosUC.Name = "apellidosUC";
                        nombreUC.DatoTbUC.ReadOnly = true;
                        nombreUC.DatoTbUC.Text = ModeloDeNegocio.MNBiblioteca.getNombreUsuario(introducir.Clave);
                        apellidosUC.DatoTbUC.ReadOnly = true;
                        apellidosUC.DatoTbUC.Text = ModeloDeNegocio.MNBiblioteca.getApellidosUsuario(introducir.Clave);
                        datosUsuario.Controls.Add(dniUC);
                        datosUsuario.Controls.Add(nombreUC);
                        datosUsuario.Controls.Add(apellidosUC);
                        DialogResult usuario = datosUsuario.ShowDialog();
                        
                        introducir.Dispose();
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "No existe ningún usuario con ese DNI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (error == DialogResult.OK)
                        {
                            this.introducirToolStripMenuItem_Click(sender, e);
                        }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("¿Quieres introducir otro?", "El parametro DNI es obligatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (error == DialogResult.OK)
                    {
                        this.introducirToolStripMenuItem_Click(sender, e);
                    }
                }
            }
            else
            {
                introducir.Close();
            }
            introducir.Dispose();
        }

        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listadoUsuarios listado = new listadoUsuarios(MNBiblioteca.listaUsuarios());
            listado.ShowDialog();
            /*
            listado listado = new listado();
            listado.Text = "Listado de usuarios";
            

            claveListado dni=new claveListado(70,0,"DNI",MNBiblioteca.listaUsuarios());
            claveListado nombre = new claveListado(190,0,"Nombre", MNBiblioteca.listaUsuarios());
            claveListado apellidos = new claveListado(310, 0, "Apellidos", MNBiblioteca.listaUsuarios());

            listado.Controls.Add(dni);
            listado.Controls.Add(nombre);
            listado.Controls.Add(apellidos);
            listado.ShowDialog();
            */
        }

        private void recorridoUnoAUnoTsmi_Click(object sender, EventArgs e)
        {
            rocorridoUnoaUno recorrido=new rocorridoUnoaUno();
            List<Usuario> listaUsuarios=MNBiblioteca.listaUsuarios();
            recorrido.Text = "Datos de un usuario";
            claveUC dniUC = new claveUC(20,50, "DNI:");
            datoUC nombreUC = new datoUC(20, 80, "Nombre:");
            datoUC apellidosUC = new datoUC(20, 110, "Apellidos:");
            datoUC numLibrosUC = new datoUC(20, 140, "Libros prestados:");
            dniUC.Name = "dniUC";
            nombreUC.DatoTbUC.ReadOnly = true;
            nombreUC.Name = "nombreUC"; 
            apellidosUC.DatoTbUC.ReadOnly = true;
            apellidosUC.Name = "apellidosUC";
            numLibrosUC.DatoTbUC.ReadOnly = true;
            numLibrosUC.Name = "numLibrosUC";
            foreach(Usuario u in listaUsuarios)
            {
                recorrido.BindingNavigator.BindingSource.Add(u);
            }
            recorrido.BindingNavigatorPositionItem.TextChanged += (s, ev) => cambiarDatosUsuarioUnoaUno(sender, e, recorrido);

            recorrido.Controls.Add(dniUC);
            recorrido.Controls.Add(nombreUC);
            recorrido.Controls.Add(apellidosUC);
            recorrido.Controls.Add(numLibrosUC);
            /*
            recorrido.BindingNavigator.MoveFirstItem.Click += delegate (object se, EventArgs eve)
            {
                recorrido.BindingNavigator.BindingSource.MoveFirst();

            };
            recorrido.BindingNavigator.MovePreviousItem.Click += delegate (object se, EventArgs eve)
            {
                recorrido.BindingNavigator.BindingSource.MovePrevious();

            };
            recorrido.BindingNavigator.MoveNextItem.Click += delegate (object se, EventArgs eve)
            {
                recorrido.BindingNavigator.BindingSource.MoveNext();

            };
            recorrido.BindingNavigator.MoveLastItem.Click += delegate (object se, EventArgs eve)
            {
                recorrido.BindingNavigator.BindingSource.MoveLast();

            };
            */
            

            this.cambiarDatosUsuarioUnoaUno(sender,e,recorrido);

            recorrido.ShowDialog();
        }
        private void cambiarDatosUsuarioUnoaUno(object sender, EventArgs e, rocorridoUnoaUno recorrido)
        {
            claveUC dniUC = (claveUC)recorrido.Controls["dniUC"];
            datoUC nombreUC = (datoUC)recorrido.Controls["nombreUC"];
            datoUC apellidosUC = (datoUC)recorrido.Controls["apellidosUC"];
            datoUC numLibrosUC = (datoUC)recorrido.Controls["numLibrosUC"];

            Usuario u=(Usuario)recorrido.BindingNavigator.BindingSource.Current;
            string dni = "";
            string nombre = "";
            string apellidos = "";
            int numLibros = 0;
            if (u != null)
            {
                dni = u.Dni;
                nombre = u.Nombre;
                apellidos = u.Apellidos;               
                numLibros = MNBiblioteca.numLibrosPrestados(u.Dni);               
            }
            dniUC.ClaveTbUC.Text = dni;
            nombreUC.DatoTbUC.Text = nombre;
            apellidosUC.DatoTbUC.Text = apellidos;
            numLibrosUC.DatoTbUC.Text = numLibros.ToString();

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

        //=======================================================
        private void altaPrestamosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void bajaPrestamosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void listadoDePrestamosActivosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void recorridoUnoAUnoPrestamosTsmi_Click(object sender, EventArgs e)
        {

        }

        //=======================================================

        private void altaLibrosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void bajaLibrosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void insertarLibrosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void seleccionarLibrosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeLibrosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void recorridoUnoAUnoLibrosTsmi_Click(object sender, EventArgs e)
        {

        }

        private void altaEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }

        private void bajaEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }

        private void introducirEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }

        private void seleccionarEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }

        private void recorridoUnoAUnoEjemplaresTsmi_Click(object sender, EventArgs e)
        {

        }
    }
}
