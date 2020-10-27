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
    public partial class frmMovimientoRpt : Form
    {
        public frmMovimientoRpt()
        {
            InitializeComponent();
        }

        rptMovimientoKardex movKardex = new rptMovimientoKardex();
        private void mostrarReporte()
        {
            try
            {
                DataTable dt = new DatVentas.DatKardex().BuscarProducto_Kardex(frmInventarioKardex.IDPRODUCTO, "MOVIMIENTO_KARDEX");
                movKardex = new rptMovimientoKardex();
                movKardex.DataSource = dt;
                reportViewerMovimiento.Report = movKardex;
                reportViewerMovimiento.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el reporte "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMovimientoRpt_Load(object sender, EventArgs e)
        {
            mostrarReporte();
        }
    }
}
