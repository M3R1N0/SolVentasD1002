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
    public class DatOpenCloseBox
    {
        public int GetOpenCloseMovDetail(string serial, int idUsuario)
        {
            int result;
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("Mostrar_Movimientos_De_Caja_Por_Serial_Usuario", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@serial", serial);
                    da.SelectCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                    return result = da.Fill(dt);
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw ex;
                }
            }
        }

        public int insertOpenBoxDetail(OpenCloseBox o)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_agregar_detalle_cierrecaja", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@fechInicio", o.FechaInicio);
                    sc.Parameters.AddWithValue("@fechFin", o.FechaFin);
                    sc.Parameters.AddWithValue("@fechCierre", o.FechaCierre);
                    sc.Parameters.AddWithValue("@ingresos", o.Ingresos);
                    sc.Parameters.AddWithValue("@egresos", o.Egresos);
                    sc.Parameters.AddWithValue("@saldo", o.Saldo);
                    sc.Parameters.AddWithValue("@idUsuario", o.UsuarioId.Id);
                    sc.Parameters.AddWithValue("@totalCalculado", o.TotalCalculado);
                    sc.Parameters.AddWithValue("@totalReal", o.TotalReal);
                    sc.Parameters.AddWithValue("@estado", o.Estado);
                    sc.Parameters.AddWithValue("@diferencia", o.Diferencia);
                    sc.Parameters.AddWithValue("@idCaja", o.CadaId.Id);

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

        public DataTable SelectDetailOpenClose(string serial)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("exec sp_mostrar_movimiento_cierrecaja_xserial'" + serial + "'", conn);
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

        public void InsertarEfectivoInicial(decimal saldo, int cajaID)
        {
            using (SqlConnection connection = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    SqlCommand sc = new SqlCommand($"UPDATE tb_Movimiento_CierreCaja set Saldo_EnCaja='{saldo}' WHERE Caja_Id='{cajaID}' and Estado='{1}'", connection);
                    connection.Open();
                    sc.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    throw ex;
                }

            }
        }

        public void CerrarCaja(int cajaID, DateTime cierre, DateTime fin)
        {
            using (SqlConnection connection = new SqlConnection(MasterConnection.connection))
            {
                try { 
                
                    SqlCommand sc = new SqlCommand($"UPDATE tb_Movimiento_CierreCaja set Estado={0} ,Fecha_Fin={fin.ToString("dd/MM/yyyy")}, Fecha_Cierre={cierre.ToString("dd/MM/yyyy")} WHERE Caja_Id={cajaID} and Estado={1}", connection);
                    connection.Open();
                    sc.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    throw ex;
                }

            }
        }
    }
}
