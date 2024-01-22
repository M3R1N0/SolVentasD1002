using BusVenta.Helpers;
using EntVenta;
using System;
using System.Drawing;
using System.Linq;

namespace Reportes
{
    /// <summary>
    /// Summary description for ReportTicket.
    /// </summary>
    public partial class ReportTicket : Telerik.Reporting.Report
    {
        public ReportTicket()
        {
            InitializeComponent();
        }

        public ReportTicket(ParametrosReporte vm)
        {
            InitializeComponent();

            pbLogo.Value = Sistema.ByteToImage(vm.LogoEmpresa);// vm.LogoEmpresa;
            txtEmpresa.Value = vm.NombreEmpresa;
            txtDireccion.Value = vm.Direccion;
            txtProvincia.Value = vm.Provincia;
            txtFolio.Value = vm.Folio;
            txtTV.Value = vm.FormaPago;
            txtCliente.Value = vm.Cliente;
            txtNoCliente.Value = vm.Ruc;
            txtDireccionCliente.Value = vm.DireccionCliente;
            txtFechaVenta.Value = vm.FechaVenta.ToString();
            txtTotal.Value = string.Format("{0:C2}",vm.MontoTotal.ToString()) ;
            txtEfectivo.Value = string.Format("{0:C2}", vm.Efectivo.ToString());
            txtCambio.Value = string.Format("{0:C2}", vm.Cambio.ToString());
            txtBonificación.Value = string.Format("{0:C2}", vm.Bonificacion.ToString());
            txtTotalLetra.Value = vm.LetraNumero;
            txtComentario.Value = (vm.Comentarios == "N/A" || string.IsNullOrEmpty(vm.Comentarios)) ? "" : "NOTA: "+vm.Comentarios;
            txtCajero.Value = $"¡Lo antendió {vm.Cajero}!";
            txtAgradecimiento.Value = vm.Agradecimiento;
            txtAnuncio.Value = vm.Anuncio;
            txtTotalArticulos.Value = $"Productos vendidos: {vm.TotalProducto}";

            //pnlCancelar.Visible = (vm.EstadoVenta == "VENTA CANCELADA") ? true : false;

            if (vm.EstadoVenta == "VENTA CANCELADA")
            {
                Telerik.Reporting.Drawing.TextWatermark textWatermark1 = new Telerik.Reporting.Drawing.TextWatermark();
                textWatermark1.Color = System.Drawing.Color.LightGray;
                textWatermark1.Font.Bold = true;
                textWatermark1.Font.Italic = false;
                textWatermark1.Font.Name = "Cascadia Code SemiBold";
                textWatermark1.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
                textWatermark1.Font.Strikeout = false;
                textWatermark1.Font.Underline = false;
                textWatermark1.Orientation = Telerik.Reporting.Drawing.WatermarkOrientation.Diagonal;
                textWatermark1.Position = Telerik.Reporting.Drawing.WatermarkPosition.Behind;
                textWatermark1.PrintOnFirstPage = true;
                textWatermark1.PrintOnLastPage = true;
                textWatermark1.Text = "CANCELADO";
                textWatermark1.Opacity = 0.3D;
                this.Report.PageSettings.Watermarks.Add(textWatermark1);
            }


            lblCambio.Value = (vm.FormaPago.Equals("CONTADO", StringComparison.InvariantCultureIgnoreCase)) ? "Cambio :" : "Saldo por liquidar :";
            // rptTicket.txtCambio.Visible = (reporte.FormaPago.Equals("CONTADO", StringComparison.InvariantCultureIgnoreCase)) ? true : false;
            lblBonificacion.Visible = (vm.Bonificacion != 0) ? true : false;
            txtBonificación.Visible = (vm.Bonificacion != 0) ? true : false;
           
            tbTicket.DataSource = vm.lstDetalleVenta;
            var lst = vm.lstDetalleVenta.Select(x => new CatalogoGenerico { Nombre = x.UnidadMedida }).Distinct().ToList();
            lst = lst.GroupBy(x => x.Nombre)
                    .Select(x => x.First()).ToList();
            objectDataSource1.DataSource = lst;

        }
    }
}