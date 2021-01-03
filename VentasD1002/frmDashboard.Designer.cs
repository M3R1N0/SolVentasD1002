namespace VentasD1002
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 67);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNotificacion);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Controls.Add(this.pbPerfil);
            this.panel2.Controls.Add(this.menuStrip3);
            this.panel2.Controls.Add(this.menuStrip5);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(730, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 67);
            this.panel2.TabIndex = 1;
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.AutoSize = true;
            this.lblNotificacion.BackColor = System.Drawing.Color.Red;
            this.lblNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacion.ForeColor = System.Drawing.Color.White;
            this.lblNotificacion.Location = new System.Drawing.Point(284, 23);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(21, 13);
            this.lblNotificacion.TabIndex = 10;
            this.lblNotificacion.Text = "10";
            // 
            // pbPerfil
            // 
            this.pbPerfil.Location = new System.Drawing.Point(352, 7);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(56, 52);
            this.pbPerfil.TabIndex = 0;
            this.pbPerfil.TabStop = false;
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip3.Location = new System.Drawing.Point(150, 26);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(50, 29);
            this.menuStrip3.TabIndex = 7;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(42, 25);
            this.toolStripMenuItem2.Text = " ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // menuStrip5
            // 
            this.menuStrip5.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip5.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.menuStrip5.Location = new System.Drawing.Point(197, 25);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(50, 29);
            this.menuStrip5.TabIndex = 8;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(42, 25);
            this.toolStripMenuItem4.Text = " ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(263, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVentas});
            this.menuStrip1.Location = new System.Drawing.Point(10, 23);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(107, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(99, 25);
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1147, 510);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnVentas;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblNotificacion;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}