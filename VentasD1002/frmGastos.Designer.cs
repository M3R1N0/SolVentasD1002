namespace VentasD1002
{
    partial class frmGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGastos));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.chkComprobante = new System.Windows.Forms.CheckBox();
            this.pnlComprobante = new System.Windows.Forms.Panel();
            this.txtNComprobante = new System.Windows.Forms.TextBox();
            this.cboTipoComprobante = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbAgregar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gdvConcepto = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlConcepto = new System.Windows.Forms.Panel();
            this.btnCancelarConcepto = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNvoConcepto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rtbnIngresos = new System.Windows.Forms.RadioButton();
            this.rbtnGastos = new System.Windows.Forms.RadioButton();
            this.pnlComprobante.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvConcepto)).BeginInit();
            this.pnlConcepto.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(239, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(396, 55);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Gastos";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha :";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(203, 194);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(268, 26);
            this.txtMonto.TabIndex = 4;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(203, 258);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(268, 59);
            this.txtDetalle.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(203, 226);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(120, 26);
            this.dtpFecha.TabIndex = 6;
            // 
            // chkComprobante
            // 
            this.chkComprobante.AutoSize = true;
            this.chkComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComprobante.Location = new System.Drawing.Point(120, 331);
            this.chkComprobante.Name = "chkComprobante";
            this.chkComprobante.Size = new System.Drawing.Size(125, 24);
            this.chkComprobante.TabIndex = 7;
            this.chkComprobante.Text = "Comprobante";
            this.chkComprobante.UseVisualStyleBackColor = true;
            this.chkComprobante.CheckedChanged += new System.EventHandler(this.chkComprobante_CheckedChanged);
            // 
            // pnlComprobante
            // 
            this.pnlComprobante.Controls.Add(this.txtNComprobante);
            this.pnlComprobante.Controls.Add(this.cboTipoComprobante);
            this.pnlComprobante.Controls.Add(this.label5);
            this.pnlComprobante.Controls.Add(this.label6);
            this.pnlComprobante.Location = new System.Drawing.Point(120, 360);
            this.pnlComprobante.Name = "pnlComprobante";
            this.pnlComprobante.Size = new System.Drawing.Size(351, 70);
            this.pnlComprobante.TabIndex = 8;
            // 
            // txtNComprobante
            // 
            this.txtNComprobante.Location = new System.Drawing.Point(157, 40);
            this.txtNComprobante.Name = "txtNComprobante";
            this.txtNComprobante.Size = new System.Drawing.Size(177, 20);
            this.txtNComprobante.TabIndex = 7;
            // 
            // cboTipoComprobante
            // 
            this.cboTipoComprobante.FormattingEnabled = true;
            this.cboTipoComprobante.Items.AddRange(new object[] {
            "RECIBO",
            "TICKET"});
            this.cboTipoComprobante.Location = new System.Drawing.Point(157, 13);
            this.cboTipoComprobante.Name = "cboTipoComprobante";
            this.cboTipoComprobante.Size = new System.Drawing.Size(177, 21);
            this.cboTipoComprobante.TabIndex = 6;
            this.cboTipoComprobante.Text = "--Seleccione una opción--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "N° Comprobante :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo comprobante :";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(357, 449);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 32);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(221, 449);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 32);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbAgregar);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 85);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el concepto o agregue uno nuevo";
            // 
            // pbAgregar
            // 
            this.pbAgregar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("pbAgregar.Image")));
            this.pbAgregar.Location = new System.Drawing.Point(409, 30);
            this.pbAgregar.Name = "pbAgregar";
            this.pbAgregar.Size = new System.Drawing.Size(39, 35);
            this.pbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgregar.TabIndex = 3;
            this.pbAgregar.TabStop = false;
            this.pbAgregar.Click += new System.EventHandler(this.pbAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(15)))));
            this.panel1.Location = new System.Drawing.Point(7, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 3);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(55, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(335, 19);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gdvConcepto
            // 
            this.gdvConcepto.AllowUserToAddRows = false;
            this.gdvConcepto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdvConcepto.BackgroundColor = System.Drawing.Color.White;
            this.gdvConcepto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvConcepto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvConcepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvConcepto.ColumnHeadersVisible = false;
            this.gdvConcepto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.gdvConcepto.Location = new System.Drawing.Point(110, 149);
            this.gdvConcepto.MultiSelect = false;
            this.gdvConcepto.Name = "gdvConcepto";
            this.gdvConcepto.ReadOnly = true;
            this.gdvConcepto.RowHeadersVisible = false;
            this.gdvConcepto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gdvConcepto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvConcepto.Size = new System.Drawing.Size(338, 176);
            this.gdvConcepto.TabIndex = 37;
            this.gdvConcepto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvConcepto_CellClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 5;
            // 
            // pnlConcepto
            // 
            this.pnlConcepto.Controls.Add(this.btnCancelarConcepto);
            this.pnlConcepto.Controls.Add(this.btnAgregar);
            this.pnlConcepto.Controls.Add(this.panel2);
            this.pnlConcepto.Controls.Add(this.txtNvoConcepto);
            this.pnlConcepto.Controls.Add(this.label7);
            this.pnlConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConcepto.Location = new System.Drawing.Point(56, 88);
            this.pnlConcepto.Name = "pnlConcepto";
            this.pnlConcepto.Size = new System.Drawing.Size(493, 393);
            this.pnlConcepto.TabIndex = 4;
            // 
            // btnCancelarConcepto
            // 
            this.btnCancelarConcepto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelarConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarConcepto.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarConcepto.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarConcepto.Image")));
            this.btnCancelarConcepto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarConcepto.Location = new System.Drawing.Point(221, 152);
            this.btnCancelarConcepto.Name = "btnCancelarConcepto";
            this.btnCancelarConcepto.Size = new System.Drawing.Size(116, 32);
            this.btnCancelarConcepto.TabIndex = 37;
            this.btnCancelarConcepto.Text = "Cancelar";
            this.btnCancelarConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarConcepto.UseVisualStyleBackColor = true;
            this.btnCancelarConcepto.Click += new System.EventHandler(this.btnCancelarConcepto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(355, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 32);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(12, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 3);
            this.panel2.TabIndex = 2;
            // 
            // txtNvoConcepto
            // 
            this.txtNvoConcepto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNvoConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNvoConcepto.Location = new System.Drawing.Point(12, 93);
            this.txtNvoConcepto.Name = "txtNvoConcepto";
            this.txtNvoConcepto.Size = new System.Drawing.Size(457, 19);
            this.txtNvoConcepto.TabIndex = 1;
            this.txtNvoConcepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ingrese el  nuevo concepto :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Location = new System.Drawing.Point(120, 354);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 5);
            this.panel3.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbltitulo);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 55);
            this.panel4.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Bisque;
            this.panel5.Controls.Add(this.rtbnIngresos);
            this.panel5.Controls.Add(this.rbtnGastos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 55);
            this.panel5.TabIndex = 40;
            // 
            // rtbnIngresos
            // 
            this.rtbnIngresos.AutoSize = true;
            this.rtbnIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbnIngresos.Location = new System.Drawing.Point(110, 19);
            this.rtbnIngresos.Name = "rtbnIngresos";
            this.rtbnIngresos.Size = new System.Drawing.Size(97, 24);
            this.rtbnIngresos.TabIndex = 1;
            this.rtbnIngresos.Text = "Ingresos";
            this.rtbnIngresos.UseVisualStyleBackColor = true;
            this.rtbnIngresos.CheckedChanged += new System.EventHandler(this.rtbnIngresos_CheckedChanged);
            // 
            // rbtnGastos
            // 
            this.rbtnGastos.AutoSize = true;
            this.rbtnGastos.Checked = true;
            this.rbtnGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGastos.Location = new System.Drawing.Point(12, 19);
            this.rbtnGastos.Name = "rbtnGastos";
            this.rbtnGastos.Size = new System.Drawing.Size(85, 24);
            this.rbtnGastos.TabIndex = 0;
            this.rbtnGastos.TabStop = true;
            this.rbtnGastos.Text = "Gastos";
            this.rbtnGastos.UseVisualStyleBackColor = true;
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(635, 539);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlConcepto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gdvConcepto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlComprobante);
            this.Controls.Add(this.chkComprobante);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos varios";
            this.Load += new System.EventHandler(this.frmGastos_Load);
            this.pnlComprobante.ResumeLayout(false);
            this.pnlComprobante.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvConcepto)).EndInit();
            this.pnlConcepto.ResumeLayout(false);
            this.pnlConcepto.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox chkComprobante;
        private System.Windows.Forms.Panel pnlComprobante;
        private System.Windows.Forms.TextBox txtNComprobante;
        private System.Windows.Forms.ComboBox cboTipoComprobante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView gdvConcepto;
        private System.Windows.Forms.Panel pnlConcepto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNvoConcepto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelarConcepto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rtbnIngresos;
        private System.Windows.Forms.RadioButton rbtnGastos;
    }
}