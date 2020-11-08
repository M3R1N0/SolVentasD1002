using BusVenta;
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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ListarClientes_Proveedores();
            pnlAltaCliente.Visible = false;
        }

        private void ListarClientes_Proveedores()
        {
            try
            {
                List<Cliente> lstClientes = new BusCliente().ListarClientes("");
                gdvClientes.DataSource = lstClientes;

                DataTablePersonalizado.Multilinea(ref gdvClientes);
                gdvClientes.Columns[2].Visible = false;
                gdvClientes.Columns[10].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrióun error al mostrar los datos"+ ex.Message, "Listado de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAltaCliente.Visible = false;
            LimpiarCampos();
        }

        private void btnVentaPendiente_Click(object sender, EventArgs e)
        {
            pnlAltaCliente.Visible = true;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSaldo.Text, "[^0-9]"))
            {
               // MessageBox.Show("Ingrese datos válidos", "Ingreso de Saldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSaldo.Text = txtSaldo.Text.Remove(txtSaldo.Text.Length - 1);
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, "[^0-9]"))
            {
               // MessageBox.Show("Ingrese datos válidos","Numero Telfónico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefono.Text = txtTelefono.Text.Remove(txtTelefono.Text.Length - 1);
            }
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
                    c.Telefono = txtTelefono.Text;
                    c.Saldo = Convert.ToDecimal(txtSaldo.Text);
                    c.Proveedor = rbProveedor.Checked ? "SI" : "NO";
                    c.Clientes = rbCliente.Checked ? "SI" : "NO";
                    c.Ruc = String.IsNullOrEmpty(txtRuc.Text) ? "N/A" : txtRuc.Text;
                    c.Estado = true;

                    if (String.IsNullOrEmpty(lblID.Text))
                    {
                        new BusCliente().Agregar_Cliente(c);
                        MessageBox.Show("Datos agregados correctamente", "¡ÉXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                    {
                        c.Id = Convert.ToInt32(lblID.Text);
                        new BusCliente().Editar_Cliente(c);
                        MessageBox.Show("Datos modificados correctamente", "¡ÉXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //pnlAltaCliente.Visible = false;
                        //LimpiarCampos();
                        //ListarClientes_Proveedores();
                    }
                }
                pnlAltaCliente.Visible = false;
                LimpiarCampos();
                ListarClientes_Proveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al ingresar los datos: "+ex.Message,"Ingreso de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.gdvClientes.Columns["Delete"].Index)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro de borrar los datos del Cliente?","Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                if (result == DialogResult.OK)
                { // int onekey = Convert.ToInt32(dr.Cells["Id"].Value);
                    try
                    {
                        var s = gdvClientes.SelectedCells[2].Value.ToString();
                        new BusCliente().eliminar_Cliente(Convert.ToInt32(s));
                        MessageBox.Show("Registro Eliminado", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes_Proveedores();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar el registro" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            if (e.ColumnIndex == this.gdvClientes.Columns["Edit"].Index)
            {
                lblID.Text = gdvClientes.SelectedCells[2].Value.ToString();
                txtNombre.Text = gdvClientes.SelectedCells[3].Value.ToString();
                txtDireccion.Text = gdvClientes.SelectedCells[4].Value.ToString();
                txtRuc.Text =  gdvClientes.SelectedCells[5].Value.ToString();
                txtTelefono.Text = gdvClientes.SelectedCells[6].Value.ToString();
                txtSaldo.Text = gdvClientes.SelectedCells[9].Value.ToString();

                var cliente = gdvClientes.SelectedCells[7].Value.ToString();
                var proveedor = gdvClientes.SelectedCells[8].Value.ToString();

                if (cliente.Equals("SI"))
                {
                    rbCliente.Checked = true;
                }
                if (proveedor.Equals("SI"))
                {
                    rbProveedor.Checked = true;
                }

                pnlAltaCliente.Visible = true;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtSaldo.Clear();
            txtRuc.Clear();
            rbCliente.Checked = false;
            rbProveedor.Checked = false;
            lblID.Text = "";
        }

        private void txtBuscarVencimiento_TextChanged(object sender, EventArgs e)
        {
            try
            {
               List<Cliente> ls =  new BusCliente().ListarClientes(txtBuscarCliente.Text);
                gdvClientes.DataSource = ls;
                DataTablePersonalizado.Multilinea(ref gdvClientes);
                gdvClientes.Columns[2].Visible = false;
                gdvClientes.Columns[10].Visible = false;

            }
            catch (Exception )
            {
                MessageBox.Show("No existe el cliente buscado, verifique nuevamente", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
