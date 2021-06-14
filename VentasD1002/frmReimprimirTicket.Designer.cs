namespace VentasD1002
{
    partial class frmReimprimirTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReimprimirTicket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnFiltroFechas = new System.Windows.Forms.RadioButton();
            this.rbtnFiltroCliente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdVenta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdvListado = new System.Windows.Forms.DataGridView();
            this.Detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbA4 = new System.Windows.Forms.RadioButton();
            this.RbtnMod2 = new System.Windows.Forms.RadioButton();
            this.pnlBuscarPorCLiente = new System.Windows.Forms.Panel();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnBonificacion = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEditarPago = new System.Windows.Forms.Button();
            this.pnlEditarPago = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.cancelarVentaF9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cobrarF10 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvListado)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlBuscarPorCLiente.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlEditarPago.SuspendLayout();
            this.panel8.SuspendLayout();
            this.menuStrip6.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnFiltroFechas);
            this.panel1.Controls.Add(this.rbtnFiltroCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblIdVenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 54);
            this.panel1.TabIndex = 0;
            // 
            // rbnFiltroFechas
            // 
            this.rbnFiltroFechas.AutoSize = true;
            this.rbnFiltroFechas.Checked = true;
            this.rbnFiltroFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnFiltroFechas.Location = new System.Drawing.Point(4, 31);
            this.rbnFiltroFechas.Name = "rbnFiltroFechas";
            this.rbnFiltroFechas.Size = new System.Drawing.Size(161, 24);
            this.rbnFiltroFechas.TabIndex = 14;
            this.rbnFiltroFechas.TabStop = true;
            this.rbnFiltroFechas.Text = "Buscar por Fechas";
            this.rbnFiltroFechas.UseVisualStyleBackColor = true;
            // 
            // rbtnFiltroCliente
            // 
            this.rbtnFiltroCliente.AutoSize = true;
            this.rbtnFiltroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltroCliente.Location = new System.Drawing.Point(188, 31);
            this.rbtnFiltroCliente.Name = "rbtnFiltroCliente";
            this.rbtnFiltroCliente.Size = new System.Drawing.Size(154, 24);
            this.rbtnFiltroCliente.TabIndex = 13;
            this.rbtnFiltroCliente.Text = "Buscar por cliente";
            this.rbtnFiltroCliente.UseVisualStyleBackColor = true;
            this.rbtnFiltroCliente.CheckedChanged += new System.EventHandler(this.rbtnFiltroCliente_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1132, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Tickets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdVenta
            // 
            this.lblIdVenta.AutoSize = true;
            this.lblIdVenta.Location = new System.Drawing.Point(498, 9);
            this.lblIdVenta.Name = "lblIdVenta";
            this.lblIdVenta.Size = new System.Drawing.Size(35, 13);
            this.lblIdVenta.TabIndex = 15;
            this.lblIdVenta.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlEditarPago);
            this.panel2.Controls.Add(this.gdvListado);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 481);
            this.panel2.TabIndex = 1;
            // 
            // gdvListado
            // 
            this.gdvListado.AllowUserToAddRows = false;
            this.gdvListado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gdvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalle});
            this.gdvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvListado.Location = new System.Drawing.Point(0, 57);
            this.gdvListado.Name = "gdvListado";
            this.gdvListado.RowHeadersVisible = false;
            this.gdvListado.RowTemplate.ReadOnly = true;
            this.gdvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvListado.Size = new System.Drawing.Size(651, 424);
            this.gdvListado.TabIndex = 10;
            this.gdvListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvListado_CellClick);
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Detalle.Image")));
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.ToolTipText = "Ver detalle";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbA4);
            this.panel4.Controls.Add(this.RbtnMod2);
            this.panel4.Controls.Add(this.pnlBuscarPorCLiente);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dtpFin);
            this.panel4.Controls.Add(this.dtpInicio);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(651, 57);
            this.panel4.TabIndex = 10;
            // 
            // rbA4
            // 
            this.rbA4.AutoSize = true;
            this.rbA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbA4.Location = new System.Drawing.Point(501, 14);
            this.rbA4.Name = "rbA4";
            this.rbA4.Size = new System.Drawing.Size(55, 24);
            this.rbA4.TabIndex = 13;
            this.rbA4.Text = "A-4";
            this.rbA4.UseVisualStyleBackColor = true;
            // 
            // RbtnMod2
            // 
            this.RbtnMod2.AutoSize = true;
            this.RbtnMod2.Checked = true;
            this.RbtnMod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnMod2.Location = new System.Drawing.Point(405, 14);
            this.RbtnMod2.Name = "RbtnMod2";
            this.RbtnMod2.Size = new System.Drawing.Size(90, 24);
            this.RbtnMod2.TabIndex = 15;
            this.RbtnMod2.TabStop = true;
            this.RbtnMod2.Text = "Ticket 2";
            this.RbtnMod2.UseVisualStyleBackColor = true;
            // 
            // pnlBuscarPorCLiente
            // 
            this.pnlBuscarPorCLiente.Controls.Add(this.txtBuscarCliente);
            this.pnlBuscarPorCLiente.Location = new System.Drawing.Point(4, 0);
            this.pnlBuscarPorCLiente.Name = "pnlBuscarPorCLiente";
            this.pnlBuscarPorCLiente.Size = new System.Drawing.Size(378, 54);
            this.pnlBuscarPorCLiente.TabIndex = 14;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(21, 14);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(341, 26);
            this.txtBuscarCliente.TabIndex = 0;
            this.txtBuscarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarCliente_MouseClick);
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            this.txtBuscarCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarCliente_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Inicio:";
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(240, 18);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(113, 24);
            this.dtpFin.TabIndex = 9;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(63, 18);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(113, 24);
            this.dtpInicio.TabIndex = 8;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fin:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(651, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 481);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.reportViewer1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(481, 424);
            this.panel6.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(481, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(481, 57);
            this.panel5.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnEditarPago);
            this.panel7.Controls.Add(this.btnBonificacion);
            this.panel7.Controls.Add(this.btnImprimir);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(481, 57);
            this.panel7.TabIndex = 0;
            // 
            // btnBonificacion
            // 
            this.btnBonificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBonificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBonificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnBonificacion.Image")));
            this.btnBonificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBonificacion.Location = new System.Drawing.Point(184, 14);
            this.btnBonificacion.Name = "btnBonificacion";
            this.btnBonificacion.Size = new System.Drawing.Size(159, 32);
            this.btnBonificacion.TabIndex = 18;
            this.btnBonificacion.Text = "Bonificación";
            this.btnBonificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBonificacion.UseVisualStyleBackColor = true;
            this.btnBonificacion.Click += new System.EventHandler(this.btnBonificacion_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(353, 14);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 32);
            this.btnImprimir.TabIndex = 17;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Detalle";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.ToolTipText = "Ver detalle";
            // 
            // btnEditarPago
            // 
            this.btnEditarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPago.Image")));
            this.btnEditarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPago.Location = new System.Drawing.Point(31, 14);
            this.btnEditarPago.Name = "btnEditarPago";
            this.btnEditarPago.Size = new System.Drawing.Size(143, 32);
            this.btnEditarPago.TabIndex = 19;
            this.btnEditarPago.Text = "Editar pago";
            this.btnEditarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPago.UseVisualStyleBackColor = true;
            this.btnEditarPago.Click += new System.EventHandler(this.btnEditarPago_Click);
            // 
            // pnlEditarPago
            // 
            this.pnlEditarPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlEditarPago.Controls.Add(this.lblMontoTotal);
            this.pnlEditarPago.Controls.Add(this.menuStrip6);
            this.pnlEditarPago.Controls.Add(this.menuStrip2);
            this.pnlEditarPago.Controls.Add(this.label4);
            this.pnlEditarPago.Controls.Add(this.label3);
            this.pnlEditarPago.Controls.Add(this.panel8);
            this.pnlEditarPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditarPago.Location = new System.Drawing.Point(0, 57);
            this.pnlEditarPago.Name = "pnlEditarPago";
            this.pnlEditarPago.Size = new System.Drawing.Size(651, 424);
            this.pnlEditarPago.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gold;
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(651, 40);
            this.panel8.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(651, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Editar Ticket";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(609, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Está a punto de realizar el cambio de la forma de pago (contado a crédito).";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(163, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "¿Desea continuar?";
            // 
            // menuStrip6
            // 
            this.menuStrip6.AutoSize = false;
            this.menuStrip6.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip6.BackgroundImage = global::VentasD1002.Resources.resources.Rojo;
            this.menuStrip6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip6.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarVentaF9ToolStripMenuItem});
            this.menuStrip6.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip6.Location = new System.Drawing.Point(125, 215);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.ShowItemToolTips = true;
            this.menuStrip6.Size = new System.Drawing.Size(152, 44);
            this.menuStrip6.TabIndex = 628;
            this.menuStrip6.Text = "menuStrip6";
            // 
            // cancelarVentaF9ToolStripMenuItem
            // 
            this.cancelarVentaF9ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.cancelarVentaF9ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelarVentaF9ToolStripMenuItem.Image")));
            this.cancelarVentaF9ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelarVentaF9ToolStripMenuItem.Name = "cancelarVentaF9ToolStripMenuItem";
            this.cancelarVentaF9ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.cancelarVentaF9ToolStripMenuItem.Size = new System.Drawing.Size(129, 40);
            this.cancelarVentaF9ToolStripMenuItem.Text = "Cancelar";
            this.cancelarVentaF9ToolStripMenuItem.Click += new System.EventHandler(this.cancelarVentaF9ToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.BackgroundImage = global::VentasD1002.Resources.resources.verde;
            this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobrarF10});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(326, 215);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.ShowItemToolTips = true;
            this.menuStrip2.Size = new System.Drawing.Size(156, 45);
            this.menuStrip2.TabIndex = 627;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cobrarF10
            // 
            this.cobrarF10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.cobrarF10.Image = ((System.Drawing.Image)(resources.GetObject("cobrarF10.Image")));
            this.cobrarF10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cobrarF10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cobrarF10.Name = "cobrarF10";
            this.cobrarF10.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.cobrarF10.Size = new System.Drawing.Size(140, 41);
            this.cobrarF10.Text = "Continuar";
            this.cobrarF10.Click += new System.EventHandler(this.cobrarF10_Click);
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(280, 283);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(44, 20);
            this.lblMontoTotal.TabIndex = 629;
            this.lblMontoTotal.Text = "0.00";
            // 
            // frmReimprimirTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 535);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReimprimirTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reimpresión de ticket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReimprimirTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvListado)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlBuscarPorCLiente.ResumeLayout(false);
            this.pnlBuscarPorCLiente.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnlEditarPago.ResumeLayout(false);
            this.pnlEditarPago.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DataGridView gdvListado;
        private System.Windows.Forms.DataGridViewImageColumn Detalle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton rbA4;
        private System.Windows.Forms.RadioButton rbnFiltroFechas;
        private System.Windows.Forms.RadioButton rbtnFiltroCliente;
        private System.Windows.Forms.Panel pnlBuscarPorCLiente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.RadioButton RbtnMod2;
        private System.Windows.Forms.Button btnBonificacion;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.Label lblIdVenta;
        private System.Windows.Forms.Button btnEditarPago;
        private System.Windows.Forms.Panel pnlEditarPago;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.MenuStrip menuStrip6;
        private System.Windows.Forms.ToolStripMenuItem cancelarVentaF9ToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cobrarF10;
        private System.Windows.Forms.Label lblMontoTotal;
    }
}