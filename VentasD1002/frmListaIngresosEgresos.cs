using BusVenta;
using BusVenta.Helpers;
using DatVentas;
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
    public partial class frmListaIngresosEgresos : Form
    {
        public frmListaIngresosEgresos()
        {
            InitializeComponent();
        }

        Subro.Controls.DataGridViewGrouper grouper = new Subro.Controls.DataGridViewGrouper();

        private void frmConfigPrecioGanancia_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void ObtenerDatos()
        {
            try
            {
                var serialPC = Sistema.ObenterSerialPC();
                var inicio = dpInicio.Value;
                var idusuario = BusUser.ObtenerUsuario_Loggeado().Id;
                var fin = dpFin.Value;

                CajaDAL.EntradaSalidaEfectivo(serialPC, idusuario, ref gdvData, inicio, fin);

                Comun.StyleDatatable(ref gdvData);
                grouper = new Subro.Controls.DataGridViewGrouper(gdvData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void dpInicio_ValueChanged(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void dpFin_ValueChanged(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void chkAgrupar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgrupar.CheckState == CheckState.Checked)
            {
                AgruparListaEmpleados(true);
            }
            else
            {
                AgruparListaEmpleados(false);
            }
        }

        private void AgruparListaEmpleados(bool Valor)
        {
            if (Valor == true)
            {
                grouper.RemoveGrouping();
                grouper.SetGroupOn("Tipo");
                grouper.Options.ShowGroupName = false;
                grouper.Options.GroupSortOrder = System.Windows.Forms.SortOrder.None;
                gdvData.Columns["Tipo"].Visible = false;

                gdvData.RowHeadersVisible = false;
                gdvData.ClearSelection();
            }
            else
            {
                grouper.RemoveGrouping();
                //gdvListado.RowHeadersVisible = true;
                gdvData.Columns["Tipo"].Visible = true;
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGastos gastos = new frmGastos();
            gastos.ShowDialog();
            ObtenerDatos();
        }
    }
}
