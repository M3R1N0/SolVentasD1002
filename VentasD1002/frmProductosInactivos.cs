﻿using BusVenta;
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
    public partial class frmProductosInactivos : Form
    {
        public frmProductosInactivos()
        {
            InitializeComponent();
        }

        private void frmProductosInactivos_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void ObtenerDatos()
        {
            try
            {
                string buscar = (string.IsNullOrEmpty(txtBuscar.Text)) ? "" : txtBuscar.Text;
                List<Producto> lstProducto = new BusProducto().ListarProductos_Inactivos(buscar);

                gdvDatos.DataSource = lstProducto;

                gdvDatos.Columns[1].Visible = false;
                gdvDatos.Columns[2].Visible = false;
                gdvDatos.Columns[3].Visible = false;
                gdvDatos.Columns[4].Visible = false;
                gdvDatos.Columns[13].Visible = false;
                gdvDatos.Columns[14].Visible = false;
                gdvDatos.Columns[15].Visible = false;
                gdvDatos.Columns[16].Visible = false;
                gdvDatos.Columns[17].Visible = false;
                gdvDatos.Columns[18].Visible = false;
                gdvDatos.Columns[19].Visible = false;
                gdvDatos.Columns[20].Visible = false;
                gdvDatos.Columns[21].Visible = false;
         

                DataTablePersonalizado.Multilinea(ref gdvDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos : "+ ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int contador  = 0;
            foreach (DataGridViewRow dr in gdvDatos.Rows)
            {
                if (Convert.ToBoolean(dr.Cells[0].Value))
                {
                    int idProducto = Convert.ToInt32(dr.Cells[1].Value);
                    DatProducto.ActivarProducto(idProducto);
                    contador++;
                }
            }

            if (contador == 0)
            {
                MessageBox.Show("Es necesario seleccionar un producto ", "No hay datos seleccionados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Operación realizada con éxito \n Productos Actualizados :{contador}", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerDatos();
            }
        }
    }
}
