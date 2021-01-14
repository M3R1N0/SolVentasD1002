namespace VentasD1002
{
    partial class frmCargarDatosExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarDatosExcel));
            this.gdvDatos = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRutaBackup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCargarExcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdvDatos
            // 
            this.gdvDatos.AllowUserToAddRows = false;
            this.gdvDatos.AllowUserToResizeRows = false;
            this.gdvDatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gdvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvDatos.Location = new System.Drawing.Point(51, 153);
            this.gdvDatos.MultiSelect = false;
            this.gdvDatos.Name = "gdvDatos";
            this.gdvDatos.ReadOnly = true;
            this.gdvDatos.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gdvDatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvDatos.Size = new System.Drawing.Size(1048, 297);
            this.gdvDatos.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1099, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(51, 297);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(51, 297);
            this.panel3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Seleccione el archivo de respaldo a cargar :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtRutaBackup
            // 
            this.txtRutaBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaBackup.Location = new System.Drawing.Point(91, 111);
            this.txtRutaBackup.Name = "txtRutaBackup";
            this.txtRutaBackup.ReadOnly = true;
            this.txtRutaBackup.Size = new System.Drawing.Size(486, 23);
            this.txtRutaBackup.TabIndex = 25;
            this.txtRutaBackup.TextChanged += new System.EventHandler(this.txtRutaBackup_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1150, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vista previa productos actualizados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCargarExcel
            // 
            this.btnCargarExcel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCargarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargarExcel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnCargarExcel.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargarExcel.FlatAppearance.BorderSize = 0;
            this.btnCargarExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCargarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCargarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarExcel.Image")));
            this.btnCargarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarExcel.Location = new System.Drawing.Point(595, 102);
            this.btnCargarExcel.Name = "btnCargarExcel";
            this.btnCargarExcel.Size = new System.Drawing.Size(173, 38);
            this.btnCargarExcel.TabIndex = 10;
            this.btnCargarExcel.Text = "Cargar Archivo";
            this.btnCargarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarExcel.UseVisualStyleBackColor = false;
            this.btnCargarExcel.Click += new System.EventHandler(this.btnCargarExcel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnCargarExcel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRutaBackup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 153);
            this.panel1.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(51, 85);
            this.panel6.TabIndex = 31;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(774, 102);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(194, 38);
            this.btnActualizar.TabIndex = 29;
            this.btnActualizar.Text = "Actualizar Datos";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(988, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(162, 85);
            this.panel5.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 68);
            this.panel2.TabIndex = 28;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCargarDatosExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.gdvDatos);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargarDatosExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Datos actualizados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCargarDatosExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvDatos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRutaBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCargarExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}