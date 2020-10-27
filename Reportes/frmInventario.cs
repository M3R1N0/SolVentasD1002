using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        rptInventarios rptInventario = new rptInventarios();
        private void MostrarDatosInventario()
        {
            try
            {
                // List<Producto> productos = new BusVenta.BusProducto().MostrarInventario();
                DataTable productos = new DatVentas.DatProducto().Mostrar_ProductoInvetario();
                rptInventario = new rptInventarios();
                rptInventario.DataSource = productos;
                rptInventario.tbInvetarioProducto.DataSource = productos;
                reportViewer1.Report = rptInventario;

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el reporte "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            MostrarDatosInventario();
        }
    }
}
