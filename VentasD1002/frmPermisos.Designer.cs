namespace VentasD1002
{
    partial class frmPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermisos));
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.Modulos = new System.Windows.Forms.TabPage();
            this.pnlITems = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Modulos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(116, 40);
            this.cboRol.Margin = new System.Windows.Forms.Padding(4);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(285, 25);
            this.cboRol.TabIndex = 131;
            this.cboRol.SelectionChangeCommitted += new System.EventHandler(this.cboRol_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 130;
            this.label2.Text = "Perfil:";
            // 
            // btnPerfil
            // 
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.Location = new System.Drawing.Point(404, 36);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(34, 32);
            this.btnPerfil.TabIndex = 132;
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // Modulos
            // 
            this.Modulos.Controls.Add(this.pnlITems);
            this.Modulos.Location = new System.Drawing.Point(4, 25);
            this.Modulos.Name = "Modulos";
            this.Modulos.Padding = new System.Windows.Forms.Padding(3);
            this.Modulos.Size = new System.Drawing.Size(677, 377);
            this.Modulos.TabIndex = 0;
            this.Modulos.Text = "Modulos existentes";
            this.Modulos.UseVisualStyleBackColor = true;
            // 
            // pnlITems
            // 
            this.pnlITems.BackColor = System.Drawing.SystemColors.Control;
            this.pnlITems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlITems.Location = new System.Drawing.Point(3, 3);
            this.pnlITems.Name = "pnlITems";
            this.pnlITems.Size = new System.Drawing.Size(671, 371);
            this.pnlITems.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Modulos);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(24, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 406);
            this.tabControl1.TabIndex = 129;
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 499);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.Modulos.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Modulos;
        private System.Windows.Forms.FlowLayoutPanel pnlITems;
        private System.Windows.Forms.TabControl tabControl1;
    }
}