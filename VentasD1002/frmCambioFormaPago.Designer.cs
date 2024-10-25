using VentasD1002.Properties;

namespace VentasD1002
{
    partial class frmCambioFormaPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambioFormaPago));
            this.pnlEditarPago = new System.Windows.Forms.Panel();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.btnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnContinuar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEditarPago.SuspendLayout();
            this.panel8.SuspendLayout();
            this.menuStrip6.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEditarPago
            // 
            this.pnlEditarPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlEditarPago.Controls.Add(this.label1);
            this.pnlEditarPago.Controls.Add(this.lblMontoTotal);
            this.pnlEditarPago.Controls.Add(this.menuStrip6);
            this.pnlEditarPago.Controls.Add(this.menuStrip2);
            this.pnlEditarPago.Controls.Add(this.label4);
            this.pnlEditarPago.Controls.Add(this.label3);
            this.pnlEditarPago.Controls.Add(this.panel8);
            this.pnlEditarPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditarPago.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEditarPago.Location = new System.Drawing.Point(0, 0);
            this.pnlEditarPago.Name = "pnlEditarPago";
            this.pnlEditarPago.Size = new System.Drawing.Size(662, 325);
            this.pnlEditarPago.TabIndex = 12;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(304, 283);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(66, 31);
            this.lblMontoTotal.TabIndex = 629;
            this.lblMontoTotal.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(163, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "¿Desea continuar?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Está a punto de realizar el cambio de la forma de pago (contado a crédito).";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gold;
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(662, 40);
            this.panel8.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(662, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cambio de forma de pago";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip6
            // 
            this.menuStrip6.AutoSize = false;
            this.menuStrip6.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip6.BackgroundImage = Resources.Rojo;
            this.menuStrip6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip6.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelar});
            this.menuStrip6.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip6.Location = new System.Drawing.Point(125, 172);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.ShowItemToolTips = true;
            this.menuStrip6.Size = new System.Drawing.Size(152, 52);
            this.menuStrip6.TabIndex = 628;
            this.menuStrip6.Text = "menuStrip6";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.btnCancelar.Size = new System.Drawing.Size(129, 48);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.BackgroundImage =Resources.verde;
            this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnContinuar});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(326, 172);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.ShowItemToolTips = true;
            this.menuStrip2.Size = new System.Drawing.Size(156, 52);
            this.menuStrip2.TabIndex = 627;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnContinuar.Image = ((System.Drawing.Image)(resources.GetObject("btnContinuar.Image")));
            this.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.btnContinuar.Size = new System.Drawing.Size(140, 48);
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 630;
            this.label1.Text = "Monto total:";
            // 
            // frmCambioFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 325);
            this.Controls.Add(this.pnlEditarPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCambioFormaPago";
            this.Text = "frmCambioTipoPago";
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

        private System.Windows.Forms.Panel pnlEditarPago;
        private System.Windows.Forms.Label lblMontoTotal;
        internal System.Windows.Forms.MenuStrip menuStrip6;
        private System.Windows.Forms.ToolStripMenuItem btnCancelar;
        internal System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnContinuar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}