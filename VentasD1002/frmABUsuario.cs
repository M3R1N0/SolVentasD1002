using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
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

namespace VentasD1002
{
    public partial class frmABUsuario : Form
    {
        public frmABUsuario()
        {
            InitializeComponent();
            cboRol.Enabled = true;
            LlenarCboRol(2);
        }

        public frmABUsuario(int idUsuario)
        {
            InitializeComponent();
            ObtenerDatos(idUsuario);
        }

        private void ObtenerDatos(int idUsuario)
        {
            try
            {
                var user = DatUser.ObtenerUsuario(idUsuario);
                lblID.Text = user.Id.ToString();
                txtNombre.Text = user.Nombre;
                txtApellidos.Text = user.Apellidos;
                txtDireccion.Text = user.Direccion;
                txtCorreo.Text = user.Correo;
                txtUsuario.Text = user.Usuario;
                txtContraseña.Text = EncriptarTexto.Desencriptar(user.Contraseña);
                LlenarCboRol(user.IdRol);
                cboRol.Enabled = false;

                MemoryStream ms = new MemoryStream(user.Foto);
                Image img = Image.FromStream(ms);
                pbFoto.Image = img;
            }
            catch (Exception)
            {
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Comun.ValidateMail(txtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no valido,debe tener el siguiente formato : 'ejemplo@gmail.com, " + "Favor de ingresar correo válido", "Validadción Correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
                txtCorreo.SelectAll();
            }
            else
            {
                try
                {
                    if (CamposObligatorios())
                    {

                        User u = new User();
                        u.Nombre = txtNombre.Text;
                        u.Apellidos = txtApellidos.Text;
                        u.Direccion = txtDireccion.Text;
                        u.Usuario = txtUsuario.Text;
                        string contraseña = EncriptarTexto.Encriptar(txtContraseña.Text);
                        u.Contraseña = contraseña;
                        MemoryStream ms = new MemoryStream();
                        pbFoto.Image.Save(ms, pbFoto.Image.RawFormat);
                        u.Foto = ms.GetBuffer();
                        u.NombreFoto = lblNombreIcono.Text;
                        u.Correo = txtCorreo.Text;
                        u.IdRol = Convert.ToInt32(cboRol.SelectedValue);
                        u.Estado = true;
                        u.Id = Convert.ToInt32(lblID.Text);

                        if (lblID.Text == "0")
                        {
                            new BusUser().AddUser(u);
                        }
                        else
                        {
                            new BusUser().EditUser(u);
                        }

                        MessageBox.Show("Operación realizada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Campos Obligatorios : [Nombre],[NombreFoto],[Rol],favor de verificar esten correctamente", "Falta llenar campos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool CamposObligatorios()
        {
            if (txtNombre.Text == "" || txtDireccion.Text == "" || txtCorreo.Text == "" || txtContraseña.Text == "" || pbFoto.Image == null || cboRol.SelectedItem.ToString() == "")
            {
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            Comun.LimpiarTextBox(this.Controls);
            lblID.Text = "0";
            pbFoto.Image = null;
        }


        private void LlenarCboRol(int id)
        {
            try
            {
                var dtCatalogoRol = DatVentas.DatCatGenerico.ListarCat_TipoUsuario();
                cboRol.DataSource = dtCatalogoRol;
                cboRol.DisplayMember = "Nombre";
                cboRol.ValueMember = "Id";
                cboRol.SelectedValue = id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Orcurrio un error al llenar el Rol, contacte al Administrador" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbFoto_Click(object sender, EventArgs e)
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
                    pbFoto.BackgroundImage = null;
                    pbFoto.Image = new Bitmap(ofd.FileName);
                    pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    lblNombreIcono.Text = Path.GetFileName(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Close();
        }

        private void chkMostrarOcultarPwd_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkMostrarOcultarPwd.Checked)
            {
                this.chkMostrarOcultarPwd.BackgroundImage = Properties.Resources.mostrar;
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                this.chkMostrarOcultarPwd.BackgroundImage = Properties.Resources.hide_64;
                txtContraseña.PasswordChar = '*';
            }
        }

      
    }
}
