using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class EntradaProductoVM
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal GananciaMayoreo { get; set; }
        public decimal PrecioMenudeo { get; set; }
        public decimal GananciaMenudeo { get; set; }
        public decimal GananciaMayoreoM { get; set; }
        public decimal GananciaMayoreoU { get; set; }
        public decimal TotalIngresado { get; set; }
        public DateTime Caducidad { get; set; }
        public string Estatus { get; set; }
    }
}
