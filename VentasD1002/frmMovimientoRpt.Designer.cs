namespace VentasD1002
{
    partial class frmMovimientoRpt
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
            this.reportViewerMovimiento = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerMovimiento
            // 
            this.reportViewerMovimiento.AccessibilityKeyMap = null;
            this.reportViewerMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerMovimiento.Location = new System.Drawing.Point(0, 0);
            this.reportViewerMovimiento.Name = "reportViewerMovimiento";
            this.reportViewerMovimiento.Size = new System.Drawing.Size(800, 450);
            this.reportViewerMovimiento.TabIndex = 0;
            // 
            // frmMovimientoRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerMovimiento);
            this.Name = "frmMovimientoRpt";
            this.Text = "frmMovimientoRpt";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmMovimientoRpt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.ReportViewer.WinForms.ReportViewer reportViewerMovimiento;
    }
}