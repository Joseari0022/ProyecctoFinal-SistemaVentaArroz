using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class EntradaArrozBll
    {
        EntradasArroz ea = new EntradasArroz();
        public static bool Guardar(EntradasArroz eta)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                {
                    db.EntradasArroz.Add(eta);
                    db.SaveChanges();
                    db.Dispose();
                    return false;
                }
            }
            catch (Exception e)
            {
                return true;
                throw e;
            }
        }

        public static bool Eliminar(EntradasArroz et)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                EntradasArroz cpa = db.EntradasArroz.Find(et);
                {
                    db.EntradasArroz.Remove(et);
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
                EntradasArroz eta = db.EntradasArroz.Find(v);
                {
                    db.EntradasArroz.Remove(eta);
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

        public static EntradasArroz Buscar(int Id)
        {
            SistemaArrozDb db = new SistemaArrozDb();
            return db.EntradasArroz.Find(Id);
        }

        public static List<EntradasArroz> GetLista()
        {
            List<EntradasArroz> lista = new List<EntradasArroz>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.EntradasArroz.ToList();
            return lista;
        }

        public static List<EntradasArroz> GetListaId(int EntradaId)
        {
            List<EntradasArroz> lista = new List<EntradasArroz>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.EntradasArroz.Where(p => p.EntradaArrozId == EntradaId).ToList();
            return lista;
        }

        public static List<EntradasArroz> GetListaNombreCliente(string Nombrecl)
        {
            List<EntradasArroz> lista = new List<EntradasArroz>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.EntradasArroz.Where(p => p.NombresClientes == Nombrecl).ToList();
            return lista;
        }

        public static List<EntradasArroz> GetListaTipoArroz(string TipoArroz)
        {
            List<EntradasArroz> lista = new List<EntradasArroz>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.EntradasArroz.Where(p => p.TipoArroz == TipoArroz).ToList();
            return lista;
        }

        public static List<EntradasArroz> GetListaCantidad(int cantidad)
        {
            List<EntradasArroz> lista = new List<EntradasArroz>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.EntradasArroz.Where(p => p.Cantidad == cantidad).ToList();
            return lista;
        }

        public static List<EntradasArroz> GetListaPrecio(int precio)
        {
            List<EntradasArroz> lista = new List<EntradasArroz>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.EntradasArroz.Where(p => p.Precio == precio).ToList();
            return lista;
        }

        public static List<EntradasArroz> GetListaHumedad(string humedad)
        {
            List<EntradasArroz> lista = new List<EntradasArroz>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.EntradasArroz.Where(p => p.Humedad == humedad).ToList();
            return lista;
        }

        public static List<EntradasArroz> GetListaFechaEntrada(DateTime Desde, DateTime Hasta)
        {
            List<EntradasArroz> lista = new List<EntradasArroz>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.EntradasArroz.Where(p => p.FechaEntrada >= Desde && p.FechaEntrada <= Hasta).ToList();
            return lista;
        }

        public static List<EntradasArroz> GetListaGuardaAlmacen(string GuardaAlmacen)
        {
            List<EntradasArroz> lista = new List<EntradasArroz>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.EntradasArroz.Where(p => p.AutorizadaGuardaAlmacen == GuardaAlmacen).ToList();
            return lista;
        }

        public static List<EntradasArroz> GetListaCargo(string cargo)
        {
            List<EntradasArroz> lista = new List<EntradasArroz>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.EntradasArroz.Where(p => p.Cargo == cargo).ToList();
            return lista;
        }
    }
}
