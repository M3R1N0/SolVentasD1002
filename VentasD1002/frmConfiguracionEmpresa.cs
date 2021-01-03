using BusVenta;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmConfiguracionEmpresa : Form
    {
        public frmConfiguracionEmpresa()
        {
            InitializeComponent();
        }

        private void frmConfiguracionEmpresa_Load(object sender, EventArgs e)
        {
            Obtener_Empresa();
        }

        public bool ValidateMail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        }

        private void panelRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siguienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ( ValidateMail(txtCorreo.Text) == false )
            {
                MessageBox.Show("El correo debe tener el siguiente formato :\n ejemplo_123@dominio.com","Validacion correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCorreo.Focus();
                txtCorreo.SelectAll();
            }

            try
            {
                if (txtNombreEmpresa.Text == "" || txtCorreo.Text == "" || txtRutaBackup.Text == "" || pbLogo.Image == null )
                {
                    MessageBox.Show("Favor de llenar todos los campos ", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbLogo.Image.Save(ms, pbLogo.Image.RawFormat);
                    Empresa empresa = new Empresa();

                    empresa.Nombre = txtNombreEmpresa.Text;
                    empresa.Moneda = cboMoneda.Text;
                    empresa.Logo = ms.GetBuffer();
                    empresa.Pais = cboPaises.Text;
                    empresa.RutaBackup = txtRutaBackup.Text;
                    empresa.CorreoEnvio = txtCorreo.Text;

                    if (radioButtonSi.Checked)
                    {
                        empresa.Usa_Impuestos = "SI";
                        empresa.Impuesto = cboImpuesto1.Text;
                        empresa.Porcentaje = Convert.ToDecimal(cboPorcentaje.Text);
                    }

                    if (radioButtonNo.Checked)
                    {
                        empresa.Usa_Impuestos = "NO";
                        empresa.Impuesto = "N/A";
                        empresa.Porcentaje = 0;
                    }

                    
                    if (chckLectora.Checked)
                    {
                        empresa.Busqueda = "SCANNER";
                    }
                    if (chckTeclado.Checked)
                    {
                        empresa.Busqueda = "TECLADO";
                    }

                    new BusEmpresa().Actualizar_Empresa(empresa);
                    MessageBox.Show("Proceso Realizado", "Registro Exitoso");
                    this.Hide();
                    frmConfiguracion configuracion = new frmConfiguracion();
                    configuracion.ShowDialog();
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al actualizar los datos : "+ex.Message, "Actualizacion de datoa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Obtener_Empresa()
        {
            try
            {
                Empresa empresa = new BusEmpresa().ObtenerEmpresa();
                txtNombreEmpresa.Text = empresa.Nombre;
                pbLogo.BackgroundImage = null;
                Byte[] img = empresa.Logo;
                MemoryStream ms = new MemoryStream(img);
                pbLogo.Image = Image.FromStream(ms);
                cboPaises.Text = empresa.Pais;
                cboMoneda.Text = empresa.Moneda;

                if (empresa.Usa_Impuestos.Equals("SI"))
                {
                    radioButtonSi.Checked= true;
                    cboImpuesto1.Text = empresa.Impuesto;
                    cboPorcentaje.Text = empresa.Porcentaje.ToString();
                }
                else
                {
                    radioButtonNo.Checked = true;
                }

                if (empresa.Busqueda.Equals("SCANNER"))
                {
                    chckLectora.Checked = true;
                }
                else
                {
                    chckTeclado.Checked = true;
                }

                txtRutaBackup.Text = empresa.RutaBackup;
                txtCorreo.Text = empresa.CorreoEnvio;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un erro al mostrar los datos :\n "+ex.Message, "Configuracion empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConfiguracion configuracion = new frmConfiguracion();
            configuracion.ShowDialog();
            this.Dispose();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                ofd.InitialDirectory = "";
                ofd.Filter = "Imagenes|*.jpg;*.png";
                ofd.FilterIndex = 2;
                ofd.Title = "Cargar Logo de la empresa";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbLogo.BackgroundImage = null;
                    pbLogo.Image = new Bitmap(ofd.FileName);
                    pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    // lblNombreIcono.Text = Path.GetFileName(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRutaBackup.Text = folderBrowserDialog1.SelectedPath;
                string ruta = txtRutaBackup.Text;

                //if (ruta.Contains(@"C:\"))
                //{
                //    MessageBox.Show("Seleccione una ruta diferente al Disco C:", "Ruta no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtRutaBackup.Text = "";
                //}
                //else
                //{
                    txtRutaBackup.Text = folderBrowserDialog1.SelectedPath;
                //}
            }
        }

        private void txtRutaBackup_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
