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
                    string query;
                    if (String.IsNullOrEmpty(nombre))
                    {
                        query = "SELECT * FROM tb_Cliente WHERE Estado = 1";
                    }
                    else
                    {
                        query = "SELECT * FROM  tb_Cliente WHERE Nombre like '%" + nombre + "%' and ESTADO = 1";
                    }
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
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

        public int BorrarCliente(int id)
        {
            using (SqlConnection con = new SqlConnection(MasterConnection.connection))
            {
                int resultado;
                try
                {
                    SqlCommand sc = new SqlCommand($"UPDATE tb_Cliente SET Estado = 0 WHERE Id_Cliente={id}", con);
                    con.Open();
                    resultado = sc.ExecuteNonQuery();
                    con.Close();

                    return resultado;
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                }
            }
        }

        public int ActualizarCliente(Cliente c)
        {
            using (SqlConnection con = new SqlConnection(MasterConnection.connection))
            {
                int resultado;
                try
                {
                    SqlCommand sc = new SqlCommand("sp_Actualizar_Cliente", con);
                    sc.CommandType = CommandType.StoredProcedure;

                    sc.Parameters.AddWithValue("@id", c.Id);
                    sc.Parameters.AddWithValue("@nombre", c.NombreCompleto);
                    sc.Parameters.AddWithValue("@direccion", c.Direccion);
                    sc.Parameters.AddWithValue("@ruc", c.Ruc);
                    sc.Parameters.AddWithValue("@telefono", c.Telefono);
                    sc.Parameters.AddWithValue("@cliente", c.Clientes);
                    sc.Parameters.AddWithValue("@proveedor", c.Proveedor);
                    sc.Parameters.AddWithValue("@saldo", c.Saldo);
                    con.Open();
                    resultado = sc.ExecuteNonQuery();
                    con.Close();

                    return resultado;
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
