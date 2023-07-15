namespace Reportes
{
    using EntVenta;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for rptComprobanteAbono.
    /// </summary>
    public partial class rptComprobanteAbono : Telerik.Reporting.Report
    {
        public rptComprobanteAbono()
        {
            InitializeComponent();
        }

        public rptComprobanteAbono(DataTable table)
        {
            InitializeComponent();
            tbCobro.DataSource = table;
            DataSource = table;
        }

    }
}