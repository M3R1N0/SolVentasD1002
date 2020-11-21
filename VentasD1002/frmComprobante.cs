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
    public partial class frmComprobante : Form
    {
        public frmComprobante()
        {
            InitializeComponent();
        }

        private int ID;

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtNombreComprobante.Text) || string.IsNullOrEmpty(TXTCANTIDADDECEROS.Text)
                    || string.IsNullOrEmpty(txtnumerofin.Text) || string.IsNullOrEmpty(txtSerie.Text))
                {
                    MessageBox.Show("Favor de llenar todos los campos" , "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Serializacion s = new Serializacion();
                    s.Tipo_Documento = txtNombreComprobante.Text;
                    s.Serie = txtSerie.Text;
                    s.NumeroFin = txtnumerofin.Text;
                    s.Cantidad_Numero = TXTCANTIDADDECEROS.Text;
                    s.Destino = "OTROS";
                    s.Por_Defecto = "-";

                    new BusSerializacion().Agregar_Serializacion(s);
                    MessageBox.Show("Operación Realizada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlABComprobante.Visible = false;
                    LimpiarCampos();
                    ListarComprobantes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrióun error al agregar los datos" + ex.Message, "Nuevo  comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarComprobantes()
        {
            try
            {
                List<Serializacion> ls = new BusSerializacion().ListarComprobantes();
                gdvComprobantes.DataSource = ls;
                gdvComprobantes.Columns[2].Visible = false;
                gdvComprobantes.Columns[3].Visible = false;
                gdvComprobantes.Columns[4].Visible = false;
                gdvComprobantes.Columns[5].Visible = false;

                DataTablePersonalizado.Multilinea(ref gdvComprobantes);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrióun error al mostrar los datos" + ex.Message, "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmComprobante_Load(object sender, EventArgs e)
        {
            pnlABComprobante.Visible = false; 
            ListarComprobantes();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUARDAR.Enabled = true;
            GUARDARCAMBIOS.Enabled = false;
            pnlABComprobante.Visible = true;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            TXTCANTIDADDECEROS.Clear();
            txtNombreComprobante.Clear();
            txtnumerofin.Clear();
            txtSerie.Clear();
            checkDefecto.Checked = false;
            lblID.Text = "";
            lblDocumento.Text = "";
        }

        private void VOLVEROK_Click(object sender, EventArgs e)
        {
            pnlABComprobante.Visible = false;
            LimpiarCampos();
        }

        private void gdvComprobantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gdvComprobantes.Columns["Eliminar"].Index) 
            {
                DialogResult result = MessageBox.Show("¿Esta seguro de eliminar los datos seleccionados?","Borrar Comprobante", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                try
                {
                    if (result == DialogResult.OK)
                    {
                        var id = gdvComprobantes.SelectedCells[2].Value.ToString();
                        var destino = gdvComprobantes.SelectedCells[6].Value.ToString();
                        if (destino.Equals("VENTAS"))
                        {
                            MessageBox.Show("No tiene permisos para eliminar este comprobante", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            new BusSerializacion().Borrar_Serializacion(Convert.ToInt32(id));
                            ListarComprobantes();
                            MessageBox.Show("Operación Realizada", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }

            if (e.ColumnIndex == gdvComprobantes.Columns["Editar"].Index)
            {
                GUARDAR.Enabled = false;
                GUARDARCAMBIOS.Enabled = true;
                lblDocumento.Text = gdvComprobantes.SelectedCells[7].Value.ToString();
                lblID.Text = gdvComprobantes.SelectedCells[2].Value.ToString();
                TXTCANTIDADDECEROS.Text = gdvComprobantes.SelectedCells[4].Value.ToString();
                txtSerie.Text = gdvComprobantes.SelectedCells[3].Value.ToString();
                txtnumerofin.Text = gdvComprobantes.SelectedCells[5].Value.ToString();
                txtNombreComprobante.Text = gdvComprobantes.SelectedCells[7].Value.ToString();
                var activo = gdvComprobantes.SelectedCells[8].Value.ToString();
                if (activo.Equals("SI"))
                {
                    checkDefecto.Checked = true;
                }
                else
                {
                    checkDefecto.Checked = false;
                }
                pnlABComprobante.Visible = true;
            }
        }

        private void GUARDARCAMBIOS_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtNombreComprobante.Text) || string.IsNullOrEmpty(TXTCANTIDADDECEROS.Text)
                    || string.IsNullOrEmpty(txtnumerofin.Text) || string.IsNullOrEmpty(txtSerie.Text))
                {
                    MessageBox.Show("Favor de llenar todos los campos", "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string documento = lblDocumento.Text;
                    Serializacion s = new Serializacion();
                    s.Tipo_Documento = txtNombreComprobante.Text;
                    s.Serie = txtSerie.Text;
                    s.NumeroFin = txtnumerofin.Text;
                    s.Cantidad_Numero = TXTCANTIDADDECEROS.Text;
                    s.Destino = documento.Equals("TICKET") || documento.Equals("BOLETA") || documento.Equals("FACTURA") ? "VENTAS" : "OTROS";
                    s.Por_Defecto = checkDefecto.Checked == true ? "SI" : "NO";
                    s.Id = Convert.ToInt32(lblID.Text);
                    new BusSerializacion().Actualizar_Serializacion(s);
                    MessageBox.Show("Operación Realizada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlABComprobante.Visible = false;
                    LimpiarCampos();
                    ListarComprobantes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
