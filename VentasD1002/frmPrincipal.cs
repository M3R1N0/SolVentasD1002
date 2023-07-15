using BusVenta;
using BusVenta.Helpers;
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

namespace VentasD1002
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private Form currentChildForm;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MostrarMenu();
        }

        #region Permisos "MENU"

        private void MostrarMenu()
        {
            try
            {
                var idUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
                string modulos = "frmVenta,frmDevoluciones,frmCreditosCobrar,frmDashboard,frmReimprimirTicket,frmListaIngresosEgresos,frmProductos,frmConfiguracion,frmCierreCaja";
                var menus = PermisoDAL.ObtenerFormsInternos(idUsuario, modulos);
                var miMenu = new MenuStrip();

                var _procesarVenta = menus.Where(x => x.NombreForm == "frmVenta").FirstOrDefault();
                if (_procesarVenta !=null)
                {
                    foreach (var menu in menus)
                    {
                        if (menu.NombreForm == "frmVentasEnEspera" || menu.NombreForm == "frmBonificacion") continue;

                        if (menu.NombreForm == "frmVenta")
                        {
                            OpenForm(new frmVenta());
                            continue;
                        }

                        ToolStripMenuItem menuPadre = new ToolStripMenuItem(menu.Nombre, null, Click_Menu, menu.NombreForm);
                        MemoryStream ms = new MemoryStream(menu.Icono);
                        menuPadre.Image = Image.FromStream(ms);
                        menuPadre.TextImageRelation = TextImageRelation.ImageAboveText;
                        menuPadre.ImageScaling = ToolStripItemImageScaling.None;

                        miMenu.Items.Add(menuPadre);
                    }

                    this.MainMenuStrip = miMenu;
                    Controls.Add(miMenu);
                }
                else
                {
                    pnlSuperior.Visible = true;
                    OpenForm(new frmConfiguracion());
                    Obtener_PerfilUsuario();
                    timerReloj.Start();
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
                }
            }
            else
            {
                MessageBox.Show("El formulario no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           
        }

        private void Obtener_PerfilUsuario()
        {
            try
            {
                var serialPC = Sistema.ObenterSerialPC();
                var u = BusUser.ObtenerUsuario_Loggeado();
                byte[] b = u.Foto;
                MemoryStream ms = new MemoryStream(b);
                pbPerfil.Image = Image.FromStream(ms);
                linkPerfil.Text = $"{u.Nombre} ({u.Rol})";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void linkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var sesion = BusUser.ObtenerUsuario_Loggeado();
            frmABUsuario usuario = new frmABUsuario(sesion.Id);
            usuario.ShowDialog();
            Obtener_PerfilUsuario();
        }
    }
}
