namespace VentasD1002
{
    partial class frmCobrar
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
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoNota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dpLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.cancelarVentaF9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.menuStrip6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tipo de nota:";
            // 
            // cboTipoNota
            // 
            this.cboTipoNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoNota.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoNota.FormattingEnabled = true;
            this.cboTipoNota.Location = new System.Drawing.Point(159, 22);
            this.cboTipoNota.Name = "cboTipoNota";
            this.cboTipoNota.Size = new System.Drawing.Size(182, 26);
            this.cboTipoNota.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total:";
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCambio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.ForeColor = System.Drawing.Color.Black;
            this.txtCambio.Location = new System.Drawing.Point(46, 249);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(213, 54);
            this.txtCambio.TabIndex = 22;
            this.txtCambio.Text = "0.00";
            this.txtCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(46, 81);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(213, 54);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecibo
            // 
            this.txtRecibo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRecibo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecibo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibo.ForeColor = System.Drawing.Color.Black;
            this.txtRecibo.Location = new System.Drawing.Point(46, 162);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(213, 54);
            this.txtRecibo.TabIndex = 21;
            this.txtRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecibo.TextChanged += new System.EventHandler(this.txtRecibo_TextChanged);
            this.txtRecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecibo_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(46, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 6);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(46, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 6);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Location = new System.Drawing.Point(46, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 6);
            this.panel3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Recibo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cambio:";
            // 
            // dpLiquidacion
            // 
            this.dpLiquidacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpLiquidacion.Location = new System.Drawing.Point(330, 111);
            this.dpLiquidacion.Name = "dpLiquidacion";
            this.dpLiquidacion.Size = new System.Drawing.Size(137, 26);
            this.dpLiquidacion.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha liquidación:";
            // 
            // menuStrip6
            // 
            this.menuStrip6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip6.AutoSize = false;
            this.menuStrip6.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip6.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarVentaF9ToolStripMenuItem});
            this.menuStrip6.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip6.Location = new System.Drawing.Point(311, 155);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.ShowItemToolTips = true;
            this.menuStrip6.Size = new System.Drawing.Size(149, 61);
            this.menuStrip6.TabIndex = 630;
            this.menuStrip6.Text = "menuStrip6";
            // 
            // cancelarVentaF9ToolStripMenuItem
            // 
            this.cancelarVentaF9ToolStripMenuItem.BackgroundImage = global::VentasD1002.Properties.Resources.verde;
            this.cancelarVentaF9ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelarVentaF9ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.cancelarVentaF9ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelarVentaF9ToolStripMenuItem.Name = "cancelarVentaF9ToolStripMenuItem";
            this.cancelarVentaF9ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.cancelarVentaF9ToolStripMenuItem.Size = new System.Drawing.Size(141, 57);
            this.cancelarVentaF9ToolStripMenuItem.Text = "Procesar venta";
            this.cancelarVentaF9ToolStripMenuItem.Click += new System.EventHandler(this.cancelarVentaF9ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(317, 229);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(132, 64);
            this.menuStrip1.TabIndex = 631;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackgroundImage = global::VentasD1002.Properties.Resources.negro;
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 60);
            this.toolStripMenuItem1.Text = "Venta rápida";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.DarkOrange;
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(0, 333);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(494, 36);
            this.lblMensaje.TabIndex = 632;
            this.lblMensaje.Text = "LA NOTA SE PROCESARÁ COMO VENTA A CRÉDITO YA QUE EL MONTO RECIBIDO NO CUBRE CON E" +
    "L TOTAL DE LA VENTA";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Location = new System.Drawing.Point(453, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(29, 14);
            this.reportViewer1.TabIndex = 633;
            this.reportViewer1.Visible = false;
            // 
            // frmCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 369);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip6);
            this.Controls.Add(this.dpLiquidacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipoNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cobrar";
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCambio;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpLiquidacion;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.MenuStrip menuStrip6;
        private System.Windows.Forms.ToolStripMenuItem cancelarVentaF9ToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblMensaje;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
    }
}