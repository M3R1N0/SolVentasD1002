using BusVenta;
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
    public partial class frmListadoClientesCredito : Form
    {
        public frmListadoClientesCredito()
        {
            InitializeComponent();
        }

        private void frmListadoClientesCredito_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = DatVenta.ListarClientes_TotalALquidar();
                gdvTotalCredito.DataSource = data;

                gdvTotalCredito.Columns[0].Visible = false;
                DataTablePersonalizado.Multilinea(ref gdvTotalCredito);

                pnlListadoClienteCredito.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar los datos : " + ex.Message, "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
