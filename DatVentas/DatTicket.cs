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
    public class DatTikect
    {
        public int Insertar_Ticket(Ticket t)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_insertarTicket", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@Identificadorfiscal", t.Identificador_Fiscal);
                    sc.Parameters.AddWithValue("@direccion", t.Direccion);
                    sc.Parameters.AddWithValue("@provincia", t.Provincia);
                    sc.Parameters.AddWithValue("@moneda", t.Moneda);
                    sc.Parameters.AddWithValue("@agradecimiento", t.Agradecimiento);
                    sc.Parameters.AddWithValue("@paginaweb", t.Pagina_Web);
                    sc.Parameters.AddWithValue("@anuncio", t.Anuncio);
                    sc.Parameters.AddWithValue("@datosfiscales", t.Datos_Fiscales);
                    sc.Parameters.AddWithValue("@pordefecto", t.Default);
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
