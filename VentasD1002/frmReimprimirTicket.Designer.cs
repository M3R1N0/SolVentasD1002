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
            this.rbTicket = new System.Windows.Forms.RadioButton();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvListado)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlBuscarPorCLiente.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnFiltroFechas);
            this.panel1.Controls.Add(this.rbtnFiltroCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 54);
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
            this.label1.Size = new System.Drawing.Size(946, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Tickets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
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
            this.panel4.Controls.Add(this.rbTicket);
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
            this.rbA4.Location = new System.Drawing.Point(585, 16);
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
            this.RbtnMod2.Location = new System.Drawing.Point(484, 16);
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
            // rbTicket
            // 
            this.rbTicket.AutoSize = true;
            this.rbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTicket.Location = new System.Drawing.Point(388, 16);
            this.rbTicket.Name = "rbTicket";
            this.rbTicket.Size = new System.Drawing.Size(90, 24);
            this.rbTicket.TabIndex = 12;
            this.rbTicket.Text = "Ticket 1";
            this.rbTicket.UseVisualStyleBackColor = true;
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
            this.panel3.Size = new System.Drawing.Size(295, 481);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.reportViewer1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 424);
            this.panel6.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(295, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 57);
            this.panel5.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnImprimir);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(154, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(141, 57);
            this.panel7.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(9, 22);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 32);
            this.btnImprimir.TabIndex = 17;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmReimprimirTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 535);
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
        private System.Windows.Forms.RadioButton rbTicket;
        private System.Windows.Forms.RadioButton rbnFiltroFechas;
        private System.Windows.Forms.RadioButton rbtnFiltroCliente;
        private System.Windows.Forms.Panel pnlBuscarPorCLiente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.RadioButton RbtnMod2;
    }
}