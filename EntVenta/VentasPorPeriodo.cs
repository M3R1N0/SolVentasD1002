using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class VentasPorPeriodo
    {
        public string Fecha { get; set; }
        public decimal Total { get; set; }
    }
    public class DashBoard
    {
        public int TotalClientes { get; set; }
        public int TotalProveedores { get; set; }
        public int TotalUsuarios { get; set; }
        public int VentasRealizadas { get; set; }
        public decimal TotalCreditos { get; set; }
        public decimal TotalActivoNeto { get; set; }
        public decimal TotalVentas { get; set; }
        public string Nombre { get; set; }
        public List<VentasPorPeriodo> lstVentasPorPeriodo { get; set; }
    }
}
