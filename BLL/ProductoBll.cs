using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class ProductoBll
    {
        Productos producto = new Productos();
        public static bool Guardar(Productos p)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                {
                    db.Productos.Add(p);
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

        public static bool Eliminar(Productos p)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                Productos pd = db.Productos.Find(p);
                {
                    db.Productos.Remove(pd);
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

        public static Productos Buscar(int Id)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                {
                    return db.Productos.Find(Id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static List<Productos> GetLista()
        {
            List<Productos> lista = new List<Productos>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Productos.ToList();
            return lista;
        }

        public static List<Productos> GetListaId(int ProductosId)
        {
            List<Productos> lista = new List<Productos>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Productos.Where(p => p.ProductoId == ProductosId).ToList();
            return lista;
        }

        public static List<Productos> GetListaNombreProducto(string aux)
        {
            List<Productos> lista = new List<Productos>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Productos.Where(p => p.Nombre == aux).ToList();
            return lista;
        }

        public static List<Productos> GetListaDescripcionProducto(string aux)
        {
            List<Productos> lista = new List<Productos>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Productos.Where(p => p.Descripcion == aux).ToList();
            return lista;
        }

        public static List<Productos> GetListaCantidadProducto(int aux)
        {
            List<Productos> lista = new List<Productos>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Productos.Where(p => p.Cantidad == aux).ToList();
            return lista;
        }

        public static List<Productos> GetListaPrecioProducto(int aux)
        {
            List<Productos> lista = new List<Productos>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Productos.Where(p => p.Precio == aux).ToList();
            return lista;
        }

        public static List<Productos> GetListaFecha(DateTime Desde, DateTime Hasta)
        {
            List<Productos> lista = new List<Productos>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Productos.Where(p => p.FechaEntrega >= Desde && p.FechaEntrega <= Hasta).ToList();
            return lista;
        }

    }
}


