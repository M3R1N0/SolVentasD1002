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
using VentasD1002.Helpers;

namespace VentasD1002
{
    public partial class frmAbonarCredito : Form
    {
        private Venta venta;
        public frmAbonarCredito(Venta venta )
        {
            InitializeComponent();
            this.venta = venta;
            txtMontoAbonar.Focus();
            txtSaldoActual.Text = venta.Saldo.ToString();
            
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            Comun.LimpiarTextBox(this.Controls);
            this.Close();
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMontoAbonar.Text))
                {
                    MessageBox.Show("Ingrese la cantidad a Abonar", "Datos necesarios", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtMontoAbonar.Focus();
                }
                else
                {
                    string _strEstadoPago = (Convert.ToDecimal(txtMontoAbonar.Text) >= Convert.ToDecimal(txtSaldoActual.Text)) ? "PAGADO" : "PENDIENTE";
                    decimal _saldo = (Convert.ToDecimal(txtPendienteLiquidar.Text) <= 0) ? 0 : Convert.ToDecimal(txtPendienteLiquidar.Text);
                    //int _idVenta = Convert.ToInt32(lblIdVenta.Text);
                    decimal abonado = (Convert.ToDecimal(txtPendienteLiquidar.Text)) <= 0 ? Convert.ToDecimal(txtSaldoActual.Text) : Convert.ToDecimal(txtMontoAbonar.Text);
                    decimal efectivo = venta.Efectivo + Convert.ToDecimal(txtMontoAbonar.Text);

                    try
                    {
                        new BusVentas().Actualizar_VentaACredito(venta.Id, _saldo, _strEstadoPago, efectivo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la venta a credito : " + ex.StackTrace, "Error");
                    }

                    #region BITACORA PAGO CLIENTE

                    int idUsuario = BusUser.ObtenerUsuario_Loggeado().Id;

                    try
                    {
                        DatCatGenerico.Agregar_BitacoraCliente(venta.Id, idUsuario, abonado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar los datos a la bitacora : " + ex.StackTrace, "Error");
                    }
                    #endregion

                    try
                    {
                        #region TICKET
                        DataTable dt = new DatVenta().Obtener_ComprobanteCredito(venta.Id, abonado);
                        rptComprobanteAbono _rpt = new rptComprobanteAbono(dt);

                        reportViewer1.Report = _rpt;
                        reportViewer1.RefreshReport();
                        //reportViewer1.Visible = true;

                        var respuesta = ImprimirDocumento.Imprimir(ref reportViewer1, TIPO_DOCUMENTO.TICKET);

                        if (respuesta.IsSuccess == EnumOperationResult.Failure)
                        {
                            MessageBox.Show(respuesta.Message, "Error de impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (respuesta.IsSuccess == EnumOperationResult.Warning)
                        {
                            MessageBox.Show(respuesta.Message, "Error de impresión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                        }

                        #endregion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los datos del reporte : " + ex.StackTrace, "Error");
                    }

                    MessageBox.Show("Abono realizado correctamente", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AgregarBitacora(venta.Id);
                    LimpiarCampos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error de actulizacion de pagos a crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtMontoAbonar.Text="0";
            txtPendienteLiquidar.Text = "0";
            txtSaldoActual.Text = "0";
        }

        private void AgregarBitacora(int idventa)
        {
            try
            {
                string serialPC = Sistema.ObenterSerialPC();

                int idCaja = BusBox.showBoxBySerial().Id;
                int idusuario = BusUser.ObtenerUsuario_Loggeado().Id;

                Bitacora b = new Bitacora();
                b.Fecha = DateTime.Now;
                b.IdUsuario = idusuario;
                b.IdCaja = idCaja;
                b.Accion = $"ABONO DE VENTA A CREDITO [{idventa}]";

                DatCatGenerico.AgregarBitácora(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la bitacora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMontoAbonar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtMontoAbonar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMontoAbonar.Text) || txtMontoAbonar.Equals("0"))
            {
                txtMontoAbonar.Text = "0";
                txtMontoAbonar.SelectAll();
            }
            else
            {
                decimal _saldo = Convert.ToDecimal(txtSaldoActual.Text);
                decimal _Pendiente = _saldo - (Convert.ToDecimal(txtMontoAbonar.Text));
                txtPendienteLiquidar.Text = _Pendiente.ToString();
            }
        }
    }
}
