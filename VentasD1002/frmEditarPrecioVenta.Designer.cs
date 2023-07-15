namespace VentasD1002
{
    partial class frmEditarPrecioVenta
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
            this.txtPrecioPreferencial = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioMenudeo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioPreferencial)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrecioPreferencial
            // 
            this.txtPrecioPreferencial.DecimalPlaces = 2;
            this.txtPrecioPreferencial.Font = new System.Drawing.Font("Microsoft YaHei", 50F, System.Drawing.FontStyle.Bold);
            this.txtPrecioPreferencial.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPrecioPreferencial.Location = new System.Drawing.Point(22, 69);
            this.txtPrecioPreferencial.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txtPrecioPreferencial.Name = "txtPrecioPreferencial";
            this.txtPrecioPreferencial.Size = new System.Drawing.Size(431, 95);
            this.txtPrecioPreferencial.TabIndex = 4;
            this.txtPrecioPreferencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioPreferencial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioPreferencial_KeyPress);
            // 
            // lblPrecioMenudeo
            // 
            this.lblPrecioMenudeo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrecioMenudeo.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
            this.lblPrecioMenudeo.Location = new System.Drawing.Point(0, 0);
            this.lblPrecioMenudeo.Name = "lblPrecioMenudeo";
            this.lblPrecioMenudeo.Size = new System.Drawing.Size(476, 66);
            this.lblPrecioMenudeo.TabIndex = 5;
            this.lblPrecioMenudeo.Text = "INGRESE EL PRECIO";
            this.lblPrecioMenudeo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEditarPrecioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 212);
            this.Controls.Add(this.txtPrecioPreferencial);
            this.Controls.Add(this.lblPrecioMenudeo);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarPrecioVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIO DE PRECIOS";
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioPreferencial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown txtPrecioPreferencial;
        private System.Windows.Forms.Label lblPrecioMenudeo;
    }
}