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
    public partial class frmVistaBonificaciones : Form
    {
        public frmVistaBonificaciones()
        {
            InitializeComponent();
        }

        private void frmVistaBonificaciones_Load(object sender, EventArgs e)
        {
            validarFiltro();
        }

        private void ObtenerDatos(string buscar)
        {
            try
            {
                DataTable dt = DatVenta.ListarBonificaiones(dtpInicio.Value, dtpFin.Value, buscar);

                dataGridView1.DataSource = dt;

                DataTablePersonalizado.Multilinea(ref dataGridView1);
                this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =  Color.Gainsboro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de lectura : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            var buscar = (string.IsNullOrEmpty(txtBuscar.Text)) ? "" : txtBuscar.Text;
            ObtenerDatos(buscar);
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            var buscar = (string.IsNullOrEmpty(txtBuscar.Text)) ? "" : txtBuscar.Text;
            ObtenerDatos(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var buscar = (string.IsNullOrEmpty(txtBuscar.Text)) ? "" : txtBuscar.Text;
            ObtenerDatos(buscar);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            validarFiltro();
          
        }

        private void validarFiltro()
        {
            if (checkBox1.Checked == true)
            {
                pnlFiltro.Visible = true;
            }
            else
            {
                pnlFiltro.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count != 0)
            {
                decimal suma = 0;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    suma  += Convert.ToDecimal( item.Cells[7].Value);
                }

                lblTotal.Text = suma.ToString();
            }
            else
            {
                lblTotal.Text = "0.00";
            }
        }
    }
}
