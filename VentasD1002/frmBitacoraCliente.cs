using BusVenta;
using DatVentas;
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
    public partial class frmBitacoraCliente : Form
    {
        public frmBitacoraCliente()
        {
            InitializeComponent();
        }

        private void frmBitacoraCliente_Load(object sender, EventArgs e)
        {
            pbEstatus2.Visible = false;
            pbEstatusOK.Visible = false;
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                DataTable dt = new DatCatGenerico().ObtenerLista_BitacoraCliente(textBox1.Text);
                gdvLista.DataSource = dt;

                gdvLista.Columns[1].Visible = false;
                gdvLista.Columns[3].Visible = false;
                gdvLista.Columns[5].Visible = false;
                DataTablePersonalizado.Multilinea(ref gdvLista);
            }
            else
            {
                gdvLista.DataSource = null;
            }
        }

        private void gdvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.gdvLista.Columns["Detalle"].Index)
            {
                int oneKey = Convert.ToInt32(gdvLista.SelectedCells[1].Value);

                DataTable dt = new DatCatGenerico().ObtenerDetalle_BitacoraCliente(oneKey);

                decimal suma = dt.AsEnumerable().Select(c => c.Field<Decimal>("Monto Abonado")).Sum();

                txtCliente.Text = dt.Rows[0].Field<String>(3);
                txtComunidad.Text = dt.Rows[0].Field<String>(4);
                txtFolio.Text = dt.Rows[0].Field<String>(8);
                txtComprobante.Text = dt.Rows[0].Field<String>(7);
                txtFecha.Text = dt.Rows[0].Field<DateTime>(6).ToString();
                txtMonto.Text = dt.Rows[0].Field<Decimal>(9).ToString();
                txtEstatus.Text = dt.Rows[0].Field<String>(10);
                txtSaldo.Text = dt.Rows[0].Field<Decimal>(11).ToString();
                txtNAbono.Text = dt.Rows.Count.ToString();

                decimal montoInicial = Convert.ToDecimal(txtMonto.Text) - (suma +Convert.ToDecimal(txtSaldo.Text));
                txtAbonoInicial.Text = suma == Convert.ToDecimal(txtMonto.Text) ? "0" : montoInicial.ToString();


                if (txtEstatus.Text.Equals("PAGADO"))
                {
                    pbEstatus2.Visible = false;
                    pbEstatusOK.Visible = true;
                }
                else
                {
                    pbEstatusOK.Visible = false;
                    pbEstatus2.Visible = true;
                }

                gdvDetalle.DataSource = dt;
                gdvDetalle.Columns[3].Visible = false;
                gdvDetalle.Columns[4].Visible = false;
                gdvDetalle.Columns[5].Visible = false;
                gdvDetalle.Columns[6].Visible = false;
                gdvDetalle.Columns[7].Visible = false;
                gdvDetalle.Columns[8].Visible = false;
                gdvDetalle.Columns[9].Visible = false;
                gdvDetalle.Columns[10].Visible = false;
                gdvDetalle.Columns[11].Visible = false;

                DataTablePersonalizado.Multilinea(ref gdvDetalle);
            }
        }
    }
}
