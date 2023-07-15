using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public string Estado { get; set; }
        public decimal Cantidad { get; set; }
        public string UnidadMedida { get; set; }   
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal TotalPago { get; set; }
        public string Codigo { get; set; }            
        public string Stock { get; set; }
        public string Se_Vende_A { get; set; }
        public string UsaInventario { get; set; }
        public decimal Costo { get; set; }
        public decimal CantidaMostrada { get; set; }
        public int idTipoPresentacion { get; set; }

        public string Venta { get; set; }
    }

    public class DetalleVentaII
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public Int32 TipoVenta { get; set; }
        public bool EsDevuelto { get; set; }
        public bool UsaInventario { get; set; }
        public string Codigo { get; set; }

    }

}
