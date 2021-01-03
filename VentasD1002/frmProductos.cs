using BusVenta;
using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmProductos : Form
    {

        public frmProductos()
        {
            InitializeComponent();
            panelCategoria.Visible = false;
            PANELINVENTARIO.Visible = false;
            pnlABProducto.Visible = false;
            pnlActualizarStock.Visible = false;
        }

        int idUsuario;
        int idCaja;
        string serialPC;

        private void frmProductos_Load_1(object sender, EventArgs e)
        {
            ListarProductos("");
            List<string> lst = new DatProducto().listadoActualizacion();
            ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");

            serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
            //idUsuario = new DatCatGenerico().Obtener_InicioSesion( EncriptarTexto.Encriptar(serialPC) );
            idUsuario = new BusUser().ObtenerUsuario(EncriptarTexto.Encriptar(serialPC)).Id;
            idCaja = new DatBox().Obtener_CajaSerial(serialPC);
        }

        public  void ListarProductos(string buscar)
        {
            try
            {
                List<Producto> lsp = new BusProducto().ListarProductos(buscar);
                gdvProductos.DataSource = lsp;
                
                gdvProductos.Columns[2].Visible = false;
                gdvProductos.Columns[3].Visible = false;
                gdvProductos.Columns[4].Visible = false;
                gdvProductos.Columns[17].Visible = false;
                gdvProductos.Columns[18].Visible = false;
                gdvProductos.Columns[19].Visible = false;
                gdvProductos.Columns[20].Visible = false;
                gdvProductos.Columns[21].Visible = false;
                // BusVenta.DataTablePersonalizado.Multilinea(ref gdvProductos);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarProducto()
        {
            LlenarCategorias();
            lblIdProducto.Text = gdvProductos.SelectedCells[2].Value.ToString();
            cboCategoria.SelectedValue = gdvProductos.SelectedCells[3].Value.ToString();
            cboPresentacion.SelectedValue = gdvProductos.SelectedCells[4].Value.ToString();
            txtcodigodebarras.Text = gdvProductos.SelectedCells[5].Value.ToString();
            txtdescripcion.Text = gdvProductos.SelectedCells[6].Value.ToString();
            txtPresentacion.Text = gdvProductos.SelectedCells[7].Value.ToString();
            // string tipoVenta = gdvProductos.SelectedCells[8].Value.ToString();
            if (gdvProductos.SelectedCells[8].Value.ToString() == "UNIDAD" )
            {
                porunidad.Checked = true;
            }
            else
            {
                agranel.Checked = true;
            }
           // if (tipoVenta == "Unidad") porunidad.Checked = true;
          //  if (tipoVenta == "Granel") agranel.Checked = true;

            txtPMenudeo.Text = gdvProductos.SelectedCells[9].Value.ToString();
            txtPMMayoreo.Text = gdvProductos.SelectedCells[10].Value.ToString();
            txtApartirDe.Text = gdvProductos.SelectedCells[11].Value.ToString();
            txtpreciomayoreo.Text = gdvProductos.SelectedCells[12].Value.ToString();

            string inventario = gdvProductos.SelectedCells[13].Value.ToString();
            txtTotalUnidades.Text = gdvProductos.SelectedCells[20].Value.ToString();

            if (inventario == "SI")
            {
                CheckInventarios.Checked = true;
                PANELINVENTARIO.Visible = true;
                decimal _totalUnidad = Convert.ToDecimal(txtTotalUnidades.Text);
                decimal _stockMaximo = Convert.ToDecimal(gdvProductos.SelectedCells[14].Value);
                decimal _stockMinimo = Convert.ToDecimal(gdvProductos.SelectedCells[15].Value);
                decimal _unidades = (_stockMaximo % _totalUnidad);

                lblPiezasStock.Text = _unidades.ToString();

                txtstock2.Text = Math.Floor((_stockMaximo / _totalUnidad)).ToString();
                txtstockminimo.Text = (_stockMinimo / _totalUnidad).ToString();
                
            }
            else
            {
                CheckInventarios.Checked = false;
                PANELINVENTARIO.Visible = false;
            }

            

           // txtstockminimo.Text = gdvProductos.SelectedCells[15].Value.ToString();
            string fecha = gdvProductos.SelectedCells[16].Value.ToString();
            bool res = (fecha == "NO APLICA") ? No_aplica_fecha.Checked = true : No_aplica_fecha.Checked = false;

            txtfechaoka.Text = (!res) ? fecha : null;
            
            
            string _strPMenudeo = gdvProductos.SelectedCells[21].Value.ToString();

            if (_strPMenudeo.Equals("PIEZA"))
            {
                chkPieza.Checked = true;
            }else if (_strPMenudeo.Equals("CAJA"))
            {
                chkCaja.Checked = true;
            }else if (_strPMenudeo.Equals("BOLSA"))
            {
                chkBolsa.Checked = true;
            } else if (_strPMenudeo.Equals("PAQUETE"))
            {
                chkPaquete.Checked = true;
            }


                pnlABProducto.Visible = true;
            //int categoria = Convert.ToInt32(gdvProductos.SelectedCells[12].Value.ToString());
            //frmAB.cboCategoria.SelectedValue = categoria;
        }

        private void gdvProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.gdvProductos.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este producto?", "Eliminar producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                if (result == DialogResult.OK)
                {
                    //foreach (DataGridViewRow item in gdvProductos.Rows)
                   // {
                        int oneKey = Convert.ToInt32(gdvProductos.SelectedCells[2].Value);
                        try
                        {
                            new BusProducto().BorrarProducto(oneKey);
                            MessageBox.Show("Producto eliminado correctamente", "Operacion realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarProductos("");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    //}
                }
            }

            if (e.ColumnIndex == this.gdvProductos.Columns["Editar"].Index)
            {
                EditarProducto();
            }
        }

        private void btnAgregarCategorias_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreCategoria.Text == "" || txtDescCategoria.Text == "")
                {
                    MessageBox.Show("Favor de llenar los dos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int valor = lblTituloCategorias.Text.Equals("Tipo de Presentación") ? 2 : 1;
                    CatalogoGenerico c = new CatalogoGenerico();
                    c.Nombre = txtNombreCategoria.Text;
                    c.Descripcion = txtDescCategoria.Text;
                    new BusCatGenerico().AgregarCategoriasGenericas(c, valor);
                    LlenarCategorias();
                    panelCategoria.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarCategorias()
        {
            try
            {
                DataTable dtPresentacion = DatVentas.DatCatGenerico.ListarCat_TipoPresentacion();
                cboPresentacion.DataSource = dtPresentacion;
                cboPresentacion.DisplayMember = "Nombre";
                cboPresentacion.ValueMember = "Id_TipoPresentacion";

                DataTable dtProducto = DatVentas.DatCatGenerico.ListarCat_Producto();
                cboCategoria.DataSource = dtProducto;
                cboCategoria.DisplayMember = "Nombre";
                cboCategoria.ValueMember = "Id_CatProducto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbCatPresentacion_Click(object sender, EventArgs e)
        {
            txtNombreCategoria.Clear();
            txtDescCategoria.Clear();
            lblDescCategoria.Text = "Nombre Corto:";
            lblTituloCategorias.Text = "Tipo de Presentación";
            panelCategoria.Visible = true;
        }

        private void catProducto_Click(object sender, EventArgs e)
        {
            txtNombreCategoria.Clear();
            txtDescCategoria.Clear();
            panelCategoria.Visible = true;
            lblTituloCategorias.Text = "Nueva Categoría";
            lblDescCategoria.Text = "Descripción:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCategoria.Visible = false;
            txtDescCategoria.Clear();
            txtNombreCategoria.Clear();
        }

        private void CheckInventarios_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckInventarios.Checked)
            {
                PANELINVENTARIO.Visible = true;
            }
            else
            {
                PANELINVENTARIO.Visible = false;
            }
        }

        private void LimpiarCotroles()
        {
            txtcodigodebarras.Clear();
            txtdescripcion.Clear();
            txtpreciomayoreo.Clear();
            txtPMMayoreo.Clear();
            txtPMenudeo.Clear();
            porunidad.Checked = false;
            agranel.Checked = false;
            CheckInventarios.Checked = false;
            txtstockminimo.Clear();
            txtstock2.Clear();
            No_aplica_fecha.Checked = false;
            cboCategoria.SelectedValue = 0;
            cboPresentacion.SelectedValue = 0;
            txtPresentacion.Clear();
            txtApartirDe.Clear();
            lblIdProducto.Text = "";
            txtTotalUnidades.Clear();
            chkPieza.Checked = false;
            chkPaquete.Checked = false;
            chkBolsa.Checked = false;
            chkCaja.Checked = false;
            lblPiezasStock.Text = "0";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            if (lblIdProducto.Text == "")
            {
                if (txtcodigodebarras.Text == string.Empty | txtdescripcion.Text == "" | txtPMenudeo.Text == "" | txtPMMayoreo.Text == "" || cboPresentacion.SelectedValue.Equals("") ||
                     txtApartirDe.Text.Equals(""))
                {
                    MessageBox.Show("Favor de llenar todos los campos ", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                  InsertarProducto();
                }
            }
            else
            {
                ActualizarProducto();
            }
        }

        private void InsertarProducto()
        {
            try
            {
                Producto p = new Producto();
                p.codigo = txtcodigodebarras.Text;
                p.Descripcion = txtdescripcion.Text;
                p.Presentacion = txtPresentacion.Text;
                p.precioMenudeo = Convert.ToDecimal(txtPMenudeo.Text);
                p.precioMMayoreo = Convert.ToDecimal(txtPMMayoreo.Text);
                p.APartirDe = Convert.ToDecimal(txtApartirDe.Text);
                p.precioMayoreo = Convert.ToDecimal(txtpreciomayoreo.Text);
                p.IdTipoPresentacion = Convert.ToInt32(cboPresentacion.SelectedValue);
                p.IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
                p.TotalUnidades = Convert.ToDecimal(txtTotalUnidades.Text);
                p.Estado = true;
                if (porunidad.Checked == true) p.seVendeA = "UNIDAD";
                if (agranel.Checked == true) p.seVendeA = "GRANEL";

                if (chkBolsa.Checked)
                {
                    p.PresentacionMenudeo = "BOLSA";
                }
                else if (chkCaja.Checked)
                {
                    p.PresentacionMenudeo = "CAJA";
                }
                else if (chkPaquete.Checked)
                {
                    p.PresentacionMenudeo = "PAQUETE";
                }
                else if (chkPieza.Checked)
                {
                    p.PresentacionMenudeo = "PIEZA";
                }
                else
                {
                    p.PresentacionMenudeo = "PIEZA";
                }


                if (PANELINVENTARIO.Visible == true)
                {
                    p.usaInventario = "SI";
                    p.stockMinimo = Convert.ToDecimal(txtstockminimo.Text) * Convert.ToDecimal(txtTotalUnidades.Text);
                    decimal _totalStock = (Convert.ToDecimal(txtstock2) * Convert.ToDecimal(txtTotalUnidades.Text)) + Convert.ToDecimal(lblPiezasStock.Text); ;
                    p.stock = _totalStock.ToString(); ; 

                    if (No_aplica_fecha.Checked == true)
                    {
                        p.Caducidad = "NO APLICA";
                    }

                    if (No_aplica_fecha.Checked == false)
                    {
                        p.Caducidad = txtfechaoka.Text;
                    }
                }
                if (PANELINVENTARIO.Visible == false)
                {
                    p.usaInventario = "NO";
                    p.stockMinimo = 0;
                    p.Caducidad = "NO APLICA";
                    p.stock = "ILIMITADO";
                }
                Kardex kardex = new Kardex();
                kardex.Fecha = DateTime.Today;
                kardex.Motivo = "Registro inicial de producto";
                kardex.Cantidad = txtstock2.Text == string.Empty ? Convert.ToDecimal(0) : Convert.ToDecimal(txtstock2.Text);
                kardex.Id_Usuario = idUsuario;
                kardex.Tipo = "ENTRADA";
                kardex.Estado = "CONFIRMADO";
                kardex.Id_Caja = idCaja;
                // p.kardex = kardex;

                new BusProducto().AgregarProducto(p, kardex);
                MessageBox.Show("Producto agregado correctamente", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCotroles();
                ListarProductos("");
                pnlABProducto.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarProducto()
        {
            try
            {
                Producto p = new Producto();
                p.codigo = txtcodigodebarras.Text;
                p.Descripcion = txtdescripcion.Text;
                p.Presentacion = txtPresentacion.Text;
                p.precioMenudeo = Convert.ToDecimal(txtPMenudeo.Text);
                p.precioMMayoreo = Convert.ToDecimal(txtPMMayoreo.Text);
                p.APartirDe = Convert.ToDecimal(txtApartirDe.Text);
                p.precioMayoreo = Convert.ToDecimal(txtpreciomayoreo.Text);
                p.IdTipoPresentacion = Convert.ToInt32(cboPresentacion.SelectedValue);
                p.IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
                p.TotalUnidades = Convert.ToDecimal(txtTotalUnidades.Text);
                p.Estado = true;
                //p.Caducidad = (No_aplica_fecha.Checked == true) ?  "NO APLICA" : txtfechaoka.Text;
                if (porunidad.Checked == true) p.seVendeA = "UNIDAD";
                if (agranel.Checked == true) p.seVendeA = "GRANEL";
               // p.usaInventario = (CheckInventarios.Checked == true) ? "SI" : "NO";
               // p.stockMinimo = Convert.ToDecimal(txtstockminimo.Text);
                //p.stock = txtstock2.Text;
                p.Id = Convert.ToInt32(lblIdProducto.Text);

                if (PANELINVENTARIO.Visible == true)
                {
                    p.usaInventario = "SI";
                    p.stockMinimo = Convert.ToDecimal(txtstockminimo.Text) * Convert.ToDecimal(txtTotalUnidades.Text);
                    decimal _totalStock = (Convert.ToDecimal(txtstock2.Text) * Convert.ToDecimal(txtTotalUnidades.Text))+Convert.ToDecimal(lblPiezasStock.Text);
                    p.stock = _totalStock.ToString(); ;

                    if (No_aplica_fecha.Checked == true)
                    {
                        p.Caducidad = "NO APLICA";
                    }

                    if (No_aplica_fecha.Checked == false)
                    {
                        p.Caducidad = txtfechaoka.Text;
                    }
                }
                if (PANELINVENTARIO.Visible == false)
                {
                    p.usaInventario = "NO";
                    p.stockMinimo = 0;
                    p.Caducidad = "NO APLICA";
                    p.stock = "ILIMITADO";
                }



                if (chkBolsa.Checked)
                {
                    p.PresentacionMenudeo = "BOLSA";
                }
                else if (chkCaja.Checked)
                {
                    p.PresentacionMenudeo = "CAJA";
                }
                else if (chkPaquete.Checked)
                {
                    p.PresentacionMenudeo = "PAQUETE";
                }
                else if (chkPieza.Checked)
                {
                    p.PresentacionMenudeo = "PIEZA";
                }
                else
                {
                    p.PresentacionMenudeo = "PIEZA";
                }


                new BusProducto().ActualizarProducto(p);
                MessageBox.Show("Producto actualizado correctamente", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatProducto.Agregar_ActualizacionProducto(txtcodigodebarras.Text);
                LimpiarCotroles();
                pnlABProducto.Visible = false;
                ListarProductos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlABProducto.Visible = false;
            LimpiarCotroles();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnlABProducto.Visible = false;
            LimpiarCotroles();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LimpiarCotroles();
            panelCategoria.Visible = false;
            pnlABProducto.Visible = true;
            LlenarCategorias();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ListarProductos(txtBuscar.Text);
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTipoPresentacion.Text = cboPresentacion.Text;
            lblAuxHay.Text = cboPresentacion.Text.ToUpper() +'S';
            lblAuxHay2.Text = cboPresentacion.Text.ToUpper() +'S';
        }

        private void chkPieza_Click(object sender, EventArgs e)
        {
            chkPaquete.Checked = false;
            chkBolsa.Checked = false;
            chkCaja.Checked = false;
        }

        private void chkCaja_Click(object sender, EventArgs e)
        {
            chkPaquete.Checked = false;
            chkBolsa.Checked = false;
            chkPieza.Checked = false;
        }

        private void chkPaquete_Click(object sender, EventArgs e)
        {
            chkCaja.Checked = false;
            chkBolsa.Checked = false;
            chkPieza.Checked = false;
        }

        private void chkBolsa_Click(object sender, EventArgs e)
        {
            chkPaquete.Checked = false;
            chkCaja.Checked = false;
            chkPieza.Checked = false;
        }

        private void checkActualizarStock_CheckedChanged(object sender, EventArgs e)
        {
            Check_ActualizarStock();
        }

        private void Check_ActualizarStock()
        {
            if (checkActualizarStock.Checked == true)
            {
                pnlActualizarStock.Visible = true;
                txtStockActualizado.Text = txtstock2.Text;
                txtPiezasActualizadas.Text = lblPiezasStock.Text;
            }
            else
            {
                pnlActualizarStock.Visible = false;
            }
        }

        private void btnCancelarActualizacionStock_Click(object sender, EventArgs e)
        {
            pnlActualizarStock.Visible = false;
            txtPiezasActualizar.Clear();
            txtStockActualizar.Clear();
            txtStockActualizado.Clear();
            txtPiezasActualizar.Clear();
            checkActualizarStock.Checked = false;
        }

        private void txtStockActualizar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPiezasActualizar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnActualizarStock_Click(object sender, EventArgs e)
        {
            txtstock2.Text = txtStockActualizado.Text;
            lblPiezasStock.Text = txtPiezasActualizadas.Text;

            pnlActualizarStock.Visible = false;
            txtPiezasActualizar.Clear();
            txtStockActualizar.Clear();
            txtStockActualizado.Clear();
            txtPiezasActualizar.Clear();
            checkActualizarStock.Checked = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            decimal stock = String.IsNullOrEmpty(txtStockActualizar.Text) ? 0 : Convert.ToDecimal(txtStockActualizar.Text);
            decimal StockActual = Convert.ToDecimal(txtStockActualizado.Text);

            txtStockActualizado.Text = (StockActual + stock).ToString();

            decimal unidades = String.IsNullOrEmpty(txtPiezasActualizar.Text) ? 0 :  Convert.ToDecimal(txtPiezasActualizar.Text);
            decimal unidadActual = Convert.ToDecimal(txtPiezasActualizadas.Text);

            txtPiezasActualizadas.Text = (unidadActual + unidades).ToString();

            txtStockActualizar.Clear();
            txtPiezasActualizar.Clear();
        }
    }
}
