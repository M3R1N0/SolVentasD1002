using BusVenta;
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

namespace VentasD1002
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            pnlFiltro.Visible = false;
            ContarDatos();
            DibujarGrafica();
        }
        private string Usuario;
        string loggedUser;
        string loggedName;
        string Apertura;
        string UserLoginNow;
        string nameUserNow;
        string userPermision;
        string BoxPermission;
        int countMcsxu;
        int idAdmin;
        string serialPC;
        int IdCaja;
        string caja;
        List<User> lstLoggedUser;
        List<OpenCloseBox> lstOpenCloseDetail;
        DataTable dt;

        private void frmDashboard_Load(object sender, EventArgs e)
        {

            try
            {
                ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
                serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
                var auxSerial = EncriptarTexto.Encriptar(serialPC);
                userPermision = new BusUser().ObtenerUsuario(auxSerial).Rol;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta de la llave del admin :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            panel1.Visible = true;
            Productos_MasVendidos();
            ClientesFrecuentes();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Iniciar_Caja_Venta();
        }

        private void Iniciar_Caja_Venta()
        {
            try
            {
                
                IdCaja = new BusBox().showBoxBySerial(serialPC).Id;
                idAdmin = new DatCatGenerico().Obtener_IdAdmin();
                caja = new BusBox().showBoxBySerial(serialPC).SerialPC;

                int contadorDCC = ListOpenCloseDetailBox();
                //   userPermision = lstLoggedUser.Select(x => x.Rol).First();
                if (contadorDCC == 0 & userPermision != "Solo Ventas")
                {
                    AddOpenCloseDetailBox();
                    Apertura = "NUEVO";
                    timer2.Start();
                }
                else
                {
                    if (userPermision != "Solo Ventas")
                    {
                        GetSerialBoxByUser();
                        try
                        {
                            ListOpenCloseDetailBox();
                            UserLoginNow = lstOpenCloseDetail.Select(x => x.UsuarioId.Usuario).FirstOrDefault();
                            nameUserNow = lstOpenCloseDetail.Select(x => x.UsuarioId.Nombre).FirstOrDefault();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        if (countMcsxu == 0)
                        {
                            if (UserLoginNow == "Administrador" || Usuario == "Admininistrador" || userPermision == "ADMINISTRADOR")
                            {
                                MessageBox.Show("Continuaras Turno de *" + nameUserNow + " Todos los Registros seran con ese Usuario", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                BoxPermission = "Correcto";
                            }
                            if (loggedName == "Admin" && Usuario == "Admin")
                            {
                                BoxPermission = "Correcto";
                            }

                            else if (UserLoginNow != Usuario && userPermision != "ADMINISTRADOR")
                            {
                                MessageBox.Show("Para poder continuar con el Turno de *" + nameUserNow + "* ,Inicia sesion con el Usuario " + UserLoginNow + " -ó-el Usuario *admin*", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BoxPermission = "Vacio";
                            }
                            else if (UserLoginNow == Usuario)
                            {
                                BoxPermission = "Correcto";
                            }
                        }
                        else
                        {
                            BoxPermission = "Correcto";
                        }
                        if (BoxPermission == "Correcto")
                        {
                            Apertura = "Aperturado";
                            timer2.Start();
                        }
                    }
                    else
                    {
                        timer2.Start();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ListOpenCloseDetailBox()
        {
            int auxcount = 0;
            try
            {
                lstOpenCloseDetail = new BusOpenCloseBox().showMovBoxBySerial(serialPC);
                auxcount = lstOpenCloseDetail.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return auxcount;
        }

        private void AddOpenCloseDetailBox()
        {
            try
            {
               // int usuarioID = lstLoggedUser.Select(x => x.Id).First();
                User u = new User();
                u.Id = idAdmin;
                Box b = new Box();
                b.Id = IdCaja;
                OpenCloseBox open = new OpenCloseBox();
                open.FechaInicio = DateTime.Today;
                open.FechaFin = DateTime.Today;
                open.FechaCierre = DateTime.Today;
                open.Ingresos = 0;
                open.Egresos = 0;
                open.Saldo = 0;
                open.UsuarioId = u;
                open.TotalCalculado = 0;
                open.TotalReal = 0;
                open.Estado = true;
                open.Diferencia = 0;
                open.CadaId = b;

                new BusOpenCloseBox().AddOpenCloseBoxDetail(open);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSerialBoxByUser()
        {
            try
            {
                //int idUsuario = lstLoggedUser.Select(x => x.Id).First();
                countMcsxu = new BusOpenCloseBox().getMovOpenCloseBox(serialPC, idAdmin);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return countMcsxu;
        }

        ProgressBar pb = new ProgressBar();
        
        private void timer2_Tick(object sender, EventArgs e)
        {
           
                timer2.Stop();
                if ( Apertura.Equals( "NUEVO" ) )
                {
                    
                    frmAperturaCaja aperturaCaja = new frmAperturaCaja();
                    this.Hide();
                    aperturaCaja.ShowDialog();
                    Dispose();
                }
                else
                {
                    frmMenuPrincipal principal = new frmMenuPrincipal();
                    this.Hide();
                    principal.ShowDialog();
                    Dispose();
                }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmConfiguracion configuracion = new frmConfiguracion();
            configuracion.ShowDialog();
           // Dispose();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

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

        private void DibujarGrafica()
        {
            try
            {
                ArrayList arrFecha = new ArrayList();
                ArrayList arrMonto = new ArrayList();

                dt = new DataTable();
                DatVenta.DatosGrafica(ref dt);

                foreach (DataRow dr in dt.Rows)
                {
                    arrFecha.Add(dr["Fecha"]);
                    arrMonto.Add(dr["Total"]);
                }

                chart1.Series[0].Points.DataBindXY(arrFecha, arrMonto);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al obtener los datos : "+ex.Message, "Error en la gráfica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Filtrar_Grafica()
        {
            try
            {
                ArrayList arrFecha = new ArrayList();
                ArrayList arrMonto = new ArrayList();

                dt = new DataTable();
                DatVenta.Filtrar_DatosGrafica(ref dt, dtpInicio.Value, dtpFin.Value);

                foreach (DataRow dr in dt.Rows)
                {
                    arrFecha.Add(dr["Fecha"]);
                    arrMonto.Add(dr["Total"]);
                }

                chart1.Series[0].Points.DataBindXY(arrFecha, arrMonto);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al obtener los datos : " + ex.Message, "Error en la gráfica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            Filtrar_Grafica();
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            Filtrar_Grafica();
        }

        private void chkFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltro.Checked == true)
            {
                pnlFiltro.Visible = true;
            }
            else
            {
                pnlFiltro.Visible = false;
                DibujarGrafica();
            }
        }

        private void Productos_MasVendidos()
        {
            try
            {
                ArrayList arrTotal = new ArrayList();
                ArrayList arrProducto = new ArrayList();

                dt = new DataTable();
                DatDetalleVenta.Productos_MasVendidos(ref dt);

                foreach (DataRow dr in dt.Rows)
                {
                    arrTotal.Add(dr["Total"]);
                    arrProducto.Add(dr["Descripcion"]);
                }

                chartProductosVendidos.Series[0].Points.DataBindXY(arrProducto , arrTotal);

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
                ArrayList arrTotal = new ArrayList();
                ArrayList arrNombres = new ArrayList();

                dt = new DataTable();
                DatVenta.Grafica_ClienteFrecuente(ref dt);

                foreach (DataRow dr in dt.Rows)
                {
                    arrTotal.Add(dr["Total"]);
                    arrNombres.Add(dr["Nombre"]);
                }

                chartClientesFrecuentes.Series[0].Points.DataBindXY(arrNombres, arrTotal);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al obtener los datos : " + ex.Message, "Grafica clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Iniciar_Caja_Venta();
        }
    }
}
