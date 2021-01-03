using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class IngresosGastos
    {
        public int id { get; set; }
        public int idCaja { get; set; }
        public int idConcepto { get; set; }
        public DateTime Fecha { get; set; }
        public string NoComprobante { get; set; }
        public string TipoComprobante { get; set; }
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }

    }
}
