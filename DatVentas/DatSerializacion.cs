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
    public class DatSerializacion
    {
        public int Insertar_Serializacion(Serializacion s)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("ps_insertarSerializacion", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@serie", s.Serie);
                    sc.Parameters.AddWithValue("@cantidad", s.Cantidad_Numero);
                    sc.Parameters.AddWithValue("@numerofin", s.NumeroFin);
                    sc.Parameters.AddWithValue("@destino", s.Destino);
                    sc.Parameters.AddWithValue("@tipodoc", s.Tipo_Documento);
                    sc.Parameters.AddWithValue("@pordefecto", s.Por_Defecto);
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

        public int EliminarComprobante(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    int filasAfectadas = 0;
                    SqlCommand sc = new SqlCommand($"DELETE FROM tb_Serializacion WHERE Id_Serializacion={id}", con);
                    con.Open();
                    filasAfectadas = sc.ExecuteNonQuery();
                    con.Close();

                    return filasAfectadas;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EditarComprobante(Serializacion s)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    int filasAfectadas = 0;

                    SqlCommand sc = new SqlCommand("sp_ActualizarSerializacion", con);
                    con.Open();
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@id", s.Id);
                    sc.Parameters.AddWithValue("@serie", s.Serie);
                    sc.Parameters.AddWithValue("@cantindadnumeros", s.Cantidad_Numero);
                    sc.Parameters.AddWithValue("@numerofin", s.NumeroFin);
                    sc.Parameters.AddWithValue("@destino", s.Destino);
                    sc.Parameters.AddWithValue("@tipodocumento", s.Tipo_Documento);
                    sc.Parameters.AddWithValue("@pordefecto", s.Por_Defecto);
                    filasAfectadas = sc.ExecuteNonQuery();
                    con.Close();

                    return filasAfectadas;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int ActualizarFolio(string numeroFin, int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    int filasAfectadas = 0;
                    con.Open();
                    using (var cmd = new SqlCommand("UPDATE tb_Serializacion SET Numero_Fin=@numeroFin WHERE Id_Serializacion=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@numeroFin", numeroFin );
                        cmd.Parameters.AddWithValue("@id", id);
                    
                        filasAfectadas = cmd.ExecuteNonQuery();
                    }
                    con.Close();

                    return filasAfectadas;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public DataTable ObtenerComprobantes()
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tb_Serializacion WHERE Destino ='OTROS' OR Destino='VENTAS' ", conn);
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

        //=======================================================================
        public static DataTable ObtenerComprobantes_Ventas()
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tb_Serializacion WHERE  Destino='VENTAS' ", conn);
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

        public  static Serializacion ObtenerComprobante(string tipoDoc)
        {
            try
            {
                Serializacion serializacion = null;
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT * FROM tb_Serializacion WHERE Tipo_Documento='{tipoDoc }'", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        serializacion = new Serializacion();

                        serializacion.Id = reader.GetInt32(0);
                        serializacion.Serie = reader.GetString(1);
                        serializacion.Cantidad_Numero = reader.GetString(2);
                        serializacion.NumeroFin = reader.GetString(3);
                        serializacion.Destino = reader.GetString(4);
                        serializacion.Tipo_Documento = reader.GetString(5);
                        serializacion.Por_Defecto = reader.GetString(6);

                    }
                }

                return serializacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Serializacion> ObtenerTipoDocumento(string destinoDocumento)
        {
            List<Serializacion> lst = new List<Serializacion>();
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT * FROM tb_Serializacion WHERE Destino=@destino ORDER BY Por_Defecto DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@destino", destinoDocumento);
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Serializacion obj = new Serializacion();
                            obj.Id = reader.GetInt32(0);
                            obj.Serie = reader.GetString(1);
                            obj.Cantidad_Numero = reader.GetString(2);
                            obj.NumeroFin = reader.GetString(3);
                            obj.Destino = reader.GetString(4);
                            obj.Tipo_Documento = reader.GetString(5);
                            obj.Por_Defecto = reader.GetString(6);

                            lst.Add(obj);
                        }
                    }
                    conn.Close();

                    return lst;
                }
                catch (Exception ex)
                {
                    return new List<Serializacion>();
                }
            }
        }

        
    }
}
