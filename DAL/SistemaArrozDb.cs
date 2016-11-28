using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;

namespace DAL
{
    public class SistemaArrozDb : DbContext
    {
        public SistemaArrozDb() : base("name = ConStr")
        {

        }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<DetalleFacturas> DetalleFacturas { get; set; }
        public virtual DbSet<EntradasArroz> EntradasArroz { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleFacturas>()
                .HasMany<Productos>(df => df.Productos)
                .WithMany(p => p.DetalleFacturas)
                .Map(dfp =>
                {
                    dfp.MapLeftKey("ProductoId");
                    dfp.MapRightKey("FacturaId");
                    dfp.ToTable("FacturaProductos");
                });
        }

    }
}
