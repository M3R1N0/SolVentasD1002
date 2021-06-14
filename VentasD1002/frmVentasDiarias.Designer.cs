namespace VentasD1002
{
    partial class frmVentasDiarias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasDiarias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSubtotal1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCaja1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBonificacion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblVentaCredito = new System.Windows.Forms.Label();
            this.lblVentaEfectivo = new System.Windows.Forms.Label();
            this.lblFondoCaja = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSubtotal2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblBonificacion2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVentasCredito2 = new System.Windows.Forms.Label();
            this.lblVentasEfectivo2 = new System.Windows.Forms.Label();
            this.lblEfectivoCaja2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblSaldoInicial2 = new System.Windows.Forms.Label();
            this.lblCaja2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 109);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(917, 51);
            this.panel7.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(917, 51);
            this.label2.TabIndex = 0;
            this.label2.Text = "VENTAS POR DÍA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(222, 60);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(160, 40);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSubtotal1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblCaja1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 289);
            this.panel2.TabIndex = 1;
            // 
            // lblSubtotal1
            // 
            this.lblSubtotal1.AutoSize = true;
            this.lblSubtotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal1.Location = new System.Drawing.Point(240, 249);
            this.lblSubtotal1.Name = "lblSubtotal1";
            this.lblSubtotal1.Size = new System.Drawing.Size(50, 25);
            this.lblSubtotal1.TabIndex = 10;
            this.lblSubtotal1.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "SubTotal :";
            // 
            // lblCaja1
            // 
            this.lblCaja1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblCaja1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCaja1.Location = new System.Drawing.Point(0, 0);
            this.lblCaja1.Name = "lblCaja1";
            this.lblCaja1.Size = new System.Drawing.Size(460, 41);
            this.lblCaja1.TabIndex = 21;
            this.lblCaja1.Text = "Caja 1";
            this.lblCaja1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblBonificacion);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.lblVentaCredito);
            this.panel5.Controls.Add(this.lblVentaEfectivo);
            this.panel5.Controls.Add(this.lblFondoCaja);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lblSaldoInicial);
            this.panel5.Location = new System.Drawing.Point(42, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 173);
            this.panel5.TabIndex = 1;
            // 
            // lblBonificacion
            // 
            this.lblBonificacion.AutoSize = true;
            this.lblBonificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonificacion.Location = new System.Drawing.Point(198, 9);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(50, 25);
            this.lblBonificacion.TabIndex = 9;
            this.lblBonificacion.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Bonificaciones  :";
            // 
            // lblVentaCredito
            // 
            this.lblVentaCredito.AutoSize = true;
            this.lblVentaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaCredito.Location = new System.Drawing.Point(198, 124);
            this.lblVentaCredito.Name = "lblVentaCredito";
            this.lblVentaCredito.Size = new System.Drawing.Size(50, 25);
            this.lblVentaCredito.TabIndex = 5;
            this.lblVentaCredito.Text = "0.00";
            // 
            // lblVentaEfectivo
            // 
            this.lblVentaEfectivo.AutoSize = true;
            this.lblVentaEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaEfectivo.Location = new System.Drawing.Point(198, 84);
            this.lblVentaEfectivo.Name = "lblVentaEfectivo";
            this.lblVentaEfectivo.Size = new System.Drawing.Size(50, 25);
            this.lblVentaEfectivo.TabIndex = 4;
            this.lblVentaEfectivo.Text = "0.00";
            // 
            // lblFondoCaja
            // 
            this.lblFondoCaja.AutoSize = true;
            this.lblFondoCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFondoCaja.Location = new System.Drawing.Point(198, 44);
            this.lblFondoCaja.Name = "lblFondoCaja";
            this.lblFondoCaja.Size = new System.Drawing.Size(50, 25);
            this.lblFondoCaja.TabIndex = 3;
            this.lblFondoCaja.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ventas a crédito : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ventas  en efectivo :";
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.AutoSize = true;
            this.lblSaldoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoInicial.Location = new System.Drawing.Point(12, 48);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(171, 20);
            this.lblSaldoInicial.TabIndex = 1;
            this.lblSaldoInicial.Text = "Efectivo inicial en caja :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSubtotal2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.lblCaja2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(460, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 289);
            this.panel3.TabIndex = 2;
            // 
            // lblSubtotal2
            // 
            this.lblSubtotal2.AutoSize = true;
            this.lblSubtotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal2.Location = new System.Drawing.Point(245, 250);
            this.lblSubtotal2.Name = "lblSubtotal2";
            this.lblSubtotal2.Size = new System.Drawing.Size(50, 25);
            this.lblSubtotal2.TabIndex = 22;
            this.lblSubtotal2.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "SubTotal:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblBonificacion2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.lblVentasCredito2);
            this.panel6.Controls.Add(this.lblVentasEfectivo2);
            this.panel6.Controls.Add(this.lblEfectivoCaja2);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.lblSaldoInicial2);
            this.panel6.Location = new System.Drawing.Point(47, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(374, 173);
            this.panel6.TabIndex = 21;
            // 
            // lblBonificacion2
            // 
            this.lblBonificacion2.AutoSize = true;
            this.lblBonificacion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonificacion2.Location = new System.Drawing.Point(198, 9);
            this.lblBonificacion2.Name = "lblBonificacion2";
            this.lblBonificacion2.Size = new System.Drawing.Size(50, 25);
            this.lblBonificacion2.TabIndex = 9;
            this.lblBonificacion2.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bonificaciones  :";
            // 
            // lblVentasCredito2
            // 
            this.lblVentasCredito2.AutoSize = true;
            this.lblVentasCredito2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasCredito2.Location = new System.Drawing.Point(198, 124);
            this.lblVentasCredito2.Name = "lblVentasCredito2";
            this.lblVentasCredito2.Size = new System.Drawing.Size(50, 25);
            this.lblVentasCredito2.TabIndex = 5;
            this.lblVentasCredito2.Text = "0.00";
            // 
            // lblVentasEfectivo2
            // 
            this.lblVentasEfectivo2.AutoSize = true;
            this.lblVentasEfectivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasEfectivo2.Location = new System.Drawing.Point(198, 84);
            this.lblVentasEfectivo2.Name = "lblVentasEfectivo2";
            this.lblVentasEfectivo2.Size = new System.Drawing.Size(50, 25);
            this.lblVentasEfectivo2.TabIndex = 4;
            this.lblVentasEfectivo2.Text = "0.00";
            // 
            // lblEfectivoCaja2
            // 
            this.lblEfectivoCaja2.AutoSize = true;
            this.lblEfectivoCaja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivoCaja2.Location = new System.Drawing.Point(198, 44);
            this.lblEfectivoCaja2.Name = "lblEfectivoCaja2";
            this.lblEfectivoCaja2.Size = new System.Drawing.Size(50, 25);
            this.lblEfectivoCaja2.TabIndex = 3;
            this.lblEfectivoCaja2.Text = "0.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(46, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 20);
            this.label19.TabIndex = 3;
            this.label19.Text = "Ventas a crédito : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(30, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 20);
            this.label20.TabIndex = 2;
            this.label20.Text = "Ventas  en efectivo :";
            // 
            // lblSaldoInicial2
            // 
            this.lblSaldoInicial2.AutoSize = true;
            this.lblSaldoInicial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoInicial2.Location = new System.Drawing.Point(12, 48);
            this.lblSaldoInicial2.Name = "lblSaldoInicial2";
            this.lblSaldoInicial2.Size = new System.Drawing.Size(171, 20);
            this.lblSaldoInicial2.TabIndex = 1;
            this.lblSaldoInicial2.Text = "Efectivo inicial en caja :";
            // 
            // lblCaja2
            // 
            this.lblCaja2.BackColor = System.Drawing.Color.SeaGreen;
            this.lblCaja2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCaja2.Location = new System.Drawing.Point(0, 0);
            this.lblCaja2.Name = "lblCaja2";
            this.lblCaja2.Size = new System.Drawing.Size(457, 41);
            this.lblCaja2.TabIndex = 20;
            this.lblCaja2.Text = "Caja 2";
            this.lblCaja2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(917, 59);
            this.panel4.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(457, 4);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 55);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(270, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 55);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total :";
            // 
            // frmVentasDiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 457);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentasDiarias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas Diarias";
            this.Load += new System.EventHandler(this.frmVentasDiarias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBonificacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblVentaCredito;
        private System.Windows.Forms.Label lblVentaEfectivo;
        private System.Windows.Forms.Label lblFondoCaja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSaldoInicial;
        private System.Windows.Forms.Label lblCaja1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblBonificacion2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVentasCredito2;
        private System.Windows.Forms.Label lblVentasEfectivo2;
        private System.Windows.Forms.Label lblEfectivoCaja2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblSaldoInicial2;
        private System.Windows.Forms.Label lblCaja2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubtotal1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubtotal2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
    }
}