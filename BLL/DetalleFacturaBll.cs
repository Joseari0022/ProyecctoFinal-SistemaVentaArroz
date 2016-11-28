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
        public static void Guardar(DetalleFacturas f)
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
                db.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Eliminar(DetalleFacturas f)
        {
            SistemaArrozDb db = new SistemaArrozDb();
            DetalleFacturas fa = db.DetalleFacturas.Find(f);
            db.DetalleFacturas.Remove(fa);
            db.SaveChanges();
        }

        public static void Eliminar(int v)
        {
            SistemaArrozDb db = new SistemaArrozDb();
            DetalleFacturas fa = db.DetalleFacturas.Find(v);


            db.DetalleFacturas.Remove(fa);
            db.SaveChanges();
        }

        public static DetalleFacturas Buscar(int Id)
        {
            SistemaArrozDb db = new SistemaArrozDb();
            return db.DetalleFacturas.Find(Id);
        }
    }
}
