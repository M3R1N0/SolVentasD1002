namespace VentasD1002
{
    partial class frmGananciasxPeriodo
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
            this.dpInicio = new System.Windows.Forms.DateTimePicker();
            this.dpFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.lblTotalGanancia = new System.Windows.Forms.Label();
            this.lblVentaTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // dpInicio
            // 
            this.dpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpInicio.Location = new System.Drawing.Point(88, 23);
            this.dpInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpInicio.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dpInicio.Name = "dpInicio";
            this.dpInicio.Size = new System.Drawing.Size(122, 27);
            this.dpInicio.TabIndex = 0;
            this.dpInicio.ValueChanged += new System.EventHandler(this.dpInicio_ValueChanged);
            // 
            // dpFin
            // 
            this.dpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFin.Location = new System.Drawing.Point(305, 23);
            this.dpFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpFin.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dpFin.Name = "dpFin";
            this.dpFin.Size = new System.Drawing.Size(128, 27);
            this.dpFin.TabIndex = 1;
            this.dpFin.ValueChanged += new System.EventHandler(this.dpFin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fin:";
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Location = new System.Drawing.Point(30, 84);
            this.gridData.MultiSelect = false;
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersVisible = false;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.Size = new System.Drawing.Size(864, 318);
            this.gridData.TabIndex = 13;
            // 
            // lblTotalGanancia
            // 
            this.lblTotalGanancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalGanancia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalGanancia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalGanancia.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGanancia.Location = new System.Drawing.Point(604, 405);
            this.lblTotalGanancia.Name = "lblTotalGanancia";
            this.lblTotalGanancia.Size = new System.Drawing.Size(290, 37);
            this.lblTotalGanancia.TabIndex = 637;
            this.lblTotalGanancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVentaTotal
            // 
            this.lblVentaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVentaTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblVentaTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVentaTotal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaTotal.Location = new System.Drawing.Point(214, 405);
            this.lblVentaTotal.Name = "lblVentaTotal";
            this.lblVentaTotal.Size = new System.Drawing.Size(239, 37);
            this.lblVentaTotal.TabIndex = 636;
            this.lblVentaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 638;
            this.label3.Text = "Ganancia total:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 639;
            this.label4.Text = "Venta total:";
            // 
            // frmGananciasxPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalGanancia);
            this.Controls.Add(this.lblVentaTotal);
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpFin);
            this.Controls.Add(this.dpInicio);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGananciasxPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganancias por periodo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dpInicio;
        private System.Windows.Forms.DateTimePicker dpFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Label lblTotalGanancia;
        private System.Windows.Forms.Label lblVentaTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}