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
    public partial class frmCierreCaja : Form
    {
        public frmCierreCaja()
        {
            InitializeComponent();
        }

        private int idUsuario;

        private void frmCierreCaja_Load(object sender, EventArgs e)
        {
            try
            {
                lblFechaCierre.Text = DateTime.Now.ToString("dddd dd 'de' MMMM 'de' yyyy");
               
                idUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
                //idCaja = new DatBox().Obtener_CajaSerial(serialPC);
                lblNombreUsuario.Text += BusUser.ObtenerUsuario_Loggeado().Nombre;
                var serial = Sistema.ObenterSerialPC();
                CajaDAL.CorteCaja(serial, idUsuario, ref dataGridView1);

                decimal total = 0, egreso=0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    total = (decimal) row.Cells[0].Value    
                          + (decimal) row.Cells[1].Value    
                          + (decimal) row.Cells[3].Value    
                          + (decimal) row.Cells[4].Value;   

                    egreso = (decimal)row.Cells[5].Value;
                }

                total = total - egreso;
                llblCajaTotal.Text = string.Format("{0:N2}", total);
                TXTTOTALREAL.Text = string.Format("{0:N2}", total);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: "+ex.Message, "Error", MessageBoxButtons.OK);
            }
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

        private void Cerrar_Click(object sender, EventArgs e)
        {
            try
            {
                var serial = Sistema.ObenterSerialPC();
                int idCaja = BusBox.showBoxBySerial().Id;
                int idUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
                decimal totalCalculado = (string.IsNullOrEmpty(llblCajaTotal.Text)) ? 0 : Convert.ToDecimal(llblCajaTotal.Text);
                decimal totalReal = (string.IsNullOrEmpty(TXTTOTALREAL.Text)) ? 0 : Convert.ToDecimal(TXTTOTALREAL.Text);

                decimal diferencia = totalReal - totalCalculado ;
                new BusOpenCloseBox().CerrarCaja(idCaja, totalCalculado, totalReal, diferencia, idUsuario);
                new DatCatGenerico().Editar_InicioSesion(EncriptarTexto.Encriptar(serial), 0);
                this.Dispose();

                frmCopiaAutomatica copiaAutomatica = new frmCopiaAutomatica();
                copiaAutomatica.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error de cierre de caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void TXTTOTALREAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            Comun.TextBoxNumerico(sender, e);
        }
    }
}
