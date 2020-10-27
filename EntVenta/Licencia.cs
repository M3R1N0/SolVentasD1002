using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
   public class Licencia
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string FechaVencimiento { get; set; }
        public string Estado { get; set; }
        public string FechaActivacion { get; set; }
    }
}
