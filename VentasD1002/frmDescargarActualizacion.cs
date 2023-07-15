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
    public partial class frmDescargarActualizacion : Form
    {
        public frmDescargarActualizacion()
        {
            InitializeComponent();
        }

        private void frmDescargarActualizacion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                DataTable table = new DataTable();
                //columns  
                table.Columns.Add("Id_Producto", typeof(string));
                table.Columns.Add("Presentacion_Id", typeof(Int32));
                table.Columns.Add("Catalogo_Id", typeof(Int32));
                table.Columns.Add("Codigo", typeof(string));
                table.Columns.Add("Descripcion", typeof(string));
                table.Columns.Add("Presentacion", typeof(string));
                table.Columns.Add("Tipo_Venta", typeof(string));
                table.Columns.Add("Precio_Menudeo", typeof(decimal));
                table.Columns.Add("Precio_MMayoreo", typeof(decimal));
                table.Columns.Add("A_Partir_De", typeof(decimal));
                table.Columns.Add("Precio_Mayoreo", typeof(decimal));
                table.Columns.Add("Usa_Inventario", typeof(string));
                table.Columns.Add("Stock", typeof(string));
                table.Columns.Add("Stock_Minimo", typeof(decimal));
                table.Columns.Add("Caducidad", typeof(string));
                table.Columns.Add("Estado", typeof(Boolean));
                table.Columns.Add("TotalUnidades", typeof(Int32));
                table.Columns.Add("PresentacionMenudeo", typeof(string));


                List<string> lst = new DatProducto().listadoActualizacion();

                foreach (var item in lst)
                {
                    Producto p = new BusProducto().ObtenerProducto_A_Actualizar2(item);

                    table.Rows.Add(
                                p.Id,
                                p.IdTipoPresentacion,
                                p.IdCategoria,
                                p.codigo,
                                p.Descripcion,
                                p.Presentacion,
                                p.seVendeA,
                                p.precioMenudeo,
                                p.precioMMayoreo,
                                p.APartirDe,
                                p.precioMayoreo,
                                p.usaInventario,
                                p.stock,
                                p.stockMinimo,
                                p.Caducidad,
                                p.Estado,
                                p.TotalUnidades,
                                p.PresentacionMenudeo

                        );

                }

                gdDetalle.DataSource = table;

                gdDetalle.Columns[0].Visible = false;
                gdDetalle.Columns[1].Visible = false;
                gdDetalle.Columns[2].Visible = false;
                gdDetalle.Columns[12].Visible = false;
                gdDetalle.Columns[13].Visible = false;
                gdDetalle.Columns[14].Visible = false;
                gdDetalle.Columns[15].Visible = false;
                gdDetalle.Columns[16].Visible = false;
                gdDetalle.Columns[17].Visible = false;

                DataTablePersonalizado.Multilinea(ref gdDetalle);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al descargar el archivo de actualizacion : " + ex.Message, "Error de descarga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            try
            {

                if (gdDetalle.Rows.Count != 0)
                {
                   //Exportar_Importar_ArchivoExcel.ExportarExcel_Actualizacion(d);
                   //Exportar_Importar_ArchivoExcel.Exportar(ref gdDetalle);
                    this.Hide();
                    DatProducto.EliminarRegistros_ActualizacionProducto();

                   this.Hide();
                }
                else
                {
                    MessageBox.Show("No hay datos para descargar", "Datos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :"+ex.Message, "Error de Descarga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarDatos_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea borrar los datos, no podrá recuperar los datos actualizados", "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (result == DialogResult.Yes)
                {
                    DatProducto.EliminarRegistros_ActualizacionProducto();
                    MessageBox.Show("Se han eliminado los datos correctamente" , "Operación Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los datos:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
