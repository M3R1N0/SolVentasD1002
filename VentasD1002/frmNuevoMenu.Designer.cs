namespace VentasD1002
{
    partial class frmNuevoMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargarLogo = new System.Windows.Forms.Button();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.cancelarVentaF9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargarLogo);
            this.groupBox1.Controls.Add(this.menuStrip6);
            this.groupBox1.Controls.Add(this.pbLogo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(467, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnCargarLogo
            // 
            this.btnCargarLogo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarLogo.Location = new System.Drawing.Point(333, 136);
            this.btnCargarLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarLogo.Name = "btnCargarLogo";
            this.btnCargarLogo.Size = new System.Drawing.Size(92, 23);
            this.btnCargarLogo.TabIndex = 632;
            this.btnCargarLogo.Text = "Cargar logo ...";
            this.btnCargarLogo.UseVisualStyleBackColor = true;
            this.btnCargarLogo.Click += new System.EventHandler(this.btnCargarLogo_Click);
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
            this.menuStrip6.Location = new System.Drawing.Point(204, 128);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip6.ShowItemToolTips = true;
            this.menuStrip6.Size = new System.Drawing.Size(87, 40);
            this.menuStrip6.TabIndex = 631;
            this.menuStrip6.Text = "menuStrip6";
            // 
            // cancelarVentaF9ToolStripMenuItem
            // 
            this.cancelarVentaF9ToolStripMenuItem.BackgroundImage = global::VentasD1002.Properties.Resources.verde;
            this.cancelarVentaF9ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelarVentaF9ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarVentaF9ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelarVentaF9ToolStripMenuItem.Name = "cancelarVentaF9ToolStripMenuItem";
            this.cancelarVentaF9ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.cancelarVentaF9ToolStripMenuItem.Size = new System.Drawing.Size(76, 34);
            this.cancelarVentaF9ToolStripMenuItem.Text = "Guardar";
            this.cancelarVentaF9ToolStripMenuItem.Click += new System.EventHandler(this.cancelarVentaF9ToolStripMenuItem_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbLogo.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbLogo.BorderColor2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbLogo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbLogo.BorderSize = 2;
            this.pbLogo.GradientAngle = 50F;
            this.pbLogo.Location = new System.Drawing.Point(332, 35);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(93, 93);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(23, 67);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(269, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // frmNuevoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 219);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNuevoMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Menú";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCargarLogo;
        internal System.Windows.Forms.MenuStrip menuStrip6;
        private System.Windows.Forms.ToolStripMenuItem cancelarVentaF9ToolStripMenuItem;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbLogo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}