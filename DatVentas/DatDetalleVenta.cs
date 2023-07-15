using EntVenta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    sc.Parameters.AddWithValue("@idventa", dv.IdVenta);
                    sc.Parameters.AddWithValue("@tipoVenta", dv.Venta);

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

        public  bool Eliminar_DetalleVenta(int id)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("DELETE FROM tb_DetalleVenta WHERE Venta_Id =@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static void Eliminar_DetalleVenta_PorId(int idDetalle)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("DELETE FROM tb_DetalleVenta WHERE Id_DetalleVenta =@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idDetalle);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
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
                    SqlDataAdapter da = new SqlDataAdapter($"select * from tb_DetalleVenta WHERE Venta_Id={idVenta} AND ProductoDevuelto = 0 ", con);
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

        public void EditarDevolucion_DetalleVenta(DetalleVenta dv, int devuelto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand($"UPDATE tb_DetalleVenta SET Cantidad ={dv.Cantidad}, Total_Pagar={dv.TotalPago}, ProductoDevuelto = {devuelto} where Id_DetalleVenta ={dv.Id}", con);
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

        public static DataTable ObtenerDatos_Ticket(int idventa, string textoNumero)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_ReimprimirTicket]", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@idventa", idventa);
                    da.SelectCommand.Parameters.AddWithValue("@letranumero", textoNumero);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw ex;
                }
            }
        }

        public static DetalleVenta Obtener_DetalleVenta(int idDetalleVenta)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DetalleVenta v = new DetalleVenta();

                    SqlCommand cmd = new SqlCommand($"SELECT * FROM tb_DetalleVenta WHERE Id_DetalleVenta={idDetalleVenta}", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        v.Id = Convert.ToInt32(dr["Id_DetalleVenta"]);
                        v.IdVenta = Convert.ToInt32(dr["Venta_Id"]);
                        v.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
                        v.Precio = Convert.ToDecimal(dr["Precio"]);
                        v.TotalPago = Convert.ToDecimal(dr["Total_Pagar"]);
                    }
                    con.Close();
                    return v;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //---------------------------------------------------------------------
        public static List<DetalleVentaII> Listar_DetalleVenta(int idVenta)
        {
            try
            {
                var lstDetalle = new List<DetalleVentaII>();
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("sp_Listar_DetalleVenta", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idVenta", idVenta);
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DetalleVentaII dv = new DetalleVentaII();
                            dv.Id = reader.GetInt32(0);
                            dv.IdVenta = reader.GetInt32(1);
                            dv.IdProducto = reader.GetInt32(2);
                            dv.Cantidad = reader.GetDecimal(3);
                            dv.UnidadMedida = reader.GetString(4);
                            dv.Descripcion = reader.GetString(5);
                            dv.PrecioUnitario = reader.GetDecimal(6);
                            dv.Precio = reader.GetDecimal(7);
                            dv.Importe = reader.GetDecimal(8);
                            dv.TipoVenta = reader.GetInt32(9);
                            dv.EsDevuelto = reader.GetBoolean(10);
                            dv.UsaInventario = reader.GetBoolean(11);
                            dv.Codigo = reader.GetString(12);

                            lstDetalle.Add(dv);
                        }
                    }
                    con.Close();
                }
                return lstDetalle;
            }
            catch (Exception ex)
            {
                return new List<DetalleVentaII>();
            }
        }

        public static void ActualizarPrecio_DetalleVenta(DetalleVentaII dv, TIPO_VENTA tipoVenta)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();

                    using (var cmd = new SqlCommand("ActualizarPrecioCantidad_DetalleVenta", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", dv.Id);
                        cmd.Parameters.AddWithValue("@cantidad", dv.Cantidad);
                        cmd.Parameters.AddWithValue("@precio", dv.Precio);
                        cmd.Parameters.AddWithValue("@totalpagar", dv.Importe);
                        cmd.Parameters.AddWithValue("@productoid", dv.IdProducto);
                        cmd.Parameters.AddWithValue("@tipoVenta", tipoVenta.ToString());
                        cmd.Parameters.AddWithValue("@UnidadMedida", dv.UnidadMedida);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static void ActualizarPrecio(DetalleVentaII dv, TIPO_VENTA tipoVenta)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();

                    using (var cmd = new SqlCommand("UPDATE tb_DetalleVenta SET Precio = @Precio , Total_Pagar=@importe, TipoVenta=@tipoVenta WHERE Id_DetalleVenta=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", dv.Id);
                        cmd.Parameters.AddWithValue("@Precio", dv.Precio);
                        cmd.Parameters.AddWithValue("@importe", dv.Importe);
                        cmd.Parameters.AddWithValue("@tipoVenta", tipoVenta.ToString());
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static decimal ObtenerCantidadDV(int id)
        {
            try
            {
                decimal cantidad = 0;
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("SELECT Cantidad FROM tb_DetalleVenta WHERE Id_DetalleVenta=@id",con))
                    {
                        cmd.Parameters.AddWithValue("@id",id);

                       cantidad = Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                    con.Close();
                }
                return cantidad;
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
