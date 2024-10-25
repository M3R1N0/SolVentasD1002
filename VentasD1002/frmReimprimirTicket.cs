using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using VentasD1002.Helpers;

namespace VentasD1002
{
    public partial class frmReimprimirTicket : Form
    {
        private PrintDocument reporte;
        string serialPC;

        public frmReimprimirTicket()
        {
            InitializeComponent();
            MostrarMenu();
            ObtenerTipoDocumento();
        }

        private void frmReimprimirTicket_Load(object sender, EventArgs e)
        {
            ObtenerDatos(string.Empty);
        }

        #region Permisos "MENU"

        private void MostrarMenu()
        {
            try
            {
                var idUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
                string formularios = "frmCambioFormaPago,frmBonificacion";
                var menus = PermisoDAL.ObtenerFormsInternos(idUsuario, formularios);

                if (menus.Count > 0)
                {
                    var miMenu = new MenuStrip();

                    foreach (var menu in menus)
                    {
                        ToolStripMenuItem menuPadre = new ToolStripMenuItem(menu.Nombre, null, Click_Menu, menu.NombreForm);
                        MemoryStream ms = new MemoryStream(menu.Icono);
                        menuPadre.Image = Image.FromStream(ms);
                        menuPadre.TextImageRelation = TextImageRelation.ImageBeforeText;
                        menuPadre.ImageScaling = ToolStripItemImageScaling.None;

                        miMenu.Items.Add(menuPadre);
                    }

                    this.MainMenuStrip = miMenu;
                    Controls.Add(miMenu);
                }
            }
            catch (Exception ex)
            { }
        }

        private void Click_Menu(object sender, EventArgs evt)
        {
            ToolStripMenuItem itemSeleccionado = (ToolStripMenuItem)sender;
            Assembly asm = Assembly.GetEntryAssembly();
            Type element = asm.GetType(asm.GetName().Name + "." + itemSeleccionado.Name);

            if (element != null)
            {
                switch (itemSeleccionado.Name)
                {
                    case "frmCambioFormaPago":
                        EditarForma_DePago();
                        break;
                    case "frmBonificacion":
                        RealizarBonificacion();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("El formulario no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void ObtenerDatos(string buscar)
        {
            try
            {
                DataTable dt = DatVenta.ObtenerTickets(dtpInicio.Value, dtpFin.Value, buscar);
                gdvListado.DataSource = dt;

                gdvListado.Columns[1].Visible = false;
                DataTablePersonalizado.Multilinea(ref gdvListado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de lectura : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            ObtenerDatos(string.Empty);
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            ObtenerDatos(string.Empty);
        }

        private void gdvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.gdvListado.Columns["Detalle"].Index)
                {
                    int idventa = Convert.ToInt32(gdvListado.SelectedCells[1].Value);
                    lblIdVenta.Text = idventa.ToString();
                    DibujarReporte();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de al intentar obtener el ticket " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DibujarReporte()
        {
            try
            {
                int idVenta = Convert.ToInt32(lblIdVenta.Text);
                TIPO_DOCUMENTO TIPO = Comun.ObtenerTipoDocumento(cboTipoNota.Text.ToUpper());

                var respuesta = ImprimirDocumento.DibujarReporte(ref reportViewer1, DESTINO_DOCUMENTO.VENTAS, TIPO, idVenta);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un detalle al asignar los datos al reporte\nDetalles: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string NumeroATexto(string _strtotal)
        {
            string total = _strtotal;
            total = decimal.Parse(total).ToString("##0.00");
            int numero = Convert.ToInt32(Math.Floor(Convert.ToDouble(total)));
            string strTotal = Convertir_NumeroLetra.Conversion_Total_a_Letra(numero);
            string[] a = total.Split('.');
            string strTotalDecimal = a[1];
            string strTotalConvertido = strTotal + " " + strTotalDecimal + "/100 M.N";

            return strTotalConvertido;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                TIPO_DOCUMENTO TIPO = Comun.ObtenerTipoDocumento(cboTipoNota.Text);
                int idVenta = Convert.ToInt32(lblIdVenta.Text);

                var respuesta = ImprimirDocumento.Imprimir(ref reportViewer1, TIPO);

                if (respuesta.IsSuccess == EnumOperationResult.Failure)
                {
                    MessageBox.Show(respuesta.Message, "Error de impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (respuesta.IsSuccess == EnumOperationResult.Warning)
                {
                    MessageBox.Show(respuesta.Message, "Error de impresión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else { }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir el ticket : " + ex.Message, "Error de impresión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            ObtenerDatos(txtBuscarCliente.Text);
        }

        private void txtBuscarCliente_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarCliente.SelectAll();
        }

        private void txtBuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                txtBuscarCliente.Clear();
            }
        }

        private void RealizarBonificacion()
        {

            if (string.IsNullOrEmpty(lblIdVenta.Text) || lblIdVenta.Text == "0")
            {
                MessageBox.Show("Seleccione el ticket a bonificar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmBonificacion bonificacion = new frmBonificacion();
                frmBonificacion.idVenta = Convert.ToInt32(lblIdVenta.Text);
                bonificacion.ShowDialog();
            }
        }

        private void EditarForma_DePago()
        {
            try
            {
                if (string.IsNullOrEmpty(lblIdVenta.Text) || lblIdVenta.Text == "0")
                {
                    MessageBox.Show("Seleccione el ticket a modificar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int idventa = Convert.ToInt32(lblIdVenta.Text);
                    frmCambioFormaPago frmCambio = new frmCambioFormaPago(idventa);
                    frmCambio.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el cambio (Contado - Crédito) : " + ex.Message, "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblIdVenta.Text = "";
            }
        }

        private void ObtenerTipoDocumento()
        {
            try
            {
                var lst = DatSerializacion.ObtenerTipoDocumento(DESTINO_DOCUMENTO.VENTAS.ToString());
                cboTipoNota.DataSource = lst;
                cboTipoNota.DisplayMember = "Tipo_Documento";
                cboTipoNota.ValueMember = "Id";
            }
            catch (Exception)
            {
            }
        }

        private void cboTipoNota_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DibujarReporte();
        }
    }
}
