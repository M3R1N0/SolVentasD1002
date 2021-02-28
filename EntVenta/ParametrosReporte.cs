using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class ParametrosReporte
    {
        public int Id { get; set; }
        public byte[] LogoEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Provincia { get; set; }
        public string Agradecimiento { get; set; }
        public string Anuncio { get; set; }
        public string PaginaWeb { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal MontoTotal { get; set; }
        public string FormaPago { get; set; }
        public string Folio { get; set; }
        public string Cajero { get; set; }
        public string Cliente { get; set; }
        public string DireccionCliente { get; set; }
        public decimal TotalProducto { get; set; }
        public decimal Efectivo { get; set; }
        public decimal Cambio { get; set; }
        public string LetraNumero { get; set; }
        public string Comentarios { get; set; }
        public int IdDetalleVenta { get; set; }

        public List<DetalleVenta> lstDetalleVenta { get; set; }
    }
}
