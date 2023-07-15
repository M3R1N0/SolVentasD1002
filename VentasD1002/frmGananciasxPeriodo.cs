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
    public partial class frmGananciasxPeriodo : Form
    {
        public frmGananciasxPeriodo()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //ListarGanancia();
        }

        private void ListarGanancia()
        {
            try
            {
                var inicio = dpInicio.Value;
                var fin = dpFin.Value;

                DatVenta.FiltrarGanancia_PorPeriodo(ref gridData, inicio, fin);
                Comun.StyleDatatable(ref gridData);

               var GananciaTotal= (from DataGridViewRow row in gridData.Rows
                                 where row.Cells[7].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDecimal(row.Cells[7].FormattedValue)).Sum();

                var VentaTotal = (from DataGridViewRow row in gridData.Rows
                                     where row.Cells[5].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDecimal(row.Cells[5].FormattedValue)).Sum();

                lblTotalGanancia.Text = string.Format("{0:N2}", GananciaTotal);
                lblVentaTotal.Text = string.Format("{0:N2}", VentaTotal);
            }
            catch (Exception)
            {
            }

        }

        private void dpInicio_ValueChanged(object sender, EventArgs e)
        {
            dpInicio.MaxDate = dpFin.Value;
            dpFin.MinDate = dpInicio.Value;
            ListarGanancia();
        }

        private void dpFin_ValueChanged(object sender, EventArgs e)
        {
            dpFin.MinDate = dpInicio.Value;
            dpInicio.MaxDate = dpFin.Value;
            ListarGanancia();
        }
    }
}
