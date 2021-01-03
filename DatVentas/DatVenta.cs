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
                    sc.Parameters.AddWithValue("@vuelto", v.Vuelto);
                    sc.Parameters.AddWithValue("@efectivo", v.Efectivo);

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

        public DataTable ObtenerComrpobante()
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_Mostrar_TicketImpreso]", conn);
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

        public DataTable Obtener_VentasEnEspera()
        {
            using (SqlConnection con = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM tb_VentaEnEspera", con);
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                }
            }
        }

        public int InsertarVentaEspera(VentaEspera ve)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("[sp_insertarVentaEspera]", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@idcliente", ve.IdCliente);
                    sc.Parameters.AddWithValue("@idusuario", ve.IdUsuario);
                    sc.Parameters.AddWithValue("@idcaja", ve.IdCaja);
                    sc.Parameters.AddWithValue("@fechaventa", ve.FechaVenta);
                    sc.Parameters.AddWithValue("@referencia", ve.Referencia);
                    sc.Parameters.AddWithValue("@montototal", ve.MontoTotal);


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

        public int EliminarVentaEspera(int id)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("DELETE FROM tb_VentaEnEspera WHERE Id=" + id, conn);


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

        public DataTable ObtenerVenta_Total(DateTime cierre, int idusuario, int idcaja)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                   
                    
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("sp_ObtenerDatos_VentasTotales", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@cierre", cierre);
                    da.SelectCommand.Parameters.AddWithValue("@idusuario", idusuario);
                    da.SelectCommand.Parameters.AddWithValue("@idcaja", idcaja);
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ObtenerVentas_PorCobrar(string buscar)
        {
            using (SqlConnection con = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    string _query = "";

                    if (string.IsNullOrEmpty(buscar))
                    {
                        _query = @"SELECT v.*, c.Nombre  FROM tb_Ventas v 
                                   INNER JOIN tb_Cliente c on v.Cliente_Id = c.Id_Cliente
                                   WHERE Estado_Pago ='PENDIENTE'";
                    }
                    else
                    {
                        _query = @"SELECT v.*, c.Nombre  FROM tb_Ventas v 
                                   INNER JOIN tb_Cliente c on v.Cliente_Id = c.Id_Cliente
                                   WHERE Estado_Pago ='PENDIENTE' AND v.Folio + v.Comprobante + c.Nombre like '%'+'"+buscar+"'+'%'";
                    }
                    SqlDataAdapter da = new SqlDataAdapter(_query, con);
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                }
            }
        }

        public int Actualizar_CreditoPorPagar(int idventa, decimal saldo, string EstadoPago)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    int _filasAfectadas;

                    SqlCommand cmd = new SqlCommand($"UPDATE tb_Ventas SET Estado_Pago='{EstadoPago}', Saldo={saldo} WHERE Id_Venta={idventa}", con);
                    con.Open();
                    _filasAfectadas = cmd.ExecuteNonQuery();
                    con.Close();

                    return _filasAfectadas;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Obtener_ComprobanteCredito(int idventa , decimal abonado)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter($"exec sp_Comprobante_PagoCredito {idventa}, {abonado}", con);
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
