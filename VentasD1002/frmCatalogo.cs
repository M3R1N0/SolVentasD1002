using BusVenta;
using BusVenta.Helpers;
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
    public partial class frmCatalogo : Form
    {
        private EnumTipoCatalogo TIPO_CATALOGO;

        public frmCatalogo(string Detalle, EnumTipoCatalogo enumTipo)
        {
            InitializeComponent();
            lblDetalle.Text = Detalle;
            TIPO_CATALOGO = enumTipo;
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtDetalle.Text))
                {
                    MessageBox.Show("Favor de llenar los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //int valor = (tipoCatalogo.Equals(EnumTipoCatalogo.PRESENTACION)) ? 2 : 1;
                    CatalogoGenerico c = new CatalogoGenerico();
                    c.Nombre = txtNombre.Text.Trim();
                    c.Descripcion = txtDetalle.Text.Trim();
                    var respuesta = BusCatGenerico.AgregarCategoriasGenericas(c, TIPO_CATALOGO);

                    MessageBox.Show(respuesta.Message,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Comun.LimpiarTextBox(this.Controls);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
