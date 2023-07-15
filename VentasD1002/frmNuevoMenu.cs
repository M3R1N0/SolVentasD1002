using DatVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EntVenta.PermisoVM;

namespace VentasD1002
{
    public partial class frmNuevoMenu : Form
    {
        public frmNuevoMenu()
        {
            InitializeComponent();
        }

        private void cancelarVentaF9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && pbLogo.Image != null)
                {
                    MenuVM menu = new MenuVM();
                    menu.Nombre = txtNombre.Text.Trim();
                    MemoryStream ms = new MemoryStream();
                    pbLogo.Image.Save(ms, pbLogo.Image.RawFormat);
                    menu.Icono = ms.GetBuffer();

                    PermisoDAL.AgregarMenu(menu);

                }
                else
                {
                    MessageBox.Show("Favor de ingresar el nombre y/o cargar la imagen","ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                txtNombre.Clear();
                pbLogo.Image = null;
                this.Close();
            }
        }

        private void btnCargarLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                ofd.InitialDirectory = "";
                ofd.Filter = "Imagenes|*.jpg;*.png";
                ofd.FilterIndex = 2;
                ofd.Title = "Carga Foto de perfil";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbLogo.BackgroundImage = null;
                    pbLogo.Image = new Bitmap(ofd.FileName);
                    pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    //lblNombreIcono.Text = Path.GetFileName(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
