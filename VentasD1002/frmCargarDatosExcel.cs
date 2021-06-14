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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmCargarDatosExcel : Form
    {
        public frmCargarDatosExcel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRutaBackup.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void frmCargarDatosExcel_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
        }

        private void btnCargarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string ext = Path.GetExtension(txtRutaBackup.Text);
                if (!string.IsNullOrEmpty(txtRutaBackup.Text))
                {
                    if (ext.Equals(".csv"))
                    {
                        DataTable dt = Exportar_Importar_ArchivoExcel.CargarCSV(txtRutaBackup.Text);
                        //DataTablePersonalizado.Leer_ArchivoExcel(ref gdvDatos, txtRutaBackup.Text);

                        gdvDatos.DataSource = dt;
                        DataTablePersonalizado.Multilinea(ref gdvDatos);

                        gdvDatos.Columns[0].Visible = false;
                        gdvDatos.Columns[1].Visible = false;
                        gdvDatos.Columns[2].Visible = false;
                        gdvDatos.Columns[12].Visible = false;
                        gdvDatos.Columns[13].Visible = false;
                        gdvDatos.Columns[14].Visible = false;
                        gdvDatos.Columns[15].Visible = false;
                        gdvDatos.Columns[16].Visible = false;
                        gdvDatos.Columns[17].Visible = false;
                       // gdvDatos.Columns[18].Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Seleccione el archivo con extension .csv para continuar", "Archivo no admitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione el archivo de respaldo a cargar", "Ruta no valida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRutaBackup.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el archivo : "+ex.Message, "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarProducto();
          
        }

        private void ActualizarProducto()
        {

            if (gdvDatos.Rows.Count != 0)
            {
                List<string> lstproductosNoActualizados = new List<string>();
                int contadorActualizados = 0;
                int TotalProductosCargados = gdvDatos.Rows.Count;

                try
                {
                    foreach (DataGridViewRow dr in gdvDatos.Rows)
                    {
                        Producto p = new Producto();
                        p.Id = Convert.ToInt32(dr.Cells[0].Value);
                        p.IdTipoPresentacion = Convert.ToInt32(dr.Cells[1].Value);
                        p.IdCategoria = Convert.ToInt32(dr.Cells[2].Value);
                        p.codigo = dr.Cells[3].Value.ToString();
                        p.Descripcion = dr.Cells[4].Value.ToString();
                        p.Presentacion = dr.Cells[5].Value.ToString();
                        p.seVendeA = dr.Cells[6].Value.ToString();
                        p.precioMenudeo = Convert.ToDecimal(dr.Cells[7].Value);
                        p.precioMMayoreo = Convert.ToDecimal(dr.Cells[8].Value);
                        p.APartirDe = Convert.ToDecimal(dr.Cells[9].Value);
                        p.precioMayoreo = Convert.ToDecimal(dr.Cells[10].Value);
                        p.usaInventario = dr.Cells[11].Value.ToString();
                        p.stock = dr.Cells[12].Value.ToString();
                        p.stockMinimo = Convert.ToDecimal(dr.Cells[13].Value);
                        p.Caducidad = dr.Cells[14].Value.ToString();
                        p.Estado = Convert.ToBoolean(dr.Cells[15].Value.ToString());
                        p.TotalUnidades = Convert.ToDecimal(dr.Cells[16].Value);
                        p.PresentacionMenudeo = dr.Cells[17].Value.ToString();

                        if (DatProducto.ExisteProductoPorID(p.codigo))
                        {
                            new DatProducto().ActualizarProducto_Excel(p);
                            gdvDatos.Rows.RemoveAt(dr.Index);
                            
                            contadorActualizados++;
                        }
                        else
                        {
                            lstproductosNoActualizados.Add(p.Descripcion);
                        }

                    }

                    ValidarProcesoActualizacion(lstproductosNoActualizados, contadorActualizados, TotalProductosCargados);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al actualizar los datos : " + ex.Message, "Erro de Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void ValidarProcesoActualizacion(List<string> lstproductosNoActualizados, int contadorActualizados, int totalProductosCargados)
        {

            if (contadorActualizados == totalProductosCargados)
            {
                MessageBox.Show($"Se han actualizado todos los productos de manera exitosa", "Operacion realizada con Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                txtRutaBackup.Clear();
                gdvDatos.DataSource = null;
            }
            else
            {
                MessageBox.Show($"Se actualizaron {contadorActualizados} de {totalProductosCargados} productos cargados \n Los siguientes productos no se han dado de alta en el sistema  o han cambiado de Codigo", "Operacion Realizada con detalles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEditar.Enabled = true;
            }

            gdvDatos.Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dr in gdvDatos.Rows)
                {
                    Producto p = new Producto();
                    p.Id = Convert.ToInt32(dr.Cells[0].Value);
                    p.IdTipoPresentacion = Convert.ToInt32(dr.Cells[1].Value);
                    p.IdCategoria = Convert.ToInt32(dr.Cells[2].Value);
                    p.codigo = dr.Cells[3].Value.ToString();
                    p.Descripcion = dr.Cells[4].Value.ToString();
                    p.Presentacion = dr.Cells[5].Value.ToString();
                    p.seVendeA = dr.Cells[6].Value.ToString();
                    p.precioMenudeo = Convert.ToDecimal(dr.Cells[7].Value);
                    p.precioMMayoreo = Convert.ToDecimal(dr.Cells[8].Value);
                    p.APartirDe = Convert.ToDecimal(dr.Cells[9].Value);
                    p.precioMayoreo = Convert.ToDecimal(dr.Cells[10].Value);
                    p.usaInventario = dr.Cells[11].Value.ToString();
                    p.stock = dr.Cells[12].Value.ToString();
                    p.stockMinimo = Convert.ToDecimal(dr.Cells[13].Value);
                    p.Caducidad = dr.Cells[14].Value.ToString();
                    p.Estado = Convert.ToBoolean(dr.Cells[15].Value.ToString());
                    p.TotalUnidades = Convert.ToDecimal(dr.Cells[16].Value);
                    p.PresentacionMenudeo = dr.Cells[17].Value.ToString();

                    frmABProducto producto = new frmABProducto(p);
                    producto.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar los datos : "+ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
