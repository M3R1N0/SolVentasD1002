namespace VentasD1002
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gdvUsuarios = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAgregarUsuarios = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblNombreIcono = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelAgregarUsuarios.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.Controls.Add(this.pbCerrar);
            this.panelEncabezado.Controls.Add(this.label1);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(864, 43);
            this.panelEncabezado.TabIndex = 0;
            // 
            // pbCerrar
            // 
            this.pbCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(827, 6);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(31, 30);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 1;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(864, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gdvUsuarios
            // 
            this.gdvUsuarios.AllowUserToAddRows = false;
            this.gdvUsuarios.AllowUserToResizeColumns = false;
            this.gdvUsuarios.AllowUserToResizeRows = false;
            this.gdvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.gdvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gdvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(174)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.gdvUsuarios.EnableHeadersVisualStyles = false;
            this.gdvUsuarios.GridColor = System.Drawing.Color.White;
            this.gdvUsuarios.Location = new System.Drawing.Point(16, 136);
            this.gdvUsuarios.Name = "gdvUsuarios";
            this.gdvUsuarios.ReadOnly = true;
            this.gdvUsuarios.RowHeadersVisible = false;
            this.gdvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvUsuarios.Size = new System.Drawing.Size(823, 308);
            this.gdvUsuarios.TabIndex = 3;
            this.gdvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvUsuarios_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eliminar.FillWeight = 149.2386F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Editar.FillWeight = 50.76142F;
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(696, 80);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(107, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.agregarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agregarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem.Image")));
            this.agregarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // panelAgregarUsuarios
            // 
            this.panelAgregarUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAgregarUsuarios.BackColor = System.Drawing.Color.White;
            this.panelAgregarUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAgregarUsuarios.BackgroundImage")));
            this.panelAgregarUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAgregarUsuarios.Controls.Add(this.panelTitulo);
            this.panelAgregarUsuarios.Controls.Add(this.label9);
            this.panelAgregarUsuarios.Controls.Add(this.panel1);
            this.panelAgregarUsuarios.Controls.Add(this.txtApellidos);
            this.panelAgregarUsuarios.Controls.Add(this.label2);
            this.panelAgregarUsuarios.Controls.Add(this.panel4);
            this.panelAgregarUsuarios.Controls.Add(this.txtDireccion);
            this.panelAgregarUsuarios.Controls.Add(this.label8);
            this.panelAgregarUsuarios.Controls.Add(this.lblIdUsuario);
            this.panelAgregarUsuarios.Controls.Add(this.lblNombreIcono);
            this.panelAgregarUsuarios.Controls.Add(this.pbFoto);
            this.panelAgregarUsuarios.Controls.Add(this.btnVolver);
            this.panelAgregarUsuarios.Controls.Add(this.btnGuardarCambios);
            this.panelAgregarUsuarios.Controls.Add(this.btnGuardar);
            this.panelAgregarUsuarios.Controls.Add(this.cboRol);
            this.panelAgregarUsuarios.Controls.Add(this.label7);
            this.panelAgregarUsuarios.Controls.Add(this.panel9);
            this.panelAgregarUsuarios.Controls.Add(this.panel8);
            this.panelAgregarUsuarios.Controls.Add(this.panel7);
            this.panelAgregarUsuarios.Controls.Add(this.panel6);
            this.panelAgregarUsuarios.Controls.Add(this.txtCorreo);
            this.panelAgregarUsuarios.Controls.Add(this.txtContraseña);
            this.panelAgregarUsuarios.Controls.Add(this.txtUsuario);
            this.panelAgregarUsuarios.Controls.Add(this.txtNombre);
            this.panelAgregarUsuarios.Controls.Add(this.label6);
            this.panelAgregarUsuarios.Controls.Add(this.label5);
            this.panelAgregarUsuarios.Controls.Add(this.label4);
            this.panelAgregarUsuarios.Controls.Add(this.label3);
            this.panelAgregarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAgregarUsuarios.Location = new System.Drawing.Point(86, 62);
            this.panelAgregarUsuarios.Name = "panelAgregarUsuarios";
            this.panelAgregarUsuarios.Size = new System.Drawing.Size(734, 401);
            this.panelAgregarUsuarios.TabIndex = 5;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panelTitulo.Controls.Add(this.label10);
            this.panelTitulo.Controls.Add(this.btnSalir);
            this.panelTitulo.Location = new System.Drawing.Point(10, 9);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(713, 33);
            this.panelTitulo.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(226, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "MANTENIMIENTO USUARIOS";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.Location = new System.Drawing.Point(677, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(36, 27);
            this.btnSalir.TabIndex = 44;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Apellidos :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(209, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 1);
            this.panel1.TabIndex = 46;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Location = new System.Drawing.Point(209, 111);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(248, 19);
            this.txtApellidos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Dirección";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(209, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 1);
            this.panel4.TabIndex = 42;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Location = new System.Drawing.Point(209, 141);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(248, 19);
            this.txtDireccion.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(257, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Para recuperar su contraseña";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(534, 76);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(81, 20);
            this.lblIdUsuario.TabIndex = 39;
            this.lblIdUsuario.Text = "IDUsuario";
            this.lblIdUsuario.Visible = false;
            // 
            // lblNombreIcono
            // 
            this.lblNombreIcono.AutoSize = true;
            this.lblNombreIcono.Location = new System.Drawing.Point(534, 222);
            this.lblNombreIcono.Name = "lblNombreIcono";
            this.lblNombreIcono.Size = new System.Drawing.Size(0, 20);
            this.lblNombreIcono.TabIndex = 38;
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.ErrorImage = null;
            this.pbFoto.InitialImage = null;
            this.pbFoto.Location = new System.Drawing.Point(517, 102);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(127, 117);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 37;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(134, 348);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 32);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCambios.Image")));
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambios.Location = new System.Drawing.Point(251, 348);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(178, 32);
            this.btnGuardarCambios.TabIndex = 34;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(445, 348);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 32);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboRol
            // 
            this.cboRol.DisplayMember = "Seleccione ...";
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Items.AddRange(new object[] {
            "Solo Ventas",
            "Cajero",
            "Administrador"});
            this.cboRol.Location = new System.Drawing.Point(209, 289);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(248, 28);
            this.cboRol.TabIndex = 6;
            this.cboRol.ValueMember = "Seleccione ...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Nombre :";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(209, 255);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(247, 1);
            this.panel9.TabIndex = 30;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(209, 225);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(247, 1);
            this.panel8.TabIndex = 29;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(209, 195);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(247, 1);
            this.panel7.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(209, 105);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(247, 1);
            this.panel6.TabIndex = 27;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Location = new System.Drawing.Point(209, 231);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(248, 19);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Location = new System.Drawing.Point(209, 201);
            this.txtContraseña.MaxLength = 6;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(248, 19);
            this.txtContraseña.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Location = new System.Drawing.Point(209, 171);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(248, 19);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(209, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 19);
            this.txtNombre.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Rol :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Correo electrónico :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contraseña :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Usuario :";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(16, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 71);
            this.panel2.TabIndex = 6;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 489);
            this.Controls.Add(this.panelAgregarUsuarios);
            this.Controls.Add(this.gdvUsuarios);
            this.Controls.Add(this.panelEncabezado);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.panelEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAgregarUsuarios.ResumeLayout(false);
            this.panelAgregarUsuarios.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdvUsuarios;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.Panel panelAgregarUsuarios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblNombreIcono;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Panel panel2;
    }
}