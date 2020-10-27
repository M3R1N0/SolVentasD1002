using BusVenta;
using DatVentas;
using EntVenta;
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
    public partial class frmServidorRemoto : Form
    {
        public frmServidorRemoto()
        {
            InitializeComponent();
        }

        string EstadoConexion;
        private void frmServidorRemoto_Load(object sender, EventArgs e)
        {
            Listar_Usuarios();
            if (DatUser.AUX_CONEXION.Equals("CORRECTO"))
            {
                Dispose();
                frmRegistroEmpresa frmRegistroEmpresa = new frmRegistroEmpresa();
                frmRegistroEmpresa.ShowDialog();
            }
        }

        private void Listar_Usuarios()
        {
            try
            {
                List<User> lstUsuarios = new BusUser().ListarUsuarios();
                EstadoConexion = "CONECTADO";
            }
            catch (Exception )
            {
                EstadoConexion = "-";
               // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Hide();
            frmInstalacionServidor frmInstalacion = new frmInstalacionServidor();
            frmInstalacion.ShowDialog();
            this. Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
