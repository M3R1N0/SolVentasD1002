namespace VentasD1002
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.gdvClientes = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.rbtnCliente = new RJCodeAdvance.RJControls.RJRadioButton();
            this.rbtnProveedor = new RJCodeAdvance.RJControls.RJRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvClientes
            // 
            this.gdvClientes.AllowUserToAddRows = false;
            this.gdvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvClientes.BackgroundColor = System.Drawing.Color.White;
            this.gdvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.gdvClientes.EnableHeadersVisualStyles = false;
            this.gdvClientes.Location = new System.Drawing.Point(30, 125);
            this.gdvClientes.Name = "gdvClientes";
            this.gdvClientes.RowHeadersVisible = false;
            this.gdvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gdvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvClientes.Size = new System.Drawing.Size(958, 452);
            this.gdvClientes.TabIndex = 2;
            this.gdvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvClientes_CellClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(76, 72);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(506, 27);
            this.txtBuscarCliente.TabIndex = 388;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarVencimiento_TextChanged);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel15.Location = new System.Drawing.Point(68, 99);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(514, 3);
            this.panel15.TabIndex = 389;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(30, 68);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 387;
            this.pictureBox4.TabStop = false;
            // 
            // rbtnCliente
            // 
            this.rbtnCliente.AutoSize = true;
            this.rbtnCliente.Checked = true;
            this.rbtnCliente.CheckedColor = System.Drawing.Color.LimeGreen;
            this.rbtnCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCliente.Location = new System.Drawing.Point(611, 78);
            this.rbtnCliente.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnCliente.Name = "rbtnCliente";
            this.rbtnCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnCliente.Size = new System.Drawing.Size(91, 25);
            this.rbtnCliente.TabIndex = 390;
            this.rbtnCliente.TabStop = true;
            this.rbtnCliente.Text = "Cliente";
            this.rbtnCliente.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnCliente.UseVisualStyleBackColor = true;
            this.rbtnCliente.CheckedChanged += new System.EventHandler(this.rbtnCliente_CheckedChanged);
            // 
            // rbtnProveedor
            // 
            this.rbtnProveedor.AutoSize = true;
            this.rbtnProveedor.CheckedColor = System.Drawing.Color.LimeGreen;
            this.rbtnProveedor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnProveedor.Location = new System.Drawing.Point(735, 78);
            this.rbtnProveedor.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnProveedor.Name = "rbtnProveedor";
            this.rbtnProveedor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnProveedor.Size = new System.Drawing.Size(116, 25);
            this.rbtnProveedor.TabIndex = 391;
            this.rbtnProveedor.Text = "Proveedor";
            this.rbtnProveedor.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnProveedor.UseVisualStyleBackColor = true;
            this.rbtnProveedor.CheckedChanged += new System.EventHandler(this.rbtnProveedor_CheckedChanged);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 608);
            this.Controls.Add(this.rbtnProveedor);
            this.Controls.Add(this.rbtnCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.gdvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gdvClientes;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox pictureBox4;
        private RJCodeAdvance.RJControls.RJRadioButton rbtnCliente;
        private RJCodeAdvance.RJControls.RJRadioButton rbtnProveedor;
    }
}