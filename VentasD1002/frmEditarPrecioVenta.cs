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
    public partial class frmEditarPrecioVenta : Form
    {
        private DetalleVentaII _detalle = new DetalleVentaII();
        public frmEditarPrecioVenta(DetalleVentaII dv)
        {
            InitializeComponent();

            _detalle = dv;
            txtPrecioPreferencial.Value = dv.Precio;
            txtPrecioPreferencial.Focus();
            txtPrecioPreferencial.Select(0, txtPrecioPreferencial.Value.ToString().Length);
        }

        private void txtPrecioPreferencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    var precio = Convert.ToDecimal(txtPrecioPreferencial.Value);
                    if (precio != 0)
                    {
                        _detalle.Importe = precio * _detalle.Cantidad;
                        _detalle.Precio = precio;

                        DatDetalleVenta.ActualizarPrecio_DetalleVenta(_detalle, TIPO_VENTA.P);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("EL precio debe ser diferente de Cero\n Favor de ingresar de nuevo", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
