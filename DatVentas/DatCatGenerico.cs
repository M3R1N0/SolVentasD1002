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
    public class DatCatGenerico
    {
        public int InsertarCatalogo(string c, string pordefecto)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("exec sp_AgregarCatProducto'" + c + "','" + pordefecto + "'", conn);
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

        public int Insertar_TipoUsuario(CatalogoGenerico c)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_Insertar_TipoUsuario", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@nombre", c.Nombre);
                    sc.Parameters.AddWithValue("@descripcion", c.Descripcion);
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

        public int InsertarDatosCatalago(CatalogoGenerico C, int valor)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_AgregarDatosCatalogos", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@nombre", C.Nombre);
                    sc.Parameters.AddWithValue("@descripcion", C.Descripcion);
                    sc.Parameters.AddWithValue("@valor", valor);
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

        public DataTable MostrarCategorias()
        {

            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CatProducto WHERE Estado= 1", conn);
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

        public static DataTable ListarCat_TipoUsuario()
        {

            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cat_Tipo_Usuario WHERE Estado = 1", conn);
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

        public static DataTable ListarCat_TipoPresentacion()
        {

            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cat_Tipo_Presentacion WHERE Estado = 1", conn);
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

        public static DataTable ListarCat_Producto()
        {

            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cat_Producto WHERE Estado = 1", conn);
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

        #region INSERCION DE DATOS DE LA TB_INICIOSESION

        public void Insertar_InicioSesion(string serialPC)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_insertar_inicioSesion", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@idSerialPC", serialPC);
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

        public void Editar_InicioSesion( string serialPC, int idUsuario)
        {
            using (SqlConnection con = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    con.Open();
                    SqlCommand sc = new SqlCommand("sp_Editar_IncioSecion", con);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue( "@serialpc", serialPC );
                    sc.Parameters.AddWithValue( "@idusuario", idUsuario );
                    sc.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                }
            }
        }

        public int Obtener_IdAdmin()
        {
            using ( SqlConnection con = new SqlConnection( MasterConnection.connection ))
            {
                try
                {
                    con.Open();
                    SqlCommand sc = new SqlCommand("SELECT Id_Usuario FROM tb_Usuario WHERE Rol_Id = 1", con);
                    int Id = Convert.ToInt32( sc.ExecuteScalar() );
                    return Id;
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                }
            }
        }

        public DataRow Obtener_InicioSesion(string serialpc)
        {
            using (SqlConnection con = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("mostrar_InicioSesion", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@serialpc", serialpc);
                    da.Fill(dt);

                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                }
            }
        }

        #endregion

        #region CATALOGO FORMA PAGO
        public static DataTable ObtenerCatalogo_FormaPago()
        {

            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cat_FormaPago WHERE Estado = 1", conn);
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
        #endregion
    }
}
