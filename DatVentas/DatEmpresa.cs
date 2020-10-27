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
   public class DatEmpresa
    {
        public int Agregar_Empresa(Empresa e)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_insertarEmpresa", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@nombre", e.Nombre);
                    sc.Parameters.AddWithValue("@logo", e.Logo);
                    sc.Parameters.AddWithValue("@impuesto", e.Impuesto);
                    sc.Parameters.AddWithValue("@porcentaje", e.Porcentaje);
                    sc.Parameters.AddWithValue("@moneda", e.Moneda);
                    sc.Parameters.AddWithValue("@trabajaImpuesto", e.Usa_Impuestos);
                    sc.Parameters.AddWithValue("@modoBusqueda", e.Busqueda);
                    sc.Parameters.AddWithValue("@rutaBackup", e.RutaBackup);
                    sc.Parameters.AddWithValue("@correoEnvioRpt", e.CorreoEnvio);
                    sc.Parameters.AddWithValue("@ultimoBackup", e.UltimoBackup);
                    sc.Parameters.AddWithValue("@ultimoBackup2", e.UltimaFechaBackup);
                    sc.Parameters.AddWithValue("@frecuenciaBackup", e.FrecuenciaBackup);
                    sc.Parameters.AddWithValue("@TipoEmpresa", e.TipoEmpresa);
                    sc.Parameters.AddWithValue("@pais", e.Pais);
                    sc.Parameters.AddWithValue("@Redondeo", e.Redondeo);
                    sc.Parameters.AddWithValue("@estado", e.Estado);
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

        public DataRow MostraEmpresa()
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tb_Empresa ", conn);
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

        public int EditarEmpresa(Empresa e)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_ActualizarEmpresa", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@empresa", e.Nombre);
                    sc.Parameters.AddWithValue("@logo", e.Logo);
                    sc.Parameters.AddWithValue("@impuesto", e.Impuesto);
                    sc.Parameters.AddWithValue("@porcentajeimpuesto", e.Porcentaje);
                    sc.Parameters.AddWithValue("@manejaimpuesto", e.Usa_Impuestos);
                    sc.Parameters.AddWithValue("@modobusqueda", e.Busqueda);
                    sc.Parameters.AddWithValue("@moneda", e.Moneda);
                    sc.Parameters.AddWithValue("@correo", e.CorreoEnvio);
                    sc.Parameters.AddWithValue("@rutabackup", e.RutaBackup);
                    sc.Parameters.AddWithValue("@pais", e.Pais);
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
