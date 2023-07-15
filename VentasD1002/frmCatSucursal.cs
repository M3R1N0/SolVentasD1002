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
    public partial class frmCatSucursal : Form
    {
        public frmCatSucursal()
        {
            InitializeComponent();
        }

        private void frmCatSucursal_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Texts) && !string.IsNullOrEmpty(txtDirección.Texts))
                {
                    CatalogoGenerico c = new CatalogoGenerico();
                    c.Nombre = txtNombre.Texts.Trim();
                    c.Descripcion = txtDirección.Texts.Trim();
                    c.Estado = true;

                    DatCatGenerico.Guardar_Sucursal(c);
                    Comun.LimpiarTextBox(this.Controls);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Comun.LimpiarTextBox(this.Controls);
            this.Close();
        }
    }
}
