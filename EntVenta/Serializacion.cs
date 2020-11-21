using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class Serializacion
    {
        public int Id { get; set; }
        public string Serie { get; set; }
        public string Cantidad_Numero { get; set; }
        public string NumeroFin { get; set; }
        public string Destino { get; set; }
        public string Tipo_Documento { get; set; }
        public string Por_Defecto { get; set; }

        public string  SerieCompleta { get; set; }
    }
}
