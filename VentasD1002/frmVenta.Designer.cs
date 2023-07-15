namespace VentasD1002
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnMenudeo = new System.Windows.Forms.RadioButton();
            this.rbtnMayoreo = new System.Windows.Forms.RadioButton();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pbpLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbPerfil = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.linkPerfil = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridVentas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venta_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVenta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProductoDevuelto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsaInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSaldoDisponible = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalArticulos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel30 = new System.Windows.Forms.Panel();
            this.menuStrip8 = new System.Windows.Forms.MenuStrip();
            this.enEsperaF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.cancelarVentaF9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cobrarF10 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkNota = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.gridBuscar = new System.Windows.Forms.DataGridView();
            this.gdvClientes = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.menuEspera = new System.Windows.Forms.MenuStrip();
            this.ventasEnEsperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpLogoEmpresa)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel29.SuspendLayout();
            this.menuStrip8.SuspendLayout();
            this.menuStrip6.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvClientes)).BeginInit();
            this.menuEspera.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.rbtnMenudeo);
            this.panel1.Controls.Add(this.rbtnMayoreo);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.pbpLogoEmpresa);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboFormaPago);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 97);
            this.panel1.TabIndex = 0;
            // 
            // rbtnMenudeo
            // 
            this.rbtnMenudeo.AutoSize = true;
            this.rbtnMenudeo.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMenudeo.Location = new System.Drawing.Point(198, 34);
            this.rbtnMenudeo.Name = "rbtnMenudeo";
            this.rbtnMenudeo.Size = new System.Drawing.Size(93, 24);
            this.rbtnMenudeo.TabIndex = 2;
            this.rbtnMenudeo.Text = "Menudeo";
            this.rbtnMenudeo.UseVisualStyleBackColor = true;
            // 
            // rbtnMayoreo
            // 
            this.rbtnMayoreo.AutoSize = true;
            this.rbtnMayoreo.Checked = true;
            this.rbtnMayoreo.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMayoreo.Location = new System.Drawing.Point(97, 34);
            this.rbtnMayoreo.Name = "rbtnMayoreo";
            this.rbtnMayoreo.Size = new System.Drawing.Size(87, 24);
            this.rbtnMayoreo.TabIndex = 1;
            this.rbtnMayoreo.TabStop = true;
            this.rbtnMayoreo.Text = "Mayoreo";
            this.rbtnMayoreo.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(930, 35);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(33, 29);
            this.btnClientes.TabIndex = 6;
            this.btnClientes.Tag = "CLIENTE";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbpLogoEmpresa
            // 
            this.pbpLogoEmpresa.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbpLogoEmpresa.Image = global::VentasD1002.Properties.Resources.JIEL;
            this.pbpLogoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.pbpLogoEmpresa.Name = "pbpLogoEmpresa";
            this.pbpLogoEmpresa.Size = new System.Drawing.Size(91, 97);
            this.pbpLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbpLogoEmpresa.TabIndex = 20;
            this.pbpLogoEmpresa.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbPerfil);
            this.panel3.Controls.Add(this.linkPerfil);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(972, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 97);
            this.panel3.TabIndex = 20;
            // 
            // pbPerfil
            // 
            this.pbPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbPerfil.BorderColor = System.Drawing.Color.Lime;
            this.pbPerfil.BorderColor2 = System.Drawing.Color.SeaGreen;
            this.pbPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbPerfil.BorderSize = 2;
            this.pbPerfil.GradientAngle = 50F;
            this.pbPerfil.Location = new System.Drawing.Point(29, 0);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(66, 66);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 1;
            this.pbPerfil.TabStop = false;
            // 
            // linkPerfil
            // 
            this.linkPerfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkPerfil.Location = new System.Drawing.Point(0, 76);
            this.linkPerfil.Name = "linkPerfil";
            this.linkPerfil.Size = new System.Drawing.Size(134, 21);
            this.linkPerfil.TabIndex = 0;
            this.linkPerfil.TabStop = true;
            this.linkPerfil.Text = "linkLabel1";
            this.linkPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPerfil_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cliente:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.Location = new System.Drawing.Point(509, 61);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(413, 3);
            this.panel8.TabIndex = 18;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCliente.Location = new System.Drawing.Point(509, 39);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(413, 19);
            this.txtCliente.TabIndex = 4;
            this.txtCliente.Text = "GENERAL";
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Forma de pago:";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.ItemHeight = 19;
            this.cboFormaPago.Location = new System.Drawing.Point(311, 39);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(165, 27);
            this.cboFormaPago.TabIndex = 3;
            this.cboFormaPago.SelectionChangeCommitted += new System.EventHandler(this.cboFormaPago_SelectionChangeCommitted);
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel24.Location = new System.Drawing.Point(198, 148);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(561, 3);
            this.panel24.TabIndex = 16;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(282, 120);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(473, 20);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // gridVentas
            // 
            this.gridVentas.AllowUserToAddRows = false;
            this.gridVentas.AllowUserToResizeColumns = false;
            this.gridVentas.AllowUserToResizeRows = false;
            this.gridVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Venta_Id,
            this.Producto_Id,
            this.Cant,
            this.Unid,
            this.Articulo,
            this.Unitario,
            this.Precio,
            this.Importe,
            this.TipoVenta,
            this.ProductoDevuelto,
            this.UsaInventario,
            this.Codigo});
            this.gridVentas.Location = new System.Drawing.Point(136, 155);
            this.gridVentas.MultiSelect = false;
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.RowHeadersVisible = false;
            this.gridVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVentas.Size = new System.Drawing.Size(748, 312);
            this.gridVentas.TabIndex = 19;
            this.gridVentas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVentas_CellEndEdit);
            this.gridVentas.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridVentas_CellMouseUp);
            this.gridVentas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridVentas_RowsAdded);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Venta_Id
            // 
            this.Venta_Id.DataPropertyName = "IdVenta";
            this.Venta_Id.Frozen = true;
            this.Venta_Id.HeaderText = "IdVenta";
            this.Venta_Id.Name = "Venta_Id";
            // 
            // Producto_Id
            // 
            this.Producto_Id.DataPropertyName = "IdProducto";
            this.Producto_Id.Frozen = true;
            this.Producto_Id.HeaderText = "IdProducto";
            this.Producto_Id.Name = "Producto_Id";
            // 
            // Cant
            // 
            this.Cant.DataPropertyName = "Cantidad";
            this.Cant.Frozen = true;
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            // 
            // Unid
            // 
            this.Unid.DataPropertyName = "UnidadMedida";
            this.Unid.Frozen = true;
            this.Unid.HeaderText = "Unidad";
            this.Unid.Name = "Unid";
            // 
            // Articulo
            // 
            this.Articulo.DataPropertyName = "Descripcion";
            this.Articulo.Frozen = true;
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            // 
            // Unitario
            // 
            this.Unitario.DataPropertyName = "PrecioUnitario";
            this.Unitario.Frozen = true;
            this.Unitario.HeaderText = "Unitario";
            this.Unitario.Name = "Unitario";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.Frozen = true;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            this.Importe.Frozen = true;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // TipoVenta
            // 
            this.TipoVenta.DataPropertyName = "TipoVenta";
            this.TipoVenta.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TipoVenta.Frozen = true;
            this.TipoVenta.HeaderText = "TipoVenta";
            this.TipoVenta.Name = "TipoVenta";
            this.TipoVenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProductoDevuelto
            // 
            this.ProductoDevuelto.DataPropertyName = "EsDevuelto";
            this.ProductoDevuelto.Frozen = true;
            this.ProductoDevuelto.HeaderText = "ProductoDevuelto";
            this.ProductoDevuelto.Name = "ProductoDevuelto";
            // 
            // UsaInventario
            // 
            this.UsaInventario.DataPropertyName = "UsaInventario";
            this.UsaInventario.Frozen = true;
            this.UsaInventario.HeaderText = "UsaInventario";
            this.UsaInventario.Name = "UsaInventario";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSaldoDisponible);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblTotalArticulos);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 485);
            this.panel2.TabIndex = 21;
            // 
            // lblSaldoDisponible
            // 
            this.lblSaldoDisponible.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoDisponible.Location = new System.Drawing.Point(3, 167);
            this.lblSaldoDisponible.Name = "lblSaldoDisponible";
            this.lblSaldoDisponible.Size = new System.Drawing.Size(105, 33);
            this.lblSaldoDisponible.TabIndex = 25;
            this.lblSaldoDisponible.Text = "0.0";
            this.lblSaldoDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Saldo Disponible:";
            // 
            // lblTotalArticulos
            // 
            this.lblTotalArticulos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalArticulos.Location = new System.Drawing.Point(3, 102);
            this.lblTotalArticulos.Name = "lblTotalArticulos";
            this.lblTotalArticulos.Size = new System.Drawing.Size(105, 33);
            this.lblTotalArticulos.TabIndex = 23;
            this.lblTotalArticulos.Text = "0";
            this.lblTotalArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total artículos:";
            // 
            // panel29
            // 
            this.panel29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel29.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel29.BackgroundImage")));
            this.panel29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel29.Controls.Add(this.lblTotal);
            this.panel29.Controls.Add(this.panel30);
            this.panel29.Location = new System.Drawing.Point(491, 468);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(395, 54);
            this.panel29.TabIndex = 22;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(202, 6);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 39);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0.00";
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.Transparent;
            this.panel30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel30.BackgroundImage")));
            this.panel30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel30.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel30.Location = new System.Drawing.Point(21, -6);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(175, 74);
            this.panel30.TabIndex = 0;
            // 
            // menuStrip8
            // 
            this.menuStrip8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip8.AutoSize = false;
            this.menuStrip8.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip8.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enEsperaF8ToolStripMenuItem});
            this.menuStrip8.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip8.Location = new System.Drawing.Point(901, 270);
            this.menuStrip8.Name = "menuStrip8";
            this.menuStrip8.ShowItemToolTips = true;
            this.menuStrip8.Size = new System.Drawing.Size(180, 56);
            this.menuStrip8.TabIndex = 630;
            this.menuStrip8.Text = "menuStrip8";
            // 
            // enEsperaF8ToolStripMenuItem
            // 
            this.enEsperaF8ToolStripMenuItem.BackgroundImage = global::VentasD1002.Properties.Resources.naranja;
            this.enEsperaF8ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enEsperaF8ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.enEsperaF8ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enEsperaF8ToolStripMenuItem.Image")));
            this.enEsperaF8ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enEsperaF8ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.enEsperaF8ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.enEsperaF8ToolStripMenuItem.Name = "enEsperaF8ToolStripMenuItem";
            this.enEsperaF8ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.enEsperaF8ToolStripMenuItem.Size = new System.Drawing.Size(171, 52);
            this.enEsperaF8ToolStripMenuItem.Text = "Pendiente (F8)";
            this.enEsperaF8ToolStripMenuItem.Click += new System.EventHandler(this.enEsperaF8ToolStripMenuItem_Click);
            this.enEsperaF8ToolStripMenuItem.MouseLeave += new System.EventHandler(this.enEsperaF8ToolStripMenuItem_MouseLeave);
            this.enEsperaF8ToolStripMenuItem.MouseHover += new System.EventHandler(this.enEsperaF8ToolStripMenuItem_MouseHover);
            // 
            // menuStrip6
            // 
            this.menuStrip6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip6.AutoSize = false;
            this.menuStrip6.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip6.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarVentaF9ToolStripMenuItem});
            this.menuStrip6.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip6.Location = new System.Drawing.Point(907, 210);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.ShowItemToolTips = true;
            this.menuStrip6.Size = new System.Drawing.Size(190, 56);
            this.menuStrip6.TabIndex = 629;
            this.menuStrip6.Text = "menuStrip6";
            // 
            // cancelarVentaF9ToolStripMenuItem
            // 
            this.cancelarVentaF9ToolStripMenuItem.BackgroundImage = global::VentasD1002.Properties.Resources.Rojo;
            this.cancelarVentaF9ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelarVentaF9ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.cancelarVentaF9ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelarVentaF9ToolStripMenuItem.Image")));
            this.cancelarVentaF9ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelarVentaF9ToolStripMenuItem.Name = "cancelarVentaF9ToolStripMenuItem";
            this.cancelarVentaF9ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.cancelarVentaF9ToolStripMenuItem.Size = new System.Drawing.Size(158, 52);
            this.cancelarVentaF9ToolStripMenuItem.Text = "Cancelar (F9)";
            this.cancelarVentaF9ToolStripMenuItem.Click += new System.EventHandler(this.cancelarVentaF9ToolStripMenuItem_Click);
            this.cancelarVentaF9ToolStripMenuItem.MouseLeave += new System.EventHandler(this.enEsperaF8ToolStripMenuItem_MouseLeave);
            this.cancelarVentaF9ToolStripMenuItem.MouseHover += new System.EventHandler(this.enEsperaF8ToolStripMenuItem_MouseHover);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobrarF10});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(905, 150);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.ShowItemToolTips = true;
            this.menuStrip2.Size = new System.Drawing.Size(180, 56);
            this.menuStrip2.TabIndex = 628;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cobrarF10
            // 
            this.cobrarF10.BackgroundImage = global::VentasD1002.Properties.Resources.verde;
            this.cobrarF10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cobrarF10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobrarF10.Image = ((System.Drawing.Image)(resources.GetObject("cobrarF10.Image")));
            this.cobrarF10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cobrarF10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cobrarF10.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.cobrarF10.Name = "cobrarF10";
            this.cobrarF10.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.cobrarF10.Size = new System.Drawing.Size(161, 52);
            this.cobrarF10.Text = "Cobrar  (F10)";
            this.cobrarF10.Click += new System.EventHandler(this.cobrarF10_Click);
            this.cobrarF10.MouseLeave += new System.EventHandler(this.enEsperaF8ToolStripMenuItem_MouseLeave);
            this.cobrarF10.MouseHover += new System.EventHandler(this.enEsperaF8ToolStripMenuItem_MouseHover);
            // 
            // checkNota
            // 
            this.checkNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkNota.BackColor = System.Drawing.Color.Transparent;
            this.checkNota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkNota.BackgroundImage")));
            this.checkNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkNota.Location = new System.Drawing.Point(910, 336);
            this.checkNota.Name = "checkNota";
            this.checkNota.OffColor = System.Drawing.Color.Gray;
            this.checkNota.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.checkNota.Size = new System.Drawing.Size(35, 20);
            this.checkNota.TabIndex = 631;
            this.checkNota.Value = false;
            this.checkNota.OnValueChange += new System.EventHandler(this.checkNota_OnValueChange);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(950, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nota:";
            // 
            // txtNota
            // 
            this.txtNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNota.BackColor = System.Drawing.SystemColors.Info;
            this.txtNota.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(912, 362);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(174, 138);
            this.txtNota.TabIndex = 2;
            // 
            // gridBuscar
            // 
            this.gridBuscar.AllowUserToAddRows = false;
            this.gridBuscar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBuscar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.gridBuscar.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.gridBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBuscar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuscar.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBuscar.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridBuscar.Location = new System.Drawing.Point(198, 153);
            this.gridBuscar.MultiSelect = false;
            this.gridBuscar.Name = "gridBuscar";
            this.gridBuscar.ReadOnly = true;
            this.gridBuscar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridBuscar.RowHeadersVisible = false;
            this.gridBuscar.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBuscar.Size = new System.Drawing.Size(561, 285);
            this.gridBuscar.TabIndex = 9;
            this.gridBuscar.Visible = false;
            this.gridBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBuscar_CellClick);
            this.gridBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridBuscar_KeyDown);
            // 
            // gdvClientes
            // 
            this.gdvClientes.AllowUserToAddRows = false;
            this.gdvClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gdvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvClientes.ColumnHeadersVisible = false;
            this.gdvClientes.GridColor = System.Drawing.SystemColors.Control;
            this.gdvClientes.Location = new System.Drawing.Point(508, 66);
            this.gdvClientes.MultiSelect = false;
            this.gdvClientes.Name = "gdvClientes";
            this.gdvClientes.ReadOnly = true;
            this.gdvClientes.RowHeadersVisible = false;
            this.gdvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvClientes.Size = new System.Drawing.Size(414, 264);
            this.gdvClientes.TabIndex = 5;
            this.gdvClientes.Visible = false;
            this.gdvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvClientes_CellClick);
            this.gdvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvClientes_CellContentClick);
            this.gdvClientes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gdvClientes_DataBindingComplete);
            this.gdvClientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gdvClientes_KeyDown);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.Location = new System.Drawing.Point(198, 111);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(78, 29);
            this.txtCantidad.TabIndex = 632;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress_1);
            // 
            // menuEspera
            // 
            this.menuEspera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuEspera.AutoSize = false;
            this.menuEspera.Dock = System.Windows.Forms.DockStyle.None;
            this.menuEspera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasEnEsperaToolStripMenuItem});
            this.menuEspera.Location = new System.Drawing.Point(136, 474);
            this.menuEspera.Name = "menuEspera";
            this.menuEspera.Size = new System.Drawing.Size(169, 41);
            this.menuEspera.TabIndex = 633;
            this.menuEspera.Text = "menuStrip1";
            // 
            // ventasEnEsperaToolStripMenuItem
            // 
            this.ventasEnEsperaToolStripMenuItem.Name = "ventasEnEsperaToolStripMenuItem";
            this.ventasEnEsperaToolStripMenuItem.Size = new System.Drawing.Size(106, 37);
            this.ventasEnEsperaToolStripMenuItem.Text = "Ventas en espera";
            this.ventasEnEsperaToolStripMenuItem.Click += new System.EventHandler(this.ventasEnEsperaToolStripMenuItem_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1106, 582);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.gdvClientes);
            this.Controls.Add(this.gridBuscar);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkNota);
            this.Controls.Add(this.menuStrip8);
            this.Controls.Add(this.menuStrip6);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuEspera);
            this.Controls.Add(this.panel29);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridVentas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel24);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuEspera;
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpLogoEmpresa)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.menuStrip8.ResumeLayout(false);
            this.menuStrip8.PerformLayout();
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvClientes)).EndInit();
            this.menuEspera.ResumeLayout(false);
            this.menuEspera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gridVentas;
        private System.Windows.Forms.PictureBox pbpLogoEmpresa;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbPerfil;
        private System.Windows.Forms.LinkLabel linkPerfil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalArticulos;
        private System.Windows.Forms.Label lblSaldoDisponible;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel30;
        internal System.Windows.Forms.MenuStrip menuStrip8;
        private System.Windows.Forms.ToolStripMenuItem enEsperaF8ToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip menuStrip6;
        private System.Windows.Forms.ToolStripMenuItem cancelarVentaF9ToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cobrarF10;
        private Bunifu.Framework.UI.BunifuiOSSwitch checkNota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.DataGridView gridBuscar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.DataGridView gdvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoDevuelto;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsaInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.RadioButton rbtnMenudeo;
        private System.Windows.Forms.RadioButton rbtnMayoreo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.MenuStrip menuEspera;
        private System.Windows.Forms.ToolStripMenuItem ventasEnEsperaToolStripMenuItem;
    }
}