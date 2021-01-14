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
   public class DatDetalleVenta
    {
        public int Insertar_DetalleVenta(DetalleVenta dv)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("[sp_detalle_venta]", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@productoid", dv.IdProducto);
                    sc.Parameters.AddWithValue("@cantidad", dv.Cantidad);
                    sc.Parameters.AddWithValue("@precio", dv.Precio);
                    sc.Parameters.AddWithValue("@totalpagar", dv.TotalPago);
                    sc.Parameters.AddWithValue("@unidadmedida", dv.UnidadMedida);
                    sc.Parameters.AddWithValue("@cantidadmostrada", dv.CantidaMostrada);
                    sc.Parameters.AddWithValue("@estado",dv.Estado);
                    sc.Parameters.AddWithValue("@descripcion", dv.Descripcion);
                    sc.Parameters.AddWithValue("@codigo", dv.Codigo);
                    sc.Parameters.AddWithValue("@stock", dv.Stock);
                    sc.Parameters.AddWithValue("@sevendea", dv.Se_Vende_A);
                    sc.Parameters.AddWithValue("@usainventario", dv.UsaInventario);
                    sc.Parameters.AddWithValue("@costo", dv.Costo);

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

        public int Insertar_DetalleVentaEspera(DetalleVentaEspera dv)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("[sp_Insertar_detalleVentaEspera]", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@productoid", dv.IdProducto);
                    sc.Parameters.AddWithValue("@idpresentacion", dv.IdPresentacion);
                    sc.Parameters.AddWithValue("@descripcion", dv.Descripcion);
                    sc.Parameters.AddWithValue("@unidadmedida", dv.UnidadMedida);
                    sc.Parameters.AddWithValue("@cantidad", dv.Cantidad);
                    sc.Parameters.AddWithValue("@precio", dv.Precio);
                    sc.Parameters.AddWithValue("@totalpagar", dv.TotalPago);
                    sc.Parameters.AddWithValue("@stock", dv.Stock);
                    sc.Parameters.AddWithValue("@usainventario", dv.UsaInventario);

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

        public DataTable ObtenerDetalle_VentaEnEspera(int idVenta)
        {
            using (SqlConnection con = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(@"select * from tb_DetalleVentaEspera WHERE VentaId=" + idVenta, con);
                    da.Fill(dt);

                    return dt;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public int Eliminar_DetalleVentaEspera(int id)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("DELETE FROM tb_DetalleVentaEspera WHERE VentaId=" + id, conn);
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

        public DataTable ObtenerDetalle_VentaPendiente(int idVenta)
        {
            using (SqlConnection con = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(@"select * from tb_DetalleVenta WHERE Venta_Id=" + idVenta, con);
                    da.Fill(dt);

                    return dt;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable ObtenerDatos_DetalleVenta(int idVenta)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter($"sp_ObtenerDatos_DetalleVenta {idVenta}", con);
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditarDevolucion_DetalleVenta(int idVenta)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand($"UPDATE tb_DetalleVenta SET ProductoDevuelto = 1 where Id_DetalleVenta ={idVenta}", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Productos_MasVendidos(ref DataTable dtDatos)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_ProductoMasVendidos", con);
                    da.Fill(dtDatos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
