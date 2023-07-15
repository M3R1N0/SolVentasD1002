using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;

namespace VentasD1002
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        string userPermision;
        string serialPC;
        DataTable dt;

        private void frmDashboard_Load(object sender, EventArgs e)
        {

            try
            {
                serialPC = Sistema.ObenterSerialPC();
                var auxSerial = EncriptarTexto.Encriptar(serialPC);
                userPermision = BusUser.ObtenerUsuario_Loggeado().Rol;

                List<CatalogoGenerico> lst = new List<CatalogoGenerico>();
                lst.Add(new CatalogoGenerico() { Nombre = "DIARIO", Id = 1 });
                lst.Add(new CatalogoGenerico() { Nombre = "SEMANAL", Id = 2 });
                lst.Add(new CatalogoGenerico() { Nombre = "MENSUAL", Id = 3 });
                lst.Add(new CatalogoGenerico() { Nombre = "ANUAL", Id = 4 });

                cboPeriodo.DataSource = lst;
                cboPeriodo.ValueMember = "Id";
                cboPeriodo.DisplayMember = "Nombre";
                cboPeriodo.SelectedValue = 1;

                dpInicio.MaxDate = dpFin.Value;
                dpFin.MinDate = dpInicio.Value;

                //Productos_MasVendidos();
                //ClientesFrecuentes();
                ContarDatos();

                //ObtenerDatos_Ventas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta de la llave del admin :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ObtenerDatos_Ventas()
        {
            try
            {
                var datos = DashBoardDAL.Listar_PorPeriodo(dpInicio.Value, dpFin.Value, cboPeriodo.Text);

                if (datos.Count > 0)
                {

                    var arrTotal = datos.Select(x => x.Total).ToArray();
                    var arrPeriodo = datos.Select(x => x.Fecha).ToArray();

                    graficaVentas.DataSource = datos;
                    graficaVentas.Series[0].XValueMember = "Fecha";
                    graficaVentas.Series[0].YValueMembers = "Total";
                    graficaVentas.DataBind();

                }
            }
            catch (Exception ex)
            {

            }
        }

        ProgressBar pb = new ProgressBar();

        private void ContarDatos()
        {
            try
            {

                lblTotalClientes.Text = DatCliente.TotalClientes().ToString();
                lblTotalProducto.Text = DatProducto.TotalProducto().ToString();
                lblStockBajos.Text = DatProducto.TotalProducto_StockBajos().ToString();
                lblVentasCredito.Text = DatVenta.Total_VentasCredito().ToString();
                lblVentaTotal.Text = DatVenta.Total_VentasRealizadas().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos : "+ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            dpInicio.MaxDate = dpFin.Value;
            dpFin.MinDate = dpInicio.Value;
            ObtenerDatos_Ventas();
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            dpInicio.MaxDate = dpFin.Value;
            dpFin.MinDate = dpInicio.Value;
            ObtenerDatos_Ventas();
        }

        private void Productos_MasVendidos()
        {
            try
            {
                int rango = (string.IsNullOrEmpty(txtRango.Text)) ? 10 : Convert.ToInt32(txtRango.Text);
                var dash = DashBoardDAL.Top10_Productos(dpInicio.Value, dpFin.Value, rango);

                if (dash.Count > 0)
                {

                    LiveCharts.SeriesCollection piechartData = new LiveCharts.SeriesCollection();
                    foreach (var item in dash)
                    {
                        piechartData.Add(new PieSeries
                        {
                            Title = Convert.ToString(item.Fecha),
                            Values = new LiveCharts.ChartValues<decimal> { item.Total },
                            DataLabels = true,
                        });
                    }

                    chartProductosVendidos.Series.Clear();
                    chartProductosVendidos.Series = piechartData;
                    chartProductosVendidos.LegendLocation = LiveCharts.LegendLocation.Left;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al obtener los datos : " + ex.Message, "Grafica productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientesFrecuentes()
        {
            try
            {
                int rango = (string.IsNullOrEmpty(txtRango.Text)) ? 10 : Convert.ToInt32(txtRango.Text);
                var dash = DashBoardDAL.Grafica_CLientesFrecuents(dpInicio.Value, dpFin.Value, rango);

                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

                SeriesCollection piechartData = new SeriesCollection();



                /*  foreach (var item in data.netSalesPeriod)
                  {
                      piechartData.Add(new PieSeries
                      {
                          Title = Convert.ToDateTime(item.Period).ToShortDateString(),
                          Values = new ChartValues<double> { item.NetSale },
                          DataLabels = true,
                          LabelPoint = labelPoint,
                      });
                  }

                  pieChart1.Series.Clear();
                  pieChart1.Series = piechartData;
                  pieChart1.LegendLocation = LegendLocation.Left;*/

                //CARTESIAN CHARTS
                chartClientesFrecuentes.Series.Clear();
                foreach (DashBoard item in dash)
                {
                    chartClientesFrecuentes.Series.Add(new ColumnSeries
                    {
                        Title = item.Nombre,
                        Values = new ChartValues<Int32> { item.TotalClientes },
                        DataLabels = true,
                        //LabelPoint = point => data.netSalesPeriod.Where(i => Convert.ToDouble(i.NetSale) == point.Y).Select(i => i.NetSale.ToString()).First(),
                    });
                    chartClientesFrecuentes.LegendLocation = LegendLocation.Right;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al obtener los datos : " + ex.Message, "Grafica clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboPeriodo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ObtenerDatos_Ventas();
        }

        private void rbtnVentas_CheckedChanged(object sender, EventArgs e)
        {
            txtRango.Visible = false;
            chartClientesFrecuentes.Visible = false;
            chartProductosVendidos.Visible = false;
            graficaVentas.Visible = true;
            ObtenerDatos_Ventas();
        }

        private void rbtnClientesFrecuentes_CheckedChanged(object sender, EventArgs e)
        {
            chartProductosVendidos.Visible = false;
            graficaVentas.Visible = false;
            chartClientesFrecuentes.Visible = true;
            chartClientesFrecuentes.Dock = DockStyle.Fill;
            chartClientesFrecuentes.BringToFront();
            ClientesFrecuentes();
            txtRango.Visible = true;
        }

        private void rbtnProductosTop10_CheckedChanged(object sender, EventArgs e)
        {
            chartClientesFrecuentes.Visible = false;
            graficaVentas.Visible = false;
            chartProductosVendidos.Visible = true;
            chartProductosVendidos.Dock = DockStyle.Fill;
            chartProductosVendidos.BringToFront();
            Productos_MasVendidos();
            txtRango.Visible = true;
        }

        private void txtRango_KeyPress(object sender, KeyPressEventArgs e)
        {
            Comun.TextBoxNumerico(sender, e);
        }

        private void txtRango_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Productos_MasVendidos();
            }
        }
    }
}
