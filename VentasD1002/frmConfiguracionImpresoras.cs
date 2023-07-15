using BusVenta;
using BusVenta.Helpers;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmConfiguracionImpresoras : Form
    {
        public frmConfiguracionImpresoras()
        {
            InitializeComponent();
        }

        private void Obtenter_ImpresorasInstaladas()
        {
            try
            {
                comboBox2.Items.Clear();
                for (var i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                {
                    comboBox2.Items.Add(PrinterSettings.InstalledPrinters[i]);
                }
                comboBox2.Text = "--SELECCIONE--";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las impresoras : " + ex.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConfiguracionImpresoras_Load(object sender, EventArgs e)
        {
            Obtenter_ImpresorasInstaladas();
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!comboBox2.Text.Equals("--SELECCIONE--"))
                {
                    if (rbTicket.Checked == false && rbA4.Checked == false)
                    {
                        MessageBox.Show("Seleccione el tipo de impresion que desea asignar  a la impresra", "Datos no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Box b = new Box();
                        b.Id =  BusBox.showBoxBySerial().Id;

                        if (rbTicket.Checked == true)
                        {
                            b.ImpresoraTicket = comboBox2.Text;
                        }

                        if (rbA4.Checked == true)
                        {
                            b.ImpresoraA4 = comboBox2.Text;
                        }

                        new BusBox().Actualizar_ImpresoraTicket(b);
                        MessageBox.Show("Opreación Realizada", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una impresora", "Datos no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al configurar la impresora : " + ex.Message, "Error de configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
