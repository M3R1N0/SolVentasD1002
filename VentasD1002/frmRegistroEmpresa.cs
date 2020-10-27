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
    public partial class frmRegistroEmpresa : Form
    {
        public frmRegistroEmpresa()
        {
            InitializeComponent();
        }

        private static string serialPC;

        private void frmRegistroEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
                serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cboImpuesto1.Enabled = false;
            cboPorcentaje.Enabled = false;
        }

        private void Guardar_Empresa()
        {
            try
            {
                if (txtNombreEmpresa.Text == "" || cboPaises.SelectedIndex == 0 || txtRutaBackup.Text == "" || txtNombreCaja.Text == ""
                    || txtCorreo.Text == "")
                {
                    MessageBox.Show( "Llene todos los campos del formulario", "Falta campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                else
                {
                    Empresa e = new Empresa();
                    MemoryStream ms = new MemoryStream();
                    e.Nombre = txtNombreEmpresa.Text;
                   
                    e.Moneda = cboMoneda.Text;

                    if (radioButtonSi.Checked)
                    {
                        e.Usa_Impuestos = "SI";
                        e.Impuesto = cboImpuesto1.Text;
                        e.Porcentaje = Convert.ToDecimal(cboPorcentaje.Text);
                    }
                    if (radioButtonNo.Checked)
                    {
                        
                        e.Usa_Impuestos = "NO";
                        e.Impuesto = "N/A";
                        e.Porcentaje = 0;
                    }

                    e.RutaBackup = txtRutaBackup.Text;
                    e.CorreoEnvio = txtCorreo.Text;
                    e.UltimoBackup = "NINGUNA";
                    e.UltimaFechaBackup = DateTime.Now;
                    e.FrecuenciaBackup = 1;
                    e.TipoEmpresa = "GENERAL";
                    e.Estado = "PENDIENTE";
                    e.Redondeo = "N/A";

                    if (chckLectora.Checked)
                    {
                        e.Busqueda = "SCANNER";
                    }
                    if (chckTeclado.Checked)
                    {
                        e.Busqueda = "TECLADO";
                    }

                    pbLogo.Image.Save(ms, pbLogo.Image.RawFormat);
                    e.Logo = ms.GetBuffer();
                    e.RutaBackup = txtRutaBackup.Text;
                    e.Pais = cboPaises.Text;

                    if (ValidateMail(txtCorreo.Text))
                    {
                        e.CorreoEnvio = txtCorreo.Text;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un correo con el formato valido : ejemplo@gail.com", "Correo no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    new BusEmpresa().Agregar_Empresa(e);
                    AgregarCaja();
                    AgregarSerializacion_Ticket();
                    this.Hide();
                    frmUsuarioAutorizado usuarioAutorizado = new frmUsuarioAutorizado();
                    usuarioAutorizado.ShowDialog();
                    this.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarCaja()
        {
            try
            {
                if (txtNombreCaja.Text != "")
                {
                    Box b = new Box();
                    b.Descripcion = txtNombreCaja.Text;
                    b.Tema = "CLARO";
                    b.SerialPC = serialPC;
                    b.ImpresoraTicket = "NINGUNA";
                    b.ImpresoraA4 = "NINGUNA";
                    b.Tipo = "PRINCIPAL";
                    b.Estado = true;

                    new BusBox().Agregar_Caja(b);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Ocurrio un error al agregar la caja "+ex.Message, "Error caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMoneda.SelectedIndex = cboPaises.SelectedIndex;
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                ofd.InitialDirectory = "";
                ofd.Filter = "Imagenes|*.jpg;*.png";
                ofd.FilterIndex = 2;
                ofd.Title = "Carga Logo empresa";

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
            if ( folderBrowserDialog1.ShowDialog() == DialogResult.OK )
            {
                txtRutaBackup.Text = folderBrowserDialog1.SelectedPath;
                string ruta = txtRutaBackup.Text;

                if ( ruta.Contains(@"C:\") )
                {
                    MessageBox.Show( "Seleccione una ruta diferente al Disco C:", "Ruta no válida", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    txtRutaBackup.Text = "";
                }
                else
                {
                    txtRutaBackup.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }

        public bool ValidateMail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        }

        private void AgregarSerializacion_Ticket()
        {
            try
            {
                #region  INSERTAR DATOS SERIALIZACION
                Serializacion s = new Serializacion();
                s.Serie = "T";
                s.Cantidad_Numero = "6";
                s.NumeroFin = "0";
                s.Tipo_Documento = "TICKET";
                s.Destino = "VENTAS";
                s.Por_Defecto = "SI";

                new BusSerializacion().Agregar_Serializacion(s);

                Serializacion s1 = new Serializacion();
                s1.Serie = "B";
                s1.Cantidad_Numero = "6";
                s1.NumeroFin = "0";
                s1.Tipo_Documento = "BOLETA";
                s1.Destino = "VENTAS";
                s1.Por_Defecto = "NO";

                new BusSerializacion().Agregar_Serializacion(s1);

                Serializacion s2 = new Serializacion();
                s2.Serie = "F";
                s2.Cantidad_Numero = "6";
                s2.NumeroFin = "0";
                s2.Tipo_Documento = "FACTURA";
                s2.Destino = "VENTAS";
                s2.Por_Defecto = "NO";

                new BusSerializacion().Agregar_Serializacion(s2);

                Serializacion s3 = new Serializacion();
                s3.Serie = "I";
                s3.Cantidad_Numero = "6";
                s3.NumeroFin = "0";
                s3.Tipo_Documento = "INGRESO";
                s3.Destino = "INGRESO DE COBROS";
                s3.Por_Defecto = "NO";

                new BusSerializacion().Agregar_Serializacion(s3);

                Serializacion s4 = new Serializacion();
                s4.Serie = "E";
                s4.Cantidad_Numero = "6";
                s4.NumeroFin = "0";
                s4.Tipo_Documento = "EGRESO";
                s4.Destino = "EGRESO DE PAGOS";
                s4.Por_Defecto = "NO";

                new BusSerializacion().Agregar_Serializacion(s4);

                #endregion

                #region INSERTAR DATOS TICKET
                try
                {
                    Ticket t = new Ticket();
                    t.Identificador_Fiscal = "RUC Identificador Fiscal de la Empresa";
                    t.Direccion = "Santa Maria Chilchotla";
                    t.Provincia = "Santa María Chilchotla-Oaxaca-México";
                    t.Moneda = "Peso Mexicano";
                    t.Agradecimiento = "Gracias por su Compra!, vuelva pronto...";
                    t.Pagina_Web = "Agrega tu pagina";
                    t.Anuncio = "aqui tu anuncio /Cupones / Descuentos";
                    t.Datos_Fiscales = "Datos Fiscales -  Num. Autorización - Resolución...";
                    t.Default = "Ticket No Fiscal";

                    new BusTicket().Agregar_Ticket(t);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error en la insercion de ticket "+ ex.Message);
                }
                #endregion

                #region INSERTAR DATOS CATEGORIA USUARIO
                try
                {

                    CatalogoGenerico c = new CatalogoGenerico();
                    c.Descripcion = "CONTROL TOTAL DEL SISTEMA";
                    c.Estado = true;
                    c.Nombre = "ADMINISTRADOR";

                    new BusCatGenerico().Agregar_TipoUsuario(c);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error en la insercion de  " + ex.Message);
                }

                #endregion


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al agregar la serialización " + ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siguienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Guardar_Empresa();
        }

        private void radioButtonSi_CheckedChanged(object sender, EventArgs e)
        {
            cboImpuesto1.Enabled = true;
            cboPorcentaje.Enabled = true;
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            cboImpuesto1.Enabled = false;
            cboPorcentaje.Enabled = false;
        }
    }
}
