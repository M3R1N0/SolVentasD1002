namespace VentasD1002
{
    partial class frmAbonarCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbonarCredito));
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPendienteLiquidar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMontoAbonar = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // bntCancelar
            // 
            this.bntCancelar.BackgroundImage = global::VentasD1002.Properties.Resources.Rojo;
            this.bntCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelar.ForeColor = System.Drawing.Color.MistyRose;
            this.bntCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bntCancelar.Image")));
            this.bntCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntCancelar.Location = new System.Drawing.Point(171, 276);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(123, 49);
            this.bntCancelar.TabIndex = 31;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // btnAbonar
            // 
            this.btnAbonar.BackgroundImage = global::VentasD1002.Properties.Resources.verde;
            this.btnAbonar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonar.ForeColor = System.Drawing.Color.Honeydew;
            this.btnAbonar.Image = ((System.Drawing.Image)(resources.GetObject("btnAbonar.Image")));
            this.btnAbonar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbonar.Location = new System.Drawing.Point(322, 276);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(123, 49);
            this.btnAbonar.TabIndex = 30;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbonar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbonar.UseVisualStyleBackColor = true;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Orange;
            this.panel8.Location = new System.Drawing.Point(260, 228);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(184, 5);
            this.panel8.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(79, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 31);
            this.label12.TabIndex = 29;
            this.label12.Text = "Por liquidar:";
            // 
            // txtPendienteLiquidar
            // 
            this.txtPendienteLiquidar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPendienteLiquidar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPendienteLiquidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendienteLiquidar.Location = new System.Drawing.Point(260, 184);
            this.txtPendienteLiquidar.Name = "txtPendienteLiquidar";
            this.txtPendienteLiquidar.ReadOnly = true;
            this.txtPendienteLiquidar.Size = new System.Drawing.Size(185, 38);
            this.txtPendienteLiquidar.TabIndex = 26;
            this.txtPendienteLiquidar.Text = "0.00";
            this.txtPendienteLiquidar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(728, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 31);
            this.label11.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Orange;
            this.panel7.Location = new System.Drawing.Point(260, 162);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(184, 5);
            this.panel7.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 31);
            this.label9.TabIndex = 23;
            this.label9.Text = "Monto a Abonar:";
            // 
            // txtMontoAbonar
            // 
            this.txtMontoAbonar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMontoAbonar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAbonar.Location = new System.Drawing.Point(260, 118);
            this.txtMontoAbonar.Name = "txtMontoAbonar";
            this.txtMontoAbonar.Size = new System.Drawing.Size(185, 38);
            this.txtMontoAbonar.TabIndex = 24;
            this.txtMontoAbonar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontoAbonar.TextChanged += new System.EventHandler(this.txtMontoAbonar_TextChanged);
            this.txtMontoAbonar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoAbonar_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Orange;
            this.panel6.Location = new System.Drawing.Point(260, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 5);
            this.panel6.TabIndex = 22;
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSaldoActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoActual.Location = new System.Drawing.Point(260, 55);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.ReadOnly = true;
            this.txtSaldoActual.Size = new System.Drawing.Size(185, 38);
            this.txtSaldoActual.TabIndex = 21;
            this.txtSaldoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "Saldo actual:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(10, 10);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Visible = false;
            // 
            // frmAbonarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 345);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.btnAbonar);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPendienteLiquidar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMontoAbonar);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtSaldoActual);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbonarCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abono ventas a crédito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPendienteLiquidar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMontoAbonar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.Label label8;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
    }
}