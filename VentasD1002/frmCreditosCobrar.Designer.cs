namespace VentasD1002
{
    partial class frmCreditosCobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditosCobrar));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pbLogo = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.lblTotalCredtio = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gdvTotalCredito = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gdvDetalle = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtCajero = new RJCodeAdvance.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolio = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIdVenta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkContraerColapsar = new System.Windows.Forms.CheckBox();
            this.chkAgrupar = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gdvListado = new System.Windows.Forms.DataGridView();
            this.Detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtMontoTotal = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtTotalAbonado = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtTotalLiquidar = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaVenta = new RJCodeAdvance.RJControls.RJTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTotalCredito)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalle)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1259, 711);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.panel15);
            this.tabPage1.Controls.Add(this.gdvTotalCredito);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1251, 682);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista crédito por cliente";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DarkOrange;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(3, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1245, 34);
            this.label14.TabIndex = 0;
            this.label14.Text = "Listado de clientes de notas por liquidar";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.pbLogo);
            this.panel15.Controls.Add(this.lblTotalCredtio);
            this.panel15.Controls.Add(this.label15);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(3, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1245, 95);
            this.panel15.TabIndex = 5;
            // 
            // pbLogo
            // 
            this.pbLogo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbLogo.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbLogo.BorderColor2 = System.Drawing.Color.CornflowerBlue;
            this.pbLogo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbLogo.BorderSize = 2;
            this.pbLogo.GradientAngle = 50F;
            this.pbLogo.Location = new System.Drawing.Point(5, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(93, 93);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // lblTotalCredtio
            // 
            this.lblTotalCredtio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCredtio.AutoEllipsis = true;
            this.lblTotalCredtio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCredtio.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCredtio.Location = new System.Drawing.Point(1001, 36);
            this.lblTotalCredtio.Name = "lblTotalCredtio";
            this.lblTotalCredtio.Size = new System.Drawing.Size(229, 39);
            this.lblTotalCredtio.TabIndex = 3;
            this.lblTotalCredtio.Text = "0.00";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(762, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(235, 41);
            this.label15.TabIndex = 2;
            this.label15.Text = "Crédito  total:";
            // 
            // gdvTotalCredito
            // 
            this.gdvTotalCredito.AllowUserToAddRows = false;
            this.gdvTotalCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvTotalCredito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdvTotalCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gdvTotalCredito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.gdvTotalCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvTotalCredito.Location = new System.Drawing.Point(28, 146);
            this.gdvTotalCredito.MultiSelect = false;
            this.gdvTotalCredito.Name = "gdvTotalCredito";
            this.gdvTotalCredito.ReadOnly = true;
            this.gdvTotalCredito.RowHeadersVisible = false;
            this.gdvTotalCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvTotalCredito.Size = new System.Drawing.Size(1196, 509);
            this.gdvTotalCredito.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1251, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cobro crédito";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTotalLiquidar);
            this.panel3.Controls.Add(this.txtTotalAbonado);
            this.panel3.Controls.Add(this.txtMontoTotal);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.gdvDetalle);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lblIdVenta);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(565, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 676);
            this.panel3.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(382, 558);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Monto total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 638);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monto a Liquidar :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Monto Abonado :";
            // 
            // gdvDetalle
            // 
            this.gdvDetalle.AllowUserToAddRows = false;
            this.gdvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvDetalle.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gdvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDetalle.Location = new System.Drawing.Point(7, 163);
            this.gdvDetalle.MultiSelect = false;
            this.gdvDetalle.Name = "gdvDetalle";
            this.gdvDetalle.ReadOnly = true;
            this.gdvDetalle.RowHeadersVisible = false;
            this.gdvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvDetalle.Size = new System.Drawing.Size(670, 383);
            this.gdvDetalle.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 152);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtFechaVenta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.txtCajero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFolio);
            this.groupBox1.Controls.Add(this.btnCobrar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 152);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCliente.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCliente.BorderFocusColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCliente.BorderRadius = 0;
            this.txtCliente.BorderSize = 2;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCliente.Location = new System.Drawing.Point(92, 61);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCliente.PasswordChar = false;
            this.txtCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCliente.PlaceholderText = "";
            this.txtCliente.Size = new System.Drawing.Size(439, 34);
            this.txtCliente.TabIndex = 20;
            this.txtCliente.Texts = "";
            this.txtCliente.UnderlinedStyle = true;
            // 
            // txtCajero
            // 
            this.txtCajero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCajero.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCajero.BorderFocusColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCajero.BorderRadius = 0;
            this.txtCajero.BorderSize = 2;
            this.txtCajero.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCajero.Location = new System.Drawing.Point(92, 103);
            this.txtCajero.Margin = new System.Windows.Forms.Padding(4);
            this.txtCajero.Multiline = false;
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCajero.PasswordChar = false;
            this.txtCajero.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCajero.PlaceholderText = "";
            this.txtCajero.Size = new System.Drawing.Size(200, 34);
            this.txtCajero.TabIndex = 19;
            this.txtCajero.Texts = "";
            this.txtCajero.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Folio N° :";
            // 
            // txtFolio
            // 
            this.txtFolio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFolio.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtFolio.BorderFocusColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtFolio.BorderRadius = 12;
            this.txtFolio.BorderSize = 2;
            this.txtFolio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFolio.Location = new System.Drawing.Point(400, 18);
            this.txtFolio.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolio.Multiline = false;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFolio.PasswordChar = false;
            this.txtFolio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFolio.PlaceholderText = "";
            this.txtFolio.Size = new System.Drawing.Size(131, 35);
            this.txtFolio.TabIndex = 18;
            this.txtFolio.Texts = "";
            this.txtFolio.UnderlinedStyle = false;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackgroundImage = global::VentasD1002.Properties.Resources.azul;
            this.btnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCobrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCobrar.Image")));
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.Location = new System.Drawing.Point(556, 96);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(121, 50);
            this.btnCobrar.TabIndex = 10;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cliente :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cajero :";
            // 
            // lblIdVenta
            // 
            this.lblIdVenta.AutoSize = true;
            this.lblIdVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVenta.Location = new System.Drawing.Point(33, 204);
            this.lblIdVenta.Name = "lblIdVenta";
            this.lblIdVenta.Size = new System.Drawing.Size(16, 17);
            this.lblIdVenta.TabIndex = 11;
            this.lblIdVenta.Text = "0";
            this.lblIdVenta.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(555, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 676);
            this.panel1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chkContraerColapsar);
            this.panel4.Controls.Add(this.chkAgrupar);
            this.panel4.Controls.Add(this.txtBuscar);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.gdvListado);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(552, 676);
            this.panel4.TabIndex = 2;
            // 
            // chkContraerColapsar
            // 
            this.chkContraerColapsar.AutoSize = true;
            this.chkContraerColapsar.Location = new System.Drawing.Point(112, 99);
            this.chkContraerColapsar.Name = "chkContraerColapsar";
            this.chkContraerColapsar.Size = new System.Drawing.Size(224, 21);
            this.chkContraerColapsar.TabIndex = 393;
            this.chkContraerColapsar.Text = "Contraer / Colapsar grupos";
            this.chkContraerColapsar.UseVisualStyleBackColor = true;
            this.chkContraerColapsar.Visible = false;
            this.chkContraerColapsar.CheckedChanged += new System.EventHandler(this.chkContraerColapsar_CheckedChanged);
            // 
            // chkAgrupar
            // 
            this.chkAgrupar.AutoSize = true;
            this.chkAgrupar.Location = new System.Drawing.Point(13, 99);
            this.chkAgrupar.Name = "chkAgrupar";
            this.chkAgrupar.Size = new System.Drawing.Size(85, 21);
            this.chkAgrupar.TabIndex = 394;
            this.chkAgrupar.Text = "Agrupar";
            this.chkAgrupar.UseVisualStyleBackColor = true;
            this.chkAgrupar.CheckedChanged += new System.EventHandler(this.chkAgrupar_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(60, 52);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(458, 27);
            this.txtBuscar.TabIndex = 391;
            this.txtBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseClick);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel9.Location = new System.Drawing.Point(52, 79);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(466, 3);
            this.panel9.TabIndex = 392;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(18, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 390;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el ticket a cobrar :";
            // 
            // gdvListado
            // 
            this.gdvListado.AllowUserToAddRows = false;
            this.gdvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvListado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gdvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalle});
            this.gdvListado.Location = new System.Drawing.Point(14, 135);
            this.gdvListado.Name = "gdvListado";
            this.gdvListado.RowHeadersVisible = false;
            this.gdvListado.RowTemplate.ReadOnly = true;
            this.gdvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvListado.Size = new System.Drawing.Size(532, 521);
            this.gdvListado.TabIndex = 3;
            this.gdvListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvListado_CellClick_1);
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Detalle.Image")));
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.ToolTipText = "Ver detalle";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Detalle";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.ToolTipText = "Ver detalle";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMontoTotal.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtMontoTotal.BorderFocusColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtMontoTotal.BorderRadius = 12;
            this.txtMontoTotal.BorderSize = 2;
            this.txtMontoTotal.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMontoTotal.Location = new System.Drawing.Point(519, 553);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotal.Multiline = false;
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMontoTotal.PasswordChar = false;
            this.txtMontoTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMontoTotal.PlaceholderText = "";
            this.txtMontoTotal.Size = new System.Drawing.Size(158, 34);
            this.txtMontoTotal.TabIndex = 19;
            this.txtMontoTotal.Texts = "";
            this.txtMontoTotal.UnderlinedStyle = false;
            // 
            // txtTotalAbonado
            // 
            this.txtTotalAbonado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalAbonado.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtTotalAbonado.BorderFocusColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtTotalAbonado.BorderRadius = 12;
            this.txtTotalAbonado.BorderSize = 2;
            this.txtTotalAbonado.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAbonado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalAbonado.Location = new System.Drawing.Point(520, 593);
            this.txtTotalAbonado.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAbonado.Multiline = false;
            this.txtTotalAbonado.Name = "txtTotalAbonado";
            this.txtTotalAbonado.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalAbonado.PasswordChar = false;
            this.txtTotalAbonado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalAbonado.PlaceholderText = "";
            this.txtTotalAbonado.Size = new System.Drawing.Size(158, 34);
            this.txtTotalAbonado.TabIndex = 20;
            this.txtTotalAbonado.Texts = "";
            this.txtTotalAbonado.UnderlinedStyle = false;
            // 
            // txtTotalLiquidar
            // 
            this.txtTotalLiquidar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalLiquidar.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtTotalLiquidar.BorderFocusColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtTotalLiquidar.BorderRadius = 12;
            this.txtTotalLiquidar.BorderSize = 2;
            this.txtTotalLiquidar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLiquidar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalLiquidar.Location = new System.Drawing.Point(519, 633);
            this.txtTotalLiquidar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalLiquidar.Multiline = false;
            this.txtTotalLiquidar.Name = "txtTotalLiquidar";
            this.txtTotalLiquidar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalLiquidar.PasswordChar = false;
            this.txtTotalLiquidar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalLiquidar.PlaceholderText = "";
            this.txtTotalLiquidar.Size = new System.Drawing.Size(158, 34);
            this.txtTotalLiquidar.TabIndex = 21;
            this.txtTotalLiquidar.Texts = "";
            this.txtTotalLiquidar.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha v.:";
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaVenta.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtFechaVenta.BorderFocusColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtFechaVenta.BorderRadius = 0;
            this.txtFechaVenta.BorderSize = 2;
            this.txtFechaVenta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFechaVenta.Location = new System.Drawing.Point(368, 103);
            this.txtFechaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaVenta.Multiline = false;
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFechaVenta.PasswordChar = false;
            this.txtFechaVenta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFechaVenta.PlaceholderText = "";
            this.txtFechaVenta.Size = new System.Drawing.Size(163, 34);
            this.txtFechaVenta.TabIndex = 22;
            this.txtFechaVenta.Texts = "";
            this.txtFechaVenta.UnderlinedStyle = true;
            // 
            // frmCreditosCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 711);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmCreditosCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créditos por Cobrar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCreditosCobrar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTotalCredito)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gdvDetalle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIdVenta;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdvListado;
        private System.Windows.Forms.DataGridViewImageColumn Detalle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel15;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbLogo;
        private System.Windows.Forms.Label lblTotalCredtio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView gdvTotalCredito;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox chkContraerColapsar;
        private System.Windows.Forms.CheckBox chkAgrupar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJTextBox txtFolio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJTextBox txtCliente;
        private RJCodeAdvance.RJControls.RJTextBox txtCajero;
        private RJCodeAdvance.RJControls.RJTextBox txtTotalLiquidar;
        private RJCodeAdvance.RJControls.RJTextBox txtTotalAbonado;
        private RJCodeAdvance.RJControls.RJTextBox txtMontoTotal;
        private RJCodeAdvance.RJControls.RJTextBox txtFechaVenta;
        private System.Windows.Forms.Label label2;
    }
}