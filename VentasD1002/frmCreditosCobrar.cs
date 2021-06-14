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
using System.Drawing.Printing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Reporting.Processing;

namespace VentasD1002
{
    public partial class frmCreditosCobrar : Form
    {
        private PrintDocument TICKET;
        public frmCreditosCobrar()
        {
            InitializeComponent();
        }

        private void frmCreditosCobrar_Load(object sender, EventArgs e)
        {
            Listar_TotalCredito_PorCliente();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Listar_TotalCredito_PorCliente();
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                ListarVentar_PorCobrar("");
                pnlAbonar.Visible = false;
                pnlVistaTicket.Visible = false;
                pnlListadoClienteCredito.Visible = false;
            }
        }

        private void Listar_TotalCredito_PorCliente()
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
            finally
            {
                decimal totalCredito = 0;
                foreach (DataGridViewRow item in gdvTotalCredito.Rows)
                {
                    totalCredito += Convert.ToDecimal(item.Cells[6].Value);
                }

                lblTotalCredtio.Text = "$ " + totalCredito.ToString();
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (gdvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione la venta a cobrar", "Venta no existe", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                txtSaldoActual.Text = lblTotalLiquidar.Text;
                pnlAbonar.Visible = true;
                txtMontoAbonar.Focus();
            }
        }

        private void gdvListado_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.gdvListado.Columns["Detalle"].Index)
                {
                    if (pnlAbonar.Visible != true)
                    {
                        int _idusuario = Convert.ToInt32(gdvListado.SelectedCells[3].Value);
                        lblCajero.Text = new BusUser().ListarUsuarios().Where(x => x.Id.Equals(_idusuario)).Select(x => x.Nombre).FirstOrDefault();

                        int _idVenta = Convert.ToInt32(gdvListado.SelectedCells[1].Value);
                        lblIdVenta.Text = _idVenta.ToString();
                        lblCliente.Text = gdvListado.SelectedCells[6].Value.ToString();
                        lblFolio.Text = gdvListado.SelectedCells[7].Value.ToString();
                        lblTicket.Text = gdvListado.SelectedCells[8].Value.ToString();
                        lblMontototal.Text = gdvListado.SelectedCells[9].Value.ToString();
                        lblTotalLiquidar.Text = gdvListado.SelectedCells[10].Value.ToString();

                        decimal _totalAbonado = Convert.ToDecimal(gdvListado.SelectedCells[9].Value.ToString()) - Convert.ToDecimal(gdvListado.SelectedCells[10].Value.ToString());
                        lblTotalAbonado.Text = _totalAbonado.ToString();


                        gdvDetalle.DataSource = new BusDetalleVenta().ListarDetalleVenta_PorCobrar(_idVenta);

                        gdvDetalle.Columns[0].Visible = false;
                        gdvDetalle.Columns[1].Visible = false;
                        gdvDetalle.Columns[2].Visible = false;
                        //gdvDetalle.Columns[8].Visible = false;
                        gdvDetalle.Columns[9].Visible = false;
                        gdvDetalle.Columns[10].Visible = false;
                        gdvDetalle.Columns[11].Visible = false;
                        gdvDetalle.Columns[12].Visible = false;
                        gdvDetalle.Columns[13].Visible = false;
                        gdvDetalle.Columns[14].Visible = false;
                        gdvDetalle.Columns[15].Visible = false;

                        DataTablePersonalizado.Multilinea(ref gdvDetalle);
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un proceso de cobro en curso!, proceda con el guardado o de lo contrario presione cancelar", "Proceso ocupado ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el detalle: " + ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            ListarVentar_PorCobrar(textBox1.Text);
        }

        private void textBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();
        }

        private void bntCancelar_Click_1(object sender, EventArgs e)
        {
            pnlAbonar.Visible = false;
            txtMontoAbonar.Clear();
            txtPendienteLiquidar.Clear();
            txtSaldoActual.Clear();
        }

        private void txtMontoAbonar_TextChanged_1(object sender, EventArgs e)
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

        private void txtMontoAbonar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnAbonar_Click_1(object sender, EventArgs e)
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
                    int _idVenta = Convert.ToInt32(lblIdVenta.Text);
                    decimal abonado = (Convert.ToDecimal(txtPendienteLiquidar.Text)) <= 0 ? Convert.ToDecimal(txtSaldoActual.Text) : Convert.ToDecimal(txtMontoAbonar.Text);
                    decimal efectivo = Convert.ToDecimal(lblTotalAbonado.Text) + Convert.ToDecimal(txtMontoAbonar.Text);

                    try
                    {
                        new BusVentas().Actualizar_VentaACredito((Int32)_idVenta, _saldo, _strEstadoPago, efectivo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la venta a credito : "+ex.StackTrace, "Error");
                    }

                    #region BITACORA PAGO CLIENTE

                    ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
                    string serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
                    int idUsuario = new BusUser().ObtenerUsuario(EncriptarTexto.Encriptar(serialPC)).Id;

                    try
                    {
                        DatCatGenerico.Agregar_BitacoraCliente(_idVenta, idUsuario, abonado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar los datos a la bitacora : " + ex.StackTrace, "Error");
                    }
                    #endregion

                    try
                    {
                        //ParametrosReporte obj = new DatVenta().ObtenerDatos_ComrpobanteCredito(_idVenta, abonado);
                        #region TICKET
                        rptComprobanteAbono _rpt = new rptComprobanteAbono();
                         DataTable dt = new DatVenta().Obtener_ComprobanteCredito(_idVenta, abonado);
                        _rpt.tbCobro.DataSource = dt;
                        _rpt.DataSource = dt;

                        reportViewer1.Report = _rpt;
                        reportViewer1.RefreshReport();

                        pnlVistaTicket.Visible = true;
                        #endregion
                        _rpt = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los datos del reporte : " + ex.StackTrace, "Error");
                    }

                    try
                    {
                        string impresora = DatBox.Obtener_ImpresoraTicket(serialPC, "TICKET");
                        TICKET = new PrintDocument();
                        TICKET.PrinterSettings.PrinterName = impresora;

                        if (TICKET.PrinterSettings.IsValid)
                        {
                            PrinterSettings printerSettings = new PrinterSettings();
                            printerSettings.PrinterName = impresora;

                            ReportProcessor reportProcessor = new ReportProcessor();
                            reportProcessor.PrintReport(reportViewer1.ReportSource, printerSettings);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al imprimir el ticket : " + ex.Message, "Error de impresión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                 

                    LimpiarCampos();
                    ListarVentar_PorCobrar("");
                    MessageBox.Show("Abono realizado correctamente", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AgregarBitacora(_idVenta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error de actulizacion de pagos a crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            pnlVistaTicket.Visible = false;
        }

        private void ListarVentar_PorCobrar(string busqueda)
        {
            try
            {
                List<Venta> _lstVenta = new BusVentas().ListarVentas_PorCobrar(busqueda);
                gdvListado.DataSource = _lstVenta;

                gdvListado.Columns[1].Visible = false;
                gdvListado.Columns[2].Visible = false;
                gdvListado.Columns[3].Visible = false;
                gdvListado.Columns[4].Visible = false;
                gdvListado.Columns[8].Visible = false;
                gdvListado.Columns[9].Visible = false;
                gdvListado.Columns[10].Visible = false;
                gdvListado.Columns[11].Visible = false;
                gdvListado.Columns[12].Visible = false;
                gdvListado.Columns[13].Visible = false;
                gdvListado.Columns[14].Visible = false;
                gdvListado.Columns[15].Visible = false;
                gdvListado.Columns[16].Visible = false;
                gdvListado.Columns[17].Visible = false;
                gdvListado.Columns[18].Visible = false;

                DataTablePersonalizado.Multilinea(ref gdvListado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la lista: " + ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            pnlAbonar.Visible = false;
            txtMontoAbonar.Clear();
            txtPendienteLiquidar.Clear();
            txtSaldoActual.Clear();

            gdvDetalle.DataSource = null;

            lblIdVenta.Text = "...";
            lblFolio.Text = "...";
            lblCajero.Text = "...";
            lblCliente.Text = "...";
            lblTicket.Text = "...";
            lblMontototal.Text = "...";
            lblTotalAbonado.Text = "...";
            lblTotalLiquidar.Text = "...";
            TICKET = null;
        }

        private void AgregarBitacora(int idventa)
        {
            try
            {
                string serialPC = Sistema.ObenterSerialPC();

                int idCaja = new BusBox().showBoxBySerial(serialPC).Id;
                int idusuario = new BusUser().ObtenerUsuario(EncriptarTexto.Encriptar(serialPC)).Id;

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

    }
}
