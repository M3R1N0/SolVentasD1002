namespace VentasD1002
{
    partial class frmInventarioKardex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventarioKardex));
            this.tbStocks = new System.Windows.Forms.TabControl();
            this.tabStocksBajos = new System.Windows.Forms.TabPage();
            this.gridStockBajos = new System.Windows.Forms.DataGridView();
            this.tabCaducados = new System.Windows.Forms.TabPage();
            this.gridCaducados = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.rbtnCaducados = new RJCodeAdvance.RJControls.RJRadioButton();
            this.rbtnPorCaducar = new RJCodeAdvance.RJControls.RJRadioButton();
            this.tbStocks.SuspendLayout();
            this.tabStocksBajos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockBajos)).BeginInit();
            this.tabCaducados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCaducados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tbStocks
            // 
            this.tbStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStocks.Controls.Add(this.tabStocksBajos);
            this.tbStocks.Controls.Add(this.tabCaducados);
            this.tbStocks.Location = new System.Drawing.Point(12, 108);
            this.tbStocks.Name = "tbStocks";
            this.tbStocks.SelectedIndex = 0;
            this.tbStocks.Size = new System.Drawing.Size(902, 394);
            this.tbStocks.TabIndex = 0;
            this.tbStocks.SelectedIndexChanged += new System.EventHandler(this.tbStocks_SelectedIndexChanged);
            // 
            // tabStocksBajos
            // 
            this.tabStocksBajos.Controls.Add(this.gridStockBajos);
            this.tabStocksBajos.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStocksBajos.Location = new System.Drawing.Point(4, 22);
            this.tabStocksBajos.Name = "tabStocksBajos";
            this.tabStocksBajos.Padding = new System.Windows.Forms.Padding(3);
            this.tabStocksBajos.Size = new System.Drawing.Size(894, 368);
            this.tabStocksBajos.TabIndex = 0;
            this.tabStocksBajos.Text = "Stocks bajos";
            this.tabStocksBajos.UseVisualStyleBackColor = true;
            // 
            // gridStockBajos
            // 
            this.gridStockBajos.AllowUserToAddRows = false;
            this.gridStockBajos.AllowUserToDeleteRows = false;
            this.gridStockBajos.AllowUserToResizeRows = false;
            this.gridStockBajos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridStockBajos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridStockBajos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridStockBajos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridStockBajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridStockBajos.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridStockBajos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStockBajos.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.gridStockBajos.Location = new System.Drawing.Point(3, 3);
            this.gridStockBajos.Name = "gridStockBajos";
            this.gridStockBajos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStockBajos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridStockBajos.RowHeadersVisible = false;
            this.gridStockBajos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.gridStockBajos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridStockBajos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gridStockBajos.RowTemplate.ReadOnly = true;
            this.gridStockBajos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStockBajos.Size = new System.Drawing.Size(888, 362);
            this.gridStockBajos.TabIndex = 374;
            // 
            // tabCaducados
            // 
            this.tabCaducados.Controls.Add(this.gridCaducados);
            this.tabCaducados.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCaducados.Location = new System.Drawing.Point(4, 22);
            this.tabCaducados.Name = "tabCaducados";
            this.tabCaducados.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaducados.Size = new System.Drawing.Size(894, 368);
            this.tabCaducados.TabIndex = 1;
            this.tabCaducados.Text = "Productos caducados / x caducar";
            this.tabCaducados.UseVisualStyleBackColor = true;
            // 
            // gridCaducados
            // 
            this.gridCaducados.AllowUserToAddRows = false;
            this.gridCaducados.AllowUserToDeleteRows = false;
            this.gridCaducados.AllowUserToResizeRows = false;
            this.gridCaducados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCaducados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCaducados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridCaducados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCaducados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCaducados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCaducados.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridCaducados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCaducados.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.gridCaducados.Location = new System.Drawing.Point(3, 3);
            this.gridCaducados.Name = "gridCaducados";
            this.gridCaducados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCaducados.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridCaducados.RowHeadersVisible = false;
            this.gridCaducados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.gridCaducados.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridCaducados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gridCaducados.RowTemplate.ReadOnly = true;
            this.gridCaducados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCaducados.Size = new System.Drawing.Size(888, 362);
            this.gridCaducados.TabIndex = 375;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.ToolTipText = "Editar Producto";
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.ToolTipText = "Eliminar producto";
            this.dataGridViewImageColumn2.Width = 10;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(171, 65);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(387, 27);
            this.txtBuscar.TabIndex = 385;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel15.Location = new System.Drawing.Point(163, 92);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(395, 3);
            this.panel15.TabIndex = 386;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(125, 61);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 384;
            this.pictureBox4.TabStop = false;
            // 
            // rbtnCaducados
            // 
            this.rbtnCaducados.AutoSize = true;
            this.rbtnCaducados.Checked = true;
            this.rbtnCaducados.CheckedColor = System.Drawing.Color.Red;
            this.rbtnCaducados.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCaducados.Location = new System.Drawing.Point(607, 72);
            this.rbtnCaducados.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnCaducados.Name = "rbtnCaducados";
            this.rbtnCaducados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnCaducados.Size = new System.Drawing.Size(120, 23);
            this.rbtnCaducados.TabIndex = 387;
            this.rbtnCaducados.TabStop = true;
            this.rbtnCaducados.Text = "Caducados";
            this.rbtnCaducados.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnCaducados.UseVisualStyleBackColor = true;
            this.rbtnCaducados.CheckedChanged += new System.EventHandler(this.rbtnCaducados_CheckedChanged);
            // 
            // rbtnPorCaducar
            // 
            this.rbtnPorCaducar.AutoSize = true;
            this.rbtnPorCaducar.CheckedColor = System.Drawing.Color.Orange;
            this.rbtnPorCaducar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPorCaducar.Location = new System.Drawing.Point(742, 72);
            this.rbtnPorCaducar.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnPorCaducar.Name = "rbtnPorCaducar";
            this.rbtnPorCaducar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnPorCaducar.Size = new System.Drawing.Size(127, 23);
            this.rbtnPorCaducar.TabIndex = 388;
            this.rbtnPorCaducar.Text = "Por caducar";
            this.rbtnPorCaducar.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnPorCaducar.UseVisualStyleBackColor = true;
            this.rbtnPorCaducar.CheckedChanged += new System.EventHandler(this.rbtnPorCaducar_CheckedChanged);
            // 
            // frmInventarioKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 514);
            this.Controls.Add(this.rbtnPorCaducar);
            this.Controls.Add(this.rbtnCaducados);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tbStocks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventarioKardex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventarioKardex_Load);
            this.tbStocks.ResumeLayout(false);
            this.tabStocksBajos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStockBajos)).EndInit();
            this.tabCaducados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCaducados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbStocks;
        private System.Windows.Forms.TabPage tabStocksBajos;
        private System.Windows.Forms.TabPage tabCaducados;
        public System.Windows.Forms.DataGridView gridStockBajos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.DataGridView gridCaducados;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private RJCodeAdvance.RJControls.RJRadioButton rbtnCaducados;
        private RJCodeAdvance.RJControls.RJRadioButton rbtnPorCaducar;
    }
}