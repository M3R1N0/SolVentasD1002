using BusVenta;
using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmCajaRemota : Form
    {
        public frmCajaRemota()
        {
            InitializeComponent();
        }

        public static string strConexion;
        string SerialPC;

        private void frmCajaRemota_Load(object sender, EventArgs e)
        {
            ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
            SerialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
            //IdCaja = new BusBox().showBoxBySerial(SerialPC).Id;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCajaRemota.Text))
            {
                AgregarCaja();
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de la caja", "Caja Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCajaRemota.Focus();
            }
         
        }

        private void AgregarCaja()
        {
            try
            {
                if (String.IsNullOrEmpty(txtCajaRemota.Text))
                {
                    Box b = new Box();
                    b.Descripcion = txtCajaRemota.Text;
                    b.Tema = "CLARO";
                    b.SerialPC = SerialPC;
                    b.ImpresoraTicket = "NINGUNA";
                    b.ImpresoraA4 = "NINGUNA";
                    b.Tipo = "SECUNDARIA";
                    b.Estado = true;

                    new DatBox().Insertar_CajaRemota(strConexion, b);

                    string serial = EncriptarTexto.Encriptar(SerialPC);
                    new DatCatGenerico().Insertar_InicioSesionRemoto( strConexion, serial);

                    MessageBox.Show("¡LISTO!, Se ha habilitado la caja remota", "Caja Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al agregar la caja " + ex.Message, "Error caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
