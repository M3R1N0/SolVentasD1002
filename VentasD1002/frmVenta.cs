using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        public static int idCliente;

        private void frmVenta_Load(object sender, EventArgs e)
        {
            try
            {
                //SerialPC = Sistema.ObenterSerialPC();
                //idCaja = BusBox.ObtenerCajaPorSerial(SerialPC).Id;
                var ser = "DGc4WsydMGelIz+a9PorWg==";
                var sssss = "50026B778488E74D";
                var sss = EncriptarTexto.Desencriptar(sssss);
                Listar_FormaPago();
                Mostrar_TipoComprobante();
                ObtenerFolioDocumento();
                iniciarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region INFORMACION INICIAL

        private void Listar_FormaPago()
        {
            try
            {
                try
                {
                    DataTable dtFormaPago = DatCatGenerico.ObtenerCatalogo_FormaPago();
                    cboFormaPago.DataSource = dtFormaPago;
                    cboFormaPago.ValueMember = "Id_TipoPago";
                    cboFormaPago.DisplayMember = "Tipo_Pago";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar los datos Tipo de pago " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mostrar_TipoComprobante()
        {
            try
            {
                DataTable dt = DatSerializacion.ObtenerComprobantes_Ventas();
                cboTipoDoc.DataSource = dt;
                cboTipoDoc.ValueMember = "Id_Serializacion";
                cboTipoDoc.DisplayMember = "Tipo_Documento";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los comprobantes : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerFolioDocumento()
        {
            try
            {
                int numero = 0;
                if (!String.IsNullOrEmpty(cboTipoDoc.Text) || cboTipoDoc.Text != "System.Data.DataRowView")
                {
                    Serializacion serializacion = DatSerializacion.ObtenerComprobante(cboTipoDoc.Text);

                    numero = Convert.ToInt32(serializacion.NumeroFin) + 1;
                    string folio = Formato_FolioVenta.FormatoFolio(numero.ToString(), Convert.ToInt32(serializacion.Cantidad_Numero));
                    lblFolio.Text = serializacion.Serie + "-" + folio;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al obtener el folio del comprobante : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerFolioDocumento();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtCliente.Text))
                {
                    List<Cliente> ls = new BusCliente().ListarClientes(txtCliente.Text);
                    gdvClientes.DataSource = ls;
                    gdvClientes.Visible = true;

                    gdvClientes.Columns[0].Visible = false;
                    gdvClientes.Columns[2].Visible = false;
                    gdvClientes.Columns[3].Visible = false;
                    gdvClientes.Columns[4].Visible = false;
                    gdvClientes.Columns[5].Visible = false;
                    gdvClientes.Columns[6].Visible = false;
                    gdvClientes.Columns[7].Visible = false;
                    gdvClientes.Columns[8].Visible = false;

                    if (cboFormaPago.Text.Equals("Credito") || cboFormaPago.Text.Equals("credito") || cboFormaPago.Text.Equals("CREDITO"))
                        txtCreditoAutorizado.Text = gdvClientes.SelectedCells[7].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos del cliente" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCliente.Text = gdvClientes.SelectedCells[1].Value.ToString();
                idCliente = Convert.ToInt32(gdvClientes.SelectedCells[0].Value.ToString());
                gdvClientes.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCliente_MouseClick(object sender, MouseEventArgs e)
        {
            txtCliente.SelectAll();
        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.Equals(cboFormaPago.Text, "CREDITO", StringComparison.OrdinalIgnoreCase))
            {
                Cliente cliente = BusCliente.ObtenerCliente(idCliente);
                txtCreditoAutorizado.Text = cliente.Saldo.ToString();
            }
            else
            {
                txtCreditoAutorizado.Text = "N/A";
            }

        }

        private void iniciarDatos()
        {

            cboFormaPago.SelectedValue = 1;
            cboTipoDoc.SelectedValue = 1;
            CboTipoPrecio.SelectedItem = "MAYOREO";

            Cliente cliente = DatCliente.ObtenerCliente_General();
            txtCliente.Text = cliente.NombreCompleto;
            idCliente = cliente.Id;
            gdvClientes.Visible = false;
            gdvBuscar.Visible = false;

        }

        #endregion

        #region MENU SUPERIOR

        private void VentaEnEsperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<VentaEspera> lstVentas = new BusVentas().Listar_VentasEnEspera();

            if (lstVentas.Count != 0)
            {
                frmVentasEnEspera ventasEnEspera = new frmVentasEnEspera();
               // ventasEnEspera.FormClosing += frm_FormClosing;
                ventasEnEspera.ShowDialog();
            }
            else
            {
                MessageBox.Show("Actualmente no existen ventas en Espera", "Ventas en Espera", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void créditosPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreditosCobrar creditosCobrar = new frmCreditosCobrar();
            creditosCobrar.ShowDialog();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReimprimirTicket frmReimprimir = new frmReimprimirTicket();
            frmReimprimir.ShowDialog();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevoluciones devoluciones = new frmDevoluciones();
            devoluciones.ShowDialog();
        }

        private void productoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInventarioKardex kardex = new frmInventarioKardex();
            kardex.ShowDialog();
        }

        private void panelDeControlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BusUser.ValidarPerfil_Usuario())
            {
                this.Hide();
                frmDashboard dashboard = new frmDashboard();
                dashboard.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No tiene los privilegios para acceder al módulo", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cerrarTurnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmCierreCaja cierreCaja = new frmCierreCaja();
                cierreCaja.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Producto> lstProducto;

                if (String.IsNullOrEmpty(txtBuscar.Text))
                {
                    gdvBuscar.Visible = false;
                }
                else
                {

                    if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
                    {
                        gdvBuscar.Visible = true;
                        DataTable dt = new DataTable();
                        lstProducto = new BusProducto().ListarProductos(txtBuscar.Text, 0);
                        gdvBuscar.DataSource = lstProducto;


                        gdvBuscar.Rows[0].Selected = true;
                        gdvBuscar.Columns[5].Width = 450;
                        if (CboTipoPrecio.Text == "MENUDEO")
                        {
                            gdvBuscar.Columns[7].Visible = true;
                            gdvBuscar.Columns[8].Visible = false;
                            gdvBuscar.Columns[10].Visible = false;

                        }
                        else if (CboTipoPrecio.Text == "MEDIO MAYOREO")
                        {
                            gdvBuscar.Columns[7].Visible = false;
                            gdvBuscar.Columns[8].Visible = true;
                            gdvBuscar.Columns[10].Visible = false;
                        }
                        else
                        {
                            gdvBuscar.Columns[7].Visible = false;
                            gdvBuscar.Columns[8].Visible = false;
                            gdvBuscar.Columns[10].Visible = true;
                        }

                        gdvBuscar.Columns[0].Visible = false;
                        gdvBuscar.Columns[1].Visible = false;
                        gdvBuscar.Columns[2].Visible = false;
                        gdvBuscar.Columns[3].Visible = false;

                        gdvBuscar.Columns[5].Visible = false;
                        gdvBuscar.Columns[6].Visible = false;
                        //gdvBuscar.Columns[7].Visible = false;
                        //gdvBuscar.Columns[8].Visible = false;
                        gdvBuscar.Columns[9].Visible = false;
                        //gdvBuscar.Columns[10].Visible = false;
                        gdvBuscar.Columns[11].Visible = false;
                        gdvBuscar.Columns[12].Visible = false;
                        gdvBuscar.Columns[13].Visible = false;
                        gdvBuscar.Columns[14].Visible = false;
                        gdvBuscar.Columns[15].Visible = false;
                        gdvBuscar.Columns[16].Visible = false;
                        gdvBuscar.Columns[17].Visible = false;
                        gdvBuscar.Columns[18].Visible = false;
                        gdvBuscar.Columns[19].Visible = false;

                        gdvBuscar.Rows[0].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // lstProducto = null;
                //  MessageBox.Show("El producto ingresado no existe!,\n verifique que haya ingresado corectamente los datos", "BUSQUEDA FALLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //     txtBuscar.SelectAll();
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
                    {
                        string _producto = gdvBuscar.CurrentCell.Value.ToString();
                        Producto producto = new BusProducto().ObtenerProducto(_producto);
                        if (producto != null)
                        {
                            VerificarProducto(producto);
                        }
                        else
                        {
                            MessageBox.Show("El producto no Existe, Verifique que haya ingresado un producto válido", "Entrada  Inconrrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtBuscar.Text = string.Empty;
                            txtBuscar.Focus();
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("El producto que intenta ingresar no existe", "Producto no Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void VerificarProducto(Producto producto)
        {
            try
            {
                Respuesta respuesta = BusVentas.ValidarTipoPrecio(CboTipoPrecio.Text, producto);

                if (respuesta.Exito == 0)
                {
                    MessageBox.Show(respuesta.Mensaje, respuesta.TipoMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscar.Text = "";
                    txtBuscar.Focus();
                }
                else
                {
                    AgregarProducto_A_Venta(producto);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al Verificar el producto : " + ex.Message, "Error de verificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AgregarProducto_A_Venta(Producto producto)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("PRESENTACION_ID", typeof(System.Int32));//0
            dt.Columns.Add("ID", typeof(System.Int32));             //1
            dt.Columns.Add("CANTIDAD", typeof(System.Decimal));     //2
            dt.Columns.Add("UNIDAD", typeof(System.String));        //3
            dt.Columns.Add("CONCEPTO");                             //4
            dt.Columns.Add("PZA X CAJA");                           //5
            dt.Columns.Add("PRESENTACIÓN");                         //6
            dt.Columns.Add("PRECIO", typeof(System.Decimal));       //7
            dt.Columns.Add("IMPORTE", typeof(System.Decimal));      //8
            dt.Columns.Add("STOCK", typeof(System.Decimal));        //9
            dt.Columns.Add("CODIGO");                               //10
            dt.Columns.Add("USAINVENTARIO");                        //11
            dt.Columns.Add("APARTIR");                              //12
            DataRow dr = dt.NewRow();

            string unidad = "";
            decimal precio = 0;
            decimal _totalUnidades = 0;
            string _unidad = "";

            try
            {

                BusVentas.ValidarProducto(ref producto, ref precio, ref _totalUnidades, ref unidad, CboTipoPrecio.Text);

                var _usaInventario = producto.usaInventario;
                Decimal _ApartirDe = producto.APartirDe;


                if (gdvVentas.Rows.Count == 0)
                {
                    if (Convert.ToDecimal(producto.stock) < 1 && _usaInventario == "SI")
                    {
                        gdvBuscar.Visible = false;
                        // timer1.Start();
                    }
                    else
                    {
                        int id = producto.Id;
                        string _strProducto = producto.Descripcion;


                        dr["PRESENTACION_ID"] = producto.IdTipoPresentacion;
                        dr["ID"] = producto.Id;
                        dr["CANTIDAD"] = 1;
                        dr["UNIDAD"] = unidad;
                        dr["CONCEPTO"] = _strProducto;
                        dr["PZA X CAJA"] = producto.TotalUnidades;
                        dr["PRESENTACIÓN"] = producto.Presentacion;
                        dr["PRECIO"] = precio;
                        dr["IMPORTE"] = precio;
                        dr["STOCK"] = _usaInventario.Equals("SI") ? (Convert.ToDecimal(producto.stock) - _totalUnidades).ToString() : "123456";
                        dr["CODIGO"] = producto.codigo;
                        dr["USAINVENTARIO"] = producto.usaInventario;
                        dr["APARTIR"] = producto.APartirDe;

                        dt.Rows.Add(dr);
                        txtBuscar.Text = "";
                        gdvVentas.DataSource = dt;
                        DataTablePersonalizado.Multilinea2(ref gdvVentas);
                        gdvVentas.Columns[0].Visible = false;
                        gdvVentas.Columns[1].Visible = false;
                        gdvVentas.Columns[3].ReadOnly = true;
                        gdvVentas.Columns[4].ReadOnly = true;
                        gdvVentas.Columns[5].Visible = false;
                        gdvVentas.Columns[6].ReadOnly = true;
                        gdvVentas.Columns[7].ReadOnly = true;
                        gdvVentas.Columns[9].Visible = false;
                        gdvVentas.Columns[10].Visible = false;
                        gdvVentas.Columns[11].Visible = false;
                        gdvVentas.Columns[12].Visible = false;
                    }
                }
                else
                {
                    DataTable dt2 = new DataTable();
                    dt2 = gdvVentas.DataSource as DataTable;

                    int codigo = producto.Id;// lstProducto.Select(x => x.Id).FirstOrDefault();
                    DataRow[] d = dt2.Select($"ID={codigo} and UNIDAD ='{unidad}'"); //VERIFICA SI EXISTE EL ID A INGRESAR
                    string _auxUnidad = d.Length == 0 ? "" : d[0].Field<string>("UNIDAD");
                    DataRow[] productos = dt2.Select($"ID={codigo}");

                    decimal sumaStock = 0;
                    if (productos.Length == 1)
                    {
                        sumaStock = (from DataRow dtr in productos
                                     select dtr.Field<Decimal>("STOCK")).Sum();
                    }

                    if (d.Length == 1 && unidad.Equals(_auxUnidad))
                    {
                        //d[0].SetField("STOCK", sumaStock);
                        decimal stock = d[0].Field<decimal>("STOCK");
                        decimal cantidad = d[0].Field<decimal>("CANTIDAD");
                        decimal SUBTOTAL = d[0].Field<decimal>("IMPORTE");
                        decimal PRECIO = d[0].Field<decimal>("PRECIO");
                        if (stock >= cantidad + 1 && _totalUnidades < stock)
                        {
                            decimal _precionMM = producto.precioMMayoreo;// lstProducto.Select(x => x.precioMMayoreo).FirstOrDefault();
                            decimal _sumaCantidad = cantidad + 1;
                            if (_precionMM != 0 && _sumaCantidad >= _ApartirDe)
                            {
                                PRECIO = _precionMM;
                                d[0].SetField("PRECIO", PRECIO);
                            }

                            d[0].SetField("CANTIDAD", _sumaCantidad);
                            d[0].SetField("IMPORTE", PRECIO * _sumaCantidad);
                            d[0].SetField("STOCK", (stock - _totalUnidades));
                            txtBuscar.Text = "";

                        }
                        else
                        {
                            gdvBuscar.Visible = false;
                            // timer1.Start();
                        }
                    }
                    else
                    {
                        producto.stock = (Convert.ToDecimal(sumaStock) == 0) ? producto.stock : sumaStock.ToString();

                        if (Convert.ToDecimal(producto.stock) < 1 && _usaInventario == "SI")
                        {
                            gdvBuscar.Visible = false;
                            //timer1.Start();
                        }
                        else
                        {
                            DataRow dr2 = dt2.NewRow();
                            int id = producto.Id;

                            dr2["PRESENTACION_ID"] = producto.IdTipoPresentacion;
                            dr2["ID"] = producto.Id;
                            dr2["CANTIDAD"] = 1;
                            dr2["UNIDAD"] = unidad;
                            dr2["CONCEPTO"] = producto.Descripcion;
                            dr2["PZA X CAJA"] = producto.TotalUnidades;
                            dr2["PRESENTACIÓN"] = producto.Presentacion;
                            dr2["PRECIO"] = precio;
                            dr2["IMPORTE"] = precio;
                            dr2["STOCK"] = _usaInventario.Equals("SI") ? (Convert.ToDecimal(producto.stock) - _totalUnidades).ToString() : "123456";
                            dr2["CODIGO"] = producto.codigo;
                            dr2["USAINVENTARIO"] = producto.usaInventario;
                            dr2["APARTIR"] = producto.APartirDe;

                            dt2.Rows.Add(dr2);
                            txtBuscar.Text = "";
                        }
                    }
                }
                // }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al ingresar los datos a la venta" + ex.Message, "ERROR DE ENTRADA DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SumaTotal_a_Pagar();
                DataTablePersonalizado.Multilinea2(ref gdvVentas);
            }
        }

        private void SumaTotal_a_Pagar()
        {
            decimal sumatoria = 0;
            int filas = 0;
            foreach (DataGridViewRow dr in gdvVentas.Rows)
            {
                sumatoria += Convert.ToDecimal(dr.Cells["IMPORTE"].Value);
            }
            //lblTotal.Text = sumatoria.ToString("#,#.#0");
            txtProductosVendidos.Text = gdvVentas.Rows.Count.ToString();


        }

        private void gdvBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    txtBuscar.Text = string.Empty;
                    txtBuscar.Focus();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
                    {
                        decimal precio = 0;
                        string tipoPrecio = "";

                        Producto producto;

                        string _producto = gdvBuscar.CurrentCell.Value.ToString();
                        producto = new BusProducto().ObtenerProducto(_producto);

                        VerificarProducto(producto);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtBuscar.Text = string.Empty;
                txtBuscar.Focus();
            }
        }

        private void gdvVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal cantidad;
            decimal precio;
            decimal stock;
            string _strCodigo;
            decimal _ApartiDe;
            decimal _precioMM;
            decimal _precioActual;
            string _strPresentacion;
            String _strUnidadMedida;
            decimal _auxCantidad = 0;
            if (gdvVentas.Columns[e.ColumnIndex].Name == "CANTIDAD")
            {
                try
                {
                    stock = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[9].Value.ToString());
                    _strUnidadMedida = gdvVentas.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cantidad = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[2].Value.ToString());
                    _strCodigo = gdvVentas.Rows[e.RowIndex].Cells[10].Value.ToString();
                    _ApartiDe = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[12].Value.ToString());
                    _precioActual = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[7].Value.ToString());

                    Producto p = new BusProducto().ObtenerProducto(_strCodigo);

                    _precioMM = p.precioMMayoreo;
                    _strPresentacion = p.PresentacionMenudeo;
                    p.stock = p.stock.Equals("ILIMITADO") ? "123456" : p.stock;

                    if (_precioActual == p.precioMayoreo)
                    {
                        _auxCantidad = Convert.ToDecimal(cantidad * p.TotalUnidades);
                    }

                    if (cantidad > Convert.ToDecimal(p.stock) || _auxCantidad > Convert.ToDecimal(p.stock))
                    {
                        MessageBox.Show("LA CANTIDAD DE PRODUCTO INGRESADO SUPERA EL STOCK ACTUAL!", "STOCK FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        decimal _auxStock = 0;
                        if (_precioActual == p.precioMayoreo)
                        {
                            _auxStock = Math.Floor(Convert.ToDecimal(Decimal.Parse(p.stock) / p.TotalUnidades));
                            gdvVentas.Rows[e.RowIndex].Cells[2].Value = _auxStock;
                            precio = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[7].Value.ToString());
                            gdvVentas.Rows[e.RowIndex].Cells[8].Value = _auxStock * precio;
                            gdvVentas.Rows[e.RowIndex].Cells[9].Value = (Decimal.Parse(p.stock) - (_auxStock * p.TotalUnidades));
                        }
                        else
                        {
                            gdvVentas.Rows[e.RowIndex].Cells[2].Value = p.stock;
                            precio = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[7].Value.ToString());
                            gdvVentas.Rows[e.RowIndex].Cells[8].Value = stock * precio;
                            gdvVentas.Rows[e.RowIndex].Cells[9].Value = (Decimal.Parse(p.stock) - cantidad);
                        }


                    }
                    else
                    {
                        if (_precioActual == p.precioMayoreo)
                        {
                            gdvVentas.Rows[e.RowIndex].Cells[7].Value = _precioActual;
                            gdvVentas.Rows[e.RowIndex].Cells[8].Value = cantidad * _precioActual;
                        }
                        else if (_precioMM != 0 && cantidad >= _ApartiDe && _precioActual == p.precioMMayoreo)//ACTUALIZA EL PRECIO MEDIO MAYOREO
                        {
                            gdvVentas.Rows[e.RowIndex].Cells[7].Value = _precioMM;
                            gdvVentas.Rows[e.RowIndex].Cells[8].Value = cantidad * _precioMM;
                        }
                        else if (_precioActual == p.precioMenudeo)
                        {
                            gdvVentas.Rows[e.RowIndex].Cells[7].Value = p.precioMenudeo;
                            precio = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[7].Value.ToString());
                            gdvVentas.Rows[e.RowIndex].Cells[8].Value = cantidad * precio;
                        }
                        else
                        {
                            precio = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[7].Value.ToString());
                            gdvVentas.Rows[e.RowIndex].Cells[8].Value = cantidad * precio;
                        }
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
                finally
                {
                    SumaTotal_a_Pagar();
                }

            }
        }

        private void gdvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gdvVentas.Columns[e.ColumnIndex].Name == "PRECIO")
                {

                    txtProducto.Text = gdvVentas.Rows[e.RowIndex].Cells[4].Value.ToString();
                    var _auxProducto = gdvVentas.Rows[e.RowIndex].Cells[4].Value.ToString();
                    lblId.Text = gdvVentas.Rows[e.RowIndex].Cells[1].Value.ToString();
                    lblUnidad.Text = gdvVentas.Rows[e.RowIndex].Cells[3].Value.ToString();
                    decimal _PrecioActual = Convert.ToDecimal(gdvVentas.Rows[e.RowIndex].Cells[7].Value.ToString());

                    Producto p = new BusProducto().ObtenerProducto(_auxProducto);

                    rbtnMenudeo.Checked = p.precioMenudeo == _PrecioActual ? true : false;
                    rbtnMMayoreo.Checked = p.precioMMayoreo == _PrecioActual ? true : false;
                    rbtnMayoreo.Checked = p.precioMayoreo == _PrecioActual ? true : false;

                    lblMenudeo.Text = p.precioMenudeo.ToString() == "0.00" ? "N/A" : p.precioMenudeo.ToString();// p.precioMenudeo.ToString();
                    lblMMayoreo.Text = p.precioMMayoreo.ToString() == "0.00" ? "N/A" : p.precioMMayoreo.ToString();
                    lblMayoreo.Text = p.precioMayoreo.ToString() == "0.00" ? "N/A" : p.precioMayoreo.ToString();//p.precioMayoreo.ToString();

                    if (lblMMayoreo.Text.Equals("N/A"))
                    {
                        rbtnMMayoreo.Enabled = false;
                    }
                    else
                    {
                        rbtnMMayoreo.Enabled = true;
                    }

                    if (lblMenudeo.Text.Equals("N/A"))
                    {
                        rbtnMenudeo.Enabled = false;
                    }
                    else
                    {
                        rbtnMenudeo.Enabled = true;
                    }

                    if (lblMayoreo.Text.Equals("N/A"))
                    {
                        rbtnMayoreo.Enabled = false;
                    }
                    else
                    {
                        rbtnMayoreo.Enabled = true;
                    }

                    pnlCambioPrecio.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar el catálogo de precios : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                txtPrecioPreferencial.Visible = true;
                txtPrecioPreferencial.Focus();
            }
            else
            {
                txtPrecioPreferencial.Visible = false;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlCambioPrecio.Visible = false;
        }

        private void rbtnMenudeo_CheckedChanged(object sender, EventArgs e)
        {
            ModificarPrecios("MENUDEO", lblMenudeo.Text);
        }

        private void rbtnMMayoreo_CheckedChanged(object sender, EventArgs e)
        {
            ModificarPrecios("MEDIO MAYOREO", lblMMayoreo.Text);
        }

        private void rbtnMayoreo_CheckedChanged(object sender, EventArgs e)
        {
            ModificarPrecios("MAYOREO", lblMayoreo.Text);
        }

        private void txtPrecioPreferencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioPreferencial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ModificarPrecios("PREFERENCIAL", txtPrecioPreferencial.Text);
                this.pnlCambioPrecio.Visible = false;
            }
        }

        private void ModificarPrecios(string tipoPrecio, string precio)
        {
            DataTable dt2 = new DataTable();
            dt2 = gdvVentas.DataSource as DataTable;

            // int codigoii= Convert.ToInt32(lblId.Text);
            var codigo = lblId.Text;
            Producto p = new BusProducto().ObtenerProducto(txtProducto.Text);
            try
            {
                if (!string.IsNullOrEmpty(codigo))
                {
                    DataRow[] d = dt2.Select($"ID={codigo} AND UNIDAD='{lblUnidad.Text}'"); //VERIFICA SI EXISTE EL ID A INGRESAR

                    if (d.Length == 1)
                    {
                        decimal valor = d[0].Field<decimal>("CANTIDAD");
                        decimal PRECIO = d[0].Field<decimal>("PRECIO");
                        int presentacion = d[0].Field<Int32>("PRESENTACION_ID");

                        string unidad = "";
                        string _auxUnidad = "";
                        if (tipoPrecio == "MAYOREO")
                        {
                            unidad = DatCatGenerico.ObtenerPresentacion(presentacion).Descripcion;
                        }
                        else if (tipoPrecio == "MEDIO MAYOREO")
                        {
                            unidad = DatCatGenerico.Obtener_Presentacion_Abv(p.PresentacionMenudeo);

                        }
                        else if (tipoPrecio == "MENUDEO")
                        {
                            unidad = DatCatGenerico.Obtener_Presentacion_Abv(p.PresentacionMenudeo);

                        }



                        d[0].SetField("PRECIO", Convert.ToDecimal(precio));
                        d[0].SetField("CANTIDAD", valor);
                        d[0].SetField("IMPORTE", Convert.ToDecimal(precio) * valor);

                        if (tipoPrecio != "PREFERENCIAL")
                            d[0].SetField("UNIDAD", unidad);

                        txtBuscar.Text = "";
                    }
                    txtProducto.Text = "";
                    lblId.Text = "";
                    txtPrecioPreferencial.Text = "0";
                    txtPrecioPreferencial.Visible = false;
                    toggleSwitch1.IsOn = false; 
                }

            }
            catch (Exception ex)
            {
                  MessageBox.Show("Error : " + ex.Message, "Error al actualizar el precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SumaTotal_a_Pagar();
                this.pnlCambioPrecio.Visible = false;

            }
        }
    }
}
