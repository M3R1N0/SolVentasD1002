using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVentas
{
    public  class DatLicencia
    {
        public  void  AgregarLicencia( string s, string f, string e, string fa )
        {
              using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand sc = new SqlCommand("sp_insertarLicencia", conn);
                        sc.CommandType = CommandType.StoredProcedure;
                        sc.Parameters.AddWithValue("@s", s);
                        sc.Parameters.AddWithValue("@f", f);
                        sc.Parameters.AddWithValue("@e", e);
                        sc.Parameters.AddWithValue("@fa", fa);
                        sc.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        throw ex;
                    }
                }
            
        }

        public DataRow ObtenerLicencia_Temporal()
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter( "SELECT * FROM tb_Licencia", conn );
                    da.Fill( dt );
                    return dt.Rows[0];

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
