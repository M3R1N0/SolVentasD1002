using BusVenta;
using DatVentas;
using EntVenta;
using Reportes;
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
    public partial class frmInventarioKardex : Form
    {
        public frmInventarioKardex()
        {
            InitializeComponent();
        }

        public static int IDPRODUCTO;

        private void frmInventarioKardex_Load(object sender, EventArgs e)
        {
            // groupBox1.Visible = false;
            gvdResultadoBusqueda.Visible = false;
            gdvKardex.Visible = false;
        }

        private void tabKardex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabKardex.SelectedIndex == 0)
            {
                //  MessageBox.Show("kardex");
            }
            if (tabKardex.SelectedIndex == 1)
            {
                //MessageBox.Show("movimiento");
            }
            if (tabKardex.SelectedIndex == 2)
            {
                Llenar_InventariosBajos();
            }
            if (tabKardex.SelectedIndex == 3)
            {
                Llenar_gdvInventarios("");
                lblCantidadProductos.Text = "" + gdvInventarios.Rows.Count;
            }
            if (tabKardex.SelectedIndex == 4)
            {
                rbPorVencer.Checked = false;
                rbVencido.Checked = true;
                Mostrar_ProductosVencidos("");
            }

        }

        #region PANEL MOVIMIENTO

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscarMovimiento_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarMovimiento.Text == "")
            {
                gvdResultadoBusqueda.Visible = false;
            }
            else
            {
                gvdResultadoBusqueda.Visible = true;
                try
                {
                    List<Producto> productos = new BusProducto().ListarProductos_kardex(txtBuscarMovimiento.Text);
                    gvdResultadoBusqueda.DataSource = productos;


                    gvdResultadoBusqueda.Columns[0].Visible = false;
                    gvdResultadoBusqueda.Columns[1].Visible = false;
                    gvdResultadoBusqueda.Columns[2].Visible = false;
                    gvdResultadoBusqueda.Columns[3].Visible = false;
                    gvdResultadoBusqueda.Columns[5].Visible = false;
                    gvdResultadoBusqueda.Columns[6].Visible = false;
                    gvdResultadoBusqueda.Columns[7].Visible = false;
                    gvdResultadoBusqueda.Columns[8].Visible = false;
                    gvdResultadoBusqueda.Columns[9].Visible = false;
                    gvdResultadoBusqueda.Columns[10].Visible = false;
                    gvdResultadoBusqueda.Columns[11].Visible = false;
                    gvdResultadoBusqueda.Columns[12].Visible = false;
                    gvdResultadoBusqueda.Columns[13].Visible = false;
                    gvdResultadoBusqueda.Columns[14].Visible = false;
                    gvdResultadoBusqueda.Columns[15].Visible = false;
                    gvdResultadoBusqueda.Columns[16].Visible = false;
                    gvdResultadoBusqueda.Columns[17].Visible = false;

                    // BusVenta.DataTablePersonalizado.Multilinea(ref gvdResultadoBusqueda);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al al mostrar los datos " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gvdResultadoBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // txtBuscarMovimiento.Text = gvdResultadoBusqueda.SelectedCells[0].Value.ToString();
            gvdResultadoBusqueda.Visible = false;
            // int valor = Convert.ToInt32( gvdResultadoBusqueda.SelectedCells[0].Value.ToString());
            Buscar_MovimientoKardex();
        }

        private void Buscar_MovimientoKardex()
        {
            try
            {
                int buscar = Convert.ToInt32(gvdResultadoBusqueda.SelectedCells[0].Value.ToString());
                DataTable dt = new DatKardex().BuscarProducto_Kardex(buscar, "MOVIMIENTO_KARDEX");
                gdvMovimientos.DataSource = dt;
                IDPRODUCTO = buscar;

                BusVenta.DataTablePersonalizado.Multilinea(ref gdvMovimientos);
                txtBuscarMovimiento.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gvdResultadoBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMovimientoRpt frmMovimientoRpt = new frmMovimientoRpt();
            frmMovimientoRpt.ShowDialog();
        }

        #endregion

        #region PANEL INVENTARIOS BAJOS

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Llenar_InventariosBajos()
        {
            try
            {
                DataTable dt = DatVentas.DatProducto.Obtener_InventariosBajos();
                gdvInventariosBajos.DataSource = dt;
                BusVenta.DataTablePersonalizado.Multilinea(ref gdvInventariosBajos);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region PANEL INVENTARIO

        private void txtBuscarRepoteInventario_TextChanged(object sender, EventArgs e)
        {
            Llenar_gdvInventarios(txtBuscarRepoteInventario.Text);
        }

        private void Llenar_gdvInventarios(string buscar)
        {
            try
            {
                DataTable dt = DatVentas.DatProducto.Obtener_Inventarios(buscar);
                gdvInventarios.DataSource = dt;
                BusVenta.DataTablePersonalizado.Multilinea(ref gdvInventarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region PANEL PRODUCTOS VENCIDOS

        private void txtBuscarVencimiento_TextChanged(object sender, EventArgs e)
        {

            rbPorVencer.Checked = false;
            rbVencido.Checked = false;
            Mostrar_ProductosVencidos(txtBuscarVencimiento.Text);

        }

        private void Mostrar_ProductosVencidos(string buscar)
        {
            try
            {
                DataTable dt = DatVentas.DatProducto.Obtener_ProductosVencidos(buscar);
                gdvVencimiento.DataSource = dt;
                BusVenta.DataTablePersonalizado.Multilinea(ref gdvVencimiento);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbPorVencer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DatVentas.DatProducto.Obtener_ProductosVencidosDelMes();
                gdvVencimiento.DataSource = dt;
                BusVenta.DataTablePersonalizado.Multilinea(ref gdvVencimiento);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbVencido_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar_ProductosVencidos("");
        }

        #endregion

        #region PANEL KARDEX

        private void txtBuscarKardex_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarKardex.Text == "")
            {
                gdvKardex.Visible = false;
            }
            else
            {
                gdvKardex.Visible = true;
                try
                {
                    List<Producto> productos = new BusProducto().ListarProductos_kardex(txtBuscarKardex.Text);
                    gdvKardex.DataSource = productos;

                    gdvKardex.Columns[0].Visible = false;
                    gdvKardex.Columns[1].Visible = false;
                    gdvKardex.Columns[2].Visible = false;
                    gdvKardex.Columns[3].Visible = false;
                    gdvKardex.Columns[5].Visible = false;
                    gdvKardex.Columns[6].Visible = false;
                    gdvKardex.Columns[7].Visible = false;
                    gdvKardex.Columns[8].Visible = false;
                    gdvKardex.Columns[9].Visible = false;
                    gdvKardex.Columns[10].Visible = false;
                    gdvKardex.Columns[11].Visible = false;
                    gdvKardex.Columns[12].Visible = false;
                    gdvKardex.Columns[13].Visible = false;
                    gdvKardex.Columns[14].Visible = false;
                    gdvKardex.Columns[15].Visible = false;
                    gdvKardex.Columns[16].Visible = false;
                    gdvKardex.Columns[17].Visible = false;
                    
                    // BusVenta.DataTablePersonalizado.Multilinea(ref gvdResultadoBusqueda);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al al mostrar los datos " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Buscar_Kardex()
        {
            try
            {
                List<Producto> productos = new BusProducto().ListarProductos_kardex(txtBuscarKardex.Text);
                gdvKardex.DataSource = productos;


                gvdResultadoBusqueda.Columns[0].Visible = false;
                gvdResultadoBusqueda.Columns[1].Visible = false;
                gvdResultadoBusqueda.Columns[2].Visible = false;
                gvdResultadoBusqueda.Columns[3].Visible = false;
                gvdResultadoBusqueda.Columns[5].Visible = false;
                gvdResultadoBusqueda.Columns[6].Visible = false;
                gvdResultadoBusqueda.Columns[7].Visible = false;
                gvdResultadoBusqueda.Columns[8].Visible = false;
                gvdResultadoBusqueda.Columns[9].Visible = false;
                gvdResultadoBusqueda.Columns[10].Visible = false;
                gvdResultadoBusqueda.Columns[11].Visible = false;
                gvdResultadoBusqueda.Columns[12].Visible = false;
                gvdResultadoBusqueda.Columns[13].Visible = false;
                gvdResultadoBusqueda.Columns[14].Visible = false;
                gvdResultadoBusqueda.Columns[15].Visible = false;
                gvdResultadoBusqueda.Columns[16].Visible = false;
                gvdResultadoBusqueda.Columns[17].Visible = false;

                gdvKardex.Visible = true;
                // BusVenta.DataTablePersonalizado.Multilinea(ref gvdResultadoBusqueda);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al al mostrar los datos " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        rptKardex kardex = new rptKardex(); 

        private void gdvKardex_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int buscar = Convert.ToInt32(gdvKardex.SelectedCells[0].Value.ToString());
                
                DataTable dt = new DatKardex().BuscarProducto_Kardex(buscar,"");
               

                kardex = new rptKardex();
                kardex.DataSource = dt;
                kardex.tbKardex.DataSource = dt;
                rvwKardex.Report = kardex;

                this.rvwKardex.RefreshReport();
                  BusVenta.DataTablePersonalizado.Multilinea(ref gdvMovimientos);
                txtBuscarKardex.Clear();
                gdvKardex.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

      
    }
}
