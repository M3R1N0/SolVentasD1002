using DatVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VentasD1002
{
    public partial class frmInstalacionServidor : Form
    {
        public frmInstalacionServidor()
        {
            InitializeComponent();
        }

        string NombreEquipo;

        private void frmInstalacionServidor_Load(object sender, EventArgs e)
        {
            
            panelBuscandoServidor.Visible = true;
            panelInstalandoServidor.Visible = false;

            NombreEquipo = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            txtServidor.Text = @".\" + txtServidor.Text;
            Verificar_ServidorInstalado();

            ScriptElimnarDB = ScriptElimnarDB.Replace("DBVENTAS", txtDB.Text);
            txtTablasSP.Text = txtTablasSP.Text.Replace("DBVENTAS", txtDB.Text);
            txtScriptUsuarioRemoto.Text = txtScriptUsuarioRemoto.Text.Replace("ada369", txtUsuario.Text);
            txtScriptUsuarioRemoto.Text = txtScriptUsuarioRemoto.Text.Replace("BASEADA", txtDB.Text);
            txtScriptUsuarioRemoto.Text = txtScriptUsuarioRemoto.Text.Replace("softwarereal", txtpwd.Text);
            // Cursor = Cursors.WaitCursor;

            txtTablasSP.Text = txtTablasSP.Text + Environment.NewLine + txtScriptUsuarioRemoto.Text;

        }

        #region  SERVIDOR INSTALADO

        #region VARIABLES
        private string ScriptElimnarDB = "ALTER DATABASE DBVENTAS SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE DBVENTAS";
        private DatVentas.AES aes = new DatVentas.AES();
        string ruta;
        public static int milisegundos;
        public static int segundos;
        #endregion

        private void Verificar_ServidorInstalado()
        {
            EliminarScript_BD();
            CrearBD();
        }

        private void CrearBD()
        {
            var conn = new SqlConnection("Server=" + txtServidor.Text + ";Database = Master; Trusted_Connection=True");
            try
            {
                string bd = "CREATE DATABASE " + txtDB.Text;
                var cmd = new SqlCommand(bd, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                SaveToXML(aes.Encrypt("Server=" + txtServidor.Text + ";Database =" + txtDB.Text + "; Trusted_Connection=True", DatVentas.Desencryptation.appPwdUnique, int.Parse("256")));
                CrearTablas_SP();
                panelBuscandoServidor.Visible = true;
                panelInstalandoServidor.Visible = false;
               // panelInstalandoServidor.Dock = DockStyle.Fill;
                lblBuscandoServidor.Text = "Espere un momento, para terminar de configurar la Base de Datos";
               // pnlTemporizador.Visible = false;
                timer4.Start();
            }
            catch (Exception ex)
            {
                //this.Cursor = Cursors.Default;
                panelBuscandoServidor.Visible = true;
               // pnlTemporizador.Visible = true;
                panelInstalandoServidor.Visible = false;
                lblBuscandoServidor.Text = "De click en el boton instalar servidor...";
                conn.Close();
                // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CrearTablas_SP()
        {
            try
            {
                ruta = Path.Combine(Directory.GetCurrentDirectory(), txtNombreScript.Text + ".txt");
                FileInfo file = new FileInfo(ruta);
                StreamWriter sw;

                if (File.Exists(ruta) == false)
                {
                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtTablasSP.Text);
                    sw.Flush();
                    sw.Close();
                }
                else if (File.Exists(ruta) == true)
                {
                    File.Delete(ruta);
                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtTablasSP.Text);
                    sw.Flush();
                    sw.Close();
                }

                Process process = new Process();
                process.StartInfo.FileName = "sqlcmd";
                process.StartInfo.Arguments = " -S " + txtServidor.Text + " -i " + txtNombreScript.Text + ".txt";
                process.Start();

                timer1.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarScript_BD()
        {
            //string str;
            try
            {
                //Server=localhost;Database=ABARROTERA;User ID=ORTHEGA\Orthega ;Trusted_Connection=True;
                SqlConnection connection = new SqlConnection("Server=" + txtServidor.Text + ";Database = Master; Trusted_Connection=True");
                SqlCommand sc = new SqlCommand(ScriptElimnarDB, connection);
                connection.Open();
                sc.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                //  MessageBox.Show( ex.Message, "Error", MessageBoxButtons.OK   , MessageBoxIcon.Error);
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

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();

            milisegundos += 1;
            lblMilseg.Text = Convert.ToString(milisegundos);
            if (milisegundos == 60)
            {
                segundos += 1;
                lblSeg.Text = Convert.ToString(segundos);
                milisegundos = 0;
            }

            if (segundos == 15)
            {
                timer4.Stop();
                try
                {
                    File.Delete(ruta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Dispose();
                Application.Restart();
            }
        }

        #endregion

        #region INSTALAR SERVIDOR

        #region VARIABLLES INSTALACION
        public static int ms;
        public static int seg;
        public static int min;
        #endregion

        private void btnInstalarServidor_Click_1(object sender, EventArgs e)
        {
            try
            {
                richtxtConfiguracion.Text = richtxtConfiguracion.Text.Replace("PRUEBAFINAL22", txtServidor.Text);
                timerConfiguacionINI.Start();
                Ejecutar();
                timer2.Start();
                panelBuscandoServidor.Visible = false;
                panelInstalandoServidor.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ejecutar()
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "SQLEXPR_x86_ESN.exe";
                process.StartInfo.Arguments = "/ConfigurationFile=ConfigurationFile.ini /ACTION=Install /IACCEPTSQLSERVERLICENSETERMS /SECURITYMODE=SQL /SAPWD=" + txtpwd.Text + " /SQLSYSADMINACCOUNTS=" + NombreEquipo;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();

                panelInstalandoServidor.Visible = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void timerConfiguacionINI_Tick(object sender, EventArgs e)
        {
            string rutaConfiguracion;
            StreamWriter writer;

            rutaConfiguracion = Path.Combine(Directory.GetCurrentDirectory(), "ConfigurationFile.ini");
            rutaConfiguracion = rutaConfiguracion.Replace("ConfigurationFile.ini", @"SQLEXPR_x86_ESN\ConfigurationFile.ini");

            if (File.Exists(rutaConfiguracion))
            {
                timerConfiguacionINI.Stop();
            }

            try
            {
                writer = File.CreateText(rutaConfiguracion);
                writer.WriteLine(richtxtConfiguracion.Text);
                writer.Flush();
                writer.Close();
                timerConfiguacionINI.Stop();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ms += 1;
            string milSeg = ms.ToString();
            if (ms == 60)
            {
                seg += 1;
                lblSegundo.Text = seg.ToString();

                ms = 0;
            }

            if (seg == 60)
            {
                min += 1;
                lblMinuto.Text = min.ToString();

                seg = 0;
            }

            if (min == 6)
            {
                timer2.Enabled = false;
                Ejecutar_EliminarScript_BD();
                Ejecutar_CrearBD();
                timer3.Start();
            }
        }

        private void Ejecutar_CrearBD()
        {
            var conn = new SqlConnection("Server=" + txtServidor.Text + ";Database = Master; Trusted_Connection=True");
            try
            {
                string bd = "CREATE DATABASE " + txtDB.Text;
                var cmd = new SqlCommand(bd, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                SaveToXML(aes.Encrypt("Server=" + txtServidor.Text + ";Database =" + txtDB.Text + "; Trusted_Connection=True", DatVentas.Desencryptation.appPwdUnique, int.Parse("256")));
                CrearTablas_SP();
               
                timer4.Start();
            }
            catch (Exception ex)
            {
                conn.Close();
                // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ejecutar_EliminarScript_BD()
        {
            try
            {
                //Server=localhost;Database=ABARROTERA;User ID=ORTHEGA\Orthega ;Trusted_Connection=True;
                SqlConnection connection = new SqlConnection("Server=" + txtServidor.Text + ";Database = Master; Trusted_Connection=True");
                SqlCommand sc = new SqlCommand(ScriptElimnarDB, connection);
                connection.Open();
                sc.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                //  MessageBox.Show( ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ms += 1;
            string milSeg = ms.ToString();
            if (ms == 60)
            {
                seg += 1;
                lblSegundo.Text = seg.ToString();

                ms = 0;
            }

            if (seg == 60)
            {
                min += 1;
                lblMinuto.Text = min.ToString();

                seg = 0;
            }

            if (min == 1)
            {
                Ejecutar_EliminarScript_BD();
                Ejecutar_CrearBD();
            }
        }



        #endregion

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
