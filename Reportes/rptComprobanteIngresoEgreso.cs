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
    /// Summary description for rptComprobanteIngresoEgreso.
    /// </summary>
    public partial class rptComprobanteIngresoEgreso : Telerik.Reporting.Report
    {
        public rptComprobanteIngresoEgreso()
        {
            InitializeComponent();
        }

        public rptComprobanteIngresoEgreso(Empresa empresa, IngresosGastos ingresosGastos)
        {
            InitializeComponent();
            this.DataSource = empresa;
            txtUsuario.Value = ingresosGastos.Usuario;
            txtDetalle.Value = ingresosGastos.Descripcion;
            txtMonto.Value = String.Format("{0:N2}",ingresosGastos.Importe);
        }
    }
}