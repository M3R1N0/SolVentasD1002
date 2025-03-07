﻿using EntVenta;
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

    }
}
