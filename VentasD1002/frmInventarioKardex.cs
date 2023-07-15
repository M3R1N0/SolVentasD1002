using BusVenta;
using BusVenta.Helpers;
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

        private async void frmInventarioKardex_Load(object sender, EventArgs e)
        {
            rbtnCaducados.Visible = false;
            rbtnPorCaducar.Visible = false;
            await ObteneStocks_Bajos();
            await ListarDatos_Caducados();
        }

        private async Task ObteneStocks_Bajos()
        {
            try
            {
                string busqueda = txtBuscar.Text;
                ProductoDAL.ListarProductos_StockBajos(ref gridStockBajos, busqueda);
                Comun.StyleDatatable(ref gridStockBajos);
              //  lblTotal.Text = gridStocks.RowCount.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private async Task ListarDatos_Caducados()
        {
            try
            {
                string tipo = (rbtnCaducados.Checked) ? "CADUCADO" : "POR CADUCAR";
                ProductoDAL.ListarProductos_Caducados(ref gridCaducados, tipo);
                Comun.StyleDatatable(ref gridCaducados);

                //lblTotal.Text = gridCaducados.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ocurrió un error al obtener los datos!, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            await ObteneStocks_Bajos();
        }

        private void tbStocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbtnCaducados.Visible = false;
            rbtnPorCaducar.Visible = false;

            if (tbStocks.SelectedTab.Name != "tabStocksBajos")
            {
                rbtnCaducados.Visible = true;
                rbtnPorCaducar.Visible = true;
            }
        }

        private async  void rbtnCaducados_CheckedChanged(object sender, EventArgs e)
        {
            await ListarDatos_Caducados();
        }

        private async  void rbtnPorCaducar_CheckedChanged(object sender, EventArgs e)
        {
            await ListarDatos_Caducados();
        }
    }
}
