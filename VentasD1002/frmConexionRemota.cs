using BusVenta;
using DatVentas;
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
using System.Xml;

namespace VentasD1002
{
    public partial class frmConexionRemota : Form
    {
        public frmConexionRemota()
        {
            InitializeComponent();
        }

        string strConexion;
        int id;
        string indicador;
        private AES aes = new AES();
        int IdCaja = 0;
        string SerialPC;

        private void frmConexionRemota_Load(object sender, EventArgs e)
        {
            ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
            SerialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIP.Text))
            {
                ConectarServidor_Manual();
            }
            else
            {
                MessageBox.Show("Ingrese la IP", "Campo necesario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ComprobarConexion()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConexion);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP (1) Id_Usuario from tb_Usuario", conn);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                indicador = "CONECTADO";
                //conn.Close();
            }
            catch (Exception ex)
            {
                indicador = "NO CONECTADO";
                MessageBox.Show("Error al comprobar la conexion Remota: "+ex.Message);
            }
        }


        private void ConectarServidor_Manual()
        {
            string Ip = txtIP.Text.Trim();
            strConexion = "Data Source=" + Ip + ";Initial Catalog=DBVENTAS_JIEL;Integrated Security=False; User Id=SoftVentas; Password=Admin123";

            ComprobarConexion();
            if (indicador.Equals("CONECTADO"))
            {
               frmEncriptar.SaveToXML(aes.Encrypt(strConexion, Desencryptation.appPwdUnique, int.Parse("256")));
                ObtenerIdCaja();
                if (IdCaja > 0)
                {
                    MessageBox.Show("Conexión establecida!, vuelva a abrir el sistema", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
                else
                {
                    this.Dispose();

                    frmCajaRemota cajaRemota = new frmCajaRemota();
                    frmCajaRemota.strConexion = strConexion;
                    cajaRemota.ShowDialog();
                }
            }
        }


        private void ObtenerIdCaja()
        {
            try
            {
                //IdCaja = new BusBox().showBoxBySerial(SerialPC).Id;
                SqlConnection conn = new SqlConnection(strConexion);
                conn.Open();
                SqlCommand command = new SqlCommand($"SELECT [Id_Caja] from tb_Caja WHERE Serial_PC='{SerialPC}'", conn);
                IdCaja = Convert.ToInt32(command.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la caja : "+ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SaveToXML(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }

       
    }
}
