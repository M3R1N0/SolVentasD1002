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
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmABProducto : Form
    {
        public static string TipoPresentacion;
        public static string Categoria;
        public static string PresentacionMenudeo;
        public static bool EsNuevo;
        private bool EsCargaBatch = false;
        private int idUsuario;
        private int idCaja;
        private string serialPC;

        private ProductoVM _producto = new ProductoVM();

        public frmABProducto()
        {
            InitializeComponent();
            lblIdProducto.Text = "0";
            EsNuevo = true;
            txtcodigodebarras.ReadOnly = false;
        }

        public frmABProducto(int idproducto)
        {
            InitializeComponent();
            ObtenerProducto(idproducto);
            EsNuevo = false;
        }

        public frmABProducto(ProductoVM producto)
        {
            InitializeComponent();
            var p = producto;
            ValidarProducto(p);
            EsNuevo = false;
        }

        private void ValidarProducto(ProductoVM producto)
        {
            try
            {
                EsCargaBatch = true;
                txtcodigodebarras.ReadOnly = true;
                _producto = producto;
                txtcodigodebarras.ReadOnly = true;
                txtcodigodebarras.Text = producto.codigo;
                lblIdProducto.Text = producto.Id.ToString();
                txtClave.Text = producto.Clave;
                txtdescripcion.Text = producto.Articulo;
                txtPresentacion.Text = producto.Detalle;
                porunidad.Checked = producto.TipoVenta.Equals(EnumTipoVenta.UNIDAD.ToString()) ? true : false;
                agranel.Checked = (porunidad.Checked) ? false : true;
                txtpreciomayoreo.Text = producto.Precio.ToString();
                txtMayoreo2.Text = producto.PrecioMayoreo.ToString();
                txtApartideMayoreo.Text = producto.A_Partir_De.ToString();
                txtPesoMayoreo.Text = producto.Peso.ToString();
                txtTotalUnidades.Text = producto.UnidadesPorPresentacion.ToString();

                txtCompraMay.Text = producto.PrecioCompra.ToString();

                gbMenudeo.Enabled = false;
                if (producto.IdProductoU != 0)
                {
                    gbMenudeo.Enabled = true;
                    txtCompraMen.Text = producto.PrecioCompraU.ToString();
                    txtPMenudeo.Text = producto.PrecioU.ToString();
                    txtPMMayoreo.Text = producto.PrecioMayoreoU.ToString();
                    txtApartirDeMM.Text = producto.A_Partir_DeU.ToString();
                    txtCodigoU.Text = producto.CodigoU;
                    chkPrecioMenudeo.Value = true;
                }

                CheckInventarios.Checked = false;
                PANELINVENTARIO.Visible = false;

                if (producto.UsaInventario)
                {
                    CheckInventarios.Checked = true;
                    PANELINVENTARIO.Visible = true;
                    decimal _unidades = (producto.Stock % producto.UnidadesPorPresentacion);
                    txtstockminimo.Text = (producto.StockMinimo / producto.UnidadesPorPresentacion).ToString();
                }

                No_aplica_fecha.Checked = (producto.Caducidad == Convert.ToDateTime("1/1/1900")) ? false : true;
                txtfechaoka.Value = (producto.Caducidad == Convert.ToDateTime("1/1/1900")) ? DateTime.Now : producto.Caducidad;

                ListatCatalogos(producto.idPresentacion, producto.IdPresentacionU, producto.IdCategoria, producto.IdProveedor, producto.IdMarca);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al obtener los datos : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //============================================================================================================
        private void ListatCatalogos(int idMayoreo,int idMenudeo, int idCategoria, int idProveedor, int idMarca)
        {
            try
            {
                DatCatGenerico.ObtenerCatalogo_Presentacion(ref cboPresentacion, idMayoreo);
                DatCatGenerico.ObtenerCatalogo_Presentacion(ref cboPresentacionMenudeo, idMenudeo);
                DatCatGenerico.ObtenerCatalogo_TipoProducto(ref cboCategoria, idCategoria);
                DatCatGenerico.ObtenerCatalogo_Proveedor(ref CboProveedor, idProveedor);
                DatCatGenerico.ObtenerCatalogo_Marcas(ref cboMarca, idMarca);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotalUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            Comun.TextBoxNumerico(sender, e);
        }

        private void CheckInventarios_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCheckInventario();   
        }

        private void ValidarCheckInventario()
        {
            PANELINVENTARIO.Visible = CheckInventarios.Checked ? true : false;
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                GuardarProducto();
            }
        }

        private bool ValidarCampos()
        {
            bool isValid = true;
            var strBuilder = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtcodigodebarras.Text))
            {
                isValid = false;
                strBuilder.Append("\n- El código de barra no debe de quedar vacío.");
            }

            if (string.IsNullOrWhiteSpace(txtdescripcion.Text))
            {
                isValid = false;
                strBuilder.Append("\n- Es necesario agregar la descripción.");
            }

            if (string.IsNullOrWhiteSpace(txtcodigodebarras.Text))
            {
                isValid = false;
                strBuilder.Append("\n- El código de barra no debe de quedar vacío.");
            }

            if (!agranel.Checked && !porunidad.Checked)
            {
                isValid = false;
                strBuilder.Append("\n- Debe seleccionar un tipo de venta.");
            }

            if (string.IsNullOrEmpty(txtCompraMay.Text) || txtCompraMay.Text == "0")
            {
                isValid = false;
                strBuilder.Append("\n- Ingrese el precio de compra");
            }

            if (string.IsNullOrEmpty(txtpreciomayoreo.Text) || txtpreciomayoreo.Text == "0")
            {
                isValid = false;
                strBuilder.Append("\n- El precio venta debe ser mayor a 0");
            }

            if (gbMenudeo.Enabled)
            {

                if (string.IsNullOrEmpty(txtCodigoU.Text))
                {
                    isValid = false;
                    strBuilder.Append("\n- Ingrese un codigo unitario válido");
                }


                if (string.IsNullOrEmpty(txtCompraMen.Text) || txtCompraMen.Text == "0")
                {
                    isValid = false;
                    strBuilder.Append("\n- El precio de compra menudeo debe ser mayor a 0");
                }


                if (string.IsNullOrEmpty(txtPMenudeo.Text) || txtPMenudeo.Text == "0")
                {
                    isValid = false;
                    strBuilder.Append("\n- El precio venta unitario debe ser mayor a 0");
                }
            }

            if (!isValid)
            {
                MessageBox.Show("Se encontraron las siguientes observaciones:\n" + strBuilder + "\n\n   ¡FAVOR DE REVISAR SUS DATOS INGRESADOS!   ", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isValid;
        }

        private void GuardarProducto()
        {
            try
            {
                ProductoVM p = new ProductoVM();
                p.Id = Convert.ToInt32(lblIdProducto.Text);
                p.IdProveedor = Convert.ToInt32(CboProveedor.SelectedValue);
                p.IdMarca = Convert.ToInt32(cboMarca.SelectedValue);
                p.IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
                p.idPresentacion = Convert.ToInt32(cboPresentacion.SelectedValue);
                p.Clave = txtClave.Text.Trim();
                p.codigo = txtcodigodebarras.Text.Trim();
                p.Articulo = txtdescripcion.Text.Trim();
                p.Detalle = txtPresentacion.Text.Trim();
                p.PrecioCompra = Convert.ToDecimal(txtCompraMay.Text);
                p.Precio = Convert.ToDecimal(txtpreciomayoreo.Text);
                p.PrecioMayoreo = (string.IsNullOrEmpty(txtMayoreo2.Text)) ? p.Precio: Convert.ToDecimal(txtMayoreo2.Text);
                p.A_Partir_De = (string.IsNullOrEmpty(txtApartideMayoreo.Text)) ? 1 :Convert.ToDecimal(txtApartideMayoreo.Text);
                if (porunidad.Checked == true) p.TipoVenta = EnumTipoVenta.UNIDAD.ToString();
                if (agranel.Checked == true) p.TipoVenta = EnumTipoVenta.GRANEL.ToString();
                p.UsaInventario = (CheckInventarios.Checked) ? true : false;
                p.Stock = 0;
                p.StockMinimo = (string.IsNullOrEmpty(txtstockminimo.Text))
                              ? 0 : Convert.ToDecimal(txtstockminimo.Text) * Convert.ToDecimal(txtTotalUnidades.Text);
                p.UnidadesPorPresentacion = Convert.ToDecimal(txtTotalUnidades.Text);
                p.Caducidad = (No_aplica_fecha.Checked) ? txtfechaoka.MinDate : txtfechaoka.Value;
                p.Peso = (string.IsNullOrEmpty(txtPesoMayoreo.Text)) ? 0 : Convert.ToDecimal(txtPesoMayoreo.Text);

                p.CodigoU = "";
                if (gbMenudeo.Enabled)
                {
                    if (ValidarCamposMenudeo())
                    {
                        p.IdPresentacionU = Convert.ToInt32(cboPresentacionMenudeo.SelectedValue);
                        p.CodigoU = (string.IsNullOrEmpty(txtCodigoU.Text)) ? "" : txtCodigoU.Text.Trim();
                        p.PrecioCompraU = (string.IsNullOrEmpty(txtCompraMen.Text)) ? 0 : Convert.ToDecimal(txtCompraMen.Text);
                        p.PrecioU = (string.IsNullOrEmpty(txtPMenudeo.Text)) ? 0 : Convert.ToDecimal(txtPMenudeo.Text);
                        p.PrecioMayoreoU = (string.IsNullOrEmpty(txtPMMayoreo.Text)) ? 0 : Convert.ToDecimal(txtPMMayoreo.Text);
                        p.A_Partir_DeU = (string.IsNullOrEmpty(txtApartirDeMM.Text)) ? 0 : Convert.ToDecimal(txtApartirDeMM.Text);
                        p.Activo = true; 
                    }
                    else
                    {
                        return;
                    }
                }
                
                ProductoDAL.GuardarProducto(p);
                MessageBox.Show("Datos guardados correctamente", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!EsCargaBatch && p.Id == 0)
                {
                    DialogResult result = MessageBox.Show("Desea agregar un nuevo producto", "Nuevo Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        LimpiarCotroles();
                    }
                    else
                    {
                        LimpiarCotroles();
                        this.Dispose();
                    }
                }
                else
                {
                    LimpiarCotroles();
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposMenudeo()
        {
            bool isValid = true;
            var strBuilder = new StringBuilder();



            if (string.IsNullOrEmpty(txtCodigoU.Text))
            {
                isValid = false;
                strBuilder.Append("\n- Ingrese un codigo unitario válido");
            }


            if (string.IsNullOrEmpty(txtCompraMen.Text) || txtCompraMen.Text == "0")
            {
                isValid = false;
                strBuilder.Append("\n- El precio de compra menudeo debe ser mayor a 0");
            }


            if (string.IsNullOrEmpty(txtPMenudeo.Text) || txtPMenudeo.Text == "0")
            {
                var ventaMenudeo = Convert.ToDecimal(txtPMenudeo.Text);
                var compraMen = Convert.ToDecimal(txtCompraMen.Text);
                var esMayor = ventaMenudeo > compraMen;
                isValid = false;
                strBuilder.Append("\n- El precio venta unitario debe ser mayor a 0");
                strBuilder.Append("\n- El precio venta unitario debe ser mayor al precio de compra");
            }

            if (!isValid)
            {
                MessageBox.Show("Se encontraron las siguientes observaciones:\n" + strBuilder + "\n\n   ¡Favor de configurar de manera correcta el precio menudeo!   ", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isValid;
        }

        private void ObtenerProducto(int idproducto)
        {
            try
            {
                var producto = ProductoDAL.ObtenerProducto(idproducto);
                _producto = producto;
                txtcodigodebarras.ReadOnly = true;
                txtcodigodebarras.Text = producto.codigo;
                lblIdProducto.Text = producto.Id.ToString();
                txtClave.Text = producto.Clave;
                txtdescripcion.Text = producto.Articulo;
                txtPresentacion.Text = producto.Detalle;
                porunidad.Checked = producto.TipoVenta.Equals(EnumTipoVenta.UNIDAD.ToString()) ? true : false;
                agranel.Checked = (porunidad.Checked) ? false : true;
                txtpreciomayoreo.Text = producto.Precio.ToString();
                txtMayoreo2.Text = producto.PrecioMayoreo.ToString();
                txtApartideMayoreo.Text = producto.A_Partir_De.ToString();
                txtPesoMayoreo.Text = producto.Peso.ToString();
                txtTotalUnidades.Text = producto.UnidadesPorPresentacion.ToString();
                lblFechaActualizacion.Text = producto.UltimaActualizacion.ToString();
                txtCompraMay.Text = producto.PrecioCompra.ToString();

                gbMenudeo.Enabled = false;
                if (producto.IdProductoU != 0)
                {
                    gbMenudeo.Enabled = true;
                    txtCompraMen.Text = producto.PrecioCompraU.ToString();
                    txtPMenudeo.Text = producto.PrecioU.ToString();
                    txtPMMayoreo.Text = producto.PrecioMayoreoU.ToString();
                    txtApartirDeMM.Text = producto.A_Partir_DeU.ToString();
                    txtCodigoU.Text = producto.CodigoU;
                    chkPrecioMenudeo.Value = true;
                }

                CheckInventarios.Checked = false;
                PANELINVENTARIO.Visible = false;

                if (producto.UsaInventario)
                {
                    CheckInventarios.Checked = true;
                    PANELINVENTARIO.Visible = true;
                    decimal _unidades = (producto.Stock % producto.UnidadesPorPresentacion);
                    txtstockminimo.Text = (producto.StockMinimo / producto.UnidadesPorPresentacion).ToString();
                }

                No_aplica_fecha.Checked = (producto.Caducidad == Convert.ToDateTime("1/1/1900")) ? false : true;
                txtfechaoka.Value = (producto.Caducidad == Convert.ToDateTime("1/1/1900")) ? DateTime.Now : producto.Caducidad;

                ListatCatalogos(producto.idPresentacion, producto.IdPresentacionU, producto.IdCategoria, producto.IdProveedor,producto.IdMarca);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al obtener los datos : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpiarCotroles()
        {
            porunidad.Checked = false;
            agranel.Checked = false;
            CheckInventarios.Checked = false;
            No_aplica_fecha.Checked = false;
            cboCategoria.SelectedValue = 0;
            cboPresentacion.SelectedValue = 0;
            cboPresentacionMenudeo.SelectedValue = 0;
            gbMenudeo.Enabled = false;
            lblIdProducto.Text = "0";

            Comun.LimpiarTextBox(this.Controls);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var codigo = DateTime.Now.ToString("ddhhmmss");
            txtClave.Text = codigo.ToString();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var codigo = DateTime.Now.ToString("yyMMddhhmmss");
            txtCodigoU.Text ="U-"+ codigo.ToString();
        }

        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            var codigo = DateTime.Now.ToString("yyMMddhhmmss");
            txtcodigodebarras.Text = codigo.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCotroles();
            this.Dispose();
        }

        private void pbCatPresentacion_Click(object sender, EventArgs e)
        {
            frmCatalogo frm = new frmCatalogo("Nombre Corto:", EnumTipoCatalogo.PRESENTACION);
            frm.ShowDialog();
            try
            {
                int id = (lblIdProducto.Text == "0") ? 1 : _producto.idPresentacion;
                int idU = (lblIdProducto.Text == "0") ? 1 : _producto.IdPresentacionU;
                DatCatGenerico.ObtenerCatalogo_Presentacion(ref cboPresentacion, id);
                DatCatGenerico.ObtenerCatalogo_Presentacion(ref cboPresentacionMenudeo, idU);
            }
            catch (Exception)
            {
            }
        }

        private void catProducto_Click(object sender, EventArgs e)
        {
            frmCatalogo frm = new frmCatalogo("Detalle:", EnumTipoCatalogo.CATEGORIA);
            frm.ShowDialog();
            try
            {
                int id = (lblIdProducto.Text == "0") ? 1 : _producto.IdCategoria;
                DatCatGenerico.ObtenerCatalogo_TipoProducto(ref cboCategoria, id);
            }
            catch (Exception)
            {
            }
        }

        private void frmABProducto_Load(object sender, EventArgs e)
        {
            if (lblIdProducto.Text =="0" && EsNuevo)
                ListatCatalogos(1, 1, 1,1,1);
        }

        private void txtpreciomayoreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Comun.TextBoxNumerico(sender, e);
        }

        private void txtpreciomayoreo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApartideMayoreo.Text))
            {
                txtApartideMayoreo.Text = "1";
                txtMayoreo2.Text = txtpreciomayoreo.Text;
            }
        }

        private void txtPMenudeo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApartirDeMM.Text) && !string.IsNullOrEmpty(txtPMenudeo.Text))
            {
                txtApartirDeMM.Text = "1";
                txtPMMayoreo.Text = txtPMenudeo.Text;
            }
        }

        private void txtPMMayoreo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApartirDeMM.Text) && string.IsNullOrEmpty(txtPMenudeo.Text))
            {
                txtApartirDeMM.Text = "1";
                txtPMenudeo.Text = txtPMMayoreo.Text;
            }
        }

        private void chkPrecioMenudeo_OnValueChange(object sender, EventArgs e)
        {
        }

        private void CalcularGanancia()
        {
            try
            {
                decimal costo = Convert.ToDecimal(txtCompraMay.Text);
                decimal numUnidades = Convert.ToDecimal(txtTotalUnidades.Text);
                decimal venta = Convert.ToDecimal(txtpreciomayoreo.Text);
                decimal ganancia = Math.Round((((venta * 100)/costo)-100), 2);

                txtCompraMen.Text = string.Format("{0:N2}", (costo / numUnidades));
                decimal ventaU =(Convert.ToDecimal(txtCompraMen.Text) *(1+(ganancia/100)));
                txtPMenudeo.Text = string.Format("{0:N2}", ventaU);
                txtApartirDeMM.Text = "1";
                txtPMMayoreo.Text = txtPMenudeo.Text;
            }
            catch (Exception)
            {
            }
        }

        private void txtCompraMay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var precio = Convert.ToDecimal(txtCompraMay.Text);
                var unidades = Convert.ToDecimal(txtTotalUnidades.Text);
                txtCompraMen.Text = (precio / unidades).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void chkPrecioMenudeo_Click(object sender, EventArgs e)
        {
            if (chkPrecioMenudeo.Value)
            {
                gbMenudeo.Enabled = true;
                CalcularGanancia();
            }
            else
            {
                gbMenudeo.Enabled = false;
                txtCodigoU.Clear();
                txtCompraMen.Clear();
                txtPMenudeo.Clear();
                txtPMMayoreo.Clear();
                txtApartirDeMM.Clear();
            }
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            frmAltaCliente proveedor = new frmAltaCliente(CLIENTE_PROVEEDOR.PROVEEDOR);
            proveedor.ShowDialog();
            int id = (lblIdProducto.Text == "0") ? 1 : _producto.IdProveedor;
            DatCatGenerico.ObtenerCatalogo_Proveedor(ref CboProveedor, id);
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            frmCatalogo frm = new frmCatalogo("Detalle:", EnumTipoCatalogo.MARCA);
            frm.ShowDialog();
            try
            {
                int id = (lblIdProducto.Text == "0") ? 1 : _producto.IdMarca;
                DatCatGenerico.ObtenerCatalogo_Marcas(ref cboMarca, id);
            }
            catch (Exception)
            {
            }
        }
    }
}
