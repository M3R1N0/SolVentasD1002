using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public byte [] Logo { get; set; }
        public string Impuesto { get; set; }
        public Decimal Porcentaje { get; set; }
        public string Moneda { get; set; }
        public string Usa_Impuestos { get; set; }
        public string Busqueda { get; set; }
        public string RutaBackup { get; set; }
        public string CorreoEnvio { get; set; }
        public string UltimoBackup { get; set; }
        public DateTime UltimaFechaBackup { get; set; }
        public int FrecuenciaBackup { get; set; }
        public string TipoEmpresa { get; set; }
        public string Pais { get; set; }
        public string Redondeo { get; set; }
        public string Estado { get; set; }
    }
}
