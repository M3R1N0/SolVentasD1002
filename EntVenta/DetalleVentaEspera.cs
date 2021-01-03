using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class DetalleVentaEspera
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int IdPresentacion { get; set; }
        public string Descripcion { get; set; }
        public string UnidadMedida { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }   
        public decimal TotalPago { get; set; }  
        public string Stock { get; set; }
        public string Codigo { get; set; }
        public string UsaInventario { get; set; }
    }
}
