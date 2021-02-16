using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class ParametrosReporte
    {
        public byte[] LogoEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Agradecimiento { get; set; }
        public string Anuncio { get; set; }
        public string PaginaWeb { get; set; }
        public string FormaPago { get; set; }
        public string Folio { get; set; }
        public string Cajero { get; set; }
        public string Cliente { get; set; }
        public string DireccionCliente { get; set; }
        public decimal Total { get; set; }
        public decimal Efectivo { get; set; }
        public decimal Cambio { get; set; }
        public List<DetalleVenta> lstDetalleVenta { get; set; }


    }
}
