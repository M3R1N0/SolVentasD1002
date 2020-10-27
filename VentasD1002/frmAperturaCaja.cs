using BusVenta;
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
    public partial class frmAperturaCaja : Form
    {
        string serialPC;
        int idCaja;
        Box listadoCaja;
        public frmAperturaCaja()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtEfectivoInicial.Text))
                {
                    MessageBox.Show("Favor de ingresar un monto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEfectivoInicial.Focus();
                }
                else
                {
                    new BusOpenCloseBox().EditarEfectivoInicial(Convert.ToDecimal(txtEfectivoInicial.Text), idCaja);
                    this.Hide();
                    frmMenuPrincipal principal = new frmMenuPrincipal();
                    principal.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAperturaCaja_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ",";
            ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
            serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();

            listadoCaja = new BusBox().showBoxBySerial(serialPC);
            try
            {
                idCaja = listadoCaja.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                new BusOpenCloseBox().EditarEfectivoInicial(0, idCaja);
                this.Hide();
                frmMenuPrincipal principal = new frmMenuPrincipal();
                principal.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void OnlyNumber(KeyPressEventArgs e, bool isDecimal)
        {
            string aceptado;
            if (!isDecimal)
            {
                aceptado = "0123456789" + Convert.ToChar(8);
            }
            else

                aceptado = "0123456789" + Convert.ToChar(8);

            if (aceptado.Contains("" + e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtEfectivoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumerosSeparadores.SeparadorDeNumeros(txtEfectivoInicial, e);
        }
    }
}
