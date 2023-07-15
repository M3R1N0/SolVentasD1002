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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmCambioFormaPago : Form
    {
        public frmCambioFormaPago(int idVenta)
        {
            InitializeComponent();
            ObtenerVenta(idVenta);
        }

        private Venta _venta;
        private void ObtenerVenta(int idVenta)
        {
            try
            {
                _venta = DatVenta.ObtenerVenta(idVenta);
                lblMontoTotal.Text = _venta.MontoTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un detalle al obtener la venta\n Detalles: "+ex.Message,"Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {

                DatVenta.Editar_FormaPago(_venta.Id, _venta.MontoTotal);

                MessageBox.Show("Proceso realizado correctamente", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AgregarBitacora(_venta);
                this.Close();
            }
            catch (Exception)
            {
            }
        }

        private void AgregarBitacora(Venta v)
        {
            try
            {
                string serialPC = Sistema.ObenterSerialPC();

                int idCaja = BusBox.showBoxBySerial().Id;
                int idusuario = BusUser.ObtenerUsuario_Loggeado().Id;

                Bitacora b = new Bitacora();
                b.Fecha = DateTime.Now;
                b.IdUsuario = idusuario;
                b.IdCaja = idCaja;
                b.Accion = $"CAMBIO DE FORMA DE PAGO CONTADO-CREDITO [{v.Id}]";

                DatCatGenerico.AgregarBitácora(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la bitacora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
