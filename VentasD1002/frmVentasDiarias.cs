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
    public partial class frmVentasDiarias : Form
    {
        public frmVentasDiarias()
        {
            InitializeComponent();
        }

        private void frmVentasDiarias_Load(object sender, EventArgs e)
        {
            ConsultarVentas();
        }

        private void ConsultarVentas()
        {
            try
            {
                DateTime fechaInicio = Convert.ToDateTime(dateTimePicker1.Text);
                List<Venta> lst = DatVenta.ObtenerVenta_TotalPorCaja(fechaInicio);


                int contador = 1;
                List<int> _lstCaja = lst.Select(x => x.IdCaja).Distinct().ToList();
                foreach (var item in _lstCaja)
                {
                    if (contador == 1)
                    {

                        lblCaja1.Text = lst.Where(x => x.IdCaja.Equals(item)).Select( x => x.Comentarios).FirstOrDefault();
                        lblBonificacion.Text = lst.Where(x => x.IdCaja.Equals(item)).Select(x => x.Saldo).FirstOrDefault().ToString();
                        lblFondoCaja.Text = lst.Where(x => x.IdCaja.Equals(item)).Select(x => x.Vuelto).FirstOrDefault().ToString();
                        lblVentaCredito.Text = lst.Where(x => x.IdCaja.Equals(item) && x.FormaPago.Equals("Credito") && x.Accion != "VENTA CANCELADA")
                                                  .Select(x => x.MontoTotal)
                                                  .Sum().ToString();
                        lblVentaEfectivo.Text = lst.Where(x => x.IdCaja.Equals(item) && x.FormaPago.Equals("Contado") && x.Accion != "VENTA CANCELADA")
                                                  .Select(x => x.MontoTotal)
                                                  .Sum().ToString();
                        contador++;
                    }
                    else
                    {
                        lblCaja2.Text = lst.Where(x => x.IdCaja.Equals(item)).Select(x => x.Comentarios).FirstOrDefault();
                        lblBonificacion2.Text = lst.Where(x => x.IdCaja.Equals(item)).Select(x => x.Saldo).FirstOrDefault().ToString();
                        lblEfectivoCaja2.Text = lst.Where(x => x.IdCaja.Equals(item)).Select(x => x.Vuelto).FirstOrDefault().ToString();
                        lblVentasCredito2.Text = lst.Where(x => x.IdCaja.Equals(item) && x.FormaPago.Equals("Credito") && x.Accion != "VENTA CANCELADA")
                                                  .Select(x => x.MontoTotal)
                                                  .Sum().ToString();
                        lblVentasEfectivo2.Text = lst.Where(x => x.IdCaja.Equals(item) && x.FormaPago.Equals("Contado") && x.Accion != "VENTA CANCELADA")
                                                  .Select(x => x.MontoTotal)
                                                  .Sum().ToString();

                    }
                }


                decimal subtotal1 =  Convert.ToDecimal(lblVentaEfectivo.Text) 
                                    + Convert.ToDecimal(lblVentaCredito.Text) + Convert.ToDecimal(lblFondoCaja.Text);

                lblSubtotal1.Text = subtotal1.ToString();

                decimal subtotal2 = Convert.ToDecimal(lblVentasEfectivo2.Text)
                                  + Convert.ToDecimal(lblVentasCredito2.Text) + Convert.ToDecimal(lblEfectivoCaja2.Text);

                lblSubtotal2.Text = subtotal2.ToString();


                lblTotal.Text = (subtotal1 + subtotal2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos : "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarVentas();
        }
    }
}
