using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class ObjetoGenerico
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public decimal TotalCredito { get; set; }
        public decimal TotalContado { get; set; }
        public decimal TotalBonificacion { get; set; }
        public decimal CajaInicial { get; set; }
        public decimal Saldo { get; set; }
        public int NumCredito { get; set; }
        public int NumContado { get; set; }
        public int NumCancelada { get; set; }
        public string FormaPago { get; set; }
        public string NombreCaja { get; set; }
        public string EstadoPago { get; set; }
        public string Accion { get; set; }
        public DateTime FechaVenta { get; set; }

    }
}
