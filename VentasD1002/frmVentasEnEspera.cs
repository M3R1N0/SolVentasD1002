using BusVenta;
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
    public partial class frmVentasEnEspera : Form
    {
        public frmVentasEnEspera()
        {
            InitializeComponent();
        }

        private int _IdVenta;
        private int _idCliente;

        private void frmVentasEnEspera_Load(object sender, EventArgs e)
        {
            Obtener_ListaVentas();
        }

        private void Obtener_ListaVentas()
        {
            try
            {
                List<VentaEspera> dt = new BusVentas().Listar_VentasEnEspera();

                gdvListaDVentas.DataSource = dt;

                gdvListaDVentas.Columns[1].Visible = false;
                gdvListaDVentas.Columns[2].Visible = false;
                gdvListaDVentas.Columns[3].Visible = false;
                gdvListaDVentas.Columns[4].Visible = false;

                DataTablePersonalizado.Multilinea(ref gdvListaDVentas);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar el detalle : "+ex.Message, "Error de listado ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvListaDVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == this.gdvListaDVentas.Columns["Eliminar"].Index)
                {
                    DialogResult result = MessageBox.Show("¿Desea eliminar la venta?", "Eliminar Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        int idVenta = Convert.ToInt32(gdvListaDVentas.SelectedCells[1].Value);
                        new BusDetalleVenta().Eliminar_DetalleVentaEspera(idVenta);
                        new BusVentas().Eliminar_VentaEspera(idVenta);

                        MessageBox.Show("Venta Eliminado de manera correcta", "Venta eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Obtener_ListaVentas();
                        gdvDetalleVentaEspera.DataSource = null;
                    }
                }
                else
                {
                    _IdVenta = Convert.ToInt32(gdvListaDVentas.SelectedCells[1].Value);
                    _idCliente = Convert.ToInt32(gdvListaDVentas.SelectedCells[2].Value);
                    ObtenerDetalleVenta(_IdVenta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la fila : "+ ex.Message, "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerDetalleVenta(int idVenta)
        {
            try
            {
                DataTable detalleVenta = new DatDetalleVenta().ObtenerDetalle_VentaEnEspera(idVenta);
                gdvDetalleVentaEspera.DataSource = detalleVenta;

                gdvDetalleVentaEspera.Columns[0].Visible = false;
                gdvDetalleVentaEspera.Columns[1].Visible = false;
                gdvDetalleVentaEspera.Columns[2].Visible = false;
                gdvDetalleVentaEspera.Columns[3].Visible = false;
                gdvDetalleVentaEspera.Columns[9].Visible = false;
                gdvDetalleVentaEspera.Columns[10].Visible = false;

                DataTablePersonalizado.Multilinea(ref gdvDetalleVentaEspera);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el detalle de la venta : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenuPrincipal.idVenta = _IdVenta;
                frmMenuPrincipal.idCliente = _idCliente;
                frmMenuPrincipal.VentaEspera = "VENTA EN ESPERA";
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el detalle de la venta : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}
