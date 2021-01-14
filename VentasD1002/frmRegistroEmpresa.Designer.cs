namespace VentasD1002
{
    partial class frmRegistroEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroEmpresa));
            this.label1 = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPaises = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPorcentaje = new System.Windows.Forms.ComboBox();
            this.cboImpuesto1 = new System.Windows.Forms.ComboBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            this.cboImpuesto = new System.Windows.Forms.ComboBox();
            this.cboPorcentajeImpuesto = new System.Windows.Forms.ComboBox();
            this.chckLectora = new System.Windows.Forms.CheckBox();
            this.chckTeclado = new System.Windows.Forms.CheckBox();
            this.txtNombreCaja = new System.Windows.Forms.TextBox();
            this.txtRutaBackup = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siguienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(160, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Llene todos los campos para registrar de manera correcta su empresa";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(76, 34);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(49, 21);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "NO";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSi.Location = new System.Drawing.Point(6, 34);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(40, 21);
            this.rbSi.TabIndex = 0;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "SI";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // cboMoneda
            // 
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Items.AddRange(new object[] {
            ".",
            "$",
            "$$"});
            this.cboMoneda.Location = new System.Drawing.Point(548, 70);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(66, 24);
            this.cboMoneda.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // cboPaises
            // 
            this.cboPaises.FormattingEnabled = true;
            this.cboPaises.Items.AddRange(new object[] {
            "----SELECCIONE---",
            "Mexico",
            "Brazil"});
            this.cboPaises.Location = new System.Drawing.Point(247, 73);
            this.cboPaises.Name = "cboPaises";
            this.cboPaises.Size = new System.Drawing.Size(180, 24);
            this.cboPaises.TabIndex = 2;
            this.cboPaises.SelectedIndexChanged += new System.EventHandler(this.cboPaises_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.Location = new System.Drawing.Point(201, 31);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(527, 26);
            this.txtNombreEmpresa.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(70, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(122, 110);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboPorcentaje);
            this.groupBox1.Controls.Add(this.cboImpuesto1);
            this.groupBox1.Controls.Add(this.radioButtonNo);
            this.groupBox1.Controls.Add(this.radioButtonSi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(201, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aplica Impuestos";
            // 
            // cboPorcentaje
            // 
            this.cboPorcentaje.FormattingEnabled = true;
            this.cboPorcentaje.Items.AddRange(new object[] {
            "16"});
            this.cboPorcentaje.Location = new System.Drawing.Point(243, 30);
            this.cboPorcentaje.Name = "cboPorcentaje";
            this.cboPorcentaje.Size = new System.Drawing.Size(72, 24);
            this.cboPorcentaje.TabIndex = 7;
            // 
            // cboImpuesto1
            // 
            this.cboImpuesto1.FormattingEnabled = true;
            this.cboImpuesto1.Items.AddRange(new object[] {
            "IVA"});
            this.cboImpuesto1.Location = new System.Drawing.Point(116, 30);
            this.cboImpuesto1.Name = "cboImpuesto1";
            this.cboImpuesto1.Size = new System.Drawing.Size(110, 24);
            this.cboImpuesto1.TabIndex = 6;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(66, 33);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(44, 21);
            this.radioButtonNo.TabIndex = 5;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Location = new System.Drawing.Point(22, 33);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(38, 21);
            this.radioButtonSi.TabIndex = 4;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "Si";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            this.radioButtonSi.CheckedChanged += new System.EventHandler(this.radioButtonSi_CheckedChanged);
            // 
            // cboImpuesto
            // 
            this.cboImpuesto.FormattingEnabled = true;
            this.cboImpuesto.Location = new System.Drawing.Point(131, 33);
            this.cboImpuesto.Name = "cboImpuesto";
            this.cboImpuesto.Size = new System.Drawing.Size(66, 21);
            this.cboImpuesto.TabIndex = 7;
            // 
            // cboPorcentajeImpuesto
            // 
            this.cboPorcentajeImpuesto.FormattingEnabled = true;
            this.cboPorcentajeImpuesto.Location = new System.Drawing.Point(214, 34);
            this.cboPorcentajeImpuesto.Name = "cboPorcentajeImpuesto";
            this.cboPorcentajeImpuesto.Size = new System.Drawing.Size(66, 21);
            this.cboPorcentajeImpuesto.TabIndex = 8;
            // 
            // chckLectora
            // 
            this.chckLectora.AutoSize = true;
            this.chckLectora.BackColor = System.Drawing.Color.Transparent;
            this.chckLectora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckLectora.Location = new System.Drawing.Point(522, 190);
            this.chckLectora.Name = "chckLectora";
            this.chckLectora.Size = new System.Drawing.Size(80, 21);
            this.chckLectora.TabIndex = 8;
            this.chckLectora.Text = "Scanner";
            this.chckLectora.UseVisualStyleBackColor = false;
            // 
            // chckTeclado
            // 
            this.chckTeclado.AutoSize = true;
            this.chckTeclado.BackColor = System.Drawing.Color.Transparent;
            this.chckTeclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckTeclado.Location = new System.Drawing.Point(617, 189);
            this.chckTeclado.Name = "chckTeclado";
            this.chckTeclado.Size = new System.Drawing.Size(78, 21);
            this.chckTeclado.TabIndex = 9;
            this.chckTeclado.Text = "Teclado";
            this.chckTeclado.UseVisualStyleBackColor = false;
            // 
            // txtNombreCaja
            // 
            this.txtNombreCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCaja.Location = new System.Drawing.Point(302, 222);
            this.txtNombreCaja.Name = "txtNombreCaja";
            this.txtNombreCaja.Size = new System.Drawing.Size(426, 23);
            this.txtNombreCaja.TabIndex = 10;
            // 
            // txtRutaBackup
            // 
            this.txtRutaBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaBackup.Location = new System.Drawing.Point(242, 280);
            this.txtRutaBackup.Name = "txtRutaBackup";
            this.txtRutaBackup.Size = new System.Drawing.Size(486, 23);
            this.txtRutaBackup.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(201, 340);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(527, 23);
            this.txtCorreo.TabIndex = 12;
            // 
            // panelRegistro
            // 
            this.panelRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.panelRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRegistro.BackgroundImage")));
            this.panelRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegistro.Controls.Add(this.pictureBox1);
            this.panelRegistro.Controls.Add(this.label7);
            this.panelRegistro.Controls.Add(this.label6);
            this.panelRegistro.Controls.Add(this.label5);
            this.panelRegistro.Controls.Add(this.label4);
            this.panelRegistro.Controls.Add(this.groupBox1);
            this.panelRegistro.Controls.Add(this.label10);
            this.panelRegistro.Controls.Add(this.label9);
            this.panelRegistro.Controls.Add(this.label8);
            this.panelRegistro.Controls.Add(this.txtCorreo);
            this.panelRegistro.Controls.Add(this.txtRutaBackup);
            this.panelRegistro.Controls.Add(this.txtNombreCaja);
            this.panelRegistro.Controls.Add(this.chckTeclado);
            this.panelRegistro.Controls.Add(this.chckLectora);
            this.panelRegistro.Controls.Add(this.cboMoneda);
            this.panelRegistro.Controls.Add(this.label3);
            this.panelRegistro.Controls.Add(this.cboPaises);
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Controls.Add(this.txtNombreEmpresa);
            this.panelRegistro.Controls.Add(this.pbLogo);
            this.panelRegistro.Controls.Add(this.menuStrip1);
            this.panelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRegistro.Location = new System.Drawing.Point(69, 75);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(833, 490);
            this.panelRegistro.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(198, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(444, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Registre un correo válido para el envío del reporte de cierre de caja :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(198, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Elija el directorio donde desee guardar la copia de seguridad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(198, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nombre Caja :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(198, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dispositivo  de búsqueda con frecuencia :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(474, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Moneda :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(198, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pais :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(198, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nombre de la Empresa :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siguienteToolStripMenuItem,
            this.siguienteToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(483, 411);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(248, 33);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siguienteToolStripMenuItem
            // 
            this.siguienteToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.siguienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("siguienteToolStripMenuItem.Image")));
            this.siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            this.siguienteToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.siguienteToolStripMenuItem.Text = "Cancelar";
            // 
            // siguienteToolStripMenuItem1
            // 
            this.siguienteToolStripMenuItem1.BackColor = System.Drawing.Color.DarkGreen;
            this.siguienteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("siguienteToolStripMenuItem1.Image")));
            this.siguienteToolStripMenuItem1.Name = "siguienteToolStripMenuItem1";
            this.siguienteToolStripMenuItem1.Size = new System.Drawing.Size(124, 29);
            this.siguienteToolStripMenuItem1.Text = "Siguiente";
            this.siguienteToolStripMenuItem1.Click += new System.EventHandler(this.siguienteToolStripMenuItem1_Click);
            // 
            // frmRegistroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(960, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelRegistro);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de la Empresa";
            this.Load += new System.EventHandler(this.frmRegistroEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPaises;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboImpuesto;
        private System.Windows.Forms.ComboBox cboPorcentajeImpuesto;
        private System.Windows.Forms.CheckBox chckLectora;
        private System.Windows.Forms.CheckBox chckTeclado;
        private System.Windows.Forms.TextBox txtNombreCaja;
        private System.Windows.Forms.TextBox txtRutaBackup;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.ComboBox cboPorcentaje;
        private System.Windows.Forms.ComboBox cboImpuesto1;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonSi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siguienteToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}