using BusVenta;
using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmGastos : Form
    {
        public frmGastos()
        {
            InitializeComponent();
        }

        private int _idConcepto;

        private int _idCaja;

        private void frmGastos_Load(object sender, EventArgs e)
        {
            pnlConcepto.Visible = false;
            pnlComprobante.Visible = false;
            gdvConcepto.Visible = false;

            ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
           string  serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
            _idCaja = new BusBox().showBoxBySerial(serialPC).Id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnGastos.Checked && string.IsNullOrEmpty(txtBuscar.Text))
                {
                    MessageBox.Show("seleccione el concepto", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscar.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtMonto.Text) || string.IsNullOrEmpty(txtDetalle.Text))
                {
                    MessageBox.Show("Llene todos los campos por favor", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   
                    IngresosGastos ig = new IngresosGastos();
                    ig.idCaja = _idCaja;
                    ig.idConcepto = _idConcepto;
                    ig.Importe = Convert.ToDecimal(txtMonto.Text);
                    ig.Fecha = dtpFecha.Value;
                    ig.Descripcion = txtDetalle.Text;
                    ig.TipoComprobante = chkComprobante.Checked ? cboTipoComprobante.Text : "N/A";
                    ig.NoComprobante = chkComprobante.Checked ? "01" : "N/A";

                    new DatGastoIngreso().InsertarIngresoGastos(ig);
                    
                    MessageBox.Show("Se ha ingresado los datos de forma correcta", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al insertar los datos : " + ex.Message, "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtBuscar.Clear();
            txtMonto.Clear();
            txtNComprobante.Clear();
            txtDetalle.Clear();
            chkComprobante.Checked = false;
            _idConcepto = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void pbAgregar_Click(object sender, EventArgs e)
        {
            pnlConcepto.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    gdvConcepto.Visible = false;
                }
                else
                {
                    DataTable dt = new DatCatGenerico().Buscar_Concepto(txtBuscar.Text);
                    gdvConcepto.Visible = true;
                    gdvConcepto.DataSource = dt;
                    gdvConcepto.Columns[1].Visible = false;

                    DataTablePersonalizado.Multilinea(ref gdvConcepto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al mostrar los datos", "Datos inexistentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNvoConcepto.Text))
                {
                    MessageBox.Show("El campo no debe estar vacío, verifique los datos", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (_idConcepto != 0)
                    {
                        new DatCatGenerico().Editar_Concepto(txtNvoConcepto.Text, _idConcepto);
                        txtBuscar.Clear();
                    }
                    else
                    {
                        new DatCatGenerico().Insertar_Concepto(txtNvoConcepto.Text);
                    }
                 
                    MessageBox.Show("Datos Guardados", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlConcepto.Visible = false;
                    txtNvoConcepto.Clear();
                    txtBuscar.Focus();
                    _idConcepto = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al insertar el concepto : " + ex.Message, "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelarConcepto_Click(object sender, EventArgs e)
        {
            pnlConcepto.Visible = false;
            txtNvoConcepto.Clear();
            txtBuscar.Focus();
            _idConcepto = 0;
        }

        private void gdvConcepto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gdvConcepto.Columns["Editar"].Index)
            {
                _idConcepto = Convert.ToInt32(gdvConcepto.SelectedCells[1].Value);
                txtNvoConcepto.Text = gdvConcepto.SelectedCells[2].Value.ToString();
                gdvConcepto.Visible = false;
                txtBuscar.Clear();
                pnlConcepto.Visible = true;
            }

            _idConcepto = Convert.ToInt32(gdvConcepto.SelectedCells[1].Value);
            txtBuscar.Text = gdvConcepto.SelectedCells[2].Value.ToString();
            gdvConcepto.Visible = false;
        }

        private void chkComprobante_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCheck();
        }

        private void ValidarCheck()
        {
            if (chkComprobante.Checked)
            {
                pnlComprobante.Visible = true;
            }
            else
            {
                pnlComprobante.Visible = false;
            }
        }

        private void rtbnIngresos_CheckedChanged(object sender, EventArgs e)
        {
            validarIngreso();
        }

        private void validarIngreso()
        {
            if (rtbnIngresos.Checked)
            {
                groupBox1.Enabled = false;
                lbltitulo.Text = "INGRESOS";
                LimpiarCampos();
            }
            else
            {
                groupBox1.Enabled = true;
                lbltitulo.Text = "GASTOS";
                LimpiarCampos();
            }
        }
    }
}
