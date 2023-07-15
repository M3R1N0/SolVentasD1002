using BusVenta;
using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            MostrarMenu();
        }

        #region Permisos "MENU"

        private void MostrarMenu()
        {
            try
            {
                var idUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
                string modulos = "frmAltaCliente";
                var menus = PermisoDAL.ObtenerFormsInternos(idUsuario, modulos);
                var miMenu = new MenuStrip();
                miMenu.Items.Clear();
                foreach (var menu in menus)
                {
                    ToolStripMenuItem menuPadre = new ToolStripMenuItem(menu.Nombre, null, Click_Menu, menu.NombreForm);
                    MemoryStream ms = new MemoryStream(menu.Icono);
                    menuPadre.Image = Image.FromStream(ms);
                    menuPadre.Text = menu.Nombre;
                    menuPadre.TextImageRelation = TextImageRelation.ImageBeforeText;
                    menuPadre.ImageScaling = ToolStripItemImageScaling.None;

                    miMenu.Items.Add(menuPadre);
                }
                this.MainMenuStrip = miMenu;
                Controls.Add(miMenu);
            }
            catch (Exception ex)
            { }
        }

        private void Click_Menu(object sender, EventArgs evt)
        {
            CLIENTE_PROVEEDOR TIPO = (rbtnCliente.Checked)
                                       ? CLIENTE_PROVEEDOR.CLIENTE
                                       : CLIENTE_PROVEEDOR.PROVEEDOR;
            frmAltaCliente altaCliente = new frmAltaCliente(TIPO);
            altaCliente.ShowDialog();
            ValidarListado();
        }

        #endregion

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ValidarListado();
        }

        private void ValidarListado()
        {
            try
            {
                var busqueda = txtBuscarCliente.Text;

                if (rbtnCliente.Checked)
                {
                     DatCliente.ListarClientes(ref gdvClientes,busqueda);
                }

                if (rbtnProveedor.Checked)
                {
                    DatCliente.ListarProveedores(ref gdvClientes, busqueda);
                    gdvClientes.Columns[10].Visible = false;
                }

                DataTablePersonalizado.Multilinea(ref gdvClientes);
                gdvClientes.Columns[2].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrióun error al mostrar los datos" + ex.Message, "Listado de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(gdvClientes.SelectedCells[2].Value.ToString());
                CLIENTE_PROVEEDOR TIPO = (rbtnCliente.Checked)
                                        ? CLIENTE_PROVEEDOR.CLIENTE
                                        : CLIENTE_PROVEEDOR.PROVEEDOR;

                if (e.ColumnIndex == this.gdvClientes.Columns["Delete"].Index)
                {
                    DialogResult result = MessageBox.Show("¿Esta seguro de borrar la fila seleccionada ?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            if (TIPO == CLIENTE_PROVEEDOR.CLIENTE)
                            {
                                new BusCliente().eliminar_Cliente(id);
                            }
                            else
                            {
                                DatCliente.EliminarProveedor(id);
                            }

                            MessageBox.Show("Registro Eliminado", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un error al intentar eliminar el registro" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (e.ColumnIndex == this.gdvClientes.Columns["Edit"].Index)
                {
                    frmAltaCliente altaCliente = new frmAltaCliente(id, TIPO);
                    altaCliente.ShowDialog();
                }

                ValidarListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar obtener los datos" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarVencimiento_TextChanged(object sender, EventArgs e)
        {
            ValidarListado();
        }

        private void rbtnCliente_CheckedChanged(object sender, EventArgs e)
        {
            ValidarListado();
        }

        private void rbtnProveedor_CheckedChanged(object sender, EventArgs e)
        {
            ValidarListado();
        }
    }
}
