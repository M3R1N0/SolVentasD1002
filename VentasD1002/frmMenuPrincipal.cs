using BusVenta;
using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reportes;
using System.Drawing.Printing;
using Telerik.Reporting.Processing;

namespace VentasD1002
{
    public partial class frmMenuPrincipal : Form
    {
        private int idCaja;
        private string serialPC;
        private Box listadoCaja;
        private List<Producto> lstProducto;
        private List<CatalogoGenerico> lsTipoPresentacion = new List<CatalogoGenerico>();
        private int rowIndex = 0;
        private int idCliente;
        private string indicador;
        private PrintDocument TICKET;
        bool esVentaNueva;

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            gdvBuscar.Visible = false;
            pnlCantidad.Visible = false;
            gdvClientes.Visible = false;
            pnlCambioPrecios.Visible = false;
            pnlCobrar.Visible = false;

            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
                System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ".";
                System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ",";
                System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
                System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ",";

                ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
                serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
                idCaja = new BusBox().showBoxBySerial(serialPC).Id;

                lsTipoPresentacion = new BusCatGenerico().ListarTipoPresentacion();
                listadoCaja = new BusBox().showBoxBySerial(serialPC);

                var comprobante = new BusSerializacion().ListarComprobantes()
                                                       .Where(x => x.Por_Defecto.Equals("SI"))
                                                       .Select(x => x.Tipo_Documento).FirstOrDefault();
                lblComprobante.Text = comprobante;

                string ticket = DatBox.Obtener_ImpresoraTicket(serialPC);
                cboImpresora.Text = ticket;


                Obtener_PerfilUsuario();
                Obtenter_ImpresorasInstaladas();
                Listar_FormaPago();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Obtener_PerfilUsuario()
        {
            try
            {
                User u = new BusUser().ObtenerUsuario(EncriptarTexto.Encriptar(serialPC));
                byte[] b = u.Foto;
                MemoryStream ms = new MemoryStream(b);
                pbPerfil.Image = Image.FromStream(ms);
                lblNombre.Text = u.Nombre;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime cierre = dateTimePicker1.Value;
                DateTime fin = dateTimePicker1.Value;
                new BusOpenCloseBox().CerrarCaja(idCaja, cierre, fin);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos p = new frmProductos();
            p.ShowDialog();
        }

        #region GRID VENTAS

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar.SelectAll();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtBuscar.Text))
                {
                    gdvBuscar.Visible = false;
                }
                else
                {
                    gdvBuscar.Visible = true;
                    DataTable dt = new DataTable();
                    lstProducto = new BusProducto().ListarProductos(txtBuscar.Text);
                    gdvBuscar.DataSource = lstProducto;

                    gdvBuscar.Columns[0].Visible = false;
                    gdvBuscar.Columns[1].Visible = false;
                    gdvBuscar.Columns[2].Visible = false;
                    gdvBuscar.Columns[3].Visible = false;
                    gdvBuscar.Columns[5].Visible = false;
                    gdvBuscar.Columns[6].Visible = false;
                    gdvBuscar.Columns[7].Visible = false;
                    gdvBuscar.Columns[8].Visible = false;
                    gdvBuscar.Columns[9].Visible = false;
                    gdvBuscar.Columns[10].Visible = false;
                    gdvBuscar.Columns[11].Visible = false;
                    gdvBuscar.Columns[12].Visible = false;
                    gdvBuscar.Columns[13].Visible = false;
                    gdvBuscar.Columns[14].Visible = false;
                    gdvBuscar.Columns[15].Visible = false;
                    gdvBuscar.Columns[16].Visible = false;
                    gdvBuscar.Columns[17].Visible = false;

                    gdvBuscar.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto ingresado no existe!,\n verifique que haya ingresado corectamente los datos", "BUSQUEDA FALLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscar.SelectAll();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtCantidad.Text == "")
                {
                    MessageBox.Show("Ingrese una cantidad valida", "IMPORTANTE!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCantidad.SelectAll();
                }
                else
                {
                    pnlCantidad.Visible = false;
                    txtCantidad.Clear();
                    txtBuscar.Focus();
                }
            }
        }

        private void gdvBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBuscar.Clear();
            pnlCantidad.Visible = true;
            txtCantidad.Focus();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("PRESENTACION_ID", typeof(System.Int32));//0
            dt.Columns.Add("ID", typeof(System.Int32));             //1
            dt.Columns.Add("CANTIDAD", typeof(System.Decimal));     //2
            dt.Columns.Add("UNIDAD");                               //3
            dt.Columns.Add("CONCEPTO");                             //4
            dt.Columns.Add("PZA X CAJA");                           //5
            dt.Columns.Add("PRESENTACIÓN");                         //6
            dt.Columns.Add("PRECIO", typeof(System.Decimal));       //7
            dt.Columns.Add("IMPORTE", typeof(System.Decimal));      //8
            dt.Columns.Add("STOCK", typeof(System.Decimal));        //9
            dt.Columns.Add("CODIGO");                               //10
            dt.Columns.Add("USAINVENTARIO");                        //11
            DataRow dr = dt.NewRow();
            string unidad = "";
            decimal precio = 0;

            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    int tipoPresentacion = lstProducto.Select(x => x.IdTipoPresentacion).FirstOrDefault();
                    if (rbMayoreo.Checked == true)
                    {
                        unidad = lsTipoPresentacion.Where(x => x.Id.Equals(tipoPresentacion)).Select(x => x.Descripcion).FirstOrDefault();
                        precio = lstProducto.Select(x => x.precioMayoreo).FirstOrDefault();
                    }
                    if (rbMMayoreo.Checked == true)
                    {
                        unidad = lsTipoPresentacion.Where(x => x.Id.Equals(tipoPresentacion)).Select(x => x.Descripcion).FirstOrDefault();
                        precio = lstProducto.Select(x => x.precioMMayoreo).FirstOrDefault();
                        if (unidad == "BTO")
                        {
                            unidad = "KG";
                        }
                        if (unidad == "CJA")
                        {
                            unidad = "PZA";
                        }
                        if (unidad == "PQTE")
                        {
                            unidad = "PZA";
                        }
                        if (unidad == "RJA")
                        {
                            unidad = "PZA";
                        }
                    }
                    if (rbMenudeo.Checked == true)
                    {
                        unidad = lsTipoPresentacion.Where(x => x.Id.Equals(tipoPresentacion)).Select(x => x.Descripcion).FirstOrDefault();
                        precio = lstProducto.Select(x => x.precioMenudeo).FirstOrDefault();
                        if (unidad == "BTO")
                        {
                            unidad = "KG";
                        }
                        if (unidad == "CJA")
                        {
                            unidad = "PZA";
                        }
                        if (unidad == "PQTE")
                        {
                            unidad = "PZA";
                        }
                        if (unidad == "RJA")
                        {
                            unidad = "PZA";
                        }
                    }

                    if (gdvVentas.Rows.Count == 0)
                    {
                        int id = lstProducto.Select(x => x.Id).FirstOrDefault();
                        string producto = lstProducto.Select(x => x.Descripcion).FirstOrDefault();

                        dr["PRESENTACION_ID"] = lstProducto.Select(x => x.IdTipoPresentacion).FirstOrDefault();
                        dr["ID"] = id;
                        dr["CANTIDAD"] = 1;
                        dr["UNIDAD"] = unidad;
                        dr["CONCEPTO"] = producto;
                        dr["PZA X CAJA"] = lstProducto.Select(x => x.APartirDe).FirstOrDefault();
                        dr["PRESENTACIÓN"] = lstProducto.Select(x => x.Presentacion).FirstOrDefault();
                        dr["PRECIO"] = precio;
                        dr["IMPORTE"] = precio;
                        dr["STOCK"] = lstProducto.Select(x => x.stock).FirstOrDefault();
                        dr["CODIGO"] = lstProducto.Select(x => x.codigo).FirstOrDefault();
                        dr["USAINVENTARIO"] = lstProducto.Select(x => x.usaInventario).FirstOrDefault();

                        dt.Rows.Add(dr);
                        txtBuscar.Clear();
                        gdvVentas.DataSource = dt;
                        DataTablePersonalizado.Multilinea(ref gdvVentas);
                        gdvVentas.Columns[0].Visible = false;
                        gdvVentas.Columns[1].Visible = false;
                        //gdvVentas.Columns[2].ReadOnly = true;
                        gdvVentas.Columns[3].ReadOnly = true;
                        gdvVentas.Columns[4].ReadOnly = true;
                        gdvVentas.Columns[5].ReadOnly = true;
                        gdvVentas.Columns[6].ReadOnly = true;
                        gdvVentas.Columns[7].ReadOnly = true;
                        gdvVentas.Columns[9].Visible = false;
                        gdvVentas.Columns[10].Visible = false;
                        gdvVentas.Columns[11].Visible = false;

                    }
                    else
                    {
                        DataTable dt2 = new DataTable();
                        dt2 = gdvVentas.DataSource as DataTable;

                        int codigo = lstProducto.Select(x => x.Id).FirstOrDefault();
                        DataRow[] d = dt2.Select("ID=" + codigo + ""); //VERIFICA SI EXISTE EL ID A INGRESAR

                        if (d.Length == 1)
                        {
                            decimal valor = d[0].Field<decimal>("CANTIDAD");
                            decimal SUBTOTAL = d[0].Field<decimal>("IMPORTE");
                            decimal PRECIO = d[0].Field<decimal>("PRECIO");
                            d[0].SetField("CANTIDAD", valor + 1);
                            d[0].SetField("IMPORTE", PRECIO * (valor + 1));
                            txtBuscar.Clear();
                        }
                        else
                        {
                            DataRow dr2 = dt2.NewRow();
                            int id = lstProducto.Select(x => x.Id).FirstOrDefault();
                            string producto = lstProducto.Select(x => x.Descripcion).FirstOrDefault();

                            dr2["PRESENTACION_ID"] = lstProducto.Select(x => x.IdTipoPresentacion).FirstOrDefault();
                            dr2["ID"] = id;
                            dr2["CANTIDAD"] = 1;
                            dr2["UNIDAD"] = unidad;
                            dr2["CONCEPTO"] = producto;
                            dr2["PZA X CAJA"] = lstProducto.Select(x => x.APartirDe).FirstOrDefault();
                            dr2["PRESENTACIÓN"] = lstProducto.Select(x => x.Presentacion).FirstOrDefault();
                            dr2["PRECIO"] = precio;
                            dr2["IMPORTE"] = precio;
                            dr2["STOCK"] = lstProducto.Select(x => x.stock).FirstOrDefault();
                            dr2["CODIGO"] = lstProducto.Select(x => x.codigo).FirstOrDefault();
                            dr2["USAINVENTARIO"] = lstProducto.Select(x => x.usaInventario).FirstOrDefault();

                            dt2.Rows.Add(dr2);
                            txtBuscar.Clear();
                        }
                    }
                    lstProducto = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto ingresado no existe!,\n verifique que haya ingresado corectamente los datos", "BUSQUEDA FALLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SumaTotal_a_Pagar();
            }
        }

        private void gdvVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal cantidad;
            decimal precio;
            decimal stock;
            if (gdvVentas.Columns[e.ColumnIndex].Name == "CANTIDAD")
            {
                try
                {
                    stock = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[9].Value.ToString());
                    cantidad = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[2].Value.ToString());

                    if (cantidad > stock)
                    {
                        MessageBox.Show("LA CANTIDAD DE PRODUCTO INGRESADO SUPERA EL STOCK ACTUAL!", "STOCK FALTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gdvVentas.Rows[e.RowIndex].Cells[2].Value = stock;
                        precio = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[7].Value.ToString());
                        gdvVentas.Rows[e.RowIndex].Cells[8].Value = stock * precio;
                    }
                    else
                    {
                        precio = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[7].Value.ToString());
                        gdvVentas.Rows[e.RowIndex].Cells[8].Value = cantidad * precio;
                    }

                    cantidad = 0;
                    precio = 0;
                    stock = 0;
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
            if (gdvVentas.Columns[e.ColumnIndex].Name == "PRECIO")
            {
                if (rbMayoreo.Checked == true)
                {
                    cboTipoPrecio.SelectedIndex = 2;
                }
                if (rbMMayoreo.Checked == true)
                {
                    cboTipoPrecio.SelectedIndex = 1;
                }
                if (rbMenudeo.Checked == true)
                {
                    cboTipoPrecio.SelectedIndex = 0;
                }

                lblProducto.Text = gdvVentas.Rows[e.RowIndex].Cells[4].Value.ToString();
                lblId.Text = gdvVentas.Rows[e.RowIndex].Cells[1].Value.ToString();
                pnlCambioPrecios.Visible = true;
            }
        }

        private void cboTipoPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboTipoPrecio.Text == "MENUDEO")
                {
                    decimal menudeo = new DatProducto().ObtenerTipoPrecio(Convert.ToInt32(lblId.Text), "U");
                    lblPrecio.Text = menudeo.ToString();
                }

                if (cboTipoPrecio.Text == "MEDIO MAYOREO")
                {
                    decimal menudeo = new DatProducto().ObtenerTipoPrecio(Convert.ToInt32(lblId.Text), "MM");
                    lblPrecio.Text = menudeo.ToString();
                }

                if (cboTipoPrecio.Text == "MAYOREO")
                {
                    decimal menudeo = new DatProducto().ObtenerTipoPrecio(Convert.ToInt32(lblId.Text), "M");
                    lblPrecio.Text = menudeo.ToString();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                SumaTotal_a_Pagar();
            }
        }

        private void gdvVentas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.gdvVentas.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.gdvVentas.CurrentCell = this.gdvVentas.Rows[e.RowIndex].Cells[4];
                this.contextMenuStrip1.Show(this.gdvVentas, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void elimininarDeLaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.gdvVentas.Rows[this.rowIndex].IsNewRow)
                {
                    this.gdvVentas.Rows.RemoveAt(this.rowIndex);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                SumaTotal_a_Pagar();
            }
        }

        private void cancelarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gdvVentas.DataSource = null;
            lblTotal.Text = "0.00";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2 = gdvVentas.DataSource as DataTable;

            int codigo1 = Convert.ToInt32(lblId.Text);
            var codigo = lblId.Text;
            try
            {
                DataRow[] d = dt2.Select("ID=" + codigo + ""); //VERIFICA SI EXISTE EL ID A INGRESAR

                if (d.Length == 1)
                {
                    decimal valor = d[0].Field<decimal>("CANTIDAD");
                    decimal PRECIO = d[0].Field<decimal>("PRECIO");
                    int presentacion = d[0].Field<Int32>("PRESENTACION_ID");

                    string unidad = "";
                    if (cboTipoPrecio.Text == "MAYOREO")
                    {
                        unidad = lsTipoPresentacion.Where(x => x.Id.Equals(presentacion)).Select(x => x.Descripcion).FirstOrDefault();
                    }
                    else if (cboTipoPrecio.Text == "MEDIO MAYOREO")
                    {
                        unidad = lsTipoPresentacion.Where(x => x.Id.Equals(presentacion)).Select(x => x.Descripcion).FirstOrDefault();
                        if (unidad == "BTO")
                        {
                            unidad = "KG";
                        }
                        if (unidad == "CJA")
                        {
                            unidad = "PZA";
                        }
                    }
                    else
                    {
                        unidad = lsTipoPresentacion.Where(x => x.Id.Equals(presentacion)).Select(x => x.Descripcion).FirstOrDefault();
                        if (unidad == "BTO")
                        {
                            unidad = "KG";
                        }
                        if (unidad == "CJA")
                        {
                            unidad = "PZA";
                        }
                    }

                    d[0].SetField("PRECIO", Convert.ToDecimal(lblPrecio.Text));
                    d[0].SetField("CANTIDAD", valor);
                    d[0].SetField("IMPORTE", Convert.ToDecimal(lblPrecio.Text) * valor);
                    d[0].SetField("UNIDAD", unidad);
                    txtBuscar.Clear();
                }
                lblPrecio.Text = "";
                cboFormaPago.SelectedItem = 0;
                lblProducto.Text = "";
                lblId.Text = "";
                pnlCambioPrecios.Visible = false;
            }
            catch (Exception)
            { }
            finally
            {
                SumaTotal_a_Pagar();
            }
        }

        private void SumaTotal_a_Pagar()
        {
            decimal sumatoria = 0;
            foreach (DataGridViewRow dr in gdvVentas.Rows)
            {
                sumatoria += Convert.ToDecimal(dr.Cells["IMPORTE"].Value);
            }
            lblTotal.Text = sumatoria.ToString("#,#.#0");
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
           
            try
            {
                esVentaNueva = true;
                if (gdvVentas.DataSource == null )
                {
                    MessageBox.Show("NO HAY PRODUCTOS EN VENTA","COBRO NO AUTORIZDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Mostrar_TipoComprobante();
                    lblPagoTotal.Text = lblTotal.Text;
                    pnlCobrar.Visible = true;
                    if (cboFormaPago.Text == "Credito")
                    {
                        rbtnAbonar.Enabled = true;
                        dtpFechaPago.Enabled = true;
                        rbtnAbonar.Checked = true;
                    }
                    else
                    {
                        rbtnAbonar.Enabled = false;
                        rbtnAbonar.Checked = false;
                        dtpFechaPago.Enabled = false;
                    }
                    Dibujar_BotonComprobante();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al ingresar la venta" + ex.Message, "Venta no generada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

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

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            try
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

        #region PANEL COBRO

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pnlCambioPrecios.Visible = false;
        }

        private void txtRecibi_TextChanged(object sender, EventArgs e)
        {
            decimal recibi;
            if (string.IsNullOrEmpty(txtRecibi.Text) || txtRecibi.Equals("0"))
            {
                txtRecibi.Text = "0";
                txtRecibi.SelectAll();
            }
            else if( esVentaNueva == true)
            {
                recibi = Convert.ToDecimal(txtRecibi.Text);
                decimal cambio = recibi - (Convert.ToDecimal(lblPagoTotal.Text));
                txtCambio.Text = "$ " + cambio;
            }
        }

        private void txtRecibi_KeyPress(object sender, KeyPressEventArgs e)
        {

            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

        }

        private void pbCerrarPanelCobrar_Click(object sender, EventArgs e)
        {
            pnlCobrar.Visible = false;
            txtRecibi.Clear();
            txtCambio.Clear();
            lblPagoTotal.ResetText();
        }

        private void Dibujar_BotonComprobante()
        {
            FlowLayoutPanel3.Controls.Clear();
            try
            {
                List<Serializacion> lstSerializacion = new BusSerializacion().ListarComprobantes()
                                                       .Where(x => x.Destino.Equals("VENTAS")).ToList();

                foreach (var item in lstSerializacion)
                {
                    Button b = new Button();
                    b.Text = item.Tipo_Documento;
                    b.Size = new System.Drawing.Size(90, 40);
                    b.BackColor = Color.FromArgb(70, 70, 71);
                    b.Font = new System.Drawing.Font("Segoe UI", 12);
                    b.FlatStyle = FlatStyle.Flat;
                    b.ForeColor = Color.WhiteSmoke;
                    FlowLayoutPanel3.Controls.Add(b);
                    if (b.Text == lblComprobante.Text)
                    {
                        b.Visible = false;
                    }
                    b.Click += miEvento;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void miEvento(System.Object sender, EventArgs e)
        {
            lblComprobante.Text = ((Button)sender).Text;
            Dibujar_BotonComprobante();
            Mostrar_TipoComprobante();
            //validar_tipos_de_comprobantes();
            //identificar_el_tipo_de_pago();
            string tipoPago = cboFormaPago.Text.ToUpper();
            if (lblComprobante.Text == "FACTURA" && tipoPago.Equals("CREDITO"))
            {
                //PANEL_CLIENTE_FACTURA.Visible = false;
            }
            if (lblComprobante.Text == "FACTURA" && tipoPago == "EFECTIVO")
            {
                //PANEL_CLIENTE_FACTURA.Visible = true;
                //lblindicador_de_factura_1.Text = "Cliente: (Obligatorio)";
                //lblindicador_de_factura_1.ForeColor = Color.FromArgb(255, 192, 192);

            }
            else if (lblComprobante.Text != "FACTURA" && tipoPago == "EFECTIVO")
            {
                //PANEL_CLIENTE_FACTURA.Visible = true;
                //lblindicador_de_factura_1.Text = "Cliente: (Opcional)";
                //lblindicador_de_factura_1.ForeColor = Color.DimGray;

            }

            if (lblComprobante.Text == "FACTURA" && tipoPago == "TARJETA")
            {
                //PANEL_CLIENTE_FACTURA.Visible = true;
                //lblindicador_de_factura_1.Text = "Cliente: (Obligatorio)";
                //lblindicador_de_factura_1.ForeColor = Color.FromArgb(255, 192, 192);

            }
            else if (lblComprobante.Text != "FACTURA" && tipoPago == "TARJETA")
            {
                //PANEL_CLIENTE_FACTURA.Visible = true;
                //lblindicador_de_factura_1.Text = "Cliente: (Opcional)";
                //lblindicador_de_factura_1.ForeColor = Color.DimGray;
            }
        }

        private void TGuardarSinImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                txtRecibi.Text = "0";
                indicador = "VISTA PREVIA";
                NumeroATexto();

                GenerarVenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al insertar la venta " + ex.Message, "Error de inseción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarVenta()
        {
            try
            {
                decimal cambio = txtRecibi.Text.Equals("") || txtRecibi.Text.Equals(null) ? 0 : Convert.ToDecimal(txtRecibi.Text);
                decimal saldo = Convert.ToDecimal(lblPagoTotal.Text) - cambio;
                decimal saldoCredito = cambio >= Convert.ToDecimal(lblPagoTotal.Text) ? 0 : saldo;

                Venta venta = new Venta();
                venta.IdCaja = idCaja;
                venta.IdCliente = txtCliente.Text.Equals("GENERAL") ? 1 : idCliente;
                string serial = EncriptarTexto.Encriptar(serialPC);
                venta.IdUsuario = new BusUser().ObtenerUsuario(serial).Id;
                venta.FechaVenta = DateTime.Now;
                venta.Folio = lblSerie.Text + "-"+lblCorrelativo.Text;
                venta.MontoTotal = Convert.ToDecimal(lblTotal.Text);
                venta.FormaPago = cboFormaPago.Text;
                venta.EstadoPago = cboFormaPago.Text.Equals("Contado") && saldoCredito == 0 ? "PAGADO" : "PENDIENTE";
                venta.Comprobante = "TICKET";
                venta.FechaLiquidacion = cboFormaPago.Text.Equals("Credito") ? dtpFechaPago.Value.ToString() : "N/A";
                venta.Accion = "VENTA REALIZADA";
                venta.Saldo = saldoCredito;
                venta.TipoPago = 0;
                venta.ReferenciaTarjeta = "N/A";

                new BusVentas().AgregarVenta(venta);

                foreach (DataGridViewRow dr in gdvVentas.Rows)
                {
                    DetalleVenta d = new DetalleVenta();
                    d.IdProducto = Convert.ToInt32(dr.Cells["ID"].Value);
                    d.Cantidad = Convert.ToDecimal(dr.Cells["CANTIDAD"].Value);
                    d.Precio = Convert.ToDecimal(dr.Cells["PRECIO"].Value);
                    d.TotalPago = Convert.ToDecimal(dr.Cells["IMPORTE"].Value);
                    d.UnidadMedida = dr.Cells["UNIDAD"].Value.ToString();
                    d.Estado = "VENTA REALIZADA";
                    d.CantidaMostrada = 0;
                    d.Descripcion = Convert.ToString(dr.Cells["CONCEPTO"].Value);
                    d.Stock = Convert.ToString(dr.Cells["STOCK"].Value);
                    d.Codigo = Convert.ToString(dr.Cells["CODIGO"].Value);
                    d.UsaInventario = Convert.ToString(dr.Cells["USAINVENTARIO"].Value);
                    d.Se_Vende_A = "0";
                    d.Costo = 0;

                    new BusDetalleVenta().Agregar_DetalleVenta(d);
                }

                new BusSerializacion().Actualizar_numeroFin(lblNumeroFin.Text, Convert.ToInt32(lblIdSerializacion.Text));

                #region Ticket

                rptTicket rptTicket = new rptTicket();
                DataTable DT = new DatVenta().ObtenerComrpobante();
                rptTicket = new rptTicket();
                rptTicket.tbTicket.DataSource = DT;
                rptTicket.DataSource = DT;

                if (indicador.Equals("VISTA PREVIA"))
                {
                    frmVistaPreviaTickek vistaPreviaTickek = new frmVistaPreviaTickek();

                    vistaPreviaTickek.reportViewer2.Report = rptTicket;
                    vistaPreviaTickek.reportViewer2.RefreshReport();

                    vistaPreviaTickek.ShowDialog();
                }
                else if (indicador.Equals("IMPRIMIR DIRECTO"))
                {
                    reportViewerImprimir.Report = rptTicket;
                    reportViewerImprimir.RefreshReport();
                }

                #endregion

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al insertar la venta " + ex.Message, "Error de inseción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mostrar_TipoComprobante()
        {
            try
            {
                List<Serializacion> lstComprobantes = new BusSerializacion().ListarComprobantes();
                var _lst = lstComprobantes.Where(x => x.Tipo_Documento.Equals(lblComprobante.Text))
                                          .FirstOrDefault();

                lblSerie.Text = _lst.Serie;
                lblCantidadCero.Text = _lst.Cantidad_Numero;
                lblIdSerializacion.Text = _lst.Id.ToString();
                int numero = Convert.ToInt32(_lst.NumeroFin) + 1;
                lblNumeroFin.Text = numero.ToString(); 
                lblCorrelativo.Text = Formato_FolioVenta.FormatoFolio(lblNumeroFin.Text, Convert.ToInt32(lblCantidadCero.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los comprobantes : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumeroATexto()
        {
            string total = lblPagoTotal.Text;
            total = decimal.Parse(total).ToString("##0.00");
            int numero = Convert.ToInt32(Math.Floor(Convert.ToDouble(total)));
            string strTotal = Convertir_NumeroLetra.Conversion_Total_a_Letra(numero);
            string[] a = total.Split('.');
            string strTotalDecimal = a[1];
            string strTotalConvertido = strTotal + " CON " + strTotalDecimal + "/100";
        }

        private void btnGuardarImprimirdirecto_Click(object sender, EventArgs e)
        {
            indicador = "IMPRIMIR DIRECTO";
            bool aux = Convert.ToDecimal(txtRecibi.Text) >= Convert.ToDecimal(lblTotal.Text) ? true : false;
            if (aux)
            {
                if (cboImpresora.Text != "NINGUNA")
                {
                    try
                    {
                        Editar_ImpresoraTicket();
                        GenerarVenta();

                        TICKET = new PrintDocument();
                        TICKET.PrinterSettings.PrinterName = cboImpresora.Text;

                        if (TICKET.PrinterSettings.IsValid)
                        {
                            PrinterSettings printerSettings = new PrinterSettings();
                            printerSettings.PrinterName = cboImpresora.Text;

                            ReportProcessor reportProcessor = new ReportProcessor();
                            reportProcessor.PrintReport(reportViewerImprimir.ReportSource, printerSettings);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al imprimir el ticket : "+ex.Message, "Error de impresión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Seleccione una impresora", "Impresora inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Para imprimir el ticket debe de cubrir el total de la venta", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Editar_ImpresoraTicket()
        {
            try
            {
                Box b = new Box();
                b.Id = idCaja;
                b.ImpresoraTicket = cboImpresora.Text;

                new BusBox().Actualizar_ImpresoraTicket(b);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void Obtenter_ImpresorasInstaladas()
        {
            try
            {
                cboImpresora.Items.Clear();
                for (var i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                {
                    cboImpresora.Items.Add(PrinterSettings.InstalledPrinters[i]);
                }
                cboImpresora.Items.Add("NINGUNA");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las impresoras : "+ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            lblCantidadCero.Text = "";
            lblSerie.Text = "";
            lblNumeroFin.Text = "";
            lblCorrelativo.Text = "";
            lblPagoTotal.Text = "";
            txtCambio.Clear();
            rbMenudeo.Checked = true;
            cboFormaPago.SelectedValue = 1;
            gdvClientes.Visible = false;
            txtCliente.Text = "GENERAL";
            gdvVentas.DataSource = null;
            pnlCobrar.Visible = false;
        }
        
        #endregion


    }
}
