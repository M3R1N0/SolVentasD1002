using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
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
using Telerik.ReportViewer.WinForms;
using VentasD1002.Helpers;

namespace VentasD1002
{
    public partial class frmCobrar : Form
    {
        private Venta _venta;
        public frmCobrar(Venta venta)
        {
            InitializeComponent();
            _venta = venta;
            txtTotal.Text = _venta.MontoTotal.ToString();
            ObtenerTipoDocumento();
            txtCambio.Text = "0";
            txtRecibo.Text = "0";
        }

        private void ObtenerTipoDocumento()
        {
            try
            {
                var lst = DatSerializacion.ObtenerTipoDocumento(DESTINO_DOCUMENTO.VENTAS.ToString());
                cboTipoNota.DataSource = lst;
                cboTipoNota.DisplayMember = "Tipo_Documento";
                cboTipoNota.ValueMember = "Id";
            }
            catch (Exception)
            {
            }
        }

        private void txtRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Comun.TextBoxNumerico(sender,e);
        }

        private void ObtenerCambio()
        {
            try
            {
                decimal total = Convert.ToDecimal(txtTotal.Text);
                decimal recibo = (string.IsNullOrEmpty(txtRecibo.Text)) ? 0 : Convert.ToDecimal(txtRecibo.Text);
                decimal cambio = Convert.ToDecimal(txtCambio.Text);

                cambio = (total - recibo);
                lblMensaje.Visible = (cambio > 0) ? true : false;

                txtCambio.Text = cambio.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtRecibo_TextChanged(object sender, EventArgs e)
        {
            ObtenerCambio();
        }

        private void cancelarVentaF9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmarVenta(IMPRIMIR_REPORTE.SI);
        }

        private void ConfirmarVenta(IMPRIMIR_REPORTE imprimirReporte)
        {
            try
            {
                OperationResponse respuesta = OperationResponse.Success("");

                decimal recibo = (string.IsNullOrEmpty(txtRecibo.Text)) ? 0 : Convert.ToDecimal(txtRecibo.Text);
                _venta.Folio = Comun.ObtenerFolio(DESTINO_DOCUMENTO.VENTAS, Convert.ToInt32(cboTipoNota.SelectedValue));
                var arr = _venta.Folio.Split('-');
                var folio = Convert.ToInt32(arr[1]) + 1;
                DatSerializacion.ActualizarFolio(folio.ToString(), Convert.ToInt32(cboTipoNota.SelectedValue));

                _venta.Vuelto = Convert.ToDecimal(txtCambio.Text);
                _venta.Recibo = recibo;
                _venta.Efectivo = recibo;
                _venta.EstadoPago = ESTADO_PAGO.PAGADO.ToString();
                _venta.Saldo = 0;
                _venta.FechaLiquidacion = DateTime.Now.ToString();
                _venta.FechaVenta = DateTime.Now;

                if (_venta.MontoTotal > _venta.Recibo)
                { 
                    _venta.Saldo = _venta.Vuelto;
                    _venta.FechaLiquidacion = dpLiquidacion.Value.AddDays(15).ToString();
                    _venta.EstadoPago = ESTADO_PAGO.PENDIENTE.ToString();
                    _venta.Vuelto = 0;
                    _venta.FormaPago = "Credito";
                }

                if (_venta.FormaPago.ToUpper() == TIPO_PAGO.CREDITO.ToString() && _venta.Recibo == 0)
                {
                    _venta.Vuelto = (_venta.Vuelto > 0) ? 0 : _venta.Vuelto;
                }

                BusVentas.AgregarVenta(_venta);

                if (_venta.FormaPago.ToUpper() == TIPO_PAGO.CREDITO.ToString() && (_venta.Recibo != 0 && _venta.Recibo <= _venta.MontoTotal))
                {
                    DatCatGenerico.Agregar_BitacoraCliente(_venta.Id, _venta.IdUsuario, _venta.Recibo);
                }

                if (imprimirReporte == IMPRIMIR_REPORTE.SI)
                {
                    TIPO_DOCUMENTO TIPO = Comun.ObtenerTipoDocumento(cboTipoNota.Text.ToUpper());
                    for (int i = 1; i <= 2; i++)
                    {
                        respuesta = ImprimirDocumento.Imprimir(ref reportViewer1, DESTINO_DOCUMENTO.VENTAS, TIPO, _venta.Id);
                        //MessageBox.Show($"IMPRESION N° {i.ToString()}");
                        if (_venta.FormaPago.ToUpper() == TIPO_PAGO.CONTADO.ToString())
                        {
                            break;
                        }
                    }
                }

                if (respuesta.IsSuccess == EnumOperationResult.Warning)
                {
                    MessageBox.Show(respuesta.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (respuesta.IsSuccess == EnumOperationResult.Failure)
                {
                    MessageBox.Show(respuesta.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                }

                ReestablecerDatos(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ocurrió un error al asignar los datos! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReestablecerDatos(bool ventaRealizada)
        {
            try
            {
                frmVenta.EsVentaRealizada = ventaRealizada;
                this.Close();
            }
            catch (Exception)
            {
                this.Close();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfirmarVenta(IMPRIMIR_REPORTE.NO);
        }

       
    }
}
