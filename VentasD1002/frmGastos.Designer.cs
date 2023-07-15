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
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rtbnIngresos = new System.Windows.Forms.RadioButton();
            this.rbtnGastos = new System.Windows.Forms.RadioButton();
            this.chkImprimir = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lbltitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(239, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(288, 55);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Gastos";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle :";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(145, 196);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(268, 26);
            this.txtMonto.TabIndex = 4;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(145, 241);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(268, 59);
            this.txtDetalle.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::VentasD1002.Properties.Resources.azul;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(313, 378);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 41);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::VentasD1002.Properties.Resources.Rojo;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Snow;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(191, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 41);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 112);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el concepto o agregue uno nuevo";
            // 
            // pbAgregar
            // 
            this.pbAgregar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("pbAgregar.Image")));
            this.pbAgregar.Location = new System.Drawing.Point(426, 47);
            this.pbAgregar.Name = "pbAgregar";
            this.pbAgregar.Size = new System.Drawing.Size(39, 35);
            this.pbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgregar.TabIndex = 3;
            this.pbAgregar.TabStop = false;
            this.pbAgregar.Click += new System.EventHandler(this.pbAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(76, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 3);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(85, 55);
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
            this.gdvConcepto.Location = new System.Drawing.Point(85, 157);
            this.gdvConcepto.MultiSelect = false;
            this.gdvConcepto.Name = "gdvConcepto";
            this.gdvConcepto.ReadOnly = true;
            this.gdvConcepto.RowHeadersVisible = false;
            this.gdvConcepto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gdvConcepto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvConcepto.Size = new System.Drawing.Size(347, 193);
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
            this.pnlConcepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConcepto.Location = new System.Drawing.Point(0, 55);
            this.pnlConcepto.Name = "pnlConcepto";
            this.pnlConcepto.Size = new System.Drawing.Size(527, 390);
            this.pnlConcepto.TabIndex = 4;
            // 
            // btnCancelarConcepto
            // 
            this.btnCancelarConcepto.BackgroundImage = global::VentasD1002.Properties.Resources.naranja;
            this.btnCancelarConcepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarConcepto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelarConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarConcepto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarConcepto.ForeColor = System.Drawing.Color.Bisque;
            this.btnCancelarConcepto.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarConcepto.Image")));
            this.btnCancelarConcepto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarConcepto.Location = new System.Drawing.Point(226, 206);
            this.btnCancelarConcepto.Name = "btnCancelarConcepto";
            this.btnCancelarConcepto.Size = new System.Drawing.Size(116, 48);
            this.btnCancelarConcepto.TabIndex = 37;
            this.btnCancelarConcepto.Text = "Cancelar";
            this.btnCancelarConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarConcepto.UseVisualStyleBackColor = true;
            this.btnCancelarConcepto.Click += new System.EventHandler(this.btnCancelarConcepto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::VentasD1002.Properties.Resources.verde;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Ivory;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(348, 206);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 48);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(17, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 3);
            this.panel2.TabIndex = 2;
            // 
            // txtNvoConcepto
            // 
            this.txtNvoConcepto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNvoConcepto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNvoConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNvoConcepto.Location = new System.Drawing.Point(17, 147);
            this.txtNvoConcepto.Name = "txtNvoConcepto";
            this.txtNvoConcepto.Size = new System.Drawing.Size(457, 19);
            this.txtNvoConcepto.TabIndex = 1;
            this.txtNvoConcepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ingrese el  nuevo concepto :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbltitulo);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 55);
            this.panel4.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
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
            // chkImprimir
            // 
            this.chkImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chkImprimir.BackColor = System.Drawing.Color.Transparent;
            this.chkImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkImprimir.BackgroundImage")));
            this.chkImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkImprimir.Font = new System.Drawing.Font("Century Gothic", 6.5F);
            this.chkImprimir.Location = new System.Drawing.Point(85, 323);
            this.chkImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.chkImprimir.Name = "chkImprimir";
            this.chkImprimir.OffColor = System.Drawing.Color.Gray;
            this.chkImprimir.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.chkImprimir.Size = new System.Drawing.Size(35, 20);
            this.chkImprimir.TabIndex = 719;
            this.chkImprimir.Value = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 720;
            this.label1.Text = "Imprimir comprobante";
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(527, 445);
            this.Controls.Add(this.pnlConcepto);
            this.Controls.Add(this.gdvConcepto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkImprimir);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos varios";
            this.Load += new System.EventHandler(this.frmGastos_Load);
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
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDetalle;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rtbnIngresos;
        private System.Windows.Forms.RadioButton rbtnGastos;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private Bunifu.Framework.UI.BunifuiOSSwitch chkImprimir;
        private System.Windows.Forms.Label label1;
    }
}