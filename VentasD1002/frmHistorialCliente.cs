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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmHistorialCliente : Form
    {
        public frmHistorialCliente()
        {
            InitializeComponent();
            progressPanel1.Visible = false;
        }

        private void frmHistorialCliente_Load(object sender, EventArgs e)
        {
            ObtenerClientes("");
        }

        private void ObtenerClientes( string buscar)
        {
            try
            {
                DataTable lstCliente = DatCliente.ListarVentasPorCliente(buscar);

                gdvClientes.DataSource = lstCliente;
                gdvClientes.Columns[1].Visible = false;

                Comun.StyleDatatable(ref gdvClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de los clientes : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            ObtenerClientes(txtCliente.Text);
        }

        private void gdvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == gdvClientes.Columns["Excel"].Index)
                {
                    progressPanel1.Visible = true;
                    int idcliente = Convert.ToInt32(gdvClientes.SelectedCells[1].Value);
                    string cliente = gdvClientes.SelectedCells[3].Value.ToString();
                    Respuesta resp = Exportar_Importar_ArchivoExcel.ExportarHistorial_VentasCliente(idcliente, cliente);

                    if (resp.Exito == 1)
                    {
                        progressPanel1.Visible = false;
                        MessageBox.Show(resp.Mensaje, resp.TipoMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        progressPanel1.Visible = false;
                        MessageBox.Show(resp.Mensaje, resp.TipoMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al exportar los datos : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
