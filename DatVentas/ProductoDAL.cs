using EntVenta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatVentas
{
    public class ProductoDAL
    {
        public static ProductoVM ObtenerProducto(int id)
        {
            try
            {
                ProductoVM producto = new ProductoVM();
                using (var conn = new SqlConnection(MasterConnection.connection))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("pa_ConsultarProducto",conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                producto.Id = reader.GetInt32(0);
                                producto.IdCategoria = reader.GetInt32(1);
                                producto.idPresentacion = reader.GetInt32(2);
                                producto.codigo = reader.GetString(3);
                                producto.Clave = reader.GetString(4);
                                producto.Articulo = reader.GetString(5);
                                producto.Detalle = reader.GetString(6);
                                producto.PrecioCompra = reader.GetDecimal(7);
                                producto.Precio = reader.GetDecimal(8);
                                producto.PrecioMayoreo = reader.GetDecimal(9);
                                producto.A_Partir_De = reader.GetDecimal(10);
                                producto.TipoVenta = reader.GetString(11);
                                producto.UsaInventario = reader.GetBoolean(12);
                                producto.Stock = reader.GetDecimal(13);
                                producto.StockMinimo = reader.GetDecimal(14);
                                producto.UnidadesPorPresentacion = reader.GetDecimal(15);
                                producto.Caducidad = reader.GetDateTime(16);
                                producto.Peso = reader.GetDecimal(17);
                                producto.UltimaActualizacion = reader.GetDateTime(18);
                                producto.Activo = reader.GetBoolean(19);

                                producto.IdProductoU = reader.GetInt32(20);
                                producto.IdPresentacionU = reader.GetInt32(21);
                                producto.CodigoU = reader.GetString(22);
                                producto.PrecioCompraU = reader.GetDecimal(23);
                                producto.PrecioU = reader.GetDecimal(24);
                                producto.PrecioMayoreoU = reader.GetDecimal(25);
                                producto.A_Partir_DeU = reader.GetDecimal(26);
                                producto.IdProveedor = reader.GetInt32(27);
                                producto.IdMarca = reader.GetInt32(28);
                            }
                        }
                    }
                    conn.Close();
                }

                return producto;
            }
            catch (Exception)
            {
                return new ProductoVM();
            }
        }

        public static void ListarProductos(ref DataGridView grid, string busqueda)
        {
            try
            {
                var dt = new DataTable();
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    using (var da = new SqlDataAdapter("pa_ListarProductos",con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@busqueda",busqueda);

                        da.Fill(dt);
                        grid.DataSource= dt;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public static List<ProductoVM> FiltrarProductos( string busqueda)
        {
            try
            {
                var lst = new List<ProductoVM>();
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("[pa_FiltrarProducto]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@busqueda", busqueda);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ProductoVM producto = new ProductoVM();
                                producto.Id = reader.GetInt32(0);
                                producto.IdCategoria = reader.GetInt32(1);
                                producto.idPresentacion = reader.GetInt32(2);
                                producto.codigo = reader.GetString(3);
                                producto.Articulo = reader.GetString(4);
                                producto.PrecioCompra = reader.GetDecimal(5);
                                producto.Precio = reader.GetDecimal(6);
                                producto.PrecioMayoreo = reader.GetDecimal(7);
                                producto.A_Partir_De = reader.GetDecimal(8);
                                producto.TipoVenta = reader.GetString(9);
                                producto.UsaInventario = reader.GetBoolean(10);
                                producto.Stock = reader.GetDecimal(11);
                                producto.StockMinimo = reader.GetDecimal(12);
                                producto.UnidadesPorPresentacion = reader.GetDecimal(13);
                                producto.Caducidad = reader.GetDateTime(14);
                                producto.UltimaActualizacion = reader.GetDateTime(15);
                                producto.Activo = reader.GetBoolean(16);

                                producto.IdProductoU = reader.GetInt32(17);
                                producto.IdPresentacionU = reader.GetInt32(18);
                                producto.CodigoU = reader.GetString(19);
                                producto.PrecioCompraU = reader.GetDecimal(20);
                                producto.PrecioU = reader.GetDecimal(21);
                                producto.PrecioMayoreoU = reader.GetDecimal(22);
                                producto.A_Partir_DeU = reader.GetDecimal(23);

                                lst.Add(producto);
                            }
                        }

                    }
                    con.Close();
                }
                return lst;
            }
            catch (Exception)
            {
                return new List<ProductoVM>();
            }
        }

        public static List<ProductoVM> FiltrarProductos_UsaInventario(string busqueda)
        {
            try
            {
                var lst = new List<ProductoVM>();
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("[pa_FiltrarProducto_usaInventario]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@busqueda", busqueda);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ProductoVM producto = new ProductoVM();
                                producto.Id = reader.GetInt32(0);
                                producto.IdCategoria = reader.GetInt32(1);
                                producto.idPresentacion = reader.GetInt32(2);
                                producto.codigo = reader.GetString(3);
                                producto.Articulo = reader.GetString(4);
                                producto.PrecioCompra = reader.GetDecimal(5);
                                producto.Precio = reader.GetDecimal(6);
                                producto.PrecioMayoreo = reader.GetDecimal(7);
                                producto.A_Partir_De = reader.GetDecimal(8);
                                producto.TipoVenta = reader.GetString(9);
                                producto.UsaInventario = reader.GetBoolean(10);
                                producto.Stock = reader.GetDecimal(11);
                                producto.StockMinimo = reader.GetDecimal(12);
                                producto.UnidadesPorPresentacion = reader.GetDecimal(13);
                                producto.Caducidad = reader.GetDateTime(14);
                                producto.UltimaActualizacion = reader.GetDateTime(15);
                                producto.Activo = reader.GetBoolean(16);

                                producto.IdProductoU = reader.GetInt32(17);
                                producto.IdPresentacionU = reader.GetInt32(18);
                                producto.CodigoU = reader.GetString(19);
                                producto.PrecioCompraU = reader.GetDecimal(20);
                                producto.PrecioU = reader.GetDecimal(21);
                                producto.PrecioMayoreoU = reader.GetDecimal(22);
                                producto.A_Partir_DeU = reader.GetDecimal(23);

                                lst.Add(producto);
                            }
                        }

                    }
                    con.Close();
                }
                return lst;
            }
            catch (Exception)
            {
                return new List<ProductoVM>();
            }
        }

        public static void GuardarProducto(ProductoVM vm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {

                    conn.Open();
                    using (var cmd = new SqlCommand("pa_GuardarProducto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", vm.Id);
                        cmd.Parameters.AddWithValue("@idCategoria", vm.IdCategoria);
                        cmd.Parameters.AddWithValue("@idPresentacion", vm.idPresentacion);
                        cmd.Parameters.AddWithValue("@codigo", vm.codigo);
                        cmd.Parameters.AddWithValue("@clave", vm.Clave);
                        cmd.Parameters.AddWithValue("@articulo", vm.Articulo);
                        cmd.Parameters.AddWithValue("@detalle", vm.Detalle);
                        cmd.Parameters.AddWithValue("@precio", vm.Precio);
                        cmd.Parameters.AddWithValue("@precioMayoreo", vm.PrecioMayoreo);
                        cmd.Parameters.AddWithValue("@aPartirDe", vm.A_Partir_De);
                        cmd.Parameters.AddWithValue("@tipoVenta", vm.TipoVenta);
                        cmd.Parameters.AddWithValue("@usaInventario", vm.UsaInventario);
                        cmd.Parameters.AddWithValue("@stock", vm.Stock);
                        cmd.Parameters.AddWithValue("@stockMinimo", vm.StockMinimo);
                        cmd.Parameters.AddWithValue("@unidadesPorPresentacion", vm.UnidadesPorPresentacion);
                        cmd.Parameters.AddWithValue("@caducidad", vm.Caducidad);
                        cmd.Parameters.AddWithValue("@peso", vm.Peso);

                        cmd.Parameters.AddWithValue("@idPresentacionU", vm.IdPresentacionU);
                        cmd.Parameters.AddWithValue("@codigoU", vm.CodigoU);
                        cmd.Parameters.AddWithValue("@precioU", vm.PrecioU);
                        cmd.Parameters.AddWithValue("@precioMayoreoU", vm.PrecioMayoreoU);
                        cmd.Parameters.AddWithValue("@aPartirDeU", vm.A_Partir_DeU);

                        cmd.Parameters.AddWithValue("@PrecioCompra", vm.PrecioCompra);
                        cmd.Parameters.AddWithValue("@PrecioCompraU", vm.PrecioCompraU);
                        cmd.Parameters.AddWithValue("@idProveedor", vm.IdProveedor);
                        cmd.Parameters.AddWithValue("@idMarca", vm.IdMarca);
                        cmd.Parameters.AddWithValue("@PrecioMenudeoActivado", vm.Activo);
                        

                        cmd.ExecuteNonQuery();
                    }
                    
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un detalle al guardar los datos",ex.InnerException);
            }
            
        }

        public static EntradaProductoVM ObtenerUltimaEntrada(int idProducto, string tipo)
        {
            var vm = new EntradaProductoVM();
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("[pa_ObtenerEntradaProducto]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);
                        cmd.Parameters.AddWithValue("@tipo", tipo);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                vm.Id = reader.GetInt32(0);
                                vm.IdProducto = reader.GetInt32(1);
                                vm.FechaIngreso = reader.GetDateTime(2);
                                vm.PrecioCompra = reader.GetDecimal(3);
                                vm.GananciaMayoreo = reader.GetDecimal(4);
                                vm.GananciaMenudeo = reader.GetDecimal(5);
                                vm.GananciaMayoreoM = reader.GetDecimal(6);
                                vm.GananciaMayoreoU = reader.GetDecimal(7);
                                vm.TotalIngresado = reader.GetDecimal(8);
                                vm.Caducidad = reader.GetDateTime(9);
                                vm.Estatus = reader.GetString(10);
                            }
                        }

                    }
                    con.Close();
                }

            }
            catch (Exception)
            {
                
            }
                return vm;
        }

        public static void GuardarEntrada(EntradaProductoVM entrada)
        {
            try
            {
                using (var conn = new SqlConnection(MasterConnection.connection))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("pa_GuardarEntrada",conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", entrada.Id);
                        cmd.Parameters.AddWithValue("@idProducto", entrada.IdProducto);
                        cmd.Parameters.AddWithValue("@precioCompra",entrada.PrecioCompra);
                        cmd.Parameters.AddWithValue("@gananciaMayoreo", entrada.GananciaMayoreo);
                        cmd.Parameters.AddWithValue("@gananciaMenudeo", entrada.GananciaMenudeo);
                        cmd.Parameters.AddWithValue("@totalIngresado", entrada.TotalIngresado);
                        cmd.Parameters.AddWithValue("@fecha", entrada.FechaIngreso);
                        cmd.Parameters.AddWithValue("@estatus", entrada.Estatus);
                        cmd.Parameters.AddWithValue("@Caducidad", entrada.Caducidad);
                        cmd.Parameters.AddWithValue("@gananciaMMayoreo", entrada.GananciaMayoreoM);
                        cmd.Parameters.AddWithValue("@gananciaUMayoreo", entrada.GananciaMayoreoU);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static void ActualizarPrecio(ProductoVM p)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_ActualizarPrecio", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@id", p.Id);
                    sc.Parameters.AddWithValue("@precioCosto", p.PrecioCompra);
                    sc.Parameters.AddWithValue("@ganancia", 0);
                    sc.Parameters.AddWithValue("@precioVenta", p.Precio);
                    sc.Parameters.AddWithValue("@precioMayoreo", p.PrecioMayoreo);
                    sc.Parameters.AddWithValue("@apartirde", p.A_Partir_De);
                    sc.Parameters.AddWithValue("@precioCompraU", p.PrecioCompraU);
                    sc.Parameters.AddWithValue("@gananciaU", 0);
                    sc.Parameters.AddWithValue("@precioVentaU", p.PrecioU);
                    sc.Parameters.AddWithValue("@precioMayoreoU", p.PrecioMayoreoU);
                    sc.Parameters.AddWithValue("@aPartirDeU", p.A_Partir_DeU);
                    sc.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {
                }
            }
        }

        public static void ActualizarStockDisponible_Producto(int idProducto, decimal cantidad, TIPO_ACTUALIZACION tipo )
        {
            try
            {

                using (var conn = new SqlConnection(MasterConnection.connection))
                {

                }

            }
            catch (Exception)
            {
            }
        }

        public static ProductoVM ObtenerProducto_x_Codigo(string codigo, string tipoCodigo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    ProductoVM p = new ProductoVM();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_ObtenerProductoVenta", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@articulo", codigo);
                    cmd.Parameters.AddWithValue("@tipoCodigo", tipoCodigo);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        p = new ProductoVM();
                        p.Id = reader.GetInt32(0);
                        p.Presentacion = reader.GetString(2);
                        p.codigo = reader.GetString(3);
                        p.TipoVenta = reader.GetString(5);
                        p.PrecioCompra = reader.GetDecimal(6);
                        p.Ganancia = reader.GetDecimal(7);
                        p.Precio = reader.GetDecimal(8);
                        p.PrecioMayoreo = reader.GetDecimal(9);
                        p.A_Partir_De = reader.GetDecimal(10);
                        p.UsaInventario = reader.GetBoolean(11);
                        p.Stock = reader.GetDecimal(12);
                        p.StockMinimo = reader.GetDecimal(13);
                        p.UnidadesPorPresentacion = reader.GetDecimal(15);
                        p.Venta = reader.GetString(17);

                    }
                    con.Close();

                    return p;

                }

            }
            catch (Exception ex)
            {
                return new ProductoVM();
            }
        }

        public static void Aumentar_DisminuirStock(ProductoVM p, string tipoActualizacion)
        {
            try
            {
                var producto = ObtenerProducto_x_Codigo(p.codigo,p.Venta);
                var productoBajo = producto;
                if (tipoActualizacion.Equals("DISMINUIR"))
                {
                    producto.Cantidad = (p.Venta.Equals("U"))
                                              ? producto.Stock - p.Cantidad
                                              : producto.Stock - (p.Cantidad * producto.UnidadesPorPresentacion);

                    ActualizarStock(producto);

                    if (productoBajo.Cantidad <= 0)
                    {
                        var entrada = ObtenerUltimaEntrada(p.Id, "VALIDAR_STOCK");
                        productoBajo.Stock = (entrada.TotalIngresado + producto.Cantidad);
                        productoBajo.Ganancia = entrada.GananciaMayoreo;
                        productoBajo.PrecioCompra = entrada.PrecioCompra;
                        productoBajo.Precio = (1 + (entrada.GananciaMayoreo / 100)) * entrada.PrecioCompra;
                        productoBajo.PrecioMayoreo = entrada.GananciaMayoreoM;

                        productoBajo.PrecioCompraU = (entrada.PrecioCompra / producto.UnidadesPorPresentacion);
                        productoBajo.GananciaU = entrada.GananciaMenudeo;
                        productoBajo.PrecioU = (1 + (entrada.GananciaMenudeo / 100)) * productoBajo.PrecioU;
                        productoBajo.PrecioMayoreoU = entrada.GananciaMayoreoU;
                        productoBajo.Cantidad = productoBajo.Stock;

                        ActualizarStock(productoBajo);
                        ActualizarPrecio(productoBajo);
                        Desactivar_EntradaProducto(entrada.Id);
                        AsignarEntradaActual_Producto(entrada);
                    }
                }
                else
                {
                    producto.Cantidad = (p.Venta.Equals("U"))
                                        ? producto.Stock + p.Cantidad
                                        : producto.Stock + (p.Cantidad * producto.UnidadesPorPresentacion);
                    ActualizarStock(producto);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static void ListarProductos_x_CodigoDescripcion(string busqueda, ref DataGridView grid, TIPO_VENTA tipoVenta)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("sp_ObtenerProductoVenta", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@articulo", busqueda);
                    da.SelectCommand.Parameters.AddWithValue("@tipoCodigo", tipoVenta.ToString());
                    da.Fill(dt);
                    grid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static void ActualizarStock(ProductoVM p)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_ActualizarStock", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@idProducto", p.Id);
                    sc.Parameters.AddWithValue("@cantidad", p.Cantidad);
                    sc.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {
                }
            }
        }

        public static void Desactivar_EntradaProducto(int id)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("UPDATE EntradaProducto SET Estatus = 0 WHERE Id=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {
            }
        }

        public static void AsignarEntradaActual_Producto(EntradaProductoVM entrada)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("UPDATE Producto SET IdEntrada = @idEntrada WHERE Id=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@idEntrada", entrada.Id);
                        cmd.Parameters.AddWithValue("@id", entrada.IdProducto);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {
            }
        }

        public static TIPO_VENTA ObtenerTipoVenta_Preferencial(int id, string presentacion)
        {
            string tipo = "";
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {

                    con.Open();
                    using (var cmd = new SqlCommand("ObtenerTipoVenta_PrecioPreferencial", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idProducto", id);
                        cmd.Parameters.AddWithValue("@presentacion", presentacion);
                        tipo = Convert.ToString(cmd.ExecuteScalar());

                    }
                    con.Close();
                }
            }
            catch (Exception)
            {
            }
            return (tipo == "M") ? TIPO_VENTA.M : TIPO_VENTA.U;
        }

        public static List<ProductoVM> Consultar_ProductosActualizados(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                var lst = new List<ProductoVM>();
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd =new SqlCommand("ObtenerProductosActualizados", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@inicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fin", fechaFin);

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ProductoVM p = new ProductoVM();
                            p.Id = reader.GetInt32(0);
                            p.Proveedor = reader.GetString(1);
                            p.Marca = reader.GetString(2);
                            p.Categoria = reader.GetString(3);
                            p.Presentacion = reader.GetString(4);
                            p.codigo = reader.GetString(5);
                            p.Articulo = reader.GetString(6);
                            p.Detalle = reader.GetString(7);
                            p.PrecioCompra = reader.GetDecimal(8);
                            p.Precio = reader.GetDecimal(9);
                            p.PrecioMayoreo = reader.GetDecimal(10);
                            p.A_Partir_De = reader.GetDecimal(11);
                            p.TipoVenta = reader.GetString(12);
                            p.UsaInventario = reader.GetBoolean(13);
                            p.StockMinimo = reader.GetDecimal(14);
                            p.Caducidad = Convert.ToDateTime( reader.GetString(15));
                            p.UnidadesPorPresentacion = reader.GetDecimal(16);
                            p.Venta = reader.GetString(17);
                            p.Clave = reader.GetString(18);
                            p.Peso = reader.GetDecimal(19);
                            lst.Add(p);
                        }

                    }
                    con.Close();
                }

                return lst;
            }
            catch (Exception)
            {
                return new List<ProductoVM>();
            }
        }

        public static void ListarProductos_StockBajos(ref DataGridView grid, string busqueda)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("sp_ListarStocksBajos", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@buscar", busqueda);
                    da.Fill(dt);
                    grid.DataSource = dt;

                }

            }
            catch (Exception ex)
            {
            }
        }

        public static void ListarProductos_Caducados(ref DataGridView grid, string tipo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("Listar_ProductosCaducados_PorCaducar", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@tipo", tipo);
                    da.Fill(dt);
                    grid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static void  ActivarDesactivar_Producto(int id, bool valor)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("pa_DesactivarProducto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@valor", valor);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                }
            }
        }

        public static void ListarProductos_Inactivos(ref DataGridView grid, string buscar)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("ProductosInactivos", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@busqueda",buscar );
                    da.Fill(dt);
                    grid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
