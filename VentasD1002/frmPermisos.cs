using Bunifu.Framework.UI;
using BusVenta;
using DatVentas;
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
using static EntVenta.PermisoVM;

namespace VentasD1002
{
    public partial class frmPermisos : Form
    {
        public frmPermisos()
        {
            InitializeComponent();
            LlenarCboRol();
        }

        private void LlenarCboRol()
        {
            try
            {
                var dtCatalogoRol = DatCatGenerico.ListarCat_TipoUsuario();
                cboRol.DataSource = dtCatalogoRol;
                cboRol.DisplayMember = "Nombre";
                cboRol.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Orcurrio un error al llenar el Rol, contacte al Administrador" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboRol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DibujarItems();
        }

        private void DibujarItems()
        {
            try
            {
                pnlITems.Controls.Clear();
                List<int> lstId = new List<int>();

                int idPerfil = Convert.ToInt32(cboRol.SelectedValue);
                var lstPermiso = PermisoDAL.ListarPermiso(idPerfil);
                var lstSubMenu = PermisoDAL.ListarSubMenu();


                lstId = lstPermiso.Where(x => x.Estado == true).Select(x => x.IdMenu).ToList();

                foreach (var item in lstSubMenu)
                {
                    Label label = new Label();
                    Panel panel = new Panel();
                    BunifuiOSSwitch oSSwitch = new BunifuiOSSwitch();

                    label.Text = item.Nombre;
                    label.Name = item.Id.ToString();
                    //label.Size = new Size(175, 25);
                    label.Font = new Font("Century gothic", 8);
                    label.FlatStyle = FlatStyle.Flat;
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.Black;
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.TopLeft;

                    panel.Size = new Size(200, 20);

                    oSSwitch.Dock = DockStyle.Left;
                    oSSwitch.Font = new Font("Century gothic", 7);
                    oSSwitch.Name = item.Id.ToString();
                    oSSwitch.Value = false;

                    if (lstId.Contains(item.Id))
                    {
                        oSSwitch.Value = true;
                    }

                    panel.Controls.Add(oSSwitch);
                    panel.Controls.Add(label);
                    label.BringToFront();
                    pnlITems.Controls.Add(panel);

                    oSSwitch.OnValueChange += new EventHandler(oSSwitchEvent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void oSSwitchEvent(object sender, EventArgs e)
        {
            try
            {
                var f = ((BunifuiOSSwitch)sender);
                string idSubmenu = ((BunifuiOSSwitch)sender).Name;
                bool valueCheck = ((BunifuiOSSwitch)sender).Value;


                int IdSubmenu = Convert.ToInt32(idSubmenu);
                int idPerfil = Convert.ToInt32(cboRol.SelectedValue);

                if (valueCheck)
                {
                    PermisoDAL.GuardarConf_Permisos(idPerfil, IdSubmenu, valueCheck);
                    //DibujarItems();
                }
                else
                {
                    var result = MessageBox.Show("¿Seguro desea quitar el permiso?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        PermisoDAL.GuardarConf_Permisos(idPerfil, IdSubmenu, valueCheck);
                    }

                    DibujarItems();

                }

            }
            catch (Exception)
            {
            }
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            MostrarMenu();
        }

        #region Permisos "MENU"

        private void MostrarMenu()
        {
            try
            {
                var idUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
                string modulos = "Modulos";
                var menus = PermisoDAL.ListaPermisosMenu(idUsuario, modulos);
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
            DibujarItems();
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
                    DibujarItems();
                }
            }
            else
            {
                MessageBox.Show("El formulario no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
