namespace VentasD1002
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblStockBajos = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblVentasCredito = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalProducto = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblVentaTotal = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dpInicio = new System.Windows.Forms.DateTimePicker();
            this.dpFin = new System.Windows.Forms.DateTimePicker();
            this.panel14 = new System.Windows.Forms.Panel();
            this.chartProductosVendidos = new LiveCharts.WinForms.PieChart();
            this.graficaVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRango = new System.Windows.Forms.TextBox();
            this.rbtnProductosTop10 = new RJCodeAdvance.RJControls.RJRadioButton();
            this.rbtnClientesFrecuentes = new RJCodeAdvance.RJControls.RJRadioButton();
            this.rbtnVentas = new RJCodeAdvance.RJControls.RJRadioButton();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartClientesFrecuentes = new LiveCharts.WinForms.CartesianChart();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficaVentas)).BeginInit();
            this.panel15.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.lblTotalClientes);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(8, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 101);
            this.panel3.TabIndex = 1;
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.Location = new System.Drawing.Point(64, 36);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(129, 65);
            this.lblTotalClientes.TabIndex = 2;
            this.lblTotalClientes.Text = "0.00";
            this.lblTotalClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PowderBlue;
            this.panel4.Controls.Add(this.lblStockBajos);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(9, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 101);
            this.panel4.TabIndex = 3;
            // 
            // lblStockBajos
            // 
            this.lblStockBajos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockBajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockBajos.Location = new System.Drawing.Point(64, 36);
            this.lblStockBajos.Name = "lblStockBajos";
            this.lblStockBajos.Size = new System.Drawing.Size(129, 65);
            this.lblStockBajos.TabIndex = 2;
            this.lblStockBajos.Text = "0.00";
            this.lblStockBajos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stock bajos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PowderBlue;
            this.panel5.Controls.Add(this.lblVentasCredito);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(10, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(193, 101);
            this.panel5.TabIndex = 4;
            // 
            // lblVentasCredito
            // 
            this.lblVentasCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVentasCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasCredito.Location = new System.Drawing.Point(64, 36);
            this.lblVentasCredito.Name = "lblVentasCredito";
            this.lblVentasCredito.Size = new System.Drawing.Size(129, 65);
            this.lblVentasCredito.TabIndex = 2;
            this.lblVentasCredito.Text = "0.00";
            this.lblVentasCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "N° créditos por cobrar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PowderBlue;
            this.panel6.Controls.Add(this.lblTotalProducto);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(10, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(193, 101);
            this.panel6.TabIndex = 5;
            // 
            // lblTotalProducto
            // 
            this.lblTotalProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducto.Location = new System.Drawing.Point(64, 36);
            this.lblTotalProducto.Name = "lblTotalProducto";
            this.lblTotalProducto.Size = new System.Drawing.Size(129, 65);
            this.lblTotalProducto.TabIndex = 2;
            this.lblTotalProducto.Text = "0.00";
            this.lblTotalProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 36);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 65);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "N° Productos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PowderBlue;
            this.panel7.Controls.Add(this.lblVentaTotal);
            this.panel7.Controls.Add(this.pictureBox6);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(10, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(193, 101);
            this.panel7.TabIndex = 5;
            // 
            // lblVentaTotal
            // 
            this.lblVentaTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVentaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaTotal.Location = new System.Drawing.Point(64, 36);
            this.lblVentaTotal.Name = "lblVentaTotal";
            this.lblVentaTotal.Size = new System.Drawing.Size(129, 65);
            this.lblVentaTotal.TabIndex = 2;
            this.lblVentaTotal.Text = "0.00";
            this.lblVentaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(169)))), ((int)(((byte)(190)))));
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 36);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 36);
            this.label10.TabIndex = 0;
            this.label10.Text = "N° Ventas Realizadas";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Location = new System.Drawing.Point(6, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(210, 115);
            this.panel8.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Location = new System.Drawing.Point(237, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(210, 115);
            this.panel9.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Location = new System.Drawing.Point(466, 11);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(210, 115);
            this.panel10.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel11.BackgroundImage")));
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Controls.Add(this.panel6);
            this.panel11.Location = new System.Drawing.Point(690, 12);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(210, 115);
            this.panel11.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel12.Controls.Add(this.panel7);
            this.panel12.Location = new System.Drawing.Point(914, 12);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(210, 115);
            this.panel12.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel9);
            this.panel13.Controls.Add(this.panel8);
            this.panel13.Controls.Add(this.panel10);
            this.panel13.Controls.Add(this.panel11);
            this.panel13.Controls.Add(this.panel12);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1147, 133);
            this.panel13.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fin:";
            // 
            // dpInicio
            // 
            this.dpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpInicio.Location = new System.Drawing.Point(206, 30);
            this.dpInicio.Name = "dpInicio";
            this.dpInicio.Size = new System.Drawing.Size(95, 24);
            this.dpInicio.TabIndex = 4;
            this.dpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // dpFin
            // 
            this.dpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFin.Location = new System.Drawing.Point(338, 30);
            this.dpFin.Name = "dpFin";
            this.dpFin.Size = new System.Drawing.Size(91, 24);
            this.dpFin.TabIndex = 5;
            this.dpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.chartClientesFrecuentes);
            this.panel14.Controls.Add(this.chartProductosVendidos);
            this.panel14.Controls.Add(this.graficaVentas);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 133);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1147, 515);
            this.panel14.TabIndex = 9;
            // 
            // chartProductosVendidos
            // 
            this.chartProductosVendidos.Location = new System.Drawing.Point(221, 73);
            this.chartProductosVendidos.Name = "chartProductosVendidos";
            this.chartProductosVendidos.Size = new System.Drawing.Size(99, 46);
            this.chartProductosVendidos.TabIndex = 11;
            this.chartProductosVendidos.Text = "pieChart1";
            // 
            // graficaVentas
            // 
            this.graficaVentas.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX2.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.graficaVentas.ChartAreas.Add(chartArea2);
            this.graficaVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.graficaVentas.Legends.Add(legend2);
            this.graficaVentas.Location = new System.Drawing.Point(0, 67);
            this.graficaVentas.Name = "graficaVentas";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BackSecondaryColor = System.Drawing.Color.GhostWhite;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.DeepSkyBlue;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "{0:0}";
            series2.Legend = "Legend1";
            series2.LegendText = "Monto total (pesos)";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series1";
            this.graficaVentas.Series.Add(series2);
            this.graficaVentas.Size = new System.Drawing.Size(1147, 448);
            this.graficaVentas.TabIndex = 1;
            this.graficaVentas.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title2.Name = "Ventas por periodo";
            title2.Text = "Ventas por periodo";
            this.graficaVentas.Titles.Add(title2);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.pnlFiltro);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1147, 67);
            this.panel15.TabIndex = 0;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.label3);
            this.pnlFiltro.Controls.Add(this.txtRango);
            this.pnlFiltro.Controls.Add(this.rbtnProductosTop10);
            this.pnlFiltro.Controls.Add(this.rbtnClientesFrecuentes);
            this.pnlFiltro.Controls.Add(this.rbtnVentas);
            this.pnlFiltro.Controls.Add(this.cboPeriodo);
            this.pnlFiltro.Controls.Add(this.label2);
            this.pnlFiltro.Controls.Add(this.dpFin);
            this.pnlFiltro.Controls.Add(this.label5);
            this.pnlFiltro.Controls.Add(this.label7);
            this.pnlFiltro.Controls.Add(this.dpInicio);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(1147, 67);
            this.pnlFiltro.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1013, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rango:";
            // 
            // txtRango
            // 
            this.txtRango.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRango.Location = new System.Drawing.Point(1017, 29);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(100, 27);
            this.txtRango.TabIndex = 11;
            this.txtRango.Visible = false;
            this.txtRango.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRango_KeyPress);
            this.txtRango.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRango_KeyUp);
            // 
            // rbtnProductosTop10
            // 
            this.rbtnProductosTop10.AutoSize = true;
            this.rbtnProductosTop10.CheckedColor = System.Drawing.Color.Lime;
            this.rbtnProductosTop10.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnProductosTop10.Location = new System.Drawing.Point(729, 30);
            this.rbtnProductosTop10.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnProductosTop10.Name = "rbtnProductosTop10";
            this.rbtnProductosTop10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnProductosTop10.Size = new System.Drawing.Size(271, 24);
            this.rbtnProductosTop10.TabIndex = 10;
            this.rbtnProductosTop10.Text = "Top 10 Productos mas vendidos";
            this.rbtnProductosTop10.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnProductosTop10.UseVisualStyleBackColor = true;
            this.rbtnProductosTop10.CheckedChanged += new System.EventHandler(this.rbtnProductosTop10_CheckedChanged);
            // 
            // rbtnClientesFrecuentes
            // 
            this.rbtnClientesFrecuentes.AutoSize = true;
            this.rbtnClientesFrecuentes.CheckedColor = System.Drawing.Color.Lime;
            this.rbtnClientesFrecuentes.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnClientesFrecuentes.Location = new System.Drawing.Point(547, 30);
            this.rbtnClientesFrecuentes.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnClientesFrecuentes.Name = "rbtnClientesFrecuentes";
            this.rbtnClientesFrecuentes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnClientesFrecuentes.Size = new System.Drawing.Size(176, 24);
            this.rbtnClientesFrecuentes.TabIndex = 9;
            this.rbtnClientesFrecuentes.Text = "Clientes frecuentes";
            this.rbtnClientesFrecuentes.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnClientesFrecuentes.UseVisualStyleBackColor = true;
            this.rbtnClientesFrecuentes.CheckedChanged += new System.EventHandler(this.rbtnClientesFrecuentes_CheckedChanged);
            // 
            // rbtnVentas
            // 
            this.rbtnVentas.AutoSize = true;
            this.rbtnVentas.Checked = true;
            this.rbtnVentas.CheckedColor = System.Drawing.Color.Lime;
            this.rbtnVentas.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVentas.Location = new System.Drawing.Point(454, 30);
            this.rbtnVentas.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnVentas.Name = "rbtnVentas";
            this.rbtnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnVentas.Size = new System.Drawing.Size(86, 24);
            this.rbtnVentas.TabIndex = 8;
            this.rbtnVentas.TabStop = true;
            this.rbtnVentas.Text = "Ventas";
            this.rbtnVentas.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnVentas.UseVisualStyleBackColor = true;
            this.rbtnVentas.CheckedChanged += new System.EventHandler(this.rbtnVentas_CheckedChanged);
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Items.AddRange(new object[] {
            "DIARIO",
            "SEMANAL",
            "MENSUAL",
            "ANUAL"});
            this.cboPeriodo.Location = new System.Drawing.Point(7, 26);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(166, 28);
            this.cboPeriodo.TabIndex = 7;
            this.cboPeriodo.SelectionChangeCommitted += new System.EventHandler(this.cboPeriodo_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Periodo:";
            // 
            // chartClientesFrecuentes
            // 
            this.chartClientesFrecuentes.Location = new System.Drawing.Point(402, 73);
            this.chartClientesFrecuentes.Name = "chartClientesFrecuentes";
            this.chartClientesFrecuentes.Size = new System.Drawing.Size(138, 29);
            this.chartClientesFrecuentes.TabIndex = 12;
            this.chartClientesFrecuentes.Text = "cartesianChart1";
            this.chartClientesFrecuentes.Visible = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1147, 648);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graficaVentas)).EndInit();
            this.panel15.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblStockBajos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblVentasCredito;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalProducto;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblVentaTotal;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.DateTimePicker dpFin;
        private System.Windows.Forms.DateTimePicker dpInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficaVentas;
        private RJCodeAdvance.RJControls.RJRadioButton rbtnProductosTop10;
        private RJCodeAdvance.RJControls.RJRadioButton rbtnClientesFrecuentes;
        private RJCodeAdvance.RJControls.RJRadioButton rbtnVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRango;
        private LiveCharts.WinForms.PieChart chartProductosVendidos;
        private LiveCharts.WinForms.CartesianChart chartClientesFrecuentes;
    }
}