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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmCopiaAutomatica : Form
    {
        public frmCopiaAutomatica()
        {
            InitializeComponent();
        }

        private string strSoftware = "SISVENTAS";
        private string strBaseDatos = "softVentas";
        private Thread hilo;
        private bool termino = false;
        int contador = 10;
        int frecuencia;

        private void frmCopiaAutomatica_Load(object sender, EventArgs e)
        {
            cargarDatos();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador -= 1;
            lblContador.Text = contador.ToString();
            if (contador == 0)
            {
                timer1.Stop();
                contador = 0;
                lblContador.Text = contador.ToString();
                timerBackup.Start();
                GenerarCopiaSeguridad();
            }
           
        }

        private void cargarDatos()
        {
            try
            {
                Empresa e = new BusEmpresa().ObtenerEmpresa();

                txtRutaBackup.Text = e.RutaBackup;
                frecuencia = e.FrecuenciaBackup;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al obtener los datos : " + ex.Message, "Erro de lectura de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarCopiaSeguridad()
        {
            try
            {
                string carpeta = @"\BackupData_" + strSoftware;
                string rutaCompleta = txtRutaBackup.Text + carpeta;

                if (System.IO.Directory.Exists(txtRutaBackup.Text + carpeta))
                {

                }
                else
                {
                    System.IO.Directory.CreateDirectory(txtRutaBackup.Text + carpeta);
                }

                string date = DateTime.Now.ToString().Replace(' ', '_').Replace("/", "").Replace(":", "").Replace(".", "");
                string subCarpeta = rutaCompleta + @"\Respaldo_" + date;

                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(rutaCompleta, subCarpeta));

                string nombreRespaldo = strBaseDatos + ".bak";

                // termino = new DatCatGenerico().GenerarRespaldo(subCarpeta, nombreRespaldo);
                SqlConnection connection = new SqlConnection(MasterConnection.connection);
                connection.Open();
                SqlCommand cmd = new SqlCommand("BACKUP DATABASE DBVENTAS TO DISK = '" + subCarpeta + @"\" + nombreRespaldo + "'", connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                termino = true;
            }
            catch (Exception ex)
            {
                termino = false;
                MessageBox.Show("Error al crear la carpeta", "Carpeta no creada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerBackup_Tick(object sender, EventArgs e)
        {
            if (termino == true)
            {
                timerBackup.Stop();
                EditarRespaldos();
            }
        }

        private void EditarRespaldos()
        {
            int resultado = new DatEmpresa().EditarEmpresa_CompiaSeguridad(frecuencia);

            if (resultado != 0)
            {
               // MessageBox.Show("Copia generada correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void cANCELARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
