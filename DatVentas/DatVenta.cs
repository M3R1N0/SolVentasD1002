using EntVenta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVentas
{
   public class DatVenta
    {
        public int InsertarVenta(Venta v)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("[sp_insertarVenta]", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@idcliente", v.IdCliente);
                    sc.Parameters.AddWithValue("@idusuario", v.IdUsuario);
                    sc.Parameters.AddWithValue("@idcaja", v.IdCaja);
                    sc.Parameters.AddWithValue("@fechaventa", v.FechaVenta);
                    sc.Parameters.AddWithValue("@folio", v.Folio);
                    sc.Parameters.AddWithValue("@montototal", v.MontoTotal);
                    sc.Parameters.AddWithValue("@formapago", v.FormaPago);
                    sc.Parameters.AddWithValue("@estadopago", v.EstadoPago);
                    sc.Parameters.AddWithValue("@comprobante", v.Comprobante);
                    sc.Parameters.AddWithValue("@fechaliquidacion", v.FechaLiquidacion);
                    sc.Parameters.AddWithValue("@accion", v.Accion);
                    sc.Parameters.AddWithValue("@saldo", v.Saldo);
                    sc.Parameters.AddWithValue("@tipopago", v.TipoPago);
                    sc.Parameters.AddWithValue("@referenciatarjeta", v.ReferenciaTarjeta);

                    resultado = sc.ExecuteNonQuery();
                    conn.Close();
                    return resultado;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw ex;
                }
            }
        }
    }
}
