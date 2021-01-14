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
    public class DatBox
    {
        public DataRow selectBoxBySerial(string serial)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT  Id_Caja, Descripcion FROM tb_Caja WHERE  Serial_PC='" +serial + "'", conn);
                    da.Fill(dt);
                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw ex;
                }
            }
        }

        public int Insertar_Caja(Box b)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_insertarCaja", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@descripcion", b.Descripcion);
                    sc.Parameters.AddWithValue("@tema", b.Tema);
                    sc.Parameters.AddWithValue("@serialPC", b.SerialPC);
                    sc.Parameters.AddWithValue("@impresoraTicket", b.ImpresoraTicket);
                    sc.Parameters.AddWithValue("@impresoA4", b.ImpresoraA4);
                    sc.Parameters.AddWithValue("@tipo", b.Tipo);
                    sc.Parameters.AddWithValue("@estado", b.Estado);
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

        public void Insertar_CajaRemota( string conexion ,Box b)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_insertarCaja", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@descripcion", b.Descripcion);
                    sc.Parameters.AddWithValue("@tema", b.Tema);
                    sc.Parameters.AddWithValue("@serialPC", b.SerialPC);
                    sc.Parameters.AddWithValue("@impresoraTicket", b.ImpresoraTicket);
                    sc.Parameters.AddWithValue("@impresoA4", b.ImpresoraA4);
                    sc.Parameters.AddWithValue("@tipo", b.Tipo);
                    sc.Parameters.AddWithValue("@estado", b.Estado);
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

        public int Obtener_CajaSerial(string serialpc)
        {
            using (SqlConnection con = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    con.Open();
                    SqlCommand sc = new SqlCommand("SELECT Id_Caja FROM tb_Caja WHERE Serial_PC ='" + serialpc+"'", con);
                    int id = Convert.ToInt32( sc.ExecuteScalar() );
                    return id;
                }
                catch (Exception ex)
                {
                   throw ex;
                      con.Close();
               }
            }
        }

        public DataTable ObtenerTipoCaja()
        {
            using (SqlConnection con = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("sp_mostrarCajaPrincipal", con);
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

        public  static string Obtener_ImpresoraTicket(string serialPC)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    string aux;
                    SqlCommand sc = new SqlCommand($"SELECT Impresora_Tickect FROM tb_Caja WHERE Serial_PC='"+serialPC+"'", conn);
                    conn.Open();
                   aux = Convert.ToString(  sc.ExecuteScalar());
                    conn.Close();
                    return aux;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw ex;
                }
            }
        }

        public int Actualizar_ImpresoraTicket(Box b)
        {
            using (SqlConnection con = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    SqlCommand sc = new SqlCommand($"UPDATE tb_Caja SET Impresora_Tickect='{b.ImpresoraTicket}' WHERE Id_Caja={b.Id}", con);
                    con.Open();
                    int filasAfectadas = sc.ExecuteNonQuery();
                    con.Close();

                    return filasAfectadas;
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                }
            }
        }
    }
}
