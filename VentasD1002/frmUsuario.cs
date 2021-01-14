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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        #region variables
        int id;
        #endregion
        
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            panelAgregarUsuarios.Visible = false;
            ListarUsuarios();
            LlenarCboRol();
        }

        public bool ValidateMail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        }

        private bool CamposObligatorios()
        {
            if (txtNombre.Text == "" || txtDireccion.Text == "" || txtCorreo.Text == "" || txtContraseña.Text == "" || pbFoto.Image == null || cboRol.SelectedItem.ToString() == "")
            {
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateMail(txtCorreo.Text) == false)
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
                        u.RolID = Convert.ToInt32(cboRol.SelectedValue); 
                        u.Estado = true;
                        new BusUser().AddUser(u);//txtNombre.Text, txtDireccion.Text, txtUsuario.Text, txtContraseña.Text, ms.GetBuffer(),lblNombreIcono.Text, txtCorreo.Text, cboRol.SelectedItem.ToString(), true );
                        MessageBox.Show("Operación realizada","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        panelAgregarUsuarios.Visible = false;
                        ListarUsuarios();
                        ClearFields();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            panelAgregarUsuarios.Visible = false;
            ClearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClearFields()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            pbFoto.Image = null;
            lblNombreIcono.Text = "";
            txtCorreo.Clear();
            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAgregarUsuarios.Visible = true;
            ClearFields();
            btnGuardar.Enabled = true;        
            btnGuardarCambios.Enabled = false;
        }

        private void ListarUsuarios()
        {
            User u = new User();
            //u.Usuario = "";
            //u.Contraseña = "";
            List<User> lstUsuarios = new BusUser().getUsersList(u);
            gdvUsuarios.DataSource = lstUsuarios;

            gdvUsuarios.Columns[0].Width = 15;
            gdvUsuarios.Columns[0].Width = 15;
            gdvUsuarios.Columns[2].Visible = false;
            gdvUsuarios.Columns[6].Visible = false;
            gdvUsuarios.Columns[7].Visible = false;
            gdvUsuarios.Columns[11].Visible = false;
            gdvUsuarios.Columns[12].Visible = false;
            gdvUsuarios.ClearSelection();

           // DataTablePersonalizado.Multilinea(ref gdvUsuarios);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gdvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.gdvUsuarios.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar éste usuario?", "Eliminar usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        foreach (DataGridViewRow row in gdvUsuarios.SelectedRows)
                        {
                            User u = new User();
                            u.Id = Convert.ToInt32(row.Cells["Id"].Value); ;
                            new BusUser().DeleteUser(u);
                            ListarUsuarios();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el usuario" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (e.ColumnIndex == this.gdvUsuarios.Columns["Editar"].Index)
            {
                id = Convert.ToInt32(gdvUsuarios.SelectedCells[2].Value.ToString());
                txtNombre.Text = gdvUsuarios.SelectedCells[3].Value.ToString();
                txtApellidos.Text = gdvUsuarios.SelectedCells[4].Value.ToString();
                txtDireccion.Text = gdvUsuarios.SelectedCells[5].Value.ToString();
                pbFoto.BackgroundImage = null;
                byte[] b = (byte[])gdvUsuarios.SelectedCells[6].Value;
                MemoryStream ms = new MemoryStream(b);
                pbFoto.Image = Image.FromStream(ms);
                panelAgregarUsuarios.Visible = true;
                btnGuardar.Enabled = false;
                lblNombreIcono.Text = gdvUsuarios.SelectedCells[7].Value.ToString();
                txtUsuario.Text = gdvUsuarios.SelectedCells[8].Value.ToString();
                string contraseña = EncriptarTexto.Desencriptar(gdvUsuarios.SelectedCells[9].Value.ToString());
                txtContraseña.Text = contraseña;
                txtCorreo.Text = gdvUsuarios.SelectedCells[10].Value.ToString();
                cboRol.Text = gdvUsuarios.SelectedCells[13].Value.ToString();

                btnGuardarCambios.Enabled = true;
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User();
                u.Nombre = txtNombre.Text;
                u.Apellidos = txtApellidos.Text;
                u.Direccion = txtDireccion.Text;
                u.Usuario = txtUsuario.Text;
                string contraseña = EncriptarTexto.Encriptar(txtContraseña.Text);
                u.Contraseña = contraseña;
                MemoryStream ms = new MemoryStream();
                pbFoto.Image.Save(ms,pbFoto.Image.RawFormat);
                u.Foto = ms.GetBuffer();
                u.NombreFoto = lblNombreIcono.Text;
                u.Correo = txtCorreo.Text;
                u.RolID = Convert.ToInt32 (cboRol.SelectedValue);
                u.Id = id;
                new BusUser().EditUser(u);
                MessageBox.Show("Usuario Actualizado","Actualizacion correcta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                panelAgregarUsuarios.Visible = false;
                ClearFields();
                ListarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConfiguracion configuracion = new frmConfiguracion();
            configuracion.ShowDialog();
            this.Dispose();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LlenarCboRol()
        {
            try
            {
                // List<CatalogoGenerico> lstcatalogoRol = new BusCatGenerico().ListarCat_TipoUsuario();
                // cboRol.Items.Insert(0, "Seleccione");
                DataTable dtCatalogoRol = DatVentas.DatCatGenerico.ListarCat_TipoUsuario();
                cboRol.DataSource = dtCatalogoRol;
                cboRol.DisplayMember = "Nombre";
                cboRol.ValueMember = "Id_Rol";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Orcurrio un error al llenar el Rol, contacte al Administrador" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelAgregarUsuarios.Visible = false;
            ClearFields();
           // ListarUsuarios();
        }
    }
}
