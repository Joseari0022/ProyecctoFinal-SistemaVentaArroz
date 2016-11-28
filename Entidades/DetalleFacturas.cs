using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleFacturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaVenta { get; set; }

        public virtual List<Productos> Productos { get; set; }
        public DetalleFacturas()
        {
            this.Productos = new List<Entidades.Productos>();
        }

        public DetalleFacturas(int facturaid, int clienteid, DateTime fechaventa)
        {
            this.FacturaId = facturaid;
            this.ClienteId = clienteid;
            this.FechaVenta = fechaventa;
            this.Productos = new List<Productos>();
        }
    }
}
