using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.ReportViewer.WinForms;
using VentasD1002.Helpers;

namespace VentasD1002
{
    public partial class frmFormatoComprobante : Form
    {
        string txttipo;
        public frmFormatoComprobante()
        {
            InitializeComponent();
        }

        private void frmFormatoComprobante_Load(object sender, EventArgs e)
        {

            Mostrar_FormatoTicket();
            ObtenerDatos();
        }

        private void Mostrar_FormatoTicket()
        {
            try
            {
                DataTable dt = new DatTikect().Mostrar_FormatoTicket();
                datalistado_tickets.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar los datos: " + ex.Message, "Error de listado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerDatos()
        {
            try
            {
                txttipo = datalistado_tickets.SelectedCells[13].Value.ToString();

                ICONO.BackgroundImage = null;
                byte[] b = (Byte[])datalistado_tickets.SelectedCells[1].Value;
                MemoryStream ms = new MemoryStream(b);
                ICONO.Image = Image.FromStream(ms);

                txtempresaTICKET.Text = datalistado_tickets.SelectedCells[2].Value.ToString();
                txtEmpresa_RUC.Text = datalistado_tickets.SelectedCells[5].Value.ToString();
                txtDireccion.Text = datalistado_tickets.SelectedCells[6].Value.ToString();
                txtProvincia_departamento.Text = datalistado_tickets.SelectedCells[7].Value.ToString();
                //txtMoneda_String.Text = datalistado_tickets.SelectedCells[8].Value.ToString();
                txtAgradecimiento.Text = datalistado_tickets.SelectedCells[9].Value.ToString();
                txtpagina_o_facebook.Text = datalistado_tickets.SelectedCells[10].Value.ToString();
                TXTANUNCIO.Text = datalistado_tickets.SelectedCells[11].Value.ToString();
                //txtAutorizacion_fiscal.Text = datalistado_tickets.SelectedCells[12].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = "Imagenes|*.jpg;*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Title = "Cargador de Imagenes Ada 369";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ICONO.BackgroundImage = null;
                ICONO.Image = new Bitmap(openFileDialog1.FileName);
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void imprimirPruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportViewer reportViewer1 = new ReportViewer();
            ImprimirDocumento.Imprimir(ref reportViewer1, DESTINO_DOCUMENTO.VENTAS, TIPO_DOCUMENTO.TICKET, 1004);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket t = new Ticket();
                t.Identificador_Fiscal = txtEmpresa_RUC.Text;
                t.Direccion = txtDireccion.Text;
                t.Provincia = txtProvincia_departamento.Text;
                t.Moneda = "PESO MEXICANO";
                t.Agradecimiento = txtAgradecimiento.Text;
                t.Pagina_Web = txtpagina_o_facebook.Text;
                t.Anuncio = TXTANUNCIO.Text;
                t.Datos_Fiscales = "";
                t.Default = txttipo;

                Empresa empresa = new Empresa();
                MemoryStream ms = new MemoryStream();
                ICONO.Image.Save(ms, ICONO.Image.RawFormat);
                empresa.Nombre = txtempresaTICKET.Text;
                empresa.Logo = ms.GetBuffer();

                new BusTicket().Editar_FormatoTicket(t, empresa);
                timer1.Start();
                //  frmExito exito = new frmExito();
                //exito.Show();
                MessageBox.Show("Operación realizada", "¡ÉXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                //frmConfiguracion frmConfiguracion = new frmConfiguracion();
                //frmConfiguracion.ShowDialog();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
