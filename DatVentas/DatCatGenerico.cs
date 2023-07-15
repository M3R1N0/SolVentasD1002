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

        public static List<CatalogoGenerico> ListarCat_TipoUsuario()
        {
            var lst = new List<CatalogoGenerico>();
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT * FROM Cat_Tipo_Usuario WHERE Estado = 1", conn))
                    {
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CatalogoGenerico c = new CatalogoGenerico();
                            c.Id = reader.GetInt32(0);
                            c.Nombre = reader.GetString(1);
                            c.Descripcion = reader.GetString(2);
                            c.Estado = reader.GetBoolean(3);

                            lst.Add(c);
                        }
                    }
                    conn.Close();
                }
                return lst;
            }
            catch (Exception)
            {
                return new List<CatalogoGenerico>();
            }
        }

        public static void ObtenerCatalogo_Presentacion( ref ComboBox comboBox, int id)
        {

            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    using (var adapter = new SqlDataAdapter("SELECT * FROM Cat_Tipo_Presentacion WHERE Estado = @estado", conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@estado", 1);
                        adapter.Fill(dt);

                        comboBox.DataSource = dt;
                        comboBox.DisplayMember = "Nombre";
                        comboBox.ValueMember = "Id_TipoPresentacion";
                        comboBox.SelectedValue = id;
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                }
            }
        }

        public static string Obtener_Presentacion_Abv(string presentacion)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    string resultado;
                    SqlCommand cmd = new SqlCommand($"SELECT NombreCorto FROM [Cat_Tipo_Presentacion]  WHERE Nombre='{presentacion}'", con);
                    con.Open();
                    resultado = Convert.ToString(cmd.ExecuteScalar());
                    con.Close();

                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CatalogoGenerico ObtenerPresentacion(int idPresentacion)
        {
            try
            {
                CatalogoGenerico presentacion = null;
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand($"SELECT * FROM [Cat_Tipo_Presentacion]  WHERE Id_TipoPresentacion={idPresentacion}", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        presentacion = new CatalogoGenerico();

                        presentacion.Id = reader.GetInt32(0);
                        presentacion.Nombre = reader.GetString(1);
                        presentacion.Descripcion = reader.GetString(2);
                        presentacion.Estado = reader.GetBoolean(3);

                    }

                    con.Close();

                    return presentacion;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ObtenerCatalogo_TipoProducto(ref ComboBox comboBox, int id)
        {

            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    using (var adapter = new SqlDataAdapter("SELECT * FROM Cat_Producto WHERE Estado = @estado", conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@estado", 1);
                        adapter.Fill(dt);

                        comboBox.DataSource = dt;
                        comboBox.DisplayMember = "Nombre";
                        comboBox.ValueMember = "Id_CatProducto";
                        comboBox.SelectedValue = id;

                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                }
            }
        }

        public static void ObtenerCatalogo_Proveedor(ref ComboBox comboBox,int id)
        {

            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    using (var adapter = new SqlDataAdapter("SELECT * FROM Proveedor WHERE Activo = 1", conn))
                    {
                        //adapter.SelectCommand.Parameters.AddWithValue("@estado", 1);
                        adapter.Fill(dt);

                        comboBox.DataSource = dt;
                        comboBox.DisplayMember = "Clave";
                        comboBox.ValueMember = "Id";
                        comboBox.SelectedValue = id;
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        public static void ObtenerCatalogo_Marcas(ref ComboBox comboBox, int id)
        {

            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    using (var adapter = new SqlDataAdapter("SELECT * FROM Cat_Marca WHERE Activo = 1", conn))
                    {
                        //adapter.SelectCommand.Parameters.AddWithValue("@estado", 1);
                        adapter.Fill(dt);

                        comboBox.DataSource = dt;
                        comboBox.DisplayMember = "Nombre";
                        comboBox.ValueMember = "Id";
                        comboBox.SelectedValue = id;
                    }
                }
                catch (Exception ex)
                {
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

        public void Insertar_InicioSesionRemoto ( string conexion ,string serialPC)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
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

        public static void Insertar_FormaPago(string tipoPago, string Descripcion)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand($"INSERT INTO Cat_FormaPago VALUES ('{tipoPago}', '{Descripcion}', '{true}')", conn);
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
        #endregion

        public int Insertar_Concepto(string concepto)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand($"INSERT INTO Cat_Concepto VALUES('{concepto}') ", conn);
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

        public int Editar_Concepto(string concepto, int id)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand($"UPDATE  Cat_Concepto SET Descripcion='{concepto}' WHERE Id_Concepto="+id, conn);
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

        public DataTable Buscar_Concepto(string concepto)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  Cat_Concepto WHERE Descripcion  like '%" + concepto + "%'", conn);
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

        #region BITACORA CLIENTE CRÉDITO POR PAGAR

        public static void Agregar_BitacoraCliente(int idVenta, int idUsuario, decimal monto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    SqlCommand cmd = new SqlCommand("sp_AgregarBitacora_CreditoCliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idventa", idVenta);
                    cmd.Parameters.AddWithValue("@idusuario", idUsuario);
                    cmd.Parameters.AddWithValue("@monto", monto);

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

        public  DataTable ObtenerLista_BitacoraCliente(string cliente)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter($" EXEC sp_Listar_BitacoraCredito '{cliente}'", con);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ObtenerDetalle_BitacoraCliente(int idVenta)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter($" EXEC sp_obtenerDetalle_BitacoraCredito {idVenta}", con);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Decimal ObtenerPago_CreditoAbonado(int idusuario)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    Decimal montoAbonado = 0;
                    SqlCommand cmd = new SqlCommand($" exec sp_ObtenerMonto_CreditoCobrar {idusuario}", con);
                    con.Open();
                    montoAbonado = Convert.ToDecimal(cmd.ExecuteScalar());
                    con.Close();
                    return montoAbonado;
                }
            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
        }

        #endregion

        public bool GenerarRespaldo (string rutaCarpeta, string nombreRespaldo)
        {
            bool resultado = false;
            try
            {
              
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    

                    SqlCommand cmd = new SqlCommand("BACKUP DATABASE DBVENTAS TO DISK='"+rutaCarpeta+@"\"+nombreRespaldo+ "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                     return resultado = true;
                }
            }
            catch (Exception ex)
            {
                return resultado = false;
                throw ex;
            }
        }

        public static void  AgregarBitácora(Bitacora b)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregarBitacora",con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fecha", b.Fecha);
                    cmd.Parameters.AddWithValue("@idusuario", b.IdUsuario);
                    cmd.Parameters.AddWithValue("@idcaja", b.IdCaja);
                    cmd.Parameters.AddWithValue("@accion", b.Accion);
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<CatalogoGenerico> ListarCatalogo_TipoVenta()
        {
            var lst = new List<CatalogoGenerico>();
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand sc = new SqlCommand("SELECT Id,Detalle FROM TipoVenta", conn);
                        var reader = sc.ExecuteReader();

                        while (reader.Read())
                        {
                            CatalogoGenerico c = new CatalogoGenerico();
                            c.Id = reader.GetInt32(0);
                            c.Nombre = reader.GetString(1);

                            lst.Add(c);
                        }
                        conn.Close();

                        return lst;
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        throw ex;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int ObtenerIdentificador_Catalogo(string nombre, TIPO_CATALOGO TIPO)
        {
            try
            {
                string query = "";
                switch (TIPO)
                {
                    case TIPO_CATALOGO.CATEGORIA:
                        query = "SELECT Id_CatProducto FROM Cat_Producto WHERE UPPER(Nombre) = @nombre";
                        break;
                    case TIPO_CATALOGO.MARCA:
                        query = "SELECT Id FROM Cat_Marca WHERE UPPER(Nombre) = @nombre";
                        break;
                    case TIPO_CATALOGO.PROVEEDOR:
                        query = "SELECT Id FROM Proveedor WHERE UPPER(Nombre) = @nombre";
                        break;
                    case TIPO_CATALOGO.PRESENTACION:
                        query = "SELECT Id_TipoPresentacion FROM Cat_Tipo_Presentacion WHERE UPPER(Nombre) = @nombre";
                        break;
                    default:
                        break;
                }
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand(query,con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    con.Close();
                }
            }
            catch (Exception )
            {
                return 1;
            }
        }

        public static void Guardar_Sucursal(CatalogoGenerico c)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("INSERT INTO Cat_Sucursal VALUES(@nombre,@direccion,@activo)", conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                        cmd.Parameters.AddWithValue("@direccion", c.Descripcion);
                        cmd.Parameters.AddWithValue("@activo", c.Estado);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();

                }
                catch (Exception ex)
                {
                }
            }
        }

        public static void ObtenerSucursales(ref ComboBox combo)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    using (var adapter = new SqlDataAdapter("SELECT * FROM Cat_Sucursal WHERE Activo = @activo", conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@activo", true);
                        adapter.Fill(dt);

                        combo.DataSource = dt;
                        combo.DisplayMember = "Nombre";
                        combo.ValueMember = "Id";
                    }
                    conn.Close();

                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
