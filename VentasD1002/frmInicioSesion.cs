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
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmInicioSesion : Form
    {
        #region variables
        private string Usuario;

        string loggedUser;
        string loggedName;
        string serialPC;
        public static int IdCaja;
        public static int idusuario;
        string Apertura;
        string UserLoginNow;
        string nameUserNow;
        string permisoUsuario;
        string BoxPermission;
        int countMcsxu;
        List<User> lstLoggedUser;
        List<OpenCloseBox> lstOpenCloseDetail;
        #endregion

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DibujarLogin();

            lblIP.Text = Sistema.ObtenerIP();
        }

        #region CARGA INICIAL

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
                    PictureBox picture = new PictureBox();

                    label.Text = item.Usuario;
                    label.Name = item.Id.ToString();
                    label.Size = new Size(175, 25);
                    label.Font = new Font("Microsoft Sans Serif", 13);
                    label.FlatStyle = FlatStyle.Flat;
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.Gainsboro;
                    label.Dock = DockStyle.Bottom;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Cursor = Cursors.Hand;

                    panel.Size = new Size(90, 90);
                    panel.BorderStyle = BorderStyle.None;
                    panel.Dock = DockStyle.Top;
                    panel.BackColor = Color.Transparent;

                    picture.Size = new Size(80, 80);
                    picture.Dock = DockStyle.Top;
                    picture.BackgroundImage = null;
                    byte[] b = item.Foto;
                    MemoryStream ms = new MemoryStream(b);
                    picture.Image = Image.FromStream(ms);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.Tag = item.Usuario;
                    picture.Cursor = Cursors.Hand;

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myPictureEvent(object sender, EventArgs e)
        {
            Usuario = ((PictureBox)sender).Tag.ToString();
            panelIniciarSesion.Visible = true;
            MostrarPermisos();
        }

        private void MostrarPermisos()
        {
            permisoUsuario = new BusUser().ShowPermision(Usuario);
        }

        private void myLabelEvent(object sender, EventArgs e)
        {
            Usuario = ((Label)sender).Text;
            panelIniciarSesion.Visible = true;
            //flowLayoutPanelUsuarios.Visible = false;
            MostrarPermisos();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelIniciarSesion.Visible = false;
            txtContraseña.Clear();
        }

        #endregion


        private void AccederSistema()
        {
            int LoggedCount = LoadUser();
            try
            {
                loggedName = lstLoggedUser.Select(u => u.Nombre).FirstOrDefault();
                loggedUser = lstLoggedUser.Select(u => u.Usuario).FirstOrDefault();
                idusuario = lstLoggedUser.Select(u => u.Id).FirstOrDefault();
            }
            catch
            { }

            if (LoggedCount > 0)
            {
                int contadorDCC = ListOpenCloseDetailBox();
                if (contadorDCC == 0 & permisoUsuario.ToUpper() != "VENDEDOR")
                {
                    AddOpenCloseDetailBox();
                    Apertura = "NUEVO";
                    timer2.Start();
                }
                else
                {
                    if (permisoUsuario.ToUpper() != "VENDEDOR")
                    {
                        GetSerialBoxByUser();
                        try
                        {
                            ListOpenCloseDetailBox();
                            UserLoginNow = lstOpenCloseDetail.Select(x => x.UsuarioId.Usuario).FirstOrDefault();
                            nameUserNow = lstOpenCloseDetail.Select(x => x.UsuarioId.Nombre).FirstOrDefault();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        if (countMcsxu == 0)
                        {
                            if (UserLoginNow.ToUpper() == "ADMINISTRADOR" || Usuario.ToUpper() == "ADMINISTRADOR" || permisoUsuario.ToUpper() == "ADMINISTRADOR")
                            {
                                MessageBox.Show("Continuaras Turno de *" + nameUserNow + " Todos los Registros seran con ese Usuario", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                BoxPermission = "Correcto";
                            }
                            if (loggedName == "Admin" && Usuario == "Admin")
                            {
                                BoxPermission = "Correcto";
                            }

                            else if (UserLoginNow.ToUpper() != Usuario.ToUpper() && permisoUsuario.ToUpper() != "ADMINISTRADOR")
                            {
                                MessageBox.Show("Para poder continuar con el Turno de *" + nameUserNow + "* ,Inicia sesion con el Usuario " + UserLoginNow + " -ó-el Usuario *admin*", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BoxPermission = "Vacio";
                            }
                            else if (UserLoginNow.ToUpper() == Usuario.ToUpper())
                            {
                                BoxPermission = "Correcto";
                            }
                        }
                        else
                        {
                            BoxPermission = "Correcto";
                        }
                        if (BoxPermission == "Correcto")
                        {
                            Apertura = "Aperturado";
                            timer2.Start();
                        }
                    }
                    else
                    {
                        timer2.Start();
                    }
                }
            }
        }

        private void AddOpenCloseDetailBox()
        {
            try
            {
                int usuarioID = lstLoggedUser.Select(x => x.Id).First();
                User u = new User();
                u.Id = usuarioID;
                Box b = new Box();
                b.Id = IdCaja;
                OpenCloseBox open = new OpenCloseBox();
                open.FechaInicio = DateTime.Now;
                open.FechaFin = DateTime.Now;
                open.FechaCierre = DateTime.Now;
                open.Ingresos = 0;
                open.Egresos = 0;
                open.Saldo = 0;
                open.UsuarioId = u;
                open.TotalCalculado = 0;
                open.TotalReal = 0;
                open.Estado = true;
                open.Diferencia = 0;
                open.CadaId = b;

                BusOpenCloseBox.AddOpenCloseBoxDetail(open);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ListOpenCloseDetailBox()
        {
            int auxcount = 0;
            try
            {
                lstOpenCloseDetail = new BusOpenCloseBox().showMovBoxBySerial(serialPC);
                auxcount = lstOpenCloseDetail.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return auxcount;
        }

        private int LoadUser()
        {
            int auxCount = 0;
            try
            {
                User u = new User();
                u.Contraseña = EncriptarTexto.Encriptar(txtContraseña.Text);
                u.Usuario = Usuario;

                lstLoggedUser = new BusUser().getUsersList(u);
                auxCount = lstLoggedUser.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el usuario" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return auxCount;
        }

        private int GetSerialBoxByUser()
        {
            try
            {
                int idUsuario = lstLoggedUser.Select(x => x.Id).First();
                countMcsxu = new BusOpenCloseBox().getMovOpenCloseBox(serialPC, idUsuario);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return countMcsxu;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            List<User> lstUsuarios = new BusUser().ListarUsuarios();
            int contadorUsuario = lstUsuarios.Count;
            string INDICADOR = DatUser.AUX_CONEXION;

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
                serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
                IdCaja =  BusBox.showBoxBySerial().Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        ProgressBar pb = new ProgressBar();
        private void timer2_Tick(object sender, EventArgs e)
        {
            pb.Maximum = 100;
            if (pb.Value < 100)
            {
                pb.Value = pb.Value + 10;
            }
            else
            {
                pb.Value = 0;
                timer2.Stop();

                var tipoUsuario = lstLoggedUser.Select(x => x.Rol).First();
                if (tipoUsuario.ToUpper().Equals("ADMINISTRADOR"))
                {
                    new DatCatGenerico().Editar_InicioSesion(EncriptarTexto.Encriptar(serialPC), idusuario);
                    this.Hide();
                    frmDashboard dashboard = new frmDashboard();
                    dashboard.ShowDialog();
                    Dispose();
                }
                else
                {
                    if (Apertura == "NUEVO" & permisoUsuario.ToUpper() != "VENDEDOR")
                    {
                        new DatCatGenerico().Editar_InicioSesion(EncriptarTexto.Encriptar(serialPC), idusuario);
                        this.Hide();
                        frmAperturaCaja frm = new frmAperturaCaja();
                        frm.ShowDialog();
                        UserLoginNow = null;
                        nameUserNow = null;
                    }
                    else
                    {
                        this.Hide();
                        new DatCatGenerico().Editar_InicioSesion(EncriptarTexto.Encriptar(serialPC), idusuario);
                        frmMenuPrincipal principal = new frmMenuPrincipal();
                        principal.ShowDialog();
                        UserLoginNow = null;
                        nameUserNow = null;
                    }
                }
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            AccederSistema();
        }
    }
}
