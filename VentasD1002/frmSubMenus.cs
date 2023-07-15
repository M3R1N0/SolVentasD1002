using BusVenta.Helpers;
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
    public partial class frmSubMenus : Form
    {
        public object Comum { get; private set; }

        public frmSubMenus()
        {
            InitializeComponent();
            ObtenerMenus();
            ListarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoMenu frmMenu = new frmNuevoMenu();
            frmMenu.ShowDialog();
            ObtenerMenus();
        }

        private void ObtenerMenus()
        {
            try
            {
                PermisoDAL.ListarMenu(ref cboMenu);
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtFormulario.Text) && !string.IsNullOrEmpty(txtNombre.Text)
                    && pbLogo.Image != null)
                {
                    SubMenu sub = new SubMenu();
                    sub.IdMenu = Convert.ToInt32(cboMenu.SelectedValue);
                    sub.Nombre = txtNombre.Text.Trim();
                    sub.NombreForm = txtFormulario.Text.Trim();

                    MemoryStream ms = new MemoryStream();
                    pbLogo.Image.Save(ms, pbLogo.Image.RawFormat);
                    sub.Icono = ms.GetBuffer();

                    PermisoDAL.AgregarSubMenu(sub);

                    MessageBox.Show("Operación realizada correctamente", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Todos los campos son necesarios, favor de llenarlos", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtFormulario.Clear();
                txtNombre.Clear();
                pbLogo.Image = null;
                //ObtenerMenus();
                ListarDatos();
            }
        }

        private void ListarDatos()
        {
            try
            {
                PermisoDAL.ListarSubMenus(ref grid);
                Comun.StyleDatatable(ref grid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
