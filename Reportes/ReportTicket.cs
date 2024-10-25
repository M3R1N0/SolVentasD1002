namespace Reportes
{
    using BusVenta.Helpers;
    using DatVentas;
    using EntVenta;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for ReportTicket.
    /// </summary>
    public partial class ReportTicket : Telerik.Reporting.Report
    {
        public ReportTicket()
        {
            InitializeComponent();
        }

        public ReportTicket(ParametrosReporte datos)
        {
            try
            {
                InitializeComponent();
                pbLogo.Value = DatEmpresa.ObtenerLogoEmpresa();

                txtDireccion.Value = datos.Direccion;
                txtEmpresa.Value = datos.NombreEmpresa;
                txtProvincia.Value = datos.Provincia;
                txtFolio.Value = datos.Folio;
                txtFormaPago.Value = datos.FormaPago.ToUpper();
                txtSubEncabezado.Value = datos.SubEncabezado;
                txtNotaPieTicket.Value = datos.NotaPieTicket;

                txtCliente.Value = datos.Cliente;
                txtRuc.Value = datos.Ruc;
                txtDireccionCliente.Value = datos.DireccionCliente;
                txtFechaVenta.Value = datos.FechaVenta.ToString("dd/MM/yyyy hh:mm");

                lblCambio.Value = (datos.FormaPago.Equals("CONTADO", StringComparison.InvariantCultureIgnoreCase)) ? "Cambio:" : "Saldo a liquidar:";
                lblEfectivo.Value = (datos.FormaPago.Equals("CONTADO", StringComparison.InvariantCultureIgnoreCase)) ? "Efectivo:" : "Monto abonado:";
                lblBonificacion.Visible = false;
                txtBonificacion.Visible = false;


                if (datos.MontoTotal != 0)
                {
                    txtMontoTotal.Value = string.Format("{0:N2}", datos.MontoTotal);
                    txtEfectivo.Value = string.Format("{0:N2}", datos.Efectivo);
                    txtCambio.Value = string.Format("{0:N2}", datos.Cambio);
                    txtBonificacion.Value = string.Format("{0:N2}", datos.Bonificacion);
                }
                else
                {
                    txtMontoTotal.Value = string.Format("{0:N2}", datos.lstDetalleVenta.Select(x=> x.TotalPago).Sum());
                    txtEfectivo.Value = string.Format("{0:N2}", datos.Efectivo);
                    txtCambio.Value = string.Format("{0:N2}", datos.Cambio);
                    txtBonificacion.Value = string.Format("{0:N2}", datos.Bonificacion);
                }

                txtLetraNumero.Value = datos.LetraNumero;
                txtComentario.Value = (string.IsNullOrEmpty(datos.Comentarios)) ? "" :datos.Comentarios;
                txtAtendio.Value = $"¡ Lo atendió {datos.Cajero} !";
                txtAgradecimiento.Value = datos.Agradecimiento;
                txtAnuncio.Value = datos.Anuncio;
                txtArticulosVendidos.Value = $"Total artículos vendidos: {string.Format("{0:N}",datos.lstDetalleVenta.Count)}";

                if (datos.FormaPago.ToUpper() == TIPO_PAGO.COTIZACION.ToString() || datos.MontoTotal == 0)
                {
                    pnlCotizacion.Visible = false;

                    Telerik.Reporting.Drawing.TextWatermark textWatermark1 = new Telerik.Reporting.Drawing.TextWatermark();
                    textWatermark1.Color = System.Drawing.Color.LightGray;
                    textWatermark1.Font.Bold = true;
                    textWatermark1.Font.Italic = false;
                    textWatermark1.Font.Name = "Arial Black";
                    textWatermark1.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
                    textWatermark1.Font.Strikeout = false;
                    textWatermark1.Font.Underline = false;
                    textWatermark1.Orientation = Telerik.Reporting.Drawing.WatermarkOrientation.Diagonal;
                    textWatermark1.Position = Telerik.Reporting.Drawing.WatermarkPosition.Behind;
                    textWatermark1.PrintOnFirstPage = true;
                    textWatermark1.PrintOnLastPage = true;
                    textWatermark1.Text = "COTIZACIÓN";
                    textWatermark1.Opacity = 0.3D;
                    this.Report.PageSettings.Watermarks.Add(textWatermark1);
                }

                var lstCat = (from c in datos.lstDetalleVenta
                              select new DetalleVenta() {
                                  UnidadMedida = c.UnidadMedida
                              }).ToList();

                var lst = lstCat.GroupBy(car => car.UnidadMedida)
                                .Select(g => g.First()).ToList();

                this.objectDataSource1.DataSource = lst;
                tbTicket.DataSource = datos.lstDetalleVenta;

            }
            catch (Exception)
            {

            }
        }
    }
}