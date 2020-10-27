using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVentas
{
    public class DatKardex
    {
        public DataTable BuscarProducto_Kardex(int idproducto, string opcion)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                try
                {
                    if (opcion.Equals("MOVIMIENTO_KARDEX"))
                    {
                        da = new SqlDataAdapter("EXEC sp_buscar_movimiento_kardex'" + idproducto + "'", conn);
                    }
                    else
                    {
                        da = new SqlDataAdapter("sp_mostrarKardex'" + idproducto + "'", conn);
                    }

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
