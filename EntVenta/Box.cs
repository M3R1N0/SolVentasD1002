using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
   public class Box
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Tema { get; set; }
        public string SerialPC { get; set; }
        public string ImpresoraTicket { get; set; }
        public string ImpresoraA4 { get; set; }
        public string Tipo { get; set; }
        public bool Estado { get; set; }
    }
}
