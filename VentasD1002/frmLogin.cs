using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string Usuario;
        string serialPC;
        public static int IdCaja;
        public static int idusuario;
        private User _user;

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();
            DibujarLogin();
            panelIniciarSesion.Visible = false;
            lblIP.Text = Sistema.ObtenerIP();
            pbLogoEmpresa.Image = DatEmpresa.ObtenerLogoEmpresa();
        }

        private void DibujarLogin()
        {
            try
            {
                User u = new User();
                u.Usuario = "";
                u.Contraseña = "";

                List<User> lstUser = new BusUser().getUsersList(u);
                foreach (var item in lstUser)
                {
                    Label label = new Label();
                    Panel panel = new Panel();
                    RJCodeAdvance.RJControls.RJCircularPictureBox picture = new RJCodeAdvance.RJControls.RJCircularPictureBox();

                    label.Text = item.Usuario;
                    label.Name = item.Id.ToString();
                    label.Size = new Size(90, 23);
                    label.Font = new Font("Microsoft Sans Serif", 13);
                    label.FlatStyle = FlatStyle.Flat;
                    label.BackColor = Color.FromArgb(176, 196, 222);
                    label.ForeColor = Color.Black;
                    label.Dock = DockStyle.Bottom;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Cursor = Cursors.Hand;

                    panel.Size = new Size(90, 115);
                    panel.BorderStyle = BorderStyle.None;
                    panel.Dock = DockStyle.Top;
                    panel.BackColor = Color.FromArgb(176, 196, 222);

                    picture.Size = new Size(90, 90);
                    picture.Dock = DockStyle.Top;
                    picture.BackgroundImage = null;
                    byte[] b = item.Foto;
                    MemoryStream ms = new MemoryStream(b);
                    picture.Image = Image.FromStream(ms);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.Tag = item.Usuario;
                    picture.Cursor = Cursors.Hand;
                    picture.BorderColor = Color.FromArgb(30, 14, 31);
                    picture.BorderColor2 = Color.FromArgb(30, 14, 31);

                    panel.Controls.Add(label);
                    panel.Controls.Add(picture);
                    label.BringToFront();
                    flowLayoutPanelUsuarios.Controls.Add(panel);

                    label.Click += new EventHandler(myLabelEvent);
                    picture.Click += new EventHandler(myPictureEvent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void myPictureEvent(object sender, EventArgs e)
        {
            Usuario = ((PictureBox)sender).Tag.ToString();
            panelIniciarSesion.Visible = true;
            lblUsuario.Text = Usuario;
        }

        private void myLabelEvent(object sender, EventArgs e)
        {
            Usuario = ((Label)sender).Text;
            panelIniciarSesion.Visible = true;
            lblUsuario.Text = Usuario;
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            panelIniciarSesion.Visible = false;
            txtContraseña.Clear();
        }

        private void tver_Click(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '\0';
            tocultar.Visible = true;
            tver.Visible = false;
        }

        private void tocultar_Click(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
            tocultar.Visible = false;
            tver.Visible = true;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (ValidatePWD())
            {
                AccederSistema();
            }
        }

        private bool ValidatePWD()
        {
            try
            {
                var pwd = EncriptarTexto.Encriptar(txtContraseña.Text);
                var user = DatUser.Validate_UserCredentials(lblUsuario.Text, pwd);

                if (user.Id == 0)
                {
                    return false;
                }
                _user = user;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void AccederSistema()
        {
            try
            {
                string serialPC = EncriptarTexto.Encriptar(Sistema.ObenterSerialPC());

                var session = CajaDAL.ValidarSesion(serialPC);

                if (_user.Id == session.Id)
                {
                    this.Hide();
                    frmPrincipal frmPrincipal = new frmPrincipal();
                    frmPrincipal.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    if (session.Nombre.ToUpper().Equals("N/A") && session.Id == 0)
                    {
                        new DatCatGenerico().Editar_InicioSesion(serialPC, _user.Id);
                        this.Hide();
                        frmSplashScreen frmSplash = new frmSplashScreen();
                        frmSplash.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show($"Existe una sesión activa con el usuario {session.Usuario},\n¿Desea continuar?\nde lo contrario inicie sesión con el usuario loggeado", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            new DatCatGenerico().Editar_InicioSesion(serialPC, _user.Id);
                            this.Hide();
                            frmSplashScreen frmSplash = new frmSplashScreen();
                            frmSplash.ShowDialog();
                            this.Dispose();
                        }
                        else
                        {
                            panelIniciarSesion.Visible = false;
                            txtContraseña.Clear();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            List<User> lstUsuarios = new BusUser().ListarUsuarios();
            int contadorUsuario = lstUsuarios.Count;
            string INDICADOR = DatUser.AUX_CONEXION;
            //   MessageBox.Show(INDICADOR);

            if (DatUser.AUX_CONEXION == "CORRECTO")
            {
                if (contadorUsuario == 0 || lstUsuarios == null)
                {
                    Hide();
                    frmRegistroEmpresa registroEmpresa = new frmRegistroEmpresa();
                    registroEmpresa.ShowDialog();
                    this.Dispose();
                }
            }

            if (DatUser.AUX_CONEXION == "INCORRECTO")
            {
                Hide();
                frmServidorRemoto servidorRemoto = new frmServidorRemoto();
                servidorRemoto.ShowDialog();
                this.Dispose();
            }

            try
            {
                ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
                //foreach (ManagementObject getSerial in mos.Get())
                //{
                serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
                IdCaja = BusBox.showBoxBySerial().Id;
                // }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                Licencia licencia = new BusLicencia().Obtener_LicenciaTemporal();

                dtpVencimiento.Value = Convert.ToDateTime(EncriptarTexto.Desencriptar(licencia.FechaVencimiento));
                string serial = EncriptarTexto.Desencriptar(licencia.Serial);
                string estado = EncriptarTexto.Desencriptar(licencia.Estado);
                dtpFechaActivacion.Value = Convert.ToDateTime(EncriptarTexto.Desencriptar(licencia.FechaActivacion));

                label3.Text = estado;
                label2.Text = serial;
                //dtpFechaActivacion.Value = Convert.ToDateTime( fechaActivacion );
                // dtpVencimiento.Value = Convert.ToDateTime( VencimientoLicencia );
                dtpFechaActivacion.Format = DateTimePickerFormat.Custom;
                dtpVencimiento.Format = DateTimePickerFormat.Custom;

                if (estado != "VENCIDO")
                {
                    string fechaActual = Convert.ToString(DateTime.Now);
                    DateTime hoy = Convert.ToDateTime(fechaActual.Split(' ')[0]);

                    if (dtpVencimiento.Value >= hoy)
                    {
                        int mes = dtpFechaActivacion.Value.Month;
                        int mesActual = hoy.Month;
                        if (mes <= mesActual)
                        {
                            if (estado.Equals("?ACTIVO?"))
                            {
                                lblLicencia.Text = "Licencia activada hasta el : " + dtpVencimiento.Value.ToString("dd/MM/yyyy");
                            }
                            else if (estado.Equals("?ACTIVADO PREMIUM?"))
                            {
                                lblLicencia.Text = "Licencia profesional Activada hasta el : " + dtpVencimiento.Value.ToString("dd/MM/yyyy");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        ProgressBar pb = new ProgressBar();

    }
}
