using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class Venta
    {
        public int Id { get; set; }
        public int  IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public int IdCaja { get; set; }
        public DateTime FechaVenta { get; set; }
        public string Cliente { get; set; }
        public string Folio { get; set; }
        public string Comprobante { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal Saldo { get; set; }
        public string FormaPago { get; set; }
        public string EstadoPago { get; set; }
        public string FechaLiquidacion { get; set; }
        public string Accion { get; set; }
        public decimal TipoPago { get; set; }
        public string ReferenciaTarjeta { get; set; }

        public decimal Vuelto { get; set; }
        public decimal Efectivo { get; set; }
        public string Comentarios { get; set; }
        public decimal Recibo { get; set; }
        public string  EstadoVenta { get; set; }

    }
}
