using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
         
        }

        public static string producto;

        private void frmProductos_Load_1(object sender, EventArgs e)
        {
            MostrarMenu();
            ListarProductos("");
        }

        #region Permisos "MENU"

        private void MostrarMenu()
        {
            try
            {
                var idUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
                string modulos = "frmABProducto,frmExcel";
                var menus = PermisoDAL.ObtenerFormsInternos(idUsuario, modulos);
                var miMenu = new MenuStrip();

                foreach (var menu in menus)
                {
                    ToolStripMenuItem menuPadre = new ToolStripMenuItem(menu.Nombre, null, Click_Menu, menu.NombreForm);
                    MemoryStream ms = new MemoryStream(menu.Icono);
                    menuPadre.Image = Image.FromStream(ms);
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
            try
            {
                ToolStripMenuItem itemSeleccionado = (ToolStripMenuItem)sender;
                Assembly asm = Assembly.GetEntryAssembly();
                Type element = asm.GetType(asm.GetName().Name + "." + itemSeleccionado.Name);

                if (itemSeleccionado.Name == "frmABProducto")
                {
                    frmABProducto frmAB = new frmABProducto();
                    frmAB.FormClosing += frm_FormClosing;
                    frmAB.ShowDialog();
                }
                else
                {
                    Exportar_Importar_ArchivoExcel.ExportarProducto();
                }
            }
            catch (Exception)
            {
            }
            
        }

        #endregion

        public void ListarProductos(string buscar)
        {
            try
            {
                ProductoDAL.ListarProductos(ref gdvProductos, string.Empty);
                gdvProductos.Columns[2].Visible = false;
                // BusVenta.DataTablePersonalizado.Multilinea(ref gdvProductos);
                Comun.StyleDatatable(ref gdvProductos);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.gdvProductos.Columns["Eliminar"].Index)
                {
                    DialogResult result = MessageBox.Show("¿Desea eliminar este producto?", "Eliminar producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                    if (result == DialogResult.OK)
                    {
                        int oneKey = Convert.ToInt32(gdvProductos.SelectedCells[2].Value);
                        try
                        {
                            ProductoDAL.ActivarDesactivar_Producto(oneKey, false);

                            MessageBox.Show("Operación realizada con éxito", "Operacion realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AgregarBitacora(oneKey);
                            ListarProductos("");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (e.ColumnIndex == this.gdvProductos.Columns["Editar"].Index)
                {
                    int id = Convert.ToInt32(gdvProductos.SelectedCells[2].Value);
                    frmABProducto frmAB = new frmABProducto(id);
                    frmAB.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un detalle al obtener los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ProductoDAL.ListarProductos(ref gdvProductos,txtBuscar.Text);
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtBuscar.Text = string.Empty;
                txtBuscar.Focus();
            }
        }

        private void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtBuscar.Focus();
            ListarProductos(producto);
        }

        private void AgregarBitacora(int ID)
        {
            try
            {
                string serialPC = Sistema.ObenterSerialPC();

                int _idCaja = BusBox.showBoxBySerial().Id;
                int _idusuario = BusUser.ObtenerUsuario_Loggeado().Id;

                Bitacora b = new Bitacora();
                b.Fecha = DateTime.Now;
                b.IdUsuario = _idusuario;
                b.IdCaja = _idCaja;
                b.Accion = $"ELIMINACION DEL PRODUCTO [{ID}]";

                DatCatGenerico.AgregarBitácora(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la bitacora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
