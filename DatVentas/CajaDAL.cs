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
    public static class CajaDAL
    {
        public static string ObtenerImpresora(string tipoDocumento, string serialPC)
        {
            try
            {
                string impresora = "NINGUNA";
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("GetPrinter_ByPC", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@serialPC", serialPC);
                        cmd.Parameters.AddWithValue("@typeDoc", tipoDocumento);

                        impresora = Convert.ToString(cmd.ExecuteScalar());
                    }
                    conn.Close();
                }

                return impresora;
            }
            catch (Exception)
            {
                return "NINGUNA";
            }
        }

        public static Box ObtenerCaja(string serialPC)
        {
            try
            {
                Box caja = new Box();
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("SELECT * FROM tb_Caja WHERE Serial_PC = @serial",con))
                    {
                        cmd.Parameters.AddWithValue("serial", serialPC);
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            caja.Id = reader.GetInt32(0);
                            caja.Descripcion = reader.GetString(1);
                            caja.Tema = reader.GetString(2);
                            caja.SerialPC = reader.GetString(3);
                            caja.ImpresoraTicket = reader.GetString(4);
                            caja.ImpresoraA4 = reader.GetString(5);
                            caja.Tipo = reader.GetString(6);
                        }
                    }
                    con.Close();
                    return caja;
                }
            }
            catch (Exception)
            {
                return new Box();
            }
        }

        public static User ValidarSesion(string serialPC)
        {
            try
            {

                User sesion = new User();

                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ValidateSession", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@serialPC", serialPC);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        sesion.Id = reader.GetInt32(0);
                        sesion.Usuario = reader.GetString(1);
                        sesion.Nombre = reader.GetString(2);
                    }

                    con.Close();
                }


                return sesion;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al validar la sesión \nDetalles: "+ex.Message);
            }
        }

        public static void CorteCaja(string serialPC , int idUsuario, ref DataGridView grid)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    using (var da = new SqlDataAdapter("[sp_CorteCaja]",con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@fecha", DateTime.Now);
                        da.SelectCommand.Parameters.AddWithValue("@idusuario", idUsuario);
                        da.SelectCommand.Parameters.AddWithValue("@serialPC", serialPC);

                        var dt = new DataTable();
                        da.Fill(dt);
                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public static void EntradaSalidaEfectivo(string serialPC, int idUsuario, ref DataGridView grid, DateTime inicio, DateTime fin)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    using (var da = new SqlDataAdapter("[ListarIngresoEgresos]", con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                        da.SelectCommand.Parameters.AddWithValue("@SerialPC", serialPC);
                        da.SelectCommand.Parameters.AddWithValue("@fechaInicio", inicio);
                        da.SelectCommand.Parameters.AddWithValue("@fechaFin", fin);

                        var dt = new DataTable();
                        da.Fill(dt);
                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
