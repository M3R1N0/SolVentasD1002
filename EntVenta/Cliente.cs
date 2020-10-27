using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
   public class Cliente
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string Ruc { get; set; }
        public string Telefono { get; set; }
        public string Clientes { get; set; }
        public string Proveedor { get; set; }
        public decimal Saldo { get; set; }
        public bool Estado { get; set; }
    }
}
