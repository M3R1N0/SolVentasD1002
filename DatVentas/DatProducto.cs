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
    public class DatProducto
    {
        public int InsertarProducto(Producto p, Kardex kardex)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_insertar_producto", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@idCategoria", p.IdCategoria);
                    sc.Parameters.AddWithValue("@idPresentacion", p.IdTipoPresentacion);
                    sc.Parameters.AddWithValue("@codigo", p.codigo);
                    sc.Parameters.AddWithValue("@descripcion", p.Descripcion);
                    sc.Parameters.AddWithValue("@presentacion", p.Presentacion);
                    sc.Parameters.AddWithValue("@sevendea", p.seVendeA);
                    sc.Parameters.AddWithValue("@preciomenudeo", p.precioMenudeo);
                    sc.Parameters.AddWithValue("@preciommayoreo", p.precioMMayoreo);
                    sc.Parameters.AddWithValue("@apartirde", p.APartirDe);
                    sc.Parameters.AddWithValue("@preciomayoreo", p.precioMayoreo);
                    sc.Parameters.AddWithValue("@usainventario", p.usaInventario);
                    sc.Parameters.AddWithValue("@stock", p.stock);
                    sc.Parameters.AddWithValue("@stockminimo", p.stockMinimo);
                    sc.Parameters.AddWithValue("@caducidad", p.Caducidad);
                    sc.Parameters.AddWithValue("@totalunidades", p.TotalUnidades);
                    sc.Parameters.AddWithValue("@presentacionmenudeo", p.PresentacionMenudeo);
                    sc.Parameters.AddWithValue("@estado", p.Estado);
                    // datos pata la tabla kardex
                    sc.Parameters.AddWithValue("@idusuario", kardex.Id_Usuario);
                    sc.Parameters.AddWithValue("@idcaja", kardex.Id_Caja);
                    sc.Parameters.AddWithValue("@fecha", kardex.Fecha);
                    sc.Parameters.AddWithValue("@motivo", kardex.Motivo);
                    sc.Parameters.AddWithValue("@cantidad", kardex.Cantidad);
                    sc.Parameters.AddWithValue("@tipo", kardex.Tipo);
                    sc.Parameters.AddWithValue("@estadokardex", kardex.Estado);
                    sc.Parameters.AddWithValue("@peso", p.Peso);

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

        public DataTable MostrarProductos(string busqueda, int bandera)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    if (string.IsNullOrEmpty(busqueda) && bandera == 1)
                    {
                        da = new SqlDataAdapter("SELECT TOP (15) * FROM tb_Producto where  Estado = 1 ORDER BY Descripcion", conn);
                    }
                    else
                    {
                        da = new SqlDataAdapter($"select TOP(15) * from tb_Producto where  Codigo like '" + busqueda + "' and Estado = 1 OR   Descripcion like '%" + busqueda + "%' and Estado = 1  order by Descripcion", conn);
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

        public DataRow ObtenerProductoID(int id)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM tb_Producto WHERE Id_Producto ={id}", conn);
                    da.Fill(dt);

                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataRow ObtenerProducto(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM tb_Producto WHERE Codigo + Descripcion like'%{codigo}%' AND Estado = 1", conn);
                    da.Fill(dt);

                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataRow ObtenerProducto_Actualizado(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM tb_Producto WHERE Codigo + Descripcion like'%{codigo}%'  ORDER BY Descripcion", conn);
                    da.Fill(dt);

                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataRow ObtenerProducto_Actualizado2(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM tb_Producto WHERE Codigo ='{codigo}'", conn);
                    da.Fill(dt);

                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public int ActualizarProducto(Producto p)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_actualizarProducto", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@idCategoria", p.IdCategoria);
                    sc.Parameters.AddWithValue("@idPresentacion", p.IdTipoPresentacion);
                    sc.Parameters.AddWithValue("@codigo", p.codigo);
                    sc.Parameters.AddWithValue("@descripcion", p.Descripcion);
                    sc.Parameters.AddWithValue("@presentacion", p.Presentacion);
                    sc.Parameters.AddWithValue("@sevendea", p.seVendeA);
                    sc.Parameters.AddWithValue("@preciomenudeo", p.precioMenudeo);
                    sc.Parameters.AddWithValue("@preciommayoreo", p.precioMMayoreo);
                    sc.Parameters.AddWithValue("@apartirde", p.APartirDe);
                    sc.Parameters.AddWithValue("@preciomayoreo", p.precioMayoreo);
                    sc.Parameters.AddWithValue("@usainventario", p.usaInventario);
                    sc.Parameters.AddWithValue("@stock", p.stock);
                    sc.Parameters.AddWithValue("@stockminimo", p.stockMinimo);
                    sc.Parameters.AddWithValue("@caducidad", p.Caducidad);
                    sc.Parameters.AddWithValue("@totalunidades", p.TotalUnidades);
                    sc.Parameters.AddWithValue("@presentacionmenudeo", p.PresentacionMenudeo);
                    sc.Parameters.AddWithValue("@estado", p.Estado);
                    sc.Parameters.AddWithValue("@idproducto", p.Id);
                    sc.Parameters.AddWithValue("@peso", p.Peso);

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

        public DataTable BuscarProducto_Kardex(string buscar)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("EXEC sp_buscar_Productos_Kardex'" + buscar + "'", conn);
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

        public static DataTable Obtener_InventariosBajos()
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("EXEC sp_mostrar_inventariosBajos", conn);
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

        public static DataTable Obtener_Inventarios(string buscar)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("EXEC sp_mostrar_inventarios'" + buscar + "'", conn);
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

        public static DataTable Obtener_ProductosVencidos(string buscar)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("EXEC sp_mostrar_productos_vencidos'" + buscar + "'", conn);
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

        public static DataTable Obtener_ProductosVencidosDelMes()
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("EXEC ps_Obtener_Productos_PorVencer", conn);
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

        public DataTable Mostrar_ProductoInvetario()
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da = new SqlDataAdapter("sp_ReporteInventario", conn);

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

        public decimal ObtenerTipoPrecio(int id, string tipo)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                decimal resultado = 0;
                try
                {
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_obtenerTipoPrecio", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@id", id);
                    sc.Parameters.AddWithValue("@tipo", tipo);
                    resultado = Convert.ToDecimal(sc.ExecuteScalar());
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

        public int MostrarNotificacion_Vencimiento()
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                int resultado = 0;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_contarProductos_Vencidos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    resultado = Convert.ToInt32(cmd.ExecuteScalar());
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

        public int ActualizarStock(int idProducto, decimal cantidad)
        {
            using (SqlConnection con = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int filasAfectadas = 0;
                    SqlCommand sc = new SqlCommand($"UPDATE tb_Producto SET Stock='{cantidad.ToString()}' WHERE Id_Producto={idProducto}", con);

                    con.Open();
                    filasAfectadas = sc.ExecuteNonQuery();
                    con.Close();

                    return filasAfectadas;
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                }
            }
        }

        public static int TotalProducto()
        {
            int resultado = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand("select count(Id_Producto) from tb_Producto where Estado = 1", con);
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

        public static int TotalProducto_StockBajos()
        {
            int resultado = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand("select count(Id_Producto) from tb_Producto where Estado = 1 and Convert(decimal,Stock) <= Stock_Minimo", con);
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

        #region DESCARGAR ACTUALIZACION DE PRODUCTO

        public static void Agregar_ActualizacionProducto(string codigo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand($"INSERT INTO [tb_ProductosActualizados] VALUES ('{codigo}')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarRegistros_ActualizacionProducto()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand($"DELETE FROM [tb_ProductosActualizados]", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> listadoActualizacion()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    List<string> lstCodigos = new List<string>();
                    SqlCommand cmd = new SqlCommand("SELECT DISTINCT (Codigo) from tb_ProductosActualizados", conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lstCodigos.Add(reader["Codigo"].ToString());
                    }
                    conn.Close();

                    return lstCodigos;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ActualizarProducto_Excel(Producto p)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("[sp_actualizarProductoPorExcel]", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                  //  sc.Parameters.AddWithValue("@idCategoria", p.IdCategoria);
                   // sc.Parameters.AddWithValue("@idPresentacion", p.IdTipoPresentacion);
                    sc.Parameters.AddWithValue("@codigo", p.codigo);
                    sc.Parameters.AddWithValue("@descripcion", p.Descripcion);
                    sc.Parameters.AddWithValue("@presentacion", p.Presentacion);
                    sc.Parameters.AddWithValue("@sevendea", p.seVendeA);
                    sc.Parameters.AddWithValue("@preciomenudeo", p.precioMenudeo);
                    sc.Parameters.AddWithValue("@preciommayoreo", p.precioMMayoreo);
                    sc.Parameters.AddWithValue("@apartirde", p.APartirDe);
                    sc.Parameters.AddWithValue("@preciomayoreo", p.precioMayoreo);
                    sc.Parameters.AddWithValue("@usainventario", p.usaInventario);
                    sc.Parameters.AddWithValue("@stockminimo", p.stockMinimo);
                    sc.Parameters.AddWithValue("@caducidad", p.Caducidad);
                    sc.Parameters.AddWithValue("@totalunidades", p.TotalUnidades);
                    sc.Parameters.AddWithValue("@presentacionmenudeo", p.PresentacionMenudeo);
                    sc.Parameters.AddWithValue("@estado", p.Estado);

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

        public static bool ExisteProductoPorID(string codigo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand($"Select Codigo from  tb_Producto WHERE Codigo='{codigo}'", conn);
                    conn.Open();
                    string result  =Convert.ToString (cmd.ExecuteScalar());
                    conn.Close();

                    return (result != string.Empty) ? true : false;
                }


            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ExisteProductoPorDescripcion(string descripcion)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand($"Select Descripcion from  tb_Producto WHERE Descripcion='{descripcion}'", conn);
                    conn.Open();
                    string result = Convert.ToString(cmd.ExecuteScalar());
                    conn.Close();

                    return (result != string.Empty) ? true : false;
                }


            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        

  

        public static List<Producto> ObtenerProductos()
        {
            List<Producto> lstProducto = new List<Producto>();
            Producto p = null;
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand(@"select P.Descripcion, P.Presentacion, p.Precio_Menudeo, p.Precio_MMayoreo, p.A_Partir_De,
                                                      p.Precio_Mayoreo from tb_Producto P where p.Estado = 1 order by p.Descripcion", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        p = new Producto();

                        p.Descripcion = reader.GetString(0);
                        p.Presentacion = reader.GetString(1);
                        p.precioMenudeo = reader.GetDecimal(2);
                        p.precioMMayoreo = reader.GetDecimal(3);
                        p.APartirDe = reader.GetDecimal(4);
                        p.precioMayoreo = reader.GetDecimal(5);

                        lstProducto.Add(p);
                    }

                    return lstProducto;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ActivarProducto(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand($"UPDATE tb_Producto SET Estado = 1 WHERE Id_Producto ={id}", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
