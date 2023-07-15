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
    public partial class frmAltaCliente : Form
    {
       private CLIENTE_PROVEEDOR _TIPO;

        public frmAltaCliente(CLIENTE_PROVEEDOR TIPO)
        {
            InitializeComponent();

            _TIPO = TIPO;
            panelPV.Visible = (TIPO == CLIENTE_PROVEEDOR.PROVEEDOR) ? true : false;
        }

        public frmAltaCliente(int id, CLIENTE_PROVEEDOR TIPO)
        {
            InitializeComponent();

            _TIPO = TIPO;
            panelPV.Visible = (TIPO == CLIENTE_PROVEEDOR.PROVEEDOR) ? true : false;
            ObtenerDatos(id, TIPO);
        }

        private void ObtenerDatos(int id, CLIENTE_PROVEEDOR TIPO)
        {
            try
            {
                var obj = (TIPO == CLIENTE_PROVEEDOR.CLIENTE)
                        ? BusCliente.ObtenerCliente(id)
                        : DatCliente.ObtenerProveedor(id);

                lblID.Text = obj.Id.ToString();
                txtNombre.Text = obj.NombreCompleto;
                txtDireccion.Text = obj.Direccion;
                txtTelefono.Text = obj.Telefono;
                txtSaldo.Text = obj.Saldo.ToString();
                txtClave.Text = obj.Clave;

                if (TIPO == CLIENTE_PROVEEDOR.PROVEEDOR)
                {
                    txtRazonSocial.Text = obj.RazonSocial;
                    txtCorreo.Text = obj.Correo;
                    txtRFC.Text = obj.Ruc;
                }
            }
            catch (Exception)
            {
            }
        }

        private void LimpiarCampos()
        {
            Comun.LimpiarTextBox(this.Controls);
            lblID.Text = "";
            this.Close();
        }

        private void btnCodigoCliente_Click(object sender, EventArgs e)
        {
            txtClave.Text = "C"+DateTime.Now.ToString("yymmddss");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("Los campos ¡NOMBRE y DIRECCION! son obligatorios", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Cliente c = new Cliente();
                    c.NombreCompleto = txtNombre.Text;
                    c.Direccion = txtDireccion.Text;
                    c.Telefono = (string.IsNullOrEmpty(txtTelefono.Text)) ? "000-000" : txtTelefono.Text;
                    c.Saldo = (string.IsNullOrEmpty(txtSaldo.Text)) ? 0 : Convert.ToDecimal(txtSaldo.Text);
                    c.Clave = String.IsNullOrEmpty(txtClave.Text) ? "N/A" : txtClave.Text;
                    c.Estado = true;
                    c.Id = (string.IsNullOrEmpty(lblID.Text)) ? 0 : Convert.ToInt32(lblID.Text);

                    if (_TIPO == CLIENTE_PROVEEDOR.PROVEEDOR)
                    {
                        c.RazonSocial = (String.IsNullOrEmpty(txtRazonSocial.Text)) ? "N/A" : txtRazonSocial.Text;
                        c.Correo = (String.IsNullOrEmpty(txtCorreo.Text)) ? "N/A" : txtCorreo.Text;
                        c.Ruc = (String.IsNullOrEmpty(txtRFC.Text)) ? "N/A" : txtRFC.Text;

                        DatCliente.GuardarProveedor(c);
                    }
                    else
                    {
                        if (c.Id == 0)
                        {
                            new BusCliente().Agregar_Cliente(c);
                        }
                        else
                        {
                            new BusCliente().Editar_Cliente(c);
                        }
                    }
                    MessageBox.Show("Datos guardados correctamente", "¡ÉXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al ingresar los datos: " + ex.Message, "Ingreso de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
