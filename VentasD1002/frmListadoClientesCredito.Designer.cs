namespace VentasD1002
{
    partial class frmListadoClientesCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoClientesCredito));
            this.pnlListadoClienteCredito = new System.Windows.Forms.Panel();
            this.gdvTotalCredito = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlListadoClienteCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTotalCredito)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlListadoClienteCredito
            // 
            this.pnlListadoClienteCredito.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlListadoClienteCredito.Controls.Add(this.gdvTotalCredito);
            this.pnlListadoClienteCredito.Controls.Add(this.panel11);
            this.pnlListadoClienteCredito.Controls.Add(this.panel10);
            this.pnlListadoClienteCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListadoClienteCredito.Location = new System.Drawing.Point(0, 0);
            this.pnlListadoClienteCredito.Name = "pnlListadoClienteCredito";
            this.pnlListadoClienteCredito.Size = new System.Drawing.Size(800, 450);
            this.pnlListadoClienteCredito.TabIndex = 21;
            // 
            // gdvTotalCredito
            // 
            this.gdvTotalCredito.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gdvTotalCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvTotalCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvTotalCredito.Location = new System.Drawing.Point(0, 66);
            this.gdvTotalCredito.Name = "gdvTotalCredito";
            this.gdvTotalCredito.Size = new System.Drawing.Size(800, 384);
            this.gdvTotalCredito.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 36);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(800, 30);
            this.panel11.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Orange;
            this.panel10.Controls.Add(this.pictureBox2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(800, 36);
            this.panel10.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(755, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmListadoClientesCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlListadoClienteCredito);
            this.Name = "frmListadoClientesCredito";
            this.Text = "frmListadoClientesCredito";
            this.Load += new System.EventHandler(this.frmListadoClientesCredito_Load);
            this.pnlListadoClienteCredito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvTotalCredito)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListadoClienteCredito;
        private System.Windows.Forms.DataGridView gdvTotalCredito;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}