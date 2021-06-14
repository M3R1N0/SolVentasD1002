using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmRestaurarBD : Form
    {
        public frmRestaurarBD()
        {
            InitializeComponent();
        }

        private void frmRestaurarBD_Load(object sender, EventArgs e)
        {
            loading.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRutaBackup.Text = ofd.FileName.ToString();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtRutaBackup.Text))
            {
                MessageBox.Show("Seleccione el archivo para continuar", "Ruta no válida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                Restaurar_BD();
            }
        }

        private void Restaurar_BD()
        {
            try
            {
                string ext = Path.GetExtension(txtRutaBackup.Text);
                if (!ext.Equals(".bak"))
                {
                    MessageBox.Show("Seleccione el archivo con extension .bak para continuar", "Archivo no admitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    loading.Visible = true;
                    string DataBaseName = "DBVENTAS";
                    string server = @".\SQLEXPRESS";
                   
                    DialogResult result = MessageBox.Show("Está a punto de restaurar la base de Datos actual del sistema, ¿desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                       
                        SqlConnection cnn = new SqlConnection("Server=" + server + ";database=master; integrated security=yes");
                        try
                        {
                            cnn.Open();
                            string Proceso = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + DataBaseName + "' USE [master] ALTER DATABASE [" + DataBaseName + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [" + DataBaseName + "] RESTORE DATABASE " + DataBaseName + " FROM DISK = N'" + txtRutaBackup.Text + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                            SqlCommand BorraRestaura = new SqlCommand(Proceso, cnn);
                            BorraRestaura.ExecuteNonQuery();
                            loading.Visible = false;
                            MessageBox.Show("La base de datos ha sido restaurada satisfactoriamente! Vuelve a Iniciar El Aplicativo", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dispose();


                        }
                        catch (Exception)
                        {
                            RestaurarNoExpress();
                        }
                        finally
                        {
                            if (cnn.State == ConnectionState.Open)
                            {
                                cnn.Close();
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al restaurar la base de Datos "+ ex.Message, "Error de restauración", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RestaurarNoExpress()
        {
            string DataBaseName = "DBVENTAS";
            string server = ".";
            SqlConnection cnn = new SqlConnection("Server=" + server + ";database=master; integrated security=yes");
            try
            {
                cnn.Open();
                string Proceso = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + DataBaseName + "' USE [master] ALTER DATABASE [" + DataBaseName + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [" + DataBaseName + "] RESTORE DATABASE " + DataBaseName + " FROM DISK = N'" + txtRutaBackup.Text + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                SqlCommand BorraRestaura = new SqlCommand(Proceso, cnn);
                BorraRestaura.ExecuteNonQuery();
                loading.Visible = false;
                MessageBox.Show("La base de datos ha sido restaurada satisfactoriamente! Vuelve a Iniciar El Aplicativo", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la BD : " + ex.Message, "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

      
    }
}
