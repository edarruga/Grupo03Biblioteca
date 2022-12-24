﻿using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario("18082353Y", "David", "Armas");
            Usuario u2 = new Usuario("18082353Y", "David", "Armas");
            UsuarioDato ud = Transformador.UsuarioAUsuarioDato(u);
            UsuarioDato ud2 = Transformador.UsuarioAUsuarioDato(u2);
            BBDD.Create<ClaveUsuario, UsuarioDato>(ud);

            List<UsuarioDato> usuarioDatos = new List<UsuarioDato>();
            usuarioDatos.Add(ud);
            Console.WriteLine(usuarioDatos.Contains(ud2));

            Console.WriteLine(ud.Id.Equals(ud2.Id));
            Console.WriteLine(ud.Equals(ud2));
            Console.WriteLine(BBDD.TablaUsuario.Contains(ud2.Id));
            UsuarioDato ud3 = BBDD.Read<ClaveUsuario, UsuarioDato>(new ClaveUsuario("18082353Y"));
            Console.ReadLine();
        }
    }
}
