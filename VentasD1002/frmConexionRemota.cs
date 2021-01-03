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
    public partial class frmConexionRemota : Form
    {
        public frmConexionRemota()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIP.Text))
            {

            }
            else
            {
                MessageBox.Show("Ingrese la IP", "Campo necesario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConectarServidor()
        {

        }
    }
}
