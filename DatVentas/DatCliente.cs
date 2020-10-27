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
    public class DatCliente
    {
        public int Insertar_Cliente(Cliente c)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_insertarCliente", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@nombre", c.NombreCompleto);
                    sc.Parameters.AddWithValue("@direccion", c.Direccion);
                    sc.Parameters.AddWithValue("@ruc", c.Ruc);
                    sc.Parameters.AddWithValue("@telefono", c.Telefono);
                    sc.Parameters.AddWithValue("@cliente", c.Clientes);
                    sc.Parameters.AddWithValue("@proveedor", c.Proveedor);
                    sc.Parameters.AddWithValue("@saldo", c.Saldo);
                    sc.Parameters.AddWithValue("@estado", c.Estado);
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

        public DataTable ObtenerClientes(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  tb_Cliente WHERE Nombre like '%"+nombre+"%' and ESTADO = 1", conn);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception)
                {
                    conn.Close();
                    // throw ex;
                }
                return dt;
            }
        }
    }
}
