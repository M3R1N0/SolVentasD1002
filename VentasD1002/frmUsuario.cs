using BusVenta;
using BusVenta.Helpers;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            MostrarMenu();
            ListarUsuarios();
        }

        #region Permisos "MENU"

        private void MostrarMenu()
        {
            try
            {
                var idUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
                string modulos = "frmABUsuario";
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
            ToolStripMenuItem itemSeleccionado = (ToolStripMenuItem)sender;
            Assembly asm = Assembly.GetEntryAssembly();
            Type element = asm.GetType(asm.GetName().Name + "." + itemSeleccionado.Name);

            if (element != null)
            {
                var frmCreado = (Form)Activator.CreateInstance(element);

                if (Application.OpenForms[element.Name] == null)
                {
                    //frmCreado.MdiParent = this;
                    frmCreado.ShowDialog();
                    ListarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("El formulario no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ListarUsuarios()
        {
            var lstRol = DatCatGenerico.ListarCat_TipoUsuario();
            List<User> lstUsuarios = new BusUser().getUsersList(new User());

            var comboBox = (DataGridViewComboBoxColumn)gridUsuarios.Columns["Perfil"];
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "Id";
            comboBox.DataSource = lstRol;

            gridUsuarios.DataSource = lstUsuarios;

            Comun.StyleDatatable(ref gridUsuarios);
        }

        private void gdvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gdvUsuariosII_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int oneKey = Convert.ToInt32(gridUsuarios.SelectedCells[2].Value);
                if (e.ColumnIndex == this.gridUsuarios.Columns["Eliminar"].Index)
                {
                    DialogResult result = MessageBox.Show("¿Seguro desea eliminar el usuario seleccionado?", "Eliminar usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        // foreach (DataGridViewRow row in gdvUsuariosII.SelectedRows)
                        // {
                        User u = new User();
                        u.Id = oneKey;//Convert.ToInt32(row.Cells["Id"].Value);
                        new BusUser().DeleteUser(u);
                        ListarUsuarios();
                        //}
                    }
                }

                if (e.ColumnIndex == this.gridUsuarios.Columns["Reestablecer"].Index)
                {
                    DialogResult result = MessageBox.Show("Está a punto de reestaablecer la contraseña \n¿Desea continuar?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        string pwd = "";
                        foreach (DataGridViewRow row in gridUsuarios.SelectedRows)
                        {
                            pwd = row.Cells["Usuario"].Value.ToString();
                        }

                        pwd = EncriptarTexto.Encriptar(pwd);
                        if (DatUser.ReestablecerContraseña(oneKey, pwd))
                        {
                            MessageBox.Show("Se ha reestablecido la contraseña de forma exitosa \n La contraseña es el nombre de usuario", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un detalle al intentar reestablecer la contraseña", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void gridUsuarios_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {

                if (((DataGridView)sender).CurrentCell.ColumnIndex == 11)
                {
                    ComboBox cbo = e.Control as ComboBox;

                    if (cbo != null)
                    {
                        cbo.SelectionChangeCommitted -= new EventHandler(cbProfile_SelectedIndexChanged);
                        // now attach the event handler
                        cbo.SelectionChangeCommitted += new EventHandler(cbProfile_SelectedIndexChanged);
                    }
                }

          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un detalle al obtener los datos seleccionados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cbo = gridUsuarios.EditingControl as ComboBox;
                User user = gridUsuarios.CurrentRow.DataBoundItem as User;
                user.IdRol = Convert.ToInt32(cbo.SelectedValue);

                DatUser.ActualizarPerfilUsuario(user);
                ListarUsuarios();
            }
            catch (Exception ex)
            { }
        }
    }
}
