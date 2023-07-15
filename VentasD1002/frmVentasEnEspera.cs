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
    public partial class frmVentasEnEspera : Form
    {
        public frmVentasEnEspera()
        {
            InitializeComponent();
        }

        private void frmVentasEnEspera_Load(object sender, EventArgs e)
        {
            ListarVentas();
        }

        private void ListarVentas()
        {
            var serialPC = Sistema.ObenterSerialPC();
            DatVenta.Obtener_VentasEnEspera(ref gridVentas, serialPC);
            gridVentas.Columns[2].Visible = false;
            gridVentas.Columns[3].Visible = false;
            gridVentas.Columns[4].Visible = false;
            Comun.StyleDatatable(ref gridVentas);
        }

        private void gridVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.gridVentas.Columns["Eliminar"].Index)
                {
                    DialogResult result = MessageBox.Show("¿Seguro desea eliminar la venta seleccionada?", "Eliminar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int idVenta = Convert.ToInt32(gridVentas.SelectedCells[2].Value);
                        ObtenerDetaleVenta(idVenta);

                        BusVentas.Eliminar_Venta(idVenta);
                        MessageBox.Show("¡Operación realizada con éxito!", "Venta eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarVentas();
                    }
                }

                if (e.ColumnIndex == this.gridVentas.Columns["Restaurar"].Index)
                {

                    int idVenta = Convert.ToInt32(gridVentas.SelectedCells[2].Value);
                    int idCliente = Convert.ToInt32(gridVentas.SelectedCells[3].Value);
                    string FormaPago = Convert.ToString(gridVentas.SelectedCells[4].Value);

                    frmVenta.IDCLIENTE = idCliente;
                    frmVenta.FORMA_PAGO = FormaPago;
                    frmVenta.IDVENTA = idVenta;
                    this.Dispose();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Error al obtener los datos! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerDetaleVenta(int idVenta)
        {
            try
            {
                var lstDetalle = DatDetalleVenta.Listar_DetalleVenta(idVenta);

                if (lstDetalle.Count <= 0)
                {
                    MessageBox.Show("NO HAY DATOS QUE PROCESAR", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                foreach (DetalleVentaII item in lstDetalle)
                {
                    if (item.UsaInventario)
                    {
                        ProductoVM p = new ProductoVM();
                        p.Id = item.IdProducto;
                        p.Cantidad = item.Cantidad;
                        p.Articulo = item.Descripcion;

                        if (item.TipoVenta == (Int32) TIPO_VENTA.P)
                        {
                            p.TipoVenta = ProductoDAL.ObtenerTipoVenta_Preferencial(item.IdProducto, item.UnidadMedida).ToString();
                        }
                        else
                        {
                            p.TipoVenta = (item.TipoVenta == (Int32) TIPO_VENTA.M) ? TIPO_VENTA.M.ToString() : TIPO_VENTA.U.ToString();
                        }
                        p.UsaInventario = item.UsaInventario;
                        ProductoDAL.Aumentar_DisminuirStock(p, "AUMENTAR"); 

                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
