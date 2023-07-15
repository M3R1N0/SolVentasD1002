using DatVentas;
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

namespace VentasD1002
{
    public partial class frmTraspasoMercancia : Form
    {
        public frmTraspasoMercancia()
        {
            InitializeComponent();
        }

        private void frmVentasDiarias_Load(object sender, EventArgs e)
        {
            ObtenerSucursal();
        }

        private void ObtenerSucursal()
        {
            try
            {
                DatCatGenerico.ObtenerSucursales(ref cboSucursal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos : "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCatSucursal catSucursal = new frmCatSucursal();
            catSucursal.ShowDialog();
            ObtenerSucursal();
        }
    }
}
