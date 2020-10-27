using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductos productos = new frmProductos();
            productos.ShowDialog();
            Dispose();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard dashboard = new frmDashboard();
            dashboard.ShowDialog();
            Dispose();
        }

        private void Logo_empresa_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmConfiguracionEmpresa configuracionEmpresa = new frmConfiguracionEmpresa();
            configuracionEmpresa.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario usuario = new frmUsuario();
            usuario.ShowDialog();
            this.Dispose();
        }
    }
}
