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
    public partial class frmCierreCaja : Form
    {
        public frmCierreCaja()
        {
            InitializeComponent();
        }

        private string serialPC;
        private int idUsuario;
        private int idCaja;


        private void frmCierreCaja_Load(object sender, EventArgs e)
        {
            try
            {
                lblFecha.Text = DateTime.Now.ToString("dddd dd 'de' MMMM 'de' yyyy");

                ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
                serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
                //idUsuario = new DatCatGenerico().Obtener_InicioSesion( EncriptarTexto.Encriptar(serialPC) );
                idUsuario = new BusUser().ObtenerUsuario(EncriptarTexto.Encriptar(serialPC)).Id;
                idCaja = new DatBox().Obtener_CajaSerial(serialPC);

                lblUsuario.Text = new BusUser().ObtenerUsuario(EncriptarTexto.Encriptar(serialPC)).Nombre;
                Obtener_Totales();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Obtener_Totales()
        {
            var _cierre = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");

            DateTime cierre = Convert.ToDateTime(_cierre);
            List<Venta> _lstVenta = new BusVentas().Listar_VentasTotales(cierre, idUsuario, idCaja);

            decimal _saldoEnCaja = new DatOpenCloseBox().ObtenerSaldo_Encaja(idUsuario);

            lblFondoCaja.Text = _saldoEnCaja.ToString();
            lblVentaEfectivo.Text = _lstVenta.Where(x => x.FormaPago.Equals("Contado")).Select(x => x.MontoTotal).Sum().ToString();
            lblVentaCredito.Text = _lstVenta.Where(x => x.FormaPago.Equals("Credito")).Select(x => x.MontoTotal).Sum().ToString();
            lblTotal.Text = _lstVenta.Select(x => x.MontoTotal).Sum().ToString();
            lblVentasTotales.Text = _lstVenta.Count.ToString();
            lblTotalPagado.Text = _lstVenta.Where(x => x.FormaPago.Equals("Contado")).Count().ToString();
            lblTotalDeuda.Text = _lstVenta.Where(x => x.FormaPago.Equals("Credito")).Count().ToString();

            decimal saldo = _lstVenta.Where(x => x.FormaPago.Equals("Credito")).Select(x => x.Saldo).Sum();
            decimal totalCredito =_lstVenta.Where(x => x.FormaPago.Equals("Credito")).Select(x => x.MontoTotal).Sum();
            decimal creditoAbonado = obtenerPagoCredito();
            decimal totalAbonado = (totalCredito + creditoAbonado) - saldo;
            lblTotalAbonado.Text = totalAbonado.ToString();

            decimal totalDinero = Convert.ToDecimal(lblVentaEfectivo.Text) + Convert.ToDecimal(lblTotalAbonado.Text) + Convert.ToDecimal(lblFondoCaja.Text);
            lblTotalCaja.Text = totalDinero.ToString();
        }

        private decimal obtenerPagoCredito()
        {
            try
            {
                decimal totalCredito = 0;
                totalCredito = new DatCatGenerico().ObtenerPago_CreditoAbonado(idUsuario);
                
                return totalCredito;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar los pagos a crédito : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime cierre = DateTime.Now;
                DateTime fin = DateTime.Now;
                decimal diferencia = Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblTotalCaja.Text);
                new BusOpenCloseBox().CerrarCaja(idCaja, cierre, fin, Convert.ToDecimal(lblTotal.Text), Convert.ToDecimal(lblTotalCaja.Text), diferencia);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error de cierre de caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
