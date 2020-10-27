using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
   public class Ticket
    {
        public int Id { get; set; }
        public string Identificador_Fiscal { get; set; }
        public string Direccion { get; set; }
        public string Provincia { get; set; }
        public string Moneda { get; set; }
        public string Agradecimiento { get; set; }
        public string Pagina_Web { get; set; }
        public string Anuncio { get; set; }
        public string Datos_Fiscales { get; set; }
        public string Default { get; set; }
    }
}
