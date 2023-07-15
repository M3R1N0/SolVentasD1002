namespace Reportes
{
    using EntVenta;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for rtpRecibo.
    /// </summary>
    public partial class rtpRecibo : Telerik.Reporting.Report
    {
        public rtpRecibo()
        {
            InitializeComponent();
        }

        public rtpRecibo(ParametrosReporte datos)
        {
            try
            {
                InitializeComponent();
                //rptNota.pnlCancelar.Visible = false;
                lblCambio.Value = (datos.FormaPago.Equals("CONTADO", StringComparison.InvariantCultureIgnoreCase)) ? "Cambio :" : "Saldo a liquidar :";
                //   rptNota.txtCambio.Visible = (reporte.FormaPago.Equals("CONTADO", StringComparison.InvariantCultureIgnoreCase)) ? true : false;
                lblBonificacion.Visible = false;
                txtBonificacion.Visible = false;

                tblVentaProducto.DataSource = datos.lstDetalleVenta;
                DataSource = datos;
            }
            catch (Exception)
            {
            }
        }
    }
}