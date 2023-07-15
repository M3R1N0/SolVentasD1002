namespace VentasD1002
{
    partial class frmCierreCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCierreCaja));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.Regresar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.llblCajaTotal = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTTOTALREAL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip6.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(715, 254);
            this.dataGridView1.TabIndex = 2;
            // 
            // menuStrip6
            // 
            this.menuStrip6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip6.AutoSize = false;
            this.menuStrip6.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip6.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Regresar});
            this.menuStrip6.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip6.Location = new System.Drawing.Point(12, 337);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.ShowItemToolTips = true;
            this.menuStrip6.Size = new System.Drawing.Size(134, 56);
            this.menuStrip6.TabIndex = 631;
            this.menuStrip6.Text = "menuStrip6";
            // 
            // Regresar
            // 
            this.Regresar.BackgroundImage = global::VentasD1002.Properties.Resources.azul;
            this.Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Regresar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Regresar.ForeColor = System.Drawing.Color.Lavender;
            this.Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Regresar.Image")));
            this.Regresar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Regresar.Name = "Regresar";
            this.Regresar.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.Regresar.Size = new System.Drawing.Size(125, 52);
            this.Regresar.Text = "Regresar";
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cerrar});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(146, 337);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.ShowItemToolTips = true;
            this.menuStrip2.Size = new System.Drawing.Size(114, 56);
            this.menuStrip2.TabIndex = 630;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Cerrar
            // 
            this.Cerrar.BackgroundImage = global::VentasD1002.Properties.Resources.verde;
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.Color.Honeydew;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Cerrar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.Cerrar.Size = new System.Drawing.Size(104, 52);
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 34);
            this.label1.TabIndex = 632;
            this.label1.Text = "SALDO TOTAL EN CAJA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llblCajaTotal
            // 
            this.llblCajaTotal.BackColor = System.Drawing.Color.White;
            this.llblCajaTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.llblCajaTotal.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCajaTotal.Location = new System.Drawing.Point(521, 358);
            this.llblCajaTotal.Name = "llblCajaTotal";
            this.llblCajaTotal.Size = new System.Drawing.Size(209, 44);
            this.llblCajaTotal.TabIndex = 633;
            this.llblCajaTotal.Text = "0";
            this.llblCajaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 27);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(395, 37);
            this.lblNombreUsuario.TabIndex = 634;
            this.lblNombreUsuario.Text = "Cierre de caja: ";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaCierre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaCierre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCierre.Location = new System.Drawing.Point(413, 27);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(317, 37);
            this.lblFechaCierre.TabIndex = 635;
            this.lblFechaCierre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 34);
            this.label3.TabIndex = 636;
            this.label3.Text = "TOTAL REAL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXTTOTALREAL
            // 
            this.TXTTOTALREAL.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTTOTALREAL.Location = new System.Drawing.Point(306, 358);
            this.TXTTOTALREAL.Name = "TXTTOTALREAL";
            this.TXTTOTALREAL.Size = new System.Drawing.Size(209, 46);
            this.TXTTOTALREAL.TabIndex = 637;
            this.TXTTOTALREAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTTOTALREAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTTOTALREAL_KeyPress);
            // 
            // frmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(753, 423);
            this.ControlBox = false;
            this.Controls.Add(this.TXTTOTALREAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFechaCierre);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.llblCajaTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip6);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCierreCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCierreCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.MenuStrip menuStrip6;
        private System.Windows.Forms.ToolStripMenuItem Regresar;
        internal System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label llblCajaTotal;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTTOTALREAL;
    }
}