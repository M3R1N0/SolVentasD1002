namespace VentasD1002
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaActivacion = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.flowLayoutPanelUsuarios = new System.Windows.Forms.FlowLayoutPanel();
            this.panelIniciarSesion = new System.Windows.Forms.Panel();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnOlvidasteContraseña = new System.Windows.Forms.Button();
            this.btnCambiarUsuario = new System.Windows.Forms.Button();
            this.MenuStrip15 = new System.Windows.Forms.MenuStrip();
            this.tver = new System.Windows.Forms.ToolStripMenuItem();
            this.tocultar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.flowLayoutPanelUsuarios.SuspendLayout();
            this.panelIniciarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuStrip15.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFechaActivacion);
            this.panel1.Controls.Add(this.dtpVencimiento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 365);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 612;
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 612;
            this.label2.Visible = false;
            // 
            // dtpFechaActivacion
            // 
            this.dtpFechaActivacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaActivacion.Location = new System.Drawing.Point(3, 52);
            this.dtpFechaActivacion.Name = "dtpFechaActivacion";
            this.dtpFechaActivacion.Size = new System.Drawing.Size(110, 20);
            this.dtpFechaActivacion.TabIndex = 612;
            this.dtpFechaActivacion.Visible = false;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(3, 85);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(110, 20);
            this.dtpVencimiento.TabIndex = 612;
            this.dtpVencimiento.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(116, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 68);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(54)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡ B I E N V E N I D O ! ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.Controls.Add(this.flowLayoutPanelUsuarios);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuarios.Location = new System.Drawing.Point(116, 68);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(571, 297);
            this.panelUsuarios.TabIndex = 2;
            // 
            // flowLayoutPanelUsuarios
            // 
            this.flowLayoutPanelUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(54)))));
            this.flowLayoutPanelUsuarios.Controls.Add(this.panelIniciarSesion);
            this.flowLayoutPanelUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelUsuarios.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelUsuarios.Name = "flowLayoutPanelUsuarios";
            this.flowLayoutPanelUsuarios.Size = new System.Drawing.Size(571, 297);
            this.flowLayoutPanelUsuarios.TabIndex = 0;
            // 
            // panelIniciarSesion
            // 
            this.panelIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(54)))));
            this.panelIniciarSesion.Controls.Add(this.lblLicencia);
            this.panelIniciarSesion.Controls.Add(this.pictureBox1);
            this.panelIniciarSesion.Controls.Add(this.panel6);
            this.panelIniciarSesion.Controls.Add(this.btnOlvidasteContraseña);
            this.panelIniciarSesion.Controls.Add(this.btnCambiarUsuario);
            this.panelIniciarSesion.Controls.Add(this.MenuStrip15);
            this.panelIniciarSesion.Controls.Add(this.txtContraseña);
            this.panelIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.panelIniciarSesion.Location = new System.Drawing.Point(3, 3);
            this.panelIniciarSesion.Name = "panelIniciarSesion";
            this.panelIniciarSesion.Size = new System.Drawing.Size(568, 294);
            this.panelIniciarSesion.TabIndex = 0;
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencia.Location = new System.Drawing.Point(134, 269);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(60, 17);
            this.lblLicencia.TabIndex = 613;
            this.lblLicencia.Text = "Licencia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 612;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.panel6.Location = new System.Drawing.Point(147, 109);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(210, 1);
            this.panel6.TabIndex = 611;
            // 
            // btnOlvidasteContraseña
            // 
            this.btnOlvidasteContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(54)))));
            this.btnOlvidasteContraseña.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(54)))));
            this.btnOlvidasteContraseña.FlatAppearance.BorderSize = 0;
            this.btnOlvidasteContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlvidasteContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlvidasteContraseña.Location = new System.Drawing.Point(129, 144);
            this.btnOlvidasteContraseña.Name = "btnOlvidasteContraseña";
            this.btnOlvidasteContraseña.Size = new System.Drawing.Size(229, 28);
            this.btnOlvidasteContraseña.TabIndex = 610;
            this.btnOlvidasteContraseña.Text = "¿Olvidaste tu contraseña?";
            this.btnOlvidasteContraseña.UseVisualStyleBackColor = false;
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(54)))));
            this.btnCambiarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(54)))));
            this.btnCambiarUsuario.FlatAppearance.BorderSize = 0;
            this.btnCambiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarUsuario.Location = new System.Drawing.Point(155, 120);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(171, 28);
            this.btnCambiarUsuario.TabIndex = 609;
            this.btnCambiarUsuario.Text = "Cambiar de usuario";
            this.btnCambiarUsuario.UseVisualStyleBackColor = false;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.btnCambiarUsuario_Click);
            // 
            // MenuStrip15
            // 
            this.MenuStrip15.AutoSize = false;
            this.MenuStrip15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(54)))));
            this.MenuStrip15.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip15.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tver,
            this.tocultar});
            this.MenuStrip15.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip15.Location = new System.Drawing.Point(325, 85);
            this.MenuStrip15.Name = "MenuStrip15";
            this.MenuStrip15.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip15.ShowItemToolTips = true;
            this.MenuStrip15.Size = new System.Drawing.Size(66, 22);
            this.MenuStrip15.TabIndex = 608;
            this.MenuStrip15.Text = "MenuStrip15";
            // 
            // tver
            // 
            this.tver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(54)))));
            this.tver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.tver.Image = ((System.Drawing.Image)(resources.GetObject("tver.Image")));
            this.tver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tver.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.tver.Name = "tver";
            this.tver.Size = new System.Drawing.Size(28, 18);
            this.tver.ToolTipText = "Ver contraseña";
            this.tver.Click += new System.EventHandler(this.tver_Click);
            // 
            // tocultar
            // 
            this.tocultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(54)))));
            this.tocultar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tocultar.ForeColor = System.Drawing.Color.Black;
            this.tocultar.Image = ((System.Drawing.Image)(resources.GetObject("tocultar.Image")));
            this.tocultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tocultar.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tocultar.Name = "tocultar";
            this.tocultar.Size = new System.Drawing.Size(28, 18);
            this.tocultar.ToolTipText = "Ocultar contraseña";
            this.tocultar.Visible = false;
            this.tocultar.Click += new System.EventHandler(this.tocultar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(54)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.txtContraseña.Location = new System.Drawing.Point(129, 85);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(245, 22);
            this.txtContraseña.TabIndex = 605;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(687, 365);
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelUsuarios.ResumeLayout(false);
            this.flowLayoutPanelUsuarios.ResumeLayout(false);
            this.panelIniciarSesion.ResumeLayout(false);
            this.panelIniciarSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuStrip15.ResumeLayout(false);
            this.MenuStrip15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUsuarios;
        private System.Windows.Forms.Panel panelIniciarSesion;
        internal System.Windows.Forms.MenuStrip MenuStrip15;
        internal System.Windows.Forms.ToolStripMenuItem tver;
        internal System.Windows.Forms.ToolStripMenuItem tocultar;
        internal System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnOlvidasteContraseña;
        private System.Windows.Forms.Button btnCambiarUsuario;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DateTimePicker dtpFechaActivacion;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

