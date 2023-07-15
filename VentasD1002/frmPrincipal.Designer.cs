namespace VentasD1002
{
    partial class frmPrincipal
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
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbPerfil = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.linkPerfil = new System.Windows.Forms.LinkLabel();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 97);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(944, 523);
            this.pnlDesktop.TabIndex = 0;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSuperior.Controls.Add(this.lblFecha);
            this.pnlSuperior.Controls.Add(this.lblHora);
            this.pnlSuperior.Controls.Add(this.pictureBox2);
            this.pnlSuperior.Controls.Add(this.panel3);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(944, 97);
            this.pnlSuperior.TabIndex = 1;
            this.pnlSuperior.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(413, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(324, 23);
            this.lblFecha.TabIndex = 22;
            this.lblFecha.Text = "label1";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(97, 34);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(288, 44);
            this.lblHora.TabIndex = 21;
            this.lblHora.Text = "label1";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::VentasD1002.Properties.Resources.JIEL;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbPerfil);
            this.panel3.Controls.Add(this.linkPerfil);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(762, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 97);
            this.panel3.TabIndex = 20;
            // 
            // pbPerfil
            // 
            this.pbPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbPerfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbPerfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbPerfil.BorderSize = 2;
            this.pbPerfil.GradientAngle = 50F;
            this.pbPerfil.Location = new System.Drawing.Point(54, 3);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(66, 66);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 1;
            this.pbPerfil.TabStop = false;
            // 
            // linkPerfil
            // 
            this.linkPerfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkPerfil.Location = new System.Drawing.Point(0, 76);
            this.linkPerfil.Name = "linkPerfil";
            this.linkPerfil.Size = new System.Drawing.Size(182, 21);
            this.linkPerfil.TabIndex = 0;
            this.linkPerfil.TabStop = true;
            this.linkPerfil.Text = "linkLabel1";
            this.linkPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPerfil_LinkClicked);
            // 
            // timerReloj
            // 
            this.timerReloj.Enabled = true;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 620);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbPerfil;
        private System.Windows.Forms.LinkLabel linkPerfil;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.Label lblFecha;
    }
}