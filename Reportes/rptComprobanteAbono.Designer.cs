namespace Reportes
{
    partial class rptComprobanteAbono
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptComprobanteAbono));
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup6 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.pbLogo = new Telerik.Reporting.PictureBox();
            this.txtEmpresa = new Telerik.Reporting.TextBox();
            this.txtDireccion = new Telerik.Reporting.TextBox();
            this.txtProvincia = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.txtAnuncio = new Telerik.Reporting.TextBox();
            this.textBox19 = new Telerik.Reporting.TextBox();
            this.txtAgradecimiento = new Telerik.Reporting.TextBox();
            this.txtCajero = new Telerik.Reporting.TextBox();
            this.reportHeaderSection1 = new Telerik.Reporting.ReportHeaderSection();
            this.tbCobro = new Telerik.Reporting.Table();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.txtAbonado = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.txtSaldo = new Telerik.Reporting.TextBox();
            this.txtMontoTotal = new Telerik.Reporting.TextBox();
            this.textBox20 = new Telerik.Reporting.TextBox();
            this.txtFechaVenta = new Telerik.Reporting.TextBox();
            this.textBox22 = new Telerik.Reporting.TextBox();
            this.textBox24 = new Telerik.Reporting.TextBox();
            this.txtCliente = new Telerik.Reporting.TextBox();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.txtFolio = new Telerik.Reporting.TextBox();
            this.textBox28 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.txtTicket = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.txtRuc = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(3.7D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pbLogo,
            this.txtEmpresa,
            this.txtDireccion,
            this.txtProvincia,
            this.textBox4,
            this.textBox5});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.3D), Telerik.Reporting.Drawing.Unit.Cm(0.1D));
            this.pbLogo.MimeType = "";
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.434D), Telerik.Reporting.Drawing.Unit.Cm(1.2D));
            this.pbLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pbLogo.Style.BackgroundImage.ImageData = ((System.Drawing.Image)(resources.GetObject("pbLogo.Style.BackgroundImage.ImageData")));
            this.pbLogo.Style.BackgroundImage.MimeType = "image/png";
            this.pbLogo.Value = "=Fields.Logo";
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
            this.txtEmpresa.Value = "=Fields.Empresa";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(2D));
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.9D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtDireccion.Style.Font.Bold = false;
            this.txtDireccion.Style.Font.Name = "Segoe UI";
            this.txtDireccion.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtDireccion.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtDireccion.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtDireccion.Value = "=Fields.Direccion1";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(2.4D));
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.9D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtProvincia.Style.Font.Bold = false;
            this.txtProvincia.Style.Font.Name = "Segoe UI";
            this.txtProvincia.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtProvincia.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtProvincia.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtProvincia.Value = "=Fields.Provincia_Departamento";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.7D), Telerik.Reporting.Drawing.Unit.Cm(2.8D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.2D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox4.Style.Font.Bold = false;
            this.textBox4.Style.Font.Name = "Segoe UI";
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.Value = "=Now()";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(3.2D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.911D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox5.Style.Font.Bold = true;
            this.textBox5.Style.Font.Name = "Segoe UI";
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.Value = "COMPROBANTE DE PAGO A CRÉDITO";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.132D);
            this.detail.Name = "detail";
            this.detail.Style.Visible = false;
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1.568D);
            this.pageFooterSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtAnuncio,
            this.textBox19,
            this.txtAgradecimiento,
            this.txtCajero});
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // txtAnuncio
            // 
            this.txtAnuncio.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0.368D));
            this.txtAnuncio.Name = "txtAnuncio";
            this.txtAnuncio.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.911D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtAnuncio.Style.Font.Bold = false;
            this.txtAnuncio.Style.Font.Name = "Segoe UI";
            this.txtAnuncio.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtAnuncio.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtAnuncio.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtAnuncio.Value = "=Fields.Anuncio";
            // 
            // textBox19
            // 
            this.textBox19.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.013D), Telerik.Reporting.Drawing.Unit.Cm(1.068D));
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.911D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox19.Style.Font.Bold = false;
            this.textBox19.Style.Font.Name = "Segoe UI";
            this.textBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox19.Value = "¡Conserve su ticket para el siguiente Abono!";
            // 
            // txtAgradecimiento
            // 
            this.txtAgradecimiento.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.013D), Telerik.Reporting.Drawing.Unit.Cm(0.068D));
            this.txtAgradecimiento.Name = "txtAgradecimiento";
            this.txtAgradecimiento.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.898D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtAgradecimiento.Style.Font.Bold = false;
            this.txtAgradecimiento.Style.Font.Name = "Segoe UI";
            this.txtAgradecimiento.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtAgradecimiento.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtAgradecimiento.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtAgradecimiento.Value = "=Fields.Agradecimiento";
            // 
            // txtCajero
            // 
            this.txtCajero.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.2D), Telerik.Reporting.Drawing.Unit.Cm(0.668D));
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.535D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtCajero.Style.Font.Bold = false;
            this.txtCajero.Style.Font.Name = "Segoe UI";
            this.txtCajero.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtCajero.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtCajero.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtCajero.Value = "= \'Lo atendió : \'+Fields.Usuario";
            // 
            // reportHeaderSection1
            // 
            this.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(3.9D);
            this.reportHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.tbCobro,
            this.textBox20,
            this.txtFechaVenta,
            this.textBox22,
            this.textBox24,
            this.txtCliente,
            this.textBox16,
            this.txtFolio,
            this.textBox28,
            this.textBox9,
            this.txtTicket,
            this.textBox1,
            this.txtRuc});
            this.reportHeaderSection1.Name = "reportHeaderSection1";
            // 
            // tbCobro
            // 
            this.tbCobro.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(4.034D)));
            this.tbCobro.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.765D)));
            this.tbCobro.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.41D)));
            this.tbCobro.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.434D)));
            this.tbCobro.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.407D)));
            this.tbCobro.Body.SetCellContent(0, 0, this.textBox6);
            this.tbCobro.Body.SetCellContent(1, 0, this.textBox12);
            this.tbCobro.Body.SetCellContent(1, 1, this.txtAbonado);
            this.tbCobro.Body.SetCellContent(2, 0, this.textBox17);
            this.tbCobro.Body.SetCellContent(2, 1, this.txtSaldo);
            this.tbCobro.Body.SetCellContent(0, 1, this.txtMontoTotal);
            tableGroup1.Name = "tableGroup";
            tableGroup2.Name = "tableGroup1";
            this.tbCobro.ColumnGroups.Add(tableGroup1);
            this.tbCobro.ColumnGroups.Add(tableGroup2);
            this.tbCobro.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox6,
            this.txtMontoTotal,
            this.textBox12,
            this.txtAbonado,
            this.textBox17,
            this.txtSaldo});
            this.tbCobro.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.6D), Telerik.Reporting.Drawing.Unit.Cm(2.2D));
            this.tbCobro.Name = "tbCobro";
            tableGroup4.Name = "group1";
            tableGroup5.Name = "group3";
            tableGroup6.Name = "group";
            tableGroup3.ChildGroups.Add(tableGroup4);
            tableGroup3.ChildGroups.Add(tableGroup5);
            tableGroup3.ChildGroups.Add(tableGroup6);
            tableGroup3.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup3.Name = "detailTableGroup";
            this.tbCobro.RowGroups.Add(tableGroup3);
            this.tbCobro.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.799D), Telerik.Reporting.Drawing.Unit.Cm(1.251D));
            this.tbCobro.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.tbCobro.Style.Font.Name = "Courier New";
            this.tbCobro.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            // 
            // textBox6
            // 
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.034D), Telerik.Reporting.Drawing.Unit.Cm(0.41D));
            this.textBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox6.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox6.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox6.Style.Font.Name = "Segoe UI";
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox6.StyleName = "";
            this.textBox6.Value = "Total Venta :";
            // 
            // textBox12
            // 
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.034D), Telerik.Reporting.Drawing.Unit.Cm(0.434D));
            this.textBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox12.Style.Font.Name = "Segoe UI";
            this.textBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox12.StyleName = "";
            this.textBox12.Value = "Monto abonado :";
            // 
            // txtAbonado
            // 
            this.txtAbonado.Format = "{0:C2}";
            this.txtAbonado.Name = "txtAbonado";
            this.txtAbonado.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.765D), Telerik.Reporting.Drawing.Unit.Cm(0.434D));
            this.txtAbonado.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.txtAbonado.Style.Font.Bold = true;
            this.txtAbonado.Style.Font.Name = "Segoe UI";
            this.txtAbonado.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtAbonado.StyleName = "";
            this.txtAbonado.Value = "=Fields.Abonado";
            // 
            // textBox17
            // 
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.034D), Telerik.Reporting.Drawing.Unit.Cm(0.407D));
            this.textBox17.Style.Font.Name = "Segoe UI";
            this.textBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox17.StyleName = "";
            this.textBox17.Value = "Saldo por liquidar :";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Format = "{0:C2}";
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.765D), Telerik.Reporting.Drawing.Unit.Cm(0.407D));
            this.txtSaldo.Style.Font.Bold = true;
            this.txtSaldo.Style.Font.Name = "Segoe UI";
            this.txtSaldo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtSaldo.StyleName = "";
            this.txtSaldo.Value = "=Fields.Saldo";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Format = "{0:C2}";
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.765D), Telerik.Reporting.Drawing.Unit.Cm(0.41D));
            this.txtMontoTotal.Style.Font.Bold = true;
            this.txtMontoTotal.Style.Font.Name = "Segoe UI";
            this.txtMontoTotal.StyleName = "";
            this.txtMontoTotal.Value = "=Fields.Monto_Total";
            // 
            // textBox20
            // 
            this.textBox20.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.2D), Telerik.Reporting.Drawing.Unit.Cm(1.7D));
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox20.Style.Font.Bold = false;
            this.textBox20.Style.Font.Italic = false;
            this.textBox20.Style.Font.Name = "Segoe UI";
            this.textBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox20.Value = "Fecha Venta :";
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(1.7D));
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtFechaVenta.Style.Font.Bold = false;
            this.txtFechaVenta.Style.Font.Name = "Segoe UI";
            this.txtFechaVenta.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtFechaVenta.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtFechaVenta.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtFechaVenta.Value = "=Fields.Fecha_Venta";
            // 
            // textBox22
            // 
            this.textBox22.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(3.7D));
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.911D), Telerik.Reporting.Drawing.Unit.Cm(0.05D));
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
            this.textBox24.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.911D), Telerik.Reporting.Drawing.Unit.Cm(0.05D));
            this.textBox24.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
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
            this.txtCliente.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(1.1D));
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtCliente.Style.Font.Bold = false;
            this.txtCliente.Style.Font.Name = "Segoe UI";
            this.txtCliente.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtCliente.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtCliente.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtCliente.Value = "=Fields.Cliente";
            // 
            // textBox16
            // 
            this.textBox16.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.2D), Telerik.Reporting.Drawing.Unit.Cm(1.1D));
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox16.Style.Font.Bold = false;
            this.textBox16.Style.Font.Name = "Segoe UI";
            this.textBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox16.Value = "Cliente :";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7D), Telerik.Reporting.Drawing.Unit.Cm(0.1D));
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.211D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtFolio.Style.Font.Bold = false;
            this.txtFolio.Style.Font.Name = "Segoe UI";
            this.txtFolio.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtFolio.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtFolio.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtFolio.Value = "=Fields.Folio";
            // 
            // textBox28
            // 
            this.textBox28.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.8D), Telerik.Reporting.Drawing.Unit.Cm(0.1D));
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox28.Style.Font.Bold = true;
            this.textBox28.Style.Font.Italic = false;
            this.textBox28.Style.Font.Name = "Segoe UI";
            this.textBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox28.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox28.Value = "Folio N°:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.8D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox9.Style.Font.Bold = true;
            this.textBox9.Style.Font.Italic = false;
            this.textBox9.Style.Font.Name = "Segoe UI";
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox9.Value = "Ticket N°:";
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.211D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtTicket.Style.Font.Bold = false;
            this.txtTicket.Style.Font.Name = "Segoe UI";
            this.txtTicket.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtTicket.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtTicket.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtTicket.Value = "=Fields.Ticket";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.2D), Telerik.Reporting.Drawing.Unit.Cm(1.4D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox1.Style.Font.Bold = false;
            this.textBox1.Style.Font.Name = "Segoe UI";
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "N° Cliente:";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(1.4D));
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.txtRuc.Style.Font.Bold = false;
            this.txtRuc.Style.Font.Name = "Segoe UI";
            this.txtRuc.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtRuc.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtRuc.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtRuc.Value = "=Fields.Ruc";
            // 
            // rptComprobanteAbono
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
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(7.924D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PictureBox pbLogo;
        private Telerik.Reporting.TextBox txtEmpresa;
        private Telerik.Reporting.TextBox txtDireccion;
        private Telerik.Reporting.TextBox txtProvincia;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox txtAbonado;
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox txtCliente;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox txtSaldo;
        private Telerik.Reporting.TextBox txtCajero;
        private Telerik.Reporting.TextBox txtAnuncio;
        private Telerik.Reporting.TextBox textBox19;
        private Telerik.Reporting.TextBox txtAgradecimiento;
        public Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        public Telerik.Reporting.ReportHeaderSection reportHeaderSection1;
        public Telerik.Reporting.Table tbCobro;
        public Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.TextBox textBox20;
        private Telerik.Reporting.TextBox txtFechaVenta;
        private Telerik.Reporting.TextBox textBox22;
        private Telerik.Reporting.TextBox textBox24;
        private Telerik.Reporting.TextBox txtFolio;
        private Telerik.Reporting.TextBox textBox28;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox txtTicket;
        private Telerik.Reporting.TextBox txtMontoTotal;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox txtRuc;
    }
}