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
    public partial class gestionDeBiblioteca : Form
    {
        public gestionDeBiblioteca(String nombre)
        {
            InitializeComponent();
            this.Text = nombre+" - Gestión de biblioteca";

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
            datos datosUsuario = new datos();
            datosUsuario.Text = "Datos del usuario";
            claveDesplegable dniUC = new claveDesplegable(85, 50, "DNI:",)
            //claveUC dniUC = new claveUC(85, 50, "DNI:", introducir.Clave);
            datoUC nombreUC = new datoUC(85, 100, "Nombre:");
            datoUC apellidosUC = new datoUC(85, 150, "Apellidos:");
            nombreUC.Name = "nombreUC";
            apellidosUC.Name = "apellidosUC";
            nombreUC.DatoTbUC.ReadOnly = true;
            //nombreUC.DatoTbUC.Text = ModeloDeNegocio.MNBiblioteca.getNombreUsuario(introducir.Clave);
            apellidosUC.DatoTbUC.ReadOnly = true;
            //apellidosUC.DatoTbUC.Text = ModeloDeNegocio.MNBiblioteca.getApellidosUsuario(introducir.Clave);
            datosUsuario.Controls.Add(dniUC);
            datosUsuario.Controls.Add(nombreUC);
            datosUsuario.Controls.Add(apellidosUC);
            DialogResult usuario = datosUsuario.ShowDialog();

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
    }
}
