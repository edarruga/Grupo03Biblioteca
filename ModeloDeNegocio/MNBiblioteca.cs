﻿using ModeloDeDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeNegocio
{
    public static class MNBiblioteca
    {
        public static string login(string nombre,string contrasena)
        {
            return GestorBD.Login(nombre,contrasena);
        }
        public static bool existeUsuario(string dni)
        {
            return GestorBD.GetUsuario(dni)!=null;
        }
        public static string getNombreUsuario(string dni)
        {
            return GestorBD.GetUsuario(dni).Nombre;
        }
        public static string getApellidosUsuario(string dni)
        {
            return GestorBD.GetUsuario(dni).Apellidos;
        }
        public static bool altaUsuario(string dni,string nombre,string apellidos)
        {
            return GestorBD.AltaUsuario(new Usuario(dni,nombre,apellidos));
        }
        public static bool bajaUsuario(string dni)
        {
            return GestorBD.BajaUsuario(dni);
        }
        public static List<Usuario> listaUsuarios()
        {
            return GestorBD.ListaUsuarios();
        }
        public static List<string> listaDNIs()
        {
            List<string> lista = new List<string>();
            List<Usuario> usuarios = MNBiblioteca.listaUsuarios();
            foreach(Usuario usuario in usuarios)
            {
                lista.Add(usuario.Dni);
            }
            return lista;
        }
        public static int numLibrosPrestados(string dni)
        {
            
            return GestorBD.NumLibrosPrestados(dni);
        }
        public static bool existeLibro(string isbn)
        {
            return GestorBD.GetLibro(isbn) != null;
        }
        public static List<string> listaEjemplares(string isbn)
        {
            List<string> codigos = new List<string>();
            List<Ejemplar> ejemplares = MNAdquisiciones.listaEjemplares(isbn);
            foreach (Ejemplar ejemplar in ejemplares)
            {
                codigos.Add(ejemplar.Codigo);
            }
            return codigos;
        }
        public static bool ejemplarDisponible(string codigo)
        {
            return GestorBD.EjemplarDisponible(codigo);
        }
        public static Ejemplar getEjemplar(string codigo)
        {
            return GestorBD.GetEjemplar(codigo);
        }
        public static List<Ejemplar> listaEjemplares(List<string> codigos)
        {
            List<Ejemplar> ejemplares=new List<Ejemplar>();
            foreach(string codigo in codigos)
            {
                ejemplares.Add(getEjemplar(codigo));
            }
            return ejemplares;
        }
        
        public static bool darEjemplarPrestado(string codigo)
        {
            return GestorBD.DarEjemplarPrestado(codigo);
        }
        public static bool devolverEjemplarPrestado(string codigo)
        {
            return GestorBD.DevolverEjemplarPrestado(codigo);
        }
    }
}
