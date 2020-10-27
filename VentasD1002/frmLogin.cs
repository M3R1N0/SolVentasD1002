using BusVenta;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using DatVentas;
using System.Data;

namespace VentasD1002
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

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
        string userPermision;
        string BoxPermission;
        int countMcsxu;
        List<User> lstLoggedUser;
        List<OpenCloseBox> lstOpenCloseDetail;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            DibujarLogin();
            timer1.Start();
            panelIniciarSesion.Visible = false;
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
                    PictureBox picture = new PictureBox();

                    label.Text = item.Usuario;
                    label.Name = item.Id.ToString();
                    label.Size = new Size(175, 25);
                    label.Font = new Font("Microsoft Sans Serif", 13);
                    label.FlatStyle = FlatStyle.Flat;
                    label.BackColor = Color.FromArgb(20, 20, 20);
                    label.ForeColor = Color.White;
                    label.Dock = DockStyle.Bottom;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Cursor = Cursors.Hand;

                    panel.Size = new Size(90, 90);
                    panel.BorderStyle = BorderStyle.None;
                    panel.Dock = DockStyle.Top;
                    panel.BackColor = Color.FromArgb(20, 20, 20);

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
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void myPictureEvent(object sender, EventArgs e)
        {
            Usuario = ((PictureBox)sender).Tag.ToString();
            panelIniciarSesion.Visible = true;
            ShowPermission();
        }

        private void myLabelEvent(object sender, EventArgs e)
        {
            Usuario = ((Label)sender).Text;
            panelIniciarSesion.Visible = true;
            //flowLayoutPanelUsuarios.Visible = false;
            ShowPermission();
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
            AccederSistema();
        }

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
             //   userPermision = lstLoggedUser.Select(x => x.Rol).First();
                if (contadorDCC == 0 & userPermision != "Solo Ventas")
                {
                    AddOpenCloseDetailBox();
                    Apertura = "NUEVO";
                    timer2.Start();
                }
                else
                {
                    if (userPermision != "Solo Ventas")
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
                            if (UserLoginNow == "Administrador" || Usuario == "Admininistrador"  || userPermision == "Administrador" )
                            {
                                MessageBox.Show("Continuaras Turno de *" + nameUserNow + " Todos los Registros seran con ese Usuario", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                BoxPermission = "Correcto";
                            }
                            if (loggedName == "Admin" && Usuario == "Admin")
                            {
                                BoxPermission = "Correcto";
                            }

                            else if (UserLoginNow != Usuario && userPermision !="Administrador")
                            {
                                MessageBox.Show("Para poder continuar con el Turno de *" + nameUserNow + "* ,Inicia sesion con el Usuario " + UserLoginNow + " -ó-el Usuario *admin*", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BoxPermission = "Vacio";
                            }
                            else if (UserLoginNow == Usuario)
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
                open.FechaInicio = DateTime.Today;
                open.FechaFin = DateTime.Today;
                open.FechaCierre = DateTime.Today;
                open.Ingresos = 0;
                open.Egresos = 0;
                open.Saldo = 0;
                open.UsuarioId =  u;
                open.TotalCalculado = 0;
                open.TotalReal = 0;
                open.Estado = true;
                open.Diferencia = 0;
                open.CadaId =b;

                new BusOpenCloseBox().AddOpenCloseBoxDetail(open);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ListOpenCloseDetailBox()
        {
            int auxcount=0;
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
            int auxCount=0;
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
                MessageBox.Show("Error al mostrar el usuario"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return auxCount;
        }

        private int GetSerialBoxByUser()
        {
            try
            {
                int idUsuario = lstLoggedUser.Select(x => x.Id).First();  
                countMcsxu = new BusOpenCloseBox().getMovOpenCloseBox(serialPC,idUsuario);
               
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
         //   MessageBox.Show(INDICADOR);

            if (DatUser.AUX_CONEXION == "CORRECTO" )
            {
                if ( contadorUsuario == 0 || lstUsuarios == null)
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
                    serialPC =  mos.Properties["SerialNumber"].Value.ToString().Trim();
                    IdCaja = new BusBox().showBoxBySerial(serialPC).Id;
               // }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                Licencia licencia = new BusLicencia().Obtener_LicenciaTemporal();

                 dtpVencimiento.Value = Convert.ToDateTime( EncriptarTexto.Desencriptar( licencia.FechaVencimiento ) );
                string serial = EncriptarTexto.Desencriptar( licencia.Serial );
                string estado = EncriptarTexto.Desencriptar( licencia.Estado );
                 dtpFechaActivacion.Value = Convert.ToDateTime( EncriptarTexto.Desencriptar( licencia.FechaActivacion ));

                label3.Text = estado;
                label2.Text = serial;
                //dtpFechaActivacion.Value = Convert.ToDateTime( fechaActivacion );
                // dtpVencimiento.Value = Convert.ToDateTime( VencimientoLicencia );
                dtpFechaActivacion.Format = DateTimePickerFormat.Custom;
                dtpVencimiento.Format = DateTimePickerFormat.Custom;

                if (estado != "VENCIDO")
                {
                    string fechaActual =Convert.ToString( DateTime.Now );
                    DateTime  hoy = Convert.ToDateTime(fechaActual.Split(' ')[0]);

                    if ( dtpVencimiento.Value >= hoy)
                    {
                        int mes = dtpFechaActivacion.Value.Month;
                        int mesActual = hoy.Month;
                        if ( mes <= mesActual)
                        {
                            if (estado.Equals("?ACTIVO?"))
                            {
                                lblLicencia.Text = "Licencia activada hasta el : " + dtpVencimiento.Value.ToString("dd/MM/yyyy");
                            }
                            else if ( estado.Equals("?ACTIVADO PREMIUM?"))
                            {
                                lblLicencia.Text = "Licencia profesional Activada hasta el : "+ dtpVencimiento.Value.ToString("dd/MM/yyyy");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowPermission()
        {
            userPermision = new BusUser().ShowPermision(Usuario);
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
                if ( tipoUsuario.Equals("ADMINISTRADOR"))
                {
                    new DatCatGenerico().Editar_InicioSesion( EncriptarTexto.Encriptar(serialPC), idusuario);
                    this.Hide();
                    frmDashboard dashboard = new frmDashboard();
                    dashboard.ShowDialog();
                    Dispose();
                }
                else
                {
                    if (Apertura == "NUEVO" & userPermision != "Solo Ventas")
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
    }
}
