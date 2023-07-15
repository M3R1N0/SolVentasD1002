using BusVenta;
using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reportes;
using Telerik.Reporting.Processing;
using System.Management;
using BusVenta.Helpers;
using VentasD1002.Helpers;

namespace VentasD1002
{
    public partial class frmDevoluciones : Form
    {
        private PrintDocument TICKET;
        string serialPC;
        private decimal Precio;
        private decimal Cantidad;
        int idVenta;
        public frmDevoluciones()
        {
            InitializeComponent();
            pnlProcesar.Visible = false;
        }

        private void frmDevoluciones_Load(object sender, EventArgs e)
        {
            txtBuscar.SelectAll();
            txtBuscar.Focus();
            gdvResultado.Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtBuscar.Text) && txtBuscar.Text != "Ingrese el nombre del cliente o el num de comprobante ")
                {
                    gdvResultado.Visible = true;
                    DatVenta.BuscarVenta( ref gdvResultado,txtBuscar.Text);
                    gdvResultado.Columns[0].Visible = false;
                    Comun.StyleDatatable(ref gdvResultado);
                }
                else
                {
                    if (String.IsNullOrEmpty(txtBuscar.Text))
                    {
                        gdvResultado.Visible = false;
                        txtBuscar.Text = "Ingrese el nombre del cliente o el num de comprobante ";
                        txtBuscar.SelectAll();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en la búsqueda : "+ex.Message, "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlProcesar.Visible = false;
            try
            {
                int oneKey = Convert.ToInt32(gdvResultado.SelectedCells[0].Value);
                txtCliente.Texts = gdvResultado.SelectedCells[2].Value.ToString();
                txtFolio.Texts = gdvResultado.SelectedCells[3].Value.ToString();
                txtFechaVenta.Texts = Convert.ToDateTime(gdvResultado.SelectedCells[1].Value).ToString("dd 'de' MMMM 'de' yyyy");

                gdvResultado.Visible = false;
                txtBuscar.ResetText();

                ObtenerDetalleVenta(oneKey);
                idVenta = oneKey;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerDetalleVenta(int oneKey)
        {
            try
            {
                var lstDetalle = DatDetalleVenta.Listar_DetalleVenta(oneKey);

                grid.DataSource = lstDetalle;
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    col.ReadOnly = true;
                    col.Visible = false;

                    if (col.Index == 0 || col.Index == 1 || col.Index == 5 ||
                        col.Index == 6 || col.Index == 7 || //col.Index == 8 || 
                        col.Index == 9 || col.Index == 10)
                    {
                        col.Visible = true;
                    }
                }
                Comun.StyleDatatable(ref grid);

                var VentaTotal = (from DataGridViewRow row in grid.Rows
                                  where row.Cells[10].FormattedValue.ToString() != string.Empty
                                  select Convert.ToDecimal(row.Cells[10].FormattedValue)).Sum();

                //txtCajero.Texts = dtDatos.Select(x => x.Cajero).FirstOrDefault();
                lblTotal.Text = string.Format("{0:N2}", VentaTotal);
            }
            catch (Exception)
            {
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlProcesar.Visible = false;
            lblTotalDevuelto.Text = "0.00";
        }

        private void AgregarBitacora(int idventa, string tipo)
        {
            try
            {
                string SerialPC = Sistema.ObenterSerialPC();
                string strTipo = (tipo.Equals("TOTAL")) ? $"DEVOLUCIÓN TOTAL DE LA VENTA [{idventa}]" : $"DEVOLUCIÓN DE PRODUCTO [{idventa}]";
                int idCaja = BusBox.showBoxBySerial().Id;
                int idusuario = BusUser.ObtenerUsuario_Loggeado().Id;

                Bitacora b = new Bitacora();
                b.Fecha = DateTime.Now;
                b.IdUsuario = idusuario;
                b.IdCaja = idCaja;
                b.Accion = strTipo;

                DatCatGenerico.AgregarBitácora(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la bitacora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirTicket(int idVenta)
        {
            try
            {
                reportViewer1.Visible = true;
                var respuesta = ImprimirDocumento.DibujarReporte(ref reportViewer1, DESTINO_DOCUMENTO.VENTAS, TIPO_DOCUMENTO.TICKET, idVenta);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un detalle al asignar los datos al reporte\nDetalles: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar_campos()
        {
            this.Controls.Clear();
            Precio = 0;
            Cantidad = 0;
            idVenta = 0;
            gdvDatos.DataSource = null;
            
        }

        private void txtCantidadDevuelto_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtCantidadDevuelto.Text) || txtCantidadDevuelto.Equals("0"))
            {
                txtCantidadDevuelto.Text = "0";
                txtCantidadDevuelto.SelectAll();
            }
            else
            {
                decimal devuelto = Convert.ToDecimal(txtCantidadDevuelto.Text);
                if ( devuelto > Cantidad)
                {
                    MessageBox.Show("La cantidad supera al producto total vendido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantidadDevuelto.Text = Cantidad.ToString();
                    txtCantidadDevuelto.SelectAll();
                    txtCantidadDevuelto.Focus();

                }
                else
                {
                    decimal totalADevolver = Precio * Convert.ToDecimal(txtCantidadDevuelto.Text);
                    lblTotalDevuelto.Text = totalADevolver.ToString();
                }
            }
           
        }

        private void txtCantidadDevuelto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnDevolverTodo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Seguro desea cancelar la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes && idVenta != 0)
                {
                    ObtenerDetaleVenta(idVenta);

                    BusVentas.Eliminar_Venta(idVenta);
                    MessageBox.Show("¡Operación realizada con éxito!", "Venta eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
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

                        if (item.TipoVenta == (Int32)TIPO_VENTA.P)
                        {
                            p.TipoVenta = ProductoDAL.ObtenerTipoVenta_Preferencial(item.IdProducto, item.UnidadMedida).ToString();
                        }
                        else
                        {
                            p.TipoVenta = (item.TipoVenta == (Int32)TIPO_VENTA.M) ? TIPO_VENTA.M.ToString() : TIPO_VENTA.U.ToString();
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

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int IdDetalle = Convert.ToInt32(grid.SelectedCells[2].Value.ToString());
                int idProducto = Convert.ToInt32(grid.SelectedCells[4].Value.ToString());
                string tipoV = grid.SelectedCells[11].Value.ToString();

                DetalleVentaII detalle = ((DataGridView)sender).CurrentRow.DataBoundItem as DetalleVentaII;

                TIPO_VENTA tipoVenta = (detalle.TipoVenta == 1) ? TIPO_VENTA.M : TIPO_VENTA.U;
                var p = ProductoDAL.ObtenerProducto_x_Codigo(detalle.Codigo, tipoVenta.ToString());

                if (e.ColumnIndex == this.grid.Columns["Eliminar"].Index)
                {
                    p.Cantidad = detalle.Cantidad;
                    DatDetalleVenta.Eliminar_DetalleVenta_PorId(detalle.Id);

                    //bitacora.Detalle = $"Devolución del producto {detalle.IdProducto}, cantidad : {detalle.Cantidad};{detalle.UnidadMedida};{detalle.TipoVenta}, de la venta {detalle.IdVenta}";

                    ProductoDAL.Aumentar_DisminuirStock(p, "AUMENTAR");
                    DatVenta.ActualizarTotalVenta(detalle.IdVenta, detalle.Importe);
                }

                if (e.ColumnIndex == this.grid.Columns["Quitar"].Index)
                {
                    p.Cantidad = 1;
                    if (detalle.Cantidad == 1)
                    {
                         DatDetalleVenta.Eliminar_DetalleVenta_PorId(detalle.Id);
                        //bitacora.ValorActual = "0";
                        //bitacora.Detalle = $"Devolución del producto {detalle.IdProducto}, cantidad : {detalle.Cantidad};{detalle.UnidadMedida};{detalle.TipoVenta}, de la venta {detalle.IdVenta}";
                    }
                    else
                    {
                        detalle.Cantidad = -1;
                        detalle.Importe = detalle.Precio;
                        //bitacora.ValorActual = (detalle.Cantidad - 1).ToString();
                        //bitacora.Detalle = $"Devolución del producto {detalle.IdProducto}, cantidad : {1}; {detalle.UnidadMedida};{detalle.TipoVenta};{detalle.Id}, de la venta {detalle.IdVenta}";
                        DetalleVenta d = new DetalleVenta();
                        d.Id = detalle.Id;
                        d.IdProducto = detalle.IdProducto; ;
                        d.IdVenta = detalle.IdVenta;
                        d.Cantidad = detalle.Cantidad;
                        d.Precio = detalle.Precio;
                        d.TotalPago =detalle.Importe;
                        d.UnidadMedida = detalle.UnidadMedida;
                        d.Estado = "VENTA REALIZADA";
                        d.CantidaMostrada = 0;
                        d.Descripcion = "";// p.Articulo;
                        d.Stock = p.Stock.ToString();
                        d.Codigo = detalle.Codigo;
                        d.UsaInventario = detalle.UsaInventario ? "SI" : "NO";
                        d.Se_Vende_A = "";
                        d.Costo = 0;
                        d.Venta = tipoVenta.ToString();

                        if (!BusDetalleVenta.Agregar_DetalleVenta(d))
                        {
                            MessageBox.Show("Ocurrrió un error al actualizar el registro", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    ProductoDAL.Aumentar_DisminuirStock(p, "AUMENTAR");

                    DatVenta.ActualizarTotalVenta(detalle.IdVenta, detalle.Importe);
                }

                ObtenerDetalleVenta(detalle.IdVenta);

                var result = MessageBox.Show("¿Desea imprimir el ticket?","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ImprimirTicket(detalle.IdVenta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: "+ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
