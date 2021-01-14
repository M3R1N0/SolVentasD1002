namespace VentasD1002
{
    partial class frmInstalacionServidor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstalacionServidor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timerConfiguacionINI = new System.Windows.Forms.Timer(this.components);
            this.panelBuscandoServidor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnInstalarServidor = new System.Windows.Forms.Button();
            this.lblBuscandoServidor = new System.Windows.Forms.TextBox();
            this.panelInstalandoServidor = new System.Windows.Forms.Panel();
            this.pnlTemporizador = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.richtxtConfiguracion = new System.Windows.Forms.RichTextBox();
            this.lblMilseg = new System.Windows.Forms.Label();
            this.lblSeg = new System.Windows.Forms.Label();
            this.txtTablasSP = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreScript = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtScriptUsuarioRemoto = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panelBuscandoServidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelInstalandoServidor.SuspendLayout();
            this.pnlTemporizador.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 61);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSTALACIÓN DEL SERVIDOR";
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timerConfiguacionINI
            // 
            this.timerConfiguacionINI.Interval = 10;
            this.timerConfiguacionINI.Tick += new System.EventHandler(this.timerConfiguacionINI_Tick);
            // 
            // panelBuscandoServidor
            // 
            this.panelBuscandoServidor.BackColor = System.Drawing.Color.Black;
            this.panelBuscandoServidor.Controls.Add(this.panel2);
            this.panelBuscandoServidor.Controls.Add(this.pictureBox4);
            this.panelBuscandoServidor.Controls.Add(this.btnInstalarServidor);
            this.panelBuscandoServidor.Controls.Add(this.lblBuscandoServidor);
            this.panelBuscandoServidor.Location = new System.Drawing.Point(407, 78);
            this.panelBuscandoServidor.Name = "panelBuscandoServidor";
            this.panelBuscandoServidor.Size = new System.Drawing.Size(505, 487);
            this.panelBuscandoServidor.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Location = new System.Drawing.Point(11, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 105);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(170, 114);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(98, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // btnInstalarServidor
            // 
            this.btnInstalarServidor.FlatAppearance.BorderSize = 0;
            this.btnInstalarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstalarServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstalarServidor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnInstalarServidor.Location = new System.Drawing.Point(75, 33);
            this.btnInstalarServidor.Name = "btnInstalarServidor";
            this.btnInstalarServidor.Size = new System.Drawing.Size(301, 40);
            this.btnInstalarServidor.TabIndex = 0;
            this.btnInstalarServidor.Text = "Instalar Servidor ...";
            this.btnInstalarServidor.UseVisualStyleBackColor = true;
            this.btnInstalarServidor.Click += new System.EventHandler(this.btnInstalarServidor_Click_1);
            // 
            // lblBuscandoServidor
            // 
            this.lblBuscandoServidor.BackColor = System.Drawing.Color.Black;
            this.lblBuscandoServidor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBuscandoServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscandoServidor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBuscandoServidor.Location = new System.Drawing.Point(27, 235);
            this.lblBuscandoServidor.Multiline = true;
            this.lblBuscandoServidor.Name = "lblBuscandoServidor";
            this.lblBuscandoServidor.Size = new System.Drawing.Size(423, 97);
            this.lblBuscandoServidor.TabIndex = 5;
            this.lblBuscandoServidor.Text = "Buscando servidor instalado...";
            // 
            // panelInstalandoServidor
            // 
            this.panelInstalandoServidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panelInstalandoServidor.Controls.Add(this.pnlTemporizador);
            this.panelInstalandoServidor.Controls.Add(this.pictureBox2);
            this.panelInstalandoServidor.Controls.Add(this.textBox1);
            this.panelInstalandoServidor.Controls.Add(this.pictureBox1);
            this.panelInstalandoServidor.Controls.Add(this.panel3);
            this.panelInstalandoServidor.Location = new System.Drawing.Point(443, 90);
            this.panelInstalandoServidor.Name = "panelInstalandoServidor";
            this.panelInstalandoServidor.Size = new System.Drawing.Size(428, 461);
            this.panelInstalandoServidor.TabIndex = 6;
            // 
            // pnlTemporizador
            // 
            this.pnlTemporizador.Controls.Add(this.label3);
            this.pnlTemporizador.Controls.Add(this.panel4);
            this.pnlTemporizador.Location = new System.Drawing.Point(3, 245);
            this.pnlTemporizador.Name = "pnlTemporizador";
            this.pnlTemporizador.Size = new System.Drawing.Size(420, 60);
            this.pnlTemporizador.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tiempo estimado : 6 minutos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSegundo);
            this.panel4.Controls.Add(this.lblMinuto);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(250, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 58);
            this.panel4.TabIndex = 3;
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSegundo.Location = new System.Drawing.Point(112, 30);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(29, 20);
            this.lblSegundo.TabIndex = 3;
            this.lblSegundo.Text = "00";
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMinuto.Location = new System.Drawing.Point(32, 31);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(29, 20);
            this.lblMinuto.TabIndex = 2;
            this.lblMinuto.Text = "00";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 25);
            this.panel5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(107, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Seg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(28, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Min.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(115, 337);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(41, 167);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(357, 47);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "No cierre este ventana, se cerrará automaticamente cuando este todo listo.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 56);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(53, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Instalando Servidor ...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.txtUsuario);
            this.panel6.Controls.Add(this.richtxtConfiguracion);
            this.panel6.Controls.Add(this.lblMilseg);
            this.panel6.Controls.Add(this.lblSeg);
            this.panel6.Controls.Add(this.txtTablasSP);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.txtNombreScript);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.txtDB);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtpwd);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtServidor);
            this.panel6.Location = new System.Drawing.Point(125, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(975, 451);
            this.panel6.TabIndex = 8;
            this.panel6.Visible = false;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(33, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Usuario :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(111, 74);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(139, 20);
            this.txtUsuario.TabIndex = 12;
            this.txtUsuario.Text = "SoftVentas";
            // 
            // richtxtConfiguracion
            // 
            this.richtxtConfiguracion.Location = new System.Drawing.Point(40, 324);
            this.richtxtConfiguracion.Name = "richtxtConfiguracion";
            this.richtxtConfiguracion.Size = new System.Drawing.Size(369, 96);
            this.richtxtConfiguracion.TabIndex = 11;
            this.richtxtConfiguracion.Text = resources.GetString("richtxtConfiguracion.Text");
            // 
            // lblMilseg
            // 
            this.lblMilseg.AutoSize = true;
            this.lblMilseg.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMilseg.Location = new System.Drawing.Point(334, 60);
            this.lblMilseg.Name = "lblMilseg";
            this.lblMilseg.Size = new System.Drawing.Size(13, 13);
            this.lblMilseg.TabIndex = 10;
            this.lblMilseg.Text = "0";
            // 
            // lblSeg
            // 
            this.lblSeg.AutoSize = true;
            this.lblSeg.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSeg.Location = new System.Drawing.Point(297, 60);
            this.lblSeg.Name = "lblSeg";
            this.lblSeg.Size = new System.Drawing.Size(13, 13);
            this.lblSeg.TabIndex = 9;
            this.lblSeg.Text = "0";
            // 
            // txtTablasSP
            // 
            this.txtTablasSP.Location = new System.Drawing.Point(37, 211);
            this.txtTablasSP.Name = "txtTablasSP";
            this.txtTablasSP.Size = new System.Drawing.Size(369, 96);
            this.txtTablasSP.TabIndex = 8;
            this.txtTablasSP.Text = resources.GetString("txtTablasSP.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(33, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Script :";
            // 
            // txtNombreScript
            // 
            this.txtNombreScript.Location = new System.Drawing.Point(111, 183);
            this.txtNombreScript.Name = "txtNombreScript";
            this.txtNombreScript.Size = new System.Drawing.Size(139, 20);
            this.txtNombreScript.TabIndex = 6;
            this.txtNombreScript.Text = "D1002Script";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(4, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Base de datos :";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(112, 148);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(139, 20);
            this.txtDB.TabIndex = 4;
            this.txtDB.Text = "DBVENTAS";
            this.txtDB.TextChanged += new System.EventHandler(this.txtDB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(22, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Contaseña :";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(109, 114);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(139, 20);
            this.txtpwd.TabIndex = 2;
            this.txtpwd.Text = "123";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(34, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Instancia :";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(112, 44);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(139, 20);
            this.txtServidor.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtScriptUsuarioRemoto);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(532, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 254);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para crear un usuario remoto";
            // 
            // txtScriptUsuarioRemoto
            // 
            this.txtScriptUsuarioRemoto.Location = new System.Drawing.Point(6, 19);
            this.txtScriptUsuarioRemoto.Name = "txtScriptUsuarioRemoto";
            this.txtScriptUsuarioRemoto.Size = new System.Drawing.Size(340, 214);
            this.txtScriptUsuarioRemoto.TabIndex = 0;
            this.txtScriptUsuarioRemoto.Text = resources.GetString("txtScriptUsuarioRemoto.Text");
            this.txtScriptUsuarioRemoto.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // frmInstalacionServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1217, 618);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelBuscandoServidor);
            this.Controls.Add(this.panelInstalandoServidor);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInstalacionServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSTALACION DEL SERVIDOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInstalacionServidor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBuscandoServidor.ResumeLayout(false);
            this.panelBuscandoServidor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelInstalandoServidor.ResumeLayout(false);
            this.panelInstalandoServidor.PerformLayout();
            this.pnlTemporizador.ResumeLayout(false);
            this.pnlTemporizador.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timerConfiguacionINI;
        private System.Windows.Forms.Panel panelBuscandoServidor;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnInstalarServidor;
        private System.Windows.Forms.TextBox lblBuscandoServidor;
        private System.Windows.Forms.Panel panelInstalandoServidor;
        private System.Windows.Forms.Panel pnlTemporizador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox richtxtConfiguracion;
        private System.Windows.Forms.Label lblMilseg;
        private System.Windows.Forms.Label lblSeg;
        private System.Windows.Forms.RichTextBox txtTablasSP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreScript;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtScriptUsuarioRemoto;
    }
}