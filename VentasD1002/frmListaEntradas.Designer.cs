namespace VentasD1002
{
    partial class frmListaEntradas
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
            this.radNavigationView1 = new Telerik.WinControls.UI.RadNavigationView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radNavigationView1)).BeginInit();
            this.radNavigationView1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radNavigationView1
            // 
            this.radNavigationView1.Controls.Add(this.radPageViewPage1);
            this.radNavigationView1.Controls.Add(this.radPageViewPage2);
            this.radNavigationView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radNavigationView1.HeaderHeight = 30;
            this.radNavigationView1.Location = new System.Drawing.Point(0, 0);
            this.radNavigationView1.Name = "radNavigationView1";
            this.radNavigationView1.SelectedPage = this.radPageViewPage1;
            this.radNavigationView1.Size = new System.Drawing.Size(798, 462);
            this.radNavigationView1.TabIndex = 1;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(59F, 30F);
            this.radPageViewPage1.Location = new System.Drawing.Point(281, 30);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(516, 431);
            this.radPageViewPage1.Text = "Entrada";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(59F, 30F);
            this.radPageViewPage2.Location = new System.Drawing.Point(0, 0);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(200, 100);
            this.radPageViewPage2.Text = "Historial";
            // 
            // frmListaEntradas
            // 
            this.ClientSize = new System.Drawing.Size(798, 462);
            this.Controls.Add(this.radNavigationView1);
            this.Name = "frmListaEntradas";
            ((System.ComponentModel.ISupportInitialize)(this.radNavigationView1)).EndInit();
            this.radNavigationView1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private Telerik.WinControls.UI.RadNavigationView radNavigationView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
    }
}