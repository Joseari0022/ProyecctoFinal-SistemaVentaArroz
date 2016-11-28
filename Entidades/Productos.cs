using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Productos
    { 
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int  Cantidad { get; set; }
        public DateTime FechaEntrega { get; set; }
        
        public virtual List<DetalleFacturas> DetalleFacturas { get; set; }
        public Productos()
        {
            this.DetalleFacturas = new List<DetalleFacturas>();
        }

        public Productos(int productoid,string nombre)
        {
            this.ProductoId = productoid;
            this.Nombre = nombre;
            this.DetalleFacturas = new List<DetalleFacturas>();
        }
    }
}
