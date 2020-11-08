namespace VentasD1002
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip8 = new System.Windows.Forms.MenuStrip();
            this.btnVentaPendiente = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.gdvClientes = new System.Windows.Forms.DataGridView();
            this.pnlAltaCliente = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.rbProveedor = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvClientes)).BeginInit();
            this.pnlAltaCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 30);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(994, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip8);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.txtBuscarCliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 87);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip8
            // 
            this.menuStrip8.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip8.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVentaPendiente});
            this.menuStrip8.Location = new System.Drawing.Point(765, 5);
            this.menuStrip8.Name = "menuStrip8";
            this.menuStrip8.Size = new System.Drawing.Size(213, 72);
            this.menuStrip8.TabIndex = 16;
            this.menuStrip8.Text = "menuStrip8";
            // 
            // btnVentaPendiente
            // 
            this.btnVentaPendiente.BackColor = System.Drawing.Color.Transparent;
            this.btnVentaPendiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVentaPendiente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnVentaPendiente.Image = ((System.Drawing.Image)(resources.GetObject("btnVentaPendiente.Image")));
            this.btnVentaPendiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaPendiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVentaPendiente.Name = "btnVentaPendiente";
            this.btnVentaPendiente.Size = new System.Drawing.Size(205, 68);
            this.btnVentaPendiente.Text = "Agregar Cliente";
            this.btnVentaPendiente.Click += new System.EventHandler(this.btnVentaPendiente_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(111, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(155, 44);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(349, 26);
            this.txtBuscarCliente.TabIndex = 14;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarVencimiento_TextChanged);
            // 
            // gdvClientes
            // 
            this.gdvClientes.AllowUserToAddRows = false;
            this.gdvClientes.BackgroundColor = System.Drawing.Color.White;
            this.gdvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.gdvClientes.EnableHeadersVisualStyles = false;
            this.gdvClientes.Location = new System.Drawing.Point(52, 157);
            this.gdvClientes.Name = "gdvClientes";
            this.gdvClientes.RowHeadersVisible = false;
            this.gdvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gdvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvClientes.Size = new System.Drawing.Size(912, 402);
            this.gdvClientes.TabIndex = 2;
            this.gdvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvClientes_CellClick);
            // 
            // pnlAltaCliente
            // 
            this.pnlAltaCliente.BackColor = System.Drawing.Color.Transparent;
            this.pnlAltaCliente.Controls.Add(this.lblID);
            this.pnlAltaCliente.Controls.Add(this.groupBox1);
            this.pnlAltaCliente.Controls.Add(this.rbProveedor);
            this.pnlAltaCliente.Controls.Add(this.rbCliente);
            this.pnlAltaCliente.Controls.Add(this.menuStrip2);
            this.pnlAltaCliente.Controls.Add(this.menuStrip1);
            this.pnlAltaCliente.Controls.Add(this.label9);
            this.pnlAltaCliente.Controls.Add(this.panel5);
            this.pnlAltaCliente.Controls.Add(this.txtDireccion);
            this.pnlAltaCliente.Controls.Add(this.label2);
            this.pnlAltaCliente.Controls.Add(this.panel6);
            this.pnlAltaCliente.Controls.Add(this.txtTelefono);
            this.pnlAltaCliente.Controls.Add(this.label7);
            this.pnlAltaCliente.Controls.Add(this.panel7);
            this.pnlAltaCliente.Controls.Add(this.panel10);
            this.pnlAltaCliente.Controls.Add(this.txtSaldo);
            this.pnlAltaCliente.Controls.Add(this.txtNombre);
            this.pnlAltaCliente.Controls.Add(this.label3);
            this.pnlAltaCliente.Controls.Add(this.panel4);
            this.pnlAltaCliente.Location = new System.Drawing.Point(136, 126);
            this.pnlAltaCliente.Name = "pnlAltaCliente";
            this.pnlAltaCliente.Size = new System.Drawing.Size(733, 470);
            this.pnlAltaCliente.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(this.Label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(80, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 99);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de  facturación (Opcional)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(13, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 1);
            this.panel3.TabIndex = 339;
            // 
            // txtRuc
            // 
            this.txtRuc.BackColor = System.Drawing.SystemColors.Control;
            this.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuc.Location = new System.Drawing.Point(13, 62);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(560, 19);
            this.txtRuc.TabIndex = 338;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.Black;
            this.Label14.Location = new System.Drawing.Point(9, 31);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(146, 20);
            this.Label14.TabIndex = 337;
            this.Label14.Text = "RUC/ RFC/ NIT/ CI:";
            // 
            // rbProveedor
            // 
            this.rbProveedor.AutoSize = true;
            this.rbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProveedor.Location = new System.Drawing.Point(324, 237);
            this.rbProveedor.Name = "rbProveedor";
            this.rbProveedor.Size = new System.Drawing.Size(99, 24);
            this.rbProveedor.TabIndex = 69;
            this.rbProveedor.Text = "Proveedor";
            this.rbProveedor.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Checked = true;
            this.rbCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.rbCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCliente.Location = new System.Drawing.Point(222, 237);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(82, 25);
            this.rbCliente.TabIndex = 68;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelar});
            this.menuStrip2.Location = new System.Drawing.Point(431, 413);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(128, 40);
            this.menuStrip2.TabIndex = 67;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar});
            this.menuStrip1.Location = new System.Drawing.Point(577, 413);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(123, 40);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 36);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(109, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Dirección :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(221, 147);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(431, 1);
            this.panel5.TabIndex = 64;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(221, 123);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(432, 19);
            this.txtDireccion.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Telefono :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(220, 185);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(431, 1);
            this.panel6.TabIndex = 62;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(220, 161);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(432, 19);
            this.txtTelefono.TabIndex = 50;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Nombre completo:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(220, 221);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(431, 1);
            this.panel7.TabIndex = 58;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(220, 110);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(431, 1);
            this.panel10.TabIndex = 57;
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.SystemColors.Control;
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(220, 197);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(432, 19);
            this.txtSaldo.TabIndex = 51;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(220, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(432, 19);
            this.txtNombre.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Saldo :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(733, 40);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar / Editar Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(578, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 71;
            this.lblID.Visible = false;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 608);
            this.Controls.Add(this.pnlAltaCliente);
            this.Controls.Add(this.gdvClientes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip8.ResumeLayout(false);
            this.menuStrip8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvClientes)).EndInit();
            this.pnlAltaCliente.ResumeLayout(false);
            this.pnlAltaCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.MenuStrip menuStrip8;
        private System.Windows.Forms.ToolStripMenuItem btnVentaPendiente;
        private System.Windows.Forms.DataGridView gdvClientes;
        private System.Windows.Forms.Panel pnlAltaCliente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnGuardar;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnCancelar;
        private System.Windows.Forms.RadioButton rbProveedor;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRuc;
        internal System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}