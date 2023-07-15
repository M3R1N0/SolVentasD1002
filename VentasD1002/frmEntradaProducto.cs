using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
using Microsoft.Vbe.Interop;
using System;
using System.Text;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmEntradaProducto : Form
    {
        ProductoVM _producto;
        EntradaProductoVM ultimaEntrada;

        public frmEntradaProducto()
        {
            InitializeComponent();
        }

        private void txtCantMayoreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Comun.TextBoxNumerico(sender, e);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var busqueda = txtBuscar.Text ?? "";

                if (busqueda != "")
                {
                    var data = ProductoDAL.FiltrarProductos_UsaInventario(busqueda);
                    gdvResultado.DataSource = data;
                    Comun.StyleDatatable(ref gdvResultado);

                    foreach (DataGridViewColumn col in gdvResultado.Columns)
                    {
                        col.Visible = false;
                        if (col.Name.ToString().Equals("Articulo"))
                        {
                            col.Visible = true;
                        }
                    }

                    gdvResultado.Visible = true;
                }
            }
            catch (Exception)
            {
                gdvResultado.Visible = false;
            }
        }

        private void gdvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _producto = ((DataGridView)sender).CurrentRow.DataBoundItem as ProductoVM;
            MostrarProducto(_producto);
          
            txtBuscar.Clear();
        }

        private void MostrarProducto(ProductoVM producto)
        {
            try
            {
                LimpiarCampos();
                _producto = producto;
                ultimaEntrada = ProductoDAL.ObtenerUltimaEntrada(_producto.Id, TIPO_CONSULTA_ENTRADA.ENTRADA_PRODUCTO.ToString());

                decimal stockActual = (producto.Stock + ultimaEntrada.TotalIngresado) / producto.UnidadesPorPresentacion;
                decimal pzas = (producto.Stock + ultimaEntrada.TotalIngresado) % producto.UnidadesPorPresentacion;

                lblArticulo.Text = _producto.Articulo;
                txtCosto.Text = ultimaEntrada.PrecioCompra.ToString("#.##");
                txtGanancia.Text = ultimaEntrada.GananciaMayoreo.ToString("#.##");
                txtVenta.Text = _producto.Precio.ToString("#.##");
                txtMayoreo.Text = _producto.PrecioMayoreo.ToString("#.##");
                txtApartirDe.Text = _producto.A_Partir_De.ToString();
                DatCatGenerico.ObtenerCatalogo_Presentacion(ref cboPresentacion, _producto.idPresentacion);

                if (_producto.IdProductoU != 0)
                {
                    gbMenudeo.Enabled = true;
                    DatCatGenerico.ObtenerCatalogo_Presentacion(ref cboPrsentacionMenudeo, _producto.IdPresentacionU);
                    txtCostoU.Text = ultimaEntrada.PrecioMenudeo.ToString("#.##");
                    txtGananciaU.Text = ultimaEntrada.GananciaMenudeo.ToString("#.##");
                    txtVentaU.Text = _producto.PrecioU.ToString("#.##");
                    txtMayoreoU.Text = _producto.PrecioMayoreoU.ToString("#.##");
                    txtApartirDeU.Text = _producto.A_Partir_DeU.ToString();
                }
                else
                {
                    gbMenudeo.Enabled = false;
                    txtCostoU.Clear();
                    txtGananciaU.Clear();
                    txtVentaU.Clear();
                    txtMayoreoU.Clear();
                    txtApartirDeU.Clear();
                }

                //lblCantMay.Text = cboPresentacion.Text + " CON ";
                //lblCantMen.Text = cboPrsentacionMenudeo.Text + "(S).";

                stockActual = Math.Floor(stockActual);
                lblStockActual.Text = (stockActual == 0)
                                    ? "0 " + cboPresentacion.Text + "(S) C/ " + pzas + " " + cboPrsentacionMenudeo.Text + "(S)"
                                    : stockActual.ToString() + " " + cboPresentacion.Text + "(S) C/ " + pzas + " " + cboPrsentacionMenudeo.Text + "(S)";
            }
            catch (Exception)
            {
                gdvResultado.Visible = false;
            }
        }

        private void LimpiarCampos()
        {
            gdvResultado.Visible = false;
            DatCatGenerico.ObtenerCatalogo_Presentacion(ref cboPresentacion, 1);
            DatCatGenerico.ObtenerCatalogo_Presentacion(ref cboPrsentacionMenudeo, 1);
            Comun.LimpiarTextBox(this.Controls);
            lblArticulo.Text = "Articulo";
            lblCantMay.Text = "CAJAS CON";
            lblCantMen.Text = "PIEZA(S)";
            chkAplicarCambios.Value = false;
            chkCaducidad.Value = false;
            dpCaducidad.Value = DateTime.Now;

        }

        private void txtVenta_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
                decimal resultado = 0;
                try
                {
                    decimal costo = string.IsNullOrEmpty(txtCosto.Text) ? 0 : Convert.ToDecimal(txtCosto.Text);
                    decimal ganancia = string.IsNullOrEmpty(txtGanancia.Text) ? 0 : Convert.ToDecimal(txtGanancia.Text);
                    decimal venta = string.IsNullOrEmpty(txtVenta.Text) ? 0 : Convert.ToDecimal(txtVenta.Text);

                    if (costo != 0)
                    {
                        txtGanancia.Text = new BusProducto().CalcularPorcentajeGanancia(costo, venta);
                    }
                    else if (ganancia != 0)
                    {
                        txtCosto.Text = new BusProducto().CalcularPrecioVenta(venta, ganancia);
                    }

                }
                catch (Exception)
                {
                    txtGanancia.Text = "0";
                }
           // }
        }

        private void txtCosto_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
           
            //}
        }

        private void ActualizarDatosMenudeo()
        {
            try
            {
                decimal costo = string.IsNullOrEmpty(txtCosto.Text) ? 0 : Convert.ToDecimal(txtCosto.Text);
                decimal ganancia = string.IsNullOrEmpty(txtGanancia.Text) ? 0 : Convert.ToDecimal(txtGanancia.Text);
                decimal venta = string.IsNullOrEmpty(txtVenta.Text) ? 0 : Convert.ToDecimal(txtVenta.Text);

                txtCostoU.Text = (costo / _producto.UnidadesPorPresentacion).ToString("#.##");
                decimal costoU = string.IsNullOrEmpty(txtCostoU.Text) ? 0 : Convert.ToDecimal(txtCostoU.Text);
                decimal ventaU = string.IsNullOrEmpty(txtVentaU.Text) ? 0 : Convert.ToDecimal(txtVentaU.Text);

                if (string.IsNullOrEmpty(txtGananciaU.Text) || txtGananciaU.Text == "0")
                {
                    txtGananciaU.Text = new BusProducto().CalcularPorcentajeGanancia(costoU, ventaU);
                }

                txtVentaU.Text = new BusProducto().CalcularPrecioVenta(costoU, Convert.ToDecimal(txtGananciaU.Text));
            }
            catch (Exception)
            {
            }
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            if ( lblArticulo.Text != "Articulo")
            {
                if (ValidarCampos())
                {
                    AgregarEntrada(); 
                }
            }
            else
            {
                MessageBox.Show("Seleccione un artículo válido","ARTICULO NO SELECCIONADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private bool ValidarCampos()
        {
            StringBuilder strBuilder = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrEmpty(txtCantMayoreo.Text) || txtCantMayoreo.Text == "0")
            {
                isValid = false;
                strBuilder.Append("- El total a ingresar deber ser mayor a 0.\n");
            }

            if (string.IsNullOrEmpty(txtCosto.Text) || txtCosto.Text == "0")
            {
                isValid = false;
                strBuilder.Append("- El precio de compra debe ser mayor a cero \n");
            }

            if (string.IsNullOrEmpty(txtGanancia.Text) || txtGanancia.Text == "0")
            {
                isValid = false;
                strBuilder.Append("- La ganancia debe ser mayor a cero. \n");
            }

            if (gbMenudeo.Enabled)
            {
               
                if (string.IsNullOrEmpty(txtCostoU.Text) || txtCostoU.Text == "0")
                {
                    isValid = false;
                    strBuilder.Append("- El precio de compra menudeo debe ser mayor a cero. \n");
                }

                if (string.IsNullOrEmpty(txtGananciaU.Text) || txtGananciaU.Text == "0")
                {
                    isValid = false;
                    strBuilder.Append("- La ganancia menudeo debe ser mayor a cero. \n");
                }
            }

            if (!isValid)
            {
                MessageBox.Show("Se encontraron las siguientes observaciones:\n\n" + strBuilder.ToString() +"\n *****FAVOR DE REVISAR*****", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isValid;
        }

        private void AgregarEntrada()
        {
            try
            {
                EntradaProductoVM nuevaEntrada = new EntradaProductoVM();
                var unidades = (string.IsNullOrEmpty(txtCantUnitario.Text)) ? 0 : Convert.ToDecimal(txtCantUnitario.Text);
                var nuevoStock = Convert.ToDecimal(txtCantMayoreo.Text) * _producto.UnidadesPorPresentacion;
                decimal Unidades = string.IsNullOrWhiteSpace(txtCantUnitario.Text) ? 0 : Convert.ToDecimal(txtCantUnitario.Text);

                nuevaEntrada.Id = 0;
                nuevaEntrada.IdProducto = _producto.Id;
                nuevaEntrada.PrecioCompra = Convert.ToDecimal(txtCosto.Text);
                nuevaEntrada.GananciaMayoreo = Convert.ToDecimal(txtGanancia.Text);
                nuevaEntrada.GananciaMenudeo = Convert.ToDecimal(txtGananciaU.Text);
                nuevaEntrada.GananciaMayoreoM = Convert.ToDecimal(txtMayoreo.Text);
                nuevaEntrada.GananciaMayoreoU = Convert.ToDecimal(txtMayoreoU.Text);
                nuevaEntrada.TotalIngresado = nuevoStock + unidades;
                nuevaEntrada.Caducidad =(chkCaducidad.Value)  ? dpCaducidad.MinDate : dpCaducidad.Value;
                nuevaEntrada.Estatus = ESTATUS_STOCK.EN_ESPERA.ToString();
                nuevaEntrada.FechaIngreso = DateTime.Now;

                if (chkCaducidad.Value)
                {
                    nuevaEntrada.Caducidad = dpCaducidad.MinDate;
                }

                if (ultimaEntrada.Estatus == ESTATUS_STOCK.EN_ESPERA.ToString())
                {
                    var result = MessageBox.Show($"Actualmente existe un lote del producto en espera con fecha de ingreso :{ultimaEntrada.FechaIngreso.ToString("dd/MM/yyy")}\n" +
                                                 $"¿Desea agregarlo al existente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        nuevaEntrada.Id = ultimaEntrada.Id;
                        nuevaEntrada.TotalIngresado += ultimaEntrada.TotalIngresado;
                    }
                }

                ProductoDAL.GuardarEntrada(nuevaEntrada);

                if (chkAplicarCambios.Value)
                {
                    _producto.idPresentacion = Convert.ToInt32(cboPresentacion.SelectedValue);
                    _producto.Precio = Convert.ToDecimal(txtVenta.Text);
                    _producto.PrecioMayoreo = Convert.ToDecimal(txtMayoreo.Text);
                    _producto.A_Partir_De = Convert.ToDecimal(txtApartirDe.Text);

                    var precioUnitario = (string.IsNullOrEmpty(txtCostoU.Text)) ? 0 : Convert.ToDecimal(txtCostoU.Text);
                    var precioUnitarioM = (string.IsNullOrEmpty(txtMayoreoU.Text)) ? 0 : Convert.ToDecimal(txtMayoreoU.Text);
                    var ApartirDeU = (string.IsNullOrEmpty(txtApartirDeU.Text)) ? 0 : Convert.ToDecimal(txtApartirDeU.Text);

                    if (gbMenudeo.Enabled)
                    {
                        _producto.PrecioU = precioUnitario;
                        _producto.PrecioMayoreoU = precioUnitarioM;
                        _producto.A_Partir_DeU = ApartirDeU;
                    }

                    ProductoDAL.ActualizarPrecio(_producto);
                }

                MessageBox.Show("Datos guardados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception )
            {
                MessageBox.Show("Ocurrió un detalle inesperado al agregar los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABProducto frm = new frmABProducto();
            frm.ShowDialog();
        }

        private void frmEntradaProducto_Load(object sender, EventArgs e)
        {
            DatCatGenerico.ObtenerCatalogo_Presentacion(ref cboPresentacion, 1);
            DatCatGenerico.ObtenerCatalogo_Presentacion(ref cboPrsentacionMenudeo, 1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Close();
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal costo = string.IsNullOrEmpty(txtCosto.Text) ? 0 : Convert.ToDecimal(txtCosto.Text);
                decimal ganancia = string.IsNullOrEmpty(txtGanancia.Text) ? 0 : Convert.ToDecimal(txtGanancia.Text);
                decimal venta = string.IsNullOrEmpty(txtVenta.Text) ? 0 : Convert.ToDecimal(txtVenta.Text);

                if (venta != 0)
                {
                    txtGanancia.Text = new BusProducto().CalcularPorcentajeGanancia(costo, venta);
                }
                else if (ganancia != 0)
                {
                    txtVenta.Text = new BusProducto().CalcularPrecioVenta(costo, ganancia);
                }

                if (gbMenudeo.Enabled)
                {
                    ActualizarDatosMenudeo();
                }
            }
            catch (Exception)
            {
                txtGanancia.Text = "0";
            }
        }

        private void txtGananciaU_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                decimal costo = string.IsNullOrEmpty(txtCostoU.Text) ? 0 : Convert.ToDecimal(txtCostoU.Text);
                decimal ganancia = string.IsNullOrEmpty(txtCostoU.Text) ? 0 : Convert.ToDecimal(txtGananciaU.Text);
                decimal venta = string.IsNullOrEmpty(txtVentaU.Text) ? 0 : Convert.ToDecimal(txtVentaU.Text);

                txtVentaU.Text = new BusProducto().CalcularPrecioVenta(costo, ganancia);
            }
            catch (Exception)
            {
            }
        }

        private void txtVentaU_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                decimal costo = string.IsNullOrEmpty(txtCostoU.Text) ? 0 : Convert.ToDecimal(txtCostoU.Text);
                decimal ganancia = string.IsNullOrEmpty(txtGananciaU.Text) ? 0 : Convert.ToDecimal(txtGananciaU.Text);
                decimal venta = string.IsNullOrEmpty(txtVentaU.Text) ? 0 : Convert.ToDecimal(txtVentaU.Text);

                txtGananciaU.Text = new BusProducto().CalcularPorcentajeGanancia(costo, venta);
            }
            catch (Exception)
            {
            }
        }
    }
}
