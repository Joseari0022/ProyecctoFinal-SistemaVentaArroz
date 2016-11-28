using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entidades;
using DAL;

namespace BLL
{
    public class UsuarioBll
    {
        Usuarios usuario = new Usuarios();
        public static bool Guardar(Usuarios u)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                {
                    db.Usuarios.Add(u);
                    db.SaveChanges();
                    db.Dispose();
                    return false;
                }
            }
            catch (Exception)
            {
                return true;
                throw;
            }
        }

        public static bool Eliminar(Usuarios u)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                Usuarios us = db.Usuarios.Find(u);
                {
                    db.Usuarios.Remove(us);
                    db.SaveChanges();
                    return false;
                }

            }
            catch (Exception)
            {
                return true;
                throw;
            }
        }

        public static Usuarios Buscar(int Id)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                {
                    return db.Usuarios.Find(Id);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static bool Eliminar(int v)
        {
            SistemaArrozDb db = new SistemaArrozDb();
            Usuarios us = db.Usuarios.Find(v);
            try
            {
                db.Usuarios.Remove(us);
                db.SaveChanges();
                return false;
            }
            catch (Exception e)
            {
                return true;
                throw e;
            }
        }

        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Usuarios.ToList();
            return lista;
        }

        public static List<Usuarios> GetListaId(int usuarioId)
        {
            List<Usuarios> lista = new List<Usuarios>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Usuarios.Where(p => p.UsuarioId == usuarioId).ToList();
            return lista;
        }

        public static List<Usuarios> GetListaNombreUsuario(string aux)
        {
            List<Usuarios> lista = new List<Usuarios>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Usuarios.Where(p => p.NombreUsuario == aux).ToList();
            return lista;
        }

        public static List<Usuarios> GetContrasena(string aux)
        {
            List<Usuarios> lista = new List<Usuarios>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Usuarios.Where(p => p.ContrasenaUsuario == aux).ToList();
            return lista;
        }
    }
}

