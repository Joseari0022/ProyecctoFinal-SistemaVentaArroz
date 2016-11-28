using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string EdadCliente { get; set; }
        public string CedulaCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public DateTime Fecha { get; set; }
        
    }
}
