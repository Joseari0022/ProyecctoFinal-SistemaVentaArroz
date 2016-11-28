using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class ClienteBLL
    {
        Clientes cliente = new Clientes();
        public static bool Guardar(Clientes c)
        {

            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                {
                    db.Clientes.Add(c);
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

        public static bool Eliminar(Clientes c)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                Clientes cl = db.Clientes.Find(c);
                {
                    db.Clientes.Remove(c);
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

        public static bool Eliminar(int v)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                Clientes c = db.Clientes.Find(v);
                {
                    db.Clientes.Remove(c);
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

        public static Clientes Buscar(Int32 Id)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                {
                    return db.Clientes.Find(Id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Clientes> GetListaNombreCliente(string aux)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Clientes.Where(p => p.NombreCliente == aux).ToList();
            return lista;
        }

        public static List<Clientes> GetListaId()
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Clientes.ToList();
            return lista;
        }

        public static List<Clientes> GetLista(int ClienteId)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Clientes.Where(p => p.ClienteId == ClienteId).ToList();
            return lista;
        }

        public static List<Clientes> GetListaApellido(string ApellioCliente)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Clientes.Where(p => p.ApellidoCliente == ApellioCliente).ToList();
            return lista;
        }

        public static List<Clientes> GetListaEdad(string EdadCliente)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Clientes.Where(p => p.EdadCliente == EdadCliente).ToList();
            return lista;
        }

        public static List<Clientes> GetListaCedula(string CedulaCliente)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Clientes.Where(p => p.CedulaCliente == CedulaCliente).ToList();
            return lista;
        }

        public static List<Clientes> GetListaDireccion(string DireccionCliente)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Clientes.Where(p => p.DireccionCliente == DireccionCliente).ToList();
            return lista;
        }

        public static List<Clientes> GetListaTelefono(string TelefonoCliente)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Clientes.Where(p => p.TelefonoCliente == TelefonoCliente).ToList();
            return lista;
        }

        public static List<Clientes> GetListaFecha(DateTime Desde, DateTime Hasta)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Clientes.Where(p => p.Fecha >= Desde && p.Fecha <= Hasta).ToList();
            return lista;
        }
    }
}
