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
    public partial class frmCopiaSeguridad : Form
    {
        public frmCopiaSeguridad()
        {
            InitializeComponent();
        }

        private string strSoftware = "SISVENTAS";
        private string strBaseDatos = "softVentas";
        private Thread hilo;
        private bool termino = false;

        private void frmCopiaSeguridad_Load(object sender, EventArgs e)
        {
            loading.Visible = false;
            cargarDatos();
        }

        private void cargarDatos()
        {
            try
            {
                Empresa e = new BusEmpresa().ObtenerEmpresa();

                txtRutaBackup.Text = e.RutaBackup;
                cboFrecuencia.Text = e.FrecuenciaBackup.ToString();
                lblUltimaCopia.Text =""+ e.UltimaFechaBackup;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al obtener los datos : " + ex.Message, "Erro de lectura de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRutaBackup.Text))
            {
                // hilo = new Thread(new ThreadStart(guardarCopia));
                guardarCopia();
               loading.Visible = true;
              //  hilo.Start();
                timer1.Start();
            }
            else
            {
                MessageBox.Show("No existe la ruta para guardar la copia de seguridad", "Ruta no válida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guardarCopia()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (termino ==  true)
            {
                timer1.Stop();
                loading.Visible = false;
                lblCopiaGuardada.Text = "Copia guardada en: " + txtRutaBackup.Text + @"\" + "softVentas.bak";
               

                EditarRespaldos();
            }
        }

        private void EditarRespaldos()
        {
            int resultado = new DatEmpresa().EditarEmpresa_CompiaSeguridad(Convert.ToInt32(cboFrecuencia.Text));

            if (resultado != 0)
            {
                MessageBox.Show("Proceso realizado con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void pbLoading_Click(object sender, EventArgs e)
        {

        }
    }
}
