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
            IdCaja = new BusBox().showBoxBySerial(SerialPC).Id;
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


        private void ComprobarConexion()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConexion);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id_Usuario from tb_Usuario", conn);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                indicador = "CONECTADO";
                conn.Close();
            }
            catch (Exception ex)
            {
                indicador = "NO CONECTADO";
            }
        }


        private void ConectarServidor_Manual()
        {
            string Ip = txtIP.Text;
            strConexion = "Data Source=" + Ip + ";Initial Catalog=DBVENTAS; Integrated Security=False; User Id=SoftVentas; Password=123";

            ComprobarConexion();
            if (indicador.Equals("CONECTADO"))
            {
               frmEncriptar.SaveToXML(aes.Encrypt(strConexion, Desencryptation.appPwdUnique, int.Parse("256")));
                if (IdCaja > 0)
                {
                    MessageBox.Show("Conexión establecida!, vuelva a abrir el sistema", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
                else
                {
                    frmCajaRemota.strConexion = strConexion;
                    Dispose();
                    frmCajaRemota cajaRemota = new frmCajaRemota();
                    cajaRemota.Show();
                }
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
