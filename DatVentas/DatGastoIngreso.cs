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
   public class DatGastoIngreso
    {
        public  void InsertarIngresoGastos(IngresosGastos ig)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();

                    string query = ig.idConcepto == 0 ? "[insertar_tb_Ingresos]" : "[insertar_tb_Gastos]";
                  
                    SqlCommand sc = new SqlCommand(query, conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@Caja_Id", ig.idCaja);
                    if (ig.idConcepto != 0)
                    {
                        sc.Parameters.AddWithValue("@Concepto_Id", ig.idConcepto);
                    }
                    sc.Parameters.AddWithValue("@Fecha", ig.Fecha);
                    sc.Parameters.AddWithValue("@Nro_Documento", ig.NoComprobante);
                    sc.Parameters.AddWithValue("@Tipo_Comprobante", ig.TipoComprobante);
                    sc.Parameters.AddWithValue("@Importe", ig.Importe);
                    sc.Parameters.AddWithValue("@Descripcion", ig.Descripcion);       
                    

                    resultado = sc.ExecuteNonQuery();
                    conn.Close();
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

        public  DataTable Obtener_VentasEnEspera()
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
                    SqlCommand sc = new SqlCommand("DELETE FROM tb_VentaEnEspera WHERE Id="+id, conn);


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
