﻿namespace VentasD1002
{
    partial class frmVistaNotaRemision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaNotaRemision));
            this.viewerNotas = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // viewerNotas
            // 
            this.viewerNotas.AccessibilityKeyMap = null;
            this.viewerNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerNotas.Location = new System.Drawing.Point(0, 0);
            this.viewerNotas.Name = "viewerNotas";
            this.viewerNotas.Size = new System.Drawing.Size(800, 450);
            this.viewerNotas.TabIndex = 0;
            // 
            // frmVistaNotaRemision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewerNotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVistaNotaRemision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Previa Nota";
            this.Load += new System.EventHandler(this.frmVistaNotaRemision_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Telerik.ReportViewer.WinForms.ReportViewer viewerNotas;
    }
}