using BusVenta;
using BusVenta.Helpers;
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
    public partial class frmAperturaCaja : Form
    {
        //string serialPC;
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
                    var montoInicial = Convert.ToDecimal(txtEfectivoInicial.Text);
                    var respuesta =  GuardarMovimientoCaja(montoInicial);

                    this.Hide();
                    frmPrincipal principal = new frmPrincipal();
                    principal.ShowDialog();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static OperationResponse GuardarMovimientoCaja(decimal montoInicial)
        {
            string serialPC = Sistema.ObenterSerialPC();
            var caja = CajaDAL.ObtenerCaja(serialPC);

            OpenCloseBox open = new OpenCloseBox();
            open.FechaInicio = DateTime.Now;
            open.FechaFin = DateTime.Now;
            open.FechaCierre = DateTime.Now;
            open.Ingresos = 0;
            open.Egresos = 0;
            open.Saldo = montoInicial;
            open.IdUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
            open.TotalCalculado = 0;
            open.TotalReal = 0;
            open.Estado = true;
            open.Diferencia = 0;
            open.IdCaja = caja.Id;

           return BusOpenCloseBox.AddOpenCloseBoxDetail(open);
        }

        private void frmAperturaCaja_Load(object sender, EventArgs e)
        {
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarMovimientoCaja(0);

                this.Hide();
                frmPrincipal principal = new frmPrincipal();
                principal.ShowDialog();
                this.Dispose();

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
