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
    }
}
