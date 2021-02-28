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
    /// Summary description for rptTicketCopia.
    /// </summary>
    public partial class rptTicketCopia : Telerik.Reporting.Report
    {
        public rptTicketCopia()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public rptTicketCopia(ParametrosReporte obj)
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.tbTicketCopia.DataSource = obj.lstDetalleVenta;
        }
    }
}