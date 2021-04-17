using BusVenta;
using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string serial;
        private void frmCajaRemota_Load(object sender, EventArgs e)
        {
            ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
            SerialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
            //IdCaja = new BusBox().showBoxBySerial(SerialPC).Id;
            serial = EncriptarTexto.Encriptar(SerialPC);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCajaRemota.Text))
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
                Box b = new Box();
                b.Descripcion = txtCajaRemota.Text;
                b.Tema = "CLARO";
                b.SerialPC = SerialPC;
                b.ImpresoraTicket = "NINGUNA";
                b.ImpresoraA4 = "NINGUNA";
                b.Tipo = "SECUNDARIA";
                b.Estado = true;

                //new DatBox().Insertar_CajaRemota(strConexion, b);
                SqlConnection conexionExpress = new SqlConnection(strConexion);
                conexionExpress.Open();
                SqlCommand sc = new SqlCommand("sp_insertarCaja", conexionExpress);
                sc.CommandType = CommandType.StoredProcedure;
                sc.Parameters.AddWithValue("@descripcion", b.Descripcion);
                sc.Parameters.AddWithValue("@tema", b.Tema);
                sc.Parameters.AddWithValue("@serialPC", b.SerialPC);
                sc.Parameters.AddWithValue("@impresoraTicket", b.ImpresoraTicket);
                sc.Parameters.AddWithValue("@impresoA4", b.ImpresoraA4);
                sc.Parameters.AddWithValue("@tipo", b.Tipo);
                sc.Parameters.AddWithValue("@estado", b.Estado);
                sc.ExecuteNonQuery();
                conexionExpress.Close();

                InsertarInicioSesion();

                
               // new DatCatGenerico().Insertar_InicioSesionRemoto(strConexion, serial);

                MessageBox.Show("¡LISTO!, Se ha habilitado la caja remota", "Caja Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al agregar la caja " + ex.Message, "Error caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertarInicioSesion()
        {
            try
            {
                
                SqlConnection conexionExpress = new SqlConnection(strConexion);
                conexionExpress.Open();

                SqlCommand sc = new SqlCommand("sp_insertar_inicioSesion", conexionExpress);
                sc.CommandType = CommandType.StoredProcedure;
                sc.Parameters.AddWithValue("@idSerialPC", serial);
                sc.ExecuteNonQuery();
                conexionExpress.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
