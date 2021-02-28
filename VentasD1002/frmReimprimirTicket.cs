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
using Reportes;
using System.Drawing.Printing;
using Telerik.Reporting.Processing;
using System.Management;
using EntVenta;

namespace VentasD1002
{
    public partial class frmReimprimirTicket : Form
    {
        private PrintDocument reporte;
        string serialPC;

        public frmReimprimirTicket()
        {
            InitializeComponent();
        }

        private void frmReimprimirTicket_Load(object sender, EventArgs e)
        {
            ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
            serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();

            pnlBuscarPorCLiente.Visible = false;
        }

        private void ObtenerDatos(string buscar)
        {
            try
            {
                DataTable dt = DatVenta.ObtenerTickets(dtpInicio.Value, dtpFin.Value, buscar);
                gdvListado.DataSource = dt;

                gdvListado.Columns[1].Visible = false;
                DataTablePersonalizado.Multilinea(ref gdvListado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de lectura : "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            ObtenerDatos(string.Empty);
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            ObtenerDatos(string.Empty);
        }

        private void gdvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.gdvListado.Columns["Detalle"].Index)
                {
                    int idventa = Convert.ToInt32(gdvListado.SelectedCells[1].Value);
                    string total = Convert.ToString(gdvListado.SelectedCells[7].Value);

                    string textoNumero = NumeroATexto(total);

                    ParametrosReporte reporte = DatVenta.Consultar_Ticket_Parametro(idventa);
                    reporte.LetraNumero = textoNumero;
                 

                    if (rbTicket.Checked == true)
                    {
                        rptTicket rptTicket = new rptTicket();
                        rptTicket.tbTicket.DataSource = reporte.lstDetalleVenta;
                        rptTicket.DataSource = reporte;
                        reportViewer1.Report = rptTicket;
                    }
                    else if(RbtnMod2.Checked)
                    {
                        ReportTicket rptTicket = new ReportTicket();
                        rptTicket.tbTicket.DataSource = reporte.lstDetalleVenta;
                        rptTicket.DataSource = reporte;
                        reportViewer1.Report = rptTicket;
                    }
                    else
                    {
                        rtpRecibo recibo = new rtpRecibo();
                        recibo.tblVentaProducto.DataSource = reporte.lstDetalleVenta;
                        recibo.DataSource = reporte;
                        reportViewer1.Report = recibo;
                    }
                    
                    reportViewer1.RefreshReport();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de al intentar obtener el ticket "+ ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string NumeroATexto(string _strtotal)
        {
            string total = _strtotal;
            total = decimal.Parse(total).ToString("##0.00");
            int numero = Convert.ToInt32(Math.Floor(Convert.ToDouble(total)));
            string strTotal = Convertir_NumeroLetra.Conversion_Total_a_Letra(numero);
            string[] a = total.Split('.');
            string strTotalDecimal = a[1];
            string strTotalConvertido = strTotal + " " + strTotalDecimal + "/100 M.N";

            return strTotalConvertido;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string impresora="";

                if (rbTicket.Checked == true)
                {
                    impresora = DatBox.Obtener_ImpresoraTicket(serialPC, "TICKET");
                }
                else if (rbA4.Checked == true)
                {
                    impresora = DatBox.Obtener_ImpresoraTicket(serialPC, "RECIBO");
                }
                
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

        }

        private void rbtnFiltroCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnFiltroCliente.Checked == true)
            {
                pnlBuscarPorCLiente.Visible = true;
            }
            else
            {
                pnlBuscarPorCLiente.Visible = false;
            }
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            ObtenerDatos(txtBuscarCliente.Text);
        }

        private void txtBuscarCliente_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarCliente.SelectAll();
        }

        private void txtBuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                txtBuscarCliente.Clear();
            }
        }
    }
}
