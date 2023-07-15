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
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            MostrarMenu();
        }

        #region Permisos "MENU"

        private void MostrarMenu()
        {
            try
            {
                var idUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
                string modulos = "TODOS";
                var menus = PermisoDAL.ListaPermisosMenu(idUsuario, modulos).OrderBy(x=>x.Modulo).ToList();
                flowPnlItems.Controls.Clear();
                foreach (var modulo in menus.GroupBy(x=>x.Modulo).ToList())
                {
                    var miMenu = new MenuStrip();
                    Panel panel = new Panel();
                    Label label = new Label();
                    bool esVacio = true;
                    label.Text = modulo.Key;
                    panel.BackColor = Color.WhiteSmoke;
                    miMenu.BackColor = Color.WhiteSmoke;
                    panel.Size = (menus.Where(x => x.Modulo.Equals(modulo.Key)).ToList().Count() < 3) 
                                ? new Size(288, 100)
                                : new Size(865, 100);

                    foreach (var item in menus.Where(x=>x.Modulo.Equals(modulo.Key)).OrderBy(x=> x.Nombre).ToList())
                    {
                        if (this.GetType().Name == item.NombreForm || item.NombreForm =="frmSubMenus") continue;

                        ToolStripMenuItem menuPadre = new ToolStripMenuItem(item.Nombre, null, Click_Menu, item.NombreForm);
                        MemoryStream ms = new MemoryStream(item.Icono);
                        menuPadre.Image = Image.FromStream(ms);
                        menuPadre.TextImageRelation = TextImageRelation.ImageAboveText;
                        menuPadre.ImageScaling = ToolStripItemImageScaling.None;
                        menuPadre.BackColor = Color.WhiteSmoke;

                        if (item.NombreForm == "frmVenta" || item.NombreForm == "frmBonificacion")
                        {
                            menuPadre.Enabled = false;
                        }

                        esVacio = false;
                        miMenu.Items.Add(menuPadre);
                    }

                    if (!esVacio)
                    {
                        panel.Controls.Add(label);
                        panel.Controls.Add(miMenu);

                        miMenu.Dock = DockStyle.Top;
                        label.Dock = DockStyle.Top;
                        panel.Dock = DockStyle.Top;

                        label.BringToFront();
                        miMenu.BringToFront();
                        panel.BringToFront();

                        flowPnlItems.Controls.Add(panel); 
                    }
                  
                   
                }
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
                    if (frmCreado.Name == "frmPermisos")
                    {
                        MostrarMenu();
                    }
                }
            }
            else
            {
                MessageBox.Show("El formulario no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void frmConfiguracion_SizeChanged(object sender, EventArgs e)
        {
            pnlFondo.Location = new Point(this.Width / 2 - pnlFondo.Width / 2, this.Height / 2 - pnlFondo.Height / 2);
            pnlFondo.Anchor = AnchorStyles.None;
        }
    }
}
