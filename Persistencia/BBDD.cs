using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class BBDD
    {
        private static Table<ClaveLibro,  LibroDato> tablaLibro = new Table<ClaveLibro, LibroDato>();
        private static Table<ClaveUsuario, UsuarioDato> tablaUsuario = new Table<ClaveUsuario, UsuarioDato>();
        private static Table<ClaveEjemplar, EjemplarDato> tablaEjemplar = new Table<ClaveEjemplar, EjemplarDato>();
        private static Table<ClavePrestamo, PrestamoDato> tablaPrestamo = new Table<ClavePrestamo, PrestamoDato>();
        private static Table<ClavePrestamoEjemplar, PrestamoEjemplarDato> tablaPrestamoEjemplar = new Table<ClavePrestamoEjemplar, PrestamoEjemplarDato>();

        private BBDD() { }

        public static Table<ClaveLibro, LibroDato> TablaLibro { get { return tablaLibro; } }

        public static Table<ClaveUsuario, UsuarioDato> TablaUsuario { get { return tablaUsuario; } }

        public static Table<ClaveEjemplar, EjemplarDato> TablaEjemplar { get { return tablaEjemplar; } }

        public static Table<ClavePrestamo, PrestamoDato> TablaPrestamo { get { return tablaPrestamo; } }

        public static Table<ClavePrestamoEjemplar, PrestamoEjemplarDato> TablaPrestamoEjemplar { get { return tablaPrestamoEjemplar; } }

        public static bool Create<T, U>(U u) where U : Entity<T> where T : IEquatable<T>
        {
            if (u != null)
            {
                if (u is LibroDato)
                {
                    if (!tablaLibro.Contains((u as LibroDato).Id))
                    {
                        tablaLibro.Add(u as LibroDato);
                        return true;
                    }
                }
                if (u is UsuarioDato)
                {
                    if (!tablaUsuario.Contains((u as UsuarioDato).Id))
                    {
                        tablaUsuario.Add(u as UsuarioDato);
                        return true;
                    }
                }
                if (u is PrestamoDato)
                {
                    //TERMINAR
                    //
                    //IMPORTANTE
                    if (!tablaPrestamo.Contains((u as PrestamoDato).Id) && tablaUsuario.Contains(new ClaveUsuario((u as PrestamoDato).DniUsuario)))
                    {
                        PrestamoDato pd = u as PrestamoDato;
                        Prestamo p = Transformador.PrestamoDatoAPrestamo(pd);
                        //foreach (Ejemplar e in p.EjemPrestados)
                        //{
                        //    BBDD.TablaPrestamoEjemplar.Add(Transformador.PrestamoAPrestamoEjemplarDato(p, e));
                        //}
                        tablaPrestamo.Add(pd);
                        return true;
                    }
                }
                if (u is EjemplarDato)
                {
                    if (!tablaEjemplar.Contains((u as EjemplarDato).Id) && tablaLibro.Contains(new ClaveLibro((u as EjemplarDato).IsbnLibro)))
                    {
                        tablaEjemplar.Add(u as EjemplarDato);
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>El libro con ISBN "isbn", o en caso de no existir en la tabla devuelve nulo</returns>
        //public static Object Read(Clave c)
        //{
        //    if (c != null)
        //    {
        //        if (c is ClaveLibro && tablaLibro.Contains(c as ClaveLibro))
        //        {
        //            return tablaLibro[c as ClaveLibro];
        //        }
        //        if (c is ClaveUsuario && tablaUsuario.Contains(c as ClaveUsuario))
        //        {
        //            return tablaUsuario[c as ClaveUsuario];
        //        }
        //        if (c is ClaveEjemplar && tablaEjemplar.Contains(c as ClaveEjemplar))
        //        {
        //            return tablaEjemplar[c as ClaveEjemplar];
        //        }
        //        if (c is ClavePrestamo && tablaPrestamo.Contains(c as ClavePrestamo))
        //        {
        //            return tablaPrestamo[c as ClavePrestamo];
        //        }
        //        if (c is ClavePrestamoEjemplar && tablaPrestamoEjemplar.Contains(c as ClavePrestamoEjemplar))
        //        {
        //            return tablaPrestamoEjemplar[c as ClavePrestamoEjemplar];
        //        }
        //    }
        //    return null;
        //}

        public static U Read<T, U>(T t) where U : Entity<T> where T : IEquatable<T>
        {
            if (t != null)
            {
                if (t is ClaveLibro && tablaLibro.Contains(t as ClaveLibro))
                {
                    return tablaLibro[t as ClaveLibro] as U;
                }
                if (t is ClaveUsuario && tablaUsuario.Contains(t as ClaveUsuario))
                {
                    return tablaUsuario[t as ClaveUsuario] as U;
                }
                if (t is ClaveEjemplar && tablaEjemplar.Contains(t as ClaveEjemplar))
                {
                    return tablaEjemplar[t as ClaveEjemplar] as U;
                }
                if (t is ClavePrestamo && tablaPrestamo.Contains(t as ClavePrestamo))
                {
                    return tablaPrestamo[t as ClavePrestamo] as U;
                }
                if (t is ClavePrestamoEjemplar && tablaPrestamoEjemplar.Contains(t as ClavePrestamoEjemplar))
                {
                    return tablaPrestamoEjemplar[t as ClavePrestamoEjemplar] as U;
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="o">Tiene que ser parte del sistema de persistencia</param>
        /// <returns>verdadero si ha modificado el objeto introducido o falso si no lo introduce</returns>
        public static bool Update<T, U>(U u) where U: Entity<T> where T : IEquatable<T>
        {
            if (u!=null)
            {
                if (u is LibroDato && tablaLibro.Remove(new ClaveLibro((u as LibroDato).Isbn)))
                {
                    BBDD.Create<ClaveLibro, LibroDato>(u as LibroDato);
                    return true;
                }
                if (u is UsuarioDato && tablaUsuario.Remove(new ClaveUsuario((u as UsuarioDato).Dni)))
                {
                    BBDD.Create<ClaveUsuario, UsuarioDato>(u as UsuarioDato);
                    return true;
                }
                if (u is EjemplarDato && tablaEjemplar.Remove(new ClaveEjemplar((u as EjemplarDato).Codigo)))
                {
                    BBDD.Create<ClaveEjemplar, EjemplarDato>(u as EjemplarDato);
                    return true;
                }
                if (u is PrestamoDato && tablaPrestamo.Remove(new ClavePrestamo((u as PrestamoDato).Fecha, (u as PrestamoDato).DniUsuario)))
                {
                    BBDD.Create<ClavePrestamo, PrestamoDato>(u as PrestamoDato);
                    return true;
                }
            }
            return false;
        }

        //public static bool Delete(Clave t)
        //{
        //    if (t != null)
        //    {
        //        if (t is ClaveLibro)
        //        {
        //            return tablaLibro.Remove(t as ClaveLibro);
        //        }
        //        if (t is ClaveUsuario)
        //        {
        //            return tablaUsuario.Remove(t as ClaveUsuario);
        //        }
        //        if (t is ClaveEjemplar)
        //        {
        //            return tablaEjemplar.Remove(t as ClaveEjemplar);
        //        }
        //        if (t is ClavePrestamo)
        //        {
        //            foreach(PrestamoEjemplarDato ped in tablaPrestamoEjemplar)
        //            {
        //                if (ped.Id.Prestamo.Equals(t as ClavePrestamo))
        //                {
        //                    tablaPrestamoEjemplar.Remove(ped.Id);
        //                }
        //            }
        //            return tablaPrestamo.Remove(t as ClavePrestamo);
        //        }
        //    }
        //    return false;
        //}
        
        //IMPORTANTE: todos los elementos correspondientes en otras tablas.
        public static bool Delete<T, U>(T t) where U: Entity<T> where T : IEquatable<T>
        {
            if (t != null)
            {
                if (t is ClaveLibro)
                {
                    return tablaLibro.Remove(t as ClaveLibro);
                }
                if (t is ClaveUsuario)
                {
                    return tablaUsuario.Remove(t as ClaveUsuario);
                }
                if (t is ClaveEjemplar)
                {
                    return tablaEjemplar.Remove(t as ClaveEjemplar);
                }
                if (t is ClavePrestamo)
                {
                    foreach (PrestamoEjemplarDato ped in tablaPrestamoEjemplar)
                    {
                        if (ped.Id.Prestamo.Equals(t as ClavePrestamo))
                        {
                            tablaPrestamoEjemplar.Remove(ped.Id);
                        }
                    }
                    return tablaPrestamo.Remove(t as ClavePrestamo);
                }
            }
            return false;
        }
    }
}
