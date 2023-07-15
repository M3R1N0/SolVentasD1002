namespace Reportes
{

    partial class rptComprobanteBonificacion
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptComprobanteBonificacion));
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.pbLogo = new Telerik.Reporting.PictureBox();
            this.txtEmpresa = new Telerik.Reporting.TextBox();
            this.txtProvincia = new Telerik.Reporting.TextBox();
            this.txtDireccion = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.txtTituloTicket = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.txtAgradecimiento = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.reportHeaderSection1 = new Telerik.Reporting.ReportHeaderSection();
            this.textBox22 = new Telerik.Reporting.TextBox();
            this.textBox24 = new Telerik.Reporting.TextBox();
            this.txtCliente = new Telerik.Reporting.TextBox();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox28 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.txtTicket = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.9D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pbLogo,
            this.txtEmpresa,
            this.txtProvincia,
            this.txtDireccion});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.3D), Telerik.Reporting.Drawing.Unit.Cm(0.074D));
            this.pbLogo.MimeType = "image/png";
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.434D), Telerik.Reporting.Drawing.Unit.Cm(1.2D));
            this.pbLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pbLogo.Style.BackgroundImage.ImageData = ((System.Drawing.Image)(resources.GetObject("pbLogo.Style.BackgroundImage.ImageData")));
            this.pbLogo.Style.BackgroundImage.MimeType = "image/png";
            this.pbLogo.Value = ((object)(resources.GetObject("pbLogo.Value")));
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.9D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.txtEmpresa.Style.Font.Bold = true;
            this.txtEmpresa.Style.Font.Name = "Segoe UI";
            this.txtEmpresa.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtEmpresa.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtEmpresa.Value = "=Fields.NombreEmpresa";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(2.347D));
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.9D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtProvincia.Style.Font.Bold = false;
            this.txtProvincia.Style.Font.Name = "Segoe UI";
            this.txtProvincia.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtProvincia.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtProvincia.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtProvincia.Value = "=Fields.Provincia";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.012D), Telerik.Reporting.Drawing.Unit.Cm(2D));
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.9D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtDireccion.Style.Font.Bold = false;
            this.txtDireccion.Style.Font.Name = "Segoe UI";
            this.txtDireccion.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtDireccion.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtDireccion.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtDireccion.Value = "=Fields.Direccion";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.5D), Telerik.Reporting.Drawing.Unit.Cm(0.8D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.412D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox4.Style.Font.Bold = false;
            this.textBox4.Style.Font.Name = "Segoe UI";
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.Value = "=Now()";
            // 
            // txtTituloTicket
            // 
            this.txtTituloTicket.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0.4D));
            this.txtTituloTicket.Name = "txtTituloTicket";
            this.txtTituloTicket.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.911D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtTituloTicket.Style.Font.Bold = true;
            this.txtTituloTicket.Style.Font.Name = "Segoe UI";
            this.txtTituloTicket.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtTituloTicket.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtTituloTicket.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtTituloTicket.Value = "COMPROBANTE DE BONIFICACIÓN";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.132D);
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.detail.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.detail.Style.Visible = false;
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1.368D);
            this.pageFooterSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtAgradecimiento,
            this.textBox1});
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // txtAgradecimiento
            // 
            this.txtAgradecimiento.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.013D), Telerik.Reporting.Drawing.Unit.Cm(0.068D));
            this.txtAgradecimiento.Name = "txtAgradecimiento";
            this.txtAgradecimiento.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.898D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtAgradecimiento.Style.Font.Bold = true;
            this.txtAgradecimiento.Style.Font.Name = "Segoe UI";
            this.txtAgradecimiento.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtAgradecimiento.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtAgradecimiento.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtAgradecimiento.Value = "¡I M P O R T A N T E!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.014D), Telerik.Reporting.Drawing.Unit.Cm(0.368D));
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.898D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox1.Style.Font.Bold = false;
            this.textBox1.Style.Font.Name = "Segoe UI";
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "Favor de conservar el ticket para el corte de caja";
            // 
            // reportHeaderSection1
            // 
            this.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(4D);
            this.reportHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox22,
            this.textBox24,
            this.txtCliente,
            this.textBox16,
            this.textBox28,
            this.textBox9,
            this.txtTicket,
            this.txtTituloTicket,
            this.textBox3,
            this.textBox6,
            this.textBox7,
            this.textBox4});
            this.reportHeaderSection1.Name = "reportHeaderSection1";
            // 
            // textBox22
            // 
            this.textBox22.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(4D));
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.911D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.textBox22.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox22.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.25D);
            this.textBox22.Style.Font.Bold = true;
            this.textBox22.Style.Font.Name = "Segoe UI";
            this.textBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox22.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dashed;
            this.textBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox22.Value = "";
            // 
            // textBox24
            // 
            this.textBox24.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.911D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.textBox24.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox24.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.25D);
            this.textBox24.Style.Font.Bold = true;
            this.textBox24.Style.Font.Name = "Courier New";
            this.textBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox24.Value = "";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(1.4D));
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtCliente.Style.Font.Bold = false;
            this.txtCliente.Style.Font.Name = "Segoe UI";
            this.txtCliente.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtCliente.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtCliente.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtCliente.Value = "=Fields.Cajero";
            // 
            // textBox16
            // 
            this.textBox16.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.319D), Telerik.Reporting.Drawing.Unit.Cm(1.44D));
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox16.Style.Font.Bold = false;
            this.textBox16.Style.Font.Name = "Segoe UI";
            this.textBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox16.Value = "Cajero:";
            // 
            // textBox28
            // 
            this.textBox28.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.6D), Telerik.Reporting.Drawing.Unit.Cm(0.785D));
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox28.Style.Font.Bold = true;
            this.textBox28.Style.Font.Italic = false;
            this.textBox28.Style.Font.Name = "Segoe UI";
            this.textBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox28.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox28.Value = "Fecha:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.013D), Telerik.Reporting.Drawing.Unit.Cm(1.8D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.887D), Telerik.Reporting.Drawing.Unit.Cm(0.4D));
            this.textBox9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox9.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox9.Style.Font.Bold = true;
            this.textBox9.Style.Font.Italic = false;
            this.textBox9.Style.Font.Name = "Segoe UI";
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox9.Value = "Detalle:";
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.3D), Telerik.Reporting.Drawing.Unit.Cm(2.3D));
            this.txtTicket.Multiline = true;
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.txtTicket.Style.Font.Bold = false;
            this.txtTicket.Style.Font.Name = "Segoe UI";
            this.txtTicket.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtTicket.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtTicket.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtTicket.Value = "Monto:";
            // 
            // textBox3
            // 
            this.textBox3.Format = "{0:C2}";
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.8D), Telerik.Reporting.Drawing.Unit.Cm(2.3D));
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.748D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox3.Style.Font.Bold = true;
            this.textBox3.Style.Font.Name = "Segoe UI";
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.Value = "=Fields.Bonificacion";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.3D), Telerik.Reporting.Drawing.Unit.Cm(2.9D));
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox6.Style.Font.Bold = false;
            this.textBox6.Style.Font.Name = "Segoe UI";
            this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox6.Value = "Concepto:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.8D), Telerik.Reporting.Drawing.Unit.Cm(2.9D));
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.748D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox7.Style.Font.Bold = false;
            this.textBox7.Style.Font.Italic = true;
            this.textBox7.Style.Font.Name = "Segoe UI";
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox7.Value = "=Fields.Folio";
            // 
            // rptComprobanteBonificacion
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1,
            this.reportHeaderSection1});
            this.Name = "rptComprobanteAbono";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(1D), Telerik.Reporting.Drawing.Unit.Mm(1D), Telerik.Reporting.Drawing.Unit.Mm(2D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PageSettings.PaperSize = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(200D));
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(7.912D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PictureBox pbLogo;
        private Telerik.Reporting.TextBox txtEmpresa;
        private Telerik.Reporting.TextBox txtProvincia;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox txtTituloTicket;
        private Telerik.Reporting.TextBox txtAgradecimiento;
        public Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        public Telerik.Reporting.PageFooterSection pageFooterSection1;
        public Telerik.Reporting.ReportHeaderSection reportHeaderSection1;
        private Telerik.Reporting.TextBox textBox22;
        private Telerik.Reporting.TextBox textBox24;
        private Telerik.Reporting.TextBox txtCliente;
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox textBox28;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox txtTicket;
        private Telerik.Reporting.TextBox txtDireccion;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox1;
    }
}