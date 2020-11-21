namespace VentasD1002
{
    partial class frmComprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprobante));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAltaComprobante = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.checkDefecto = new System.Windows.Forms.CheckBox();
            this.txtnumerofin = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.TXTCANTIDADDECEROS = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNombreComprobante = new System.Windows.Forms.TextBox();
            this.pnlABComprobante = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MenuStrip5 = new System.Windows.Forms.MenuStrip();
            this.GUARDAR = new System.Windows.Forms.ToolStripMenuItem();
            this.GUARDARCAMBIOS = new System.Windows.Forms.ToolStripMenuItem();
            this.VOLVEROK = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gdvComprobantes = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.pnlAltaComprobante.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlABComprobante.SuspendLayout();
            this.panel6.SuspendLayout();
            this.MenuStrip5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvComprobantes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "Configuración de Comprobantes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAltaComprobante
            // 
            this.pnlAltaComprobante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAltaComprobante.BackgroundImage")));
            this.pnlAltaComprobante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlAltaComprobante.Controls.Add(this.lblDocumento);
            this.pnlAltaComprobante.Controls.Add(this.lblID);
            this.pnlAltaComprobante.Controls.Add(this.checkDefecto);
            this.pnlAltaComprobante.Controls.Add(this.txtnumerofin);
            this.pnlAltaComprobante.Controls.Add(this.txtSerie);
            this.pnlAltaComprobante.Controls.Add(this.TXTCANTIDADDECEROS);
            this.pnlAltaComprobante.Controls.Add(this.panel4);
            this.pnlAltaComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAltaComprobante.Location = new System.Drawing.Point(0, 0);
            this.pnlAltaComprobante.Name = "pnlAltaComprobante";
            this.pnlAltaComprobante.Size = new System.Drawing.Size(544, 341);
            this.pnlAltaComprobante.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(200, 69);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 626;
            this.lblID.Visible = false;
            // 
            // checkDefecto
            // 
            this.checkDefecto.AutoSize = true;
            this.checkDefecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDefecto.Location = new System.Drawing.Point(299, 60);
            this.checkDefecto.Name = "checkDefecto";
            this.checkDefecto.Size = new System.Drawing.Size(138, 28);
            this.checkDefecto.TabIndex = 625;
            this.checkDefecto.Text = "Por Defecto";
            this.checkDefecto.UseVisualStyleBackColor = true;
            // 
            // txtnumerofin
            // 
            this.txtnumerofin.BackColor = System.Drawing.Color.White;
            this.txtnumerofin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumerofin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtnumerofin.ForeColor = System.Drawing.Color.Black;
            this.txtnumerofin.Location = new System.Drawing.Point(297, 187);
            this.txtnumerofin.Name = "txtnumerofin";
            this.txtnumerofin.Size = new System.Drawing.Size(172, 35);
            this.txtnumerofin.TabIndex = 622;
            this.txtnumerofin.Text = "0";
            this.txtnumerofin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.White;
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtSerie.ForeColor = System.Drawing.Color.Black;
            this.txtSerie.Location = new System.Drawing.Point(297, 248);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(170, 35);
            this.txtSerie.TabIndex = 623;
            this.txtSerie.Text = "0";
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTCANTIDADDECEROS
            // 
            this.TXTCANTIDADDECEROS.BackColor = System.Drawing.Color.White;
            this.TXTCANTIDADDECEROS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTCANTIDADDECEROS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TXTCANTIDADDECEROS.ForeColor = System.Drawing.Color.Black;
            this.TXTCANTIDADDECEROS.Location = new System.Drawing.Point(297, 124);
            this.TXTCANTIDADDECEROS.Name = "TXTCANTIDADDECEROS";
            this.TXTCANTIDADDECEROS.Size = new System.Drawing.Size(170, 35);
            this.TXTCANTIDADDECEROS.TabIndex = 624;
            this.TXTCANTIDADDECEROS.Text = "0";
            this.TXTCANTIDADDECEROS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.txtNombreComprobante);
            this.panel4.Location = new System.Drawing.Point(14, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 36);
            this.panel4.TabIndex = 621;
            // 
            // txtNombreComprobante
            // 
            this.txtNombreComprobante.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtNombreComprobante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtNombreComprobante.ForeColor = System.Drawing.Color.White;
            this.txtNombreComprobante.Location = new System.Drawing.Point(-1, 10);
            this.txtNombreComprobante.Name = "txtNombreComprobante";
            this.txtNombreComprobante.Size = new System.Drawing.Size(210, 16);
            this.txtNombreComprobante.TabIndex = 615;
            this.txtNombreComprobante.Text = "FACTURA";
            this.txtNombreComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlABComprobante
            // 
            this.pnlABComprobante.Controls.Add(this.panel6);
            this.pnlABComprobante.Controls.Add(this.panel3);
            this.pnlABComprobante.Controls.Add(this.pnlAltaComprobante);
            this.pnlABComprobante.Location = new System.Drawing.Point(135, 74);
            this.pnlABComprobante.Name = "pnlABComprobante";
            this.pnlABComprobante.Size = new System.Drawing.Size(544, 341);
            this.pnlABComprobante.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.MenuStrip5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 293);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(544, 48);
            this.panel6.TabIndex = 6;
            // 
            // MenuStrip5
            // 
            this.MenuStrip5.AutoSize = false;
            this.MenuStrip5.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip5.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GUARDAR,
            this.GUARDARCAMBIOS,
            this.VOLVEROK});
            this.MenuStrip5.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip5.Location = new System.Drawing.Point(118, 8);
            this.MenuStrip5.Name = "MenuStrip5";
            this.MenuStrip5.ShowItemToolTips = true;
            this.MenuStrip5.Size = new System.Drawing.Size(384, 29);
            this.MenuStrip5.TabIndex = 533;
            this.MenuStrip5.Text = "MenuStrip5";
            // 
            // GUARDAR
            // 
            this.GUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.GUARDAR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GUARDAR.ForeColor = System.Drawing.Color.Black;
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(83, 25);
            this.GUARDAR.Text = "&Guardar";
            this.GUARDAR.ToolTipText = "Guardar ";
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // GUARDARCAMBIOS
            // 
            this.GUARDARCAMBIOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.GUARDARCAMBIOS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GUARDARCAMBIOS.ForeColor = System.Drawing.Color.Black;
            this.GUARDARCAMBIOS.Name = "GUARDARCAMBIOS";
            this.GUARDARCAMBIOS.Size = new System.Drawing.Size(153, 25);
            this.GUARDARCAMBIOS.Text = "&Guardar Cambios";
            this.GUARDARCAMBIOS.Click += new System.EventHandler(this.GUARDARCAMBIOS_Click);
            // 
            // VOLVEROK
            // 
            this.VOLVEROK.BackColor = System.Drawing.Color.Gray;
            this.VOLVEROK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.VOLVEROK.ForeColor = System.Drawing.Color.White;
            this.VOLVEROK.Name = "VOLVEROK";
            this.VOLVEROK.Size = new System.Drawing.Size(82, 25);
            this.VOLVEROK.Text = "VOLVER";
            this.VOLVEROK.Click += new System.EventHandler(this.VOLVEROK_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 42);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(544, 42);
            this.panel5.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alta / Edición de comprobantes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gdvComprobantes
            // 
            this.gdvComprobantes.AllowUserToAddRows = false;
            this.gdvComprobantes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gdvComprobantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvComprobantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvComprobantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.gdvComprobantes.Location = new System.Drawing.Point(12, 6);
            this.gdvComprobantes.Name = "gdvComprobantes";
            this.gdvComprobantes.ReadOnly = true;
            this.gdvComprobantes.RowHeadersVisible = false;
            this.gdvComprobantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvComprobantes.Size = new System.Drawing.Size(694, 230);
            this.gdvComprobantes.TabIndex = 4;
            this.gdvComprobantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvComprobantes_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(598, 103);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(97, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.nuevoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.nuevoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.gdvComprobantes);
            this.panel2.Location = new System.Drawing.Point(33, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 244);
            this.panel2.TabIndex = 6;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(170, 72);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(0, 13);
            this.lblDocumento.TabIndex = 627;
            // 
            // frmComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.pnlABComprobante);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración Comprobante";
            this.Load += new System.EventHandler(this.frmComprobante_Load);
            this.pnlAltaComprobante.ResumeLayout(false);
            this.pnlAltaComprobante.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlABComprobante.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.MenuStrip5.ResumeLayout(false);
            this.MenuStrip5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvComprobantes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAltaComprobante;
        internal System.Windows.Forms.TextBox txtnumerofin;
        internal System.Windows.Forms.TextBox txtSerie;
        internal System.Windows.Forms.TextBox TXTCANTIDADDECEROS;
        internal System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.TextBox txtNombreComprobante;
        private System.Windows.Forms.Panel pnlABComprobante;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.CheckBox checkDefecto;
        internal System.Windows.Forms.MenuStrip MenuStrip5;
        internal System.Windows.Forms.ToolStripMenuItem GUARDAR;
        internal System.Windows.Forms.ToolStripMenuItem GUARDARCAMBIOS;
        internal System.Windows.Forms.ToolStripMenuItem VOLVEROK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gdvComprobantes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDocumento;
    }
}