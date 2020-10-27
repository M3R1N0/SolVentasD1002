using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class Kardex
    {
        public int Id { get; set; }
        public int Id_Producto { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Caja { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public decimal Cantidad { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public decimal Costo_Unitario { get; set; }
        public decimal Habia { get; set; }
        public decimal Hay { get; set; }

        public string Producto { get; set; }
        public string Cajero { get; set; }
        public string Categoria_Producto { get; set; }
        public string Categoria_Presentacion { get; set; }
        public string Empresa { get; set; }

//        public Producto producto { get; set; }
    }
}
