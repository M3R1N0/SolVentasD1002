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

        public int Editar_NumeroFin(string numeroFin, int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    int filasAfectadas = 0;

                    SqlCommand sc = new SqlCommand($"UPDATE tb_Serializacion SET Numero_Fin='{numeroFin}' WHERE Id_Serializacion={id}", con);
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
    }
}
