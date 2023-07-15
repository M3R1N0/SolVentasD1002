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
    public partial class frmBonificacion : Form
    {
        public frmBonificacion()
        {
            InitializeComponent();
        }

        String serialPC;
        int idUsuario;
        int idCaja;
        public static int idVenta;
        string strUsuario;
        ParametrosReporte obj;

        private void frmBonificacion_Load(object sender, EventArgs e)
        {
            serialPC = Sistema.ObenterSerialPC();
            idUsuario =  BusUser.ObtenerUsuario_Loggeado().Id;
            strUsuario = BusUser.ObtenerUsuario_Loggeado().Nombre;
            idCaja = new DatBox().Obtener_CajaSerial(serialPC);

            ObtenerDatos();
        }

        private void ObtenerDatos()
        {
            try
            {
                obj =  DatVenta.Obtnener_DatosBonificacion(idVenta);
                txtCliente.Text = obj.Cliente;
                txtDireccion.Text = obj.DireccionCliente;
                txtFechaVenta.Text = obj.FechaVenta.ToString();
                txtFolio.Text = obj.Folio;
                txtCajero.Text = obj.Cajero;
                txtMontoTotal.Text = obj.MontoTotal.ToString();
                txtFormaPago.Text = obj.FormaPago.ToUpper();
                txtEstadoPago.Text = obj.EstadoPago;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al obtener los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBonificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtBonificacion_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBonificacion.Text) || txtBonificacion.Equals("0"))
            {
                txtBonificacion.Text = "0";
                txtBonificacion.SelectAll();
            }
         
        }

        private void cobrarF10_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtBonificacion.Text) > 0 && !string.IsNullOrEmpty(txtDetalle.Text))
                {
                    Venta v = new Venta();
                    v.Id = idVenta;
                    v.IdCliente = obj.IdDetalleVenta;
                    v.IdUsuario = idUsuario;
                    v.IdCaja = idCaja;
                    v.Vuelto = Convert.ToDecimal(txtBonificacion.Text);
                    v.Accion = txtDetalle.Text;

                    DatVenta.AgregarBonificacion(v);

                    Venta venta = new Venta();
                    venta.Id = obj.Id;
                    venta.Vuelto = obj.Cambio + v.Vuelto;
                    venta.Saldo = obj.Saldo - v.Vuelto;
                    venta.MontoTotal = obj.MontoTotal - v.Vuelto;
                    venta.EstadoPago = (obj.Saldo <= 0) ? "PAGADO" : "PENDIENTE";

                    DatVenta.EditarDatos_Devoluciones(venta);
                    obj.Bonificacion = Convert.ToDecimal(txtBonificacion.Text);
                    obj.Cajero = strUsuario;
                   // obj.PaginaWeb = "Se realizó una bonificación al Folio: "+obj.Folio +" la cantidad de : $"+txtBonificacion.Text;
                    rptComprobanteBonificacion rptTicket = new rptComprobanteBonificacion();
                    rptTicket.DataSource = obj;
                    reportViewer1.Report = rptTicket;
                    reportViewer1.RefreshReport();
                    imprimitTicket();
                    AgregarBitacora(v.Id);
                }
                else
                {
                    MessageBox.Show("Ingrese la bonificacion y el detalle", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally {
                idVenta = 0;
                obj = null;

                txtBonificacion.Clear();
                txtDetalle.Clear();
            }
        }

        private void imprimitTicket()
        {
            try
            {
                string impresora = "";
                PrintDocument reporte = null;
                impresora = DatBox.Obtener_ImpresoraTicket(serialPC, "TICKET");

                reporte = new PrintDocument();
                reporte.PrinterSettings.PrinterName = impresora;

                if (reporte.PrinterSettings.IsValid)
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
            finally {
                //this.Hide();
                //frmReimprimirTicket frm= new frmReimprimirTicket();
                //frm.ShowDialog();
                //this.Dispose();
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarBitacora(int idventa)
        {
            try
            {
               
                Bitacora b = new Bitacora();
                b.Fecha = DateTime.Now;
                b.IdUsuario = idUsuario;
                b.IdCaja = idCaja;
                b.Accion = $"BONIFICACION DE LA VENTA [{idventa}]";

                DatCatGenerico.AgregarBitácora(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la bitacora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
