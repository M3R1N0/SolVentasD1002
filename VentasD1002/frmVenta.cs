using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Reporting.Charting;
using VentasD1002.Helpers;

namespace VentasD1002
{
    public partial class frmVenta : Form
    {
        public static string CLIENTE;
        public static int IDCLIENTE;
        public static string FORMA_PAGO;
        public static int IDVENTA;
        public static string RESPUESTA;
        public static bool ELIMINARNOTIFICACION_VE = false;
        public static bool EsVentaRealizada = false;
        private int _idCliente;

        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            pbpLogoEmpresa.Image = DatEmpresa.ObtenerLogoEmpresa();
            MostrarMenu();
            ValidarEstadoNota();
            Listar_FormaPago();
            Obtener_PerfilUsuario();
            txtCantidad.Text = "1";
        }

        #region Permisos "MENU"

        private void MostrarMenu()
        {
            try
            {
                var idUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
                string modulos = "frmVentasEnEspera,frmCliente";
                var menus = PermisoDAL.ObtenerFormsInternos(idUsuario, modulos);

                menuEspera.Items.Clear();
                menuEspera.Visible = false;

                foreach (var menu in menus)
                {
                    btnClientes.Visible = false;
                    if (menu.NombreForm == "frmCliente")
                    {
                        btnClientes.Visible = true;
                    }
                    else
                    {
                        menuEspera.Visible = true;
                        ToolStripMenuItem menuPadre = new ToolStripMenuItem(menu.Nombre, null, Click_Menu, menu.NombreForm);
                        MemoryStream ms = new MemoryStream(menu.Icono);
                        menuPadre.Image = Image.FromStream(ms);
                        menuPadre.Text = menu.Nombre;
                        menuPadre.TextImageRelation = TextImageRelation.ImageBeforeText;
                        menuPadre.ImageScaling = ToolStripItemImageScaling.None;

                        menuEspera.Items.Add(menuPadre);
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        private void Click_Menu(object sender, EventArgs evt)
        {
            ToolStripMenuItem itemSeleccionado = (ToolStripMenuItem)sender;
            Assembly asm = Assembly.GetEntryAssembly();
            Type element = asm.GetType(asm.GetName().Name + "." + itemSeleccionado.Name);

            if (element != null)
            {
                var frmCreado = (Form)Activator.CreateInstance(element);

                if (Application.OpenForms[element.Name] == null)
                {
                    //frmCreado.MdiParent = this;
                    switch (frmCreado.Name)
                    {
                        case "frmBonificacion":
                            if (IDVENTA != 0)
                            {
                                frmBonificacion bonificacion = new frmBonificacion();
                                frmBonificacion.idVenta = IDVENTA;
                                bonificacion.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("No hay venta en curso a bonificar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        case "frmVentasEnEspera":
                            ObtenerVentas_EnEspera();
                            break;
                        default:
                            frmCreado.ShowDialog();
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("El formulario no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void Obtener_PerfilUsuario()
        {
            try
            {
                var serialPC = Sistema.ObenterSerialPC();
                User u = BusUser.ObtenerUsuario_Loggeado();
                byte[] b = u.Foto;
                MemoryStream ms = new MemoryStream(b);
                pbPerfil.Image = Image.FromStream(ms);
                linkPerfil.Text = $"{u.Nombre} ({u.Rol})";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Listar_FormaPago()
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        #region Cliente
        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var response = BusCliente.ListarClientes(txtCliente.Text);
                gdvClientes.DataSource = response.Data;
                gdvClientes.Visible = true;

                foreach (DataGridViewColumn col in gdvClientes.Columns)
                {
                    col.Visible = false;
                    if (col.Name.ToString().Equals("NombreCompleto"))
                    {
                        col.Visible = true;
                    }
                }

                Comun.StyleDatatable(ref gdvClientes);
                gdvClientes.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al mostrar los datos del cliente" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            /*var height = 0;
            foreach (DataGridViewRow dr in gdvClientes.Rows)
            {
                height += dr.Height;
            }

            gdvClientes.Height = height;*/
        }

        private void gdvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var cliente = gdvClientes.SelectedCells[1].Value.ToString();
                var arrCliente = cliente.Split('-');
                txtCliente.Text = arrCliente[0].Trim();
                IDCLIENTE = Convert.ToInt32(gdvClientes.SelectedCells[0].Value.ToString());
                gdvClientes.Visible = false;
                ObtenerSaldoDisponible();
            }
            catch (Exception ex)
            {
            }
        }

        private void gdvClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _idCliente = Convert.ToInt32(gdvClientes.SelectedCells[0].Value.ToString());
                string cliente = gdvClientes.SelectedCells[1].Value.ToString();
                var arrCliente = cliente.Split('-');
                txtCliente.Text = arrCliente[0].Trim();
                gdvClientes.Visible = false;
                IDCLIENTE = _idCliente;
                ObtenerSaldoDisponible();

            }
        }
        #endregion

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text.ToUpper().Contains("GENERAL") && cboFormaPago.Text.ToUpper() == "CREDITO")
            {
                MessageBox.Show("Favor de agregar un cliente valido para las ventas a crédito", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ListarProductos();
            }
        }

        private void ListarProductos()
        {
            try
            {
                gridBuscar.Visible = false;
                if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    TIPO_VENTA tipoVenta = (rbtnMayoreo.Checked) ? TIPO_VENTA.M : TIPO_VENTA.U;

                    ProductoDAL.ListarProductos_x_CodigoDescripcion(txtBuscar.Text, ref gridBuscar, tipoVenta);

                    gridBuscar.Visible = true;
                    foreach (DataGridViewColumn col in gridBuscar.Columns)
                    {
                        col.Visible = false;
                        if (col.Index == 4 || col.Index == 8)
                        {
                            col.Visible = true;
                            col.Width = 500;
                        }
                    }
                    gridBuscar.Rows[0].Selected = true;
                }
            }
            catch (Exception)
            {
            }
        }

        private void gridBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        txtBuscar.Clear();
                        txtBuscar.Focus();
                        txtCantidad.Text = "1";
                        break;
                    case Keys.Enter:
                        ObtenerProducto();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {
            }
        }

        private void ObtenerProducto()
        {
            try
            {
                var codigo = gridBuscar.SelectedCells[3].Value.ToString();
                var tipoCodigo = gridBuscar.SelectedCells[17].Value.ToString();

                var p = ProductoDAL.ObtenerProducto_x_Codigo(codigo, tipoCodigo);
                if (p.Precio != 0)
                {
                    p.Cantidad = Convert.ToDecimal(txtCantidad.Text);

                    txtBuscar.Clear();
                    txtBuscar.Focus();

                    if (ValidarStock(p))
                    {
                        if (gridVentas.Rows.Count == 0)
                        {
                            Insertar_Venta();
                        }
                        Insertar_DetalleVenta(p);
                    }
                }
                else
                {
                    CustomUI.MessageBoxUI.Show("El producto no puede ser ingresado porque el precio debe ser distinto de 0 \nFavor de revisar.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCantidad.Text = "1";
                    txtBuscar.Clear();
                    txtBuscar.Focus();
                }
            }
            catch (Exception)
            {
            }
        }

        private void gridBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerProducto();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Comun.TextBoxNumerico(sender, e);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(txtBuscar.Text) || !string.IsNullOrWhiteSpace(txtBuscar.Text.Trim()))
                    {
                        var codigo = gridBuscar.SelectedCells[3].Value.ToString();
                        var tipoCodigo = gridBuscar.SelectedCells[17].Value.ToString();

                        var producto = ProductoDAL.ObtenerProducto_x_Codigo(codigo, tipoCodigo);

                        if (producto.Precio != 0)
                        {
                            producto.Cantidad = Convert.ToDecimal(txtCantidad.Text);

                            txtBuscar.Clear();
                            txtBuscar.Focus();

                            if (ValidarStock(producto))
                            {
                                if (gridVentas.Rows.Count == 0)
                                {
                                    Insertar_Venta();
                                }
                                Insertar_DetalleVenta(producto);
                            }
                        }
                        else
                        {
                            CustomUI.MessageBoxUI.Show("El producto no puede ser ingresado porque el precio debe ser distinto de 0 \nFavor de revisar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtCantidad.Text = "1";
                            txtBuscar.Clear();
                            txtBuscar.Focus();
                        }

                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private bool ValidarStock(ProductoVM p)
        {
            try
            {
                decimal cantidadIngresada = 0;
                decimal stock = 0;

                if (!p.UsaInventario)
                {
                    return true;
                }
                var ultimaEntrada = ProductoDAL.ObtenerUltimaEntrada(p.Id, TIPO_CONSULTA_ENTRADA.VALIDAR_STOCK.ToString());
                p.Stock += ultimaEntrada.TotalIngresado;
                if (p.Stock == 0 && p.UsaInventario)
                {
                    MessageBox.Show("¡Producto agotado, Favor de agregar nueva entrada para poder agregar a la venta!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                if (p.Venta == "M")
                {
                    cantidadIngresada = p.UnidadesPorPresentacion * p.Cantidad;
                    stock = p.Stock - cantidadIngresada;
                }
                else
                {
                    stock = p.Stock - p.Cantidad;
                }

                if (stock < 0)
                {
                    MessageBox.Show("¡La cantidad ingresada es mayor al stock actual!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void Insertar_Venta()
        {
            try
            {
                Venta venta = ValidarVenta();

                IDVENTA = BusVentas.AgregarVenta(venta);
            }
            catch (Exception ex)
            {
                IDVENTA = 0;
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Venta ValidarVenta()
        {
            try
            {
                Venta venta = new Venta();

                venta.Id = IDVENTA;
                venta.IdCaja = BusBox.showBoxBySerial().Id;
                venta.IdCliente = txtCliente.Text.Equals("GENERAL") ? 1 : IDCLIENTE;
                venta.IdUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
                venta.FechaVenta = DateTime.Now;
                venta.Folio = "0-000000";
                venta.MontoTotal = 0;
                venta.FormaPago = cboFormaPago.Text;
                venta.EstadoPago = ESTADO_PAGO.PENDIENTE.ToString();
                venta.Comprobante = "";
                venta.FechaLiquidacion = "N/A";
                venta.Accion = "VENTA REALIZADA";
                venta.Saldo = 0;
                venta.TipoPago = 0;
                venta.ReferenciaTarjeta = "N/A";
                venta.Efectivo = 0;
                venta.Recibo = 0;
                venta.Vuelto = 0;
                venta.Comentarios = (string.IsNullOrEmpty(txtNota.Text)) ? "" : txtNota.Text.Trim();

                return venta;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un detalle al validar la venta,Favor de revisar sus datos \n Detalle: " + ex.Message);
            }
        }

        #region Detalle venta

        private void gridVentas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //gridVentas.Rows[e.RowIndex].Selected = true;
        }

        private void gridVentas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.gridVentas.Rows[e.RowIndex].Selected = true;
            }
        }

        private void Insertar_DetalleVenta(ProductoVM p)
        {
            try
            {
                DetalleVenta d = new DetalleVenta();
                d.IdProducto = p.Id;
                d.IdVenta = IDVENTA;
                d.Cantidad = p.Cantidad;
                d.Precio = p.Precio;
                d.TotalPago = p.Precio * p.Cantidad;
                d.UnidadMedida = p.Presentacion;
                d.Estado = "VENTA REALIZADA";
                d.CantidaMostrada = 0;
                d.Descripcion = "";// p.Articulo;
                d.Stock = p.Stock.ToString();
                d.Codigo = p.codigo;
                d.UsaInventario = p.UsaInventario ? "SI" : "NO";
                d.Se_Vende_A = "0";
                d.Costo = 0;
                d.Venta = p.Venta;

                var total = Convert.ToDecimal(lblTotal.Text);
                var saldoDisponible = Convert.ToDecimal(lblSaldoDisponible.Text);

                total += d.TotalPago;

                if (cboFormaPago.Text.ToUpper() == "CREDITO" && total > saldoDisponible)
                {
                    MessageBox.Show("El total de la venta supera al saldo autorizado o disponible\n favor de liquidar las notas anteriores o actualizar el monto autorizado", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (BusDetalleVenta.Agregar_DetalleVenta(d))
                {
                    p.Cantidad = d.Cantidad;
                    if (p.UsaInventario && !cboFormaPago.Text.ToUpper().Equals(TIPO_PAGO.COTIZACION.ToString()))
                    {
                        ProductoDAL.Aumentar_DisminuirStock(p, "DISMINUIR");
                    }
                    Listar_DetalleVenta(IDVENTA);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el detalle de la venta : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtCantidad.Text = "1";
                txtBuscar.Focus();

            }
        }

        private void gridVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TIPO_VENTA tipoVenta;
                DetalleVentaII dv = gridVentas.CurrentRow.DataBoundItem as DetalleVentaII;

                var cantidadAnterior = DatDetalleVenta.ObtenerCantidadDV(dv.Id);

                switch (dv.TipoVenta)
                {
                    case 1:
                        tipoVenta = TIPO_VENTA.M;
                        break;
                    case 2:
                        tipoVenta = TIPO_VENTA.U;
                        break;
                    default:
                        tipoVenta = TIPO_VENTA.P;
                        break;
                }

                switch (e.ColumnIndex)
                {
                    case 3:
                        var _producto = ProductoDAL.ObtenerProducto_x_Codigo(dv.Codigo, tipoVenta.ToString());

                        if (_producto.UsaInventario && !cboFormaPago.Text.ToUpper().Equals(TIPO_PAGO.COTIZACION.ToString()))
                        {
                            _producto.Cantidad = cantidadAnterior;
                            ProductoDAL.Aumentar_DisminuirStock(_producto, "AUMENTAR");
                        }

                        _producto.Cantidad = dv.Cantidad;

                        if (cboFormaPago.Text.ToUpper() == TIPO_PAGO.CREDITO.ToString())
                        {
                            var CreditoDisp = Convert.ToDecimal(lblSaldoDisponible.Text);
                            var total = Convert.ToDecimal(lblTotal.Text) - dv.Importe;

                            if (((dv.Cantidad * dv.Precio) + total) > CreditoDisp)
                            {
                                MessageBox.Show("La cantidad Ingresada supera al crédito autorizado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                _producto.Cantidad = cantidadAnterior;
                            }
                        }
                        else
                        {
                            dv.Importe = dv.Precio * dv.Cantidad;
                        }

                        if (ValidarStock(_producto))
                        {
                            DatDetalleVenta.ActualizarPrecio_DetalleVenta(dv, tipoVenta);
                        }

                        if (_producto.UsaInventario && !cboFormaPago.Text.ToUpper().Equals(TIPO_PAGO.COTIZACION.ToString()))
                        {
                            ProductoDAL.Aumentar_DisminuirStock(_producto, "DISMINUIR");
                        }

                        break;
                    case 7:
                        dv.Importe = dv.Precio * dv.Cantidad;
                        DatDetalleVenta.ActualizarPrecio(dv, TIPO_VENTA.P);
                        break;
                    case 9:
                        dv.Importe = dv.Precio * dv.Cantidad;
                        Validar_TipoVentaSeleccionado(dv, tipoVenta);
                        break;
                    default:
                        break;
                }

                Listar_DetalleVenta(dv.IdVenta);
            }
            catch (Exception)
            {
            }
        }

        private void ValidarEstadoNota()
        {
            if (checkNota.Value)
                txtNota.Visible = true;
            else
                txtNota.Visible = false;
        }

        private void checkNota_OnValueChange(object sender, EventArgs e)
        {
            ValidarEstadoNota();
        }

        private void Listar_DetalleVenta(int idVenta)
        {
            try
            {
                var lst = DatCatGenerico.ListarCatalogo_TipoVenta();

                var comboBox = (DataGridViewComboBoxColumn)gridVentas.Columns["TipoVenta"];
                comboBox.DataSource = lst;
                comboBox.DisplayMember = "Nombre";
                comboBox.ValueMember = "Id";

                var lstDetalle = DatDetalleVenta.Listar_DetalleVenta(idVenta);

                gridVentas.DataSource = lstDetalle;
                foreach (DataGridViewColumn col in gridVentas.Columns)
                {
                    col.ReadOnly = true;
                    col.Visible = false;

                    if (col.Index == 3 || col.Index == 4 || col.Index == 5 || col.Index == 7 || col.Index == 8 || col.Index == 9)
                    {
                        col.Visible = true;
                        if (col.Index == 3 || col.Index == 9)
                        {
                            col.ReadOnly = false;
                        }
                    }
                }

                Comun.StyleDatatable(ref gridVentas);
            }
            catch (Exception ex)
            { }
            finally
            {
                txtCantidad.Text = "1";
                lblTotal.Text = gridVentas.Rows.Cast<DataGridViewRow>()
                                              .Sum(g => Convert.ToDecimal(g.Cells["Importe"].Value))
                                              .ToString();
                lblTotalArticulos.Text = gridVentas.Rows.Cast<DataGridViewRow>()
                                           .Sum(g => Convert.ToDecimal(g.Cells[3].Value))
                                           .ToString();


                if (gridVentas.Rows.Count > 0)
                {
                    DataGridViewRow row = gridVentas.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).Last();
                    // scroll to last row if necessary
                    gridVentas.FirstDisplayedScrollingRowIndex = gridVentas.Rows.Count - 1; //.IndexOf(row);
                                                                                            // select row
                    row.Selected = true;
                }
            }
        }

        private void Validar_TipoVentaSeleccionado(DetalleVentaII dv, TIPO_VENTA tipoVenta)
        {
            try
            {
                var producto = ProductoDAL.ObtenerProducto_x_Codigo(dv.Codigo, tipoVenta.ToString());

                producto.Cantidad = dv.Cantidad;
                if (producto.UsaInventario && !cboFormaPago.Text.ToUpper().Equals(TIPO_PAGO.COTIZACION.ToString()))
                {
                    ProductoDAL.Aumentar_DisminuirStock(producto, "AUMENTAR");
                }

                switch (dv.TipoVenta)
                {
                    case 1:
                        if (producto.Precio != 0 || producto.PrecioMayoreo != 0)
                        {
                            if (ValidarStock(producto))
                            {
                                dv.Precio = (dv.Cantidad >= producto.A_Partir_De) ? producto.PrecioMayoreo : producto.Precio;
                                dv.UnidadMedida = producto.Presentacion;
                                dv.Importe = dv.Precio * dv.Cantidad;

                                DatDetalleVenta.ActualizarPrecio_DetalleVenta(dv, TIPO_VENTA.M);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El producto no cuenta con la configuración de precio venta a mayoreo", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case 2:
                        if (producto.Precio != 0 || producto.PrecioMayoreo != 0)
                        {
                            dv.Precio = (dv.Cantidad >= producto.A_Partir_De) ? producto.PrecioMayoreo : producto.Precio;
                            dv.UnidadMedida = producto.Presentacion;
                            dv.Importe = dv.Precio * dv.Cantidad;

                            DatDetalleVenta.ActualizarPrecio_DetalleVenta(dv, TIPO_VENTA.U);
                        }
                        else
                        {
                            MessageBox.Show("El producto no cuenta con la configuración de precio venta a menudeo", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case 3:
                        frmEditarPrecioVenta frm = new frmEditarPrecioVenta(dv);
                        frm.ShowDialog();
                        break;
                    default:
                        break;
                }

                if (producto.UsaInventario && !cboFormaPago.Text.ToUpper().Equals(TIPO_PAGO.COTIZACION.ToString()))
                {
                    ProductoDAL.Aumentar_DisminuirStock(producto, "DISMINUIR");
                }

                Listar_DetalleVenta(dv.IdVenta);
            }
            catch (Exception ex)
            { }
        }

        #endregion

        private void enEsperaF8ToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
        }

        private void enEsperaF8ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void cboFormaPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboFormaPago.Text.ToUpper() == "CREDITO")
            {
                ObtenerSaldoDisponible();
            }
        }

        private void ObtenerSaldoDisponible()
        {
            try
            {
                if (cboFormaPago.Text.ToUpper() == TIPO_PAGO.CREDITO.ToString())
                {
                    decimal saldo = DatCliente.ObtenerSaldoDisponible(IDCLIENTE);
                    lblSaldoDisponible.Text = String.Format("{0:N2}", saldo);
                }
            }
            catch (Exception)
            {
            }
        }

        private void cobrarF10_Click(object sender, EventArgs e)
        {
            ProcesarPago();
        }

        private void ProcesarPago()
        {
            try
            {
                if (gridVentas.Rows.Count > 0)
                {
                    Venta v = ValidarVenta();
                    v.MontoTotal = Convert.ToDecimal(lblTotal.Text);

                    if (cboFormaPago.Text.ToUpper() != TIPO_PAGO.COTIZACION.ToString())
                    {
                        frmCobrar procesarPago = new frmCobrar(v);
                        procesarPago.FormClosing += Form_ProcesarPago;
                        procesarPago.ShowDialog();
                    }
                    else
                    {
                        BusVentas.AgregarVenta(v);
                        var reportViewer = new Telerik.ReportViewer.WinForms.ReportViewer();
                        var respuesta = ImprimirDocumento.Imprimir(ref reportViewer, DESTINO_DOCUMENTO.VENTAS, TIPO_DOCUMENTO.TICKET, IDVENTA);

                        var respEliminarVenta = BusVentas.Eliminar_Venta(IDVENTA);
                        if (respEliminarVenta.IsSuccess == EnumOperationResult.Failure)
                        {
                            MessageBox.Show(respEliminarVenta.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        ReestablecerDatos_Predeterminados();
                    }
                }
                else
                {
                    MessageBox.Show("¡No existen articulos ingresados para procesar la venta!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ocurrió un error al confirmar la venta!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form_ProcesarPago(object sender, FormClosingEventArgs e)
        {
            if (EsVentaRealizada)
            {
                ReestablecerDatos_Predeterminados();
            }
        }

        private void ReestablecerDatos_Predeterminados()
        {
            Cliente c = DatCliente.ObtenerCliente_Predeterminado();
            txtCliente.Text = c.NombreCompleto;
            IDCLIENTE = c.Id;
            _idCliente = c.Id;
            IDVENTA = 0;
            checkNota.Value = false;
            txtNota.Clear();
            lblTotalArticulos.Text = "0.00";
            lblSaldoDisponible.Text = "0.00";
            lblTotal.Text = "0.00";
            txtCantidad.Text = "1";
            cboFormaPago.SelectedIndex = 0;
            rbtnMayoreo.Checked = true;
            gdvClientes.Visible = false;
            Listar_DetalleVenta(0);
        }

        private void gdvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void enEsperaF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridVentas.Rows.Count > 0 && cboFormaPago.Text.ToUpper() != "COTIZACION")
            {
                var result = MessageBox.Show("¿Seguro desea colocar la venta actual en Espera?", "VENTA EN ESPERA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DatVenta.Actualizar_EstadoVenta(IDVENTA, "EN ESPERA");
                    var resultImprimir = MessageBox.Show("¿Desea imprimir el tickect?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultImprimir == DialogResult.Yes)
                    {
                        var reportViewer = new Telerik.ReportViewer.WinForms.ReportViewer();
                        var respuesta = ImprimirDocumento.Imprimir(ref reportViewer, DESTINO_DOCUMENTO.VENTAS, TIPO_DOCUMENTO.TICKET, IDVENTA);
                    }

                    ReestablecerDatos_Predeterminados();
                }
            }
        }

        private void cancelarVentaF9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridVentas.Rows.Count > 0)
                {
                    var result = MessageBox.Show("¿Seguro desea cancelar la venta actual?", "CANCELAR VENTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var respuesta = BusVentas.Eliminar_Venta(IDVENTA);
                        if (respuesta.IsSuccess == EnumOperationResult.Failure)
                        {
                            MessageBox.Show(respuesta.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        ReestablecerDatos_Predeterminados();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void ObtenerVentas_EnEspera()
        {
            if (gridVentas.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¡Hay una venta en proceso,¿Desea cancelar?!", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (result == DialogResult.Yes)
                {
                    frmVentasEnEspera ventasEnEspera = new frmVentasEnEspera();
                    ventasEnEspera.FormClosing += frmVentaEnEspera_FormClosing;
                    ventasEnEspera.ShowDialog();
                }
            }
            else
            {
                frmVentasEnEspera ventasEnEspera = new frmVentasEnEspera();
                ventasEnEspera.FormClosing += frmVentaEnEspera_FormClosing;
                ventasEnEspera.ShowDialog();
            }
        }

        private void frmVentaEnEspera_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (IDVENTA != 0 && IDCLIENTE != 0)
                {
                    Listar_DetalleVenta(IDVENTA);
                    Cliente c = BusCliente.ObtenerCliente(IDCLIENTE);
                    txtCliente.Text = c.NombreCompleto;

                    cboFormaPago.SelectedText = FORMA_PAGO;
                    gdvClientes.Visible = false;

                    // VentaDAL.Notificacion_Ventas_EnEspera(ref lblNotVentaEspera, 1);
                }
                if (ELIMINARNOTIFICACION_VE)
                {
                    //VentaDAL.Notificacion_Ventas_EnEspera(ref lblNotVentaEspera, 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el detalle de la venta : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Comun.TextBoxNumerico(sender, e);
        }

        private void ventasEnEsperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObtenerVentas_EnEspera();
        }

        private void linkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var sesion = BusUser.ObtenerUsuario_Loggeado();
            frmABUsuario usuario = new frmABUsuario(sesion.Id);
            usuario.ShowDialog();
            Obtener_PerfilUsuario();
        }


    }
}
