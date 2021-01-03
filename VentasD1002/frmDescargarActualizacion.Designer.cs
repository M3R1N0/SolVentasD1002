namespace VentasD1002
{
    partial class frmDescargarActualizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescargarActualizacion));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdDetalle = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnControl = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1121, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vista previa productos actualizados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gdDetalle);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 463);
            this.panel2.TabIndex = 2;
            // 
            // gdDetalle
            // 
            this.gdDetalle.AllowUserToAddRows = false;
            this.gdDetalle.AllowUserToResizeRows = false;
            this.gdDetalle.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gdDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdDetalle.Location = new System.Drawing.Point(51, 72);
            this.gdDetalle.MultiSelect = false;
            this.gdDetalle.Name = "gdDetalle";
            this.gdDetalle.ReadOnly = true;
            this.gdDetalle.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gdDetalle.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdDetalle.Size = new System.Drawing.Size(1019, 391);
            this.gdDetalle.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1070, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(51, 391);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(51, 391);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 72);
            this.panel1.TabIndex = 3;
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.DarkOrange;
            this.btnControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnControl.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnControl.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnControl.FlatAppearance.BorderSize = 0;
            this.btnControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.Image = ((System.Drawing.Image)(resources.GetObject("btnControl.Image")));
            this.btnControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControl.Location = new System.Drawing.Point(69, 16);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(182, 38);
            this.btnControl.TabIndex = 10;
            this.btnControl.Text = "Exportar a Excel";
            this.btnControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnControl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(858, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(263, 72);
            this.panel5.TabIndex = 11;
            // 
            // frmDescargarActualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "frmDescargarActualizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDescargarActualizacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDescargarActualizacion_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gdDetalle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
    }
}