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
                    sc.Parameters.AddWithValue("@ruc", c.Clave);
                    sc.Parameters.AddWithValue("@telefono", c.Telefono);
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
                        query = "SELECT TOP(10) * FROM tb_Cliente WHERE Estado = 1";
                    }
                    else
                    {
                        query = "SELECT TOP(10) * FROM  tb_Cliente WHERE Nombre like '%" + nombre + "%' and ESTADO = 1";
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

        public DataRow ObtenerCliente_PorId(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    using (var da = new SqlDataAdapter("SELECT  * FROM tb_Cliente where Id_Cliente=@idCliente", conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@idCliente", id);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return dt.Rows[0];
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
                    //sc.Parameters.AddWithValue("@ruc", c.Ruc);
                    sc.Parameters.AddWithValue("@telefono", c.Telefono);
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

        public static int TotalClientes()
        {
            int resultado = 0;
            try
            {

                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {

                    SqlCommand cmd = new SqlCommand("select count(Id_Cliente) from tb_Cliente where Estado = 1", con);
                    con.Open();
                    resultado = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();

                    return resultado;
                }
            }
            catch (Exception ex)
            {
                return resultado = 0;
                throw ex;
            }
        }

        public static void actualizarCreditoCliente(Cliente c)
        {
            int resultado = 0;
            try
            {

                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"UPDATE tb_Cliente SET Saldo={c.Saldo} WHERE Id_Cliente={c.Id}", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ListarClientes(ref DataGridView grid, string busqueda)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    using (var da = new SqlDataAdapter("ListarCliente", con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@busqueda", busqueda);
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

        //======================================================================================
        public static Cliente ObtenerCliente_Predeterminado()
        {
            try
            {
                Cliente cliente = null;
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT C.Id_Cliente, C.Nombre, C.Saldo FROM tb_Cliente C WHERE C.Nombre LIKE '%{"GENERAL"}%'", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cliente = new Cliente();

                        cliente.Id = reader.GetInt32(0);
                        cliente.NombreCompleto = reader.GetString(1);
                        cliente.Saldo = reader.GetDecimal(2);
                    }

                    con.Close();
                    return cliente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Cliente> ListarVentas_PorCliente(string nombre)
        {
            List<Cliente> lstCliente = new List<Cliente>();
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_ObtenerVentas_PorCliente", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Ruc = reader.GetString(0);
                        cliente.NombreCompleto = reader.GetString(1);
                        cliente.Direccion = reader.GetString(2);
                        cliente.Id = reader.GetInt32(3);
                        cliente.Saldo = reader.GetDecimal(4);

                        lstCliente.Add(cliente);
                    }

                    conn.Close();
                    return lstCliente;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ListarVentasPorCliente(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {

                    SqlDataAdapter da = new SqlDataAdapter("SP_ObtenerVentas_PorCliente", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@nombre", nombre);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        public static decimal ObtenerSaldoDisponible(int idCliente)
        {
            decimal resultado = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("sp_ObtenerDisponible", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);

                        resultado = Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                    con.Close();

                    return resultado;
                }
            }
            catch (Exception ex)
            {
                return resultado = 0;
                throw ex;
            }
        }

        //======================================================================================
        public static Cliente ObtenerProveedor(int id)
        {
            try
            {
                Cliente proveedor = new Cliente();
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("SELECT * FROM Proveedor WHERE Id=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            proveedor.Id = reader.GetInt32(0);
                            proveedor.NombreCompleto = reader.GetString(1);
                            proveedor.Clave = reader.GetString(2);
                            proveedor.RazonSocial = reader.GetString(3);
                            proveedor.Ruc = reader.GetString(4);
                            proveedor.Correo = reader.GetString(5);
                            proveedor.Direccion = reader.GetString(6);
                            proveedor.Telefono = reader.GetString(7);

                        }
                    }
                    con.Close();
                }
                return proveedor;
            }
            catch (Exception)
            {
                return new Cliente();
            }
        }

        public static void GuardarProveedor (Cliente c)
        {
            try
            {
                Cliente proveedor = new Cliente();
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("GuardarProveedor", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", c.Id);
                        cmd.Parameters.AddWithValue("@nombre", c.NombreCompleto);
                        cmd.Parameters.AddWithValue("@clave", c.Clave);
                        cmd.Parameters.AddWithValue("@razonSocial", c.RazonSocial);
                        cmd.Parameters.AddWithValue("@rfc", c.Ruc);
                        cmd.Parameters.AddWithValue("@correo", c.Correo);
                        cmd.Parameters.AddWithValue("@direccion", c.Direccion);
                        cmd.Parameters.AddWithValue("@telefono", c.Telefono);

                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                
            }
            catch (Exception)
            {
                
            }
        }

        public static void ListarProveedores(ref DataGridView grid, string busqueda = "")
        {
            try
            {
                var query = (busqueda == "")
                         ? "SELECT * FROM Proveedor WHERE Activo=1"
                         : $"SELECT * FROM Proveedor WHERE   Nombre + Clave like '%{busqueda}%' AND Activo=1";
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    using (var da = new SqlDataAdapter(query, con))
                    {
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

        public static void EliminarProveedor(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var  cmd =new SqlCommand("UPDATE Proveedor SET Activo = 0 WHERE Id=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception )
            {             
            }
        }
    }
}
