using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EntradasArroz
    {
        [Key]
        public int EntradaArrozId { get; set; }
        public string NombresClientes { get; set; }
        public string TipoArroz { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public string Humedad { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string AutorizadaGuardaAlmacen { get; set; }
        public string Cargo { get; set; }
    }
}
