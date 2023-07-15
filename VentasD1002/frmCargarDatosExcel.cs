using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
using OfficeOpenXml;
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

using ExcelApp = Microsoft.Office.Interop.Excel;

namespace VentasD1002
{
    public partial class frmCargarDatosExcel : Form
    {
        private List<ProductoVM> _lstProducts;

        public frmCargarDatosExcel()
        {
            InitializeComponent();
        }

        private void frmCargarDatosExcel_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            cboTipoProceso.SelectedIndex = 1;
        }

        private void cboTipoProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoProceso.Text.ToUpper())
            {
                case "CARGA":
                    pnlDescargaActualizacion.Visible = false;
                    pnlDescargaActualizacion.Dock = DockStyle.None;
                    pnlCargaActualizacion.Visible = true;
                    pnlCargaActualizacion.Dock = DockStyle.Top;
                    pnlCargaActualizacion.BringToFront();
                    break;
                case "DESCARGA":
                    pnlCargaActualizacion.Visible = false;
                    pnlCargaActualizacion.Dock = DockStyle.None;
                    pnlDescargaActualizacion.Visible = true;
                    pnlDescargaActualizacion.Dock = DockStyle.Top;
                    pnlDescargaActualizacion.BringToFront();
                    break;
                default:
                    pnlDescargaActualizacion.Visible = false;
                    pnlDescargaActualizacion.Dock = DockStyle.None;
                    pnlCargaActualizacion.Visible = false;
                    pnlCargaActualizacion.Dock = DockStyle.None;
                    break;
            }
        }

        #region Cargar y actualizar

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRutaBackup.Text = openFileDialog1.FileName.ToString();
                try
                {
                    string ext = Path.GetExtension(txtRutaBackup.Text);
                    if (!string.IsNullOrEmpty(txtRutaBackup.Text))
                    {
                        if (ext.Equals(".xlsx"))
                        {
                            var respuesta = Exportar_Importar_ArchivoExcel.ReadExcel(txtRutaBackup.Text);

                            if (respuesta.IsSuccess == EnumOperationResult.Failure)
                            {
                                MessageBox.Show(respuesta.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                _lstProducts = (List<ProductoVM>)respuesta.Data;
                                gdvDatos.DataSource = _lstProducts.Where(x=> x.Venta=="M").ToList();

                                foreach (DataGridViewColumn col in gdvDatos.Columns)
                                {
                                    col.Visible = false;
                                    if (col.Index == 3 || col.Index == 4 || col.Index == 5 || col.Index == 6 || col.Index == 7 ||
                                        col.Index == 8 || col.Index == 9 || col.Index == 10 || col.Index == 11 || col.Index == 12 || col.Index == 14 ||
                                        col.Index == 15 || col.Index == 16 || col.Index == 17 || col.Index == 29)// || col.Index  == 32 || col.Index  == 34 ||
                                                                                                                 // col.Index == 35 || col.Index == 36)
                                    {
                                        col.Visible = true;
                                    }
                                }

                                DataTablePersonalizado.Multilinea(ref gdvDatos);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione el archivo con extension .xlsx para continuar", "Archivo no admitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Ocurrió un error al cargar el archivo : " + ex.Message, "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                List<ProductoVM> lstNoActualizados = new List<ProductoVM>();

                int contadorActualizados = 0;
                int TotalProductosCargados = _lstProducts.Where(x => x.Venta == "M").ToList().Count();// gdvDatos.Rows.Count;

                try
                {
                    foreach (ProductoVM item in _lstProducts.Where(x => x.Venta == "M").ToList())
                    {
                        ProductoVM p = new ProductoVM();

                        var producto = ProductoDAL.FiltrarProductos(item.codigo).FirstOrDefault();

                        if (producto != null)
                        {
                            producto.idPresentacion = DatCatGenerico.ObtenerIdentificador_Catalogo(item.Presentacion.ToUpper(), TIPO_CATALOGO.PRESENTACION);
                            producto.IdCategoria = DatCatGenerico.ObtenerIdentificador_Catalogo(item.Categoria.ToUpper(), TIPO_CATALOGO.CATEGORIA);
                            producto.IdMarca = DatCatGenerico.ObtenerIdentificador_Catalogo(item.Marca.ToUpper(), TIPO_CATALOGO.MARCA);
                            producto.IdProveedor = DatCatGenerico.ObtenerIdentificador_Catalogo(item.Proveedor.ToUpper(), TIPO_CATALOGO.PROVEEDOR);
                            producto.codigo = item.codigo;
                            producto.Articulo = item.Articulo;
                            producto.Detalle = item.Detalle;
                            producto.PrecioCompra = item.PrecioCompra;
                            producto.Precio = item.Precio;
                            producto.PrecioMayoreo = item.PrecioMayoreo;
                            producto.A_Partir_De = item.A_Partir_De;
                            producto.TipoVenta = item.TipoVenta;
                            producto.UsaInventario = item.UsaInventario;
                            producto.StockMinimo = item.StockMinimo;
                            producto.Caducidad = item.Caducidad;
                            producto.UnidadesPorPresentacion = item.UnidadesPorPresentacion;
                            producto.Venta = item.Venta;
                            producto.Clave = item.Clave;
                            producto.Peso = item.Peso;
                            producto.Activo = false;

                            var menudeo = _lstProducts.Where(x => x.Id == item.Id && x.Venta == "U").FirstOrDefault();

                            if (menudeo != null)
                            {
                                producto.IdPresentacionU = DatCatGenerico.ObtenerIdentificador_Catalogo(menudeo.Presentacion.ToUpper(), TIPO_CATALOGO.PRESENTACION);
                                producto.CodigoU = menudeo.codigo;
                                producto.PrecioCompraU = menudeo.PrecioCompra;
                                producto.PrecioU = menudeo.Precio;
                                producto.PrecioMayoreoU = menudeo.PrecioMayoreo;
                                producto.A_Partir_DeU = menudeo.A_Partir_De;
                                producto.Activo = true;
                            }

                            ProductoDAL.GuardarProducto(producto);
                            contadorActualizados++;

                        }
                        else
                        {
                            lstNoActualizados.Add(item);
                            var menudeo = _lstProducts.Where(x => x.Id == item.Id && x.Venta == "U").FirstOrDefault();
                            if (menudeo !=null)
                            {
                                lstNoActualizados.Add(menudeo);
                            }
                        }
                    }

                    ValidarProcesoActualizacion(lstNoActualizados , contadorActualizados, TotalProductosCargados);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al actualizar los datos : " + ex.Message, "Erro de Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ValidarProcesoActualizacion(List<ProductoVM> lstproducto, int contadorActualizados, int totalProductosCargados)
        {
            gdvDatos.DataSource = null;
            if (contadorActualizados == totalProductosCargados)
            {
                MessageBox.Show($"Se han actualizado todos los productos de manera exitosa", "Operacion realizada con Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRutaBackup.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Se actualizaron {contadorActualizados} de {totalProductosCargados} productos cargados \n Los siguientes productos no se han dado de alta en el sistema  o han cambiado de Codigo", "Operacion Realizada con detalles", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _lstProducts = lstproducto;
                gdvDatos.DataSource = lstproducto;
                btnEditar.Enabled = true;

                foreach (DataGridViewColumn col in gdvDatos.Columns)
                {
                    col.Visible = false;
                    if (col.Index == 3 || col.Index == 4 || col.Index == 5 || col.Index == 6 || col.Index == 7 ||
                        col.Index == 8 || col.Index == 9 || col.Index == 10 || col.Index == 11 || col.Index == 12 || col.Index == 14 ||
                        col.Index == 15 || col.Index == 16 || col.Index == 17 || col.Index == 29)// || col.Index  == 32 || col.Index  == 34 ||
                                                                                                 // col.Index == 35 || col.Index == 36)
                    {
                        col.Visible = true;
                    }
                }

                DataTablePersonalizado.Multilinea(ref gdvDatos);

            }
            gdvDatos.Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in _lstProducts)
                {
                    var producto = new ProductoVM();

                    producto.idPresentacion = DatCatGenerico.ObtenerIdentificador_Catalogo(item.Presentacion.ToUpper(), TIPO_CATALOGO.PRESENTACION);
                    producto.IdCategoria = DatCatGenerico.ObtenerIdentificador_Catalogo(item.Categoria.ToUpper(), TIPO_CATALOGO.CATEGORIA);
                    producto.IdMarca = DatCatGenerico.ObtenerIdentificador_Catalogo(item.Marca.ToUpper(), TIPO_CATALOGO.MARCA);
                    producto.IdProveedor = DatCatGenerico.ObtenerIdentificador_Catalogo(item.Proveedor.ToUpper(), TIPO_CATALOGO.PROVEEDOR);
                    producto.codigo = item.codigo;
                    producto.Articulo = item.Articulo;
                    producto.Detalle = item.Detalle;
                    producto.PrecioCompra = item.PrecioCompra;
                    producto.Precio = item.Precio;
                    producto.PrecioMayoreo = item.PrecioMayoreo;
                    producto.A_Partir_De = item.A_Partir_De;
                    producto.TipoVenta = item.TipoVenta;
                    producto.UsaInventario = item.UsaInventario;
                    producto.StockMinimo = item.StockMinimo;
                    producto.Caducidad = item.Caducidad;
                    producto.UnidadesPorPresentacion = item.UnidadesPorPresentacion;
                    producto.Venta = item.Venta;
                    producto.Clave = item.Clave;
                    producto.Peso = item.Peso;
                    producto.Activo = false;

                    var menudeo = _lstProducts.Where(x => x.Id == item.Id && x.Venta == "U").FirstOrDefault();

                    if (menudeo != null)
                    {
                        producto.IdPresentacionU = DatCatGenerico.ObtenerIdentificador_Catalogo(menudeo.Presentacion.ToUpper(), TIPO_CATALOGO.PRESENTACION);
                        producto.CodigoU = menudeo.codigo;
                        producto.PrecioCompraU = menudeo.PrecioCompra;
                        producto.PrecioU = menudeo.Precio;
                        producto.PrecioMayoreoU = menudeo.PrecioMayoreo;
                        producto.A_Partir_DeU = menudeo.A_Partir_De;
                        producto.Activo = true;
                    }


                    frmABProducto frm = new frmABProducto(producto);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar los datos : "+ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Descargar Actualizacion

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var lst = ProductoDAL.Consultar_ProductosActualizados(dpInicio.Value, dpFin.Value);
                if (lst.Count > 0)
                {
                    gdvDatos.DataSource = lst;

                    foreach (DataGridViewColumn col in gdvDatos.Columns)
                    {
                        col.Visible = false;
                        if (col.Index == 3 || col.Index == 4 || col.Index == 5 || col.Index == 6 || col.Index == 7 ||
                            col.Index == 8 || col.Index == 9 || col.Index == 10 || col.Index == 11 || col.Index == 12 || col.Index == 14 ||
                            col.Index == 15 || col.Index == 16 || col.Index == 17 || col.Index == 29)// || col.Index  == 32 || col.Index  == 34 ||
                                                                                                     // col.Index == 35 || col.Index == 36)
                        {
                            col.Visible = true;
                        }
                    }

                    DataTablePersonalizado.Multilinea(ref gdvDatos);
                    Comun.StyleDatatable(ref gdvDatos);
                }
                else
                {
                    MessageBox.Show("No hay productos actualizados del rango de fecha seleccionado","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gdvDatos.Rows.Count != 0)
            {
                Exportar_Importar_ArchivoExcel.ExportarExcel_Actualizacion(dpInicio.Value, dpFin.Value);
            }
            else
            {
                MessageBox.Show("No hay datos para descargar, seleccione un rango de fecha distinto", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


    }
}
