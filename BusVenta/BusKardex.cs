using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusVenta
{
   public class BusKardex
    {
        public List<Kardex> ListarMovimiento_kardex(int buscar, string opcion)
        {
            DataTable dt = new DatKardex().BuscarProducto_Kardex(buscar, opcion);
            List<Kardex> lsProductosKardex = new List<Kardex>();

            foreach (DataRow dr in dt.Rows)
            {
                Kardex k = new Kardex();
                k.Fecha = Convert.ToDateTime(dr["Fecha"]);
                k.Producto = dr["Descripcion"].ToString();
                k.Motivo= dr["Motivo"].ToString();
                k.Habia = Convert.ToDecimal(dr["Habia"]);
                k.Tipo = dr["Tipo"].ToString();
                k.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
                k.Hay = Convert.ToDecimal(dr["Hay"]);
                k.Cajero = dr["Cajero"].ToString();
                k.Categoria_Producto = dr["Categoria_Producto"].ToString();
                k.Categoria_Presentacion = dr["Categoria_Presentacion"].ToString();
                k.Empresa = dr["Empresa"].ToString();
                lsProductosKardex.Add(k);
            }
            return lsProductosKardex;
        }
    }
}
