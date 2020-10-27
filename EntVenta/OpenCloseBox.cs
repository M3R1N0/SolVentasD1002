using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
   public class OpenCloseBox
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaCierre { get; set; }
        public decimal Ingresos { get; set; }
        public decimal Egresos { get; set; }
        public decimal Saldo { get; set; }
        public User UsuarioId { get; set; }
        public decimal TotalCalculado  { get; set; }
        public decimal TotalReal { get; set; }
        public bool Estado { get; set; }
        public decimal Diferencia { get; set; }
        public Box CadaId { get; set; }
    }
}
