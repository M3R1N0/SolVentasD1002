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
         
        }

        int idUsuario;
        int idCaja;
        string serialPC;
        public static string producto;

        private void frmProductos_Load_1(object sender, EventArgs e)
        {
            ListarProductos("");
           
        }

        public  void ListarProductos(string buscar)
        {
            try
            {
                List<Producto> lsp = new BusProducto().ListarProductos(buscar,1);
                gdvProductos.DataSource = lsp;
                
                gdvProductos.Columns[2].Visible = false;
                gdvProductos.Columns[3].Visible = false;
                gdvProductos.Columns[4].Visible = false;
                gdvProductos.Columns[17].Visible = false;
                gdvProductos.Columns[18].Visible = false;
                gdvProductos.Columns[19].Visible = false;
                gdvProductos.Columns[20].Visible = false;
                gdvProductos.Columns[21].Visible = false;
                gdvProductos.Columns[22].Visible = false;
                BusVenta.DataTablePersonalizado.Multilinea(ref gdvProductos);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarProducto()
        {
            frmABProducto frmAB = new frmABProducto();
            frmABProducto.TipoPresentacion = gdvProductos.SelectedCells[4].Value.ToString();
            frmABProducto.Categoria = gdvProductos.SelectedCells[3].Value.ToString();
            string _strPMenudeo = gdvProductos.SelectedCells[21].Value.ToString();
            frmABProducto.PresentacionMenudeo = _strPMenudeo;
            frmABProducto.EsNuevo = false;
            frmAB.txtcodigodebarras.ReadOnly = true;
            frmAB.lblIdProducto.Text = gdvProductos.SelectedCells[2].Value.ToString();
           // lblIdProducto.Text = gdvProductos.SelectedCells[2].Value.ToString();
            //frmAB.cboCategoria.SelectedValue = gdvProductos.SelectedCells[3].Value.ToString();
            //frmAB.cboPresentacion.SelectedValue = gdvProductos.SelectedCells[4].Value.ToString();
           
            frmAB.txtcodigodebarras.Text = gdvProductos.SelectedCells[5].Value.ToString();
            frmAB.txtdescripcion.Text = gdvProductos.SelectedCells[6].Value.ToString();
            frmAB.txtPresentacion.Text = gdvProductos.SelectedCells[7].Value.ToString();
            if (gdvProductos.SelectedCells[8].Value.ToString() == "UNIDAD" )
            {
                frmAB.porunidad.Checked = true;
            }
            else
            {
                frmAB.agranel.Checked = true;
            }

            frmAB.txtPMenudeo.Text = gdvProductos.SelectedCells[9].Value.ToString();
            frmAB.txtPMMayoreo.Text = gdvProductos.SelectedCells[10].Value.ToString();
            frmAB.txtApartirDe.Text = gdvProductos.SelectedCells[11].Value.ToString();
            frmAB.txtpreciomayoreo.Text = gdvProductos.SelectedCells[12].Value.ToString();
            var s = gdvProductos.SelectedCells[22].Value.ToString(); 

            frmAB.txtPesoMayoreo.Text = gdvProductos.SelectedCells[22].Value.ToString();

            string inventario = gdvProductos.SelectedCells[13].Value.ToString();
            frmAB.txtTotalUnidades.Text = gdvProductos.SelectedCells[20].Value.ToString();

            if (inventario == "SI")
            {
                frmAB.CheckInventarios.Checked = true;
                frmAB.PANELINVENTARIO.Visible = true;
                decimal _totalUnidad = Convert.ToDecimal(frmAB.txtTotalUnidades.Text);
                decimal _stockMaximo = Convert.ToDecimal(gdvProductos.SelectedCells[14].Value);
                decimal _stockMinimo = Convert.ToDecimal(gdvProductos.SelectedCells[15].Value);
                decimal _unidades = (_stockMaximo % _totalUnidad);

                frmAB.lblPiezasStock.Text = _unidades.ToString();
                frmAB.txtstock2.Text = Math.Floor((_stockMaximo / _totalUnidad)).ToString();
                frmAB.txtstockminimo.Text = (_stockMinimo / _totalUnidad).ToString();
                
            }
            else
            {
                frmAB.CheckInventarios.Checked = false;
                frmAB.PANELINVENTARIO.Visible = false;
            }

           // txtstockminimo.Text = gdvProductos.SelectedCells[15].Value.ToString();
            string fecha = gdvProductos.SelectedCells[16].Value.ToString();
            bool res = (fecha == "NO APLICA") ? frmAB.No_aplica_fecha.Checked = true : frmAB.No_aplica_fecha.Checked = false;

            frmAB.txtfechaoka.Text = (!res) ? fecha : null;
            frmAB.FormClosing += frm_FormClosing;
            frmAB.ShowDialog();
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
                            AgregarBitacora(oneKey);
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
             //  int id = Convert.ToInt32(gdvProductos.SelectedCells[2].Value);
               // frmABProducto frmAB = new frmABProducto(id);
                //frmAB.ShowDialog();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmABProducto frmAB = new frmABProducto();
            frmAB.txtcodigodebarras.ReadOnly = false;
            frmAB.LimpiarCotroles();
            frmABProducto.EsNuevo = true;
            frmAB.FormClosing += frm_FormClosing;
            frmAB.ShowDialog();
            //panelCategoria.Visible = false;
            //pnlABProducto.Visible = true;
            //LlenarCategorias();
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

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtBuscar.Text = string.Empty;
                txtBuscar.Focus();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                DataTable dt = DatProducto.ListarProductos_CodigoAutomatico();
                dataGridView1.DataSource = dt;
                DataTablePersonalizado.Multilinea(ref dataGridView1);
            }
        }

        private void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtBuscar.Focus();
            ListarProductos(producto);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                 Exportar_Importar_ArchivoExcel.ExportarProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message);
            }
        }

        private void AgregarBitacora(int ID)
        {
            try
            {
                string serialPC = Sistema.ObenterSerialPC();

                int _idCaja = new BusBox().showBoxBySerial(serialPC).Id;
                int _idusuario = new BusUser().ObtenerUsuario(EncriptarTexto.Encriptar(serialPC)).Id;

                Bitacora b = new Bitacora();
                b.Fecha = DateTime.Now;
                b.IdUsuario = _idusuario;
                b.IdCaja = _idCaja;
                b.Accion = $"ELIMINACION DEL PRODUCTO [{ID}]";

                DatCatGenerico.AgregarBitácora(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la bitacora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
