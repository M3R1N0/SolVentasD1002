using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DatVentas
{
    public  partial class frmEncriptar : Form
    {
        public frmEncriptar()
        {
            InitializeComponent();
            ReadFromXML();
        }

        private  AES aes = new AES();

        public  static void SaveToXML(object dbcnString)
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

        string dbcnString;

        public void ReadFromXML()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ConnectionString.xml");
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes[0].Value;
                txtCnString.Text = (aes.Decrypt(dbcnString, Desencryptation.appPwdUnique, int.Parse("256")));

            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {
                throw ex;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveToXML(aes.Encrypt(txtCnString.Text, Desencryptation.appPwdUnique, int.Parse("256")));
            probarConexion();
        }

        private void probarConexion()
        {
            try
            {
                // public static string connection = @"Data source=ORTHEGA\SQLEXPRESS; Initial Catalog=VentaD1002; Integrated Security=True";
                DataTable dt = new DataTable();
                SqlConnection connection = new SqlConnection(MasterConnection.connection);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_Usuario", connection);
                da.Fill(dt);
                connection.Close();
                MessageBox.Show("Conexion establecida","EXITO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion"+ex.Message);
            }
        }

        private void frmEncriptar_Load(object sender, EventArgs e)
        {

        }
    }
}
