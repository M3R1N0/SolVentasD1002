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
                    sc.Parameters.AddWithValue("@estado", p.Estado);
                    // datos pata la tabla kardex
                    sc.Parameters.AddWithValue("@idusuario", kardex.Id_Usuario);
                    sc.Parameters.AddWithValue("@idcaja", kardex.Id_Caja);
                    sc.Parameters.AddWithValue("@fecha", kardex.Fecha);
                    sc.Parameters.AddWithValue("@motivo", kardex.Motivo);
                    sc.Parameters.AddWithValue("@cantidad", kardex.Cantidad);
                    sc.Parameters.AddWithValue("@tipo", kardex.Tipo);
                    sc.Parameters.AddWithValue("@estadokardex",   kardex.Estado);

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

        public DataTable MostrarProductos(string busqueda)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    if (busqueda == null | busqueda == "")
                    {
                        da = new SqlDataAdapter("SELECT * FROM tb_Producto", conn);
                    }
                    else
                    {
                        da = new SqlDataAdapter("select * from tb_Producto where Codigo like '%"+busqueda+"%' or Descripcion  like '%"+busqueda+"%'", conn);
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

        public int EliminarProducto(int id)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                int resultado = 0;
                try
                {
                    conn.Open();
                    SqlCommand sc = new SqlCommand("DELETE FROM tb_Producto WHERE Id_Producto="+id, conn);
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
                    sc.Parameters.AddWithValue("@estado", p.Estado);
                    sc.Parameters.AddWithValue("@idproducto", p.Id);

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

        public  DataTable Mostrar_ProductoInvetario()
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
                    sc.Parameters.AddWithValue("@id",id);
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
    }
}
