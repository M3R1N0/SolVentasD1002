namespace VentasD1002
{
    partial class frmVistaPreviaTickek
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
            this.pnlMostrarTicket = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label32 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.pnlMostrarTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMostrarTicket
            // 
            this.pnlMostrarTicket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMostrarTicket.Controls.Add(this.pictureBox5);
            this.pnlMostrarTicket.Controls.Add(this.label32);
            this.pnlMostrarTicket.Controls.Add(this.reportViewer2);
            this.pnlMostrarTicket.Location = new System.Drawing.Point(0, 2);
            this.pnlMostrarTicket.Name = "pnlMostrarTicket";
            this.pnlMostrarTicket.Size = new System.Drawing.Size(703, 541);
            this.pnlMostrarTicket.TabIndex = 618;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox5.Location = new System.Drawing.Point(410, 200);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(293, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // label32
            // 
            this.label32.Dock = System.Windows.Forms.DockStyle.Top;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label32.Location = new System.Drawing.Point(410, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(293, 200);
            this.label32.TabIndex = 1;
            this.label32.Text = "VENTA REALIZADA CORRECTAMENTE";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer2
            // 
            this.reportViewer2.AccessibilityKeyMap = null;
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Left;
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(410, 541);
            this.reportViewer2.TabIndex = 0;
            // 
            // frmVistaPreviaTickek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 598);
            this.Controls.Add(this.pnlMostrarTicket);
            this.Name = "frmVistaPreviaTickek";
            this.Text = "frmVistaPreviaTickek";
            this.pnlMostrarTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMostrarTicket;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label32;
        public Telerik.ReportViewer.WinForms.ReportViewer reportViewer2;
    }
}