using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
using Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Reporting.Processing;

namespace VentasD1002
{
    public partial class frmCreditosCobrar : Form
    {
        private PrintDocument TICKET;
        Subro.Controls.DataGridViewGrouper grouper = new Subro.Controls.DataGridViewGrouper();

        public frmCreditosCobrar()
        {
            InitializeComponent();
        }

        private void frmCreditosCobrar_Load(object sender, EventArgs e)
        {
            Listar_TotalCredito_PorCliente();
            pbLogo.Image = DatEmpresa.ObtenerLogoEmpresa();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Listar_TotalCredito_PorCliente();
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                ObtenerBusqueda();
            }
        }

        private void Listar_TotalCredito_PorCliente()
        {
            try
            {
                DataTable data = DatVenta.ListarClientes_TotalALquidar();
                gdvTotalCredito.DataSource = data;

                gdvTotalCredito.Columns[0].Visible = false;
                Comun.StyleDatatable(ref gdvTotalCredito);

                //pnlListadoClienteCredito.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar los datos : " + ex.Message, "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                decimal totalCredito = 0;
                foreach (DataGridViewRow item in gdvTotalCredito.Rows)
                {
                    totalCredito += Convert.ToDecimal(item.Cells[6].Value);
                }

                lblTotalCredtio.Text = string.Format("{0:N2}", totalCredito);
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (gdvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione la venta a cobrar", "Venta no existe", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Venta venta = new Venta();
                venta.Id = Convert.ToInt32(lblIdVenta.Text);
                venta.Saldo = Convert.ToDecimal(txtTotalLiquidar.Texts);
                venta.MontoTotal = Convert.ToDecimal(txtMontoTotal.Texts);
                venta.Efectivo = Convert.ToDecimal(txtTotalAbonado.Texts);

                frmAbonarCredito frmAbonar = new frmAbonarCredito(venta);
                frmAbonar.ShowDialog();
                ObtenerDetalleVenta(venta.Id);
                ObtenerBusqueda();
            }
        }

        private void gdvListado_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.gdvListado.Columns["Detalle"].Index)
                {
                    int _idVenta = Convert.ToInt32(gdvListado.SelectedCells[1].Value);
                    ObtenerDetalleVenta(_idVenta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el detalle: " + ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerDetalleVenta(int _idVenta)
        {
            ParametrosReporte data = DatVenta.Consultar_Ticket_Parametro(_idVenta);

            lblIdVenta.Text = _idVenta.ToString();
            txtCliente.Texts = data.Cliente;
            txtFolio.Texts = data.Folio;
            txtMontoTotal.Texts = string.Format("{0:N2}", data.MontoTotal);
            txtTotalLiquidar.Texts = String.Format("{0:N2}", data.Cambio);
            txtCajero.Texts = data.Cajero;
            txtTotalAbonado.Texts = (data.MontoTotal - data.Cambio).ToString();
            txtFechaVenta.Texts = data.FechaVenta.ToString("dd/MM/yyyy");
            gdvDetalle.DataSource = data.lstDetalleVenta;

            foreach (DataGridViewColumn col in gdvDetalle.Columns)
            {
                col.Visible = false;

                if (col.Index == 4 || col.Index == 5 || col.Index == 6 || col.Index == 7 || col.Index == 8)
                {
                    col.Visible = true;
                }
            }

            Comun.StyleDatatable(ref gdvDetalle);

            DataTablePersonalizado.Multilinea(ref gdvDetalle);
        }

        private void ObtenerBusqueda()
        {
            try
            {
                var busqueda = txtBuscar.Text;

                DatVenta.ObtenerVentas_PorCobrar(ref gdvListado, busqueda);
                gdvListado.Columns[1].Visible = false;
                grouper = new Subro.Controls.DataGridViewGrouper(gdvListado);

                Comun.StyleDatatable(ref gdvListado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la lista: " + ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            gdvDetalle.DataSource = null;

            txtCajero.Texts = "";
            txtFolio.Texts = "T-000000";
            txtCliente.Texts = "";
            lblIdVenta.Text = "...";
            txtMontoTotal.Texts = "";
            txtTotalAbonado.Texts = "";
            txtTotalLiquidar.Texts = "";
            txtFechaVenta.Texts = "";
            TICKET = null;
        }

        private void AgregarBitacora(int idventa)
        {
            try
            {
                string serialPC = Sistema.ObenterSerialPC();

                int idCaja      = BusBox.showBoxBySerial().Id;
                int idusuario   = BusUser.ObtenerUsuario_Loggeado().Id;

                Bitacora b = new Bitacora();
                b.Fecha = DateTime.Now;
                b.IdUsuario = idusuario;
                b.IdCaja = idCaja;
                b.Accion = $"ABONO DE VENTA A CREDITO [{idventa}]";

                DatCatGenerico.AgregarBitácora(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la bitacora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ObtenerBusqueda();
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar.SelectAll();
        }

        #region Agrupamiento de datos
        private void chkAgrupar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgrupar.CheckState == CheckState.Checked)
            {
                AgruparListaEmpleados(true);
            }
            else
            {
                AgruparListaEmpleados(false);
            }
        }

        private void chkContraerColapsar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContraerColapsar.CheckState == CheckState.Checked)
            {
                grouper.CollapseAll();
            }
            else
            {
                grouper.ExpandAll();
            }
        }

        private void AgruparListaEmpleados(bool Valor)
        {
            if (Valor == true)
            {
                grouper.RemoveGrouping();
                grouper.SetGroupOn("Nombre");
                grouper.Options.ShowGroupName = false;
                grouper.Options.GroupSortOrder = System.Windows.Forms.SortOrder.None;
                gdvListado.Columns["Nombre"].Visible = false;

                gdvListado.RowHeadersVisible = false;
                gdvListado.ClearSelection();
            }
            else
            {
                grouper.RemoveGrouping();
                //gdvListado.RowHeadersVisible = true;
                gdvListado.Columns["Nombre"].Visible = true;
            }
        }
        #endregion

    }
}
