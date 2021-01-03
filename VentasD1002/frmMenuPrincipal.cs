﻿using BusVenta;
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
        private string RolUsuario;
        private int idCaja;
        private string serialPC;
        private Box listadoCaja;
        private List<Producto> lstProducto;
        private List<CatalogoGenerico> lsTipoPresentacion = new List<CatalogoGenerico>();
        private int rowIndex = 0;
        public static int idCliente;
        private string indicador;
        private PrintDocument TICKET;
        bool esVentaNueva;
        public static int idVenta;
        public static string VentaEspera;
        //private string btnTexto;

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            gdvBuscar.Visible = false;
            // pnlCantidad.Visible = false;
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

        #region FUNCIONALIDAD PRINCIPAL

        private void Obtener_PerfilUsuario()
        {
            try
            {
                User u = new BusUser().ObtenerUsuario(EncriptarTexto.Encriptar(serialPC));
                byte[] b = u.Foto;
                MemoryStream ms = new MemoryStream(b);
                pbPerfil.Image = Image.FromStream(ms);
                lblNombre.Text = u.Nombre + " "+ u.Apellidos;
                RolUsuario = u.Rol;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {
           
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

        #endregion

        #region BUSCAR

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
                    gdvBuscar.Columns[18].Visible = false;
                    gdvBuscar.Columns[19].Visible = false;

                    gdvBuscar.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto ingresado no existe!,\n verifique que haya ingresado corectamente los datos", "BUSQUEDA FALLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscar.SelectAll();
            }
        }

        private void gdvBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBuscar.Clear();
            // pnlCantidad.Visible = true;
            //txtCantidad.Focus();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
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

            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    var _auxStockProducto = lstProducto.Select(x => x.stock).FirstOrDefault();
                    var _stockProducto = _auxStockProducto.Equals("ILIMITADO") ? "123456" : _auxStockProducto;
                    var _usaInventario = lstProducto.Select(x => x.usaInventario).FirstOrDefault();
                    int tipoPresentacion = lstProducto.Select(x => x.IdTipoPresentacion).FirstOrDefault();
                    string _strPresentacion = lstProducto.Select(x => x.PresentacionMenudeo).First();
                    Decimal _ApartirDe = lstProducto.Select(x => x.APartirDe).FirstOrDefault();
                    decimal _totalUnidades = 0;
                    string _unidad = "";

                    #region VALIDACION DE UNIDADES

                    if (rbMayoreo.Checked == true)
                    {
                        unidad = lsTipoPresentacion.Where(x => x.Id.Equals(tipoPresentacion)).Select(x => x.Descripcion).FirstOrDefault();
                        precio = lstProducto.Select(x => x.precioMayoreo).FirstOrDefault();
                        _totalUnidades = Convert.ToDecimal(lstProducto.Select(x => x.TotalUnidades).FirstOrDefault());
                    }

                    if (rbMMayoreo.Checked == true)
                    {
                        unidad = lsTipoPresentacion.Where(x => x.Id.Equals(tipoPresentacion)).Select(x => x.Descripcion).FirstOrDefault();
                        precio = lstProducto.Select(x => x.precioMMayoreo).FirstOrDefault();
                        
                        if (_stockProducto != "123456")
                        {
                            _totalUnidades = 1;
                        }

                        if (unidad == "BTO")
                        {
                            unidad = "KG";
                        }
                        else
                        {
                            if (unidad == "CJA" && _strPresentacion == "PAQUETE")
                            {
                                _unidad = "PQTE";
                            }
                            else if (unidad == "CJA")
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
                    }

                    if (rbMenudeo.Checked == true)
                    {
                        unidad = lsTipoPresentacion.Where(x => x.Id.Equals(tipoPresentacion)).Select(x => x.Descripcion).FirstOrDefault();
                        precio = lstProducto.Select(x => x.precioMenudeo).FirstOrDefault();

                        if (_stockProducto != "123456")
                        {
                            _totalUnidades =  1;
                        }
                        if (unidad == "BTO")
                        {
                            unidad = "KG";
                        }
                        else
                        {
                            if (unidad == "CJA" && _strPresentacion == "PAQUETE")
                            {
                                _unidad = "PQTE";
                            }
                            else if (unidad == "CJA")
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

                    }

                    unidad = string.IsNullOrEmpty(_unidad) ? unidad : _unidad;
                    #endregion

                    _stockProducto = String.IsNullOrEmpty(_stockProducto) ? "123456" : _stockProducto;
                    if (gdvVentas.Rows.Count == 0)
                    {
                        if (Convert.ToDecimal(_stockProducto) < 1 && _usaInventario == "SI")
                        {
                            gdvBuscar.Visible = false;
                            timer1.Start();
                        }
                        else
                        {
                            int id = lstProducto.Select(x => x.Id).FirstOrDefault();
                            string producto = lstProducto.Select(x => x.Descripcion).FirstOrDefault();

                            dr["PRESENTACION_ID"] = lstProducto.Select(x => x.IdTipoPresentacion).FirstOrDefault();
                            dr["ID"] = id;
                            dr["CANTIDAD"] = 1;
                            dr["UNIDAD"] = unidad;
                            dr["CONCEPTO"] = producto;
                            dr["PZA X CAJA"] = lstProducto.Select(x => x.TotalUnidades).FirstOrDefault();
                            dr["PRESENTACIÓN"] = lstProducto.Select(x => x.Presentacion).FirstOrDefault();
                            dr["PRECIO"] = precio;
                            dr["IMPORTE"] = precio;
                            dr["STOCK"] = _usaInventario.Equals("SI") ? (Convert.ToDecimal(_stockProducto) -_totalUnidades).ToString() : "123456";
                            dr["CODIGO"] = lstProducto.Select(x => x.codigo).FirstOrDefault();
                            dr["USAINVENTARIO"] = lstProducto.Select(x => x.usaInventario).FirstOrDefault();
                            dr["APARTIR"] = lstProducto.Select(X => X.APartirDe).FirstOrDefault();

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
                            gdvVentas.Columns[12].Visible = false;
                        }
                    }
                    else
                    {
                        DataTable dt2 = new DataTable();
                        dt2 = gdvVentas.DataSource as DataTable;

                        int codigo = lstProducto.Select(x => x.Id).FirstOrDefault();
                        DataRow[] d = dt2.Select($"ID={codigo} and UNIDAD ='{unidad}'"); //VERIFICA SI EXISTE EL ID A INGRESAR
                        string _auxUnidad = d.Length == 0 ? "" : d[0].Field<string>("UNIDAD");
                        DataRow[] productos = dt2.Select($"ID={codigo}");

                        decimal sumaStock=0;
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
                                decimal _precionMM = lstProducto.Select(x => x.precioMMayoreo).FirstOrDefault();
                                decimal _sumaCantidad = cantidad + 1;
                                if (_precionMM != 0 && _sumaCantidad >= _ApartirDe)
                                {
                                    PRECIO = _precionMM;
                                    d[0].SetField("PRECIO", PRECIO);
                                }

                                d[0].SetField("CANTIDAD", _sumaCantidad);
                                d[0].SetField("IMPORTE", PRECIO * _sumaCantidad);
                                d[0].SetField("STOCK", (stock - _totalUnidades));
                                txtBuscar.Clear();

                            }
                            else
                            {
                                gdvBuscar.Visible = false;
                                timer1.Start();
                            }
                        }
                        else
                        {
                          

                            _stockProducto = (Convert.ToDecimal(sumaStock) == 0)? _stockProducto :  sumaStock.ToString();

                            if (Convert.ToDecimal(_stockProducto) < 1 && _usaInventario == "SI")
                            {
                                gdvBuscar.Visible = false;
                                timer1.Start();
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
                                dr2["PZA X CAJA"] = lstProducto.Select(x => x.TotalUnidades).FirstOrDefault();
                                dr2["PRESENTACIÓN"] = lstProducto.Select(x => x.Presentacion).FirstOrDefault();
                                dr2["PRECIO"] = precio;
                                dr2["IMPORTE"] = precio;
                                dr2["STOCK"] = _usaInventario.Equals("SI") ? (Convert.ToDecimal(_stockProducto) - _totalUnidades).ToString(): "123456";
                                dr2["CODIGO"] = lstProducto.Select(x => x.codigo).FirstOrDefault();
                                dr2["USAINVENTARIO"] = lstProducto.Select(x => x.usaInventario).FirstOrDefault();
                                dr2["APARTIR"] = lstProducto.Select(x => x.APartirDe).FirstOrDefault();

                                dt2.Rows.Add(dr2);
                                txtBuscar.Clear();
                            }
                        }
                    }
                    lstProducto = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto ingresado no existe!,\n verifique que haya ingresado corectamente los datos" + ex.Message, "BUSQUEDA FALLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lstProducto = null;
                SumaTotal_a_Pagar();
                DataTablePersonalizado.Multilinea(ref gdvVentas);
            }
        }

        #endregion

        #region GRID VENTAS

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
            decimal _auxCantidad=0;
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

                    //_precioMM = new BusProducto().ListarProductos(_strCodigo).Select(x => x.precioMMayoreo).FirstOrDefault();
                    Producto p = new BusProducto().ObtenerProducto(_strCodigo);
                    _precioMM = p.precioMMayoreo;
                    _strPresentacion = p.PresentacionMenudeo;

                    if (_precioActual == p.precioMayoreo || _strUnidadMedida == "CJA" || _strUnidadMedida == "BTO"
                        ||  _strUnidadMedida == "RJA" || _strUnidadMedida == "SX" )
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
                            //decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[9].Value.ToString());
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
                        if (_precioActual == p.precioMayoreo || _strUnidadMedida == "CJA" || _strUnidadMedida == "BTO"
                        || _strUnidadMedida == "RJA" || _strUnidadMedida == "SX" )
                        {
                            gdvVentas.Rows[e.RowIndex].Cells[7].Value = _precioActual;
                            gdvVentas.Rows[e.RowIndex].Cells[8].Value = cantidad * _precioActual;
                           // gdvVentas.Rows[e.RowIndex].Cells[2].Value = ((stock - _auxCantidad)/p.TotalUnidades).ToString();
                        }
                        else if (_precioMM != 0 && cantidad >= _ApartiDe)//ACTUALIZA EL PRECIO MEDIO MAYOREO
                        {
                            gdvVentas.Rows[e.RowIndex].Cells[7].Value = _precioMM;
                            gdvVentas.Rows[e.RowIndex].Cells[8].Value = cantidad * _precioMM;
                            //gdvVentas.Rows[e.RowIndex].Cells[2].Value = p.stock;
                            //gdvVentas.Rows[e.RowIndex].Cells[2].Value = (stock- cantidad).ToString();
                        }
                        else
                        {
                            gdvVentas.Rows[e.RowIndex].Cells[7].Value = p.precioMenudeo;
                            precio = decimal.Parse(gdvVentas.Rows[e.RowIndex].Cells[7].Value.ToString());
                            gdvVentas.Rows[e.RowIndex].Cells[8].Value = cantidad * precio;
                            //gdvVentas.Rows[e.RowIndex].Cells[2].Value = (stock -cantidad).ToString();
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
                    cantidad = 0;
                    precio = 0;
                    stock = 0;
                }

            }
        }

        private void gdvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gdvVentas.Columns[e.ColumnIndex].Name == "PRECIO")
                {
                   
                    lblProducto.Text = gdvVentas.Rows[e.RowIndex].Cells[4].Value.ToString();
                    var _auxProducto = gdvVentas.Rows[e.RowIndex].Cells[4].Value.ToString();
                    lblId.Text = gdvVentas.Rows[e.RowIndex].Cells[1].Value.ToString();
                    lblUnidad.Text = gdvVentas.Rows[e.RowIndex].Cells[3].Value.ToString();
                    decimal _PrecioActual =Convert.ToDecimal( gdvVentas.Rows[e.RowIndex].Cells[7].Value.ToString());

                    Producto p = new BusProducto().ObtenerProducto(_auxProducto);

                    rbtnMenudeo.Checked = p.precioMenudeo == _PrecioActual ? true : false;
                    rbtnMMayoreo.Checked = p.precioMMayoreo == _PrecioActual ? true : false;
                    rbtnMayoreo.Checked = p.precioMayoreo == _PrecioActual ? true : false;

                    lblMenudeo.Text = p.precioMenudeo.ToString();
                    lblMMayoreo.Text = p.precioMMayoreo.ToString() == "0.00" ? "N/A" : p.precioMMayoreo.ToString();
                    lblMayoreo.Text = p.precioMayoreo.ToString();

                    if (lblMMayoreo.Text.Equals("N/A"))
                        rbtnMMayoreo.Enabled = false;
                    else
                        rbtnMMayoreo.Enabled = true;

                    pnlCambioPrecios.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar el catálogo de precios : "+ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
       
        private void ModificarPrecios(string tipoPrecio, string precio)
        {
            DataTable dt2 = new DataTable();
            dt2 = gdvVentas.DataSource as DataTable;

            int codigo1 = Convert.ToInt32(lblId.Text);
            var codigo = lblId.Text;
            Producto p = new BusProducto().ObtenerProducto(lblProducto.Text);
            try
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
                        unidad = lsTipoPresentacion.Where(x => x.Id.Equals(presentacion)).Select(x => x.Descripcion).FirstOrDefault();
                    }
                    else if (tipoPrecio == "MEDIO MAYOREO")
                    {
                        unidad = lsTipoPresentacion.Where(x => x.Id.Equals(presentacion)).Select(x => x.Descripcion).FirstOrDefault();
                        if (unidad == "BTO")
                        {
                            unidad = "KG";
                        }
                        if (unidad == "CJA" || unidad.Equals("PQTE") || unidad.Equals("BSA") || unidad.Equals("RJA"))
                        {
                            unidad = "PZA";
                        }

                        if (p.PresentacionMenudeo.Equals("PAQUETE"))
                        {
                            unidad = "PQTE";
                        }
                    }
                    else if(tipoPrecio == "MENUDEO")
                    {
                        unidad = lsTipoPresentacion.Where(x => x.Id.Equals(presentacion)).Select(x => x.Descripcion).FirstOrDefault();
                        if (unidad == "BTO")
                        {
                            unidad = "KG";
                        }
                        if (unidad == "CJA" || unidad.Equals("PQTE") || unidad.Equals("BSA") || unidad.Equals("RJA"))
                        {
                            unidad = "PZA";
                        }

                        if (p.PresentacionMenudeo.Equals("PAQUETE"))
                        {
                            unidad = "PQTE";
                        }
                    }

                   // Decimal _precioModificado = tipoPrecio.Equals();

                    d[0].SetField("PRECIO", Convert.ToDecimal(precio));
                    d[0].SetField("CANTIDAD", valor);
                    d[0].SetField("IMPORTE", Convert.ToDecimal(precio) * valor);

                    if (tipoPrecio != "PREFERENCIAL")
                        d[0].SetField("UNIDAD", unidad);

                    txtBuscar.Clear();
                }
                lblProducto.Text = "";
                lblId.Text = "";
                pnlCambioPrecios.Visible = false;
                chckPrecioPreferencial.Checked = false;
                txtPrecioPreferencial.Text = "0";
                txtPrecioPreferencial.Visible = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message, "Error al actualizar el precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void chckPrecioPreferencial_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chckPrecioPreferencial.Checked)
            {
                txtPrecioPreferencial.Visible = true;
                txtPrecioPreferencial.Focus();
            }
            else
            {
                txtPrecioPreferencial.Visible = false;
            }
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void rbtnMenudeo_Click(object sender, EventArgs e)
        {
            ModificarPrecios("MENUDEO", lblMenudeo.Text);
        }

        private void rbtnMMayoreo_Click(object sender, EventArgs e)
        {
            ModificarPrecios("MEDIO MAYOREO", lblMMayoreo.Text);
        }

        private void rbtnMayoreo_Click(object sender, EventArgs e)
        {
            ModificarPrecios("MAYOREO", lblMayoreo.Text);
        }

        private void txtPrecioPreferencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
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
            }
        }

        #endregion

        #region PANEL COBRO

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pnlCambioPrecios.Visible = false;
            txtPrecioPreferencial.Clear();
            txtPrecioPreferencial.Visible = false;
            chckPrecioPreferencial.Checked = false;
        }

        private void txtRecibi_TextChanged(object sender, EventArgs e)
        {
            decimal recibi;
            if (string.IsNullOrEmpty(txtRecibi.Text) || txtRecibi.Equals("0"))
            {
                txtRecibi.Text = "0";
                txtRecibi.SelectAll();
            }
            else if (esVentaNueva == true)
            {
                recibi = Convert.ToDecimal(txtRecibi.Text);
                decimal cambio = recibi - (Convert.ToDecimal(lblPagoTotal.Text));
                txtCambio.Text =  cambio.ToString();
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
                venta.Folio = lblSerie.Text + "-" + lblCorrelativo.Text;
                venta.MontoTotal = Convert.ToDecimal(lblTotal.Text);
                venta.FormaPago = cboFormaPago.Text;
                venta.EstadoPago = cboFormaPago.Text.Equals("Contado") && saldoCredito == 0 ? "PAGADO" : "PENDIENTE";
                venta.Comprobante = lblComprobante.Text;
                venta.FechaLiquidacion = cboFormaPago.Text.Equals("Credito") ? dtpFechaPago.Value.ToString() : "N/A";
                venta.Accion = "VENTA REALIZADA";
                venta.Saldo = saldoCredito;
                venta.TipoPago = 0;
                venta.ReferenciaTarjeta = "N/A";
                venta.Efectivo = Convert.ToDecimal(txtRecibi.Text);
                venta.Vuelto = Convert.ToDecimal(txtCambio.Text);
                

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
                    d.Stock = dr.Cells["STOCK"].Value.ToString().Equals("123456") ? "ILIMITADO" : Convert.ToString(dr.Cells["STOCK"].Value) ;
                    d.Codigo = Convert.ToString(dr.Cells["CODIGO"].Value);
                    d.UsaInventario = Convert.ToString(dr.Cells["USAINVENTARIO"].Value);
                    d.Se_Vende_A = "0";
                    d.Costo = 0;

                    new BusDetalleVenta().Agregar_DetalleVenta(d);
                    Producto p = new BusProducto().ObtenerProducto(d.Codigo);
                    if (d.UsaInventario == "SI" && (Convert.ToDecimal(p.stock) - d.Cantidad) >= 0)
                    {
                        
                        string presentancion = d.UnidadMedida;
                        if (p.precioMayoreo == d.Precio || presentancion.Equals("PQTE") || presentancion.Equals("SIX") 
                            || presentancion.Equals("CJA") || presentancion.Equals("BTO") || presentancion.Equals("RJA"))
                        {
                            decimal cantidadVendida = Convert.ToDecimal( p.TotalUnidades * d.Cantidad);

                            new BusProducto().Actualizar_Stock(d.IdProducto, (Convert.ToDecimal(p.stock) - cantidadVendida));
                        }
                        else
                        {
                            new BusProducto().Actualizar_Stock(d.IdProducto, (Convert.ToDecimal(p.stock) - d.Cantidad));
                        }
                        
                    }
                }

                new BusSerializacion().Actualizar_numeroFin(lblNumeroFin.Text, Convert.ToInt32(lblIdSerializacion.Text));

                if (!String.IsNullOrEmpty( VentaEspera))
                {
                    new BusDetalleVenta().Eliminar_DetalleVentaEspera(idVenta);
                    new BusVentas().Eliminar_VentaEspera(idVenta);
                }

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
                MessageBox.Show("Error al obtener las impresoras : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            gdvClientes.Visible = false;
            gdvVentas.DataSource = null;
            pnlCobrar.Visible = false;
            lblTotal.Text = "0.00";
            VentaEspera = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                pnlAgotado.Visible = true;
            }
            else
            {
                txtBuscar.SelectAll();
                txtBuscar.Focus();
                pnlAgotado.Visible = false;
                progressBar1.Value = 0;
                timer1.Stop();
            }
        }

        int valor = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            ProgressBar pb = new ProgressBar();
            pb.Value = valor;
            if (pb.Value < 50)
            {
                valor += 25;
                txtRecibi.Text = "0";
                txtRecibi.Focus();
                txtRecibi.SelectAll();
            }
            else
            {
                txtRecibi.Focus();
                txtRecibi.SelectAll();
                timer2.Stop();
                valor = 0;
            }
        }

        private void cobrarSinTicketF11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                indicador = "VISTA PREVIA";

                NumeroATexto();
                if (cboFormaPago.Text == "Credito" && txtCliente.Text == "GENERAL")
                {
                    MessageBox.Show("No puede realizar un venta a crédito con cliente de tipo general, Seleccione el cliente para procesar la venta", "Venta no generada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    GenerarVenta();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al insertar la venta " + ex.Message, "Error de inseción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cobrarYGenerarTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            indicador = "IMPRIMIR DIRECTO";

            if (cboFormaPago.Text == "Credito" && txtCliente.Text == "GENERAL")
            {
                MessageBox.Show("No puede realizar un venta a crédito con cliente de tipo general, Seleccione el cliente para procesar la venta", "Venta no generada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
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
                            MessageBox.Show("Error al imprimir el ticket : " + ex.Message, "Error de impresión", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void CobrarVenta()
        {
            try
            {
                esVentaNueva = true;
                if (gdvVentas.DataSource == null)
                {
                    MessageBox.Show("NO HAY PRODUCTOS EN VENTA", "COBRO NO AUTORIZDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // txtRecibi.Clear();
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
                    timer2.Start();
                    Dibujar_BotonComprobante();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al ingresar la venta" + ex.Message, "Venta no generada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region  VENTAS EN ESPERA

        private void GenerarVenta_EnEspera()
        {
            try
            {
                VentaEspera venta = new VentaEspera();
                venta.IdCaja = idCaja;
                string serial = EncriptarTexto.Encriptar(serialPC);
                venta.IdUsuario = new BusUser().ObtenerUsuario(serial).Id;
                venta.FechaVenta = DateTime.Now;
                venta.Referencia = txtCliente.Text;
                venta.IdCliente = txtCliente.Text.Equals("GENERAL") ? 1 : idCliente;
                venta.MontoTotal = Convert.ToDecimal(lblTotal.Text);

                new BusVentas().AgregarVentaEspera(venta);

                foreach (DataGridViewRow dr in gdvVentas.Rows)
                {
                    DetalleVentaEspera d = new DetalleVentaEspera();
                    d.IdPresentacion = Convert.ToInt32(dr.Cells["PRESENTACION_ID"].Value);
                    d.IdProducto = Convert.ToInt32(dr.Cells["ID"].Value);
                    d.Cantidad = Convert.ToDecimal(dr.Cells["CANTIDAD"].Value);
                    d.Precio = Convert.ToDecimal(dr.Cells["PRECIO"].Value);
                    d.TotalPago = Convert.ToDecimal(dr.Cells["IMPORTE"].Value);
                    d.UnidadMedida = dr.Cells["UNIDAD"].Value.ToString();
                    d.Descripcion = Convert.ToString(dr.Cells["CONCEPTO"].Value);
                    d.Stock = Convert.ToString(dr.Cells["STOCK"].Value);
                    d.UsaInventario = Convert.ToString(dr.Cells["USAINVENTARIO"].Value);

                    new BusDetalleVenta().Agregar_DetalleVentaEspera(d);
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar de la venta : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
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
                dt.Columns.Add("USAINVENTARIO");
                // DataRow dr = dt.NewRow();

                List<DetalleVentaEspera> detalleVenta = new BusVentas().ListarDetalle_VentaEnEspera(idVenta);

                foreach (var item in detalleVenta)
                {
                    dt.Rows.Add(item.IdPresentacion,
                                 item.IdProducto,
                                 item.Cantidad,
                                 item.UnidadMedida,
                                 item.Descripcion,
                                 item.Descripcion,
                                 item.Descripcion,
                                 item.Precio,
                                 item.TotalPago,
                                 item.Stock,
                                 item.Codigo,
                                 item.UsaInventario
                        );
                }

                gdvVentas.DataSource = dt;
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

                DataTablePersonalizado.Multilinea(ref gdvVentas);

                txtCliente.Text = new BusCliente().ObterCliente(idCliente).NombreCompleto;
                gdvClientes.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el detalle de la venta : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SumaTotal_a_Pagar();
            }
        }

        private void enEsperaF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvVentas.Rows.Count == 0)
                {
                    MessageBox.Show("No puede agregar una venta en espera sin datos  en la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GenerarVenta_EnEspera();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar de la venta : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region BOTONES VENTA

        private void cancelarVentaF9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gdvVentas.Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea cancelar la venta", "Cancelar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    gdvVentas.DataSource = null;
                    lblTotal.Text = "0.00";
                }
            }
        }

        private void cobrarF10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CobrarVenta();
        }

        #endregion

        #region MENU SUPERIOR

        private void VentaEnEsperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<VentaEspera> lstVentas = new BusVentas().Listar_VentasEnEspera();

            if (lstVentas.Count != 0)
            {
                frmVentasEnEspera ventasEnEspera = new frmVentasEnEspera();
                ventasEnEspera.FormClosing += frm_FormClosing;
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
            if (RolUsuario.Equals("ADMINISTRADOR"))
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

        private void pnlVentas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
