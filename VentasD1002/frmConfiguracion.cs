using BusVenta;
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
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            VerificarActualizacion();
        }

        private void VerificarActualizacion()
        {
            List<string> lst = new DatProducto().listadoActualizacion();

            if (lst.Count > 0)
                pnlProductosActualizados.Visible = true;
            else
                pnlProductosActualizados.Visible = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
           // frmDashboard dashboard = new frmDashboard();
            //dashboard.ShowDialog();
            Dispose();
        }

        private void Logo_empresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConfiguracionEmpresa configuracionEmpresa = new frmConfiguracionEmpresa();
            configuracionEmpresa.ShowDialog();
            this.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario usuario = new frmUsuario();
            usuario.ShowDialog();
            this.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFormatoComprobante frmFormato = new frmFormatoComprobante();
            frmFormato.ShowDialog();
            this.Dispose();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            frmComprobante comprobante = new frmComprobante();
            comprobante.ShowDialog();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBitacoraCliente bitacoraCliente = new frmBitacoraCliente();
            bitacoraCliente.ShowDialog();
            this.Dispose();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmDescargarActualizacion descargarActualizacion = new frmDescargarActualizacion();
            descargarActualizacion.ShowDialog();
            //this.Dispose();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmCargarDatosExcel cargarDatosExcel = new frmCargarDatosExcel();
            cargarDatosExcel.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            frmConfiguracionImpresoras impresoras = new frmConfiguracionImpresoras();
            impresoras.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmHistorialCliente historialCliente = new frmHistorialCliente();
            historialCliente.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            frmHistorialCliente historialCliente = new frmHistorialCliente();
            historialCliente.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            frmCopiaSeguridad copiaSeguridad = new frmCopiaSeguridad();
            copiaSeguridad.ShowDialog();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            frmCopiaSeguridad copiaSeguridad = new frmCopiaSeguridad();
            copiaSeguridad.ShowDialog();
        }

        private void RestaurarBD_Click(object sender, EventArgs e)
        {
            frmRestaurarBD restaurarBD = new frmRestaurarBD();
            restaurarBD.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductosInactivos inactivos = new frmProductosInactivos();
            inactivos.ShowDialog();
            this.Dispose();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductosInactivos inactivos = new frmProductosInactivos();
            inactivos.ShowDialog();
            this.Dispose();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVentasDiarias ventasDiarias = new frmVentasDiarias();
            ventasDiarias.ShowDialog();
            this.Dispose();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVentasDiarias ventasDiarias = new frmVentasDiarias();
            ventasDiarias.ShowDialog();
            this.Dispose();
        }
    }
}
