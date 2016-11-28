using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class DetalleFacturaBll
    {
        DetalleFacturas factura = new DetalleFacturas();
        public static bool Guardar(DetalleFacturas f)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                db.DetalleFacturas.Add(f);
                var df = db.DetalleFacturas.Add(f);
                foreach(var produ in df.Productos)
                {
                    db.Entry(produ).State = EntityState.Unchanged;
                }
                db.DetalleFacturas.Add(f);
                db.SaveChanges();
                return false;
                db.Dispose();
            }
            catch (Exception e)
            {
                return true;
                throw e;
            }
        }

        public static void Eliminar(int id)
        {
            using (var db = new SistemaArrozDb())
            {
                var prd = (from d in db.Productos
                               where id == d.ProductoId
                               select d).FirstOrDefault();
                db.Productos.Remove(prd);

                var Detalle = (from d in db.DetalleFacturas
                               where id == d.FacturaId
                               select d).FirstOrDefault();
                db.DetalleFacturas.Remove(Detalle);
                db.SaveChanges();
            }
        }

        //public static void Eliminar(int v)
        //{
        //    SistemaArrozDb db = new SistemaArrozDb();
        //    DetalleFacturas fa = db.DetalleFacturas.Find(v);


        //    db.DetalleFacturas.Remove(fa);
        //    db.SaveChanges();
        //}

        public static DetalleFacturas Buscar(int Id)
        {
            SistemaArrozDb db = new SistemaArrozDb();
            return db.DetalleFacturas.Find(Id);
        }

        public static List<DetalleFacturas> GetLista()
        {
            List<DetalleFacturas> lista = new List<DetalleFacturas>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.DetalleFacturas.ToList();
            return lista;
        }

        public static List<DetalleFacturas> GetListaId(int facturaId)
        {
            List<DetalleFacturas> lista = new List<DetalleFacturas>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.DetalleFacturas.Where(p => p.FacturaId == facturaId).ToList();
            return lista;
        }

        public static List<DetalleFacturas> GetListaIdCliente(int clienteid)
        {
            List<DetalleFacturas> lista = new List<DetalleFacturas>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.DetalleFacturas.Where(p => p.ClienteId == clienteid).ToList();
            return lista;
        }
    }
}
