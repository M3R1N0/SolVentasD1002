using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class VentaEspera
    {
        public int Id { get; set; }
        public int  IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public int IdCaja { get; set; }
        public DateTime FechaVenta { get; set; }
        public string Referencia { get; set; }
        public decimal MontoTotal { get; set; }
        
    }
}
