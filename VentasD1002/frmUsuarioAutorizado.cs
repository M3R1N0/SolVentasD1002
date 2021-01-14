using BusVenta;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmUsuarioAutorizado : Form
    {
        public frmUsuarioAutorizado()
        {
            InitializeComponent();
        }

        string SerialPC;
        private void frmUsuarioAutorizado_Load(object sender, EventArgs e)
        {
            LlenarCboRol();

            ManagementObject MOS = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");

            SerialPC = MOS.Properties["SerialNumber"].Value.ToString().Trim();
        }

        private void siguienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregarUsuarioAdmin();
        }

        private void LlenarCboRol()
        {
            try
            {
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

        private bool CamposObligatorios()
        {
            if (txtNombre.Text == "" || txtDireccion.Text == "" || txtCorreo.Text == "" || txtContraseña.Text == "" || pbFoto.Image == null || cboRol.SelectedItem.ToString() == "")
            {
                return false;
            }
            return true;
        }

        public bool ValidateMail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                ofd.InitialDirectory = "";
                ofd.Filter = "Imagenes|*.jpg;*.png";
                ofd.FilterIndex = 2;
                ofd.Title = "Cargar Foto de perfil";

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

        #region INSERCIÓN INICIAL DE DATOS

        private void AgregarUsuarioAdmin()
        {
            if (!CamposObligatorios())
            {
                MessageBox.Show("Ingrese el todos los campos", "Falta campos por llenar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtContraseña.Text.Equals(txtConfirmacion.Text))
                {
                    string contraseñaEncriptada = BusVenta.EncriptarTexto.Encriptar(txtContraseña.Text);
                    if (ValidateMail(txtCorreo.Text))
                    {
                        User u = new User();
                        u.Nombre = txtNombre.Text;
                        u.Apellidos = txtApellidos.Text;
                        u.Direccion = txtDireccion.Text;
                        u.Usuario = txtUsuario.Text;
                        u.Contraseña = contraseñaEncriptada;
                        MemoryStream ms = new MemoryStream();
                        pbFoto.Image.Save(ms, pbFoto.Image.RawFormat);
                        u.Foto = ms.GetBuffer();
                        u.NombreFoto = lblNombreIcono.Text;
                        u.Correo = txtCorreo.Text;
                        u.RolID = Convert.ToInt32(cboRol.SelectedValue);
                        u.Estado = true;
                        new BusUser().AddUser(u);
                        AgregarLicencia_Prueba();
                        Agregar_cliente();
                        AgregarCategoria_Producto();
                        Agregar_InicioSesion();

                        MessageBox.Show("Operación realizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();

                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cuenta de correo válida, ej: ejemplo@gmail.com", "Correo no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña no coincide, verifique por favor!", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AgregarLicencia_Prueba()
        {
            try
            {
                DateTime hoy = DateTime.Now;
                DateTime fechaFinal = hoy.AddDays(30);

                string fechaVencida = EncriptarTexto.Encriptar( fechaFinal.ToString() );
                string serialPCE = EncriptarTexto.Encriptar( SerialPC );
                string estado = EncriptarTexto.Encriptar( "?ACTIVO?" );
                string fechaActivacion = EncriptarTexto.Encriptar( hoy.ToString() );

                new DatVentas.DatLicencia().AgregarLicencia( serialPCE, fechaVencida, estado, fechaActivacion );

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Agregar_cliente()
        {
            try
            {
                Cliente c = new Cliente();
                c.NombreCompleto = "GENERAL";
                c.Direccion = "N/A";
                c.Ruc = "N/A";
                c.Telefono = "N/A";
                c.Clientes = "N/A";
                c.Proveedor = "N/A";
                c.Saldo = 0;
                c.Estado = true;

                new BusCliente().Agregar_Cliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar el cliente/ proveedor "+ ex.Message, "Error  de insercion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void AgregarCategoria_Producto()
        {
            try
            {
                //INSERCION DE CATALODOS DE PRODUCTO
                CatalogoGenerico c = new CatalogoGenerico();
                c.Nombre = "--Seleccione--";
                c.Descripcion = "N/A";
                new BusCatGenerico().AgregarCategoriasGenericas(c, 1);

                CatalogoGenerico c1 = new CatalogoGenerico();
                c1.Nombre = "GENERAL";
                c1.Descripcion = "N/A";
                new BusCatGenerico().AgregarCategoriasGenericas(c1, 1);

                //INSECION DE TIPO PRESENTACIÓN
                CatalogoGenerico c3 = new CatalogoGenerico();
                c3.Nombre = "--Seleccione--";
                c3.Descripcion = "N/A";
                new BusCatGenerico().AgregarCategoriasGenericas(c3, 2);

                CatalogoGenerico c4 = new CatalogoGenerico();
                c4.Nombre = "PIEZA";
                c4.Descripcion = "PZA";
                new BusCatGenerico().AgregarCategoriasGenericas(c4, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Ocurrio un error al insertar las categorias de producto : "+ex.Message, "Error de insercion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Agregar_InicioSesion()
        {
            try
            {
                string encriptarSerial = EncriptarTexto.Encriptar(SerialPC);
                new DatVentas.DatCatGenerico().Insertar_InicioSesion( encriptarSerial );
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Ocurrio un error al insertar inicio de sesion : " + ex.Message, "Error de insercion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
