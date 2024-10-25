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
    public class DatVenta
    {
        //================================================================================================================
        public int InsertarVenta(Venta v)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("[sp_insertarVenta]", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@idcliente", v.IdCliente);
                    sc.Parameters.AddWithValue("@idusuario", v.IdUsuario);
                    sc.Parameters.AddWithValue("@idcaja", v.IdCaja);
                    sc.Parameters.AddWithValue("@fechaventa", v.FechaVenta);
                    sc.Parameters.AddWithValue("@folio", v.Folio);
                    sc.Parameters.AddWithValue("@montototal", v.MontoTotal);
                    sc.Parameters.AddWithValue("@formapago", v.FormaPago);
                    sc.Parameters.AddWithValue("@estadopago", v.EstadoPago);
                    sc.Parameters.AddWithValue("@comprobante", v.Comprobante);
                    sc.Parameters.AddWithValue("@fechaliquidacion", v.FechaLiquidacion);
                    sc.Parameters.AddWithValue("@accion", v.Accion);
                    sc.Parameters.AddWithValue("@saldo", v.Saldo);
                    sc.Parameters.AddWithValue("@tipopago", v.TipoPago);
                    sc.Parameters.AddWithValue("@referenciatarjeta", v.ReferenciaTarjeta);
                    sc.Parameters.AddWithValue("@vuelto", v.Vuelto);
                    sc.Parameters.AddWithValue("@efectivo", v.Recibo);
                    sc.Parameters.AddWithValue("@comentarios", v.Comentarios);
                    sc.Parameters.AddWithValue("@idventa", v.Id);

                    if (v.Id == 0)
                    {
                        resultado =  Convert.ToInt32(sc.ExecuteScalar());
                    }
                    else
                    {
                        sc.ExecuteNonQuery();
                    }
                    conn.Close();
                    return resultado;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió detalle al guardar los datos de la venta\n Detalle: "+ex.Message);
                }
            }
        }

        public DataTable ObtenerComrpobante(string textoNumero)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_Mostrar_TicketImpreso]", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@letranumero", textoNumero);
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

        public static void Obtener_VentasEnEspera(ref DataGridView grid, string serialPc)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    var dt = new DataTable();
                    using (var da = new SqlDataAdapter("ObtenerVenta_EnEspera",con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@SerialPC",serialPc);
                        da.Fill(dt);
                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public bool EliminarVenta(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("DELETE FROM tb_Ventas WHERE Id_Venta=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable ObtenerVenta_Total(DateTime cierre, int idusuario, int idcaja)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("sp_ObtenerDatos_VentasTotales", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@cierre", cierre);
                    da.SelectCommand.Parameters.AddWithValue("@idusuario", idusuario);
                    da.SelectCommand.Parameters.AddWithValue("@idcaja", idcaja);
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Venta> ObtenerVenta_TotalPorCaja(DateTime fechaInicio)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {

                    List<CatalogoGenerico> lst = DatOpenCloseBox.ObtenerCajas_PorFecha(fechaInicio);

                    DateTime fechaFin = fechaInicio.AddDays(1);
                    List<Venta> lstCaja = new List<Venta>();
                   
                    foreach (CatalogoGenerico item in lst)
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SP_OBTENERVENTAS_PORCAJA", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idcaja", item.Id);
                        cmd.Parameters.AddWithValue("@inicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fin", fechaFin);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Venta obj = new Venta();

                            obj.FechaVenta = reader.GetDateTime(0);
                            obj.MontoTotal = reader.GetDecimal(1);
                            obj.FormaPago = reader.GetString(2);
                            obj.EstadoPago = reader.GetString(3);
                            obj.Accion = reader.GetString(4);
                            obj.Comentarios = reader.GetString(5); // ------> DESCRIPCION
                            obj.Saldo = reader.GetDecimal(6); // -----------> BONIFICACION
                            obj.Vuelto = reader.GetDecimal(7); // ----------> CAJA INICIAL
                            obj.IdCaja = reader.GetInt32(8); // ------------> ID CAJA

                            lstCaja.Add(obj);
                        }
                        conn.Close();
                    }

                   

                    return lstCaja;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ObtenerVentas_PorCobrar(ref DataGridView grid,string buscar)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();
                    using (var da = new SqlDataAdapter("Filtrar_NotasPorCobrar", con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@busqueda", buscar);

                        da.Fill(dt);
                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception )
            {
            }
        }

        public int Actualizar_CreditoPorPagar(int idventa, decimal saldo, string EstadoPago, decimal efectivo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    int _filasAfectadas;

                    SqlCommand cmd = new SqlCommand($"UPDATE tb_Ventas SET Estado_Pago='{EstadoPago}', Saldo={saldo}, Vuelto={saldo}, Efectivo={efectivo} WHERE Id_Venta={idventa}", con);
                    con.Open();
                    _filasAfectadas = cmd.ExecuteNonQuery();
                    con.Close();

                    return _filasAfectadas;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Obtener_ComprobanteCredito(int idventa , decimal abonado)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter($"exec sp_Comprobante_PagoCredito {idventa}, {abonado}", con);
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ParametrosReporte ObtenerDatos_ComrpobanteCredito(int idventa, decimal abonado)
        {
            try
            {
                ParametrosReporte obj = null;
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"sp_Comprobante_PagoCredito", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idVenta", idventa);
                    cmd.Parameters.AddWithValue("@abono", abonado);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        obj = new ParametrosReporte();
                        obj.Ticket = reader.GetString(0);
                        obj.Folio = reader.GetString(1);
                        obj.EstadoPago = reader.GetString(2);
                        obj.MontoTotal = reader.GetDecimal(3);
                        obj.Saldo = reader.GetDecimal(4);
                        obj.FechaVenta = reader.GetDateTime(5);
                        obj.Cajero = reader.GetString(6);
                        obj.Cliente = reader.GetString(7);
                        obj.DireccionCliente = reader.GetString(8);
                        obj.NombreEmpresa = reader.GetString(9);
                        obj.LogoEmpresa = (byte[])(reader["Logo"]);
                        obj.Agradecimiento = reader.GetString(11);
                        obj.Anuncio = reader.GetString(12);
                        obj.Direccion = reader.GetString(13);
                        obj.PaginaWeb = reader.GetString(14);
                        obj.Provincia = reader.GetString(15);
                        obj.Abonado = reader.GetDecimal(16);
                    }
                    con.Close();

                    return obj;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Total_VentasRealizadas()
        {
            int resultado = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand("select count(Id_Venta) from tb_Ventas", con);
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

        public static int Total_VentasCredito()
        {
            int resultado = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand("select count(Id_Venta) from tb_Ventas where Estado_Pago ='PENDIENTE'", con);
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

        public static void DatosGrafica(ref DataTable dtDatos)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_GraficaVenta", con);
                    da.Fill(dtDatos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Filtrar_DatosGrafica(ref DataTable dtDatos, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_Filtros_GraficaVenta", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@fechainicio", fechaInicio);
                    da.SelectCommand.Parameters.AddWithValue("@fechafin", fechaFin);

                    da.Fill(dtDatos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Grafica_ClienteFrecuente(ref DataTable dtDatos)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_ClientesFrecuentes", con);
                    da.Fill(dtDatos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObtenerTickets(DateTime inicio, DateTime fin, string buscar)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter("sp_ObtenerTickets_PorFecha", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@inicio", inicio);
                    da.SelectCommand.Parameters.AddWithValue("@fin", fin);
                    da.SelectCommand.Parameters.AddWithValue("@buscar", buscar);
                    da.Fill(dt);

                    return dt;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Venta ObtenerVenta(int idVenta)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    Venta v = new Venta();

                    con.Open();
                    using (var cmd = new SqlCommand($"SELECT * FROM tb_Ventas WHERE Id_Venta=@idVenta", con))
                    {
                        cmd.Parameters.AddWithValue("@idVenta", idVenta);

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            v.Id = reader.GetInt32(0);
                            v.MontoTotal = reader.GetDecimal(1);
                            v.Saldo = reader.GetDecimal(2);
                            v.Vuelto = reader.GetDecimal(3);
                            v.MontoTotal = reader.GetDecimal(4);
                            v.Efectivo = reader.GetDecimal(5);
                        }
                    }
                    con.Close();
                   
                    return v;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EditarDatos_Devoluciones(Venta v)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand($"UPDATE tb_Ventas SET Monto_total={v.MontoTotal}, Saldo={v.Saldo}, Vuelto={v.Vuelto},Estado_Pago='{v.EstadoPago}', Accion='{v.Accion}' WHERE Id_Venta={v.Id}", con);
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

        public static DataTable ListarClientes_TotalALquidar()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter("EXEC sp_ListarClientes_TotalPorLiquidar", conn);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static  ParametrosReporte Consultar_Ticket_Parametro(int idVenta)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    decimal bonificacion = 0;
                    ParametrosReporte obj = new ParametrosReporte();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("[sp_ObtenerTicket]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idVentas", idVenta);
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        obj.NombreEmpresa = reader.GetString(0);
                        obj.LogoEmpresa =(byte[])(reader["Logo"]);
                        obj.Agradecimiento = reader.GetString(2);
                        obj.Anuncio = reader.GetString(3);
                        obj.Direccion = reader.GetString(4);
                        obj.PaginaWeb = reader.GetString(5);
                        obj.Provincia = reader.GetString(6);
                        obj.FechaVenta = reader.GetDateTime(7);
                        obj.MontoTotal = reader.GetDecimal(8);
                        obj.Cajero = reader.GetString(9);
                        obj.Cliente = reader.GetString(10);
                        obj.DireccionCliente = reader.GetString(11);
                        obj.TotalProducto = reader.GetInt32(12);
                        obj.Folio = reader.GetString(13);
                        obj.FormaPago = reader.GetString(14);
                        obj.Cambio = reader.GetDecimal(15);
                        obj.Efectivo = reader.GetDecimal(16);
                        obj.Id = reader.GetInt32(17);
                        obj.IdDetalleVenta = reader.GetInt32(18);
                        obj.Ruc = reader.GetString(19);
                        obj.Comentarios = reader.GetString(20);
                        obj.EstadoVenta = reader.GetString(21);
                        obj.SubEncabezado = reader.GetString(22);
                        obj.NotaPieTicket = reader.GetString(23);
                    }
                    conn.Close();


                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("[sp_ObtenerDetalleVenta]", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@idventa", obj.Id);
                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    List<DetalleVenta> lst = new List<DetalleVenta>();
                    while (reader2.Read())
                    {
                        DetalleVenta d = new DetalleVenta();
                        d.Cantidad = reader2.GetDecimal(0);
                        d.UnidadMedida = reader2.GetString(1);
                        d.Descripcion = reader2.GetString(2);
                        d.Precio = reader2.GetDecimal(3);
                        d.TotalPago = reader2.GetDecimal(4);

                        lst.Add(d);
                        
                    }
                    conn.Close();
                    obj.lstDetalleVenta = lst;


                    conn.Open();
                    SqlCommand cmd3 = new SqlCommand($"SELECT ISNULL (SUM(B.Bonificacion), 0) FROM tb_Bonificacion B where Venta_Id ={idVenta}", conn);
                    bonificacion = Convert.ToDecimal(cmd3.ExecuteScalar());

                    obj.Bonificacion = bonificacion;
                    return obj;

                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw ex;
                }
            }
        }

        #region BONIFICACION 

        public static ParametrosReporte Obtnener_DatosBonificacion(int idVenta)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    ParametrosReporte obj = new ParametrosReporte();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("[SP_ObtenerDatos_Bonificacion]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idventa", idVenta);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        obj.Id = reader.GetInt32(0);
                        obj.FechaVenta = reader.GetDateTime(1);
                        obj.Folio = reader.GetString(2);
                        obj.MontoTotal = reader.GetDecimal(3);
                        obj.FormaPago = reader.GetString(4);
                        obj.EstadoPago = reader.GetString(5);
                        obj.Saldo = reader.GetDecimal(6);
                        obj.Cambio = reader.GetDecimal(7);
                        obj.Efectivo = reader.GetDecimal(8);
                        obj.IdDetalleVenta = reader.GetInt32(9);
                        obj.DireccionCliente = reader.GetString(10);
                        obj.Cliente = reader.GetString(11);
                        obj.Cajero = reader.GetString(12);
                        obj.NombreEmpresa = reader.GetString(14);
                        obj.Agradecimiento = reader.GetString(15);
                        obj.Anuncio = reader.GetString(16);
                        obj.Direccion = reader.GetString(17);
                        obj.Provincia = reader.GetString(18);
                    }
                    conn.Close();

                    return obj;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw ex;
                }
            }
        }

        public static void AgregarBonificacion(Venta v)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_AgregarBonificacion", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idcliente", v.IdCliente);
                    cmd.Parameters.AddWithValue("@idventa", v.Id);
                    cmd.Parameters.AddWithValue("@idusuario", v.IdUsuario);
                    cmd.Parameters.AddWithValue("@idcaja", v.IdCaja);
                    cmd.Parameters.AddWithValue("@bonificacion", v.Vuelto);
                    cmd.Parameters.AddWithValue("@detalle", v.Accion);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static ParametrosReporte ObtenerBonificacion_PorUsuario(int idusuario, int idCaja)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    ParametrosReporte obj = null;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("[sp_ObtenerBonificacionPorUsuario]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.Parameters.AddWithValue("@idcaja", idCaja);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        obj = new ParametrosReporte();
                        obj.TotalProducto = reader.GetInt32(0);
                        obj.Bonificacion = reader.GetDecimal(1);
                    }
                    conn.Close();

                    return obj;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw ex;
                }
            }
        }

        public static DataTable ListarBonificaiones(DateTime inicio, DateTime fin, string buscar)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter("sp_ObtenerDatosBonificaciones", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@inicio", inicio);
                    da.SelectCommand.Parameters.AddWithValue("@fin", fin);
                    da.SelectCommand.Parameters.AddWithValue("@buscar", buscar);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        public static DataTable ListarReporteVentas_PorCliente(int id)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {

                    SqlDataAdapter da = new SqlDataAdapter("SP_ObtenerReporteVenta_cliente", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@idcliente", id);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        public static void Editar_FormaPago(int idventa, decimal montoTotal)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"UPDATE tb_Ventas SET Forma_Pago = 'Credito', Estado_Pago = 'PENDIENTE',Efectivo = 0, Saldo ={montoTotal}, Vuelto = {montoTotal} WHERE Id_Venta ={idventa}",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Actualizar_EstadoVenta(int idVenta, string estado)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("UPDATE tb_Ventas SET Accion = @estado WHERE Id_Venta=@id",con))
                    {
                        cmd.Parameters.AddWithValue("@estado",estado.ToUpper());
                        cmd.Parameters.AddWithValue("@id",idVenta);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {
            }
        }

        public static void FiltrarGanancia_PorPeriodo(ref DataGridView grid, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    using (var da = new SqlDataAdapter("listarGanancia_PorPeriodos", con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        da.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFin);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        #region DEVOLUCIONES DE PRODUCTOS VENDIDOS

        public static void BuscarVenta(ref DataGridView grid,string busqueda)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();
                    using (var da = new SqlDataAdapter("sp_BuscarVenta", con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@buscar", busqueda);
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static void ActualizarTotalVenta(int idVenta, decimal total)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var command = new SqlCommand("sp_ActualizarTotalVenta", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idVenta", idVenta);
                        command.Parameters.AddWithValue("@monto", total);

                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        #endregion
    }

}
