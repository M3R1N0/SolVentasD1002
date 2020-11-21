namespace Reportes
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for rptTicket.
    /// </summary>
    public partial class rptTicket : Telerik.Reporting.Report
    {
        public rptTicket()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
         
        public rptTicket(DataTable dtDatos )
        {
            InitializeComponent();
        }
    }
}