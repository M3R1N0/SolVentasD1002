namespace VentasD1002
{
    partial class frmHistorialCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.gdvClientes = new System.Windows.Forms.DataGridView();
            this.Excel = new System.Windows.Forms.DataGridViewImageColumn();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(64, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 51);
            this.label1.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel8.ForeColor = System.Drawing.Color.Blue;
            this.panel8.Location = new System.Drawing.Point(124, 71);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(343, 3);
            this.panel8.TabIndex = 19;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCliente.Location = new System.Drawing.Point(124, 49);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(343, 19);
            this.txtCliente.TabIndex = 18;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // gdvClientes
            // 
            this.gdvClientes.AllowUserToAddRows = false;
            this.gdvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvClientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gdvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excel});
            this.gdvClientes.EnableHeadersVisualStyles = false;
            this.gdvClientes.Location = new System.Drawing.Point(45, 90);
            this.gdvClientes.Name = "gdvClientes";
            this.gdvClientes.RowHeadersVisible = false;
            this.gdvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gdvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvClientes.Size = new System.Drawing.Size(844, 442);
            this.gdvClientes.TabIndex = 4;
            this.gdvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvClientes_CellClick);
            // 
            // Excel
            // 
            this.Excel.Frozen = true;
            this.Excel.HeaderText = "Exportar";
            this.Excel.Image = ((System.Drawing.Image)(resources.GetObject("Excel.Image")));
            this.Excel.Name = "Excel";
            this.Excel.ReadOnly = true;
            this.Excel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Description = "procesando la información ...";
            this.progressPanel1.Location = new System.Drawing.Point(167, 157);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(587, 246);
            this.progressPanel1.TabIndex = 5;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // frmHistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 564);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.gdvClientes);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistorialCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de ventas por cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHistorialCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView gdvClientes;
        private System.Windows.Forms.DataGridViewImageColumn Excel;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}