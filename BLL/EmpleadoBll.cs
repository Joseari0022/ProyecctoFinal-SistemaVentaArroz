using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class EmpleadoBll
    {
        Empleados empleado = new Empleados();
        public static bool Guardar(Empleados em)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                {
                    db.Empleados.Add(em);
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

        public static bool Eliminar(Empleados e)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                Empleados em = db.Empleados.Find(e);
                {
                    db.Empleados.Remove(e);
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
                Empleados e = db.Empleados.Find(v);
                {
                    db.Empleados.Remove(e);
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

        public static Empleados Buscar(int Id)
        {
            try
            {
                SistemaArrozDb db = new SistemaArrozDb();
                {
                    return db.Empleados.Find(Id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Empleados> GetLista()
        {
            List<Empleados> lista = new List<Empleados>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Empleados.ToList();
            return lista;
        }

        public static List<Empleados> GetListaId(int empleadoId)
        {
            List<Empleados> lista = new List<Empleados>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Empleados.Where(p => p.EmpleadoId == empleadoId).ToList();
            return lista;
        }

        public static List<Empleados> GetListaNombreEmpleado(string Nombreem)
        {
            List<Empleados> lista = new List<Empleados>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Empleados.Where(p => p.Nombres == Nombreem).ToList();
            return lista;
        }

        public static List<Empleados> GetListaApellido(string Apellido)
        {
            List<Empleados> lista = new List<Empleados>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Empleados.Where(p => p.Apellidos == Apellido).ToList();
            return lista;
        }

        public static List<Empleados> GetListaCedula(string cedula)
        {
            List<Empleados> lista = new List<Empleados>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Empleados.Where(p => p.Cedula == cedula).ToList();
            return lista;
        }

        public static List<Empleados> GetListaDireccion(string direccion)
        {
            List<Empleados> lista = new List<Empleados>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Empleados.Where(p => p.Direccion == direccion).ToList();
            return lista;
        }

        public static List<Empleados> GetListaTelefono(string telefono)
        {
            List<Empleados> lista = new List<Empleados>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Empleados.Where(p => p.Telefono == telefono).ToList();
            return lista;
        }

        public static List<Empleados> GetListaFechaEntrada(DateTime Desde, DateTime Hasta)
        {
            List<Empleados> lista = new List<Empleados>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Empleados.Where(p => p.FechaEntrada >= Desde && p.FechaEntrada <= Hasta).ToList();
            return lista;
        }

        public static List<Empleados> GetListaCargo(string Cargo)
        {
            List<Empleados> lista = new List<Empleados>();
            SistemaArrozDb db = new SistemaArrozDb();
            lista = db.Empleados.Where(p => p.Cargo == Cargo).ToList();
            return lista;
        }
    }
}
